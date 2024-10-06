Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	
	Load_common(false)

	setup2D_Noir()
	setup2D_Lancelot()

end

function Play()
	Play_start(false)

	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	PlayPartVoice("ランスロット", "納得")
	message("BT_01104_0603")
	close_speech_window()

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
	message("BT_01104_0604")
	close_speech_window()

	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	PlayPartVoice("ランスロット", "肯定3")
	message("BT_01104_0605")
	close_speech_window()

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "驚き")
	message("BT_01104_0606")
	close_speech_window()

	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	PlayPartVoice("ランスロット", "肯定")
	message("BT_01104_0607")
	close_speech_window()
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "落胆")
	message("BT_01104_0608")
	close_speech_window()

	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Lancelot_preload()
end
