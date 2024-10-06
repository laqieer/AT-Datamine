
-- カットインファイルのロード
CutinPattern001 = system.LoadUIToRoot("content_effect_adv_ui_cutin_prefab", "ADV_CutIn_Pattern_001")
UiLoadList[#UiLoadList + 1] = CutinPattern001

CutinPattern002 = system.LoadUIToRoot("content_effect_adv_ui_cutin_prefab", "ADV_CutIn_Pattern_002")
UiLoadList[#UiLoadList + 1] = CutinPattern002

CutinPattern003 = system.LoadUIToRoot("content_effect_adv_ui_cutin_prefab", "ADV_CutIn_Pattern_003")
UiLoadList[#UiLoadList + 1] = CutinPattern003

-- エフェクトファイルのロード
Cutin_ADB_Eff_Base_Back_1 = system.LoadStackObject("Cutin_ADB_Eff_Base_Back_1", "content_effect_adv_ui_cutin_effect_adb_eff_base_back", "ADB_Eff_Base_Back_1")
UiAssetLoadList[#UiAssetLoadList + 1] = Cutin_ADB_Eff_Base_Back_1
Cutin_ADB_Eff_Base_Back_2 = system.LoadStackObject("Cutin_ADB_Eff_Base_Back_2", "content_effect_adv_ui_cutin_effect_adb_eff_base_back", "ADB_Eff_Base_Back_2")
UiAssetLoadList[#UiAssetLoadList + 1] = Cutin_ADB_Eff_Base_Back_2
Cutin_ADB_Eff_ConcentratedLine_Front_1 = system.LoadStackObject("Cutin_ADB_Eff_ConcentratedLine_Front_1", "content_effect_adv_ui_cutin_effect_adb_eff_concentratedline", "ADB_Eff_ConcentratedLine_Front_1")
UiAssetLoadList[#UiAssetLoadList + 1] = Cutin_ADB_Eff_ConcentratedLine_Front_1
Cutin_ADB_Eff_ConcentratedLine_Front_2 = system.LoadStackObject("Cutin_ADB_Eff_ConcentratedLine_Front_2", "content_effect_adv_ui_cutin_effect_adb_eff_concentratedline", "ADB_Eff_ConcentratedLine_Front_2")
UiAssetLoadList[#UiAssetLoadList + 1] = Cutin_ADB_Eff_ConcentratedLine_Front_2
Cutin_ADB_Eff_ConcentratedLine_Front_3 = system.LoadStackObject("Cutin_ADB_Eff_ConcentratedLine_Front_3", "content_effect_adv_ui_cutin_effect_adb_eff_concentratedline", "ADB_Eff_ConcentratedLine_Front_3")
UiAssetLoadList[#UiAssetLoadList + 1] = Cutin_ADB_Eff_ConcentratedLine_Front_3


-- カットインを開く
-- patternID カットインパターンに指定　1 = 一人　2 = 二人 3 = 三人
-- effectID エフェクトパターンの制定　1 = 通常 2 = 集中線 3 = なし
function open_cutin(patternID, effectID)
    local cutinObj = nil
    local attachBaseEffectTag = nil
    local attachConcentratedLineEffectTag = nil

    CutinPattern001.SetActive(false)
    CutinPattern002.SetActive(false)
    CutinPattern003.SetActive(false)

    if patternID == 1 then
        cutinObj = CutinPattern001
        attachBaseEffectTag = "Cutin_ADB_Eff_Base_Back_1"
        attachConcentratedLineEffectTag = "Cutin_ADB_Eff_ConcentratedLine_Front_1"
    elseif patternID == 2 then
        cutinObj = CutinPattern002
        attachBaseEffectTag = "Cutin_ADB_Eff_Base_Back_2"
        attachConcentratedLineEffectTag = "Cutin_ADB_Eff_ConcentratedLine_Front_2"
    elseif patternID == 3 then
        cutinObj = CutinPattern003
        attachBaseEffectTag = "Cutin_ADB_Eff_Base_Back_2"
        attachConcentratedLineEffectTag = "Cutin_ADB_Eff_ConcentratedLine_Front_3"
    end

    if cutinObj != nil then
        cutinObj.SetActive(true)
        cutinObj.DeattachStackObject("CutinBackRoot")
        cutinObj.DeattachStackObject("CutinFrontRoot")
        if effectID == 1 then
            cutinObj.AttachStackObject("CutinBackRoot", attachBaseEffectTag)
        elseif effectID == 2 then
            cutinObj.AttachStackObject("CutinFrontRoot", attachConcentratedLineEffectTag)
        end
        cutinObj.SetActive("TimelineController", true)
        openSignal = cutinObj.PlayUITimelineControllerInAnimation("TimelineController")

        if patternID >= 1 then
            cutinObj.SetActive("CutinChara1TimelineController", false)
        end
        if patternID >= 2 then
            cutinObj.SetActive("CutinChara2TimelineController", false)
        end
        if patternID >= 3 then
            cutinObj.SetActive("CutinChara3TimelineController", false)
        end
    end
end

-- カットインの表示
-- pos = 表示位置の指定 1～3 で左から順に並ぶ
-- character = カットインに出すキャラクターのコントロールID
-- facialTag = カットインに出すキャラクターの表情
-- mouthOpen = カットインに出すキャラクターが口をあけているか？　nilか指定なしの場合はあけている状態
function on_cutin(pos, character, facialTag, mouthOpen)
    local partTag = "CutinChara"..pos
    local partTimelineTag = "CutinChara"..pos.."TimelineController"
    local partCanvasGroupTag = "CutinChara"..pos.."CanvasGroup"
    local isMouthOpen = true
    local cutinObj = nil
    if CutinPattern001.GetActive() then
        cutinObj = CutinPattern001
    elseif CutinPattern002.GetActive() then
        cutinObj = CutinPattern002
    elseif CutinPattern003.GetActive() then
        cutinObj = CutinPattern003
    end

    if mouthOpen != nil and type(mouthOpen) == "boolean" then
        isMouthOpen = mouthOpen
    end
    if CutinPattern001.GetActive() and pos <= 1 then
        local opened = play_on_cutin(CutinPattern001, partTimelineTag)
        CutinPattern001.SetCanvasGroupAlpha(partCanvasGroupTag, 1)
        CutinPattern001.SetCutinCharacterImage(partTag, character.FaceImageTag, FacialTags[facialTag], isMouthOpen, character, opened)
    end
    if CutinPattern002.GetActive() and pos <= 2 then
        local opened = play_on_cutin(CutinPattern002, partTimelineTag)
        CutinPattern002.SetCanvasGroupAlpha(partCanvasGroupTag, 1)
        CutinPattern002.SetCutinCharacterImage(partTag, character.FaceImageTag, FacialTags[facialTag], isMouthOpen, character, opened)
    end
    if CutinPattern003.GetActive() and pos <= 3 then
        local opened = play_on_cutin(CutinPattern003, partTimelineTag)
        CutinPattern003.SetCanvasGroupAlpha(partCanvasGroupTag, 1)
        CutinPattern003.SetCutinCharacterImage(partTag, character.FaceImageTag, FacialTags[facialTag], isMouthOpen, character, opened)
    end
    change_face(character, facialTag)
end

-- カットインのアニメーション開始
function play_on_cutin(cutinObj, partTag)
    local opened = true
    if not(cutinObj.GetActive(partTag)) then
        cutinObj.SetActive(partTag, true)
        cutinObj.PlayUITimelineControllerInAnimation(partTag)
        opened = false
    end
    return opened
end

-- カットインを消去
-- pos = 表示位置の指定 1～3 で左から順に並ぶ
function off_cutin(pos)
    local partTag = "CutinChara"..pos.."TimelineController"

    if CutinPattern001.GetActive() and pos <= 1 then
        if CutinPattern001.GetActive(partTag) then
            CutinPattern001.PlayUITimelineControllerOutAnimation(partTag, false)
        end
    end
    if CutinPattern002.GetActive() and pos <= 2 then
        if CutinPattern002.GetActive(partTag) then
            CutinPattern002.PlayUITimelineControllerOutAnimation(partTag, false)
        end
    end
    if CutinPattern003.GetActive() and pos <= 3 then
        if CutinPattern003.GetActive(partTag) then
            CutinPattern003.PlayUITimelineControllerOutAnimation(partTag, false)
        end
    end
end

-- カットインを閉じる
function close_cutin()
    if CutinPattern001.GetActive() then
        CutinPattern001.PlayUITimelineControllerOutAnimation("TimelineController", false)
        off_cutin(1)
    elseif CutinPattern002.GetActive() then
        CutinPattern002.PlayUITimelineControllerOutAnimation("TimelineController", false)
        off_cutin(1)
        off_cutin(2)
    elseif CutinPattern003.GetActive() then
        CutinPattern003.PlayUITimelineControllerOutAnimation("TimelineController", false)
        off_cutin(1)
        off_cutin(2)
        off_cutin(3)
    end
end

-- カットインアニメーション再生待ち
function wait_cutin_animation()
    if CutinPattern001.GetActive() then
        signal = CutinPattern001
    elseif CutinPattern002.GetActive() then
        signal = CutinPattern002
    elseif CutinPattern003.GetActive() then
        signal = CutinPattern003
    end

    if signal != nil then
        while signal.IsProccessing() do
		    coroutine.yield()
	    end
    end
end
