Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Noir()
	setup2D_Dinatan()
	setup2D_Ragnar()
	setup2D_Gawain()
	
end

function Play()
	Play_start(false)



	
	change_face(Ragnar2, "Sad")
	open_speech_window("CHRNAME_RAGNAR2",nil , Ragnar2)
	message("MA_01C900_140002")
	close_speech_window()

	
	change_face(Gawain2, "Serious")
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain2)
	message("MA_01C900_140003")
	close_speech_window()

	
	
	change_face(Ragnar2, "Anger")
	open_speech_window("CHRNAME_RAGNAR2",nil , Ragnar2)
	message("MA_01C900_140005")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C900_140006")
	close_speech_window()

	
	change_face(Gawain2, "Anger")
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain2)
	message("MA_01C900_140007")
	close_speech_window()


	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C900_140008")
	close_speech_window()

	
	change_face(Dinatan2, "Surprise")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2 , nil)
	message("MA_01C900_140009")
	close_speech_window()

	
	
	change_face(Gawain2, "Sad")
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain2)
	message("MA_01C900_140011")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01C900_140012")
	close_speech_window()

	
	change_face(Gawain2, "Anger")
	open_speech_window("CHRNAME_GAWAIN",nil , Gawain2)
	message("MA_01C900_140014")
	close_speech_window()




	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Dinatan_preload()
	setup2D_Ragnar_preload()
	setup2D_Gawain_preload()
end
