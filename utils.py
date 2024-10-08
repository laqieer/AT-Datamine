import json

def read_bytes(binary_file, count):
    if count == 0:
        return b''
    s = binary_file.read(count)
    if len(s) < count:
        raise EOFError
    return s

def read_json_file(file):
    with open(file, "r", encoding="utf-8") as f:
        return json.load(f)

def list_to_dict(lst, key="ID"):
    return {item[key]: item for item in lst}

def combine_dicts(*dicts):
    combined = {}
    for d in dicts:
        combined.update(d)
    return combined

def get_func_name(line):
    return line.split("(")[0].split(" ")[-1].strip()

def get_func_args(line):
    args = line.split("(")[1].split(")")[0].split(",")
    return [arg.strip().replace('"', '').replace("'", "") for arg in args]

def get_func_retval(line):
    if "=" not in line:
        return ""
    return line.split("=")[0].strip()
