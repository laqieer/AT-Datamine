

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Noir()
	setup2D_Lovein()
	setup2D_Ragnar()
	setup2D_Gawain()
	
end

function Play()
	Play_start(false)



	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	 --PlayPartVoice("ノワール","悩む")
	message("MA_01A110_9020002")
	close_speech_window()

	
	change_face(Lovein2, "Sad")
	open_speech_window("CHRNAME_LOVEIN2",Lovein2 , nil)
	 --PlayPartVoice("ラヴェイン","悩む")
	message("MA_01A110_9020003")
	close_speech_window()

	
	change_face(Ragnar2, "Normal")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2 , nil)
	 --PlayPartVoice("ラグネル","挨拶")
	message("MA_01A110_9020004")
	close_speech_window()

	
	change_face(Gawain, "Serious")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	 --PlayPartVoice("ガウェイン","肯定2")
	message("MA_01A110_9020005")
	

	
	
	message("MA_01A110_9020006")
	

	
	
	message("MA_01A110_9020007")
	close_speech_window()



				


	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Lovein_preload()
	setup2D_Ragnar_preload()
	setup2D_Gawain_preload()
end
