Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	Selste=set_chara_unknown()
	character2DFull(Selste,"Selste",101060001)
	
	
	init_psbattleadv("201180001","201180001")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)
	
	load_image("101010140","content_still_10101014_image", "101010140_StillImage")
	load_image("101010270", "content_still_10101027_image", "101010270_StillImage")
	
	pbadv_setup_101010_Lancelot(1,true,22,20,0)
	
	pbadv_setup_101009_Noir(2,true,21,20,0)
	
	pbadv_setup_101028_Galahad(1,true,20,30,0)  
	
	dotArthur_D=dot_reserve_ally(201021001,20,15,0)
	dot_set_weapon(dotArthur_D,101010001)
	
	barbaroi1=dot_reserve_enemy(1302,23,16,0)
	barbaroi2=dot_reserve_enemy(1302,23,17,0)
	barbaroi3=dot_reserve_enemy(1302,19,16,0)
	barbaroi4=dot_reserve_enemy(1302,19,17,0)
	barbaroi5=dot_reserve_enemy(1209,24,11,0)
	barbaroi6=dot_reserve_enemy(1209,18,11,0)
	barbaroi7=dot_reserve_enemy(602,19,12,0)
	barbaroi8=dot_reserve_enemy(602,20,11,0)
	barbaroi9=dot_reserve_enemy(204,22,11,0)
	barbaroi10=dot_reserve_enemy(204,23,12,0)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotLancelot1,3)
	dot_unit_dir(dotArthur_D,2)

	
	

	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(35.0,0.0)

	
	
	move_camera(21,18,0.0)
	
	Ef_K_GD_L=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_GD_Lop",false,true)
	Ef_Cloak_Kira=load_particle("content_effect3d_common_adv","Ef_C_Adv_Cloak_Kira",false,true)
	Ef_Roar01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	Ef_VibesAura=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
end





function Play()
	fadein(0)
	Play_start(true)

	
	wait_time(1.0)
	
	
	change_face(Galahad1,"Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500002")
	close_speech_window()

	move_camera(21,21,1.0)
	
	dot_move_unit_seq(dotGalahad1,20,22)
	wait_seq()
	dot_unit_dir(dotGalahad1,3)
	
	
	dot_unit_dir(dotNoir2,2)
	
	dot_unit_dir(dotLancelot1,2)
	
	
	
	change_face(Lancelot1,"Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500004")
	close_speech_window()

	
	change_face(Galahad1,"Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500005")

	
	
	change_face(Galahad1,"Anger")
	message("MA_01B900_500006")
	close_speech_window()

	wait_time(1.0)

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500008")
	close_speech_window()

	
	
	change_face(Galahad1,"Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500009")

	
	change_face(Galahad1,"Anger")
	message("MA_01B900_500011")
	
	
	change_face(Galahad1,"Pain")
	message("MA_01B900_500012")
	close_speech_window()
	
	wait_time(1.0)
	
	
	
	dot_move_unit_seq(dotGalahad1,20,20) 
	wait_seq()
	dot_unit_dir(dotGalahad1,3)
	
	
	change_face(Galahad1,"Sad")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500014")

	
	change_face(Galahad1,"Sad")
	message("MA_01B900_500015")

	
	change_face(Galahad1,"Sad")
	message("MA_01B900_500016")


	
	change_face(Galahad1,"Anger")
	message("MA_01B900_500017")

	wait_time(0.5)

	
	change_face(Galahad1,"Anger")
	message("MA_01B900_500018")
	
	
	
	change_face(Galahad1,"Anger")
	message("MA_01B900_500019")

	
	change_face(Galahad1,"Pain")
	message("MA_01B900_500021")
	

	
	
	 MA_01B900_50_select1()
 
    open_select_window_tag(Noir2,"Normal","MA_01B900_500022","MA_01B900_500023")  
    
	close_speech_window()
 
    if is_select(1) then            
        MA_01B900_50_select1_1()
 
    elseif is_select(2) then        
        MA_01B900_50_select1_2()
 
    end
    MA_01B900_50_end()
 
end
 
function MA_01B900_50_select1()
 
end
 
function MA_01B900_50_select1_1()

	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500025")
	close_speech_window()

	
	change_face(Galahad1,"Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500026")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500027")
	close_speech_window()

	
	change_face(Lancelot1,"Sad")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500028")
	close_speech_window()

	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500029")
	close_speech_window()

end
 
 
function MA_01B900_50_select1_2()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500031")
	close_speech_window()

	
	change_face(Galahad1,"Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500032")
	close_speech_window()

	
	change_face(Lancelot1,"Smile")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500033")
	close_speech_window()

	
	change_face(Galahad1,"Sad")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500034")
	close_speech_window()

	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500035")
	close_speech_window()
end
 
 
function MA_01B900_50_end()

	
	wait_time(1.5)

	
	change_face(Galahad1,"Normal")
	open_speech_window("CHRNAME_GALAHAD",Galahad1,nil)
	message("MA_01B900_500037")

	
	
	change_face(Galahad1,"Smile")
	message("MA_01B900_500039")
	close_speech_window()

	
	
	
	move_camera(21,18,1.0)
	wait_time(1.0)
	
	dot_reserve_move_unit_seq(dotLancelot1,22,19)
	dot_reserve_move_unit_seq(dotNoir2,21,19)
	exec_parallel_seq()
	
	wait_time(1.0)
	

	dot_change_anim(dotArthur_D,3)
	wait_time(0.5)

	se_play("SE_ADV_MA_01A900_36_WhiteDrg_Roar")		

	on_active(Ef_Roar01)
	local gridpos=get_grid_position(21,16) 
	set_pos(Ef_Roar01,gridpos)
	play_particle(Ef_Roar01)
	
	wait_time(1.0)

	dot_change_anim(dotArthur_D,0)

	wait_time(1.0)
	
	change_face(Lancelot1,"Smile")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500041")

	
	change_face(Lancelot1,"Smile")
	message("MA_01B900_500042")
	

	

	
	change_face(Lancelot1,"Normal")
	
	message("MA_01B900_500043")

	
	
	
MA_01B900_50_select2()
 
    open_select_window_tag(Noir2,"Normal","MA_01B900_500044","MA_01B900_500045")
    
	close_speech_window()
 
    if is_select(1) then            
        MA_01B900_50_select2_1()
 
    elseif is_select(2) then        
        MA_01B900_50_select2_2()

    end
    MA_01B900_50_2_end()
 
end
 
function MA_01B900_50_select2()
 
end
 
function MA_01B900_50_select2_1()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	wait_time(0.6)
	
end
 
 
function MA_01B900_50_select2_2()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	wait_time(0.3)
	
end
 
function MA_01B900_50_2_end()
	
	
	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  
 
	on_cameraframe(2) 
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("101010270", 0.0, 0.0, 0.0) 
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)
	
	
	
	open_simple_window("NPCNAME_0163")
	message("MA_01B900_500047")
	close_speech_window()
	

fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
  
 
hide_image()
  

off_cameraframe()
off_screencolor()
 
 
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
	
	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500048")
	close_speech_window()

	
	change_face(Lancelot1,"Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500049")
	close_speech_window()

	
	open_narration_window()
	message("MA_01B900_500050")
	close_narration_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500051")

	
	change_face(Noir2,"Normal")
	message("MA_01B900_500052")
	close_speech_window()

	
	change_face(Lancelot1,"Smile")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500053")
	close_speech_window()

	
	open_narration_window()
	message("MA_01B900_500054")
	close_narration_window()

	
	change_face(Lancelot1,"Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500055")

	
	change_face(Lancelot1,"Normal")
	message("MA_01B900_500056")

	
	change_face(Lancelot1,"Normal")
	message("MA_01B900_500057")
	close_speech_window()

	
	open_narration_window()
	message("MA_01B900_500058")
	close_narration_window()

	
	on_active(Ef_VibesAura)
	local gridpos=get_grid_position(22,19) 
	set_pos(Ef_VibesAura,gridpos)
	play_particle(Ef_VibesAura)
	
	
	dot_change_anim(dotLancelot1,12)
	
	
	
	
	on_active(Ef_Cloak_Kira)
	local gridpos=get_grid_position(21,19) 
	set_pos(Ef_Cloak_Kira,gridpos)
	play_particle(Ef_Cloak_Kira)
	
	
	open_narration_window()
	message("MA_01B900_500060")
	close_narration_window()

	
	on_active(Ef_K_GD_L)
	local gridpos=get_grid_position(21,19) 
	set_pos(Ef_K_GD_L,gridpos)
	play_particle(Ef_K_GD_L)
	
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_500062")
	close_speech_window()

	
	
	change_face(Lancelot1,"Serious")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_500064")
	close_speech_window()
	
	stop_particle(Ef_VibesAura)
	
	wait_time(0.5)

	dot_move_unit_seq(dotLancelot1,22,18)
	wait_seq()
	dot_move_unit_seq(dotLancelot1,21,18)
	wait_seq()
	dot_unit_dir(dotLancelot1,3)
	
	local gridpos=get_grid_position(21,18) 
	set_pos(Ef_VibesAura,gridpos)
	play_particle(Ef_VibesAura)
	
	
	
	dot_unit_dir(dotLancelot1,0)
	dot_change_anim(dotLancelot1,3)
	dot_play_particle_unit(dotLancelot1,"Ef_C_Swd_I_Atk01",3,true)
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Selste,"Selste",101060001)
	load_image_preload("101010140","content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101010270", "content_still_10101027_image", "101010270_StillImage")
	pbadv_setup_101010_Lancelot_preload(1,true,22,20,0)
	pbadv_setup_101009_Noir_preload(2,true,21,20,0)
	pbadv_setup_101028_Galahad_preload(1,true,20,30,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_GD_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Cloak_Kira",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
end
