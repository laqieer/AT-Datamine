Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Noir()
setup2D_Galahad()
setup2D_Lancelot()
setup2D_Tristan()
setup2D_Isolde()
setup2D_Astera()

end

function Play()
	Play_start(false)

	
	change_face(Galahad2, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090002")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_090003")
	close_speech_window()

	
	change_face(Galahad2, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090005")
	close_speech_window()

	
	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01108_090006")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090007")
	close_speech_window()

	
	change_face(Isolde2, "Normal")
	open_speech_window("CHRNAME_ISOLDE2", Isolde2, nil)
	message("MA_01108_090008")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090009")
	close_speech_window()

	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01108_090011")
	close_speech_window()

	
	change_face(Isolde2, "Normal")
	open_speech_window("CHRNAME_ISOLDE2", Isolde2, nil)
	message("MA_01108_090013")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_090015")
	close_speech_window()

	
	change_face(Galahad2, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090016")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_090017")
	close_speech_window()

	
	change_face(Astera2, "Normal")
	open_speech_window("CHRNAME_ASTERA2", Astera2, nil)
	message("MA_01108_090019")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090020")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_090021")
	
	change_face(Noir2, "Normal")
	message("MA_01108_090023")
	
	change_face(Noir2, "Normal")
	message("MA_01108_090024")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090025")
	close_speech_window()

	
	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01108_090026")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01108_090028")
	
	change_face(Galahad2, "Normal")
	message("MA_01108_090030")
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
setup2D_Tristan_preload()
setup2D_Isolde_preload()
setup2D_Astera_preload()
end
