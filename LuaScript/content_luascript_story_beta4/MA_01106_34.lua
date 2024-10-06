
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201070100", "201070100")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 20, 10,0)  
	pbadv_setup_101012_Dinatan(0,true, 19, 10,0)
	pbadv_setup_101017_Maladisant(1,true, 21, 10,0)  
	pbadv_setup_101001_Tyrfing(1,true, 18, 10,0)  
	
	pbadv_setup_101014_Tristan(0,true, 19, 12,0)  
	pbadv_setup_101018_Ragnar(1,true, 22, 12,0)  
	pbadv_setup_101013_Gawain(0,true, 21, 12,0)  
	pbadv_setup_101011_Guinevere(0,true, 18, 12,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 17, 12,0)  
	pbadv_setup_101019_Isolde(1,true, 23, 12,0)  
	
	pbadv_setup_101015_Arthur(0,true, 20, 11,0)  

	pbadv_setup_101010_Lancelot(0,true, 20, 20,0)  
	pbadv_setup_101022_Mordred(0,true, 18, 20,0)  
	pbadv_setup_101024_Bors(0,true, 22, 20,0)  
	pbadv_setup_101026_Percival(0,true, 17, 20,0)  
	pbadv_setup_101032_Gareth(0,true, 23, 20,0) 
	pbadv_setup_101050_Brian(0,true, 20, 21,0)  
	pbadv_setup_101027_Dindrane(1,true, 19, 21,0)  
	pbadv_setup_101023_Clarice(1,true, 21, 21,0) 
	pbadv_setup_101025_Clare(1,true, 20, 22,0)  
	pbadv_setup_101033_Lyoness(1,true, 19, 22,0) 

	pbadv_setup_101041_Morgan(2,true, 20, 3,0) 
	
	pbadv_setup_101043_Mazoe(true,20, 9,0)  
	pbadv_setup_101042_Moronoe(true, 21, 8,0)  

	pbadv_setup_101047_Tyronoe(true, 21, 7,0) 
	pbadv_setup_101048_Thiten(true, 19, 7,0)  
	pbadv_setup_101049_Thiton(true, 20, 7,0)  

	pbadv_setup_101044_Gliten(true, 19, 6,0) 
	pbadv_setup_101045_Glitonea(true, 20, 6,0) 
	pbadv_setup_101046_Gliton(true, 21, 6,0) 
	barbaroi1 = dot_reserve_enemy(42, 22, 7, 0)
	barbaroi2 = dot_reserve_enemy(1, 18, 7, 0)
	
	barbaroi3 = dot_reserve_enemy(1, 18, 9, 0)
	barbaroi4 = dot_reserve_enemy(42, 19, 9, 0)
	barbaroi5 = dot_reserve_enemy(1100, 20, 9, 0)
	barbaroi6 = dot_reserve_enemy(42, 21, 9, 0)
	barbaroi7 = dot_reserve_enemy(1, 22, 9, 0)

	
	setup_101040_Kay(nil, nil, 0, false) 

	



setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(dotDinatan, 0)
	dot_unit_dir(dotMaladisant1,0)
	dot_unit_dir(dotGuinevere, 0)
	dot_unit_dir(dotTyrfing1, 0)
	dot_unit_dir(dotArthur, 0)
	dot_unit_dir(dotRagnar1, 0)
	dot_unit_dir(dotGawain, 0)

	dot_unit_dir(dotTristan, 0)
	dot_unit_dir(dotLancelot, 0)
	dot_unit_dir(dotGwenhwymawr1, 0)

	dot_unit_dir(dotMordred, 0)
	dot_unit_dir(dotBors, 0)
	dot_unit_dir(dotPercival, 0)
	dot_unit_dir(dotGareth, 0)
	dot_unit_dir(dotBrian, 0)
	dot_unit_dir(dotDindrane1, 0)
	dot_unit_dir(dotClarice1, 0)
	dot_unit_dir(dotClare1, 0)
	dot_unit_dir(dotIsolde1, 0)

	dot_unit_dir(dotMazoe, 1)
	dot_unit_dir(dotTyronoe, 1)
	dot_unit_dir(dotThiten, 1)
	dot_unit_dir(dotThiton, 1)
	dot_unit_dir(dotMoronoe, 1)
	dot_unit_dir(dotGliten, 1)
	dot_unit_dir(dotGlitonea, 1)
	dot_unit_dir(dotGliton, 1)

	dot_unit_dir(barbaroi1, 1)
	dot_unit_dir(barbaroi1, 1)

	
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotLancelot, false)
	dot_disp_weapon(dotMordred, false)
	dot_disp_weapon(dotBors, false)
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dotGareth, false)
	dot_disp_weapon(dotDindrane1, false)
	dot_disp_weapon(dotClarice1, false)
	dot_disp_weapon(dotClare1, false)
	dot_disp_weapon(dotIsolde1, false)


	
	dot_disp_unit(dotMordred, false)
	dot_disp_unit(dotBors, false)
	dot_disp_unit(dotPercival, false)
	dot_disp_unit(dotGareth, false)
	dot_disp_unit(dotBrian, false)
	dot_disp_unit(dotDindrane1, false)
	dot_disp_unit(dotClarice1, false)
	dot_disp_unit(dotClare1, false)

	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliton, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	
	
	dot_change_anim(dotMorgan2,1)
	
	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image("101010141", "content_still_10101014_image", "101010140_StillImage")
	
	
	Ef_baruba1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	Ef_WitchSpear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	Ef_WitchSpear3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_021", false, true)
	Ef_WitchSpear4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_022", false, true)
	Ef_WitchSpear5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_023", false, true)
	Ef_WitchSpear6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_024", false, true)
	Ef_WitchSpear7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_025", false, true)
	Ef_WitchSpear8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAppea8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)

	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WSpearAura8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	
	Ef_BlFeather1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_BlFeather8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_WitchChange8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	
	Ef_WitchPortal1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)	
	Ef_WitchPortal5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_WitchPortal8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)	
	
		
	
	show_image("101010141", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(20, 3, 0.0)
	

	Mordred2 = set_chara_unknown()
	character2DFull(Mordred2,"Mordred2", 101022002)

	load_sound("BGM_Battle_Running")

end



function Play()
	fadein(0)
	Play_start(true)
	
	
	on_active(Ef_WitchSpear1) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear1)	


	on_active(Ef_WitchSpear2) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2,45, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear2)	

	on_active(Ef_WitchSpear3) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear3, gridpos)
	turn(Ef_WitchSpear3,45,45, 0, 0.0) 
	play_particle(Ef_WitchSpear3)	

	on_active(Ef_WitchSpear4) 

	local gridpos = get_grid_position(20, 3)
	gridpos[2] = 1.0 
	set_pos(Ef_WitchSpear4, gridpos)
	turn(Ef_WitchSpear4,45,-45, 0, 0.0) 
	play_particle(Ef_WitchSpear4)	



	
fadeout(0,0,0,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	
	wait_time(2.0)
	
	

	
	
fadeout(0,0,0,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

show_image("101010140", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("NPCNAME_0165")
	message("MA_01106_340002")
	
	message("MA_01106_340003")
	
	message("MA_01106_340004")
	
	message("MA_01106_340005")
	
	message("MA_01106_340006")
	
	message("MA_01106_340007")
	
	message("MA_01106_340008")
	
	message("MA_01106_340009")
	
	message("MA_01106_340010")
	close_simple_window()
	
	
fadeout(0,0,0,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	
	wait_time(2.0)
	
	
	
	
	
	
	move_camera(20, 11, 0.6)
	wait_camera()
	
	
	wait_time(0.3)

	
	change_face(Maladisant1, "Anger")
	open_speech_window("CHRNAME_MALADISANT2", Maladisant1, nil)
	message("MA_01106_340012")
	close_speech_window()
	
	
	dot_attack_seq(dotMaladisant1, dotMazoe)
	dot_damage_seq(dotMazoe, dotMaladisant1, true)
	
	
	wait_time(0.5)
	
	dot_change_anim(dotMazoe,6)
	dot_move_knockback(dotMazoe, 20, 8,0.2, 2)
	
	
	dot_unit_dir(dotNoir2, 3)

	
	change_face(Maladisant1, "Anger")
	open_speech_window("CHRNAME_MALADISANT2", Maladisant1, nil)
	message("MA_01106_340014")
	close_speech_window()

	dot_change_anim(dotMaladisant1,0)
	dot_change_anim(dotMazoe,0)

	move_camera(20, 9, 0.8)
	
		
	dot_move_height(dotMazoe,2.0,0.7, 0)	
	wait_time(1.2)	

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340016")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_340017")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340019")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_340020")
	close_speech_window()
	

	local gridpos = get_grid_position(18, 4) 
	gridpos[2] = 2.0

	slidemove(Ef_WitchSpear1, gridpos, 0.1) 

	local gridpos = get_grid_position(19, 4) 
	gridpos[2] = 2.0

	slidemove(Ef_WitchSpear2, gridpos, 0.1) 

	local gridpos = get_grid_position(20, 4) 
	gridpos[2] = 2.0

	slidemove(Ef_WitchSpear3, gridpos, 0.1) 

	local gridpos = get_grid_position(21, 4) 
	gridpos[2] = 2.0

	slidemove(Ef_WitchSpear4, gridpos, 0.1) 


	turn(Ef_WitchSpear1,90, 0, 0, 0.2)
	play_particle(Ef_WitchSpear1)


	turn(Ef_WitchSpear2,90, 0, 0, 0.2)
	play_particle(Ef_WitchSpear2)


	turn(Ef_WitchSpear3,90, 0, 0, 0.2)
	play_particle(Ef_WitchSpear3)


	turn(Ef_WitchSpear4,90, 0, 0, 0.2)
	play_particle(Ef_WitchSpear4)


	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340021")
	
	change_face(Mazoe, "Normal")
	message("MA_01106_340022")
	close_speech_window()
	
	




	
	
	
	move_camera(20, 3, 1.0)	
	change_camera_angle(34, 1.0)
	
	
	wait_camera()
	
	
	
	


	turn(Ef_WitchSpear1,20, 0, 0, 0.2)
	play_particle(Ef_WitchSpear1)


	turn(Ef_WitchSpear2,20, 0, 0, 0.2)
	play_particle(Ef_WitchSpear2)


	turn(Ef_WitchSpear3,20, 0, 0, 0.2)
	play_particle(Ef_WitchSpear3)


	turn(Ef_WitchSpear4,20, 0, 0, 0.2)
	play_particle(Ef_WitchSpear4)

	
	wait_time(2.0)

	
	move_camera(20, 9, 1.0)	
	
	
	wait_camera()
	
	dot_move_height(dotTyronoe,2.0,0.7, 0)		
	dot_move_height(dotThiten,2.0,0.7, 0)	
	dot_move_height(dotThiton,2.0,0.7, 0)		
	wait_time(1.5)		

on_active(Ef_WitchChange1) 
	
	local gridpos = get_grid_position(20, 8)
	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)
	
on_active(Ef_WitchChange2) 
	
	local gridpos = get_grid_position(21, 7)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)
	
on_active(Ef_WitchChange3) 
	
	local gridpos = get_grid_position(19, 7)
	set_pos(Ef_WitchChange3, gridpos)
	play_particle(Ef_WitchChange3)
	
on_active(Ef_WitchChange4) 
	
	local gridpos = get_grid_position(20, 7)
	set_pos(Ef_WitchChange4, gridpos)
	play_particle(Ef_WitchChange4)



	wait_time(1.0)


	dot_disp_unit(dotMazoe, false)

	on_active(Ef_WitchSpear5) 
	local gridpos = get_grid_position(21, 7)
	gridpos[2] = 1.5 
	set_pos(Ef_WitchSpear5, gridpos)
	turn(Ef_WitchSpear5,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear5)
	
	dot_disp_unit(dotTyronoe, false)

	on_active(Ef_WitchSpear6) 
	local gridpos = get_grid_position(19, 7)
	gridpos[2] = 1.5 
	set_pos(Ef_WitchSpear6, gridpos)
	turn(Ef_WitchSpear6,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear6)
	
	dot_disp_unit(dotThiten, false)

	on_active(Ef_WitchSpear7) 
	local gridpos = get_grid_position(20, 7)
	gridpos[2] = 1.5 
	set_pos(Ef_WitchSpear7, gridpos)
	turn(Ef_WitchSpear7,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear7)
	
	dot_disp_unit(dotThiton, false)

	on_active(Ef_WitchSpear8) 
	local gridpos = get_grid_position(20, 8)
	gridpos[2] = 1.5 
	set_pos(Ef_WitchSpear8, gridpos)
	turn(Ef_WitchSpear8,90, 0, 0, 0.0) 
	play_particle(Ef_WitchSpear8)
	

	wait_time(2.0)
	
	
	dot_move_height(dotMazoe,1.1,0.1, 0)		
	dot_move_height(dotTyronoe,1.1,0.1, 0)		
	dot_move_height(dotThiten,1.1,0.1, 0)	
	dot_move_height(dotThiton,1.1,0.1, 0)		
	
	se_play("SE_ADV_MA_01106_15_Whitch_Spr_Ground")
	
	
	local gridpos = get_grid_position(21, 8) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear1, gridpos, 0.1) 


	
	local gridpos = get_grid_position(19, 6) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear2, gridpos, 0.1) 


	
	local gridpos = get_grid_position(20, 6) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear3, gridpos, 0.1) 


	
	local gridpos = get_grid_position(21, 6) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear4, gridpos, 0.1) 


	
	local gridpos = get_grid_position(21, 7) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear5, gridpos, 0.1) 


	
	local gridpos = get_grid_position(19, 7) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear6, gridpos, 0.1) 


	
	local gridpos = get_grid_position(20, 7) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear7, gridpos, 0.1) 


	
	local gridpos = get_grid_position(20, 8) 
	gridpos[2] = 0.9

	slidemove(Ef_WitchSpear8, gridpos, 0.1) 




	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_340024")
	close_speech_window()
	
	
	wait_time(1.0)	
	
	on_active(Ef_BlFeather1)
	on_active(Ef_WitchChange1)

	local gridpos = get_grid_position(21, 8)
	set_pos(Ef_BlFeather1, gridpos)
	play_particle(Ef_BlFeather1)

	local gridpos = get_grid_position(21, 8)
	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)
	
	
	on_active(Ef_BlFeather2)
	on_active(Ef_WitchChange2)

	local gridpos = get_grid_position(20, 6)
	set_pos(Ef_BlFeather2, gridpos)
	play_particle(Ef_BlFeather2)

	local gridpos = get_grid_position(20, 6)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)
	
	
	on_active(Ef_BlFeather3)
	on_active(Ef_WitchChange3)

	local gridpos = get_grid_position(21, 6)
	set_pos(Ef_BlFeather3, gridpos)
	play_particle(Ef_BlFeather3)

	local gridpos = get_grid_position(21, 6)
	set_pos(Ef_WitchChange3, gridpos)
	play_particle(Ef_WitchChange3)	
	
	on_active(Ef_BlFeather4)
	on_active(Ef_WitchChange4)

	local gridpos = get_grid_position(19, 6)
	set_pos(Ef_BlFeather4, gridpos)
	play_particle(Ef_BlFeather4)

	local gridpos = get_grid_position(19, 6)
	set_pos(Ef_WitchChange4, gridpos)
	play_particle(Ef_WitchChange4)
	
	
	on_active(Ef_BlFeather5)
	on_active(Ef_WitchChange5)

	local gridpos = get_grid_position(21, 7)
	set_pos(Ef_BlFeather5, gridpos)
	play_particle(Ef_BlFeather5)

	local gridpos = get_grid_position(21, 7)
	set_pos(Ef_WitchChange5, gridpos)
	play_particle(Ef_WitchChange5)
	
	
	on_active(Ef_BlFeather6)
	on_active(Ef_WitchChange6)

	local gridpos = get_grid_position(20, 7)
	set_pos(Ef_BlFeather6, gridpos)
	play_particle(Ef_BlFeather6)

	local gridpos = get_grid_position(20, 7)
	set_pos(Ef_WitchChange6, gridpos)
	play_particle(Ef_WitchChange6)	
	
	on_active(Ef_BlFeather7)
	on_active(Ef_WitchChange7)

	local gridpos = get_grid_position(19, 7)
	set_pos(Ef_BlFeather7, gridpos)
	play_particle(Ef_BlFeather7)

	local gridpos = get_grid_position(19, 7)
	set_pos(Ef_WitchChange7, gridpos)
	play_particle(Ef_WitchChange7)
	
	
	on_active(Ef_BlFeather8)
	on_active(Ef_WitchChange8)

	local gridpos = get_grid_position(20, 8)
	set_pos(Ef_BlFeather8, gridpos)
	play_particle(Ef_BlFeather8)

	local gridpos = get_grid_position(20, 8)
	set_pos(Ef_WitchChange8, gridpos)
	play_particle(Ef_WitchChange8)	
	

	wait_time(0.5)
	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WitchSpear2)
	stop_particle(Ef_WitchSpear3)
	stop_particle(Ef_WitchSpear4)
	stop_particle(Ef_WitchSpear5)
	stop_particle(Ef_WitchSpear6)
	stop_particle(Ef_WitchSpear7)
	stop_particle(Ef_WitchSpear8)

	wait_time(0.5)
	dot_disp_unit(dotMazoe, true)
	dot_disp_unit(dotMoronoe, true)
	dot_disp_unit(dotTyronoe, true)
	dot_disp_unit(dotThiten, true)
	dot_disp_unit(dotThiton, true)
	dot_disp_unit(dotGliten, true)
	dot_disp_unit(dotGlitonea, true)
	dot_disp_unit(dotGliton, true)

	wait_time(2.0)	
	
	

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_340026")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340027")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_340028")
	close_speech_window()

	
	move_camera(20, 8, 0.3)
	
	
	wait_time(0.5)

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340030")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340032")
	close_speech_window()

	
	change_face(Gliten, "Normal")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01106_340034")
	close_speech_window()

	
	change_face(Glitonea, "Normal")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01106_340036")
	close_speech_window()

	
	change_face(Gliton, "Normal")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01106_340038")
	close_speech_window()

	
	change_face(Tyronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_6", nil, Tyronoe)
	message("MA_01106_340040")
	close_speech_window()

	
	change_face(Thiten, "Normal")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01106_340042")
	close_speech_window()

	
	change_face(Thiton, "Normal")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01106_340044")
	close_speech_window()
	
	
	move_camera(20, 12, 0.5)		

	
	wait_time(0.7)


	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_340046")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340047")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_340048")
	close_speech_window()

	
	change_face(Gawain, "Serious")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_340049")
	
	change_face(Gawain, "Anger")
	message("MA_01106_340051")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340052")
	close_speech_window()

	
	change_face(Ragnar1, "Normal")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar1, nil)
	message("MA_01106_340053")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340054")
	close_speech_window()
	
	

	
	move_camera(20, 9, 0.6)	

	
	wait_time(0.7)


	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340056")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_340057")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340058")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340059")
	close_speech_window()


open_cutin(1,1)

on_cutin(1,Moronoe, "Smile") 


	

	open_speech_window("CHRNAME_SISTERS_1", nil, nil)
	message("MA_01106_340060")
	close_speech_window()


close_cutin()

	
	
	move_camera(20, 12, 0.3)	
	
		
	wait_time(0.5)

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_340061")
	close_speech_window()
	
	

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340063")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_340064")
	close_speech_window()
	
	

	
	move_camera(20, 13, 0.3)

	
	dot_disp_unit(dotMordred, true)
	dot_disp_unit(dotBors, true)
	dot_disp_unit(dotPercival, true)
	dot_disp_unit(dotGareth, true)
	dot_disp_unit(dotBrian, true)
	dot_disp_unit(dotDindrane1, true)
	dot_disp_unit(dotClarice1, true)
	dot_disp_unit(dotClare1, true)

	
	dot_reserve_move_unit_seq(dotLancelot, 20, 13)
	dot_reserve_move_unit_seq(dotMordred, 18, 13)
	dot_reserve_move_unit_seq(dotBors, 22, 13)
	dot_reserve_move_unit_seq(dotPercival, 17, 13)
	dot_reserve_move_unit_seq(dotGareth, 23, 13)
	dot_reserve_move_unit_seq(dotDindrane1, 16, 13)
	dot_reserve_move_unit_seq(dotClarice1, 19, 13)
	dot_reserve_move_unit_seq(dotClare1, 21, 13)
	dot_reserve_move_unit_seq(dotLyoness1, 24, 13)
	exec_parallel_seq()
	wait_seq()	

	
	wait_time(0.5)

	
	bgm_play("BGM_Battle_Running")
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01106_340066")
	close_speech_window()
	
	wait_time(0.2)	
	
	move_camera(18, 13, 0.7)	
	wait_time(0.9)
	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01106_340068")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Mordred, "Normal") 


	open_speech_window("CHRNAME_MORDRED", nil, nil)
	message("MA_01106_340069")
	OpenFirstAppearance(Mordred2)
	close_speech_window()


close_cutin()	

	wait_time(0.4)	

	move_camera(20, 10, 1.2)	
	wait_time(1.5)	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_341001")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Noir2, "Normal") 


	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01106_341002")
	close_speech_window()


close_cutin()	


	wait_time(0.4)	

	move_camera(20, 13, 1.0)	
	wait_time(1.2)	
	wait_time(0.8)


open_cutin(1,1)

on_cutin(1,Lancelot, "Normal") 


	open_speech_window("CHRNAME_LANCELOT", nil, nil)
	message("MA_01106_340070")
	close_speech_window()


close_cutin()	

	wait_time(0.4)	

	move_camera(22, 13, 0.7)	
	wait_time(0.9)	
	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	message("MA_01106_340071")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Bors, "Normal") 


	open_speech_window("CHRNAME_BORS", nil, nil)
	message("MA_01106_340072")
	OpenFirstAppearance(Bors)
	close_speech_window()


close_cutin()	

	wait_time(0.4)		

	move_camera(19, 12, 0.8)	
	wait_time(1.0)	

	
	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_340073")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Tristan, "Normal") 


	open_speech_window("CHRNAME_TRISTAN", nil, nil)
	message("MA_01106_340074")
	close_speech_window()


close_cutin()	
	
	wait_time(0.4)		
	
	move_camera(23, 13, 1.0)	
	wait_time(1.2)	
	
	change_face(Gareth, "Normal")
	open_speech_window("CHRNAME_GARETH", Gareth, nil)
	message("MA_01106_340075")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Gareth, "Normal") 


	open_speech_window("CHRNAME_GARETH", nil, nil)
	message("MA_01106_340076")
	OpenFirstAppearance(Gareth)
	close_speech_window()


close_cutin()	

	wait_time(0.4)	

	move_camera(17, 13, 1.3)	
	wait_time(1.5)	

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01106_340077")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Percival, "Normal") 


	open_speech_window("CHRNAME_PERCIVAL", nil, nil)
	message("MA_01106_340078")
	OpenFirstAppearance(Percival)
	close_speech_window()


close_cutin()

	wait_time(0.4)			
	
	move_camera(21, 12, 0.9)	
	wait_time(1.1)	
	
	change_face(Gawain, "Normal")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_340079")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Gawain, "Normal") 


	open_speech_window("CHRNAME_GAWAIN", nil, nil)
	message("MA_01106_340080")
	close_speech_window()


close_cutin()		

	wait_time(0.4)	

	move_camera(20, 11, 0.7)	
	wait_time(0.9)	
	
	wait_time(0.8)


	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_340082")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Arthur, "Normal") 


	open_speech_window("CHRNAME_ARTHUR", nil, nil)
	message("MA_01106_340083")
	close_speech_window()


close_cutin()		
	

	wait_time(0.4)		
	
	move_camera(20, 9, 1.2)

	
	dot_reserve_move_unit_seq(dotLancelot, 16, 6)
	dot_reserve_move_unit_seq(dotMordred, 16, 7)
	dot_reserve_move_unit_seq(dotClarice1, 16, 8)
	dot_reserve_move_unit_seq(dotTristan, 16, 9)
	dot_reserve_move_unit_seq(dotIsolde1, 16, 10)
	dot_reserve_move_unit_seq(dotRagnar1, 15, 7)
	dot_reserve_move_unit_seq(dotGawain, 15, 8)

	dot_reserve_move_unit_seq(dotBors, 24, 6)
	dot_reserve_move_unit_seq(dotClare1, 24, 7)
	dot_reserve_move_unit_seq(dotPercival, 24, 8)
	dot_reserve_move_unit_seq(dotDindrane1, 24, 9)
	dot_reserve_move_unit_seq(dotGareth, 25, 7)
	dot_reserve_move_unit_seq(dotLyoness1, 25, 8)

	dot_reserve_move_unit_seq(dotGuinevere, 21, 12)
	dot_reserve_move_unit_seq(dotGwenhwymawr1, 20, 12)	
	
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_unit_dir(dotLancelot, 3)
	dot_unit_dir(dotMordred, 3)
	dot_unit_dir(dotTristan, 3)
	dot_unit_dir(dotIsolde1, 3)
	dot_unit_dir(dotRagnar1, 3)
	dot_unit_dir(dotGawain, 3)
	dot_unit_dir(dotClarice1, 3)
	dot_unit_dir(dotLyoness1, 2)
	dot_unit_dir(dotBors, 2)
	dot_unit_dir(dotPercival, 2)
	dot_unit_dir(dotGareth, 2)
	dot_unit_dir(dotDindrane1, 2)


	dot_unit_dir(dotClare1, 2)

	
	change_face(Moronoe, "Anger")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340085")
	close_speech_window()

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01106_340086")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	message("MA_01106_340087")
	close_speech_window()
	
	
	move_camera(20, 11, 0.5)
	wait_camera()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_340088")
	
	change_face(Arthur, "Normal")
	message("MA_01106_340089")
	
	change_face(Arthur, "Smile")
	message("MA_01106_340090")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_340091")
	close_speech_window()
	
	
	move_camera(20, 9, 0.5)
	wait_camera()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01106_340092")
	close_speech_window()
	
	
	move_camera(20, 11, 0.5)
	wait_camera()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_340093")
	close_speech_window()	
	
	
open_cutin(1,1)

on_cutin(1,Arthur, "Serious") 


	

	open_speech_window("CHRNAME_ARTHUR", nil, nil)
	message("MA_01106_340095")
	close_speech_window()


close_cutin()
	

	
	
	
	
	dot_disp_weapon(dotLancelot, true)
	dot_disp_weapon(dotMordred, true)
	dot_disp_weapon(dotTristan, true)
	dot_disp_weapon(dotIsolde1, true)
	dot_disp_weapon(dotMordred, true)
	dot_disp_weapon(dotRagnar1, true)
	dot_disp_weapon(dotGawain, true)
	dot_disp_weapon(dotBors, true)
	dot_disp_weapon(dotPercival, true)
	dot_disp_weapon(dotGareth, true)
	dot_disp_weapon(dotDindrane1, true)
	dot_disp_weapon(dotClarice1, true)

	dot_disp_weapon(dotClare1, true)


	
	wait_time(1.0)

	
	move_camera(20, 9, 0.6)
	
	
	wait_time(0.8)

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340096")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340097")
	close_speech_window()

	
	change_face(Gliten, "Smile")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01106_340098")
	close_speech_window()

	
	change_face(Glitonea, "Smile")
	open_speech_window("CHRNAME_SISTERS_4", nil, Glitonea)
	message("MA_01106_340099")
	close_speech_window()

	
	change_face(Gliton, "Smile")
	open_speech_window("CHRNAME_SISTERS_5", nil, Gliton)
	message("MA_01106_340100")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01106_340101")
	close_speech_window()

	
	change_face(Tyronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_6", nil, Tyronoe)
	message("MA_01106_340102")
	close_speech_window()

	
	change_face(Thiten, "Smile")
	open_speech_window("CHRNAME_SISTERS_7", nil, Thiten)
	message("MA_01106_340103")
	close_speech_window()

	
	change_face(Thiton, "Smile")
	open_speech_window("CHRNAME_SISTERS_8", nil, Thiton)
	message("MA_01106_340104")
	close_speech_window()
	
	
	
	on_active(Ef_WitchPortal1)
        
	local gridpos = get_grid_position(21, 7)
	set_pos(Ef_WitchPortal1, gridpos)
	set_scale(Ef_WitchPortal1, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal1)
	
	on_active(Ef_WitchPortal2)
        
	local gridpos = get_grid_position(19, 7)
	set_pos(Ef_WitchPortal2, gridpos)
	set_scale(Ef_WitchPortal2, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal2)
	
	on_active(Ef_WitchPortal3)
        
	local gridpos = get_grid_position(20, 7)
	set_pos(Ef_WitchPortal3, gridpos)
	set_scale(Ef_WitchPortal3, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal3)
	
	on_active(Ef_WitchPortal4)
        
	local gridpos = get_grid_position(19, 6)
	set_pos(Ef_WitchPortal4, gridpos)
	set_scale(Ef_WitchPortal4, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal4)
	
	on_active(Ef_WitchPortal5)
        
	local gridpos = get_grid_position(20, 6)
	set_pos(Ef_WitchPortal5, gridpos)
	set_scale(Ef_WitchPortal5, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal5)
	
	on_active(Ef_WitchPortal6)
        
	local gridpos = get_grid_position(21, 6)
	set_pos(Ef_WitchPortal6, gridpos)
	set_scale(Ef_WitchPortal6, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal6)
        
      

	wait_time(1.0)

	dot_disp_unit(dotTyronoe, false)
	dot_disp_unit(dotThiten, false)
	dot_disp_unit(dotThiton, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotGlitonea, false)
	dot_disp_unit(dotGliton, false)

	wait_time(2.0)	

	
	
	on_active(Ef_baruba1)
	local gridpos = get_grid_position(18,9)
	set_pos(Ef_baruba1, gridpos)
	set_scale(Ef_baruba1, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba1)
	
	on_active(Ef_baruba2)
	local gridpos = get_grid_position(19,9)
	set_pos(Ef_baruba2, gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})

	on_active(Ef_baruba3)
	local gridpos = get_grid_position(20,9)
	set_pos(Ef_baruba3, gridpos)
	set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3)
	
	on_active(Ef_baruba4)
	local gridpos = get_grid_position(21,9)
	set_pos(Ef_baruba4, gridpos)
	set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4)
	
	on_active(Ef_baruba5)
	local gridpos = get_grid_position(22,9)
	set_pos(Ef_baruba5, gridpos)
	set_scale(Ef_baruba5, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba5)

	
	wait_time(0.2)

	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)
	dot_disp_unit(barbaroi5, true)
	dot_disp_unit(barbaroi6, true)
	dot_disp_unit(barbaroi7, true)
	
	
	wait_time(1.0)

	
	move_camera(16, 9, 0.9)
	
	
	wait_time(1.1)

	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01106_340106")
	close_speech_window()

	
	change_face(Tristan, "Normal")
	open_speech_window("CHRNAME_TRISTAN", Tristan, nil)
	message("MA_01106_340107")
	close_speech_window()
	
	
	move_camera(20, 9, 0.9)
	
	
	wait_time(1.1)	

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340108")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_340109")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340110")
	close_speech_window()

	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)
	message("MA_01106_340111")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01106_340112")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_340113")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_340114")
	close_speech_window()

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01106_340115")
	close_speech_window()
	
	


	


	
open_cutin(2,1)

on_cutin(1,Moronoe, "Normal") 
on_cutin(2,Mazoe, "Normal") 


	

	open_speech_window("CHRNAME_SISTERS_1_2", nil, nil)
	message("MA_01106_340116")
	close_speech_window()


close_cutin()


	
	
	
	on_active(Ef_WitchPortal7)
        
	local gridpos = get_grid_position(20, 8)
	set_pos(Ef_WitchPortal7, gridpos)
	set_scale(Ef_WitchPortal7, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal7)
	
	on_active(Ef_WitchPortal8)
        
	local gridpos = get_grid_position(21, 8)
	set_pos(Ef_WitchPortal8, gridpos)
	set_scale(Ef_WitchPortal8, {0.8, 0.8, 0.8})
	play_particle(Ef_WitchPortal8)
        


	wait_time(1.0)

	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotMoronoe, false)	

	wait_time(2.0)	

	
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(dotMoronoe, false)	

	
	wait_time(1.0)

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 10,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 19, 10,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 21, 10,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 18, 10,0)
	pbadv_setup_101014_Tristan_preload(0,true, 19, 12,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 22, 12,0)
	pbadv_setup_101013_Gawain_preload(0,true, 21, 12,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 18, 12,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 17, 12,0)
	pbadv_setup_101019_Isolde_preload(1,true, 23, 12,0)
	pbadv_setup_101015_Arthur_preload(0,true, 20, 11,0)
	pbadv_setup_101010_Lancelot_preload(0,true, 20, 20,0)
	pbadv_setup_101022_Mordred_preload(0,true, 18, 20,0)
	pbadv_setup_101024_Bors_preload(0,true, 22, 20,0)
	pbadv_setup_101026_Percival_preload(0,true, 17, 20,0)
	pbadv_setup_101032_Gareth_preload(0,true, 23, 20,0)
	pbadv_setup_101050_Brian_preload(0,true, 20, 21,0)
	pbadv_setup_101027_Dindrane_preload(1,true, 19, 21,0)
	pbadv_setup_101023_Clarice_preload(1,true, 21, 21,0)
	pbadv_setup_101025_Clare_preload(1,true, 20, 22,0)
	pbadv_setup_101033_Lyoness_preload(1,true, 19, 22,0)
	pbadv_setup_101041_Morgan_preload(2,true, 20, 3,0)
	pbadv_setup_101043_Mazoe_preload(true,20, 9,0)
	pbadv_setup_101042_Moronoe_preload(true, 21, 8,0)
	pbadv_setup_101047_Tyronoe_preload(true, 21, 7,0)
	pbadv_setup_101048_Thiten_preload(true, 19, 7,0)
	pbadv_setup_101049_Thiton_preload(true, 20, 7,0)
	pbadv_setup_101044_Gliten_preload(true, 19, 6,0)
	pbadv_setup_101045_Glitonea_preload(true, 20, 6,0)
	pbadv_setup_101046_Gliton_preload(true, 21, 6,0)
	setup_101040_Kay_preload(nil, nil, 0, false)
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101010141", "content_still_10101014_image", "101010140_StillImage")
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_020", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_021", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_022", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_023", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_024", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_025", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	character2DFull_Preload(Mordred2,"Mordred2", 101022002)
	preload_sound("BGM_Battle_Running")
end
