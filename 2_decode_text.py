import os
import warnings

from utils import read_bytes

for root, _, files in os.walk("AssetBundles/"):
    if "text_" in root:
        os.makedirs("Text/" + os.path.basename(root), exist_ok=True)
        for file in files:
            if file.endswith(".text"):
                print(f"Decoding {file}...")
                with open(os.path.join(root, file), "rb") as f_raw, open(
                    os.path.join("Text/", os.path.basename(root), file.replace('.text', '.txt')), "w", encoding="utf-8") as f_txt:
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
                        while True:
                            length = int.from_bytes(read_bytes(f_raw, 4), 'little')
                            if length == 0:
                                f_txt.write('\n')
                                continue
                            f_txt.write(read_bytes(f_raw, length).decode('utf-16-le') + '\n')
                    except EOFError:
                        pass
