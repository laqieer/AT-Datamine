Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Dinatan()
	setup2D_Gareth()
	setup2D_Lyoness()

end

function Play()
	Play_start(false)


	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_230001")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208", nil, nil)
	message("MA_01108_230002")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_230003")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230004")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_230006")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230007")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_230008")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230010")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_230011")
	
	change_face(Gareth, "Normal")
	message("MA_01108_230012")
	
	change_face(Gareth, "Normal")
	message("MA_01108_230013")
	
	change_face(Gareth, "Normal")
	message("MA_01108_230014")
	
	change_face(Gareth, "Normal")
	message("MA_01108_230015")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230016")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_230018")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230019")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_230020")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230021")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_230022")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_230023")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230025")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_230027")
	close_speech_window()

	
	change_face(Lyoness2, "Smile")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230029")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_230030")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_230031")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_230032")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_230033")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_230034")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_230035")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_230036")
	close_speech_window()



	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Dinatan_preload()
	setup2D_Gareth_preload()
	setup2D_Lyoness_preload()
end
