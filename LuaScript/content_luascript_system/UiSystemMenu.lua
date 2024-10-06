--[[
	メニュー機能表示
]]

-- システムのメニュー機能を呼び出す
-- menuType: [in]string 表示するメニュー種類。 Adv2SystemMenu.cs MenuType型参照
function open_system_menu(menuType)
	
	-- 不要なUIを非表示にしておく
	TextBox.SetButtonActive("All", false)
	
	
	local checkLoaded = system.OpenSystemMenu(menuType)
	while checkLoaded.IsProccessing() do
		coroutine.yield()
	end
	
	-- UIを元に戻しておく
	TextBox.SetButtonActive("All", true)
end

function open_global_menu()
	if system.GetPlaySpeed() == 1.0 then
		-- オート中は現在表示中の処理をまつ
		while TextBox.IsProccessing() and system.GetPlaySpeed() >= 1.0 do
			coroutine.yield()
		end
		system.SetPlayMode(0)
		_checkFooterButton()
	end
	local openingSignal = system.OpenGlobalMenu()
	while openingSignal.IsProccessing() do
		coroutine.yield()
	end
end

-- AP追加
function open_menu_addap()
	open_system_menu("AddAP")
end

-- 伝晶石追加
function open_menu_buystone()
	open_system_menu("BuyStone")
end

-- 青ソウル/赤ソウル追加
function open_menu_addsoul()
	open_system_menu("AddSoul")
end

-- ガシャ
function open_menu_gacha()
	open_system_menu("Gacha")
end

-- ギルド
function open_menu_guild()
	open_system_menu("Guild")
end

-- ショップ
function open_menu_shop()
	open_system_menu("Shop")
end

-- ユニット
function open_menu_unit()
	open_system_menu("Unit")
end

-- クエスト
function open_menu_quest()
	open_system_menu("Quest")
end

-- イベント（フリークエスト含む）
function open_menu_event()
	open_system_menu("Event")
end

-- 放置遠征
function open_menu_expedition()
	open_system_menu("Expedition")
end

-- 交換所
function open_menu_exchange()
	open_system_menu("Exchange")
end

-- プレゼントボックス
function open_menu_present()
	open_system_menu("Present")
end

-- お知らせ
function open_menu_news()
	open_system_menu("News")
end

-- ゲーム内メニュー
function open_menu_gamemenu()
	open_system_menu("GameMenu")
end

-- ミッション
function open_menu_mission()
	open_system_menu("Mission")
end

-- パネルミッション
function open_menu_panelmission()
	open_system_menu("PanelMission")
end

-- ストーリークエスト選択
function open_menu_selectstoryquest()
	open_system_menu("SelectStoryQuest")
end
