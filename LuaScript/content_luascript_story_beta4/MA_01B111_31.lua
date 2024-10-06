

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)

	
	init_psbattleadv("201200001", "201200001")
	
	
	change_time_and_weather(1, 1)

	pbadv_setup_101009_Noir(2,true, 4, 3,0)  

	pbadv_setup_101010_Lancelot(0,true, 38, 9,0)  
	pbadv_setup_101010_Lancelot(1,true, 5, 3,0)  
	pbadv_setup_101011_Guinevere(0,true,8,2,0)  
	pbadv_setup_101013_Gawain(0,true,7,3,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 7, 2,0)  
	pbadv_setup_101018_Ragnar(1,true, 8, 1,0)  
	
	pbadv_setup_101026_Percival(0,true, 8, 8,0)  
	pbadv_setup_101027_Dindrane(2,true, 8, 7,0)  
	pbadv_setup_101028_Galahad(1,true, 9, 8,0)  

	pbadv_setup_101024_Bors(0,true, 19, 7,0)  
	pbadv_setup_101025_Clare(1,true, 19, 9,0)  

	pbadv_setup_101053_Mathajim(2,true, 17, 11,0)  
	pbadv_setup_101054_Adam(2,true, 17, 12,0)  
	pbadv_setup_101055_Owen(2,true, 17, 13,0)  

	pbadv_setup_101056_Perez(1,true, 17, 10,0)  
	
	
	barubaroi1 = dot_reserve_enemy(1100, 16, 2, 0)
	barubaroi2 = dot_reserve_enemy(49, 16, 4, 0)
	barubaroi3 = dot_reserve_enemy(1100, 18, 2, 0)
	barubaroi4 = dot_reserve_enemy(49, 18, 4, 0)
	
	barubaroi5 = dot_reserve_enemy(1100, 10, 0, 0)
	barubaroi6 = dot_reserve_enemy(49, 10, 3, 0)
	barubaroi7 = dot_reserve_enemy(1100, 12, 0, 0)
	barubaroi8 = dot_reserve_enemy(49, 12, 3, 0)
	
	barubaroi9 = dot_reserve_enemy(1100, 16, 7, 0)
	barubaroi10 = dot_reserve_enemy(49, 18, 7, 0)

	
	dotroma1 = dot_reserve_ally(401039001, 0, 1, 0)
	dot_set_weapon(dotroma1, 104010001)		
	dotroma2 = dot_reserve_ally(401039001, 0, 2, 0)
	dot_set_weapon(dotroma2, 102010001)		
	dotroma3 = dot_reserve_ally(401039001, 1, 1, 0)
	dot_set_weapon(dotroma3, 104010001)		
	dotroma4 = dot_reserve_ally(401039001, 1, 2, 0)
	dot_set_weapon(dotroma4, 102010001)		
	dotroma5 = dot_reserve_ally(401039001, 0, 3, 0)
	dot_set_weapon(dotroma5, 104010001)		
	dotroma6 = dot_reserve_ally(401039001, 1, 3, 0)
	dot_set_weapon(dotroma6, 102010001)		
	dotroma7 = dot_reserve_ally(401039001, 0, 4, 0)
	dot_set_weapon(dotroma7, 104010001)		
	dotroma8 = dot_reserve_ally(401039001, 1, 4, 0)
	dot_set_weapon(dotroma8, 102010001)		
	
	
	
	setup_complete_unit()
	
	dot_disp_weapon(dotBors,false)
	dot_disp_weapon(dotClare1,false)
	dot_disp_weapon(dotPercival,false)
	dot_disp_weapon(dotDindrane2,false)
	dot_disp_weapon(dotGalahad1,false)

	
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotGwenhwymawr1, 2)
	dot_unit_dir(dotRagnar1, 2)
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotLancelot1, 3)	
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 2)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)
	
	dot_unit_dir(dotPercival, 2)
	dot_unit_dir(dotDindrane2, 2)
	dot_unit_dir(dotGalahad1, 2)
	
	dot_unit_dir(barubaroi5, 3)
	dot_unit_dir(barubaroi6, 3)
	dot_unit_dir(barubaroi7, 2)
	dot_unit_dir(barubaroi8, 2)
	dot_unit_dir(barubaroi9, 2)
	dot_unit_dir(barubaroi10, 2)

	
	dot_change_anim(dotGuinevere, 1)
	dot_change_anim(dotGawain, 1)
	dot_change_anim(dotGwenhwymawr1, 1)
	dot_change_anim(dotRagnar1, 1)
	dot_change_anim(dotroma1, 1)
	dot_change_anim(dotroma2, 1)
	dot_change_anim(dotroma3, 1)
	dot_change_anim(dotroma4, 1)
	dot_change_anim(dotroma5, 1)
	dot_change_anim(dotroma6, 1)
	dot_change_anim(dotroma7, 1)
	dot_change_anim(dotroma8, 1)
	
	
	dot_disp_unit(dotMathajim2, false)
	dot_disp_unit(dotAdam2, false)
	dot_disp_unit(dotOwen2, false)
	dot_disp_unit(dotBors, false)
	dot_disp_unit(dotClare1, false)
	dot_disp_unit(barubaroi1, false)
	dot_disp_unit(barubaroi2, false)
	dot_disp_unit(barubaroi3, false)
	dot_disp_unit(barubaroi4, false)
	dot_disp_unit(barubaroi5, false)
	dot_disp_unit(barubaroi6, false)
	dot_disp_unit(barubaroi7, false)
	dot_disp_unit(barubaroi8, false)
	dot_disp_unit(barubaroi9, false)
	dot_disp_unit(barubaroi10, false)
	
	
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	

	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(9, 8, 0.0)
end

function Play()
	fadein(0)
	Play_start(true)

	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310002")
	close_speech_window()

	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_310003")
	close_speech_window()

	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310004")

	
	
	
	
	change_face(Galahad1, "Normal")
	message("MA_01B111_310006")
	close_speech_window()
	
	se_play("SE_ADV_MA_01A900_25_Earthquake_loop")
	
	wait_time(1.5)	
	
	
	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_310008")
	close_speech_window()

	
	change_face(Dindrane2, "Normal")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_310009")
	close_speech_window()

	
	se_play("SE_ADV_MA_01B111_31_Rupture_Wood")
	se_play("SE_LoopSE_Stop")
	
	move_camera(17, 3, 0.9)
	wait_time(0.9)	

	
	dot_disp_unit(dotBors, true)
	dot_disp_unit(dotClare1, true)
	
	dot_reserve_move_unit_seq(dotBors, 17, 2)
	dot_reserve_move_unit_seq(dotClare1, 17, 3)
	exec_parallel_seq()
	wait_seq()	
	
	dot_unit_dir(dotBors, 2)
	dot_unit_dir(dotClare1, 2)

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_310011")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	message("MA_01B111_310012")
	close_speech_window()

	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B111_310013")
	close_speech_window()

	
	
	move_camera(17, 8, 0.7)

	
	dot_disp_unit(dotMathajim2, true)
	dot_disp_unit(dotAdam2, true)
	dot_disp_unit(dotOwen2, true)
	dot_disp_unit(dotPerez1, true)
	
	
	dot_reserve_move_unit_seq(dotPerez1, 17, 7)
	dot_reserve_move_unit_seq(dotMathajim2, 18, 10)
	dot_reserve_move_unit_seq(dotAdam2, 17, 10)
	dot_reserve_move_unit_seq(dotOwen2, 16, 10)	
	exec_parallel_seq()
	wait_seq()	
	
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 2)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotLancelot1, 3)	
	
	
	wait_time(1.0)
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310015")
	close_speech_window()
	
	
	move_camera(5, 3, 0.7)
	wait_time(0.5)

	
	
	change_time_and_weather(1, 5)	
	
	wait_time(1.0)
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_310017")
	close_speech_window()
	
	
	

	dot_disp_weapon(dotBors,false)
	dot_disp_weapon(dotClare1,false)
	
	
	dot_disp_unit(barubaroi1, true)
	dot_disp_unit(barubaroi2, true)
	dot_disp_unit(barubaroi3, true)
	dot_disp_unit(barubaroi4, true)
	
	
	dot_unit_dir(dotPercival, 3)
	dot_unit_dir(dotGalahad1, 3)
	dot_unit_dir(dotDindrane2, 3)
	dot_unit_dir(dotBors, 2)
	dot_unit_dir(dotClare1, 3)
	dot_unit_dir(barubaroi1, 3)
	dot_unit_dir(barubaroi2, 3)
	dot_unit_dir(barubaroi3, 2)
	dot_unit_dir(barubaroi4, 2)
	
		
	move_camera(11, 2, 0.7)
	
	dot_reserve_move_unit_seq(dotNoir2, 11, 1)
	dot_reserve_move_unit_seq(dotLancelot1, 11, 2)	
	exec_parallel_seq()
	wait_seq()	
	

	
	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_310019")
	close_speech_window()

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_310021")



















    
    MA_01B111_31_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B111_310022", "MA_01B111_310023", "MA_01B111_310024")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01B111_31_select1_1()
 
    elseif is_select(2) then        
        MA_01B111_31_select1_2()
 
    elseif is_select(3) then        
        MA_01B111_31_select1_3()
 
    end
    MA_01B111_31_end()
 
end
 
function MA_01B111_31_select1()
 
end
 
function MA_01B111_31_select1_1()
 

 
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_310026")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_310027")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_310028")
	close_speech_window()
	
	
	move_camera(9, 8, 0.7)
	wait_camera()

	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310039")
	close_speech_window()
	
      
end
 
 
function MA_01B111_31_select1_2()
 

 
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_310030")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_310031")

	
	change_face(Lancelot1, "Normal")
	message("MA_01B111_310032")
	close_speech_window()
	
	
	
	move_camera(9, 8, 0.7)
	wait_camera()
	
	
	change_face(Galahad1, "Sad")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310039")
	close_speech_window()
	
    
end
 
 
function MA_01B111_31_select1_3()
 


	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_310034")
	close_speech_window()

	
	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	message("MA_01B111_310035")
	close_speech_window()
	
	
	move_camera(9, 8, 0.7)
	wait_camera()

	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310037")
	

	
	change_face(Galahad1, "Sad")
	message("MA_01B111_310039")
	close_speech_window()
	
        
end
 
 
function MA_01B111_31_end()


	

 

	
	move_camera(12, 3, 0.7)
	wait_camera()
	
	
	on_active(Ef_bar1) 

	local gridpos = get_grid_position(10, 0) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)
	
	on_active(Ef_bar2) 

	local gridpos = get_grid_position(12, 0) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)	

	wait_time(0.2)
        
	dot_disp_unit(barubaroi5, true) 
	dot_disp_unit(barubaroi7, true) 

	wait_time(0.5)	
	
	on_active(Ef_bar3) 

	local gridpos = get_grid_position(10, 3) 
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar3)
	
	on_active(Ef_bar4) 

	local gridpos = get_grid_position(12, 3) 
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar4)	
	
	wait_time(0.2)
        
	dot_disp_unit(barubaroi6, true) 
	dot_disp_unit(barubaroi8, true) 

	wait_time(2.0)	
	
	
	move_camera(17, 8, 0.8)
	wait_camera()
	
	dot_disp_weapon(dotMathajim2,true)
	dot_disp_weapon(dotAdam2,true)
	dot_disp_weapon(dotOwen2,true)

	
	wait_time(0.5)
	
	
	dot_change_anim(dotPerez1, 5)	

	on_active(Ef_BriB )
	local gridpos = get_grid_position(17, 7)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )	
		
	
	wait_time(0.5)
	
	on_active(Ef_bar5) 

	local gridpos = get_grid_position(16, 7) 
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar5)
	
	on_active(Ef_bar6) 

	local gridpos = get_grid_position(18, 7) 
	set_pos(Ef_bar6, gridpos)
	set_scale(Ef_bar6, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar6)	

	wait_time(0.2)
        
	dot_disp_unit(barubaroi9, true) 
	dot_disp_unit(barubaroi10, true) 

	wait_time(2.0)

	
	
	
	
	
	
	
	move_camera(9, 8, 1.1)
	wait_camera()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310041")
	close_speech_window()

	
	dot_disp_weapon(dotGalahad1,true)
	dot_change_anim(dotGalahad1, 12)
	
	
	wait_time(1.0)
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_310043")
	close_speech_window()



	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 4, 3,0)
	pbadv_setup_101010_Lancelot_preload(0,true, 38, 9,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 5, 3,0)
	pbadv_setup_101011_Guinevere_preload(0,true,8,2,0)
	pbadv_setup_101013_Gawain_preload(0,true,7,3,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 7, 2,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 8, 1,0)
	pbadv_setup_101026_Percival_preload(0,true, 8, 8,0)
	pbadv_setup_101027_Dindrane_preload(2,true, 8, 7,0)
	pbadv_setup_101028_Galahad_preload(1,true, 9, 8,0)
	pbadv_setup_101024_Bors_preload(0,true, 19, 7,0)
	pbadv_setup_101025_Clare_preload(1,true, 19, 9,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 17, 11,0)
	pbadv_setup_101054_Adam_preload(2,true, 17, 12,0)
	pbadv_setup_101055_Owen_preload(2,true, 17, 13,0)
	pbadv_setup_101056_Perez_preload(1,true, 17, 10,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
end
