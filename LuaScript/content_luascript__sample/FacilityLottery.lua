Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
    demo_setup_nofade()
end

-- シーケンスの実行
function Play()
	demo_start_nofade()
	
	open_narration_window()
	message_direct("何を願いますか")
	close_narration_window()
	
	local facility = get_facility()
	local menuItems = facility.GetLotteryItems()
	local item = open_menu_window(menuItems)
	system.SelectMenuItem(item.ID)
	
	
    if item.IsCharacterSelectable == true then
        open_narration_window()
    	message_direct("誰との関係を願いますか")
    	close_narration_window()
    	
    	local commuCharas = facility.GetCommuCharacters()
    	local select = open_menu_window(commuCharas)
    	system.SelectMenuItem(select.ID)
    end
    
    connection = connection() -- 通信実行依頼
	wait_proccess(connection) -- 通信待ち
    
    result = connection.Result -- 結果
    if result.Success then
        open_narration_window()
    	message_direct(result.CharaName .. "と仲良くなれた気がする")
    	close_narration_window()
    else
        open_narration_window()
    	message_direct("想いは届いてなさそうだ")
    	close_narration_window()
    end
	
	demo_end_nofade()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
