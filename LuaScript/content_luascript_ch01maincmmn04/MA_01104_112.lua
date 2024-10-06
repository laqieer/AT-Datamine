-- MA_01104_112
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")

function Load()
	Load_common(true)

	
	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(BattleTime_Night, BattleWeather_Shiny)

	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")

	pbadv_setup_101009_Noir(2,true, 20, 22,0) --ノワール
	pbadv_setup_101012_Dinatan(0,true, 21, 14,0)  --ディナタン

	setup_complete_unit()

	dot_change_anim(dotDinatan, 1)

	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotDinatan,false)

	change_camera_distance(8.0, 0.0)
	
	change_camera_angle(45.0, 0.0)
	
	move_camera(20, 22, 0.0)
	

end

function Play()
	Play_start(true)
	fadein(0)



	dot_move_unit_seq(dotDinatan, 21, 18)
	wait_seq()
	dot_unit_dir(dotDinatan, 2)

	wait_time(0.5)
	dot_move_unit_seq(dotDinatan, 21, 22)
	wait_seq()

	dot_unit_dir(dotDinatan, 2)
	

	-- @ディナタン	兄さん	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120003")
	close_speech_window()

	-- @ノワール	ディナタン…！	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1120004")
	close_speech_window()

	-- @ディナタン	ケガ、ない？	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120005")
	close_speech_window()

	-- @ノワール	ディナタンは…？	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1120006")
	close_speech_window()

	-- @ディナタン	私………たすけられた、から	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120007")

	-- @ディナタン	だれかに、たすけられたはずなの一瞬のことで…記憶が曖昧なんだけど	
	message("MA_01104_1120008")
	close_speech_window()

	-- @ノワール	…ウレリーが守ってくれたんだな	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1120009")
	close_speech_window()

	-- @ディナタン	え…？	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120010")
	close_speech_window()

	-- @ノワール	ウレリーが、その…身代わりに──	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1120011")
	close_speech_window()

	-- @ディナタン	「ウレリー」…？	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120012")
	close_speech_window()

	-- @ノワール	お前を突き飛ばして、助けてくれて…	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1120013")
	close_speech_window()

	-- @ディナタン	…ごめんなさい、兄さん「ウレリー」って──	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120014")
	close_speech_window()

	-- @ノワール	え？	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1120015")
	close_speech_window()

	-- @ディナタン	おしえて	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120016")
	close_speech_window()

	--//暗転
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

	-- @ディナタン	だれのこと？	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1120018")
	close_speech_window()



	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 20, 22,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 21, 14,0)
end
