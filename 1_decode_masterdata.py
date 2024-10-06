import os
import re
import json
import struct
import warnings

from utils import read_bytes

raw_folder = 'AssetBundles/'
json_folder = 'MasterData/'
code_folder = 'Assembly-CSharp/GameCore/MasterData/'

raw_files = {}
decode_info = {}

string_enum_fields = {
    "AdvExpandedLockVariable": [
        "variableKind",
    ],
    "AdvLockOne": [
        "VariableKind",
        "ComparisonType",
    ],
    "AdvOptionOne": [
        "VariableKind"
    ],
    "AdvVariables": [
        "VariableKind",
    ],
    "AdvVariableType": [
        "AdvVariableType",
    ],
    "ButtonClickSE": [
        "ButtonClickSEType",
    ],
    "ButtonLongPressSE": [
        "ButtonLongPressSEType",
    ],
    "StoryAdvType": [
        "AdvType",
    ],
    "StoryMainQuestSequenceConditionType": [
        "StorySequenceConditionType",
    ],
    "StorySubquestTaskType": [
        "StorySubquestTaskType",
    ],
}

def get_serializable_fields(code_file_path):
    data_name = ''
    serializable_fields = []
    
    with open(code_file_path, 'r', encoding='utf-8') as code_file:
        lines = code_file.readlines()
        for i in range(len(lines)):
            line = lines[i].strip()
            if line == "[Serializable]":
                # extract class name from next line by regex
                data_name = re.search(r'public sealed class (.*)Data :', lines[i + 1]).group(1)
            elif line == "[SerializeField]":
                _, field_type, field_name = lines[i + 1].strip()[:-1].split(' ')
                serializable_fields.append([field_type, field_name])

    return data_name, serializable_fields

def scan_code():
    for root, _, files in os.walk(code_folder):
        for file in files:
            if file.endswith('Data.cs'):
                print(f'Scanning {file}...')
                data_name, serializable_fields = get_serializable_fields(os.path.join(root, file))
                if not data_name or not serializable_fields:
                    continue
                assert data_name in file and data_name not in decode_info
                decode_info[data_name] = serializable_fields

def decode(data_name):
    binary_file_path = raw_files[data_name.lower()]
    json_file_path = os.path.join(json_folder, os.path.basename(os.path.dirname(binary_file_path)), data_name + '.json')
    serializable_fields = decode_info[data_name]

    if not os.path.exists(binary_file_path):
        raise FileNotFoundError
    
    if not serializable_fields:
        raise ValueError

    decoded_data = []

    with open(binary_file_path, 'rb') as binary_file:
        # read 4 bytes as int32 for data count
        data_count = int.from_bytes(read_bytes(binary_file, 4), 'little')
        assert data_count >= 0
        for i in range(data_count):
            data = {}
            for field in serializable_fields:
                # Perform reading logic here
                field_type, field_name = field
                if field_type in ('string', 'DateTime') or field_name in string_enum_fields.get(data_name, []):
                    # decode utf-16 le string with length at the start
                    data[field_name] = read_bytes(binary_file, int.from_bytes(read_bytes(binary_file, 4), 'little')).decode('utf-16-le')
                elif field_type == 'int' or field_type.endswith('Enum'):
                    data[field_name] = int.from_bytes(read_bytes(binary_file, 4), 'little')
                elif field_type == 'float':
                    data[field_name] = struct.unpack('<f', read_bytes(binary_file, 4))[0]
                elif field_type == 'bool':
                    data[field_name] = bool.from_bytes(read_bytes(binary_file, 1), 'little')
                elif field_type == 'int[]':
                    data[field_name] = [int.from_bytes(read_bytes(binary_file, 4), 'little') for _ in range(int.from_bytes(read_bytes(binary_file, 4), 'little'))]
                elif field_type == 'float[]':
                    data[field_name] = [struct.unpack('<f', read_bytes(binary_file, 4))[0] for _ in range(int.from_bytes(read_bytes(binary_file, 4), 'little'))]
                elif field_type == 'bool[]':
                    data[field_name] = [bool.from_bytes(read_bytes(binary_file, 1), 'little') for _ in range(int.from_bytes(read_bytes(binary_file, 4), 'little'))]
                else:
                    raise NotImplementedError
            decoded_data.append(data)

        if binary_file.read(1):
            raise EOFError

    os.makedirs(os.path.dirname(json_file_path), exist_ok=True)
    with open(json_file_path, 'w', encoding="utf-8") as json_file:
        json.dump(decoded_data, json_file, indent=4, ensure_ascii=False)

def decode_masterdata():
    for data_name in decode_info:
        print(f'Decoding {data_name}...')
        try:
            decode(data_name)
        except Exception as e:
            warnings.warn(f'Failed to decode {data_name}: {e}')

def scan_masterdata():
    for root, _, files in os.walk(raw_folder):
        if 'masterdata' in root:
            for file in files:
                if '.' not in file:
                    raw_files[file] = os.path.join(root, file)

if __name__ == '__main__':
    scan_code()
    scan_masterdata()
    decode_masterdata()
