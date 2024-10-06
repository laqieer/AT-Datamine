Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
	load_ui()

	close_textbox_base()
end

function Play()
	while system.ProcessingChangeScene() do
		coroutine.yield()
	end
    PlayArenaTop()
end

function PlayArenaTop()
	set_active_arrow(false)
	close_textbox_base()
	TextBox.SetActive(false)

	-- マスクの表示
	active_tutorial_mask()
	set_mask_color("#0000007F")
	
	
	-- テキストの表示
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_67_01001")	--編成ボタンをタッチして編成に進んでください。
	close_tutorial_popup()
	
	
	-- 矢印の表示
	set_active_arrow(true)
	active_unmask(1, true)
	
	-- 編成
	wait_get_accesser("Tutorial_ArenaPartyEditBtn")
	
	set_mask_color("#0000007F")
	active_unmask(1, true)
	set_active_arrow(true)
	set_unmask_fittarget(1, "Tutorial_ArenaPartyEditBtn", false, true)
	set_position_target_arrow("Tutorial_ArenaPartyEditBtn", 0, 40)
	wait_button_click("Tutorial_ArenaPartyEditBtn")
	
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
