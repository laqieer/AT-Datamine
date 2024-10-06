
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201070100", "201070100")
	change_time_and_weather(1,1) 


	
	pbadv_setup_101009_Noir(2,true, 19, 21,0)  
	pbadv_setup_101001_Tyrfing(1,true, 19, 20,0)  
	pbadv_setup_101012_Dinatan(0,true, 19, 22,0)
	pbadv_setup_101017_Maladisant(0,true, 19, 23,0)  

	pbadv_setup_101015_Arthur(0,true, 18, 21,0)  
	
	pbadv_setup_101043_Mazoe(true,21, 21,0)  
	barbaroi1 = dot_reserve_enemy(42, 22, 19, 0)
	barbaroi2 = dot_reserve_enemy(1, 22, 20, 0)
	barbaroi3 = dot_reserve_enemy(42, 22, 22, 0)
	barbaroi4 = dot_reserve_enemy(1, 22, 23, 0)

setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotTyrfing1, 3)
	dot_unit_dir(dotDinatan, 3)
	dot_unit_dir(dotMaladisant, 3)
	dot_unit_dir(dotArthur, 3)
	
	dot_unit_dir(dotMazoe, 2)
	dot_unit_dir(barbaroi1, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	dot_unit_dir(barbaroi4, 2)

	
	dot_disp_unit(dotMazoe, false)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	
	
	Ef_WitchPortal = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	
	
	Ef_baruba1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(20, 22, 0.0)
end



function Play()
	fadein(0)
	Play_start(true)

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_310002")
	close_speech_window()

	
	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_310003")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_310004")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_310006")
	close_speech_window()

	
	on_active(Ef_WitchPortal) 
	local gridpos = get_grid_position(21,21) 
	set_pos(Ef_WitchPortal, gridpos)
	set_scale(Ef_WitchPortal, {0.8, 0.8, 0.8}) 
	play_particle(Ef_WitchPortal)	
	on_active(Ef_baruba1)
	local gridpos = get_grid_position(22,19)
	set_pos(Ef_baruba1 , gridpos)
    set_scale(Ef_baruba1, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba1 )
	on_active(Ef_baruba2 )
	local gridpos = get_grid_position(22,20)
	set_pos(Ef_baruba2 , gridpos)
    set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2 )	
	on_active(Ef_baruba3 )
	local gridpos = get_grid_position(22,22)
	set_pos(Ef_baruba3 , gridpos)
    set_scale(Ef_baruba3, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba3 )
	on_active(Ef_baruba4 )
	local gridpos = get_grid_position(22,23)
	set_pos(Ef_baruba4 , gridpos)
    set_scale(Ef_baruba4, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba4 )

	wait_time(0.2)		
	
	dot_disp_unit(dotMazoe, true)
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)		
	dot_disp_unit(barbaroi4, true)
	
	wait_time(2.0)	

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_310008")
	close_speech_window()

	
	change_face(Mazoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_310009")
	
	change_face(Mazoe, "Smile")
	message("MA_01106_310010")
	
	change_face(Mazoe, "Smile")
	message("MA_01106_310011")
	close_speech_window()
	
	
	move_camera(20, 22, 0.3)
	
	dot_reserve_move_unit_seq(dotArthur, 20, 21)
	exec_parallel_seq()
	wait_seq()
	
	dot_attack_seq(dotArthur, dotMazoe)
	dot_damage_seq(dotMazoe, dotArthur, true)
	
	
	wait_seq()
	

open_cutin(1,1)

on_cutin(1,Arthur,"Serious") 


	

	open_speech_window("CHRNAME_ARTHUR", nil, nil)
	message("MA_01106_310013")
	close_speech_window()


close_cutin()

	
	dot_change_anim(dotArthur,0)	


	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_310014")
	close_speech_window()
	
	
	dot_change_anim(dotArthur, 0)

	
	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_310015")
	close_speech_window()
	


 
    
    MA_01106_31_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01106_310017", "MA_01106_310018")  
 
    if is_select(1) then            
        MA_01106_31_select1_1()
 
    elseif is_select(2) then        
        MA_01106_31_select1_2()
 
    end
    MA_01106_31_end()
 
end
 
function MA_01106_31_select1()
 
end
 
function MA_01106_31_select1_1()
 


	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_310020")
	close_speech_window()

	
	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_310021")
	
	change_face(Arthur, "Serious")
	message("MA_01106_310022")
	close_speech_window()

 
      
end
 
 
function MA_01106_31_select1_2()
 

 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_310024")
	close_speech_window()

	
	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_310025")
	close_speech_window()

	
	change_face(Maladisant, "Normal")
	open_speech_window("CHRNAME_MALADISANT", Maladisant, nil)
	message("MA_01106_310026")
	close_speech_window()

	
	change_face(Dinatan, "Sad")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01106_310027")
	close_speech_window()
 
    
end
 
function MA_01106_31_end()


	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01106_310029")
	close_speech_window()
	
		
	dot_reserve_move_unit_seq(dotNoir2, 19, 1)
	dot_reserve_move_unit_seq(dotTyrfing1, 20, 1)
	dot_reserve_move_unit_seq(dotDinatan, 21, 1)
	dot_reserve_move_unit_seq(dotMaladisant, 19, 2)

	exec_parallel_seq()
	wait_seq()
	
	
	wait_time(0.5)	

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_310031")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_310032")
	close_speech_window()

	
	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01106_310034")
	close_speech_window()

	
	change_face(Mazoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_2", nil, Mazoe)
	message("MA_01106_310035")
	close_speech_window()

	
	wait_time(0.3)	

	dot_change_anim(dotArthur, 3)
	dot_change_anim(dotMazoe, 3)

	
	wait_time(0.2)	

	dot_play_particle_unit(dotArthur,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotMazoe,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	
	wait_time(1.0)	

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 19, 21,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 19, 20,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 19, 22,0)
	pbadv_setup_101017_Maladisant_preload(0,true, 19, 23,0)
	pbadv_setup_101015_Arthur_preload(0,true, 18, 21,0)
	pbadv_setup_101043_Mazoe_preload(true,21, 21,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
end
