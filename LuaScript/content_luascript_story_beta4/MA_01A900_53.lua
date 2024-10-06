
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)
	

	
	load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010151", "content_still_10101015_image", "101010150_StillImage")
	load_image("101010152", "content_still_10101015_image", "101010150_StillImage")
	
	
	init_psbattleadv("201150000", "201150000")
	
	
	change_time_and_weather(2, 1)

	
	pbadv_setup_101009_Noir(2,true, 17, 22,0)  
	pbadv_setup_101011_Guinevere(0,true, 17, 21,0)  
	pbadv_setup_101051_Lucius(0,true, 20, 22,0)  
	pbadv_setup_101030_Elaine(1,true, 5, 21,0)  
	pbadv_setup_101031_Lovein(1,true, 5, 22,0)  
	pbadv_setup_101016_Gwenhwymawr(0,true, 20, 2,0)  
	
	pbadv_setup_101010_Lancelot(3,true, 14, 20,0)  
	pbadv_setup_101015_Arthur(0,true, 14, 22,0)  
	pbadv_setup_101012_Dinatan(0,true, 14, 23,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 14, 21,0)  
	pbadv_setup_101017_Maladisant(1,true, 14, 24,0)  
	
	ryuu = dot_reserve_ally(201021001, 25,  20, 0)
	dot_set_weapon(ryuu, 105010001)		
	
	barbaroi1 = dot_reserve_enemy(1, 23, 20, 0)
	barbaroi2 = dot_reserve_enemy(1, 23, 24, 0)	

setup_complete_unit()

	
	Ef_EnemyDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	Ef_baruba1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_baruba2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	
	Ef_BriB2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	


	

	dot_unit_dir(dotLucius, 2)
	dot_unit_dir(ryuu, 2)

	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotLucius, false)
	dot_disp_weapon(dotElaine1, false)
	dot_disp_weapon(dotLovein1, false)
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotDinatan, false)
	dot_disp_weapon(dotGwenhwymawr1, false)
	dot_disp_weapon(dotMaladisant1, false)

	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)

	
	dot_change_anim(dotLucius,1)



	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(34.0, 0.0)
	move_camera(19, 23, 0.0)


	movie_load("MA_01A900_52")


	load_sound("BGM_ADV_Painful")
end



function Play()

	fadein(0)

	Play_start(true)
	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A900_530002")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_530003")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A900_530004")


	
    
    
 
    
    MA_01A900_53_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01A900_530006", "MA_01A900_530007")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01A900_53_select1_1()
 
    elseif is_select(2) then        
        MA_01A900_53_select1_2()
 
    end
    MA_01A900_53_end()
 
end
 
function MA_01A900_53_select1()
 
end
 
function MA_01A900_53_select1_1()
 

 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_530009")
	close_speech_window()

	
	change_face(Lucius, "Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A900_530010")
	
	change_face(Lucius, "Normal")
	message("MA_01A900_530011")
	
	change_face(Lucius, "Normal")
	message("MA_01A900_530017")
	
	change_face(Lucius, "Smile")
	message("MA_01A900_530018")
	close_speech_window()
 
      
end
 
 
function MA_01A900_53_select1_2()
 

 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_530013")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A900_530014")
	
	change_face(Lucius, "Normal")
	message("MA_01A900_530015")
	
	change_face(Lucius, "Normal")
	message("MA_01A900_530017")
	
	change_face(Lucius, "Smile")
	message("MA_01A900_530018")
	close_speech_window()
 
    
end
 
function MA_01A900_53_end()
 


	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530019")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_530020")
	close_speech_window()

	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A900_530021")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530022")
	close_speech_window()

	
	change_face(Lucius, "Smile")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	message("MA_01A900_530023")
	
	change_face(Lucius, "Smile")
	message("MA_01A900_530024")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")

	movie_set_active(true)
	movie_play()
	

	dot_disp_unit(dotLucius, false)	
	dot_place_unit(dotLucius,20, 24)
	


	movie_wait_playing()
	movie_stop()
	
	
	wait_time(MOVIE_AFTER)




	



	


	


	



	
	
	
	
	





















	
	
	



	
	
	
	
	
	


	wait_time(0.5)

	
	move_camera(23, 22, 0.7)
	
	wait_camera()

	dot_change_anim(ryuu,3)
	wait_time(0.5)

	se_play("SE_ADV_MA_01A900_36_WhiteDrg_Roar")

	on_active(Ef_BriB)
	local gridpos = get_grid_position(26,21)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	wait_time(1.0)	

	dot_change_anim(ryuu,0)

	wait_time(1.0)	

	
	on_active(Ef_baruba1)
	local gridpos = get_grid_position(23,20)
	set_pos(Ef_baruba1 , gridpos)
	set_scale(Ef_baruba1, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba1 )

	on_active(Ef_baruba2 )
	local gridpos = get_grid_position(23,24)
	set_pos(Ef_baruba2 , gridpos)
	set_scale(Ef_baruba2, {0.8, 0.8, 0.8})
	play_particle(Ef_baruba2 )

	wait_time(0.2)	

	dot_disp_unit(barbaroi2, true)	
	dot_disp_unit(barbaroi1, true)	
	
	wait_time(2.0)	

	
	
	move_camera(19, 23, 0.7)
	wait_camera()	

	
	dot_change_anim(dotGuinevere,0)
	

	wait_time(0.5)			

	bgm_play("BGM_ADV_Painful")
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530031")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_530032")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_530033")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530034")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotGuinevere, 19, 21)
	exec_parallel_seq()
	wait_seq()	

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530036")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_530038")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_530040")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530041")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_530042")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_530043")
	close_speech_window()

	
	change_face(Elaine1, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530044")
	close_speech_window()
	
	
	
	
	
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotNoir2, 2)
	
	
	move_camera(16, 23, 0.8)
	
	
	dot_reserve_move_unit_seq(dotLovein1, 15, 22)
	dot_reserve_move_unit_seq(dotElaine1, 15, 21)
	exec_parallel_seq()
	wait_seq()
	

	
	change_face(Elaine1, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530046")
	close_speech_window()

	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
show_image("101010150", 0.0, 0.0, 0.0,false,false)
set_scale_image(13.0,13.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN) 

	
	
	open_simple_window("NPCNAME_0352")
	message("MA_01A900_530048")
	close_simple_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	

	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530049")
	
	change_face(Elaine1, "Normal")
	message("MA_01A900_530050")
	
	change_face(Elaine1, "Normal")
	message("MA_01A900_530051")
	
	change_face(Elaine1, "Sad")
	message("MA_01A900_530052")
	close_speech_window()
	
	wait_time(0.5)
	
	
	
	dot_unit_dir(dotGuinevere, 3)
	
	wait_time(0.5)

	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530054")
	close_speech_window()
	
	
	
	move_camera(19, 23, 0.5)
	
	
	
	dot_reserve_move_unit_seq(dotElaine1, 18, 21)
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_unit_dir(dotNoir2, 3)
	

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530056")
	close_speech_window()

	
	change_face(Elaine1, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530057")
	close_speech_window()
	
	
	move_camera(23, 22, 0.7)
	wait_camera()
	
	wait_time(0.5)	
	
	
	
	
	dot_change_anim(ryuu,3)
	wait_time(0.5)

	on_active(Ef_BriB2)
	local gridpos = get_grid_position(26,21)
	set_pos(Ef_BriB2, gridpos)
	play_particle(Ef_BriB2)
	wait_time(1.0)	

	dot_change_anim(ryuu,0)
	wait_time(1.0)	
		
	
	move_camera(19, 23, 0.7)	
	wait_camera()	

	
	change_face(Elaine1, "Normal")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530059")
	close_speech_window()
	

open_cutin(1,1)

on_cutin(1,Elaine1, "Shy") 


	

	open_speech_window("CHRNAME_ELAINE", nil, nil)
	message("MA_01A900_530060")
	close_speech_window()


close_cutin()

	move_camera(16, 23, 0.7)	
	wait_camera()	
	
	change_face(Lovein1, "Surprise")
	open_mind_window("CHRNAME_LOVEIN2", Lovein1, nil)
	message("MA_01A900_530061")
	close_mind_window()

	
	change_face(Arthur, "Surprise")
	open_mind_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A900_530062")
	close_mind_window()

	move_camera(19, 23, 0.7)	
	wait_camera()	
	
	wait_time(0.5)	
	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530063")
	close_speech_window()

	
	change_face(Elaine1, "Shy")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530064")
	close_speech_window()

	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
show_image("101010151", 0.0, 0.0, 0.0,false,false)
set_scale_image(13.0,13.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN) 

	
	open_simple_window("NPCNAME_0352")
	message("MA_01A900_530065")
	close_simple_window()

	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	

	
	
	
	dot_unit_dir(dotGuinevere, 2)

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530067")
	close_speech_window()

	
	change_face(Elaine1, "Shy")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530068")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530069")
	close_speech_window()
	
	

	
	change_face(Elaine1, "Shy")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530071")
	close_speech_window()
	
	
	
	

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530073")
	close_speech_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
show_image("101010152", 0.0, 0.0, 0.0,false,false)
set_scale_image(13.0,13.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN) 


	
	open_simple_window("NPCNAME_0352")
	message("MA_01A900_530074")
	close_simple_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

	

	
	

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530076")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_530077")
	close_speech_window()

	
	change_face(Elaine1, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530079")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530081")
	close_speech_window()

	
	change_face(Elaine1, "Surprise")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530083")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530084")
	
	change_face(Guinevere, "Normal")
	message("MA_01A900_530085")
	close_speech_window()
	
	
	
	
	dot_reserve_move_unit_seq(dotGuinevere, 20, 21)
	exec_parallel_seq()
	wait_seq()
	
	
	dot_unit_dir(dotArthur, 3)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_530087")
	close_speech_window()

	
	change_face(Elaine1, "Shy")
	open_speech_window("CHRNAME_ELAINE", Elaine1, nil)
	message("MA_01A900_530088")
	close_speech_window()

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530089")
	close_speech_window()
	
	
	
	
	
		
	move_camera(22, 23, 0.5)
	
	
	dot_reserve_move_unit_seq(dotNoir2, 20, 22)
	exec_parallel_seq()
	wait_seq()
	
	wait_time(1.0)	

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01A900_530091")
	close_speech_window()

	
	
	

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010151", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101010152", "content_still_10101015_image", "101010150_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 17, 22,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 17, 21,0)
	pbadv_setup_101051_Lucius_preload(0,true, 20, 22,0)
	pbadv_setup_101030_Elaine_preload(1,true, 5, 21,0)
	pbadv_setup_101031_Lovein_preload(1,true, 5, 22,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 20, 2,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 14, 20,0)
	pbadv_setup_101015_Arthur_preload(0,true, 14, 22,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 14, 23,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 14, 21,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 14, 24,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	movie_load_preload("MA_01A900_52")
	preload_sound("BGM_ADV_Painful")
end
