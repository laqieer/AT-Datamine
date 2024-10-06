Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Galahad()
	setup2D_Astera()


end

function Play()
	Play_start(false)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01107_340002")
	close_speech_window()

	
	change_face(Astera2, "Normal")
	open_speech_window("CHRNAME_ASTERA2", Astera2, nil)
	message("MA_01107_340003")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01107_340004")
	close_speech_window()

	
	change_face(Astera2, "Normal")
	open_speech_window("CHRNAME_ASTERA2", Astera2, nil)
	message("MA_01107_340005")
	
	change_face(Astera2, "Normal")
	message("MA_01107_340006")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01107_340007")
	close_speech_window()

	
	change_face(Galahad3, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad3, nil)
	message("MA_01107_340008")
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
	setup2D_Astera_preload()
end
