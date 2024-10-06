Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Guinevere()
	setup2D_Gwenhwymawr()
	setup2D_Lucius()
	setup2D_Ragnar()
	setup2D_Gawain()
	setup2D_Vernarth()

end

function Play()
	Play_start(false)


	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01108_150002")
	
	change_face(Guinevere, "Normal")
	message("MA_01108_150003")
	
	change_face(Guinevere, "Normal")
	message("MA_01108_150004")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01108_150005")
	
	change_face(Lucius, "Normal")
	message("MA_01108_150006")
	close_speech_window()

	
	change_face(Vernarth, "Normal")
	open_speech_window("CHRNAME_VERNARTH", Vernarth, nil)
	message("MA_01108_150007")
	close_speech_window()

	
	change_face(Gawain, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01108_150008")
	close_speech_window()

	
	change_face(Ragnar2, "Smile")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	message("MA_01108_150010")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01108_150012")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_150013")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01108_150014")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01108_150015")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01108_150016")
	close_speech_window()

	
	change_face(Gwenhwymawr2, "Normal")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr2, nil)
	message("MA_01108_150017")
	close_speech_window()

	
	change_face(Lucius, "Smile")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01108_150018")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01108_150019")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01108_150020")
	close_speech_window()

	
	change_face(Gwenhwymawr2, "Normal")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr2, nil)
	message("MA_01108_150021")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01108_150022")
	
	change_face(Lucius, "Normal")
	message("MA_01108_150023")
	
	change_face(Lucius, "Normal")
	message("MA_01108_150024")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Guinevere_preload()
	setup2D_Gwenhwymawr_preload()
	setup2D_Lucius_preload()
	setup2D_Ragnar_preload()
	setup2D_Gawain_preload()
	setup2D_Vernarth_preload()
end
