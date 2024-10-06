

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	

Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	

	
	init_psbattleadv("201210000", "25010201")
	change_time_and_weather(2,1)
	
	
	pbadv_setup_101009_Noir(2,true, 20, 3,0)  
	
	pbadv_setup_101001_Tyrfing(1,true, 21, 1,0)  
	
	pbadv_setup_101011_Guinevere(0,true, 22, 8,0)  
	pbadv_setup_101013_Gawain(0,true, 18, 8,0)  


	
	
	barbaroi1 = dot_reserve_enemy(42, 16, 1, 0)
	barbaroi2 = dot_reserve_enemy(42, 24, 1, 0)
	barbaroi3 = dot_reserve_enemy(42, 16, 5, 0)
	barbaroi4 = dot_reserve_enemy(42, 24, 5, 0)
	barbaroi5 = dot_reserve_enemy(49, 19, 7, 0)
	barbaroi6 = dot_reserve_enemy(49, 21, 7, 0)
	
	
	Tyr = dot_reserve_facility(52, 20, 0, DotDir_Up, 1, true)
	
	
	
	setup_complete_unit()
	
	

	dot_unit_dir(barbaroi1,3)
	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi5,3)
	dot_unit_dir(dotTyrfing1,2)

	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGawain, false)
	dot_disp_weapon(dotTyrfing1, false)

	
	
	dot_disp_unit(dotGuinevere, false)
	dot_disp_unit(dotGawain, false)
	dot_disp_unit(dotTyrfing1, false)


	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(40.0, 0.0)

	
	
	move_camera(20, 4, 0.0)
	
	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image("101010270", "content_still_10101027_image", "101010270_StillImage")

	
	Ef_Roar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true) 
	Ef_Roar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true) 
	Ef_Roar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true) 
	Ef_Roar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true) 
	Ef_Roar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true) 
	Ef_Roar6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true) 

	Ef_Sword = load_particle("content_effect3d_common_adv", "Ef_C_Adv_LightSword", false, true) 

	Ef_Flash = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true) 

	
	movie_load("MA_01104_22")
	load_sound("SE_ADV_Movie")

	load_sound("BGM_ADV_Tyrfing")

	load_sound("BGM_Battle_Running")

	dot_disp_facility(Tyr,true)

end





function Play()
	fadein(0)
	Play_start(true)



	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_220002")


   
    MA_01104_22_select1()

    open_select_window_tag(Noir2, "Normal", "MA_01104_220003", "MA_01104_220004")  
  	close_speech_window()

if is_select(1) then            
        MA_01104_22_select1_1()

    else                            
        MA_01104_22_select1_2()

    end
    MA_01104_22_end()
     
end
 
function MA_01104_22_select1()
 
end
 
function MA_01104_22_select1_1()
 

 
	
	dot_unit_dir(dotNoir2,2)
	wait_time(0.5)
	dot_unit_dir(dotNoir2,3)
	wait_time(0.5)
	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_220006")
	

	
	change_face(Noir2, "Anger")
	
	message("MA_01104_220007")
	

	
	change_face(Noir2, "Anger")
	
	message("MA_01104_220008")
	close_speech_window()
 
      
end
 
 
function MA_01104_22_select1_2()
 

 
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_220010")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01104_220011")
	

	
	change_face(Noir2, "Sad")
	
	message("MA_01104_220012")
	close_speech_window()
 
    
end
 
 
function MA_01104_22_end()
 


	
	

	
	change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01104_220014")
	close_speech_window()

	
	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_220016")
	close_speech_window()

	
	dot_reserve_move_unit_seq(barbaroi1, 17, 1)
	dot_reserve_move_unit_seq(barbaroi2, 23, 1)
	dot_reserve_move_unit_seq(barbaroi3, 17, 5)
	dot_reserve_move_unit_seq(barbaroi4, 23, 5)
	
	exec_parallel_seq()
	
	wait_seq()

	dot_unit_dir(barbaroi3,3)
	
	
	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01104_220018")
	

	
	dot_reserve_move_unit_seq(barbaroi1, 18, 2)
	dot_reserve_move_unit_seq(barbaroi2, 22, 2)
	dot_reserve_move_unit_seq(barbaroi3, 18, 4)
	dot_reserve_move_unit_seq(barbaroi4, 22, 4)
	dot_reserve_move_unit_seq(barbaroi5, 19, 6)
	dot_reserve_move_unit_seq(barbaroi6, 21, 6)
	
	exec_parallel_seq()
	
	wait_seq()

	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi5,3)

	
	
	change_face(Gawain, "Anger")
	
	message("MA_01104_220020")
	close_speech_window()

	bgm_play("BGM_ADV_Tyrfing_ShortLoop")

	
	
	
	

	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_220022")
	

	
	
	change_face(Noir2, "Anger")
	
	message("MA_01104_220024")
	close_speech_window()
	
	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  
 
	on_cameraframe(2) 
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("101010270", 0.0, 0.0, 0.0) 
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)
	
	
	open_simple_window("NPCNAME_0163")
	message("MA_01104_220026")
	close_simple_window()


	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)
  

	off_cameraframe()
	off_screencolor()
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
	
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)
	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_220028")
	close_speech_window()

	
	
	hide_image(BLACK_WHITE_TIME)

	
	on_active(Ef_Roar1)
	on_active(Ef_Roar2)
	on_active(Ef_Roar3)
	on_active(Ef_Roar4)
	on_active(Ef_Roar5)
	on_active(Ef_Roar6)

	dot_change_anim(barbaroi1,5)
	dot_change_anim(barbaroi2,5)
	dot_change_anim(barbaroi3,5)
	dot_change_anim(barbaroi4,5)
	dot_change_anim(barbaroi5,5)
	dot_change_anim(barbaroi6,5)

	local gridpos = get_grid_position(18, 2)
	set_pos(Ef_Roar1, gridpos)
	set_scale(Ef_Roar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar1)

	local gridpos = get_grid_position(22, 2)
	set_pos(Ef_Roar2, gridpos)
	set_scale(Ef_Roar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar2)

	local gridpos = get_grid_position(18, 4)
	set_pos(Ef_Roar3, gridpos)
	set_scale(Ef_Roar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar3)

	local gridpos = get_grid_position(22, 4)
	set_pos(Ef_Roar4, gridpos)
	set_scale(Ef_Roar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar4)

	local gridpos = get_grid_position(19, 6)
	set_pos(Ef_Roar5, gridpos)
	set_scale(Ef_Roar5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar5)

	local gridpos = get_grid_position(21, 6)
	set_pos(Ef_Roar6, gridpos)
	set_scale(Ef_Roar6, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar6)

	wait_time(0.8)
	
	dot_change_anim(barbaroi1,0)
	dot_change_anim(barbaroi2,0)
	dot_change_anim(barbaroi3,0)
	dot_change_anim(barbaroi4,0)
	dot_change_anim(barbaroi5,0)
	dot_change_anim(barbaroi6,0)

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_220030")
	close_speech_window()


	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_220031")
	close_speech_window()

	wait_time(1.0)

	
	dot_reserve_move_unit_seq(dotNoir2, 20, 1)
	
	exec_parallel_seq()
	
	wait_seq()

	dot_disp_weapon(dotNoir2, false)
	dot_unit_dir(dotNoir2,0)
	dot_change_anim(dotNoir2,3)

	wait_time(0.5)

	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_220033")
 	close_speech_window()

	dot_reserve_move_unit_seq(barbaroi1, 18, 1)
	dot_reserve_move_unit_seq(barbaroi2, 22, 1)
	dot_reserve_move_unit_seq(barbaroi3, 18, 3)
	dot_reserve_move_unit_seq(barbaroi4, 22, 3)
	dot_reserve_move_unit_seq(barbaroi5, 19, 5)
	dot_reserve_move_unit_seq(barbaroi6, 21, 5)
	
	exec_parallel_seq()
	
	wait_seq()

	dot_unit_dir(barbaroi1,3)
	dot_unit_dir(barbaroi2,2)
	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi4,2)

	dot_change_anim(barbaroi1,3)
	dot_change_anim(barbaroi2,3)
	dot_change_anim(barbaroi3,3)
	dot_change_anim(barbaroi4,3)
	dot_change_anim(barbaroi5,3)
	dot_change_anim(barbaroi6,3)


 
    open_select_window_tag(Noir2, "Normal", "MA_01104_220076")  
 	

 	
	open_cutin(1,2)
	
	on_cutin(1,Noir2,"Serious") 

	
	
	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01104_220035")
	close_speech_window()

	bgm_play("BGM_To_Transition_Fade0time")

	
	close_cutin()

	off_active(Ef_Roar1)
	off_active(Ef_Roar2)
	off_active(Ef_Roar3)
	off_active(Ef_Roar4)
	off_active(Ef_Roar5)
	off_active(Ef_Roar6)


	movie_set_active(true)

	fadein(0)
	Play_start(true)
	
	movie_play()

	dot_disp_facility(Tyr,false)

	movie_wait_playing()
	
	move_camera(20, 4, 0.0)
	dot_place_unit(barbaroi1, 17, 3)
	dot_place_unit(barbaroi2, 23, 3)
	dot_place_unit(barbaroi3, 16, 5)
	dot_place_unit(barbaroi4, 24, 5)
	dot_place_unit(barbaroi5, 18, 7)
	dot_place_unit(barbaroi6, 22, 7)

	dot_place_unit(dotGuinevere, 21, 8)
	dot_place_unit(dotGawain, 19, 8)
	
	dot_change_anim(barbaroi1,0)
	dot_change_anim(barbaroi2,0)
	dot_change_anim(barbaroi3,0)
	dot_change_anim(barbaroi4,0)
	dot_change_anim(barbaroi5,0)
	dot_change_anim(barbaroi6,0)

	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi5,3)

	dot_disp_unit(dotGuinevere, true)
	dot_disp_unit(dotGawain, true)
	dot_disp_unit(dotTyrfing1, true)
	dot_change_anim(dotNoir2,0)

	movie_stop()
	

	wait_time(MOVIE_AFTER)

	
	
	change_face(Tyrfing1, "Smile")
	open_speech_window("NPCNAME_0158", Tyrfing1, nil)
	message("MA_01104_220045")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_220046")
	close_speech_window()

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("NPCNAME_0158", Tyrfing1, nil)
	message("MA_01104_220047")
	close_speech_window()

	
	change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01104_220049")
	close_speech_window()

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("NPCNAME_0158", Tyrfing1, nil)
	message("MA_01104_220050")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_220052")
	close_speech_window()

	
	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_220054")
	close_speech_window()

	OpenFirstAppearance(Tyrfing1)

	change_face(Tyrfing1, "Normal")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_220055")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_220056")
	close_speech_window()

	
	dot_reserve_move_unit_seq(barbaroi1, 19, 3)
	dot_reserve_move_unit_seq(barbaroi2, 21, 3)
	dot_reserve_move_unit_seq(barbaroi3, 18, 4)
	dot_reserve_move_unit_seq(barbaroi4, 22, 4)
	dot_reserve_move_unit_seq(barbaroi5, 19, 5)
	dot_reserve_move_unit_seq(barbaroi6, 21, 5)
	
	exec_parallel_seq()
	
	wait_seq()

	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi5,3)

	dot_change_anim(barbaroi1,5)
	dot_change_anim(barbaroi2,5)
	dot_change_anim(barbaroi3,5)
	dot_change_anim(barbaroi4,5)
	dot_change_anim(barbaroi5,5)
	dot_change_anim(barbaroi6,5)

	on_active(Ef_Roar1)
	on_active(Ef_Roar2)
	on_active(Ef_Roar3)
	on_active(Ef_Roar4)
	on_active(Ef_Roar5)
	on_active(Ef_Roar6)

	local gridpos = get_grid_position(19, 3)
	set_pos(Ef_Roar1, gridpos)
	set_scale(Ef_Roar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar1)

	local gridpos = get_grid_position(21, 3)
	set_pos(Ef_Roar2, gridpos)
	set_scale(Ef_Roar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar2)

	local gridpos = get_grid_position(18, 4)
	set_pos(Ef_Roar3, gridpos)
	set_scale(Ef_Roar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar3)

	local gridpos = get_grid_position(22, 4)
	set_pos(Ef_Roar4, gridpos)
	set_scale(Ef_Roar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar4)

	local gridpos = get_grid_position(19, 5)
	set_pos(Ef_Roar5, gridpos)
	set_scale(Ef_Roar5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar5)

	local gridpos = get_grid_position(21, 5)
	set_pos(Ef_Roar6, gridpos)
	set_scale(Ef_Roar6, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar6)

	wait_time(1.0)

	dot_change_anim(barbaroi1,0)
	dot_change_anim(barbaroi2,0)
	dot_change_anim(barbaroi3,0)
	dot_change_anim(barbaroi4,0)
	dot_change_anim(barbaroi5,0)
	dot_change_anim(barbaroi6,0)

	
	
	
	

	
    MA_01104_22_select2()
 
    open_select_window_tag(Noir2, "Normal", "MA_01104_220057", "MA_01104_220058")  
 
     if is_select(1) then            
        MA_01104_22_select2_1()

    else                            
        MA_01104_22_select2_2()

    end
    MA_01104_22_2_end()
    
 end

 
function MA_01104_22_select2()
 
end
 
function MA_01104_22_select2_1()
 

 
	
	bgm_play("BGM_Battle_Running")
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_220060")
	

	
	change_face(Noir2, "Anger")
	
	message("MA_01104_220061")
	close_speech_window()

	
	change_face(Tyrfing1, "Smile")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_220062")
	

 
      
end
 
 
function MA_01104_22_select2_2()
 

 
	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_220064")
	

	
	change_face(Noir2, "Surprise")
	
	message("MA_01104_220065")
	close_speech_window()

	
	change_face(Tyrfing1, "Smile")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_220066")
	
 
    
end

function MA_01104_22_2_end()

	
	
	change_face(Tyrfing1, "Normal")
	
	message("MA_01104_220068")
	

	
	change_face(Tyrfing1, "Normal")
	
	message("MA_01104_220069")
	

	
	change_face(Tyrfing1, "Normal")
	
	message("MA_01104_220070")
	close_speech_window()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_220071")
	close_speech_window()

	
	on_active(Ef_Sword)

	local gridpos = get_grid_position(21, 1)
	gridpos[2] = 10.0
	set_pos(Ef_Sword, gridpos)
	play_particle(Ef_Sword)

	wait_time(0.2)

	local gridpos = get_grid_position(21, 1)
	gridpos[2] = 4.8

	slidemove(Ef_Sword, gridpos, 2.0) 

	wait_time(2.0)

	on_active(Ef_Flash)

	local gridpos = get_grid_position(21, 1)
	gridpos[2] = 4.8
	set_pos(Ef_Flash, gridpos)
	play_particle(Ef_Flash)

	stop_particle(Ef_Sword)
	
	

	dot_disp_weapon(dotTyrfing1, true)

	
	bgm_play("BGM_Battle_Running")
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_220073")
	close_speech_window()


	
	
	
	dot_unit_dir(dotTyrfing1,1)
	dot_change_anim(dotTyrfing1,3)
	dot_play_particle_unit(dotTyrfing1,"Ef_C_Swd_N_Atk01",3,true)
	
	wait_time(0.2)

	dot_change_anim(barbaroi1,6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)

	
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	
	wait_time(0.5)

	dot_change_anim(dotTyrfing1,0)
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	
	dot_unit_dir(dotTyrfing1,2)

	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_220075")
	close_speech_window()

				

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 3,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 21, 1,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 22, 8,0)
	pbadv_setup_101013_Gawain_preload(0,true, 18, 8,0)
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101010270", "content_still_10101027_image", "101010270_StillImage")
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_LightSword", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash01", false, true)
	movie_load_preload("MA_01104_22")
	preload_sound("SE_ADV_Movie")
	preload_sound("BGM_ADV_Tyrfing")
	preload_sound("BGM_Battle_Running")
end
