-- バトルADV用ダミースクリプト
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	--demo_setup_nofade()
	Load_common(false)

end

function Play()
	Play_start(false)

	show_current_script()

	open_narration_window()
	message_direct("バトルADV用ダミースクリプト")
	close_narration_window()

	--demo_end_nofade()
	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
