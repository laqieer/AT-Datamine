Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
		
	init_psbattleadv(201180000,201180000)
		
	
	pbadv_setup_101009_Noir(2,true,21,38,0)
	pbadv_setup_101011_Guinevere(1,true,21,37,0)
	pbadv_setup_101030_Elaine(1,true,23,32,0)
	pbadv_setup_101031_Lovein(0,true,23,33,0)
	pbadv_setup_101013_Gawain(0,true,19,32,0)
	pbadv_setup_101018_Ragnar(0,true,19,33,0)
	pbadv_setup_101015_Arthur(0,true,20,30,0)
	pbadv_setup_101010_Lancelot(0,true,23,34,0)
	pbadv_setup_101012_Dinatan(0,true,19,34,0)
	pbadv_setup_101017_Maladisant(0,true,18,34,0)
		
	
	dotfriendly_forces1_1 = dot_reserve_ally(401035001, 18, 32, 0)
	dot_set_weapon(dotfriendly_forces1_1, 101010001)
	
	dotfriendly_forces1_2 = dot_reserve_ally(401035001, 18, 33, 0)
	dot_set_weapon(dotfriendly_forces1_2, 104010001)
	
	
	
	
	dotfriendly_forces1_4 = dot_reserve_ally(401035001, 17, 32, 0)
	dot_set_weapon(dotfriendly_forces1_4, 102020001)
	
	dotfriendly_forces1_5 = dot_reserve_ally(401035001, 17, 33, 0)
	dot_set_weapon(dotfriendly_forces1_5, 103010001)
	
	dotfriendly_forces1_6 = dot_reserve_ally(401035001, 17, 34, 0)
	dot_set_weapon(dotfriendly_forces1_6, 105010001)
	
	dotfriendly_forces2_1 = dot_reserve_ally(401035001, 24, 32, 0)
	dot_set_weapon(dotfriendly_forces2_1, 102020001)
	
	dotfriendly_forces2_2 = dot_reserve_ally(401035001, 24, 33, 0)
	dot_set_weapon(dotfriendly_forces2_2, 105010001)
	
	dotfriendly_forces2_3 = dot_reserve_ally(401035001, 24, 34, 0)
	dot_set_weapon(dotfriendly_forces2_3, 103010001)
	
	dotfriendly_forces2_4 = dot_reserve_ally(401035001, 25, 32, 0)
	dot_set_weapon(dotfriendly_forces2_4, 108010001)
	
	dotfriendly_forces2_5 = dot_reserve_ally(401035001, 25, 33, 0)
	dot_set_weapon(dotfriendly_forces2_5, 104010001)
	
	dotfriendly_forces2_6 = dot_reserve_ally(401035001, 25, 34, 0)
	dot_set_weapon(dotfriendly_forces2_6, 101010001)
	
		
	
	setup_complete_unit()
	
	
	dot_disp_weapon(dotfriendly_forces2_1,false)
	dot_disp_weapon(dotfriendly_forces2_2,false)
	dot_disp_weapon(dotfriendly_forces2_3,false)
	dot_disp_weapon(dotfriendly_forces2_4,false)
	dot_disp_weapon(dotfriendly_forces2_5,false)
	dot_disp_weapon(dotfriendly_forces2_6,false)
	dot_disp_weapon(dotfriendly_forces1_1,false)
	dot_disp_weapon(dotfriendly_forces1_2,false)
	
	dot_disp_weapon(dotfriendly_forces1_4,false)
	dot_disp_weapon(dotfriendly_forces1_5,false)
	dot_disp_weapon(dotfriendly_forces1_6,false)
	dot_disp_weapon(dotGuinevere1,false)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotElaine1,false)
	dot_disp_weapon(dotLovein,false)
	dot_disp_weapon(dotRagnar,false)
	dot_disp_weapon(dotGawain,false)
	dot_disp_weapon(dotMaladisant,false)
	dot_disp_weapon(dotDinatan,false)
	dot_disp_weapon(dotLancelot,false)
	
	
	
	dot_unit_dir(dotfriendly_forces2_1, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_2, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_3, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_4, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_5, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_6, DotDir_Left)
	dot_unit_dir(dotElaine1, DotDir_Left)
	dot_unit_dir(dotLovein, DotDir_Left)
	dot_unit_dir(dotLancelot,DotDir_Left)
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	move_camera(20,30, 0.0)
	
	
	Ef_Salas = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Salas_Gate", false, true)
	Ef_Salas2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Salas_Cross", true, true)
	Ef_Flash01_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Warp_IN1=load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true) 
	Ef_Warp_IN2=load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true) 
	
	local gridpos = get_grid_position(21,28)
	set_pos(Ef_Salas, gridpos)
	play_particle(Ef_Salas)
	local gridpos2 = get_grid_position(21,27)
	set_pos(Ef_Salas2, gridpos2)
	play_particle(Ef_Salas2)
	
	load_image("101030300","content_still_10103030_image","101030300_StillImage")
	
	
end




function Play()
	Play_start(true)
	
	
	fadein(0)

	wait_time(0.5)

	dot_change_anim(dotArthur,12)

	wait_time(1.0)

	on_active(Ef_Salas)
	on_active(Ef_Salas2)

	wait_time(1.0)
	
	fadeout(255,255,255,1.0, FADE_TIME)
	wait_time(FADE_TIME)

	wait_time(2.2)
	
	change_camera_distance(8.0, 0.0)
	move_camera(21,35, 0.0)	

	show_image("101030300", 0.0, 0.0, 0.0, true, false)

	fadein(FADE_TIME+1.6)
	wait_time(FADE_TIME)
	wait_time(4.2) 


	hide_image(STILL_SWITCH_TIME) 
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) 

	wait_time(1.0) 
	
	dot_change_anim(dotArthur,0)
	
	wait_time(0.5) 
	
	dot_reserve_move_unit_seq(dotNoir2,21,30)
	dot_reserve_move_unit_seq(dotGuinevere1,22,30)
	exec_parallel_seq()
	
	
	move_camera(21,30, 2.5)
	wait_seq()
	dot_unit_dir(dotNoir2, DotDir_Left)
	dot_unit_dir(dotGuinevere1, DotDir_Left)
	wait_time(1.5)
	
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A900_200002")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_200003")
	
	
	open_select_window_tag(Noir2,"Normal","MA_01A900_200005","MA_01A900_200006","MA_01A900_200007")
	close_speech_window()
	
	
	dot_unit_dir(dotNoir2, DotDir_Right)
	
	if is_select(1) then
		
		
		
		change_face(Noir2, "Smile")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A900_200009")
		close_speech_window()

		
		change_face(Guinevere1, "Shy")
		open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
		message("MA_01A900_200010")
		close_speech_window()

		
		change_face(Arthur, "Smile")
		open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
		message("MA_01A900_200011")
		close_speech_window()
		
		
		
		
		elseif is_select(2) then
		
		
		change_face(Noir2, "Normal")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A900_200013")
		close_speech_window()

		
		change_face(Guinevere1, "Sad")
		open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
		message("MA_01A900_200014")

		
		change_face(Guinevere1, "Smile")
		message("MA_01A900_200015")
		close_speech_window()
		
		
		
		elseif is_select(3) then
		
		
		change_face(Noir2, "Surprise")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A900_200017")
		close_speech_window()

		
		change_face(Guinevere1, "Normal")
		open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
		message("MA_01A900_200018")

		
		change_face(Guinevere1, "Smile")
		message("MA_01A900_200019")
		close_speech_window()
	
	
	end
	
	
	wait_time(1.0)
	
	
	
	
	
	dot_unit_dir(dotGuinevere1, DotDir_Right)
	
	wait_time(0.5)
	
	
	open_cutin(2,1)
	
	on_cutin(1, Guinevere1, "Normal", 3)
	on_cutin(2, Elaine1, "Surprise", 3)
	wait_time(2.0)
	on_cutin(2, Elaine1, "Smile", 3)
	wait_time(1.5)
	on_cutin(1, Guinevere1, "Smile", 3)
	wait_time(2.5)
	
	
	close_cutin()
	wait_time(0.5)
	
	
	change_face(Guinevere1, "Smile")
	dot_unit_dir(dotGuinevere1, DotDir_Left)
	
	
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_200021")
	close_speech_window()
	
	
	dot_unit_dir(dotNoir2, DotDir_Left)
	
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A900_200022")
	
	
	
	
	message("MA_01A900_200023")
	close_speech_window()
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_200024")
	close_speech_window()

	
	change_face(Guinevere1, "Normal")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_200025")
	close_speech_window()

	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A900_200026")
	close_speech_window()
	
	
	
	open_cutin(2,1)
	
	on_cutin(1, Noir2, "Smile", 1)
	on_cutin(2, Guinevere1, "Smile", 1)

	
	open_speech_window("CHRNAME_NOIR_GUINEVERE", nil, nil)
	message("MA_01A900_200027")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)
	
	
	dot_reserve_move_unit_seq(dotNoir2,21,29)
	dot_reserve_move_unit_seq(dotGuinevere1,22,29)
	exec_parallel_seq()

	on_active(Ef_Flash01_1)
	on_active(Ef_Flash01_2)
	on_active(Ef_Warp_IN1)
	on_active(Ef_Warp_IN2)
	
	local gridpos=get_grid_position(21,29)
	set_pos(Ef_Warp_IN1,gridpos)
	play_particle(Ef_Warp_IN1)
	local gridpos=get_grid_position(21,29)
	set_pos(Ef_Flash01_1,gridpos)
	play_particle(Ef_Flash01_1)
	
	local gridpos=get_grid_position(22,29)
	set_pos(Ef_Warp_IN2,gridpos)
	play_particle(Ef_Warp_IN2)
	local gridpos=get_grid_position(22,29)
	set_pos(Ef_Flash01_2,gridpos)
	play_particle(Ef_Flash01_2)
	
	wait_seq()
	
	dot_remove_unit(dotNoir2)
	dot_remove_unit(dotGuinevere1)

	fadeout(0,0,0,0,1.5)

	wait_time(1.5)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,21,38,0)
	pbadv_setup_101011_Guinevere_preload(1,true,21,37,0)
	pbadv_setup_101030_Elaine_preload(1,true,23,32,0)
	pbadv_setup_101031_Lovein_preload(0,true,23,33,0)
	pbadv_setup_101013_Gawain_preload(0,true,19,32,0)
	pbadv_setup_101018_Ragnar_preload(0,true,19,33,0)
	pbadv_setup_101015_Arthur_preload(0,true,20,30,0)
	pbadv_setup_101010_Lancelot_preload(0,true,23,34,0)
	pbadv_setup_101012_Dinatan_preload(0,true,19,34,0)
	pbadv_setup_101017_Maladisant_preload(0,true,18,34,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Salas_Gate", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Salas_Cross", true, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_IN_ADV",false,true)
	load_image_preload("101030300","content_still_10103030_image","101030300_StillImage")
end
