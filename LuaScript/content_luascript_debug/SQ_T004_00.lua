-- サブクエスト受注用スクリプト
Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")

function Load()
	load_ui()
	Talker = get_chara("Lancelot")
	Player = get_chara("Player")
end

function Play()

	show_current_script()

	change_face(Talker,"Normal")
	open_speech_window("CHRNAME_LANCELOT", Talker, nil)
		message("DB_SQ03_00010001")
		message("DB_SQ03_00010002")
		message("DB_SQ03_00010003")
	close_speech_window()

	open_narration_window()
		message("DB_SQ03_00010009")
	close_narration_window()

	open_speech_window("CHRNAME_LANCELOT", Talker, nil)
		message("DB_SQ03_00010010")
		message("DB_SQ03_00010011")
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