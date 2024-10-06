Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Brian()
	setup2D_Dinatan()

end

function Play()
	Play_start(false)



	
	change_face(Brian, "Normal")
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_160002")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_160004")
	close_speech_window()

	
	change_face(Brian, "Normal")
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_160005")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_160006")
	close_speech_window()

	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_160007")
	
	change_face(Brian, "Anger")
	message("MA_01106_160008")
	close_speech_window()



	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Brian_preload()
	setup2D_Dinatan_preload()
end
