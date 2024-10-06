Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Lancelot()
	setup2D_Guinevere()
	setup2D_Dinatan()
	setup2D_Noir()
	setup2D_Maladisant()
	
	
end

function Play()
	Play_start(false) 

	change_face(Lancelot, "Anger")
	open_speech_window("CHRNAME_LANCELOT",Lancelot, nil)
	PlayPartVoice("ランスロット", "悩む")
	message("BT_01C110_0207")
	close_speech_window()	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere, nil)
	PlayPartVoice("ギネヴィア", "肯定")
	message("BT_01C110_0208")
	close_speech_window()
	
	change_face(Noir2, "Normal")
	PlayPartVoice("ノワール", "肯定2")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	message("BT_01C110_0209")
	
	PlayPartVoice("ノワール", "肯定")
	message("BT_01C110_0210")
	close_speech_window()
	
	change_face(Dinatan2, "Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2, nil)
	PlayPartVoice("ディナタン", "肯定3")
	message("BT_01C110_0211")
	close_speech_window()
	
	change_face(Maladisant2, "Anger")
	open_speech_window("CHRNAME_MALADISANT2",Maladisant2, nil)
	PlayPartVoice("マルディサント", "肯定")
	message("BT_01C110_0212")
	close_speech_window()

	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lancelot_preload()
	setup2D_Guinevere_preload()
	setup2D_Dinatan_preload()
	setup2D_Noir_preload()
	setup2D_Maladisant_preload()
end
