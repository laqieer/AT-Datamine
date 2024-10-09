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
    StoryChapter[storyMainQuestSequence["chapter"]]["sequenceIDs"].append(storyMainQuestSequenceID)

with open("docs/story/chapter.html", "w", encoding="utf-8") as f:
    f.write("""<!DOCTYPE html>
<html>
<head>
    <title>Story Chapter</title>
    <link rel="icon" href="../imgs/common/favicon.ico" type="image/vnd.microsoft.icon">
</head>
<body>
    <h1>Story Chapter</h1>
""")
    for storyChapterID, storyChapter in sorted(StoryChapter.items(), key=lambda x: x[0]):
        f.write(f"""    <h2>{storyChapter["name"]} {storyChapter.get("storyScenarioQuestName", "")}</h2>\n""")
        if "bannerImage" in storyChapter:
            f.write(f"""    <img src="../imgs/ScenarioEvent/{storyChapter["bannerImage"]}" alt="{storyChapter["bannerImage"]}" width="680">""")
        routeID = None
        calendarId = None
        for sequenceId in storyChapter["sequenceIDs"]:
            storyMainQuestSequence = StoryMainQuestSequence[sequenceId]
            if 'routeID' in storyMainQuestSequence and routeID != storyMainQuestSequence['routeID']:
                routeID = storyMainQuestSequence['routeID']
                f.write(f"""    <h3>{StoryRoute[routeID]['name']}</h3>\n""")
            if calendarId != storyMainQuestSequence['calendarId']:
                calendarId = storyMainQuestSequence['calendarId']
                f.write(f"""    <h4>{StoryMainQuestCalendar[calendarId]['Name']}</h4>\n""")
            sequenceName = storyMainQuestSequence['SequenceName']
            advScene = storyMainQuestSequence["advScene"]
            if advScene > 0 and advScene in AdvDemoInfo and AdvDemoInfo[advScene]["existed"]:
                f.write(f"""    <li><a href="{advScene}.html">{sequenceName}</a></li>\n""")
            else:
                f.write(f"""    <li>{sequenceName}</li>\n""")
    f.write("""</body>
</html>
""")
