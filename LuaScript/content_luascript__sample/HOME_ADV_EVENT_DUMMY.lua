-- シナリオクエスト：ホーム用ダミースクリプト
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

function Load()
	nofooter_setup()

end

function Play()
	nofooter_start()

	show_current_script()

	open_narration_window()
    	message_direct("『シナリオクエスト開催中』")
	close_narration_window()

	nofooter_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    
end
