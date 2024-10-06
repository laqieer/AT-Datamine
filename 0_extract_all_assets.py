import os
import sys
import json
import shutil
import warnings
import UnityPy

def unpack_all_assets(source_folder : str, destination_folder : str):
    # iterate over all files in source folder
    for root, dirs, files in os.walk(source_folder):
        for file_name in files:
            # generate file_path
            file_path = os.path.join(root, file_name)
            if file_name.endswith(".mp4"):
                # Copy video file
                shutil.copy(file_path, os.path.join(destination_folder, root.split("\\")[-1] + ".mp4"))
                continue
            # load that file via UnityPy.load
            env = UnityPy.load(file_path)

            # iterate over internal objects
            for obj in env.objects:
                if obj.type.name not in ("Texture2D", "Sprite", "Texture2DArray", "TextAsset", "MonoBehaviour", "AudioClip", "Font", "Mesh"):
                    continue
                try:
                    # parse the object data
                    data = obj.read()
                    if not hasattr(data, "m_Name"):
                        warnings.warn(f"Object {obj.type.name} {data} in {file_path} has no name")
                        continue
                    # print(f"Exporting {obj.type.name} {data.m_Name} from {file_path}")
                    # create destination path
                    dest = os.path.join(destination_folder, root.split("\\")[-1], data.m_Name.replace("(Clone)", "")).replace("|", "_")
                    # make sure that the dir of that path exists
                    os.makedirs(os.path.dirname(dest), exist_ok = True)
                    # process specific object types
                    match obj.type.name:
                        case "Texture2D" | "Sprite":
                            # make sure that the extension is correct
                            # you probably only want to do so with images/textures
                            dest, ext = os.path.splitext(dest)
                            dest = dest + ".png"

                            img = data.image
                            img.save(dest)

                        case "Texture2DArray":
                            dest, ext = os.path.splitext(dest)
                            for i, image in enumerate(data.images):
                                image.save(f"{dest}_{i}.png")
                        
                        case "TextAsset":
                            with open(dest, "wb") as f:
                                f.write(bytes(data.script))

                        case "MonoBehaviour":
                            # save decoded data
                            tree = obj.read_typetree()
                            if not obj.serialized_type.nodes:
                                warnings.warn(f"No nodes found in MonoBehaviour {data.m_Name} in {file_path}")
                            dest, ext = os.path.splitext(dest)
                            dest = dest + ".json"
                            with open(dest, "wt", encoding = "utf8") as f:
                                json.dump(tree, f, ensure_ascii = False, indent = 4)

                        case "AudioClip":
                            os.makedirs(dest, exist_ok = True)
                            for name, d in data.samples.items():
                                if not name.endswith(".wav"):
                                    name = name + ".wav"
                                with open(os.path.join(dest, name), "wb") as f:
                                    f.write(d)

                        case "Font":
                            dest, ext = os.path.splitext(dest)
                            if not data.m_FontData:
                                warnings.warn(f"No data found in Font {data.m_Name} in {file_path}")
                            ext = ".ttf"
                            if data.m_FontData[0:4] == b"OTTO":
                                ext = ".otf"
                            dest = dest + ext
                            with open(dest, "wb") as f:
                                f.write(data.m_FontData)

                        case "Mesh":
                            dest, ext = os.path.splitext(dest)
                            dest = dest + ".obj"
                            with open(dest, "wt", newline = "") as f:
                                # newline = "" is important
                                f.write(data.export())

                        case "Renderer" | "MeshRenderer" | "SkinnedMeshRenderer":
                            os.makedirs(dest, exist_ok = True)
                            game_object = data.m_GameObject.read()
                            data.export(os.path.join(dest, game_object.m_Name))

                        case _:
                            warnings.warn(f"Unhandled type {obj.type.name} in {file_path}")
                    
                except Exception as e:
                    warnings.warn(f"Failed to parse {obj.type.name} {data} in {file_path}: {e}")
                    continue

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print("Usage: python 0_extract_all_assets.py <asset_folder>")
        sys.exit(1)

    asset_folder = sys.argv[1]
    unpack_all_assets(asset_folder, "AssetBundles")
