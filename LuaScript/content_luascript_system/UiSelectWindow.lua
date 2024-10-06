
SelectBox = system.LoadUIToRoot("ui_page_adv_selectbox", "Container_SelectBox_main")
UiLoadList[#UiLoadList + 1] = SelectBox

OptionLock = system.LoadUIToFront("ui_page_adv_selectbox", "Container_LookCondition", 801)
UiLoadList[#UiLoadList + 1] = OptionLock
-- UiIdlingList[#UiLoadList + 1] = OptionLock

-- 選択肢を開く
--  cutCharacter = カットインのキャラクター　※character2DでfacePrefabPath指定必須
--  facial3dTag = カットインキャラクターの表情のタグ
--  buttonText1 = １番目のボタンに表示するテキストのタグ
--  buttonText2 = ２番目のボタンに表示するテキストのタグ
--  buttonText3 = ３番目のボタンに表示するテキストのタグ
--  buttonText4 = ４番目のボタンに表示するテキストのタグ
--  buttonText5 = ５番目のボタンに表示するテキストのタグ
--  choice_button = ボタンにテキストを登録する関数
function open_select_window_base(cutCharacter, facial3dTag, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10, choice_button, is_select_option)
	-- 初期化
	end_foward_from_select()
	close_footer_ui()
	system.SetDefaultPlaySpeed(true)
	local inputList = {}
	local openList = {}
	local closeList = {}
	local textTagList = {}
	
	-- 選択肢ログ記録用
	local stringList = {}
	
	if cutCharacter != nil then
		SelectBox.AttachCharacterImage("CharacterImage", cutCharacter.FaceImageTag, FacialTags[facial3dTag], cutCharacter, true, -1.0)
	end
	stringList[1] = choice_button(inputList, openList, closeList, textTagList, "Button1", buttonText1)
	stringList[2] = choice_button(inputList, openList, closeList, textTagList, "Button2", buttonText2)
	stringList[3] = choice_button(inputList, openList, closeList, textTagList, "Button3", buttonText3)
	stringList[4] = choice_button(inputList, openList, closeList, textTagList, "Button4", buttonText4)
	stringList[5] = choice_button(inputList, openList, closeList, textTagList, "Button5", buttonText5)
	stringList[6] = choice_button(inputList, openList, closeList, textTagList, "Button6", buttonText6)
	stringList[7] = choice_button(inputList, openList, closeList, textTagList, "Button7", buttonText7)
	stringList[8] = choice_button(inputList, openList, closeList, textTagList, "Button8", buttonText8)
	stringList[9] = choice_button(inputList, openList, closeList, textTagList, "Button9", buttonText9)
	stringList[10] = choice_button(inputList, openList, closeList, textTagList, "Button10", buttonText10)

	-- 開始演出
	system.PlaySE("SE_00600")
	-- ボタンのアクティブの設定をしてから大元をアクティブにしないとボタンの受付が出来ないことがあるので処理順に注意
	SelectBox.SetActive(true)
	-- スクロール位置を一番上に戻す
	SelectBox.SetScrollPosition("ScrollRect",1, 1)
	local playSignal = SelectBox.PlayUITimelineControllerInAnimation("Timeline", "SelectBox_Main_In")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end
	set_active_textbox_input_object(false)
	-- 開放演出
	if #openList > 0 then
		-- スクロール出来ないようにする
		SelectBox.SetEnableScroll("ScrollRect", false, false)

		for index, openButtonName in ipairs(openList) do
			-- 画面内に選択肢がない場合は見えるとこまで移動
			SelectBox.MoveSelectBoxScrollObject("ScrollRect", openButtonName, 0.1)
			while SelectBox.IsProccessing() do
				coroutine.yield()
			end

			local endFlag = false
			local function waitSignal()
				endFlag = true
			end
			-- 効果音が無いので後で追加するかも
			SelectBox.SetTimelineSignal(openButtonName.."UnlockTimeline", 0, waitSignal)
			SelectBox.StartTimeline(openButtonName.."UnlockTimeline")
			while not endFlag do
				coroutine.yield()
			end
		end

		-- スクロール出来るようにする
		SelectBox.SetEnableScroll("ScrollRect", false, true)
	end
	-- 入力待ち
	local isChecking = true
	while isChecking do
		system.OnSelectStartTiming()
		SelectBox.Input(inputList, false, is_select_option)
		while SelectBox.IsProccessing() do
			coroutine.yield()
		end
		local inputButtonName = SelectBox.GetSelectedKey()
		isChecking = false
		for idx, closeButtonName in ipairs(closeList) do
			-- ロック状態のボタンを選ぶと詳細画面
			if inputButtonName == closeButtonName then
				-- 詳細画面初期化
				local tagtext
				local isor = system.GetActiveOptionLockIsOr(idx - 1)
				if isor == true then
					OptionLock.SetText("Message", OptionLock.GetText("LockMessageOr"))
				else
					OptionLock.SetText("Message", OptionLock.GetText("LockMessage"))
				end
				OptionLock.SetSimpleText("Title", OptionLock.GetText("LockTitle"))
				OptionLock.SetSimpleText("Close", OptionLock.GetText("LockClose"))
				local lockStates = system.GetActiveOptionLockState(idx - 1)
				local listItems = {}
				listItems[1] = OptionLock.CreateLoadUI("ListItemTop")
				-- テキストを取ってきてセットする
				tagtext = listItems[1].GetText("LockNumber")
				tagtext = string.format(tagtext, 1)
				listItems[1].SetSimpleText("Txt_Number", tagtext)
				for index = 2, #lockStates do
					-- 解放条件が2つ以上の場合は、Container_SelectBoxLockPartsを複製する
					listItems[index] = listItems[1].DuplicateUI()
					tagtext = listItems[index].GetText("LockNumber")
					tagtext = string.format(tagtext, index)
					listItems[index].SetSimpleText("Txt_Number", tagtext)
				end
				
				for index, lockState in ipairs(lockStates) do
					listItems[index].SetText("Txt_Condition", lockState.Text)
				end
				OptionLock.SetActive(true);
				-- 詳細画面開く
				playSignal = OptionLock.PlayUITimelineControllerInAnimation("UITimeline", "Com_Popup_Base_Anim_in")
				while playSignal.IsProccessing() do
					coroutine.yield()
				end
				-- 「閉じる」入力待ち
				OptionLock.Input({"Close"}, false)
				while OptionLock.IsProccessing() do
					coroutine.yield()
				end
				-- 詳細画面閉じる
				playSignal = OptionLock.PlayUITimelineControllerOutAnimation("UITimeline", true, "Com_Popup_Base_Anim_out")
				while playSignal.IsProccessing() do
					coroutine.yield()
				end
				OptionLock.SetActive(false);
				for index, lockState in ipairs(lockStates) do
					listItems[index].Empty(index > 1)
				end
				listItems = nil
				isChecking = true
			end
		end
	end
	
	-- 選んだ選択肢をログに登録。
	if SelectBox.GetSelectedKey() == "Button1" then
		add_advchoicelog(stringList[1], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[1])
	elseif SelectBox.GetSelectedKey() == "Button2" then
		add_advchoicelog(stringList[2], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[2])
	elseif SelectBox.GetSelectedKey() == "Button3" then
		add_advchoicelog(stringList[3], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[3])
	elseif SelectBox.GetSelectedKey() == "Button4" then
		add_advchoicelog(stringList[4], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[4])
	elseif SelectBox.GetSelectedKey() == "Button5" then
		add_advchoicelog(stringList[5], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[5])
	elseif SelectBox.GetSelectedKey() == "Button6" then
		add_advchoicelog(stringList[6], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[6])
	elseif SelectBox.GetSelectedKey() == "Button7" then
		add_advchoicelog(stringList[7], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[7])
	elseif SelectBox.GetSelectedKey() == "Button8" then
		add_advchoicelog(stringList[8], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[8])
	elseif SelectBox.GetSelectedKey() == "Button9" then
		add_advchoicelog(stringList[9], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[9])
	elseif SelectBox.GetSelectedKey() == "Button10" then
		add_advchoicelog(stringList[10], cutCharacter)
		system.SetAlreadyReadChoices(textTagList[10])
	else
		add_advchoicelog(stringList[1])
		system.SetAlreadyReadChoices(buttonText1)
	end
	
	-- 終了演出
	system.PlaySE("SE_00009")
	playSignal = SelectBox.PlayUITimelineControllerOutAnimation("Timeline", false, "SelectBox_Main_Out")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end
	-- 終了処理
	if cutCharacter != nil then
		cutCharacter.ActionBlink = nil
		cutCharacter.ActionLipsync = nil
	end
	button_active_reset("Button1")
	button_active_reset("Button2")
	button_active_reset("Button3")
	button_active_reset("Button4")
	button_active_reset("Button5")
	button_active_reset("Button6")
	button_active_reset("Button7")
	button_active_reset("Button8")
	button_active_reset("Button9")
	button_active_reset("Button10")
	SelectBox.SetActive(false)
	system.SetDefaultPlaySpeed(false)
	set_active_textbox_input_object(true)
	open_footer_ui(false)
end

-- 選択肢を開く
--  cutCharacter = カットインのキャラクター
--  facial3dTag = カットインキャラクターの表情のタグ
--  buttonText1 = １番目のボタンに表示するテキストのタグ
--  buttonText2 = ２番目のボタンに表示するテキストのタグ
--  buttonText3 = ３番目のボタンに表示するテキストのタグ
--  buttonText4 = ４番目のボタンに表示するテキストのタグ
--  buttonText5 = ５番目のボタンに表示するテキストのタグ
function open_select_window_tag(cutCharacter, facial3dTag, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10)
	local buttonTextTags = {}
	if buttonText1 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText1
	end
	if buttonText2 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText2
	end
	if buttonText3 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText3
	end
	if buttonText4 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText4
	end
	if buttonText5 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText5
	end
	if buttonText6 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText6
	end
	if buttonText7 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText7
	end
	if buttonText8 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText8
	end
	if buttonText9 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText9
	end
	if buttonText10 != nil then
		buttonTextTags[#buttonTextTags + 1] = buttonText10
	end
	-- マスター登録選択肢でないか確認する。
	local isOptionSelect = system.IsActiveOption(buttonTextTags)
	if isOptionSelect then
		open_select_window(cutCharacter, facial3dTag)
	else
		local function choice_button(inputList, openList, closeList, textTagList, buttonName, textTag)
			local bool validButton = (textTag != nil)
			local text
			SelectBox.SetActive(buttonName, validButton)
			if validButton then
				SelectBox.SetTextTag(buttonName, textTag)
				SelectBox.SetActive(buttonName.."Lock", false)
				SelectBox.SetActive(buttonName.."Already", system.IsAlreadyReadChoices(textTag))

				SelectBox.SetActive(buttonName.."_101010", false)
				SelectBox.SetActive(buttonName.."_101011", false)
				SelectBox.SetActive(buttonName.."_101012", false)

				inputList[#inputList + 1] = buttonName
				textTagList[#textTagList + 1] = textTag
				text = SelectBox.GetText(textTag)
			end
			return text
		end
		open_select_window_base(cutCharacter, facial3dTag, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10, choice_button, false)
	end
end

-- 選択肢を開く（文字列を直で指定）
--  cutCharacter = カットインのキャラクター
--  facial3dTag = カットインキャラクターの表情のタグ
--  buttonText1 = １番目のボタンに表示するテキスト文
--  buttonText2 = ２番目のボタンに表示するテキスト文
--  buttonText3 = ３番目のボタンに表示するテキスト文
--  buttonText4 = ４番目のボタンに表示するテキスト文
--  buttonText5 = ５番目のボタンに表示するテキスト文
function open_select_window_direct(cutCharacter, facial3dTag, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10)
	local function choice_button(inputList, openList, closeList, textTagList, buttonName, text)
		local bool validButton = (text != nil)
		SelectBox.SetActive(buttonName, validButton)
		if validButton then
			SelectBox.SetText(buttonName, text)
			SelectBox.SetActive(buttonName.."Already", false)
			SelectBox.SetActive(buttonName.."Lock", false)
			inputList[#inputList + 1] = buttonName
			textTagList[#textTagList + 1] = ""
		end
		return text
	end
	open_select_window_base(cutCharacter, facial3dTag, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10, choice_button, false)
end

-- 選択肢を開く（文字列を直で指定）
--  cutCharacter = カットインのキャラクター
--  facial3dTag = カットインキャラクターの表情のタグ
--  buttonText1 = １番目のボタンに表示するテキスト文
--  buttonText2 = ２番目のボタンに表示するテキスト文
--  buttonText3 = ３番目のボタンに表示するテキスト文
--  buttonText4 = ４番目のボタンに表示するテキスト文
--  buttonText5 = ５番目のボタンに表示するテキスト文

function open_select_window_direct_lock(cutCharacter, facial3dTag, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10)
	local function choice_button(inputList, openList, closeList, textTagList, buttonName, text)
		local bool validButton = (text != nil)
		SelectBox.SetActive(buttonName, validButton)
		if validButton then
			SelectBox.SetText(buttonName, text)
			SelectBox.SetActive(buttonName.."Already", false)
			--if #inputList == 7 or #inputList == 9 then
			SelectBox.SetActive(buttonName.."Lock", true)
			SelectBox.ResetTimeline(buttonName.."UnlockTimeline")
			--SelectBox.StopTimeline(buttonName.."UnlockTimeline")
			--end
			buttonName = "Lock"..buttonName
			closeList[#closeList + 1] = buttonName

			inputList[#inputList + 1] = buttonName
			textTagList[#textTagList + 1] = ""
		end
		return text
	end
	open_select_window_base(cutCharacter, facial3dTag, buttonText1, buttonText2, buttonText3, buttonText4, buttonText5, buttonText6, buttonText7, buttonText8, buttonText9, buttonText10, choice_button, false)
end

-- 選択肢を開く（マスターデータを元に）
--  cutCharacter = カットインのキャラクター
--  facial3dTag = カットインキャラクターの表情のタグ
function open_select_window(cutCharacter, facial3dTag)
	local function choice_button(inputList, openList, closeList, textTagList, buttonName, dummy)
		local string textTag = system.GetActiveOptionOneText(#inputList)
		local bool validButton = ((textTag != nil) and (#textTag > 0))
		SelectBox.SetActive(buttonName, validButton)
		if validButton then
			dummy = textTag 
			SelectBox.SetTextTag(buttonName, textTag)
			local alreadyReadflg = false
			if system.IsAlreadyReadChoices(textTag) or system.IsActiveSelectedOptionOne(#inputList) then
				alreadyReadflg = true
			end
			SelectBox.SetActive(buttonName.."Already", alreadyReadflg)
			local optionOneState = system.GetActiveOptionState(#inputList)
			if optionOneState <= 0 then
				SelectBox.SetActive(buttonName.."Lock", true)
				SelectBox.StopTimeline(buttonName.."UnlockTimeline")
				SelectBox.ResetTimeline(buttonName.."UnlockTimeline")
				if optionOneState == 0 then
					openList[#openList + 1] = buttonName
				else
					buttonName = "Lock"..buttonName
					closeList[#closeList + 1] = buttonName
				end
			else
				SelectBox.SetActive(buttonName.."Lock", false)
			end

			SelectBox.SetActive(buttonName.."_101010", system.GetOptionCharacterActive(textTag, 101010))
			SelectBox.SetActive(buttonName.."_101011", system.GetOptionCharacterActive(textTag, 101011))
			SelectBox.SetActive(buttonName.."_101012", system.GetOptionCharacterActive(textTag, 101012))

			inputList[#inputList + 1] = buttonName
			textTagList[#textTagList + 1] = textTag
			text = SelectBox.GetText(textTag)
		end
		return text
	end
	system.SetLockState()
	open_select_window_base(cutCharacter, facial3dTag, nil, nil, nil, nil, nil, nil, nil, nil, nil, nil, choice_button, true)
end

-- 直前の選択肢で何番目を選んだか
--  index = 調べたい選択肢の番号（1～）
--  return = true : 選んだ選択肢, false : 選んでない
function is_select(index)
	local buttonName = "Button" .. tostring(index)
	return SelectBox.GetSelectedKey() == buttonName
end

function button_active_reset(buttonName)
	SelectBox.SetActive(buttonName, true)
	SelectBox.SetActive(buttonName.."Lock", false)
end

function end_foward_from_select()
	if FooterUI ~= nul then
		onUpButtonForward()
	end
end