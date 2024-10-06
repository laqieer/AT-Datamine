Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Laiens()


end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Laiens, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens)
	message("MA_01107_380002")
	
	change_face(Laiens, "Normal")
	message("MA_01107_380003")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01107_380004")
	close_speech_window()

	
	change_face(Laiens, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens)
	message("MA_01107_380005")
	
	change_face(Laiens, "Normal")
	message("MA_01107_380006")
	
	change_face(Laiens, "Normal")
	message("MA_01107_380007")
	close_speech_window()



	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Laiens_preload()
end
