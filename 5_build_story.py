import os
import re
import shutil
import warnings

from utils import *

repo_url = "https://github.com/laqieer/AT-Datamine"

game_name = "『アスタータタリクス』"

PlayerUnitIds = [
    "101003001", # Male 1
    "101004001", # Female 1
    "101005001", # Male 2
    "101006001", # Female 2
    "101007001", # Male 3
    "101008001", # Female 3
]

CharacterList = read_json_file("MasterData/masterdata_unit_character/Character.json")
CharacterDict = list_to_dict(CharacterList, "ID")

Faces = {}
Faces[""] = ""

def SetFace(styledCharaId):
    if styledCharaId == "playerId":
        styledCharaId = PlayerUnitIds[0]
    characterId = styledCharaId[:-3]
    if styledCharaId not in Faces:
        unitThumb = os.path.join("AssetBundles", f"content_chr_{characterId}_{styledCharaId}", f"{styledCharaId}_UnitThumb.png")
        if os.path.exists(unitThumb):
            shutil.copy(unitThumb, os.path.join("docs/imgs/UnitThumb/", f"{styledCharaId}.png"))
            Faces[styledCharaId] = f"""<img src="../imgs/UnitThumb/{styledCharaId}.png" alt="{styledCharaId}" height="110"><br>"""
        else:
            Faces[styledCharaId] = ""

def GetActors(lines, firstOnly=False):
    actors = {}
    for line in lines:
        if line.startswith("--") or "function" in line or "return" in line:
            continue
        if "(" in line and ")" in line:
            func_name = get_func_name(line)
            args = get_func_args(line)
            retval = get_func_retval(line)
            if func_name.lower().endswith("_preload"):
                continue
            match func_name:
                case func_name if func_name.startswith("InitializeCharacter"):
                    assert retval != ""
                    controllerId = retval
                    styledCharaId = ""
                    if len(args) > 1:
                        characterId = args[0]
                        styleId = args[1]
                        styledCharaId = characterId + styleId
                        SetFace(styledCharaId)
                    actors[controllerId] = styledCharaId
                case "InitializeActiveCharacter":
                    assert retval != ""
                    controllerId = retval
                    styledCharaId = ""
                    if len(args) > 2:
                        styledCharaId = args[2]
                        SetFace(styledCharaId)
                    actors[controllerId] = styledCharaId
                case "InitializePlayerCharacter":
                    assert retval != ""
                    controllerId = retval
                    styledCharaId = PlayerUnitIds[0]
                    actors[controllerId] = styledCharaId
                case "character2DFull" | "character2DMinimum":
                    if len(args) > 2:
                        controllerId = args[0]
                        styledCharaId = args[2]
                        SetFace(styledCharaId)
                        actors[controllerId] = styledCharaId
                case "character2DDefaultStyleFull" | "character2DDefaultStyleMinimum":
                    if len(args) > 1:
                        controllerId = args[0]
                        characterId = args[1]
                        styledCharaId = str(CharacterDict[characterId]["defaultStyleId"])
                        SetFace(styledCharaId)
                        actors[controllerId] = styledCharaId
                case "dot_reserve_ally" | "dot_reserve_enemy":
                    if len(args) > 0:
                        assert retval != ""
                        controllerId = retval
                        styledCharaId = args[0]
                        SetFace(styledCharaId)
                        actors[controllerId]= styledCharaId
        if firstOnly and len(actors) > 0:
            break
    return actors

def GetActorByStyle(lines, style):
    actor = GetActors(lines)
    for i in range(len(lines)):
        line = lines[i]
        if line.startswith("--"):
            continue
        if f"if style == {style}" in line:
            actor = GetActors(lines[i:], True)
            break
    return actor

def FindActorByController(actors, controllerId):
    actor = None
    if controllerId in actors:
        actor = actors[controllerId]
    if "dot" + controllerId in actors:
        actor = actors["dot" + controllerId]
    if "Dot" + controllerId in actors:
        actor = actors["Dot" + controllerId]
    if actor is None:
        raise ValueError(f"Controller not found: {controllerId}")
    if actor == "playerId":
        actor = PlayerUnitIds[0]
    return actor

FuncsInCommonPack = {}

CommonPacks = ("DemoCommonPack", "2dCommonPack", "DotCommonPack")

for pack in CommonPacks:
    with open(f"LuaScript/content_luascript_common/{pack}.lua", "r", encoding="utf-8") as f:
        func_name = ""
        decl_func_name = ""
        for line in f:
            if line.startswith("--"):
                continue
            if "(" in line and ")" in line:
                func_name = get_func_name(line)
                if "function" in line:
                    decl_func_name = func_name
                    FuncsInCommonPack[decl_func_name] = {
                        "lines": [],
                        "source": pack,
                    }
                elif decl_func_name in FuncsInCommonPack:
                    FuncsInCommonPack[decl_func_name]["lines"].append(line)

Texts = {}

os.makedirs("docs/story/", exist_ok=True)
os.makedirs("docs/imgs/UnitThumb/", exist_ok=True)
os.makedirs("docs/imgs/StillImage/", exist_ok=True)

for root, _, files in os.walk("Text/"):
    for file in files:
        print(f"Reading text from {root}/{file}...")
        with open(os.path.join(root, file), "r", encoding="utf-8") as f:
            isKey = True
            key = ""
            for line in f:
                if line == "\n":
                    isKey = True
                else:
                    line = line.strip()
                    if isKey:
                        if not line.startswith("VO_"):
                            key = line
                            Texts[key] = ""
                            isKey = False
                    else:
                        value = line
                        Texts[key] += value

Texts[""] = ""
Texts["Narrator"] = "(ナレーション)"
Texts["Select"] = "(選択肢)"

def BuildText(face, talkerNameTag, text, isMind):
    text = text.replace("\r\n", "<br>").replace("\r", "<br>").replace("\n", "<br>")
    # change <ruby=ooo>xxx</ruby> or <r=ooo>xxx</r> to <ruby>xxx<rp>(</rp><rt>ooo</rt><rp>)</rp></ruby>
    text = re.sub(r"<(ruby|r)=(.*?)>(.*?)</\1>", r"<ruby>\3<rp>(</rp><rt>\2</rt><rp>)</rp></ruby>", text)
    talkerName = Texts.get(talkerNameTag, talkerNameTag)
    if isMind:
        talkerName += " (心の声)"
    return f"""
        <tr>
            <td>{face}</td>
            <td>【{talkerName}】<br>{text}</td>
        </tr>
"""

AdvDemoInfoList = read_json_file("MasterData/masterdata_adv/AdvDemoInfo.json")
AdvDemoInfoDict = list_to_dict(AdvDemoInfoList, "ID")

for info in AdvDemoInfoList:
    lua_file = os.path.join("LuaScript", info["ScriptAssetbundle"], info["ScriptFilename"] + ".lua")
    print(f"Building story for {info['ID']} {info['Name']} from {lua_file}...")
    if not os.path.exists(lua_file):
        warnings.warn(f"Lua script not found: {lua_file}")
        continue
    with open(os.path.join("LuaScript", info["ScriptAssetbundle"], info["ScriptFilename"] + ".lua"), "r", encoding="utf-8") as f_in, open(
        os.path.join("docs/story", f"{info['ID']}.html"), "w", encoding="utf-8") as f_out:
        f_out.write(f"""<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>{info['ScriptFilename']}</title>
    <link rel="icon" href="../imgs/common/favicon.ico" type="image/vnd.microsoft.icon">
</head>
<body>
    <h1>{info['Name']}</h1>
    <p><b>{info['titleText']}</b></p>
    <p>{info['summaryText']}</p>
    <a href="{repo_url}/tree/main/LuaScript/{info["ScriptAssetbundle"]}/{info["ScriptFilename"]}.lua">View script in lua</a>
""")
        f_out.write("    <table>")
        lines = f_in.readlines()
        actors = GetActors(lines)
        for line in lines:
            if line.startswith("--"):
                continue
            if "(" in line and ")" in line:
                func_name = get_func_name(line)
                args = get_func_args(line)
                retval = get_func_retval(line)
                if func_name in FuncsInCommonPack and not func_name.lower().endswith("_preload"):
                    sub_funcs = FuncsInCommonPack[func_name]["lines"]
                    if len(retval) > 0:
                        sub_funcs = [l.replace("label", retval) for l in sub_funcs]
                    if FuncsInCommonPack[func_name]["source"] == "DemoCommonPack" and len(args) > 2:
                        style = args[2]
                        sub_actors = GetActorByStyle(sub_funcs, style)
                    else:
                        sub_actors = GetActors(sub_funcs)
                    actors = combine_dicts(actors, sub_actors)
        talkerNameTag = ""
        face = ""
        isMind = False
        for line in lines:
            if line.startswith("--"):
                continue
            if "::" in line or "function" in line:
                f_out.write(f"""
        <tr>
            <td colspan="2" style="text-align: center;">{get_func_name(line.strip().replace("::", ""))}</td>
        </tr>
""")
                continue
            if "(" in line and ")" in line:
                func_name = get_func_name(line)
                args = get_func_args(line)
                match func_name:
                    case "open_speech_window" | "open_mind_window" | "open_mind_talk_window":
                        if len(args) > 2:
                            isMind = "mind" in func_name
                            talkerNameTag = args[0]
                            controllerId = args[1]
                            if controllerId in ("nil", "ni"):
                                controllerId = args[2]
                            if controllerId not in ("nil", "ni"):
                                face = Faces[FindActorByController(actors, controllerId)]
                    case "open_speech_window_only3d" | "open_simple_window_only3d":
                        if len(args) > 1:
                            isMind = False
                            talkerNameTag = args[0]
                            controllerId = args[1]
                            if controllerId not in ("nil", "ni"):
                                face = Faces[FindActorByController(actors, controllerId)]
                    case "open_narration_window":
                        isMind = False
                        talkerNameTag = "Narrator"
                        face = ""
                    case "open_simple_window":
                        isMind = False
                        if len(args) > 1:
                            talkerNameTag = args[0]
                        face = ""
                    case "OpenTalkWindow":
                        if len(args) > 2:
                            talkerNameTag = args[0]
                            controllerId = args[1]
                            frameType = args[2]
                            isMind = frameType == "mind"
                            if frameType == "narration":
                                talkerNameTag = "Narrator"
                            face = Faces[FindActorByController(actors, controllerId)]
                    case "message" | "message_nowait":
                        if len(args) > 0:
                            textId = args[0]
                            text = Texts.get(textId, textId)
                            f_out.write(BuildText(face, talkerNameTag, text, isMind))
                    case "message_direct" | "message_direct_nowait":
                        if len(args) > 0:
                            text = args[0]
                            f_out.write(BuildText(face, talkerNameTag, text, isMind))
                    case "v_message" | "v_message_nowait":
                        if len(args) > 1:
                            textId = args[1]
                            text = Texts.get(textId, textId)
                            f_out.write(BuildText(face, talkerNameTag, text, isMind))
                    case "v_message_direct" | "v_message_direct_nowait":
                        if len(args) > 1:
                            text = args[1]
                            f_out.write(BuildText(face, talkerNameTag, text, isMind))
                    case func_name if func_name.startswith("Talk"):
                        if len(args) > 1:
                            controllerId = args[0]
                            talkerNameTag = args[1]
                            frameType = args[2]
                            isMind = frameType == "mind"
                            if frameType == "narration":
                                talkerNameTag = "Narrator"
                            textId = args[-1]
                            face = Faces[FindActorByController(actors, controllerId)]
                            text = Texts.get(textId, textId)
                            f_out.write(BuildText(face, talkerNameTag, text, isMind))
                    case func_name if func_name.startswith("open_select_window"):
                        isMind = False
                        controllerId = args[0]
                        face = Faces[FindActorByController(actors, controllerId)]
                        buttonTexts = args[2:]
                        talkerNameTag = "Select"
                        text = "<ol>"
                        for buttonText in buttonTexts:
                            if "_direct" in buttonText:
                                t = buttonText
                            else:
                                t = Texts.get(buttonText, buttonText)
                            text += f"<li>{t}</li>"
                        text += "</ol>"
                        f_out.write(BuildText(face, talkerNameTag, text, isMind))
                    case "load_image":
                        assetbundleName = args[1]
                        fileName = args[2]
                        dest = os.path.join("docs/imgs/StillImage/", fileName + ".png")
                        src = os.path.join("AssetBundles", assetbundleName, fileName + ".png")
                        if not os.path.exists(dest) and os.path.exists(src):
                            shutil.copy(src, dest)
                        if os.path.exists(dest):
                            url = f"../imgs/StillImage/{fileName}.png"
                            f_out.write(f"""
        <tr>
            <td colspan="2"><img src="{url}" alt="{fileName}" style="max-width:100%;"></td>
        </tr>
""")
        
        f_out.write("    </table>")

        f_out.write("""</body>
</html>
""")

print("Building index...")
with open("docs/story/index.html", "w", encoding="utf-8") as f:
    f.write(f"""<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>{game_name}ストーリー</title>
    <link rel="icon" href="../imgs/common/favicon.ico" type="image/vnd.microsoft.icon">
</head>
<body>
    <h1>Index</h1>
    <ul>
""")
    for info in AdvDemoInfoList:
        if os.path.exists(f"docs/story/{info['ID']}.html"):
            f.write(f"""        <li><a href="{info['ID']}.html">{info['ID']} {info['Name']} {info['titleText']} {info['summaryText']}</a></li>
""")
        else:
            f.write(f"""        <li>{info['ID']} {info['Name']} {info['titleText']} {info['summaryText']}</li>
""")
    f.write("""    </ul>
</body>
</html>
""")