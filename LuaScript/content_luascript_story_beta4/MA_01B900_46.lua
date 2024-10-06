Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201180001","201180001")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)
	
	pbadv_setup_101010_Lancelot(1,true,22,19,0)
	
	pbadv_setup_101009_Noir(2,true,21,19,0)
	
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
	dot_unit_dir(dotArthur_D,1)

	
	
	
	
	
	

	
	
	dot_disp_unit(dotArthur_D,false)
	dot_disp_unit(dotNoir2,false)
	dot_disp_unit(dotLancelot1,false)
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi6,false)
	dot_disp_unit(barbaroi7,false)
	dot_disp_unit(barbaroi8,false)
	dot_disp_unit(barbaroi9,false)
	dot_disp_unit(barbaroi10,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(21,19,0.0)
	
	Ef_Roar01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true) 
	
	Ef_PortalE1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_PortalE10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_Warp_OUT1=load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true) 
	Ef_Warp_OUT2=load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true) 
	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	
	Ef_WhiteDragon_A=load_particle("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Appearance",false,true)
	Ef_WhiteDragon_Flash=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	Ef_DimensionHole=load_particle("content_effect3d_common_adv","Ef_C_Adv_DimensionHole",false,true)
	
	movie_load("MA_01B900_46")
	
end





function Play()
	fadein(0)
	Play_start(true)



	
	
	on_active(Ef_Warp_OUT1)
	local gridpos=get_grid_position(21,19) 
	set_pos(Ef_Warp_OUT1,gridpos)
	play_particle(Ef_Warp_OUT1)
	
	on_active(Ef_Warp_OUT2)
	local gridpos=get_grid_position(22,19) 
	set_pos(Ef_Warp_OUT2,gridpos)
	play_particle(Ef_Warp_OUT2)
	
	wait_time(0.3)
	
	dot_disp_unit(dotNoir2,true)
	
	dot_disp_unit(dotLancelot1,true)
	dot_unit_dir(dotLancelot1,2)
	wait_time(1.0)
	dot_unit_dir(dotNoir2,2)
	wait_time(0.3)
	
	
	
	change_face(Lancelot1,"Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_460002")
	close_speech_window()

	dot_unit_dir(dotNoir2,3)
	wait_time(0.3)
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_460004")
	close_speech_window()

	dot_unit_dir(dotLancelot1,2)
	
	change_face(Lancelot1,"Sad")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_460005")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_460006")
	close_speech_window()

	close_textbox_base()
	disableTextBox = true
	
	move_camera(21,16,0.5)
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotLancelot1,3)
	
	off_active(Ef_Warp_OUT1)
	off_active(Ef_Warp_OUT2)
	
	on_active(Ef_DimensionHole)
	local gridpos=get_grid_position(21,17)
	gridpos[2]=3.0
	set_pos(Ef_DimensionHole,gridpos)
	set_scale(Ef_DimensionHole,{1.5,1.5,1.5})
	play_particle(Ef_DimensionHole)

	wait_time(1.5)

	on_active(Ef_WhiteDragon_A)
	local gridpos=get_grid_position(21,17)
	gridpos[2]=3.0
	set_pos(Ef_WhiteDragon_A,gridpos)
	play_particle(Ef_WhiteDragon_A)	
	
	wait_time(1.5)
	
	on_active(Ef_WhiteDragon_Flash)
	local gridpos=get_grid_position(21,17)
	gridpos[2]=3.0
	set_pos(Ef_WhiteDragon_Flash,gridpos)
	play_particle(Ef_WhiteDragon_Flash)	
	
	wait_time(0.2)
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)

	wait_time(BLACK_WHITE_WAIT_TIME)
	
	movie_set_active(true)
	
	fadein(0)
	Play_start(true)
	
	movie_play()
	hide_image(STILL_SWITCH_TIME) 
	
	movie_wait_playing()
	movie_stop()
	
	dot_disp_unit(dotArthur_D, true)
	
	stop_particle(Ef_DimensionHole)
	stop_particle(Ef_WhiteDragon_A)
	stop_particle(Ef_WhiteDragon_Flash)
	
	dot_disp_unit(dotArthur_D,true)
	dot_unit_dir(dotArthur_D,2)
	
	wait_time(MOVIE_AFTER)
	
	dot_change_anim(dotArthur_D,3)
	
	
	wait_time(0.2)
	
	on_active(Ef_Roar01)
	local gridpos=get_grid_position(21,16)
	set_pos(Ef_Roar01,gridpos)
	play_particle(Ef_Roar01)
	
	se_play("SE_ADV_MA_01A900_36_WhiteDrg_Roar")
	
	wait_time(0.3)
	
	on_active(Ef_PortalE1)
	local gridpos=get_grid_position(19,17)
	set_pos(Ef_PortalE1,gridpos)
	set_scale(Ef_PortalE1,{0.8,0.8,0.8})
	play_particle(Ef_PortalE1)
	
	on_active(Ef_PortalE2)
	local gridpos=get_grid_position(23,17)
	set_pos(Ef_PortalE2,gridpos)
	set_scale(Ef_PortalE2,{0.8,0.8,0.8})
	play_particle(Ef_PortalE2)
	
	on_active(Ef_PortalE3)
	local gridpos=get_grid_position(23,16)
	set_pos(Ef_PortalE3,gridpos)
	set_scale(Ef_PortalE3,{0.8,0.8,0.8})
	play_particle(Ef_PortalE3)
	
	on_active(Ef_PortalE4)
	local gridpos=get_grid_position(19,16)
	set_pos(Ef_PortalE4,gridpos)
	set_scale(Ef_PortalE4,{0.8,0.8,0.8})
	play_particle(Ef_PortalE4)
	
	on_active(Ef_PortalE5)
	local gridpos=get_grid_position(24,11)
	set_pos(Ef_PortalE5,gridpos)
	set_scale(Ef_PortalE5,{0.8,0.8,0.8})
	play_particle(Ef_PortalE5)
	
	on_active(Ef_PortalE6)
	local gridpos=get_grid_position(18,11)
	set_pos(Ef_PortalE6,gridpos)
	set_scale(Ef_PortalE6,{0.8,0.8,0.8})
	play_particle(Ef_PortalE6)
	
	on_active(Ef_PortalE7)
	local gridpos=get_grid_position(19,12)
	set_pos(Ef_PortalE7,gridpos)
	set_scale(Ef_PortalE7,{0.8,0.8,0.8})
	play_particle(Ef_PortalE7)
	
	on_active(Ef_PortalE8)
	local gridpos=get_grid_position(20,11)
	set_pos(Ef_PortalE8,gridpos)
	set_scale(Ef_PortalE8,{0.8,0.8,0.8})
	play_particle(Ef_PortalE8)
	
	on_active(Ef_PortalE9)
	local gridpos=get_grid_position(22,11)
	set_pos(Ef_PortalE9,gridpos)
	set_scale(Ef_PortalE9,{0.8,0.8,0.8})
	play_particle(Ef_PortalE9)
	
	on_active(Ef_PortalE10)
	local gridpos=get_grid_position(23,12)
	set_pos(Ef_PortalE10,gridpos)
	set_scale(Ef_PortalE10,{0.8,0.8,0.8})
	play_particle(Ef_PortalE10)
	
	wait_time(0.2)
	
	dot_disp_unit(barbaroi1,true)
	dot_disp_unit(barbaroi2,true)
	dot_disp_unit(barbaroi3,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)
	dot_disp_unit(barbaroi9,true)
	dot_disp_unit(barbaroi10,true)
	
	wait_time(1.0)
	dot_unit_dir(dotArthur_D,2)
	dot_change_anim(dotArthur_D,0)
	
	move_camera(21,17,2.0)
	disableTextBox = false
	open_textbox_base()
	
	change_face(Lancelot1,"Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_460008")
	
	
	
	change_face(Lancelot1,"Normal")
	message("MA_01B900_460009")
	
	
	
	change_face(Lancelot1,"Sad")
	message("MA_01B900_460011")
	close_speech_window()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01B900_460013")
	close_speech_window()
	
	
	change_face(Lancelot1,"Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot1,nil)
	message("MA_01B900_460014")
	
	
	
	change_face(Lancelot1,"Normal")
	message("MA_01B900_460015")
	close_speech_window()
	
	wait_time(1.0)
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101010_Lancelot_preload(1,true,22,19,0)
	pbadv_setup_101009_Noir_preload(2,true,21,19,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Appearance",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_DimensionHole",false,true)
	movie_load_preload("MA_01B900_46")
end
