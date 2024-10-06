

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	
	setup2D_Lancelot()
	setup2D_Arthur()
	
	
end

function Play()
	Play_start(false)


	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR",Arthur , nil)
	 --PlayPartVoice("アーサー","苦しみ")
	message("MA_01B112_9050002")
	close_speech_window()

	
	change_face(Lancelot2, "Sad")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2 , nil)
	 --PlayPartVoice("ランスロット","悲しみ")
	message("MA_01B112_9050003")
	close_speech_window()

	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR",Arthur , nil)
	 --PlayPartVoice("アーサー","笑い")
	message("MA_01B112_9050004")
	

	
	
	message("MA_01B112_9050005")
	close_speech_window()

	
	change_face(Lancelot2, "Smile")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2 , nil)
	 --PlayPartVoice("ランスロット","笑い")
	message("MA_01B112_9050006")
	

	
	change_face(Lancelot2, "Normal")
	
	message("MA_01B112_9050007")
	close_speech_window()




				


	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lancelot_preload()
	setup2D_Arthur_preload()
end
