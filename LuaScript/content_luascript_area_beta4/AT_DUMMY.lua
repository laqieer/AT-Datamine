-- 能動会話用ダミースクリプト
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

function Load()
	load_ui()
	Player = area_setup_101009_Noir("Player", nil)
end

function Play()
	show_current_script()

	open_narration_window()
	message_direct("能動会話用ダミースクリプト")
	close_narration_window()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	area_setup_101009_Noir_preload("Player", nil)
end
