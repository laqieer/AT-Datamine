
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201150000", "201150000")
	
	
	change_time_and_weather(4, 4)
	
	
	load_image("MA01A9004401", "content_still_10101011_image", "101010111_StillImage")
	load_image("MA01A9004402", "content_still_10101011_image", "101010112_StillImage")	
	load_image("MA01A9004403", "content_still_10101011_image", "101010110_StillImage")	

	load_image("101010141", "content_still_10101014_image", "101010140_StillImage")

	
	
	pbadv_setup_101009_Noir(2,true, 17, 23,0)  
	pbadv_setup_101011_Guinevere(1,true, 18, 22,0)  
	pbadv_setup_101051_Lucius(2,true, 22, 22,0)  
	pbadv_setup_101010_Lancelot(3,true, 19, 20,0)  

	pbadv_setup_101015_Arthur(0,true, 19, 22,0)  
	pbadv_setup_101012_Dinatan(0,true, 19, 23,0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 19, 21,0)  
	pbadv_setup_101017_Maladisant(1,true, 19, 24,0)  
	pbadv_setup_101038_Lola(2,true, 21, 11,0) 
	pbadv_setup_101039_Fren(2,true, 21, 12,0) 
	pbadv_setup_101021_Bruno(0,true, 0, 10,0)  

	barbaroi1 = dot_reserve_enemy(304, 23, 20, 0)
	barbaroi2 = dot_reserve_enemy(1204, 23, 21, 0)
	barbaroi3 = dot_reserve_enemy(304, 23, 23, 0)
	barbaroi4 = dot_reserve_enemy(1204, 23, 24, 0)
	
	ryuu = dot_reserve_ally(201021001, 25,  20, 0)
	dot_set_weapon(ryuu, 105010001)		
	

setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotGuinevere1, 3)
	dot_unit_dir(dotLola2, 2)
	dot_unit_dir(dotFren2, 2)
	dot_unit_dir(dotLucius2, 2)
	dot_unit_dir(ryuu, 2)
	
	dot_unit_dir(dotLancelot3, 3)
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotDinatan, 3)
	dot_unit_dir(dotGwenhwymawr1, 3)
	dot_unit_dir(dotMaladisant1, 3)








	
	

	dot_disp_weapon(dotGuinevere1, false)







	
	dot_disp_unit(dotLancelot3, false)
	dot_disp_unit(dotArthur, false)
	dot_disp_unit(dotDinatan, false)
	dot_disp_unit(dotGwenhwymawr1, false)
	dot_disp_unit(dotMaladisant1, false)

	
	dot_change_anim(dotGuinevere1,1)
	dot_change_anim(dotLancelot3,1)
	dot_change_anim(dotArthur,1)
	dot_change_anim(dotDinatan,1)
	dot_change_anim(dotGwenhwymawr1,1)
	dot_change_anim(dotMaladisant1,1)

	
	
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	
	
	Ef_Aura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)	

	
	change_camera_distance(8, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(22, 22, 0.0)

	load_sound("BGM_ADV_Elation")
	
end



function Play()
	fadein(0)
	Play_start(true)
	

	
	wait_time(1.0)	
	
	se_play("SE_ADV_MA_01A900_36_WhiteDrg_Roar")
	
	dot_change_anim(ryuu,3)
	wait_time(0.5)
	on_active(Ef_BriB)
	local gridpos = get_grid_position(26,21)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	wait_time(1.0)	
	dot_change_anim(ryuu,0)
	
	wait_time(0.5)	
	
	
	move_camera(20, 23, 1.0)
	wait_camera()	
	
	wait_time(0.5)	
	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_440002")
	

	
	change_face(Lucius2, "Normal")
	
	message("MA_01A900_440004")
	
	change_face(Lucius2, "Normal")
	message("MA_01A900_440005")
	close_speech_window()

	
	dot_change_anim(dotGuinevere1,0)
	
	
	wait_time(0.5)

	
	dot_disp_weapon(dotGuinevere1, true)
	

open_cutin(1,1)

on_cutin(1,Guinevere1,"Anger") 



	

	open_speech_window("CHRNAME_GUINEVERE2", nil, nil)
	message("MA_01A900_440007")
	close_speech_window()


close_cutin()


	
	
	
	on_active(Ef_Aura )
	local gridpos = get_grid_position(22,22)
	set_pos(Ef_Aura , gridpos)
	play_particle(Ef_Aura )
	wait_time(1.0)	

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_440009")
	close_speech_window()
	
	
	
	dot_play_particle_unit(dotLucius2,"Ef_C_Mag_R_Cha01",1,true)	
	
	
	wait_time(1.0)	
	
	dot_play_particle_unit(dotLucius2,"Ef_C_Mag_R_Atk01",1,true)
	
	dot_change_anim(dotLucius2,4)		
	
	
	wait_time(0.5)	

	
	
	wait_time(0.2)		
	
	dot_play_particle_unit(dotGuinevere1,"Ef_C_Mag_R_Hit01",1,true)	
	
	move_camera(19, 23, 0.3)	
	dot_move_knockback(dotGuinevere1, 17, 22,0.2, 2)

	
	wait_time(0.4)
	
		
	dot_change_anim(dotGuinevere1,1)
	
	dot_unit_dir(dotGuinevere1, 3)
	
	
	stop_particle(Ef_Aura)
	
	dot_change_anim(dotLucius2,0)	
	
	change_face(Guinevere1, "Pain")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_440011")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_440012")
	close_speech_window()

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_440013")
	close_speech_window()

	bgm_play("BGM_ADV_Elation")

	
	on_cameraframe(2)
	
	
	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 	
	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("MA01A9004402", 0.0, 0.0, 0.0,true,false)
	set_scale_image(1.5,1.5)
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)	
	
	
	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01A900_440015")
	close_simple_window()
	
	
	open_simple_window("NPCNAME_0163")
	message("MA_01A900_440017")
	close_simple_window()
	
	
	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)

	 
	
	
	show_image("MA01A9004401", 0.0, 0.0, 0.0,true,false)
	set_scale_image(1.5,1.5)
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)

	
	
	open_simple_window("CHRNAME_BRUNO")
	message("MA_01A900_440019")
	close_simple_window()
	
	
	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)

	 
	
	
	show_image("MA01A9004403", 0.0, 0.0, 0.0,true,false)
	set_scale_image(1.0,1.0)
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)
	
	
	open_simple_window("NPCNAME_0163")
	message("MA_01A900_440021")
	close_simple_window()

	
	dot_change_anim(dotLucius2,0)
	
		
	dot_disp_unit(dotLancelot3, true)
	dot_disp_unit(dotArthur, true)
	dot_disp_unit(dotDinatan, true)
	dot_disp_unit(dotGwenhwymawr1, true)
	dot_disp_unit(dotMaladisant1, true)	

	
	
	open_simple_window("CHRNAME_BRUNO")
	message("MA_01A900_440022")
	close_simple_window()
	

	
	
	
	
	
	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)
 
	
	hide_image()
 
	
	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)
	
	
	off_cameraframe()


	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	change_face(Gwenhwymawr1, "Pain")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01A900_440024")
	close_speech_window()

	
	change_face(Maladisant1, "Anger")
	open_speech_window("CHRNAME_MALADISANT2", Maladisant1, nil)
	message("MA_01A900_440025")
	close_speech_window()

	
	change_face(Dinatan, "Pain")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01A900_440026")
	close_speech_window()

	
	change_face(Lancelot3, "Pain")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01A900_440027")
	close_speech_window()

	
	change_face(Arthur, "Pain")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01A900_440028")
	close_speech_window()
	
	move_camera(22, 23, 1.0)	
	
	dot_reserve_move_unit_seq(dotLola2, 21, 21)
	dot_reserve_move_unit_seq(dotFren2, 21, 23)
	exec_parallel_seq()
	wait_seq()

	
	dot_unit_dir(dotLola2, 2)
	dot_unit_dir(dotFren2, 2)

	
	change_face(Lola2, "Anger")
	open_speech_window("CHRNAME_LOLA2", nil, Lola2)
	message("MA_01A900_440030")
	close_speech_window()

	
	change_face(Fren2, "Anger")
	open_speech_window("CHRNAME_FREN2", nil, Fren2)
	message("MA_01A900_440031")
	close_speech_window()

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_440032")
	close_speech_window()
	
	
	

	dot_change_anim(ryuu,3)
	wait_time(0.5)
	
	on_active(Ef_BriB)
	local gridpos = get_grid_position(26,21)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	wait_time(1.0)	
	dot_change_anim(ryuu,0)
	
	
	move_camera(18, 23, 1.0)
	wait_camera()	


	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_440034")
	close_speech_window()

	wait_time(0.5)
	
	
	dot_change_anim(dotGuinevere1,0)
	
	
	wait_time(1.0)

	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_440036")
	
	change_face(Guinevere1, "Anger")
	message("MA_01A900_440037")


	bgm_play("BGM_To_End")


	
	

    MA_01A900_44_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01A900_441001")  
	close_speech_window()
	 
    if is_select(1) then            
        MA_01A900_44_select1_1()
 
    end
    MA_01A900_44_end()

end
 
function MA_01A900_44_select1()
 
end
 
function MA_01A900_44_select1_1()
 

 

 
      
end
 
 
function MA_01A900_44_end()
 

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA01A9004401", "content_still_10101011_image", "101010111_StillImage")
	load_image_preload("MA01A9004402", "content_still_10101011_image", "101010112_StillImage")
	load_image_preload("MA01A9004403", "content_still_10101011_image", "101010110_StillImage")
	load_image_preload("101010141", "content_still_10101014_image", "101010140_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 17, 23,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 18, 22,0)
	pbadv_setup_101051_Lucius_preload(2,true, 22, 22,0)
	pbadv_setup_101010_Lancelot_preload(3,true, 19, 20,0)
	pbadv_setup_101015_Arthur_preload(0,true, 19, 22,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 19, 23,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 19, 21,0)
	pbadv_setup_101017_Maladisant_preload(1,true, 19, 24,0)
	pbadv_setup_101038_Lola_preload(2,true, 21, 11,0)
	pbadv_setup_101039_Fren_preload(2,true, 21, 12,0)
	pbadv_setup_101021_Bruno_preload(0,true, 0, 10,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	preload_sound("BGM_ADV_Elation")
end
