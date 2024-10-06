Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
	nofooter_setup()
	load_ui()

	Aruhan = set_chara_unknown()
	character2DFull(Aruhan, "Aruhan", 101059001)
	close_textbox_base()
end

function Play()
    nofooter_start()
	open_tutorial_popup(nil, 0, 0)
		set_message_direct_tutorial_popup("ホーム画面では様々なことができます。")
		set_message_direct_tutorial_popup("プレゼントボックスから<br>『チュートリアルガチャチケット』を受け取ってみましょう。")
	close_tutorial_popup()
    nofooter_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Aruhan, "Aruhan", 101059001)
end
