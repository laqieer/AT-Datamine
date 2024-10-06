

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	
	setup_101009_Noir(nil, nil, 0, false)

	
	
	init_psbattleadv("201070100", "201070100")
	
	change_time_and_weather(1,1)
	
	
	
	
	
	
	

	pbadv_setup_101009_Noir(2,true, 19, 13,0)  
	pbadv_setup_101010_Lancelot(1,true, 18, 14,0)  
	pbadv_setup_101028_Galahad(1,true, 21, 13,0)  
	pbadv_setup_101036_Viena(1,true, 22, 14,0)  
	
	

	
	
	
	
	
	
	
	pbadv_setup_101043_Mazoe(true, 20, 1,0)  
	
	
	barbaroi3 = dot_reserve_enemy(3, 20, 8, 0)
	
	
	
	barbaroi7 = dot_reserve_enemy(3, 19, 4, 0)
	barbaroi8 = dot_reserve_enemy(3, 20,4, 0)
	barbaroi9 = dot_reserve_enemy(3, 21, 4, 0)
	
	
	
	
	
	



	
	
	
	setup_complete_unit()

	
	
	
	
	
	
	
	
	dot_unit_dir(dotGalahad1, 2)
	dot_unit_dir(dotViena1, 2)


	
	
	
	
	
	
	

	
	
	
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)
	dot_disp_unit(barbaroi9, false)

	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(20, 1, 0.0)
	
	
	Black_fog_Area = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_Area01", false, true)
	BlackFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WitchSpear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_Witch2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	Ef_Black2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	
	
	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 

	load_sound("BGM_Battle_AfterLancelot_General2_Start")


end



function Play()
	fadein(0)
	Play_start(true)






	dot_unit_dir(dotMazoe, 3)
	wait_time(1.5)
	dot_unit_dir(dotMazoe, 2)
	wait_time(1.5)


	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270002")
	


	change_face(Mazoe, "Normal")
	
	message("MA_01B109_270003")
	


	change_face(Mazoe, "Smile")
	
	message("MA_01B109_270004")
	




	change_face(Mazoe, "Anger")
	
	message("MA_01B109_270006")
	
	
	
	
	
	
	
	
	on_active(Ef_WitchSpear2) 
	on_active(Ef_WSpearAppea2) 
	on_active(Ef_WSpearAura2) 
	
	
	on_active(Ef_WitchChange1) 
	
	dot_disp_unit(dotMazoe, false)
	
	local gridpos = get_grid_position(20, 2)
	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)

	wait_time(1.0)

	
	
	
	
	dot_change_anim(barbaroi3,6)
	
	
	local gridpos = get_grid_position(20, 2)
	gridpos[2] = 4.0
	set_pos(Ef_WSpearAppea2, gridpos)
	turn(Ef_WSpearAppea2,90, 0, 0, 0.0)
	play_particle(Ef_WSpearAppea2)

	
	local gridpos = get_grid_position(20, 2)
	gridpos[2] = 4.0
	set_pos(Ef_WSpearAppea2, gridpos)
	turn(Ef_WSpearAppea2,90, 0, 0, 0.0)
	play_particle(Ef_WSpearAppea2)
	
	
	local gridpos = get_grid_position(20, 2)
	gridpos[2] = 4.0
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2, 90, 0, 0, 0.0)
	play_particle(Ef_WitchSpear2)
	
	set_pos(Ef_WSpearAura2, gridpos)
	turn(Ef_WSpearAura2,90, 0, 0, 0.0)
	play_particle(Ef_WSpearAura2)
	
	wait_time(1.0)
	
	dot_move_knockback(barbaroi3,20, 2,0.4,2)
	
	wait_time(0.2)
	
	local gridpos = get_grid_position(20, 2)
	gridpos[2] = 2.11
	
	slidemove(Ef_WitchSpear2, gridpos, 0.1)
	slidemove(Ef_WSpearAura2, gridpos, 0.1)
	
	wait_time(0.1)
	
	on_active(Ef_WitchSpearHit1) 
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)
	
	wait_time(0.5)

	
	dot_change_anim(barbaroi3,6)
	dot_dying_unit_seq(barbaroi3)
	
	wait_time(0.3)
	
	
	





	on_active(Black_fog_Area) 
	
	local gridpos = get_grid_position(20, 2)
	set_pos(Black_fog_Area, gridpos)
	play_particle(Black_fog_Area)
			
	wait_time(1.0)
	
	on_active(Ef_BlFeather)
	on_active(Ef_WitchChange2)

	local gridpos = get_grid_position(20, 2)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)

	local gridpos = get_grid_position(20, 2)
	set_pos(Ef_WitchChange2, gridpos)
	play_particle(Ef_WitchChange2)

	wait_time(1.0)

	stop_particle(Ef_WitchSpear2)
	stop_particle(Ef_WSpearAura2)
	dot_disp_unit(dotMazoe, true)
	
	



	move_camera(20, 6, 2.0)
	change_camera_distance(10.0, 2.0)


	wait_time(1.0)
	dot_reserve_move_unit_seq(dotNoir2, 19, 7)
	dot_reserve_move_unit_seq(dotLancelot1, 18, 8)
	dot_reserve_move_unit_seq(dotGalahad1,  21, 7)
	dot_reserve_move_unit_seq(dotViena1, 22, 8)
	
	


	exec_parallel_seq()
	
	wait_seq()

	dot_unit_dir(dotGalahad1, 2)
	dot_unit_dir(dotViena1, 2)
	

	bgm_play("BGM_Battle_AfterLancelot_General2_Start")

	change_face(Mazoe, "Anger")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270008")
	close_speech_window()


	change_face(Lancelot1, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_270009")
	close_speech_window()


	change_face(Mazoe, "Anger")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270010")
	close_speech_window()


	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_270011")
	close_speech_window()


	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270012")
	close_speech_window()


	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_270013")
	close_speech_window()


	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270014")
	close_speech_window()


	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B109_270015")
	




   
   MA_01B109_27_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B109_270016", "MA_01B109_270017")  
    
      if is_select(1) then            
        MA_01B109_27_select1_1()

    else                            
        MA_01B109_27_select1_2()

    end
    MA_01B109_27_end()
    
    end
 
function MA_01B109_27_select1()
 
end
 
function MA_01B109_27_select1_1()
 

 

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_270019")
	close_speech_window()


	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270020")
	close_speech_window()


	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_270021")
	close_speech_window()


	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270022")
	
	
	
	change_face(Mazoe, "Smile")
	
	message("MA_01B109_270031")
	close_speech_window()


	on_active(BlackFeather) 
	
	local gridpos = get_grid_position(20, 0)
	set_pos(BlackFeather, gridpos)
	play_particle(BlackFeather)
			
	wait_time(0.5)
	
	stop_particle(BlackFeather)


	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270033")
	


	change_face(Mazoe, "Smile")
	
	message("MA_01B109_270034")
	close_speech_window()

 
      
end
 
 
function MA_01B109_27_select1_2()
 

 

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_270024")
	close_speech_window()


	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270025")
	


	change_face(Mazoe, "Normal")
	
	message("MA_01B109_270026")
	close_speech_window()





	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_270028")
	close_speech_window()


	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270029")
	
	
	
	change_face(Mazoe, "Smile")
	
	message("MA_01B109_270031")
	


	on_active(BlackFeather) 
	
	local gridpos = get_grid_position(20, 0)
	set_pos(BlackFeather, gridpos)
	play_particle(BlackFeather)
			



	change_face(Mazoe, "Normal")
	
	message("MA_01B109_270033")
	


	change_face(Mazoe, "Smile")
	
	message("MA_01B109_270034")
	close_speech_window()
 
    
end
 
 
function MA_01B109_27_end()
 






	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B109_270036")
	close_speech_window()




	on_active(Ef_bar1) 

	local gridpos = get_grid_position(19, 4) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)

	on_active(Ef_bar2) 

	local gridpos = get_grid_position(20, 4) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)

	on_active(Ef_bar3) 

	local gridpos = get_grid_position(21, 4) 
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar3)

wait_time(0.2)
        
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)
	dot_disp_unit(barbaroi9,true)	

wait_time(2.0)

	move_camera(20, 1, 2.0)

	

	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270038")
	







	change_face(Mazoe, "Smile")
	
	message("MA_01B109_270040")
	close_speech_window()


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_270041")
	close_speech_window()


	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270042")
	close_speech_window()


	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_270043")
	close_speech_window()


	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270044")
	


	change_face(Mazoe, "Normal")
	
	message("MA_01B109_270045")
	close_speech_window()


	dot_play_particle_unit(dotMazoe,"Ef_C_Buf_StUp_VI",2,true)


	local gridpos = get_grid_position(20, 0)
	set_pos(BlackFeather, gridpos)
	play_particle(BlackFeather)
			
	wait_time(0.5)
	
	stop_particle(BlackFeather)





	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01B109_270047")
	close_speech_window()
	
	move_camera(20, 6, 2.0)




	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B109_270049")
	close_speech_window()


	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_270050")
	


	change_face(Galahad1, "Sad")
	
	message("MA_01B109_270051")
	close_speech_window()


	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_270052")
	






    MA_01B109_27_select2()
 
    open_select_window_tag(Noir, "Normal", "MA_01B109_270053", "MA_01B109_270054")  
 
    if is_select(1) then            
        MA_01B109_27_select2_1()

    else                                    
        MA_01B109_27_select2_2()

    end
   MA_01B109_27_2_end()

end
 
function MA_01B109_27_select2()

end
 
function MA_01B109_27_select2_1()


 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_270056")
	close_speech_window()


	change_face(Viena1, "Surprise")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	message("MA_01B109_270057")
	close_speech_window()


	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_270058")
	close_speech_window()
 
      
end
 
 
function MA_01B109_27_select2_2()
 

 

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_270060")
	close_speech_window()


	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_270061")
	


	change_face(Lancelot1, "Normal")
	
	message("MA_01B109_270062")
	close_speech_window()
 
    
    
end
 
function MA_01B109_27_2_end()





	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_270064")
	close_speech_window()



	dot_move_unit_seq(dotLancelot1, 20, 8)
	dot_move_unit_seq(dotLancelot1, 20, 7)
	wait_seq()

	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)
	
	on_active(Ef_Emblem2) 
	local locatorpos = dot_get_unit_locator(dotNoir2, 1)
	set_pos(Ef_Emblem2, locatorpos)

	on_active(Ef_Emblem1) 
	local locatorpos = dot_get_unit_locator(dotLancelot1, 1)
	set_pos(Ef_Emblem1, locatorpos)
	wait_time(2.0)





	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_270066")
	


	change_face(Lancelot1, "Normal")
	
	message("MA_01B109_270067")
	close_speech_window()


	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_270068")
	close_speech_window()


	change_face(Lancelot1, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_270069")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Noir2, "Serious") 





	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01B109_270070")
	close_speech_window()


close_cutin()



	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B109_270071")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup_101009_Noir_preload(nil, nil, 0, false)
	pbadv_setup_101009_Noir_preload(2,true, 19, 13,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 18, 14,0)
	pbadv_setup_101028_Galahad_preload(1,true, 21, 13,0)
	pbadv_setup_101036_Viena_preload(1,true, 22, 14,0)
	pbadv_setup_101043_Mazoe_preload(true, 20, 1,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_Area01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_019", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	preload_sound("BGM_Battle_AfterLancelot_General2_Start")
end
