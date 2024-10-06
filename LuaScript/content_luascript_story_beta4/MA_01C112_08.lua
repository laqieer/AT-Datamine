Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system","BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Noir()
	setup2D_Mordred()
	setup2D_Clarice()
	setup2D_Sisters_4()

	setup2D_Dinatan()
	
end

function Play()
	Play_start(false)

	
		
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C112_080002")
	close_speech_window()

	
	change_face(Clarice2, "Sad")
	open_speech_window("CHRNAME_CLARICE2",Clarice2 , nil)
	message("MA_01C112_080003")
	close_speech_window()

	
	change_face(Sisters_4,"Smile")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	message("MA_01C112_080004")
	

	
	
	message("MA_01C112_080005")
	close_speech_window()

	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C112_080006")
	close_speech_window()

	
	
	change_face(Sisters_4,"Normal")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	message("MA_01C112_080008")
	

	
	
	message("MA_01C112_080009")
	

	
	
	message("MA_01C112_080010")
	close_speech_window()

	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C112_080012")
	close_speech_window()

	
	change_face(Sisters_4,"Smile")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	message("MA_01C112_080013")
	

	
	
	message("MA_01C112_080015")
	

	
	
	
	message("MA_01C112_080017")
	close_speech_window()

	
	
	change_face(Dinatan2,"Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2,nil)
	message("MA_01C112_080019")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C112_080020")
	close_speech_window()

	

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C112_9020014")
	close_speech_window()

	
	change_face(Clarice2, "Normal")
	open_speech_window("CHRNAME_CLARICE2",Clarice2 , nil)
	message("MA_01C112_9020015")
	close_speech_window()
	
	
	change_face(Dinatan2,"Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2,nil)
	message("MA_01C112_9020016")
	close_speech_window()
	

	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	message("MA_01C112_9020017")
	close_speech_window()	
	
	
	change_face(Dinatan2,"Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2,nil)
	message("MA_01C112_9020018")
	close_speech_window()	

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C112_9020019")
	close_speech_window()
	
	
	change_face(Dinatan2,"Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2,nil)
	message("MA_01C112_9020020")
	close_speech_window()		

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C112_9020021")
	close_speech_window()



	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Mordred_preload()
	setup2D_Clarice_preload()
	setup2D_Sisters_4_preload()
	setup2D_Dinatan_preload()
end
