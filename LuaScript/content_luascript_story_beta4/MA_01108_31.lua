
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	load_image("10301026", "content_still_10301026_image", "103010260_StillImage")
	
load_image("103010251", "content_still_10301025_image", "103010251_StillImage")

load_image("103010252", "content_still_10301025_image", "103010252_StillImage")

load_image("103010253", "content_still_10301025_image", "103010253_StillImage")

load_image("101010140", "content_still_10101014_image", "101010140_StillImage")

load_image("10201014",  "content_still_10201014_image", "102010140_StillImage")
show_image("10201014", 0.0, 0.0, 0 ,true,false)



	
	

	
	
	
	init_psbattleadv("201130000", "201130000")
	
	

	
    pbadv_setup_101009_Noir(2,true,21,18,0)
    
    
    pbadv_setup_101011_Guinevere(0,true,20,20,0)
    
    
    pbadv_setup_101028_Galahad(0,true,20,19,0)
    
    
    pbadv_setup_101015_Arthur(0,true,20,18,0)
    
    
    pbadv_setup_101010_Lancelot(0,true,22,18,0)
    
    
    pbadv_setup_101012_Dinatan(0,true,22,19,0)
    
    
	pbadv_setup_101058_Laiens(1,true,21 ,8 ,0)
	
	
	pbadv_setup_101043_Mazoe(true,22 ,8 ,0)  
	
	
	pbadv_setup_101042_Moronoe(true,20 ,8 ,0)  
	
	
	pbadv_setup_101034_Excelia(2,false,1 ,2 ,0) 
	
	
	pbadv_setup_101035_Liliana(2,false,1 ,3 ,0)  
	
	
	pbadv_setup_101050_Brian(0,true,22 ,9 ,0) 
	
	
	
	pbadv_setup_101021_Bruno(3,true,22 ,20 ,0) 
	
	
	pbadv_setup_101055_Owen(0,true,21 ,2 ,0) 
	
	
    pbadv_setup_101029_Astera(0,true,21,19,0)
	

	
	barubaB = dot_reserve_ally(201020001, 4, 4, 0)
	dot_set_weapon(barubaB, 104010001)

		
	
	
	
	
	barbaroi = dot_reserve_enemy(1100,20 ,5 , 0)
	barbaroi2 = dot_reserve_enemy(1100,21 ,5 , 0)
	barbaroi3 = dot_reserve_enemy(1100,22 ,5 , 0)
	barbaroi4 = dot_reserve_enemy(1100,19 ,6 , 0)
	barbaroi5 = dot_reserve_enemy(49,20 ,6 , 0)
	barbaroi6 = dot_reserve_enemy(49,21 ,6 , 0)
	barbaroi7 = dot_reserve_enemy(49,22 ,6 , 0)
	barbaroi8 = dot_reserve_enemy(1100,23 ,6 , 0)
	barbaroi9 = dot_reserve_enemy(1100,19 ,7 , 0)
	barbaroi10 = dot_reserve_enemy(1100,23 ,7 , 0)
	barbaroi11 = dot_reserve_enemy(49,19 ,8 , 0)
	barbaroi12 = dot_reserve_enemy(49,23 ,8 , 0)
	barbaroi13 = dot_reserve_enemy(49,19 ,9 , 0)
	barbaroi14 = dot_reserve_enemy(49,23 ,9 , 0)
	barbaroi15 = dot_reserve_enemy(49,19 ,10 , 0)
	barbaroi16 = dot_reserve_enemy(49,23 ,10 , 0)
	
	barbaroi23 = dot_reserve_enemy(1100,14 ,6 , 0)
	barbaroi17 = dot_reserve_enemy(1100,14 ,7 , 0)
	barbaroi18 = dot_reserve_enemy(3,14 ,8 , 0)
	barbaroi19 = dot_reserve_enemy(1100,15 ,6 , 0)
	barbaroi20 = dot_reserve_enemy(49,15 ,7 , 0)
	barbaroi21 = dot_reserve_enemy(49,15 ,8 , 0)
	barbaroi24 = dot_reserve_enemy(1100,27 ,6 , 0)
	barbaroi25 = dot_reserve_enemy(1100,27 ,7 , 0)
	barbaroi26 = dot_reserve_enemy(1100,27 ,8 , 0)
	barbaroi27 = dot_reserve_enemy(49,28 ,6 , 0)
	barbaroi28 = dot_reserve_enemy(49,28 ,7 , 0)
	barbaroi29 = dot_reserve_enemy(49,28 ,8 , 0)
	
	
	barbaroi_m = dot_reserve_enemy(3,17 ,11 , 0)
	barbaroi_m2 = dot_reserve_enemy(3,25 ,11 , 0)
	barbaroi_m3 = dot_reserve_enemy(3,20 ,12 , 0)
	barbaroi_m4 = dot_reserve_enemy(3,22 ,12 , 0)
	barbaroi_m5 = dot_reserve_enemy(3,25 ,6 , 0)
	barbaroi_m6 = dot_reserve_enemy(3,17 ,6 , 0)
	barbaroi_m7 = dot_reserve_enemy(3,26 ,5 , 0)
	barbaroi_m8 = dot_reserve_enemy(1100,16 ,5 , 0)
	barbaroi_m9 = dot_reserve_enemy(3,20 ,3 , 0)
	barbaroi_m10 = dot_reserve_enemy(3,21 ,3 , 0)
	barbaroi_m11 = dot_reserve_enemy(3,22 ,3 , 0)
	
	
	
	change_time_and_weather(2,7)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(dotLaiens1, 2)
	dot_unit_dir(dotBrian, 2)
	
	dot_change_anim(dotBrian,1) 



	
	
	dot_disp_unit(barubaB, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)
	dot_disp_unit(barbaroi13, false)
	dot_disp_unit(barbaroi14, false)
	dot_disp_unit(barbaroi15, false)
	dot_disp_unit(barbaroi16, false)
	dot_disp_unit(barbaroi_m5, false)
	dot_disp_unit(barbaroi_m6, false)
	dot_disp_unit(barbaroi_m7, false)
	dot_disp_unit(barbaroi_m8, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(21, 7, 0.0)
	
	
	
	Ef_changeBriF = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	
	Ef_changeBri = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	
	Ef_baruba = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	
	
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	Ef_WitchSpear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)

	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)

	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)

	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)

	Ef_Witch1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	
	Ef_Black1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_Black2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	
	Ef_WitchSpear9 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_018", false, true)
	Ef_WitchSpear10 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_018_froat", false, true)

	load_sound("BGM_Battle_Tragedy_TragedyStart")
end

function LancelotMoveSet() 
	local signal1 = dot_move_unit(dotLancelot,22,13)
	wait_proccess(signal1)
	dot_unit_dir(barbaroi_m4,2)
	dot_target_attack(dotLancelot,barbaroi_m4,false)
	dot_change_anim(barbaroi_m4,6)
	
	local signal2 = dot_dying_unit(barbaroi_m4)
	wait_proccess(signal2)
end

function ArthurMoveSet() 
	local signal3 = dot_move_unit(dotArthur,20,13)
	wait_proccess(signal3)
	dot_target_attack(dotArthur,barbaroi_m3,false)
	dot_change_anim(barbaroi_m3,6)
	wait_time(0.1)
	local signal4 = dot_dying_unit(barbaroi_m3)
	wait_proccess(signal4)
end

function NoirMoveSet() 
	local signal5 = dot_move_unit(dotNoir2,21,12)
	wait_proccess(signal5)
	dot_unit_dir(barbaroi_m2,2)
	dot_target_attack(dotNoir2,barbaroi_m2,false)
	dot_change_anim(barbaroi_m2,6)
	wait_time(0.1)
	dot_change_anim(barbaroi_m2,1)
	dot_target_attack(dotNoir2,barbaroi_m2,false)
	dot_change_anim(barbaroi_m2,6)
	wait_time(0.1)
	local signal7 = dot_dying_unit(barbaroi_m2)
	wait_proccess(signal7)
end

function barubaMoveSet() 
	wait_time(0.5)
	local signal8 = dot_move_unit(barbaroi_m2,21,11)
	wait_proccess(signal8)
	
end




function Play()
	fadein(0)
	Play_start(true)


	
	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)
	
	MA_01108_31_select1()
	open_select_window_tag(Noir2, "Normal", "MA_01108_310035", "MA_01108_310036","MA_01108_310037")	
	close_speech_window()	

	if is_select(1) then			
		MA_01108_31_select1_1()
		
	elseif is_select(2) then		
		MA_01108_31_select1_2()
		
	elseif is_select(3) then		
		MA_01108_31_select1_3()

	end
	
	
	MA_01108_31_select2()
	
	open_select_window_tag(Noir2, "Normal", "MA_01108_310078", "MA_01108_310079")	
	close_speech_window()	

	if is_select(1) then			
		MA_01108_31_select2_1()

	elseif is_select(2) then		
		MA_01108_31_select2_2()

	end

	
	MA_01108_31_select3()
	
	open_select_window_tag(Noir2, "Normal", "MA_01108_310137", "MA_01108_310138")	
	close_speech_window()	

	if is_select(1) then			
		MA_01108_31_select3_1()

	elseif is_select(2) then		
		MA_01108_31_select3_2()

	end
	

	MA_01108_31_end()


	end

function MA_01108_31_select1()
	
	dot_dying_unit(barbaroi_m9)
	dot_dying_unit(barbaroi_m11)
	dot_dying_unit(barbaroi_m10)
	
	wait_time(2.0)
	
	move_camera(21, 9, 0.0)
	
	
	on_active(Ef_baruba)
	local gridpos = get_grid_position(26,5)
	set_pos(Ef_baruba, gridpos)
	set_scale(Ef_baruba, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba)
	dot_disp_unit(barbaroi_m7, true)
	wait_seq()
	
	wait_time(0.2)
	
	on_active(Ef_baruba2)
	local gridpos = get_grid_position(16,5)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2)
	dot_disp_unit(barbaroi_m8, true)
	wait_seq()
	
	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310002")
	

	
	
	message("MA_01108_310003")
	
	
	on_active(Ef_baruba3)
	local gridpos = get_grid_position(25,6)
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3)
	dot_disp_unit(barbaroi_m5, true)
	wait_seq()
	
	wait_time(0.2)
	
	on_active(Ef_baruba4)
	local gridpos = get_grid_position(17,6)
	set_pos(Ef_baruba4, gridpos)
	set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4)
	dot_disp_unit(barbaroi_m6, true)
	wait_seq()

	
	
	message("MA_01108_310004")

	
	message("MA_01108_310005")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2",nil , Mazoe)
	message("MA_01108_310006")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil , Moronoe)
	message("MA_01108_310007")
	close_speech_window()

	
	move_camera(21, 2, 1.0)
	wait_seq()
	
	
	
	open_speech_window("CHRNAME_OWEN",Owen , nil)
	message("MA_01108_310009")
	

	
	
	
	message("MA_01108_310011")
	close_speech_window()
	
	
	move_camera(21, 7, 1.0)
	wait_seq()
	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310012")
	

	
	change_face(Laiens1, "Smile")
	
	message("MA_01108_310013")
	

	
	
	message("MA_01108_310014")
	

	
	
	message("MA_01108_310015")
	close_speech_window()

	
	

	
	
	
	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310017")
	close_speech_window()

	
	
	
	move_camera(21, 12, 1.0)

	local LancelotSet = create_coroutine(LancelotMoveSet) 
	local ArthurSet = create_coroutine(ArthurMoveSet) 
	
	coroutine.resume(LancelotSet)  
	coroutine.resume(ArthurSet)  


	pbadv_wait_coroutine(LancelotSet) 
	pbadv_wait_coroutine(ArthurSet) 
	
	dot_change_anim(dotArthur,0)
	dot_change_anim(dotLancelot,0)
	
	move_camera(21, 12, 1.0)
	local NoirSet = create_coroutine(NoirMoveSet) 
	local barubaSet = create_coroutine(barubaMoveSet) 
	
	coroutine.resume(NoirSet)  
	coroutine.resume(barubaSet)  

	pbadv_wait_coroutine(barubaSet) 
	pbadv_wait_coroutine(NoirSet) 
	
	dot_change_anim(dotNoir2,0)
	
	





























	
	
	
	open_speech_window("CHRNAME_OWEN",Owen , nil)
	message("MA_01108_310019")
	close_speech_window()
	
	
	
	dot_reserve_move_unit_seq(dotGalahad,20,14)
	dot_reserve_move_unit_seq(dotAstera,21,14)
	dot_reserve_move_unit_seq(dotDinatan,22,14)
	dot_reserve_move_unit_seq(dotGuinevere,20,15)
	dot_reserve_move_unit_seq(dotBruno3,22,15)
	exec_parallel_seq()
	wait_seq()
	
	move_camera(21, 15, 1.5)
	change_camera_distance(6.0, 1.5)
	
	
	change_face(Astera, "Anger")
	open_speech_window("CHRNAME_ASTERA",Astera , nil)
	message("MA_01108_310020")
	close_speech_window()

	
	change_face(Lancelot, "Anger")	
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01108_310021")
	close_speech_window()

	
	change_face(Galahad, "Surprise")
	open_speech_window("CHRNAME_GALAHAD",Galahad , nil)
	message("MA_01108_310022")
	close_speech_window()

	
	open_speech_window("CHRNAME_ARTHUR",Arthur , nil)
	message("MA_01108_310023")
	close_speech_window()

	
	change_face(Galahad, "Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad , nil)
	message("MA_01108_310024")
	close_speech_window()
	
	
	
	dot_reserve_move_unit_seq(dotGalahad,14,14)
	dot_reserve_move_unit_seq(dotAstera,15,14)
	exec_parallel_seq()
	wait_seq()
	dot_disp_unit(dotGalahad, false)
	dot_disp_unit(dotAstera, false)
	dot_disp_unit(dotOwen, false)
	
	move_camera(21, 12, 1.0)
	change_camera_distance(8.0, 1.0)
	
	
	
	change_face(Laiens1, "Smile")
	open_speech_window("CHRNAME_LAIENS",Laiens1 , nil)
	message("MA_01108_310026")
	close_speech_window()

	
	
	open_speech_window("CHRNAME_ARTHUR",Arthur , nil)
	message("MA_01108_310028")
	

	
	
	message("MA_01108_310029")
	close_speech_window()

	
	
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310031")
	close_speech_window()

	
	
	dot_move_unit_seq(dotBrian,21,9)
	
	change_face(Brian, "Sad")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_310033")
	


end

function MA_01108_31_select1_1()



	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_310039")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_310040")
	close_speech_window()

	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01108_310041")
	close_speech_window()
	
	
	
	change_face(Laiens1, "Smile")	
	open_speech_window("CHRNAME_LAIENS",nil, Laiens1)
	message("MA_01108_310051")
	close_speech_window()
	

		
end


function MA_01108_31_select1_2()



	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_310043")
	close_speech_window()

	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01108_310044")
	close_speech_window()

	
	change_face(Brian, "Smile")
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01108_310045")
	close_speech_window()
	
	
	
	change_face(Laiens1, "Smile")	
	open_speech_window("CHRNAME_LAIENS",nil, Laiens1)
	message("MA_01108_310051")
	close_speech_window()


		
end


function MA_01108_31_select1_3()




	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_310047")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_310048")
	

	
	change_face(Laiens1, "Normal")
	
	message("MA_01108_310049")
	
	
	
	
	change_face(Laiens1, "Smile")	
	
	message("MA_01108_310051")
	close_speech_window()


		
end

function MA_01108_31_select2()	

	
	
	
	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotMazoe, false)

	
	on_active(Ef_WitchSpear1) 
	on_active(Ef_WitchSpear2) 
	

	on_active(Ef_WSpearAppea1) 
	on_active(Ef_WSpearAppea2) 

	on_active(Ef_WSpearAura1) 
	on_active(Ef_WSpearAura2) 


	local gridpos = get_grid_position(20, 9)
	gridpos[2] = 2.0	
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,45, -90, 0, 0.0)
	play_particle(Ef_WSpearAppea1)

	local gridpos = get_grid_position(22, 9)
	gridpos[2] = 2.0
	set_pos(Ef_WSpearAppea2, gridpos)
	turn(Ef_WSpearAppea2,45, 90, 0, 0.0)
	play_particle(Ef_WSpearAppea2)


	wait_time(0.5)
	
	
	local gridpos = get_grid_position(20, 9)
	gridpos[2] = 2.0
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1, 45, -90, 0, 0.0)
	play_particle(Ef_WitchSpear1)

	set_pos(Ef_WSpearAura1, gridpos)
	turn(Ef_WSpearAura1,45, -90, 0, 0.0)
	play_particle(Ef_WSpearAura1)

	
	local gridpos = get_grid_position(22, 9)
	gridpos[2] = 2.0
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2, 45, 90, 0, 0.0)
	play_particle(Ef_WitchSpear2)
	
	set_pos(Ef_WSpearAura2, gridpos)
	turn(Ef_WSpearAura2,45, 90, 0, 0.0)
	play_particle(Ef_WSpearAura2)
	

	wait_time(1.0)

	local gridpos = get_grid_position(21, 9)
	gridpos[2] = 1.11

	slidemove(Ef_WitchSpear1, gridpos, 0.1)
	slidemove(Ef_WSpearAura1, gridpos, 0.1)

	slidemove(Ef_WitchSpear2, gridpos, 0.1)
	slidemove(Ef_WSpearAura2, gridpos, 0.1)

	wait_time(0.1)

	on_active(Ef_WitchSpearHit1) 
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	dot_change_anim(dotBrian,6)
	
	
	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310053")
	close_speech_window()
	
	
	dot_change_anim(dotBrian,1)
	
	local gridpos = get_grid_position(21, 9)
	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)

	wait_time(0.3)

	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)

	stop_particle(Ef_WitchSpear2)
	stop_particle(Ef_WSpearAura2)

	
	on_active(Ef_Witch1) 
	
	local gridpos = get_grid_position(22 ,8)
	set_pos(Ef_Witch1, gridpos)
	play_particle(Ef_Witch1)

	on_active(Ef_Witch2) 
	
	local gridpos = get_grid_position(20 ,8)
	set_pos(Ef_Witch2, gridpos)
	play_particle(Ef_Witch2)


	wait_time(1.0)

	dot_place_unit(dotMoronoe,22 ,8)
	dot_place_unit(dotMazoe,20 ,8)

	dot_move_height(dotMazoe, 1.1, 0, 0)
	dot_move_height(dotMoronoe, 1.1, 0, 0)

	dot_disp_unit(dotMoronoe, true)
	dot_disp_unit(dotMazoe, true)
	
	wait_time(1.0)

	
	
	change_face(Laiens1, "Smile")	
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310055")
	close_speech_window()

	
	
	change_face(Brian, "Pain")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_310057")
	close_speech_window()
	
	
	on_active(Ef_changeBriF)

	local gridpos = get_grid_position(21,9)
	set_pos(Ef_changeBriF , gridpos)
	play_particle(Ef_changeBriF )
	
	
	change_face(Laiens1, "Anger")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310058")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil , Moronoe)
	message("MA_01108_310059")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2",nil , Mazoe)
	message("MA_01108_310060")
	close_speech_window()
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Mazoe, "Smile", 1)
	on_cutin(2, Moronoe, "Smile", 1)

	
	open_speech_window("NPCNAME_0166",nil , nil)
	message("MA_01108_310061")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)

	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01108_310062")
	close_speech_window()

	
	change_face(Moronoe, "Anger")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01108_310063")
	

	
	change_face(Moronoe, "Anger")
	
	message("MA_01108_310064")
	close_speech_window()

	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01108_310065")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310066")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2",nil , Mazoe)
	message("MA_01108_310067")
	close_speech_window()

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01108_310068")
	close_speech_window()

	
	change_face(Laiens1, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens1)
	message("MA_01108_310069")
	

	
	change_face(Laiens1, "Smile")
	
	message("MA_01108_310070")
	close_speech_window()

	
	change_face(Lancelot, "Serious")
	open_speech_window("CHRNAME_LANCELOT",Lancelot , nil)
	message("MA_01108_310071")
	close_speech_window()

	
	bgm_play("Stop_BGM_Bus_MidFade")
	change_face(Laiens1, "Smile")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310072")
	close_speech_window()
	
	stop_particle(Ef_changeBriF)
	dot_change_anim(dotBrian,0)
	
	wait_seq()
	dot_unit_dir(dotBrian, 2)

	bgm_play("BGM_Battle_Tragedy_TragedyStart")
	
	change_face(Brian, "Pain")
	open_speech_window("CHRNAME_BRIAN",nil , Brian)
	message("MA_01108_310073")
	close_speech_window()

	
	on_active(Ef_changeBri)
	local gridpos = get_grid_position(21,11)
	set_pos(Ef_changeBri , gridpos)
	play_particle(Ef_changeBri )
	wait_time(0.5)
	dot_place_unit(barubaB,20, 9)
	dot_disp_unit(dotBrian, false)
	dot_disp_unit(barubaB, true)
	wait_seq()
	dot_unit_dir(barubaB, 2)
	
	
	dot_reserve_move_unit_seq(dotDinatan,21,17)
	dot_reserve_move_unit_seq(dotGuinevere,20,18)
	dot_reserve_move_unit_seq(dotBruno3,22,18)
	dot_reserve_move_unit_seq(dotArthur,20,16)
	dot_reserve_move_unit_seq(dotLancelot,22,16)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotDinatan, 3)
	move_camera(21, 12, 1.0)
	wait_seq()

	
	
	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan , nil)
	message("MA_01108_310075")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310076")
	

	


	
end

function MA_01108_31_select2_1()



	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_310081")
	

	
	change_face(Noir2, "Anger")
	
	message("MA_01108_310082")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01108_310083")
	close_speech_window()
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Mazoe, "Smile", 1)
	on_cutin(2, Moronoe, "Smile", 1)
	
	
	
	change_face(Moronoe, "NPCNAME_0166")
	open_speech_window("NPCNAME_0166",nil , nil)
	message("MA_01108_310089")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)

		
end


function MA_01108_31_select2_2()



	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01108_310085")
	

	
	change_face(Noir2, "Anger")
	
	message("MA_01108_310086")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01108_310087")
	close_speech_window()
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Mazoe, "Smile", 1)
	on_cutin(2, Moronoe, "Smile", 1)
	
	
	
	change_face(Moronoe, "CHRNAME_SISTERS_1")
	open_speech_window("NPCNAME_0166",nil , nil)
	message("MA_01108_310089")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)


		
end

function MA_01108_31_select3()
				
	
	
	
	stop_particle(Ef_changeBriF)
	wait_seq()
	
	on_active(Ef_BriB )
	local gridpos = get_grid_position(21,11)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	wait_time(1.0)	
	
	dot_play_particle_unit(barubaB,"Ef_C_Buf_StUp_VI",2,true)
	
	
	dot_disp_unit(barbaroi11, true)
	local gridpos = get_grid_position(19,8)
	set_pos(Ef_baruba, gridpos)
	set_scale(Ef_baruba, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba)
	wait_seq()
	
	dot_disp_unit(barbaroi12, true)
	local gridpos = get_grid_position(23,8)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2)
	wait_seq()


	
	
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310091")
	close_speech_window()
	
	
	
	on_active(Ef_BriB )
	local gridpos = get_grid_position(21,11)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	wait_time(1.0)
	
	dot_play_particle_unit(barubaB,"Ef_C_Buf_StUp_VI",2,true)
	
	
	local gridpos = get_grid_position(19,9)
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3)
	dot_disp_unit(barbaroi13, true)
	
	local gridpos = get_grid_position(23,9)
	set_pos(Ef_baruba4, gridpos)
	set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4)
	dot_disp_unit(barbaroi14, true)
	
	wait_seq()
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Mazoe, "Smile", 1)
	on_cutin(2, Moronoe, "Smile", 1)

	
	
	
	open_speech_window("NPCNAME_0166",nil , nil)
	message("MA_01108_310093")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310094")
	close_speech_window()
	
	move_camera(21, 12, 1.0)
	change_camera_distance(7.0, 1.0)
	dot_disp_weapon(dotNoir2, false)
	wait_seq()
	
	
	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN",nil , nil)
	message("MA_01108_310096")
	close_speech_window()
	
	dot_change_anim(barubaB,3)
	
	
	

show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

	
	
	
	
	
	
	
	
	
		on_cameraframe(2)
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

	
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103010251", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
	
	
	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	open_simple_window("CHRNAME_GUINEVERE")
	message("MA_01108_310098")
	

	
	
	change_face(Guinevere, "Smile")
	
	message("MA_01108_310100")
	close_simple_window()

	
	
	open_narration_window()
	message("MA_01108_310102")
	close_narration_window()
	
	dot_change_anim(barubaB,0)

	
	open_simple_window("CHRNAME_GUINEVERE")
	message("MA_01108_310103")
	

	
	
	message("MA_01108_310104")
	close_simple_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)

show_image("103010252", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_DINATAN")
	message("MA_01108_310105")
	

	
	
	message("MA_01108_310106")
	

	
	
	message("MA_01108_310107")
	close_simple_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)

show_image("103010253", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	
	open_simple_window("CHRNAME_LANCELOT")
	message("MA_01108_310109")
	

	
	
	
	message("MA_01108_310110")
	

	
	
	
	message("MA_01108_310111")
	

	
	
	
	message("MA_01108_310112")
	close_simple_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
	
	
	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)
	
		
	
	hide_image(BLACK_WHITE_TIME)
	wait_seq()
	
	dot_place_unit(dotNoir2,21,13 )
	dot_place_unit(dotBruno3,21,12 )
	
	wait_time(1.0)
	
	dot_change_anim(barubaB,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Axe_N_EmyAtk01",3,true)
	wait_time(0.4)
	dot_change_anim(dotBruno3,6)
	dot_play_particle_unit(dotBruno3,"Ef_C_Cmn_N_Hit_EmySla01",3,true)
	move_camera(21, 12, 1.0)
	
	wait_time(1.0)

	
	
	
	
	
	
	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	change_face(Bruno3, "Normal")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310114")
	close_speech_window()
	
	dot_change_anim(dotBruno3,0)
	dot_change_anim(barubaB,0)

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310115")
	close_speech_window()

	
	change_face(Laiens1, "Smile")
	open_speech_window("CHRNAME_LAIENS",nil , Laiens1)
	message("MA_01108_310116")
	close_speech_window()
	
	
	change_camera_distance(8.0, 1.0)
	move_camera(21, 13, 1.0)
	dot_reserve_move_unit_seq(dotNoir2,21,14)
	dot_reserve_move_unit_seq(dotBruno3,22,14)
	exec_parallel_seq()
	wait_seq()
	dot_change_anim(dotBruno3,1)
	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310118")
	close_speech_window()

	
	change_face(Bruno3, "Anger")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310119")

	
	change_face(Bruno3, "Anger")
	
	message("MA_01108_310120")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310121")
	close_speech_window()

	
	change_face(Bruno3, "Anger")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310122")
	

	
	
	change_face(Bruno3, "Anger")
	
	message("MA_01108_310124")
	

	
	change_face(Bruno3, "Anger")
	
	message("MA_01108_310125")
	close_speech_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301026", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	
	
	open_simple_window("CHRNAME_BRIAN")
	message("MA_01108_310127")
	

	
	
	open_simple_window("CHRNAME_BRIAN")
	message("MA_01108_310129")
	close_narration_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	
	change_face(Bruno3, "Normal")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310131")
	

	
	
	change_face(Bruno3, "Anger")
	
	message("MA_01108_310133")
	

	
	change_face(Bruno3, "Anger")
	
	message("MA_01108_310134")
	close_speech_window()
	
	
	open_cutin(1, 1)
	
	on_cutin(1, Bruno3, "Serious", 1)
	
	
	
	open_speech_window("CHRNAME_BRUNO2",nil , nil)
	message("MA_01108_310135")
	

	
	close_cutin()
	wait_time(0.5)


end

function MA_01108_31_select3_1()
	
	dot_disp_weapon(dotNoir2, true)
	dot_change_anim(dotNoir2,12)
	wait_time(1.0)
	
	
	
	dot_disp_weapon(dotNoir2, true)
	
	change_face(Bruno3, "Anger")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310140")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310141")
	close_speech_window()

	
	change_face(Bruno3, "Anger")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310142")
	close_speech_window()
	
	
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310148")
	close_speech_window()
end

function MA_01108_31_select3_2()


	dot_disp_weapon(dotNoir2, true)
	dot_change_anim(dotNoir2,12)
	wait_time(1.0)

	
	
	
	dot_disp_weapon(dotNoir2, true)
	
	change_face(Bruno3, "Anger")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310144")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310145")
	

	
	change_face(Bruno3, "Anger")
	
	message("MA_01108_310146")
	
	
	
	
	change_face(Noir2, "Sad")
	
	message("MA_01108_310148")
	close_speech_window()
end


function MA_01108_31_end()

	
	

	
	change_face(Bruno3, "Smile")
	open_speech_window("CHRNAME_BRUNO2",Bruno3 , nil)
	message("MA_01108_310149")
	

	
	change_face(Bruno3, "Smile")
	
	message("MA_01108_310150")
	close_speech_window()

	
	
	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310152")
	close_speech_window()
	
	
	
	open_cutin(1, 1)
	
	on_cutin(1, Noir2, "Serious", 1)

	
	
	
	open_speech_window("CHRNAME_NOIR",nil , nil)
	message("MA_01108_310154")
	close_speech_window()

	
	close_cutin()
	wait_time(0.5)

	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN",nil , nil)
	message("MA_01108_310155")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310156")
	
	
	dot_move_unit_seq(dotNoir2,21,12)
	wait_seq()
	
	change_camera_distance(7.0, 1.0)
	move_camera(21, 12, 1.0)
	wait_seq()
	
	
	change_face(Noir2, "Anger")
	
	message("MA_01108_310157")
	close_speech_window()

	
	open_narration_window()
	message("MA_01108_310158")
	close_narration_window()
	
	





	
	
	open_cutin(1, 1)
	
	on_cutin(1, Noir2, "Serious", 1)

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",nil , nil)
	message("MA_01108_310159")
	

	
	change_face(Noir2, "Anger")
	
	message("MA_01108_310160")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)

	
	open_narration_window()
	message("MA_01108_310161")
	close_narration_window()

	
	change_face(Brian, "Anger")
	open_speech_window("CHRNAME_BRIAN",nil , nil)
	message("MA_01108_310162")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01108_310163")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10301026", "content_still_10301026_image", "103010260_StillImage")
load_image_preload("103010251", "content_still_10301025_image", "103010251_StillImage")
load_image_preload("103010252", "content_still_10301025_image", "103010252_StillImage")
load_image_preload("103010253", "content_still_10301025_image", "103010253_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("10201014",  "content_still_10201014_image", "102010140_StillImage")
    pbadv_setup_101009_Noir_preload(2,true,21,18,0)
    pbadv_setup_101011_Guinevere_preload(0,true,20,20,0)
    pbadv_setup_101028_Galahad_preload(0,true,20,19,0)
    pbadv_setup_101015_Arthur_preload(0,true,20,18,0)
    pbadv_setup_101010_Lancelot_preload(0,true,22,18,0)
    pbadv_setup_101012_Dinatan_preload(0,true,22,19,0)
	pbadv_setup_101058_Laiens_preload(1,true,21 ,8 ,0)
	pbadv_setup_101043_Mazoe_preload(true,22 ,8 ,0)
	pbadv_setup_101042_Moronoe_preload(true,20 ,8 ,0)
	pbadv_setup_101034_Excelia_preload(2,false,1 ,2 ,0)
	pbadv_setup_101035_Liliana_preload(2,false,1 ,3 ,0)
	pbadv_setup_101050_Brian_preload(0,true,22 ,9 ,0)
	pbadv_setup_101021_Bruno_preload(3,true,22 ,20 ,0)
	pbadv_setup_101055_Owen_preload(0,true,21 ,2 ,0)
    pbadv_setup_101029_Astera_preload(0,true,21,19,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotCenter_018_froat", false, true)
	preload_sound("BGM_Battle_Tragedy_TragedyStart")
end
