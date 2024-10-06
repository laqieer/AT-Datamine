Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201030001","201030001")	
	change_time_and_weather(1,1)
	


	pbadv_setup_101009_Noir(2,true,36,41,0)
	
	pbadv_setup_101010_Lancelot(3,true,37,41,0)
	
	dotbaroi1=dot_reserve_enemy(506,36,28,0)
	dotbaroi2=dot_reserve_enemy(42,35,32,0)
	dotbaroi3=dot_reserve_enemy(49,39,26,0)
	dotbaroi4=dot_reserve_enemy(49,34,26,0)
	dotbaroi5=dot_reserve_enemy(506,38,27,0)
	dotbaroi6=dot_reserve_enemy(1,38,30,0)
	dotbaroi7=dot_reserve_enemy(1,36,32,0)
	dotbaroi8=dot_reserve_enemy(1,37,32,0)
	
	
	
	setup_complete_unit()
	
	

	change_camera_distance(8.0,0.0)
	change_camera_angle(25.0,0.0)
	move_camera(36,35,0.0)

	load_sound("BGM_Battle_Running_FI")
	
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	dot_reserve_move_unit_seq(dotNoir2,36,36)
	dot_reserve_move_unit_seq(dotLancelot3,37,36)
	exec_parallel_seq()
	wait_seq()
	
	
	wait_time(0.2)	
		
	dot_unit_dir(dotLancelot3,2)

	wait_time(0.2)	

	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","悩む")
	message("CO_101010_06020002")
	close_speech_window()
	
	
	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	PlayPartVoice("ランスロット","肯定")
	message("CO_101010_06020003")
	close_speech_window()
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","肯定3")
	message("CO_101010_06020004")
	close_speech_window()
	
	bgm_play("BGM_Battle_Running_FI")
	
	
	open_speech_window("NPCNAME_0286",nil,nil)
	message("CO_101010_06020006")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotbaroi7,36,35)
	dot_reserve_move_unit_seq(dotbaroi8,37,35)
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotLancelot3,0)
	dot_unit_dir(dotNoir2,0)
	
	dot_change_anim(dotLancelot3,3)
	dot_play_particle_unit(dotLancelot3,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotbaroi7,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotbaroi8,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_change_anim(dotbaroi7,6)
	dot_change_anim(dotbaroi8,6)

	wait_time(0.2)

	dot_play_particle_unit(dotbaroi7,"Ef_C_Cmn_DieEmy01",3,true)
	dot_play_particle_unit(dotbaroi8,"Ef_C_Cmn_DieEmy01",3,true)
        
	wait_time(0.5)

	dot_disp_unit(dotbaroi7,false)
	dot_disp_unit(dotbaroi8,false)

	dot_remove_unit(dotbaroi7) 
	dot_remove_unit(dotbaroi8) 

	wait_time(0.5)
	
	dot_change_anim(dotLancelot3,0)
	dot_change_anim(dotNoir2,0)
	
	
	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	PlayPartVoice("ランスロット","落胆")
	message("CO_101010_06020008")
	close_speech_window()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("CO_101010_06020009")
	close_speech_window()
	
	
	
	change_face(Lancelot3,"Smile")
	PlayPartVoice("ランスロット","笑い")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("CO_101010_06020011")
	
	
	
	change_face(Lancelot3,"Normal")
	message("CO_101010_06020013")
	close_speech_window()
	
	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","笑い")
	message("CO_101010_06020014")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dotNoir2,36,32)
	dot_reserve_move_unit_seq(dotLancelot3,37,32)
	exec_parallel_seq()
	
	fadeout(0,0,0,0,1.0)
	reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ6_3")
	



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,36,41,0)
	pbadv_setup_101010_Lancelot_preload(3,true,37,41,0)
	preload_sound("BGM_Battle_Running_FI")
end
