-- シナリオクエスト：ホーム用ダミースクリプト
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

function Load()
	demo_setup()

end

function Play()
	demo_start()

	show_current_script()

	open_narration_window()
    	message_direct("ADV再生中です")
	close_narration_window()

	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    
end
