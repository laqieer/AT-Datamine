

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201140000","201140000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)


    pbadv_setup_101009_Noir(2,true,21,24,0)    
    
	pbadv_setup_101012_Dinatan(0,true,20,24,0)  
	
	pbadv_setup_101032_Gareth(0,true,21,21,0) 
	
	pbadv_setup_101033_Lyoness(1,true,22,21,0) 
	
	pbadv_setup_101014_Tristan(0,true,22,22,0)  
	
	pbadv_setup_101019_Isolde(1,true,22,23,0)  
	
	pbadv_setup_101051_Lucius(0,true,22,25,0)  
	
	pbadv_setup_101022_Mordred(0,true,21,25,0)  
	
	pbadv_setup_101023_Clarice(0,true,20,25,0) 
	
	
	pbadv_setup_101013_Gawain(1,true,21,22,0)  
	
    barbaroi1=dot_reserve_enemy(1,20,17,0)
	barbaroi2=dot_reserve_enemy(1,20,18,0)
	
	barbaroi4=dot_reserve_enemy(1,21,17,0)
	barbaroi5=dot_reserve_enemy(1,21,18,0)
	
	barbaroi7=dot_reserve_enemy(1,22,17,0)
	barbaroi8=dot_reserve_enemy(1,22,18,0)
	
	
	
	setup_complete_unit()
	
	dot_change_anim(dotGawain1,1)
	dot_change_anim(dotGareth,1)
	
	
	dot_unit_dir(dotGawain1, 2)
	dot_unit_dir(dotTristan, 2)
	dot_unit_dir(dotLyoness1, 2)
	dot_unit_dir(dotIsolde1, 2)
	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotDinatan,false)
	dot_disp_weapon(dotTristan,false)
	dot_disp_weapon(dotIsolde1,false)
	dot_disp_weapon(dotGareth,false)
	dot_disp_weapon(dotLyoness1,false)
	dot_disp_weapon(dotLucius,false)
	
	
	
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi7,false)
	dot_disp_unit(barbaroi8,false)
	
	
	
	change_camera_distance(8.0,0.0)
	
	
	change_camera_angle(45.0,0.0)
	
	
	move_camera(21,25,0.0)
	
	
	Ef_Portal_E1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_Portal_E2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_Portal_E4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_Portal_E5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_Portal_E7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true) 
	Ef_Portal_E8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true) 
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	change_face(Mordred,"Serious")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_170002")

	
	message("MA_01C900_170003")
	close_speech_window()

	
	change_face(Noir2,"Sad")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_170004")
	close_speech_window()

	
	change_face(Clarice,"Normal")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	message("MA_01C900_170005")
	close_speech_window()

	
	change_face(Mordred,"Pain")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_170006")
	close_speech_window()

	
	change_face(Clarice,"Sad")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	message("MA_01C900_170007")
	close_speech_window()

	
	dot_move_unit_seq(dotMordred,21,31)
	wait_time(0.2)
	dot_move_unit_seq(dotClarice,22,31)
	wait_seq()
	
	dot_remove_unit(dotClarice)
	dot_remove_unit(dotMordred)
	
	
	wait_time(3.0)
	move_camera(21,23, 0.5)

	dot_move_unit_seq(dotNoir2,21,23)
	wait_seq()

	dot_move_unit_seq(dotNoir2,20,23)
	wait_seq()

	dot_move_unit_seq(dotNoir2,20,21)
	wait_seq()
	
	dot_unit_dir(dotNoir2, 3)
	
	
	wait_time(2.0)

    dot_place_unit(barbaroi1,20,26)
    dot_place_unit(barbaroi4,21,26)
    dot_place_unit(barbaroi7,22,26)
    
	
	change_face(Gareth,"Normal")	
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C900_170009")

	
	change_face(Gareth,"Anger")	
	message("MA_01C900_170010")

	
	change_face(Gareth,"Smile")	
	message("MA_01C900_170011")
	
	wait_time(1.0)

	
	change_face(Gareth,"Sad")	
	message("MA_01C900_170012")
	close_speech_window()

	
	change_face(Noir2,"Sad")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_170013")
	close_speech_window()

	
	change_face(Gareth,"Pain")	
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C900_170014")
	close_speech_window()

	

	change_camera_angle(25.0,2.0)
	
	dot_move_unit_seq(dotIsolde1,21,24)
	wait_seq()
	wait_camera()
	
	
	change_face(Isolde1,"Sad")	
	open_speech_window("CHRNAME_ISOLDE2",Isolde1,nil)
	message("MA_01C900_170016")

	
	message("MA_01C900_170017")
	close_speech_window()

	
	change_face(Dinatan,"Sad")	
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_170018")
	close_speech_window()

	
	change_face(Isolde1,"Normal")	
	open_speech_window("CHRNAME_ISOLDE2",Isolde1,nil)
	message("MA_01C900_170019")

	
	
	change_face(Isolde1,"Anger")	
	message("MA_01C900_170021")

	
	change_face(Isolde1,"Normal")	
	message("MA_01C900_170023")
	close_speech_window()

	
	change_face(Dinatan,"Normal")	
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_170024")
	close_speech_window()

	
	change_face(Tristan,"Sad")	
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01C900_170025")

	
	change_face(Noir2,"Normal")	
	message("MA_01C900_170027")

	
	change_face(Tristan,"Pain")	
	message("MA_01C900_170028")
	close_speech_window()

	
	change_face(Noir2,"Normal")	
	open_speech_window("CHRNAME_NOIR",Noir2, nil)
	message("MA_01C900_170029")

	
	change_face(Noir2,"Sad")	
	message("MA_01C900_170030")

	
	change_face(Noir2,"Normal")	
	message("MA_01C900_170031")
	close_speech_window()

	
	change_face(Tristan,"Normal")	
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01C900_170032")
	close_speech_window()

	
	change_face(Noir2,"Sad")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_170033")

	
	change_face(Noir2,"Normal")	
	message("MA_01C900_170034")

	
	message("MA_01C900_170035")
	close_speech_window()

	
	change_face(Tristan,"Sad")	
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01C900_170036")
	close_speech_window()

	
	
	change_face(Lucius,"Surprise")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_170038")
	close_speech_window()

	wait_time(1.5)
	
	
	on_active(Ef_Portal_E1)
	on_active(Ef_Portal_E2)
	on_active(Ef_Portal_E4)
	on_active(Ef_Portal_E5)
	on_active(Ef_Portal_E7)
	on_active(Ef_Portal_E8)
	
	local gridpos=get_grid_position(20,26) 
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	
	local gridpos=get_grid_position(20,18) 
	set_pos(Ef_Portal_E2,gridpos)
	set_scale(Ef_Portal_E2,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E2)


	local gridpos=get_grid_position(21,26) 
	set_pos(Ef_Portal_E4,gridpos)
	set_scale(Ef_Portal_E4,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E4)
	
	local gridpos=get_grid_position(21,18) 
	set_pos(Ef_Portal_E5,gridpos)
	set_scale(Ef_Portal_E5,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E5)


	local gridpos=get_grid_position(22,26) 
	set_pos(Ef_Portal_E7,gridpos)
	set_scale(Ef_Portal_E7,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E7)
	
	local gridpos=get_grid_position(22,18) 
	set_pos(Ef_Portal_E8,gridpos)
	set_scale(Ef_Portal_E8,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E8)

	wait_time(0.2)
	
	dot_disp_unit(barbaroi1,true)
	dot_disp_unit(barbaroi2,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)
	
	
	
	wait_time(2.0)

	dot_reserve_move_unit_seq(barbaroi2, 20, 19)
	dot_reserve_move_unit_seq(barbaroi5, 21, 19)
	dot_reserve_move_unit_seq(barbaroi8, 22, 19)
	
	
	exec_parallel_seq()

	
	wait_seq()
	
	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_170040")
	close_speech_window()

	dot_move_unit_seq(dotTristan, 22, 23)
	wait_seq()

	dot_unit_dir(dotTristan, 2)
	
	change_face(Tristan,"Normal")	
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01C900_170041")
	close_speech_window()

	
	change_face(Isolde1,"Normal")	
	open_speech_window("CHRNAME_ISOLDE2",Isolde1,nil)
	message("MA_01C900_170042")
	close_speech_window()

	
	change_face(Lyoness1,"Sad")	
	open_speech_window("CHRNAME_LYONESS2",Lyoness1,nil)
	message("MA_01C900_170043")
	close_speech_window()

	
	dot_change_anim(dotGareth,0)
	wait_time(0.5)
	
	
	
	change_face(Gareth,"Anger")	
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C900_170045")
	close_speech_window()

	
	dot_disp_weapon(dotTristan,true)
	dot_disp_weapon(dotIsolde1,true)
	dot_disp_weapon(dotGareth,true)
	dot_disp_weapon(dotLyoness1,true)
	
	
	change_face(Isolde1,"Anger")	
	open_speech_window("CHRNAME_ISOLDE2",Isolde1,nil)
	message("MA_01C900_170047")
	close_speech_window()
	
	
	
	change_face(Tristan,"Pain")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01C900_170049")
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,21,24,0)
	pbadv_setup_101012_Dinatan_preload(0,true,20,24,0)
	pbadv_setup_101032_Gareth_preload(0,true,21,21,0)
	pbadv_setup_101033_Lyoness_preload(1,true,22,21,0)
	pbadv_setup_101014_Tristan_preload(0,true,22,22,0)
	pbadv_setup_101019_Isolde_preload(1,true,22,23,0)
	pbadv_setup_101051_Lucius_preload(0,true,22,25,0)
	pbadv_setup_101022_Mordred_preload(0,true,21,25,0)
	pbadv_setup_101023_Clarice_preload(0,true,20,25,0)
	pbadv_setup_101013_Gawain_preload(1,true,21,22,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy", false, true)
end
