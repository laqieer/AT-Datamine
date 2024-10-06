Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Guinevere()
	setup2D_Gwenhwymawr()


end

function Play()
	Play_start(false)

	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	PlayPartVoice("ギネヴィア", "照れ")
	message("BT_01104_0204")
	close_speech_window()

	change_face(Gwenhwymawr2, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr2, nil)
	PlayPartVoice("ギネマウア", "肯定2")
	message("BT_01104_0205")
	close_speech_window()

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("BT_01104_0206")
	

	change_face(Guinevere, "Normal")
	
	PlayPartVoice("ギネヴィア", "肯定2")
	message("BT_01104_0207")
	close_speech_window()

	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Guinevere_preload()
	setup2D_Gwenhwymawr_preload()
end
