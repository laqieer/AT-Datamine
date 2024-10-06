Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Noir()
setup2D_Galahad()
setup2D_Lancelot()
setup2D_Perez()

end

function Play()
	Play_start(false)


	
	change_face(Perez2, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez2)
	message("MA_01B112_360002")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B112_360003")
	close_speech_window()

	
	change_face(Perez2, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez2)
	message("MA_01B112_360004")
	close_speech_window()

	
	change_face(Lancelot2, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot2, nil)
	message("MA_01B112_360005")
	close_speech_window()

	
	change_face(Perez2, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez2)
	message("MA_01B112_360006")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_360007")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B112_360008")
	close_speech_window()

	
	change_face(Perez2, "Anger")
	open_speech_window("CHRNAME_PEREZ", nil, Perez2)
	message("MA_01B112_360009")
	close_speech_window()

	
	change_face(Lancelot2, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot2, nil)
	message("MA_01B112_360010")
	
	change_face(Lancelot2, "Anger")
	message("MA_01B112_360011")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup2D_Noir_preload()
setup2D_Galahad_preload()
setup2D_Lancelot_preload()
setup2D_Perez_preload()
end
