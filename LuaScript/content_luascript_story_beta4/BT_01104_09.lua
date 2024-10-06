Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Tyrfing()
	setup2D_Gawain()
	setup2D_Ragnar()
end

function Play()
	Play_start(false)

	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "怒り")
	message("BT_01104_0904")
	

	change_face(Noir2, "Serious")
	
	message("BT_01104_0905")
	close_speech_window()

	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	PlayPartVoice("ティルフィング", "肯定2")
	message("BT_01104_0906")
	

	change_face(Tyrfing2, "Normal")
	
	message("BT_01104_0907")
	

	change_face(Tyrfing2, "Normal")
	
	PlayPartVoice("ティルフィング", "挨拶")
	message("BT_01104_0908")
	close_speech_window()

	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("BT_01104_0909")
	

	change_face(Noir2, "Serious")
	
	message("BT_01104_0910")
	close_speech_window()

	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Tyrfing_preload()
	setup2D_Gawain_preload()
	setup2D_Ragnar_preload()
end
