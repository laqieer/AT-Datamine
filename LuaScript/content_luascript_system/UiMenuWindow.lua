
ItemBox = system.LoadUI("ui_page_adv", "Container_StoryItemList", 600)
UiLoadList[#UiLoadList + 1] = ItemBox

-- メニューを開く
-- menuItems = { TextValue, IntValue, ID }
--  return = 選んだ選択肢
function open_menu_window(menuItems, numTitle)
    if numTitle == nil then
        numTitle = "所持数"
    end
	system.SetDefaultPlaySpeed(true)
	-- 初期化
	local listItems = {}
	listItems[1] = ItemBox.CreateLoadUI("ListItemTop")
	for index = 2, #menuItems do
		listItems[index] = listItems[1].DuplicateUI()
	end
	for index = 1, #menuItems do
		if menuItems[index].TextValue != "" then
			listItems[index].Play("Contents_Default", true)
			listItems[index].SetButtonEnable("Button", menuItems[index].Enable)
			listItems[index].SetText("Name", menuItems[index].TextValue)
			listItems[index].SetText("NumTitle", numTitle .. ":")
			listItems[index].SetText("Num", menuItems[index].IntValue)
		else
			listItems[#listItems].Play("Contents_Disuse", true)
		end
	end
	-- 開始演出
	system.PlaySE("SE_00600")
	ItemBox.Play("ItemList_In", true)
	while ItemBox.IsProccessing() do
		coroutine.yield()
	end
	-- 入力待ち
	ItemBox.Input(listItems, "Button")
	while ItemBox.IsProccessing() do
		coroutine.yield()
	end
	-- 終了演出
	system.PlaySE("SE_00009")
	ItemBox.Play("ItemList_Out", false)
	while ItemBox.IsProccessing() do
		coroutine.yield()
	end
	for index, listItem in ipairs(listItems) do
		listItem.Empty(index > 1)
	end
	system.SetDefaultPlaySpeed(false)
	listItems = nil
	-- 直前のアイテム選択で選んだ選択肢の順番を取得する
	local buttonName = ItemBox.GetSelectedKey()
	local buttonNumber = buttonName:gsub("Button","")
	local index = tonumber(buttonNumber)
	return menuItems[index]
end

