Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Guinevere()
	setup2D_Lucius()
	setup2D_Tristan()

	load_sound("BGM_Battle_General1_Intro")

end

function Play()
	Play_start(false)


	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01107_130002")
	close_speech_window()

	bgm_play("BGM_Battle_General1_Intro")
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01107_130003")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01107_130004")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01107_130005")
	
	change_face(Noir2, "Normal")
	message("MA_01107_130007")
	close_speech_window()

	
	change_face(Lucius, "Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01107_130008")
	close_speech_window()

	
	change_face(Tristan, "Anger")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01107_130009")
	
	change_face(Tristan, "Anger")
	message("MA_01107_130011")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01107_130013")
	close_speech_window()




	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Guinevere_preload()
	setup2D_Lucius_preload()
	setup2D_Tristan_preload()
	preload_sound("BGM_Battle_General1_Intro")
end
