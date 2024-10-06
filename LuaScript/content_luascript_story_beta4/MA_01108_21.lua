Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Dinatan()
setup2D_Gareth()
setup2D_Lyoness()

end

function Play()
	Play_start(false)


	
	open_speech_window("NPCNAME_0207", nil, nil)
	message("MA_01108_210002")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208", nil, nil)
	message("MA_01108_210003")
	close_speech_window()

	
	open_speech_window("NPCNAME_0207", nil, nil)
	message("MA_01108_210004")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_210005")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_210006")
	close_speech_window()

	
	change_face(Dinatan, "Normal")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_210007")
	close_speech_window()

	
	change_face(Lyoness2, "Normal")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	message("MA_01108_210008")
	close_speech_window()

	
	open_speech_window("NPCNAME_0208", nil, nil)
	message("MA_01108_210009")
	close_speech_window()

	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01108_210010")
	close_speech_window()

	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_210012")
	close_speech_window()

	
	open_speech_window("NPCNAME_0207", nil, nil)
	message("MA_01108_210013")
	close_speech_window()

	
	change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_210015")
	close_speech_window()






	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup2D_Dinatan_preload()
setup2D_Gareth_preload()
setup2D_Lyoness_preload()
end
