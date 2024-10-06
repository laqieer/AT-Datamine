

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	load_image("10103032", "content_still_10103032_image", "101030320_StillImage")

	
	
	
	
	
	init_psbattleadv("201090100", "201090100")
	
	change_time_and_weather(1,1)

	
	pbadv_setup_101015_Arthur(0,true, 8, 4,0)  


	
	pbadv_setup_101041_Morgan(4,true, 15, 4,0) 



	
	
	
	setup_complete_unit()

	

	
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotMorgan4, false)

	

	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(14, 4, 0.0)
	
	
	
	Ef_DieW= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	Ef_Holy= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_Suction", false, true)
	Ef_mark = load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_Holy2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
end






function Play()
	fadein(0)
	Play_start(true)









	dot_move_unit_seq(dotArthur,13,4)
	wait_time(2.0)

	change_face(Arthur, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_450002")
	close_speech_window()
	
	
	dot_move_unit_seq(dotArthur,14,4)
	wait_time(2.0)
	
	show_image("10103032", 0.0, 0.0, 0.0, true, false)

fadein(FADE_TIME+1.6)
wait_time(FADE_TIME)
wait_time(2.2)

	dot_disp_unit(dotMorgan4, false)
	dot_remove_unit(dotMorgan4)
	
	on_active(Ef_Holy2)
	
	local gridpos = get_grid_position(15, 4)
	set_pos(Ef_Holy2, gridpos)
	play_particle(Ef_Holy2)
	
	wait_time(2.2)


hide_image(STILL_SWITCH_TIME) 
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )



	
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10103032", "content_still_10103032_image", "101030320_StillImage")
	pbadv_setup_101015_Arthur_preload(0,true, 8, 4,0)
	pbadv_setup_101041_Morgan_preload(4,true, 15, 4,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_Suction", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
end
