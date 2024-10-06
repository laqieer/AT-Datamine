
ItemBoxKizunaQuest = system.LoadUI("ui_page_areaui_kizunaquest_prefab", "KizunaQuest_SubMenu", 600)
UiLoadList[#UiLoadList + 1] = ItemBoxKizunaQuest

--[[
	コミュニケーション　ロケーション選択メニューを開く
	menuItems = { TextValue, IntValue, ID }
	return = 選んだ選択肢
]]
function open_communication_place_window(menuItems)

	system.SetDefaultPlaySpeed(true)
	ItemBoxKizunaQuest.SetActive(true)
	
	-- 初期化
	ItemBoxKizunaQuest.SetText( "MsgTitle", "行き先")

	local listItems = {}
	listItems[1] = ItemBoxKizunaQuest.CreateLoadUI("ItemNode")

	-- menuItems分のitem生成
	for index = 2, #menuItems do
		listItems[index] = listItems[1].DuplicateUI()
	end
	-- item node 初期化
	for index = 1, #menuItems do
		if menuItems[index].TextValue != "" then
			listItems[index].SetButtonEnable("Button", menuItems[index].Enable)
			listItems[index].SetText("MsgName", menuItems[index].TextValue)
		end
	end

	-- timeline構築
	local initSignal = ItemBoxKizunaQuest.InitializeTimelineController("Top")
	while initSignal.IsProccessing() do
		coroutine.yield()
	end

	-- 開始演出
	system.PlaySE("SE_00600")
	local playSignal = ItemBoxKizunaQuest.PlayUITimelineControllerInAnimation("Top", "KizunaQuest_SubMenu_In")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end

	-- 入力待ち
	ItemBoxKizunaQuest.Input(listItems, "Button")
	while ItemBoxKizunaQuest.IsProccessing() do
		coroutine.yield()
	end

	-- 終了演出
	system.PlaySE("SE_00009")
	playSignal = ItemBoxKizunaQuest.PlayUITimelineControllerOutAnimation("Top", false, "KizunaQuest_SubMenu_Out")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end

	-- item clear
	for index, listItem in ipairs(listItems) do
		listItem.Empty(index > 1)
	end

	system.SetDefaultPlaySpeed(false)
	listItems = nil
	-- 直前のアイテム選択で選んだ選択肢の順番を取得する
	local buttonName = ItemBoxKizunaQuest.GetSelectedKey()
	local buttonNumber = buttonName:gsub("Button","")
	local index = tonumber(buttonNumber)
	return menuItems[index]
end

--[[
	コミュニケーション ロケーション選択～決定判定
]]
function communication_place_select(locations)
	local bool selected = false

	-- ロケーション選択
	local location = open_communication_place_window(locations)

	-- 最終決定判定
	local message = location.TextValue .. "に誘います。\nよろしいですか？"
	if open_popup_confirme_button(message, "SELECT_NO", "SELECT_YES") then
		system.SelectMenuItem(location.ID)
		selected = true
	end
	return selected
end



