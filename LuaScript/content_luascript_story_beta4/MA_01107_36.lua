Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201020000","201020000")
	change_time_and_weather(1,2)
	
	
	
	pbadv_setup_101028_Galahad(2,true,20,22,0)

	pbadv_setup_101029_Astera(1,true,21,22,0)
	
	pbadv_setup_101010_Lancelot(3,true,20,20,0)

	pbadv_setup_101009_Noir(2,true,21,20,0)
	
	pbadv_setup_101001_Tyrfing(1,true,21,21,0)
	
	pbadv_setup_101011_Guinevere(0,true,20,21,0)
	
	pbadv_setup_101012_Dinatan(0,true,22,21,0)   
	
	pbadv_setup_101021_Bruno(3,true,18,18,0)  
	
	pbadv_setup_101058_Laiens(0,true,20,17,0)  
	
    dotbaroi21 = dot_reserve_enemy(42,21,15,0)
	dotbaroi22 = dot_reserve_enemy(42,22,15,0)
	dotbaroi23 = dot_reserve_enemy(42,19,15,0)
	dotbaroi24 = dot_reserve_enemy(42,20,15,0)
	dotbaroi25 = dot_reserve_enemy(42,21,14,0)
	dotbaroi26 = dot_reserve_enemy(42,22,14,0)
	dotbaroi27 = dot_reserve_enemy(42,19,14,0)
    dotbaroi28 = dot_reserve_enemy(42,20,14,0)
    
	dotbaroi30 = dot_reserve_ally(401038001,24,10,0)
	dot_set_weapon(dotbaroi30,101010001)
	dotbaroi31 = dot_reserve_ally(401038001,25,10,0)
	dot_set_weapon(dotbaroi31,101010001)
	dotbaroi32 = dot_reserve_ally(401038001,25,11,0)
	dot_set_weapon(dotbaroi32,101010001)
	dotbaroi33 = dot_reserve_ally(401038001,26,11,0)
	dot_set_weapon(dotbaroi33,105010001)
	dotbaroi34 = dot_reserve_ally(401038001,26,12,0)
	dot_set_weapon(dotbaroi34,105010001)
	dotbaroi35 = dot_reserve_ally(401038001,26,13,0)
	dot_set_weapon(dotbaroi35,105010001)
	dotbaroi36 = dot_reserve_ally(401038001,27,13,0)
	dot_set_weapon(dotbaroi36,105010001)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotGuinevere,2)
	dot_unit_dir(dotLancelot3,2)
	dot_unit_dir(dotDinatan,2)
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotAstera1,2)
	dot_unit_dir(dotGalahad2,2)
	dot_unit_dir(dotTyrfing1,2)
	dot_unit_dir(dotGuinevere,2)
	dot_unit_dir(dotbaroi21,3)
	dot_unit_dir(dotbaroi22,3)
	dot_unit_dir(dotbaroi23,3)
	dot_unit_dir(dotbaroi24,3)
	dot_unit_dir(dotbaroi25,3)
	dot_unit_dir(dotbaroi26,3)
	dot_unit_dir(dotbaroi27,3)
	dot_unit_dir(dotbaroi28,3)
	dot_unit_dir(dotbaroi30,2)
	dot_unit_dir(dotbaroi31,2)
	dot_unit_dir(dotbaroi32,2)
	dot_unit_dir(dotbaroi33,2)
	dot_unit_dir(dotbaroi34,2)
	dot_unit_dir(dotbaroi35,2)
	dot_unit_dir(dotbaroi36,2)

	
	

	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(28.0,0.0)

	
	
	move_camera(20,19,0.0)

	Ef_Portal_E=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 

end





function Play()
	fadein(0)
	Play_start(true)





	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_360002")
	close_speech_window()


	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_360003")
	close_speech_window()


	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_360004")
	close_speech_window()
	

	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_360005")
	close_speech_window()


	change_face(Laiens,"Smile")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
	message("MA_01107_360006")
	close_speech_window()


	on_active(Ef_Portal_E)
	
	local gridpos=get_grid_position(20,17) 
	set_pos(Ef_Portal_E,gridpos)
	set_scale(Ef_Portal_E,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E)
	
	wait_time(0.5)
	
	dot_disp_unit(dotLaiens,false)



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_360008")
	close_speech_window()


	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_360009")
	close_speech_window()

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101028_Galahad_preload(2,true,20,22,0)
	pbadv_setup_101029_Astera_preload(1,true,21,22,0)
	pbadv_setup_101010_Lancelot_preload(3,true,20,20,0)
	pbadv_setup_101009_Noir_preload(2,true,21,20,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,21,21,0)
	pbadv_setup_101011_Guinevere_preload(0,true,20,21,0)
	pbadv_setup_101012_Dinatan_preload(0,true,22,21,0)
	pbadv_setup_101021_Bruno_preload(3,true,18,18,0)
	pbadv_setup_101058_Laiens_preload(0,true,20,17,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
end
