import os
import sys
import UnityPy

def unpack_masterdata(asset_folder):
    for root, _, files in os.walk(asset_folder):
        for file in files:
            folder = os.path.basename(root)
            if 'masterdata' in folder:
                dest_folder = os.path.join("Masterdata/raw/", folder)
                if not os.path.exists(dest_folder):
                    os.makedirs(dest_folder)
                env = UnityPy.load(os.path.join(root, file))
                # iterate over internal objects
                for obj in env.objects:
                    # process specific object types
                    if obj.type.name == "TextAsset":
                        # export asset
                        data = obj.read()
                        with open(os.path.join(dest_folder, data.name), "wb") as f:
                            f.write(bytes(data.script))

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print("Usage: python 1_unpack_masterdata.py <asset_folder>")
        sys.exit(1)

    asset_folder = sys.argv[1]
    unpack_masterdata(asset_folder)
