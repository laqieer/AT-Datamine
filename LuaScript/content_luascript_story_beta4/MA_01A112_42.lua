

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	
	
	
	
	
	
	
	

	
	
	
	init_psbattleadv("201090100", "201090100")
	change_time_and_weather(1,1)
	

	

	
	pbadv_setup_101009_Noir(2,true,9,4,0)

	pbadv_setup_101011_Guinevere(1,true, 9, 3,0)  

	pbadv_setup_101013_Gawain(0,true, 9, 5,0)  
	
	pbadv_setup_101015_Arthur(0,true, 11, 3,0)  
	
	
	pbadv_setup_101020_Merlin(1,true,11,5,0)

	pbadv_setup_101051_Lucius(0,true, 19, 4,0)  

	pbadv_setup_101039_Fren(1,true, 17, 4,0) 

	
	pbadv_setup_101041_Morgan(1,true, 13, 4,0) 
	pbadv_setup_101041_Morgan(4,true, 14, 4,0)
	
	
	pbadv_setup_101042_Moronoe(true, 14, 3,0)  
	pbadv_setup_101044_Gliten(true, 14, 5,0) 


	
	
	
	setup_complete_unit()

	
	dot_unit_dir(dotLucius, 2)
	dot_unit_dir(dotMoronoe, 3)
	dot_unit_dir(dotGliten, 3)
	dot_unit_dir(dotFren1, 2)

	
	dot_disp_weapon(dotMorgan4, false)

	
	
	dot_disp_unit(dotFren1, false)
	dot_disp_unit(dotMoronoe, false)
	dot_disp_unit(dotGliten, false)
	dot_disp_unit(dotMorgan4, false)
	dot_disp_unit(dotLucius, false)
	dot_change_anim(dotMerlin1,1)
	dot_change_anim(dotMorgan1,1)
	
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(13, 4, 0.0)
	
	
	
	Ef_warpW= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_warpW2= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	
	Ef_DieW= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	
	Ef_B= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	Ef_Fren= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem15", false, true)
	Ef_power= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_lost= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)

	Ef_AuraArea = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)

	on_active(Ef_AuraArea)

	local gridpos = get_grid_position(13, 2)
	set_pos(Ef_AuraArea, gridpos)
	set_scale(Ef_AuraArea, {1.4, 1.4, 1.4})
	play_particle(Ef_AuraArea)

end






function Play()
	fadein(0)
	Play_start(true)






	


	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_420002")
	

	
	message("MA_01A112_420004")
	
	
	message("MA_01A112_420005")
	close_speech_window()
	
	
	change_face(Arthur, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_420006")
	close_speech_window()
	
	
	change_face(Morgan1, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan1)
	message("MA_01A112_420007")
	close_speech_window()
	
	

	change_face(Arthur, "Surprise")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A112_420008")
	close_speech_window()
	

	

	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01A112_420010")
	close_speech_window()
	
	dot_play_particle_unit(dotMorgan1,"Ef_C_Mag_R_Hit01",3,true)
	dot_change_anim(dotMorgan1,6)
	wait_time(0.5)
	dot_change_anim(dotMorgan1,1)
	
	move_camera(14, 4, 1.0)
	dot_disp_unit(dotLucius, true)
	dot_move_unit_seq(dotLucius,16, 4)
	wait_seq()
	

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A112_420012")
	close_speech_window()
	
	on_active(Ef_DieW)

	local gridpos = get_grid_position(13,4)
	set_pos(Ef_DieW, gridpos)
	play_particle(Ef_DieW)
	
	wait_time(0.5)
	
	on_active(Ef_lost)

	local gridpos = get_grid_position(13,4)
	set_pos(Ef_lost, gridpos)
	play_particle(Ef_lost)
	
	wait_time(1.5)
	
	on_active(Ef_power)

	local gridpos = get_grid_position(16,4)
	set_pos(Ef_power, gridpos)
	play_particle(Ef_power)
	
	
	dot_place_unit(dotMorgan1,1, 1)
	dot_place_unit(dotMorgan4,13, 4)
	dot_disp_unit(dotMorgan4, true)
	dot_disp_unit(dotMorgan1, false)
	
	dot_unit_dir(dotMorgan4, 3)
	

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A112_420014")
	close_speech_window()
	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A112_420015")
	
	
	change_face(Lucius, "Normal")
	message("MA_01A112_420016")
	
	

	change_face(Lucius, "Sad")
	message("MA_01A112_420017")
	close_speech_window()
	
	dot_change_anim(dotMerlin1,0)
	
	dot_reserve_move_unit_seq(dotArthur,13, 3)
	dot_reserve_move_unit_seq(dotMerlin1,13,5)
	exec_parallel_seq()
	wait_seq()
	
	change_face(Merlin1, "Normal")
	open_speech_window("CHRNAME_MERLIN2", Merlin1, nil)
	message("MA_01A112_420019")
	close_speech_window()
	

	
	change_face(Lucius, "Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A112_420021")
	
	
	change_face(Lucius, "Normal")
	message("MA_01A112_420022")
	
	
	change_face(Lucius, "Smile")
	message("MA_01A112_420023")
	close_speech_window()
	
	on_active(Ef_warpW)
	local gridpos = get_grid_position(14,3)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)

	on_active(Ef_warpW2)
	local gridpos = get_grid_position(14,5)
	set_pos(Ef_warpW2, gridpos)
	play_particle(Ef_warpW2)

	wait_time(0.5)
		
	dot_disp_unit(dotMoronoe, true)
	dot_disp_unit(dotGliten, true)
	wait_time(1.0)
	

	
	change_face(Gliten, "Anger")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A112_420025")
	close_speech_window()
	
	
	change_face(Moronoe, "Anger")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01A112_420026")
	close_speech_window()
	

	

	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01A112_420028")
	close_speech_window()
	
	dot_disp_unit(dotFren1, true)
	dot_move_unit_seq(dotFren1,15, 4)
	wait_seq()
	dot_change_anim(dotFren1,3)
	dot_play_particle_unit(dotFren1,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.3)
	dot_play_particle_unit(dotMoronoe,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotGliten,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(dotMoronoe,6)
	dot_change_anim(dotGliten,6)
	wait_time(0.5)
	dot_change_anim(dotFren1,0)
	dot_change_anim(dotMoronoe,1)
	dot_change_anim(dotGliten,1)
	



	

	change_face(Fren1, "Anger")
	open_speech_window("CHRNAME_FREN2", nil, Fren1)
	message("MA_01A112_420030")
	close_speech_window()
	
	
	change_face(Moronoe, "Anger")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01A112_420032")
	close_speech_window()
	
	
	change_face(Fren1, "Smile")
	open_speech_window("CHRNAME_FREN2", nil, Fren1)
	message("MA_01A112_420033")
	
	
	change_face(Fren1, "Anger")
	message("MA_01A112_420034")
	close_speech_window()
	
	
	change_face(Gliten, "Anger")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A112_420035")
	close_speech_window()
	
	

	change_face(Fren1, "Anger")
	open_speech_window("CHRNAME_FREN2", nil, Fren1)
	message("MA_01A112_420036")
	
	
	change_face(Fren1, "Anger")
	message("MA_01A112_420038")
	close_speech_window()
	
	
	change_face(Gliten, "Anger")
	open_speech_window("CHRNAME_SISTERS_3", nil, Gliten)
	message("MA_01A112_420039")
	close_speech_window()
	
	
	
	on_active(Ef_warpW)
	local gridpos = get_grid_position(14,3)
	set_pos(Ef_warpW, gridpos)
	play_particle(Ef_warpW)	
	
	on_active(Ef_warpW2)
	local gridpos = get_grid_position(14,5)
	set_pos(Ef_warpW2, gridpos)
	play_particle(Ef_warpW2)

	wait_time(1.0)

	dot_disp_unit(dotMoronoe, false)	
	dot_disp_unit(dotGliten, false)
	wait_time(0.5)
	
	
	change_face(Fren1, "Anger")
	open_speech_window("CHRNAME_FREN2", nil, Fren1)
	message("MA_01A112_420040")
	close_speech_window()
	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A112_420042")
	
	
	change_face(Lucius, "Normal")
	message("MA_01A112_420043")
	

	
	

    
    MA_01A112_42_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01A112_420045", "MA_01A112_420046")  
    close_speech_window()
 
    if is_select(1) then            
        MA_01A112_42_select1_1()

    else                            
        MA_01A112_42_select1_2()

    end
    MA_01A112_42_end()
 
end
 
function MA_01A112_42_select1()
 
end
 
function MA_01A112_42_select1_1()
 
 	move_camera(14, 4, 1.0)

 	dot_reserve_move_unit_seq(dotNoir2,12,4)
	dot_reserve_move_unit_seq(dotGuinevere1, 12, 3)
	dot_reserve_move_unit_seq(dotGawain, 12, 5)
	exec_parallel_seq()
	wait_seq()
	

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A112_420048")
	close_speech_window()
	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A112_420049")
	
	
	change_face(Lucius, "Normal")
	message("MA_01A112_420050")
	
	
	change_face(Lucius, "Normal")
	message("MA_01A112_420051")
	
	
	

	local gridpos = get_grid_position(16,4)
	set_pos(Ef_lost, gridpos)
	play_particle(Ef_lost)
	
	off_active(Ef_power)
	
	
	
	change_face(Lucius, "Normal")
	
	message("MA_01A112_420059")
	close_speech_window()
 
      
end
 
 
function MA_01A112_42_select1_2()
 
	move_camera(14, 4, 1.0)

 	dot_reserve_move_unit_seq(dotNoir2,12,4)
	dot_reserve_move_unit_seq(dotGuinevere1, 12, 3)
	dot_reserve_move_unit_seq(dotGawain, 12, 5)
	exec_parallel_seq()
	wait_seq()
	

	

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A112_420053")
	close_speech_window()
	
	
	change_face(Fren1, "Normal")
	open_speech_window("CHRNAME_FREN2", nil, Fren1)
	message("MA_01A112_420055")
	
	
	change_face(Fren1, "Anger")
	message("MA_01A112_420056")
	close_speech_window()
	
	
	change_face(Guinevere1, "Sad")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A112_420057")
	close_speech_window()
	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A112_420059")
	close_speech_window()
	
	
	local gridpos = get_grid_position(16,4)
	set_pos(Ef_lost, gridpos)
	play_particle(Ef_lost)
	off_active(Ef_power)
 
    
end
 
 
 
function MA_01A112_42_end()




	
	

	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A112_420061")
	close_speech_window()
	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A112_420062")
	
	

	change_face(Lucius, "Normal")
	message("MA_01A112_420063")
	
	

	change_face(Lucius, "Normal")
	message("MA_01A112_420065")
	
	
	change_face(Lucius, "Normal")
	message("MA_01A112_420067")
	
	
	change_face(Lucius, "Normal")
	message("MA_01A112_420068")
	close_speech_window()
	
	
	open_cutin(2, 1)
	
	on_cutin(1, Noir2, "Anger", 1)
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01A112_420069")
	close_speech_window()
	
	on_cutin(2, Lucius, "Smile", 2)
	
	

	change_face(Lucius, "Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, nil)
	message("MA_01A112_420070")
	
	

	
	message("MA_01A112_420072")
	close_speech_window()

	
	close_cutin()
	wait_time(0.5)
	
	dot_move_unit_seq(dotLucius,19, 4)
	wait_seq()
	
	dot_disp_unit(dotLucius, false)
	
	dot_reserve_move_unit_seq(dotArthur,13, 3)
	dot_reserve_move_unit_seq(dotMerlin1,13,5)
	dot_reserve_move_unit_seq(dotNoir2,12,4)
	dot_reserve_move_unit_seq(dotGuinevere1, 12, 3)
	dot_reserve_move_unit_seq(dotGawain, 12, 5)
	
	exec_parallel_seq()
	wait_seq()
	change_camera_distance(7.0, 1.0)
	move_camera(14, 4, 1.0)
		



	on_active(Ef_Fren)
	local locatorpos = dot_get_unit_locator(dotFren1,1)
	set_pos(Ef_Fren, locatorpos)


	

	change_face(Fren1, "Anger")
	open_speech_window("CHRNAME_FREN2", nil, Fren1)
	message("MA_01A112_420074")
	close_speech_window()
	
	change_camera_distance(7.0, 1.0)
	change_camera_angle(25.0, 0.0)
	
	
	open_cutin(1, 1)
	
	on_cutin(1, Fren1, "Anger", 1)
	


	
	open_speech_window("CHRNAME_FREN2", nil, nil)
	message("MA_01A112_420076")
	close_speech_window()
	
	
	close_cutin()
	wait_time(0.5)





	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,9,4,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 9, 3,0)
	pbadv_setup_101013_Gawain_preload(0,true, 9, 5,0)
	pbadv_setup_101015_Arthur_preload(0,true, 11, 3,0)
	pbadv_setup_101020_Merlin_preload(1,true,11,5,0)
	pbadv_setup_101051_Lucius_preload(0,true, 19, 4,0)
	pbadv_setup_101039_Fren_preload(1,true, 17, 4,0)
	pbadv_setup_101041_Morgan_preload(1,true, 13, 4,0)
	pbadv_setup_101041_Morgan_preload(4,true, 14, 4,0)
	pbadv_setup_101042_Moronoe_preload(true, 14, 3,0)
	pbadv_setup_101044_Gliten_preload(true, 14, 5,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Excl01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem15", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Area", false, true)
end
