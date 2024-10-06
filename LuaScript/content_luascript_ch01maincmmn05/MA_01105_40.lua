

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201080100", "201080100")
	
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101009_Noir(2,true,11,2,0)
	pbadv_setup_101001_Tyrfing(1,true,11,3,0)
	pbadv_setup_101011_Guinevere(0,true,12,2,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,12,3,0)
	pbadv_setup_101013_Gawain(0,true,13,5,0)
	pbadv_setup_101018_Ragnar(2,true,14,5,0)
	pbadv_setup_101057_Leodgrains(0,true,15,2,0)
	pbadv_setup_101057_Leodgrains(1,true,13,2,0)
	
	
	
	
	setup_complete_unit()
	
	
	dot_disp_unit(dotGawain,false)
	dot_disp_unit(dotRagnar2,false)
	dot_disp_unit(dotLeodgrains,false)
	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotTyrfing1,false)
	dot_disp_weapon(dotGuinevere,false)
	dot_disp_weapon(dotGwenhwymawr1,false)
	dot_disp_weapon(dotGawain,false)
	dot_disp_weapon(dotRagnar2,false)
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(12,2, 0.0)
	
	
	dot_unit_dir(dotLeodgrains, DotDir_Left)
	dot_unit_dir(dotLeodgrains1, DotDir_Left)
	
	
	Ef_EnemyDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)

	load_sound("BGM_Area_Acoustic")

end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	




	
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400002")
	close_speech_window()
	
	
	on_active(Ef_Fog) 

	    on_active(Ef_Fog) 

        local gridpos = get_grid_position(13, 2)
        set_pos(Ef_Fog, gridpos)
        play_particle(Ef_Fog)
	
	
	
	change_face(Leodgrains,"Smile")
	open_speech_window("CHRNAME_LEODEGRAINS", Leodgrains, nil)
	message("MA_01105_400004")
	close_speech_window()

	
	change_face(Gwenhwymawr1,"Smile")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1, nil)
	message("MA_01105_400005")
	close_speech_window()

	
	open_speech_window("CHRNAME_LEODEGRAINS", Leodgrains, nil)
	message("MA_01105_400006")
	close_speech_window()

	
	change_face(Guinevere,"Smile")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400007")
	close_speech_window()

	
	open_speech_window("CHRNAME_LEODEGRAINS", Leodgrains, nil)
	message("MA_01105_400008")
	close_speech_window()
	
	
	 

        on_active(Ef_EnemyDie) 

        local gridpos = get_grid_position(13, 2)
        set_pos(Ef_EnemyDie, gridpos)
        play_particle(Ef_EnemyDie)
        
        wait_time(0.5)
        
        dot_disp_unit(dotLeodgrains1, false)

        stop_particle(Ef_Fog)

        wait_time(3.2)
	
	
	dot_move_unit_seq(dotGuinevere, 12, 0, 0.5)
	move_camera(12,0, 1.0)
	wait_seq()
	wait_camera()
	wait_time(2.0)
	
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400010")
	close_speech_window()
	wait_seq()
	
	
	dot_unit_dir(dotGuinevere, DotDir_Up)
	dot_change_anim(dotGuinevere,DotAnim_Squat)
	
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400012")

	
	change_face(Guinevere,"Pain")
	message("MA_01105_400013")
	close_speech_window()
	

	dot_move_unit_seq(dotGwenhwymawr1, 13, 3)
	wait_seq()
	dot_move_unit_seq(dotGwenhwymawr1, 13, 0)
	wait_seq()
	dot_unit_dir(dotGwenhwymawr1, DotDir_Left)
	
	wait_time(1.0)

	
	change_face(Gwenhwymawr1,"Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01105_400014")
	close_speech_window()

	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400015")

	
	change_face(Guinevere,"Pain")
	message("MA_01105_400016")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	
	dot_reserve_move_unit_seq(dotNoir2, 11, 0)
	dot_reserve_move_unit_seq(dotTyrfing1,11,1)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotNoir2, DotDir_Right)

	
	bgm_play("BGM_Area_Acoustic")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400018")

	
	change_face(Noir2,"Normal")
	message("MA_01105_400019")

	
	change_face(Noir2,"Sad")
	message("MA_01105_400020")
	close_speech_window()
	
	
	
	
	dot_unit_dir(dotGuinevere, DotDir_Left)
	
	wait_time(2.0)
	
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400022")
	
	
	dot_change_anim(dotGuinevere,DotAnim_Idle)
	
	
	change_face(Guinevere,"Smile")
	message("MA_01105_400023")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400024")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400025")

	
	change_face(Guinevere,"Normal")
	message("MA_01105_400026")
	close_speech_window()

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400027")
	close_speech_window()
	
	dot_unit_dir(dotGuinevere, DotDir_Right)
	dot_unit_dir(dotGwenhwymawr1, DotDir_Right)

	
	dot_disp_unit(dotGawain,true)
	dot_disp_unit(dotRagnar2,true)
	wait_seq()
	
	
	move_camera(12,2, 1.0)
	dot_reserve_move_unit_seq(dotRagnar2,14,3)
	dot_reserve_move_unit_seq(dotGawain,13,3)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotRagnar2, DotDir_Left)
	dot_unit_dir(dotGawain, DotDir_Left)
	wait_camera()
	
	
	change_face(Gawain,"Smile")
	open_speech_window("CHRNAME_GAWAIN",Gawain, nil)
	message("MA_01105_400029")
	
	wait_seq()
	
	
	message("MA_01105_400030")
	close_speech_window()

	
	change_face(Gwenhwymawr1,"Surprise")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01105_400031")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400032")
	close_speech_window()

	
	change_face(Gawain,"Normal")
	open_speech_window("CHRNAME_GAWAIN",Gawain, nil)
	message("MA_01105_400033")
	close_speech_window()

	
	change_face(Ragnar2,"Smile")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2 , nil)
	message("MA_01105_400034")
	close_speech_window()
	
	
	move_camera(12,0, 1.0)
	dot_move_unit_seq(dotRagnar2,14,5)
	dot_move_unit_seq(dotGawain,13,5)
	exec_parallel_seq()
	
	wait_seq()
	
	
	dot_disp_unit(dotGawain,false)
	dot_disp_unit(dotRagnar2,false)
	
	wait_time(1.5)

	dot_unit_dir(dotGuinevere, DotDir_Left)
	
	
	change_face(Guinevere,"Shy")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400036")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400037")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400038")
	close_speech_window()

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400039")
	close_speech_window()

	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400040")
	close_speech_window()

	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400041")
	close_speech_window()

	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400043")
	close_speech_window()

	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400044")
	close_speech_window()

	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400045")
	
	
	change_face(Guinevere,"Smile")
	message("MA_01105_400046")
	close_speech_window()

	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_400047")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_400048")
	close_speech_window()



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,11,2,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,11,3,0)
	pbadv_setup_101011_Guinevere_preload(0,true,12,2,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,12,3,0)
	pbadv_setup_101013_Gawain_preload(0,true,13,5,0)
	pbadv_setup_101018_Ragnar_preload(2,true,14,5,0)
	pbadv_setup_101057_Leodgrains_preload(0,true,15,2,0)
	pbadv_setup_101057_Leodgrains_preload(1,true,13,2,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemyhuman", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	preload_sound("BGM_Area_Acoustic")
end
