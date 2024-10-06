import os
import json
import warnings

for root, _, files in os.walk("AssetBundles/"):
    if "luascript" in root:
        os.makedirs("LuaScript/" + os.path.basename(root), exist_ok=True)
        for file in files:
            if file.endswith(".json"):
                print(f"Decoding {file}...")
                textData = []
                with open(os.path.join(root, file), "r", encoding="utf-8") as f:
                    # read json file
                    data = json.load(f)
                    if "textData" in data:
                        textData = data["textData"]
                if len(textData) > 0:
                    with open(os.path.join("LuaScript/", os.path.basename(root), file.replace(".json", ".lua")), "w", encoding="utf-8") as f:
                        for i in range(len(textData)):
                            item = textData[i] ^ (0xa34 << (i & 3))
                            f.write(item.to_bytes(2, byteorder="little").decode("utf-16-le"))
                else:
                    warnings.warn(f"No textData found in {file}")
