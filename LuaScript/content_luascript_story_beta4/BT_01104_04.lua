Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Tyrfing()
	setup2D_Guinevere()
	setup2D_Gawain()

end

function Play()
	Play_start(false)

		change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	PlayPartVoice("ガウェイン", "落胆")
	message("BT_01104_0403")
	close_speech_window()

		change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("BT_01104_0404")
	close_speech_window()

		change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("BT_01104_0405")
	

		change_face(Noir2, "Sad")
	
	PlayPartVoice("ノワール", "悲しみ")
	message("BT_01104_0406")
	close_speech_window()

		change_face(Tyrfing2, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing2, nil)
	PlayPartVoice("ティルフィング", "落胆")
	message("BT_01104_0407")
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
	setup2D_Gawain_preload()
end
