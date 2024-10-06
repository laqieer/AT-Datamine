Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Tyrfing()
	setup2D_Guinevere()
	setup2D_Gwenhwymawr()

end

function Play()
	Play_start(false)

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
	message("BT_01104_1204")
	close_speech_window()

	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	PlayPartVoice("ティルフィング", "肯定3")
	message("BT_01104_1205")
	close_speech_window()
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("BT_01104_1206")
	close_speech_window()
	
	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	PlayPartVoice("ティルフィング", "挨拶")
	message("BT_01104_1207")
	close_speech_window()

	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "笑い")
	message("BT_01104_1208")
	
	
	change_face(Noir2, "Normal")
	
	message("BT_01104_1209")
	close_speech_window()

	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	PlayPartVoice("ティルフィング", "肯定")
	message("BT_01104_1210")
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
	setup2D_Guinevere_preload()
	setup2D_Gwenhwymawr_preload()
end
