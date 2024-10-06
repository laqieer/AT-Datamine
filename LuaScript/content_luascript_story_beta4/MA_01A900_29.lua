

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Fren()
	setup2D_Guinevere()
	setup2D_Lola()
	setup2D_Noir()
	
end

function Play()
	Play_start(false)


	
	
	change_face(Guinevere2, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2 , nil)
	message("MA_01A900_290002")
	close_speech_window()

	
	
	
	change_face(Lola3, "Anger")
	open_speech_window("CHRNAME_LOLA2",nil , Lola3)
	message("MA_01A900_290004")
	close_speech_window()

	
	change_face(Guinevere2, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2 , nil)
	message("MA_01A900_290005")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01A900_290006")
	close_speech_window()

	
	
	
	change_face(Fren3, "Pain")
	open_speech_window("CHRNAME_FREN2",nil , Fren3)
	message("MA_01A900_290008")
	close_speech_window()

	
	change_face(Guinevere2, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2 , nil)
	message("MA_01A900_290009")
	close_speech_window()

	
	change_face(Fren3, "Anger")
	open_speech_window("CHRNAME_FREN2",nil , Fren3)
	message("MA_01A900_290010")
	close_speech_window()

	
	
	change_face(Guinevere2, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2 , nil)
	message("MA_01A900_290012")
	close_speech_window()

	
	
	
	








	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Fren_preload()
	setup2D_Guinevere_preload()
	setup2D_Lola_preload()
	setup2D_Noir_preload()
end
