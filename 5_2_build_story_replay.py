import os
import utils

AdvDemoInfo = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_adv/AdvDemoInfo.json"))

for advDemoInfoID, advDemoInfo in AdvDemoInfo.items():
    advDemoInfo["existed"] = os.path.exists(os.path.join("docs/story/", f"{advDemoInfoID}.html"))

StoryReplay = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story_mainquest/StoryReplay.json"))
StoryReplayEntry = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story_mainquest/StoryReplayEntry.json"))
StoryReplayEntryDescription = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story_mainquest/StoryReplayEntryDescription.json"))
StoryMainQuestYearText = utils.list_to_dict(utils.read_json_file("MasterData/masterdata_story_mainquest/StoryMainQuestYearText.json"))

# Refer to: Assembly-CSharp\GameCore\MasterData\dayOfWeekTypeEnum.cs & Assembly-CSharp\GameCore\MasterData\DayofweekEnum.cs
DayOfWeekText = ["", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日", "日曜日"]

def getMonthText(storyReplayEntry):
    year = 1001
    # Refer to: Assembly-CSharp\GameCore\MasterData\StoryReplayMonthTypeEnum.cs
    month = storyReplayEntry["storyReplayMonthType"] + 4
    if month > 12:
        month -= 12
        year += 1
    return f"{StoryMainQuestYearText[year]['Text']}{month}月"

def getDayText(storyReplayEntry):
    dayNumber = storyReplayEntry["dayNumber"]
    dayOfWeek = storyReplayEntry["dayOfWeek"]
    return f"{dayNumber}日({DayOfWeekText[dayOfWeek]})"

for storyReplay in StoryReplay.values():
    storyReplay["storyReplayEntryIds"] = []

for storyReplayEntryId, storyReplayEntry in StoryReplayEntry.items():
    storyReplayEntry["storyReplayEntryDescriptionIds"] = []
    StoryReplay[storyReplayEntry['storyReplay']]["storyReplayEntryIds"].append(storyReplayEntryId)

for storyReplayEntryDescriptionId, storyReplayEntryDescription in StoryReplayEntryDescription.items():
    StoryReplayEntry[storyReplayEntryDescription['storyReplayEntry']]["storyReplayEntryDescriptionIds"].append(storyReplayEntryDescriptionId)

with open("docs/story/replay.html", "w", encoding="utf-8") as f:
    f.write("""<!DOCTYPE html>
<html>
<head>
    <title>Story Replay</title>
    <link rel="icon" href="../imgs/common/favicon.ico" type="image/vnd.microsoft.icon">
</head>
<body>
    <h1>Story Replay</h1>
""")
    for storyReplayID, storyReplay in sorted(StoryReplay.items(), key=lambda x: x[0]):
        f.write(f"""    <h2>{storyReplay["name"]}</h2>\n""")
        monthText = None
        for storyReplayEntryID in storyReplay["storyReplayEntryIds"]:
            storyReplayEntry = StoryReplayEntry[storyReplayEntryID]
            if monthText != getMonthText(storyReplayEntry):
                monthText = getMonthText(storyReplayEntry)
                f.write(f"""    <h3>{monthText}</h3>\n""")
            f.write(f"""    <h4>{getDayText(storyReplayEntry)} {storyReplayEntry['name']}</h4>\n""")
            for storyReplayEntryDescriptionID in storyReplayEntry["storyReplayEntryDescriptionIds"]:
                storyReplayEntryDescription = StoryReplayEntryDescription[storyReplayEntryDescriptionID]
                name = storyReplayEntryDescription["name"]
                advId = storyReplayEntryDescription["advId"]
                if advId is not None and advId in AdvDemoInfo and AdvDemoInfo[advId]["existed"]:
                    f.write(f"""    <li><a href="{advId}.html">{name}</a></li>\n""")
                else:
                    f.write(f"""    <li>{name}</li>\n""")
    f.write("""</body>
</html>
""")