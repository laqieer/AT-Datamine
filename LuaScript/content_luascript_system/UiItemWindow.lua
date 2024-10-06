
ItemMenu = system.LoadUI("ui_page_areaui_kizunaquest_prefab", "FacilityItem_SubMenu", 600)
UiLoadList[#UiLoadList + 1] = ItemMenu

-- optionInfo = array[{TextValue, IntValue, ItemId, FlavorValue}]
function open_item_window_general(optionInfo)
	-- 初期化
	system.SetDefaultPlaySpeed(true)

	ItemMenu.SetActive(true)
	
	local facility = get_facility()
	
	ItemMenu.SetText("MsgTitle", facility.Name)
	
	local listItems = {}
	listItems[1] = ItemMenu.CreateLoadUI("ListItemNotTop")
	listItems[1].SetButtonEnable("Button", true)
	listItems[2] = ItemMenu.CreateLoadUI("ListItemTop")
	for index = 2, #optionInfo - 1 do
		listItems[index+1] = listItems[2].DuplicateUI()
	end
	for index = 2, #optionInfo do
		listItems[index].SetText("Name", optionInfo[index].TextValue)
		listItems[index].SetText("Num", optionInfo[index].IntValue)
		listItems[index].SetText("Flavor", optionInfo[index].FlavorValue)
		listItems[index].SetButtonEnable("Button", true)
		if(optionInfo[index].ItemId != nil ) then
			listItems[index].SetChaperItemIcon("ItemIcon", optionInfo[index].ItemId, optionInfo[index].IntValue)
		end
	end
		
	local playSignal = ItemMenu.InitializeTimelineController("Timeline")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end	
	
	-- 開始演出
	system.PlaySE("SE_00600")
	playSignal = ItemMenu.PlayUITimelineControllerInAnimation("Timeline", "KizunaQuest_SubMenu_In")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end
	
	-- 入力待ち
	ItemMenu.Input(listItems, "Button")
	while ItemMenu.IsProccessing() do
		coroutine.yield()
	end
	-- 終了演出
	system.PlaySE("SE_00009")
	
	playSignal = ItemMenu.PlayUITimelineControllerOutAnimation("Timeline", false, "KizunaQuest_SubMenu_Out")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end
	
	for index, listItem in ipairs(listItems) do
		listItem.Empty(index > 1)
	end
	listItems = nil
	-- 直前のアイテム選択で選んだ選択肢の順番を取得する
	local buttonName = ItemMenu.GetSelectedKey()
	local buttonNumber = buttonName:gsub("Button","")
	system.SetDefaultPlaySpeed(false)
	return tonumber(buttonNumber)
end

-- アイテムウィンドウを開く（マスターデータを元に）
--  return = 選んだ選択肢の順番（1～）
function open_item_window(optionInfo)
	local optionInfo = system.CreateActiveOptionInfo(true)
	return open_item_window_general(optionInfo)
end

