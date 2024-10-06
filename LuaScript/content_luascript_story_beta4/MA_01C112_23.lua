Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system","BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Noir()
	setup2D_Mordred()
	setup2D_Sisters_5()
	
end

function Play()
	Play_start(false)

	
	
	change_face(Sisters_5,"Normal")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	message("MA_01C112_230002")
	

	
	
	message("MA_01C112_230003")
	

	
	
	message("MA_01C112_230004")
	close_speech_window()

	
	
	change_face(Mordred,"Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C112_230006")
	close_speech_window()

	
	change_face(Sisters_5,"Normal")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	message("MA_01C112_230007")
	

	
	change_face(Sisters_5,"Anger")
	
	message("MA_01C112_230008")
	

	
	
	message("MA_01C112_230009")
	close_speech_window()
	wait_time(0.3)
	
	
	
	bgm_play("Stop_BGM_Bus_LongFade")
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C112_230011")
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
	setup2D_Sisters_5_preload()
end
