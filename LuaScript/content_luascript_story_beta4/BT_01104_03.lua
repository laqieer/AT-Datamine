Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Tyrfing()
	
end

function Play()
	Play_start(false)

	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	PlayPartVoice("ティルフィング", "肯定3")
	message("BT_01104_0303")
	message("BT_01104_0304")
	close_speech_window()

	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "驚き")
	message("BT_01104_0305")
	close_speech_window()

	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	PlayPartVoice("ティルフィング", "挨拶")
	message("BT_01104_0306")
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
end
