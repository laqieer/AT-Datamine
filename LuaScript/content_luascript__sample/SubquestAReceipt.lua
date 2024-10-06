Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
	demo_setup_nofade()
	load_ui()
end

function Play()
    demo_start_nofade()
    open_narration_window()
        message_direct("サブクエストAの受注")
	close_narration_window()
    open_areaeventquest_window_receipt()
    demo_end_nofade()
end
-- EOF ------------------------------------


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
