-- サブクエスト受注用スクリプト
Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")

function Load()
	load_ui()
	Talker = get_chara()
	Player = get_chara("Player")
end

function Play()

	show_current_script()

	open_speech_window("NPCNAME_0351")
		message("SQ_0003_00001")
		message("SQ_0003_07004")
		message("SQ_0003_07005")
		message("SQ_0003_00006")
	close_speech_window()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	get_chara_preload()
	get_chara_preload("Player")
end
