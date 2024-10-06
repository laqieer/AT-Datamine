Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Arthur()
	setup2D_Lancelot()

end

function Play()

	Play_start(false)



	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur)
	PlayPartVoice("アーサー", "挨拶")	
	message("BT_01B900_0104")


	message("BT_01B900_0105")
	close_speech_window()
	

	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil) 
	PlayPartVoice("ランスロット", "悩む")	
	message("BT_01B900_0106")
	close_speech_window()


	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur)
	PlayPartVoice("アーサー", "笑い")	
	message("BT_01B900_0107")
	close_speech_window()
	

	change_face(Lancelot, "Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil) 
	PlayPartVoice("ランスロット", "笑い")
	message("BT_01B900_0108")
	

	change_face(Lancelot, "Serious")
	message("BT_01B900_0109")
	close_speech_window()
	

	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", nil, Arthur)
	message("BT_01B900_0110")
	close_speech_window()

	bgm_play("Reset_BGM_Bus_Volume")




	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Arthur_preload()
	setup2D_Lancelot_preload()
end
