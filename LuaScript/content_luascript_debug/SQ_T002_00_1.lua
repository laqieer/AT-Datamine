-- サブクエスト落とし物取得用スクリプト
Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")

function Load()
	load_ui()
	Player = get_chara("Player")
end

function Play()

	show_current_script()

	open_narration_window()
		message("DB_SQ01_00020001")
	close_narration_window()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	get_chara_preload("Player")
end
