Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Dinatan()
	setup2D_Maladisant()
	setup2D_Gareth()
	setup2D_Lyoness()

end

function Play()
	Play_start(false)
	
	
	change_face(Lyoness2,"Anger")
	open_speech_window("CHRNAME_LYONESS2",Lyoness2,nil)
	message("MA_01C110_160001")
	close_speech_window()
	
	
	
	
	change_face(Dinatan2,"Pain")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2,nil)
	message("MA_01C110_160003")
	
	
	
	
	change_face(Dinatan2,"Anger")
	message("MA_01C110_160005")
	close_speech_window()
	
	
	change_face(Gareth,"Anger")
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C110_160006")
	close_speech_window()
	
	
	change_face(Dinatan2,"Pain")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2,nil)
	message("MA_01C110_160007")
	close_speech_window()
	
	
	
	change_face(Maladisant2,"Anger")
	open_speech_window("CHRNAME_MALADISANT",Maladisant,nil)
	message("MA_01C110_160009")
	close_speech_window()
	
	
	


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Dinatan_preload()
	setup2D_Maladisant_preload()
	setup2D_Gareth_preload()
	setup2D_Lyoness_preload()
end
