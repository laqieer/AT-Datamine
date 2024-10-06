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
	PlayPartVoice("ランスロット", "挨拶")
	message("BT_01104_0803")
	close_speech_window()

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("BT_01104_0804")
	close_speech_window()

	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	PlayPartVoice("ランスロット", "悩む")
	message("BT_01104_0805")
	

	change_face(Lancelot, "Normal")
	
	message("BT_01104_0806")
	close_speech_window()
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "落胆")
	message("BT_01104_0807")
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
