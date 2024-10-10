import os
import utils

AdvDemoInfo = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_adv/AdvDemoInfo.json"))

for advDemoInfoID, advDemoInfo in AdvDemoInfo.items():
    advDemoInfo["existed"] = os.path.exists(os.path.join("docs/story/", f"{advDemoInfoID}.html"))

StoryChapter = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story/StoryChapter.json"))
StoryScenarioQuest = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story/StoryScenarioQuest.json"))
StoryRoute = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story/StoryRoute.json"))
StoryMainQuestSequenceRoute = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story/StoryMainQuestSequenceRoute.json"))

StoryMainQuestSequence = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story_mainquest/StoryMainQuestSequence.json"))
StoryMainQuestCalendar = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story_mainquest/StoryMainQuestCalendar.json"))

BattleAdv = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_battle_adv/BattleAdv.json"))

AreaQuestArea = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_quest/AreaQuestArea.json"))
AreaQuestAreaGroup = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_quest/AreaQuestAreaGroup.json"))
AreaQuestAreaNode = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_quest/AreaQuestAreaNode.json"))
QuestStage = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_quest/QuestStage.json"))

QuestBattleAdv = {}
QuestSequence = {}

for battleAdvID, battleAdv in BattleAdv.items():
    if battleAdv['questID'] not in QuestBattleAdv:
        QuestBattleAdv[battleAdv['questID']] = {'battleAdvIDs': []}
    QuestBattleAdv[battleAdv['questID']]['battleAdvIDs'].append(battleAdvID)

for storyScenarioQuestID, storyScenarioQuest in StoryScenarioQuest.items():
    StoryChapter[storyScenarioQuest["chapterID"]]["storyScenarioQuestName"] = storyScenarioQuest["name"]
    bannerID = storyScenarioQuest["bannerID"]
    bannerImage = f"rawdata_image_scenarioevent_{bannerID}_top_{bannerID}_eventtop.png"
    if os.path.exists(os.path.join("docs/imgs/ScenarioEvent/", bannerImage)):
        StoryChapter[storyScenarioQuest["chapterID"]]["bannerImage"] = bannerImage

StoryChapter[11]["storyScenarioQuestName"] = "アカシャ年代記【宵闇の痕跡】"
StoryChapter[13]["storyScenarioQuestName"] = "アカシャ年代記【翠風の痕跡】"
StoryChapter[14]["storyScenarioQuestName"] = "アカシャ年代記【轟雷の痕跡】"
StoryChapter[16]["storyScenarioQuestName"] = "アカシャ年代記【烈火の痕跡】"
StoryChapter[19]["storyScenarioQuestName"] = "アカシャ年代記【蒼氷の痕跡】"

StoryChapter[6]["bannerImage"] = "バナー.webp"
StoryChapter[8]["bannerImage"] = "バナー_初星ハルモニア.webp"
StoryChapter[11]["bannerImage"] = "バナー闇.png.webp"
StoryChapter[13]["bannerImage"] = "バナー風.png.webp"
StoryChapter[14]["bannerImage"] = "バナー雷.png.webp"
StoryChapter[16]["bannerImage"] = "バナー火.png.webp"
StoryChapter[19]["bannerImage"] = "バナー氷.png.webp"

for storyMainQuestSequenceRoute in StoryMainQuestSequenceRoute.values():
    StoryMainQuestSequence[storyMainQuestSequenceRoute["sequenceID"]]["routeID"] = storyMainQuestSequenceRoute["routeID"]

for storyChapter in StoryChapter.values():
    storyChapter["sequenceIDs"] = []

for storyMainQuestSequenceID, storyMainQuestSequence in StoryMainQuestSequence.items():
    questID = storyMainQuestSequence['questID']
    if questID > 0:
        assert questID not in QuestSequence, f"Duplicated questID {questID}"
        QuestSequence[questID] = storyMainQuestSequenceID
    StoryChapter[storyMainQuestSequence["chapter"]]["sequenceIDs"].append(storyMainQuestSequenceID)

for areaQuestAreaGroup in AreaQuestAreaGroup.values():
    areaQuestAreaGroup["areaQuestAreaIDs"] = []

for areaQuestAreaID, areaQuestArea in AreaQuestArea.items():
    areaQuestArea['areaQuestAreaNodeIDs'] = [] 
    AreaQuestAreaGroup[areaQuestArea["areaGroupId"]]["areaQuestAreaIDs"].append(areaQuestAreaID)

for areaQuestAreaNodeID, areaQuestAreaNode in AreaQuestAreaNode.items():
    AreaQuestArea[areaQuestAreaNode['areaId']]['areaQuestAreaNodeIDs'].append(areaQuestAreaNodeID)

with open("docs/story/quest.html", "w", encoding="utf-8") as f:
    f.write("""<!DOCTYPE html>
<html>
<head>
    <title>Main Quest</title>
    <link rel="icon" href="../imgs/common/favicon.ico" type="image/vnd.microsoft.icon">
</head>
<body>
    <script type="module">
        import mermaid from 'https://cdn.jsdelivr.net/npm/mermaid@11/dist/mermaid.esm.min.mjs';
    </script>
    <h1>Main Quest (メインクエスト)</h1>
""")
    for areaQuestAreaGroup in sorted(AreaQuestAreaGroup.values(), key=lambda x: x['areaGroupType']):
        f.write(f"""    <h2>{areaQuestAreaGroup['refName']}</h2>\n""")
        for areaQuestAreaID in sorted(areaQuestAreaGroup['areaQuestAreaIDs']):
            areaQuestArea = AreaQuestArea[areaQuestAreaID]
            f.write(f"""    <h3>{areaQuestArea['refName']}</h3>\n""")
            f.write(f"""    <pre class="mermaid">
        graph LR\n""")
            for areaQuestAreaNodeID in areaQuestArea['areaQuestAreaNodeIDs']:
                areaQuestAreaNode = AreaQuestAreaNode[areaQuestAreaNodeID]
                f.write(f"""            node{areaQuestAreaNodeID}{{{areaQuestAreaNode['refName']}}}\n""")
                if areaQuestAreaNodeID in QuestSequence:
                    f.write(f"""            click node{areaQuestAreaNodeID} "#{QuestSequence[areaQuestAreaNodeID]}"\n""")
            for areaQuestAreaNodeID in areaQuestArea['areaQuestAreaNodeIDs']:
                areaQuestAreaNode = AreaQuestAreaNode[areaQuestAreaNodeID]
                for i in range(5):
                    nextNodeId = areaQuestAreaNode[f'nextNodeId{i + 1}']
                    if nextNodeId > 0:
                        f.write(f"""            node{areaQuestAreaNodeID} --> node{nextNodeId}\n""")
            f.write(f"""    </pre>\n""")
    for storyChapterID, storyChapter in sorted(StoryChapter.items(), key=lambda x: x[0]):
        f.write(f"""    <h2>{storyChapter["name"]} {storyChapter.get("storyScenarioQuestName", "")}</h2>\n""")
        if "bannerImage" in storyChapter:
            f.write(f"""    <img src="../imgs/ScenarioEvent/{storyChapter["bannerImage"]}" alt="{storyChapter["bannerImage"]}" width="680">""")
        routeID = None
        calendarId = None
        for sequenceId in sorted(storyChapter["sequenceIDs"]):
            storyMainQuestSequence = StoryMainQuestSequence[sequenceId]
            if 'routeID' in storyMainQuestSequence and routeID != storyMainQuestSequence['routeID']:
                routeID = storyMainQuestSequence['routeID']
                f.write(f"""    <h3>{StoryRoute[routeID]['name']}</h3>\n""")
            if calendarId != storyMainQuestSequence['calendarId']:
                calendarId = storyMainQuestSequence['calendarId']
                f.write(f"""    <h4>{StoryMainQuestCalendar[calendarId]['Name']}</h4>\n""")
            sequenceName = storyMainQuestSequence['SequenceName']
            f.write(f"""    <h5 id="{sequenceId}">{sequenceName}</h5>\n""")
            advIDs = []
            advScene = storyMainQuestSequence["advScene"]
            if advScene > 0:
                advIDs.append(advScene)
            questID = storyMainQuestSequence["questID"]
            if questID > 0 and questID in QuestBattleAdv:
                advIDs += [BattleAdv[x]['advID'] for x in sorted(QuestBattleAdv[questID]['battleAdvIDs'])]
            for advID in advIDs:
                if advID > 0 and advID in AdvDemoInfo:
                    info = AdvDemoInfo[advID]
                    text = f"{info['ID']} {info['Name']} {info['titleText']} {info['summaryText']}"
                    if info["existed"]:
                        f.write(f"""    <li><a href="{advID}.html">{text}</a></li>\n""")
                    else:
                        f.write(f"""    <li>{text}</li>\n""")
    f.write("""</body>
</html>
""")
