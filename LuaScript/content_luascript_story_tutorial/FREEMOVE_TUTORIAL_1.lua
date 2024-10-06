Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
	nofooter_setup()
	load_ui()
	close_textbox_base()
end

function Play()
    nofooter_start()
    PlayAdv()
    nofooter_end()
end

function PlayAdv()

	close_textbox_base()
	TextBox.SetActive(false)

	-- マスク出す
	active_tutorial_mask()
	set_mask_color("#0000007F")

	-- テキスト表示
	open_tutorial_popup(nil, 0, 0)
		set_message_direct_tutorial_popup("吹き出しをタップして生徒から話を聞こう") -- TODO : set_message_tutorial_popupでのローカライズテキスト置き換え
	close_tutorial_popup()

	-- マスクを外す
	deactive_tutorial_mask()
	set_mask_color("#00000000")

end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
