Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Sisters_1()
	setup2D_Sisters_3()
	setup2D_Sisters_4()
	setup2D_Sisters_5()

	load_sound("BGM_ADV_Noir_Theme")


end

function Play()
	Play_start(false)


	
	change_face(Sisters_5, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Sisters_5)
	message("MA_01107_260001")
	close_speech_window()

	
	change_face(Sisters_4, "Smile")
	open_speech_window("CHRNAME_SISTERS_4", nil, Sisters_4)
	message("MA_01107_260002")
	close_speech_window()

	
	change_face(Sisters_3, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Sisters_3)
	message("MA_01107_260003")
	close_speech_window()

	
	change_face(Sisters_1, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Sisters_1)
	message("MA_01107_260004")
	close_speech_window()

	bgm_play("BGM_ADV_Noir_Theme")

	
	change_face(Noir2, "Normal")
	open_mind_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01107_260006")
	
	change_face(Noir2, "Normal")
	message("MA_01107_260007")
	
	change_face(Noir2, "Normal")
	message("MA_01107_260008")
	
	change_face(Noir2, "Normal")
	message("MA_01107_260009")
	
	change_face(Noir2, "Normal")
	message("MA_01107_260010")
	
	change_face(Noir2, "Normal")
	message("MA_01107_260011")
	close_mind_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Sisters_1_preload()
	setup2D_Sisters_3_preload()
	setup2D_Sisters_4_preload()
	setup2D_Sisters_5_preload()
	preload_sound("BGM_ADV_Noir_Theme")
end
