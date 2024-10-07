import os
import warnings

from utils import read_bytes

for root, _, files in os.walk("AssetBundles/"):
    if "text_" in root:
        dest_folder = os.path.join("Text/", os.path.basename(root))
        os.makedirs(dest_folder, exist_ok=True)
        for file in files:
            if file.endswith(".text"):
                print(f"Decoding {root}/{file}...")
                with open(os.path.join(root, file), "rb") as f_raw, open(
                    os.path.join(dest_folder, file.replace('.text', '.txt')), "w", encoding="utf-8") as f_txt:
                    f_raw.seek(0xb)
                    version = int.from_bytes(f_raw.read(1), 'little')
                    match version:
                        case 2:
                            f_raw.seek(0x2d)
                        case 3:
                            f_raw.seek(0x3a)
                        case _:
                            warnings.warn(f"Unknown version {version} for {file}")
                            continue
                    try:
                        isKey = True
                        while True:
                            length = int.from_bytes(read_bytes(f_raw, 4), 'little')
                            if length == 0:
                                if not isKey:
                                    f_txt.write('\n')
                                    isKey = not isKey
                            else:
                                s = read_bytes(f_raw, length).decode('utf-16-le').replace("\r", "\\r").replace("\n", "\\n")
                                f_txt.write(s + '\n')
                                if not isKey:
                                    f_txt.write('\n')
                                    isKey = not isKey
                                elif not s.startswith("VO_"):
                                    isKey = not isKey
                    except EOFError:
                        pass
