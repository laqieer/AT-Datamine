Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Gareth()
	setup2D_Lyoness()
	setup2D_Noir()
	
	
end

function Play()
	Play_start(false) 
	
	show_current_script()

	sortie_troops(3, 2)
	wait_seq()

	change_face(Lyoness2, "Surprise")
	open_speech_window("CHRNAME_LYONESS2",Lyoness2, nil)
	PlayPartVoice("リオネス", "驚き")
	message("BT_01C111_0304") 
	close_speech_window()	

	change_face(Gareth, "Smile")
	open_speech_window("CHRNAME_GARETH",Gareth, nil)
	PlayPartVoice("ガレス", "笑い")
	message("BT_01C111_0305") 
	close_speech_window()	
	
	change_face(Lyoness2, "Smile")
	open_speech_window("CHRNAME_LYONESS2",Lyoness2, nil)
	PlayPartVoice("リオネス", "笑い")
	message("BT_01C111_0306") 
	close_speech_window()	


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2, nil)
	PlayPartVoice("ノワール", "悩む")
	message("BT_01C111_0307")

	change_face(Noir2, "Sad")
	message("BT_01C111_0308")
	close_speech_window()	

	bgm_play("BGM_To_Main")

	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Gareth_preload()
	setup2D_Lyoness_preload()
	setup2D_Noir_preload()
end
