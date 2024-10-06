Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201200000", "201200000")
	change_time_and_weather(1,1)
	
	
	stillAnime = load_ui_effect("content_still_10103006_anim", "10103006_StillAnim", nil, nil, nil, "Root")
	
	pbadv_setup_101009_Noir(2,true,21,32,0)
	pbadv_setup_101011_Guinevere(0,true,21,33,0)
	pbadv_setup_101010_Lancelot(0,true,20,32,0)
	pbadv_setup_101030_Elaine(0,true,20,34,0)
	pbadv_setup_101031_Lovein(0,true,27,32,0)
	pbadv_setup_101013_Gawain(0,true,19,33,0)
	pbadv_setup_101018_Ragnar(0,true,19,32,0)
	pbadv_setup_101026_Percival(0,true,19,34,0)
	pbadv_setup_101024_Bors(0,true,19,35,0)
	pbadv_setup_101034_Excelia(0,true,18,33,0)
	pbadv_setup_101035_Liliana(0,true,18,32,0)
	pbadv_setup_101036_Viena(0,true,18,35,0)
	pbadv_setup_101028_Galahad(1,true,18,34,0)
	
	pbadv_setup_101011_Guinevere(1,true,18,17,0)
	pbadv_setup_101018_Ragnar(1,true,20,17,0)
	pbadv_setup_101031_Lovein(1,true,19,17,0)
	pbadv_setup_101034_Excelia(1,true,18,18,0)
	pbadv_setup_101035_Liliana(1,true,19,18,0)
	pbadv_setup_101036_Viena(1,true,20,18,0)
	
	
	dotfriendly_forces1_1 = dot_reserve_ally(401035001, 13, 35, 0)
	dot_set_weapon(dotfriendly_forces1_1, 101010001)
	
	dotfriendly_forces1_2 = dot_reserve_ally(401035001, 14, 35, 0)
	dot_set_weapon(dotfriendly_forces1_2, 104010001)
	
	dotfriendly_forces1_3 = dot_reserve_ally(401035001, 15, 35, 0)
	dot_set_weapon(dotfriendly_forces1_3, 108010001)
	
	dotfriendly_forces1_4 = dot_reserve_ally(401035001, 16, 35, 0)
	dot_set_weapon(dotfriendly_forces1_4, 102020001)
	
	dotfriendly_forces1_5 = dot_reserve_ally(401035001, 12, 36, 0)
	dot_set_weapon(dotfriendly_forces1_5, 103010001)
	
	dotfriendly_forces1_6 = dot_reserve_ally(401035001, 13, 36, 0)
	dot_set_weapon(dotfriendly_forces1_6, 105010001)
	
	dotfriendly_forces2_1 = dot_reserve_ally(401035001, 14, 36, 0)
	dot_set_weapon(dotfriendly_forces2_1, 102020001)
	
	dotfriendly_forces2_2 = dot_reserve_ally(401035001, 15, 36, 0)
	dot_set_weapon(dotfriendly_forces2_2, 105010001)
	
	dotfriendly_forces2_3 = dot_reserve_ally(401035001, 11, 37, 0)
	dot_set_weapon(dotfriendly_forces2_3, 103010001)
	
	dotfriendly_forces2_4 = dot_reserve_ally(401035001, 12, 37, 0)
	dot_set_weapon(dotfriendly_forces2_4, 108010001)
	
	dotfriendly_forces2_5 = dot_reserve_ally(401035001, 13, 37, 0)
	dot_set_weapon(dotfriendly_forces2_5, 104010001)
	
	dotfriendly_forces2_6 = dot_reserve_ally(401035001, 14, 37, 0)
	dot_set_weapon(dotfriendly_forces2_6, 101010001)

	
	roma1 = dot_reserve_ally(401040001, 27, 20, 0)
	dot_set_weapon(roma1, 101010001)
	roma2 = dot_reserve_ally(401040001, 25, 25, 0)
	dot_set_weapon(roma2, 101010001)
	roma3 = dot_reserve_ally(401040001, 26, 24, 0)
	dot_set_weapon(roma3, 101010001)
	roma4 = dot_reserve_ally(401040001, 30, 26, 0)
	dot_set_weapon(roma4, 101010001)
	roma5 = dot_reserve_ally(401040001, 28, 22, 0)
	dot_set_weapon(roma5, 101010001)
	roma6 = dot_reserve_ally(401039001, 34, 25, 0)
	dot_set_weapon(roma6, 101010001)
	barbaroi1 = dot_reserve_enemy(600, 34,22, 0)
	barbaroi2 = dot_reserve_enemy(600, 31,25, 0)
	barbaroi3 = dot_reserve_enemy(600, 33,24, 0)
	barbaroi4 = dot_reserve_enemy(600, 37,20, 0)
	barbaroi5 = dot_reserve_enemy(600, 26,23, 0)
	barbaroi6 = dot_reserve_enemy(600, 35,26, 0)
	barbaroi7 = dot_reserve_enemy(506, 33,22, 0)
	
	
	
	setup_complete_unit()
	
	
	dot_disp_unit(roma1,true)
	dot_disp_unit(roma2,true)
	dot_disp_unit(roma3,true)
	dot_disp_unit(roma4,true)
	dot_disp_unit(roma5,true)
	dot_disp_unit(roma6,true)

	dot_disp_unit(dotLovein,false)
	
	dot_disp_unit(dotGuinevere1,false)
	dot_disp_unit(dotLovein1,false)
	dot_disp_unit(dotRagnar1,false)
	dot_disp_unit(dotExcelia1,false)
	dot_disp_unit(dotLiliana1,false)
	dot_disp_unit(dotViena1,false)
	
	
	
	
	
	
	
	dot_unit_dir(roma1,2)
	dot_unit_dir(roma2,2)
	dot_unit_dir(roma3,2)
	dot_unit_dir(roma4,2)
	dot_unit_dir(roma5,2)
	dot_unit_dir(roma6,2)
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(33,24, 0.0)
	
	Ef_Emblem21=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem21",false,true)
	Ef_Emblem01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	Ef_Emblem05_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem05",false,true)
	Ef_Emblem05_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem05",false,true)
	Ef_Emblem07_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem07",false,true)
	Ef_Emblem07_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem07",false,true)
	Ef_Emblem11=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem11",false,true)
	Ef_Emblem12=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem12",false,true)
	Ef_Emblem18_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem18",false,true)
	Ef_Emblem18_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem18",false,true)
	
	Ef_Killers1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Killers2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Killers3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Killers4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Killers5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Killers6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Change_K_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_Change_K_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_Change_K_3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_Change_K_4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_Change_K_5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_Change_K_6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_VibesAura_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_VibesAura_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_VibesAura_3=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_VibesAura_4=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
end





function Play()
	fadein(0)
	Play_start(true)
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300002")
	close_speech_window()
	
	
	
	move_camera(19,33, 2.0)
	wait_camera()
		
	
	dot_disp_unit(dotLovein,true)
	dot_move_unit_seq(dotLovein,22,33)
	wait_seq()
	dot_unit_dir(dotLovein, DotDir_Left)
	
	
	change_face(Lovein,"Normal")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01A111_300004")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300005")
	close_speech_window()

	
	change_face(Gawain,"Sad")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01A111_300007")
	close_speech_window()

	
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01A111_300008")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300009")
	close_speech_window()
	
	
	dot_move_unit_seq(dotGuinevere,21,34)
	wait_seq()
	dot_unit_dir(dotGuinevere, DotDir_Left)
	wait_time(0.50)
	
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300011")
	close_speech_window()

	
	change_face(Elaine,"Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine, nil)
	message("MA_01A111_300013")
	close_speech_window()

	
	change_face(Guinevere,"Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300014")
	close_speech_window()

	
	change_face(Elaine,"Surprise")
	open_speech_window("CHRNAME_ELAINE", Elaine, nil)
	message("MA_01A111_300016")

	
	message("MA_01A111_300017")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300018")
	close_speech_window()

	
	change_face(Elaine,"Smile")
	open_speech_window("CHRNAME_ELAINE", Elaine, nil)
	message("MA_01A111_300019")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300020")
	close_speech_window()
	
	
	dot_move_unit_seq(dotLovein,22,35)
	wait_seq()
	dot_move_unit_seq(dotLovein,20,35)
	wait_seq()
	dot_unit_dir(dotLovein, DotDir_Right)
	wait_time(0.50)
	
	
	dot_unit_dir(dotNoir2, DotDir_Left)
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_300022")
	close_speech_window()

	
	change_face(Viena,"Anger")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01A111_300023")
	close_speech_window()

	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA", Excelia, nil)
	message("MA_01A111_300024")
	close_speech_window()

	
	change_face(Liliana,"Anger")
	open_speech_window("CHRNAME_LILIANA", Liliana, nil)
	message("MA_01A111_300025")
	close_speech_window()

	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A111_300026")
	close_speech_window()

	
	change_face(Lancelot,"Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01A111_300027")
	close_speech_window()

	
	change_face(Galahad1,"Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01A111_300028")
	close_speech_window()

	
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01A111_300029")
	close_speech_window()

	change_camera_angle(30.0, 2.0)

	

	move_camera(13,35, 2.0)


	dot_move_unit_seq(dotGuinevere,13,34)

	wait_seq()
	dot_unit_dir(dotfriendly_forces1_2, DotDir_Left)
	dot_unit_dir(dotfriendly_forces1_3, DotDir_Left)
	dot_unit_dir(dotfriendly_forces1_4, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_1, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_2, DotDir_Left)
	dot_unit_dir(dotfriendly_forces2_6, DotDir_Left)
	wait_time(2.0)

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300031")

	
	message("MA_01A111_300032")

	
	message("MA_01A111_300033")

	
	message("MA_01A111_300034")

	
	message("MA_01A111_300035")

	
	message("MA_01A111_300036")
	
	open_select_window_tag(Noir2,"Normal","MA_01A111_300038","MA_01A111_300039","MA_01A111_300040")
	close_speech_window()
	
	if is_select(1) then
		
		dot_move_unit_seq(dotNoir2,14,34)
		
		move_camera(14,34, 1.0)
		wait_time(1.0)
		wait_seq()

		
		change_face(Noir2,"Smile")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_300042")
		close_speech_window()
		
		dot_unit_dir(dotGuinevere, DotDir_Right)
		
		
		change_face(Guinevere,"Smile")
		open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
		message("MA_01A111_300043")

		
		message("MA_01A111_300044")
		close_speech_window()
		
		
		
		dot_unit_dir(dotNoir2, DotDir_Right)
		
		
		change_face(Ragnar,"Anger")
		open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
		message("MA_01A111_300057")
		close_speech_window()
	
		
		dot_reserve_move_unit_seq(dotNoir2,21,32)
		
		dot_reserve_move_unit_seq(dotGuinevere,21,33)
		
	elseif is_select(2) then
		
		move_camera(20,33, 1.0)
		wait_time(1.0)
		
		change_face(Noir2,"Anger")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_300046")
		close_speech_window()

		
		change_face(Gawain,"Anger")
		open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
		message("MA_01A111_300047")
		close_speech_window()

		
		change_face(Ragnar,"Anger")
		open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
		message("MA_01A111_300048")
		close_speech_window()

		
		open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
		message("MA_01A111_300049")

		
		change_face(Gawain,"Smile")
		message("MA_01A111_300051")
		close_speech_window()
		
		
		dot_unit_dir(dotNoir2, DotDir_Right)

		
		change_face(Ragnar,"Anger")
		open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
		message("MA_01A111_300057")
		close_speech_window()
	

		
		dot_reserve_move_unit_seq(dotGuinevere,21,33)
	
		
	elseif is_select(3) then
		
		move_camera(20,32, 1.0)
		wait_time(0.5)
		dot_move_unit_seq(dotNoir2,21,34)
		wait_seq()
		dot_unit_dir(dotNoir2, DotDir_Left)
		wait_time(0.5)
		
		change_face(Noir2,"Anger")
		open_speech_window("CHRNAME_NOIR", Noir2, nil)
		message("MA_01A111_300053")
		close_speech_window()

		
		change_face(Elaine,"Anger")
		open_speech_window("CHRNAME_ELAINE", Elaine, nil)
		message("MA_01A111_300054")

		
		message("MA_01A111_300055")
		close_speech_window()
		
		dot_move_unit_seq(dotNoir2,21,32)
		wait_seq()
		
		dot_unit_dir(dotNoir2, DotDir_Right)

		
		change_face(Ragnar,"Anger")
		open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
		message("MA_01A111_300057")
		close_speech_window()
		

		
		dot_reserve_move_unit_seq(dotGuinevere,21,33)
	
	end
	
	
	
	fadeout(0, 0, 0, 0, STILL_SWITCH_TIME )
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
	stillAnime.SetActive(true)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	
	change_camera_angle(25.0, 0.0)
	move_camera(20,33, 0.0)

	
	exec_parallel_seq()
		
	
	dot_unit_dir(dotfriendly_forces1_2,DotDir_Right)
	dot_unit_dir(dotfriendly_forces1_3,DotDir_Right)
	dot_unit_dir(dotfriendly_forces1_4,DotDir_Right)
	dot_unit_dir(dotfriendly_forces2_2,DotDir_Right)
	dot_unit_dir(dotfriendly_forces2_1,DotDir_Right)
	dot_unit_dir(dotfriendly_forces2_6,DotDir_Right)
	
	wait_seq()
	dot_unit_dir(dotGuinevere, DotDir_Right)
	wait_time(1.0)
	
	
	
	
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
	coroutine.yield()
		end
	fadeout(0, 0, 0, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
	stillAnime.SetActive(false)
	fadein(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
	
	
	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A111_300058")
	close_speech_window()
	
	on_active(Ef_Emblem21)
	on_active(Ef_Emblem01)
	on_active(Ef_Emblem05_1)
	on_active(Ef_Emblem05_2)
	on_active(Ef_Emblem07_1)
	on_active(Ef_Emblem07_2)
	on_active(Ef_Emblem18_1)
	on_active(Ef_Emblem18_2)
	on_active(Ef_Emblem11)
	on_active(Ef_Emblem12)
	
	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_Emblem21,locatorpos)
	local locatorpos = dot_get_unit_locator(dotElaine,1)
	set_pos(Ef_Emblem07_1,locatorpos)
	local locatorpos = dot_get_unit_locator(dotGawain,1)
	set_pos(Ef_Emblem05_1,locatorpos)
	local locatorpos = dot_get_unit_locator(dotGalahad1,1)
	set_pos(Ef_Emblem18_1,locatorpos)
	
	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_Emblem01,locatorpos)
	local locatorpos = dot_get_unit_locator(dotLovein,1)
	set_pos(Ef_Emblem07_2,locatorpos)
	local locatorpos = dot_get_unit_locator(dotRagnar,1)
	set_pos(Ef_Emblem05_2,locatorpos)
	local locatorpos = dot_get_unit_locator(dotLiliana,1)
	set_pos(Ef_Emblem12,locatorpos)
	local locatorpos = dot_get_unit_locator(dotExcelia,1)
	set_pos(Ef_Emblem11,locatorpos)
	local locatorpos = dot_get_unit_locator(dotViena,1)
	set_pos(Ef_Emblem18_2,locatorpos)
	
	
	wait_time(2.0)
	
	on_active(Ef_VibesAura_1)
	on_active(Ef_VibesAura_2)
	on_active(Ef_VibesAura_3)
	on_active(Ef_VibesAura_4)
	
	on_active(Ef_Killers1)
	on_active(Ef_Killers2)
	on_active(Ef_Killers3)
	on_active(Ef_Killers4)
	on_active(Ef_Killers5)
	on_active(Ef_Killers6)
	
	local gridpos=get_grid_position(21,32)
	set_pos(Ef_VibesAura_1,gridpos)
	play_particle(Ef_VibesAura_1)
	local gridpos=get_grid_position(20,34)
	set_pos(Ef_VibesAura_2,gridpos)
	play_particle(Ef_VibesAura_2)
	local gridpos=get_grid_position(19,33)
	set_pos(Ef_VibesAura_3,gridpos)
	play_particle(Ef_VibesAura_3)
	local gridpos=get_grid_position(18,34)
	set_pos(Ef_VibesAura_4,gridpos)
	play_particle(Ef_VibesAura_4)
	
	local gridpos=get_grid_position(21,33)
	set_pos(Ef_Killers1,gridpos)
	play_particle(Ef_Killers1)
	local gridpos=get_grid_position(20,35)
	set_pos(Ef_Killers2,gridpos)
	play_particle(Ef_Killers2)
	local gridpos=get_grid_position(19,32)
	set_pos(Ef_Killers3,gridpos)
	play_particle(Ef_Killers3)
	local gridpos=get_grid_position(18,32)
	set_pos(Ef_Killers4,gridpos)
	play_particle(Ef_Killers4)
	local gridpos=get_grid_position(18,33)
	set_pos(Ef_Killers5,gridpos)
	play_particle(Ef_Killers5)
	local gridpos=get_grid_position(18,35)
	set_pos(Ef_Killers6,gridpos)
	play_particle(Ef_Killers6)

	wait_time(1.5)

	on_active(Ef_Change_K_1)
	on_active(Ef_Change_K_2)
	on_active(Ef_Change_K_3)
	on_active(Ef_Change_K_4)
	on_active(Ef_Change_K_5)
	on_active(Ef_Change_K_6)
	
	local gridpos=get_grid_position(21,33)
	set_pos(Ef_Change_K_1,gridpos)
	play_particle(Ef_Change_K_1)
	local gridpos=get_grid_position(20,35)
	set_pos(Ef_Change_K_2,gridpos)
	play_particle(Ef_Change_K_2)
	local gridpos=get_grid_position(19,32)
	set_pos(Ef_Change_K_3,gridpos)
	play_particle(Ef_Change_K_3)
	local gridpos=get_grid_position(18,32)
	set_pos(Ef_Change_K_4,gridpos)
	play_particle(Ef_Change_K_4)
	local gridpos=get_grid_position(18,33)
	set_pos(Ef_Change_K_5,gridpos)
	play_particle(Ef_Change_K_5)
	local gridpos=get_grid_position(18,35)
	set_pos(Ef_Change_K_6,gridpos)
	play_particle(Ef_Change_K_6)

	wait_time(0.7)

	dot_change_unit(dotGuinevere,dotGuinevere1,0.0)
	dot_change_unit(dotLovein,dotLovein1,0.0)
	dot_change_unit(dotRagnar,dotRagnar1,0.0)
	dot_change_unit(dotExcelia,dotExcelia1,0.0)
	dot_change_unit(dotLiliana,dotLiliana1,0.0)
	dot_change_unit(dotViena,dotViena1,0.0)
	
	wait_time(1.5)

	stop_particle(Ef_Killers1)
	stop_particle(Ef_Killers2)
	stop_particle(Ef_Killers3)
	stop_particle(Ef_Killers4)
	stop_particle(Ef_Killers5)
	stop_particle(Ef_Killers6)
	stop_particle(Ef_Change_K_1)
	stop_particle(Ef_Change_K_2)
	stop_particle(Ef_Change_K_3)
	stop_particle(Ef_Change_K_4)
	stop_particle(Ef_Change_K_5)
	stop_particle(Ef_Change_K_6)
	stop_particle(Ef_VibesAura_1)
	stop_particle(Ef_VibesAura_2)
	stop_particle(Ef_VibesAura_3)
	stop_particle(Ef_VibesAura_4)

	wait_time(2.5)
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_ui_effect_preload("content_still_10103006_anim", "10103006_StillAnim", nil, nil, nil, "Root")
	pbadv_setup_101009_Noir_preload(2,true,21,32,0)
	pbadv_setup_101011_Guinevere_preload(0,true,21,33,0)
	pbadv_setup_101010_Lancelot_preload(0,true,20,32,0)
	pbadv_setup_101030_Elaine_preload(0,true,20,34,0)
	pbadv_setup_101031_Lovein_preload(0,true,27,32,0)
	pbadv_setup_101013_Gawain_preload(0,true,19,33,0)
	pbadv_setup_101018_Ragnar_preload(0,true,19,32,0)
	pbadv_setup_101026_Percival_preload(0,true,19,34,0)
	pbadv_setup_101024_Bors_preload(0,true,19,35,0)
	pbadv_setup_101034_Excelia_preload(0,true,18,33,0)
	pbadv_setup_101035_Liliana_preload(0,true,18,32,0)
	pbadv_setup_101036_Viena_preload(0,true,18,35,0)
	pbadv_setup_101028_Galahad_preload(1,true,18,34,0)
	pbadv_setup_101011_Guinevere_preload(1,true,18,17,0)
	pbadv_setup_101018_Ragnar_preload(1,true,20,17,0)
	pbadv_setup_101031_Lovein_preload(1,true,19,17,0)
	pbadv_setup_101034_Excelia_preload(1,true,18,18,0)
	pbadv_setup_101035_Liliana_preload(1,true,19,18,0)
	pbadv_setup_101036_Viena_preload(1,true,20,18,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem21",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem05",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem05",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem07",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem07",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem11",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem12",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem18",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem18",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
end
