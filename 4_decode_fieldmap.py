import os
import shutil

for root, _, files in os.walk("AssetBundles/"):
    if "field_" in root and "_map" in root:
        dest_folder = os.path.join("FieldMap/", os.path.basename(root))
        os.makedirs(dest_folder, exist_ok=True)
        for file in files:
            if "." not in file:
                print(f"Decoding {file}...")
                shutil.copy(os.path.join(root, file), os.path.join(dest_folder, file + '.yml'))
