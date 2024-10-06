Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201000000", "201000000")
	
	
	pbadv_setup_101009_Noir(2,true, 3, 23,0)  
	pbadv_setup_101015_Arthur(0,true, 4, 23,0)  

	dotromaa = dot_reserve_ally(401040001, 17, 23, 0) 
	dot_set_weapon(dotromaa, 102020001)

	dotromab = dot_reserve_ally(401040001, 18, 24, 0) 
	dot_set_weapon(dotromab, 102020001)
	
	dotromac = dot_reserve_ally(401040001, 18, 22, 0)  
	dot_set_weapon(dotromac, 102020001)

	dotmob = dot_reserve_ally(401005001, 19, 28, 0)  
	dot_set_weapon(dotmob, 102020001)

	setup_101013_Gawain(nil, nil, 0, false) 
	
	
	
	

	barbaroi1 = dot_reserve_enemy(1300, 10, 21, 0) 
	barbaroi2 = dot_reserve_enemy(1300, 11, 23, 0) 
	barbaroi3 = dot_reserve_enemy(1300, 13, 21, 0) 
	barbaroi4 = dot_reserve_enemy(1300, 13, 24, 0) 
	barbaroi5 = dot_reserve_enemy(1300, 14, 19, 0) 
	barbaroi6 = dot_reserve_enemy(1300, 16, 20, 0) 
	barbaroi7 = dot_reserve_enemy(1300, 20, 21, 0) 

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	

	
	dot_unit_dir(dotromac,2)
	dot_unit_dir(dotromab,2)

	dot_unit_dir(barbaroi1,3)
	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi5,3)

	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotArthur, false)
	dot_disp_weapon(dotmob, false)
	dot_disp_weapon(dotromaa, false)
	dot_disp_weapon(dotromab, false)
	dot_disp_weapon(dotromac, false)


	
	
	dot_disp_unit(dotmob, false)
		
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(16, 23, 0.0)

	
	

	load_sound("BGM_ADV_Antagonism")


end

function NoirMoveSet() 
	local signal1 = dot_move_unit(dotNoir2, 9, 21)
	wait_proccess(signal1)
	dot_unit_dir(barbaroi1,2)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotNoir2,0)
	dot_change_anim(barbaroi1,6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(barbaroi1, false)
end

function ArthurMoveSet() 
	local signal3 = dot_move_unit(dotArthur, 10, 23)
	wait_proccess(signal3)
	dot_change_anim(dotArthur,3)
	dot_play_particle_unit(dotArthur,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotArthur,0)
	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(barbaroi2, false)
end

function NoirMoveSet2() 
	local signal2 = dot_move_unit(dotNoir2, 12, 21)
	wait_proccess(signal2)
	local signal5 = dot_move_unit(barbaroi5, 13, 20)
	wait_proccess(signal5)
	local signal6 = dot_move_unit(barbaroi6, 14, 21)
	wait_proccess(signal6)
	dot_unit_dir(barbaroi3,2)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotNoir2,0)
	dot_change_anim(barbaroi3,6)
	dot_change_anim(barbaroi5,6)
	dot_change_anim(barbaroi6,6)

	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi6, false)
end

function ArthurMoveSet2() 
	local signal4 = dot_move_unit(dotArthur, 12, 24)
	wait_proccess(signal4)
	local signal7 = dot_move_unit(barbaroi7, 13, 23)
	wait_proccess(signal7)
	dot_change_anim(dotArthur,3)
	dot_play_particle_unit(dotArthur,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotArthur,0)
	dot_change_anim(barbaroi4,6)
	dot_change_anim(barbaroi7,6)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi7, false)
end




function Play()
	fadein(0)
	Play_start(true)


	

	
	
	wait_time(1.0)
	
	move_camera(4, 23, 2.5)
	wait_camera()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","悩む")
	message("CO_101015_09020002")


	
	
	

    CO_101015_0902_select1()
 
    open_select_window_tag(Noir2, "Normal", "CO_101015_09020004", "CO_101015_09020005", "CO_101015_09020006")  
 	close_speech_window()



    if is_select(1) then            
        CO_101015_0902_select1_1()
 
    elseif is_select(2) then        
        CO_101015_0902_select1_2()
 
    elseif is_select(3) then        
        CO_101015_0902_select1_3()
 
    end
    CO_101015_0902_end()
 
end
 
function CO_101015_0902_select1()
 
end
 
function CO_101015_0902_select1_1()
 

 	

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","悩む")
	message("CO_101015_09020008")
	close_speech_window()

	dot_unit_dir(dotArthur,2)

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	
	message("CO_101015_09020009")
	

	
 	change_face(Arthur, "Anger")
	
	message("CO_101015_09020010")
	close_speech_window()

      
end
 
 
function CO_101015_0902_select1_2()
 

 	

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","悩む")
	message("CO_101015_09020012")
	close_speech_window()

	dot_unit_dir(dotArthur,2)

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","肯定2")
	message("CO_101015_09020013")
	

	
	change_face(Arthur, "Anger")
	
	message("CO_101015_09020014")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","肯定2")
	message("CO_101015_09020015")
	close_speech_window()
 
    
end
 
 
function CO_101015_0902_select1_3()
 

     

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","肯定")
	message("CO_101015_09020017")
	close_speech_window()

	
	
	move_camera(16, 23, 1.2)
	wait_camera()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士3","落胆")
	message("CO_101015_09020019")
	close_speech_window()

	
	open_speech_window("NPCNAME_0222", nil, nil)
	PlayPartVoice("兵士1","肯定2")
	message("CO_101015_09020020")
	close_speech_window()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","笑い")
	message("CO_101015_09020021")
	close_speech_window()

	
	move_camera(4, 23, 1.2)
	wait_camera()

	dot_unit_dir(dotArthur,2)

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","笑い")
	message("CO_101015_09020023")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","笑い")
	message("CO_101015_09020024")
	close_speech_window()

	
	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","肯定2")
	message("CO_101015_09020026")
	close_speech_window()
 
 
        
end
 
 
function CO_101015_0902_end()
 

 

	

	
	dot_unit_dir(dotArthur,3)

	wait_time(1.0)

	dot_unit_dir(dotArthur,2)

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","肯定3")
	message("CO_101015_09020028")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","肯定2")
	message("CO_101015_09020029")
	close_speech_window()

	bgm_play("BGM_ADV_Antagonism")

	
	move_camera(12, 23, 2.0)--
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotArthur, true)

	local NoirSet = create_coroutine(NoirMoveSet) 
	local ArthurSet = create_coroutine(ArthurMoveSet) 
	
	coroutine.resume(NoirSet)  
	coroutine.resume(ArthurSet)  


	pbadv_wait_coroutine(NoirSet) 
	pbadv_wait_coroutine(ArthurSet) 

	
	
	open_speech_window("NPCNAME_0222", nil, nil)
	PlayPartVoice("兵士1","驚き")
	message("CO_101015_09020031")
	close_speech_window()

	dot_unit_dir(dotromaa,2)

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士3","驚き")
	message("CO_101015_09020032")
	close_speech_window()

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","怒り")
	message("CO_101015_09020033")
	close_speech_window()

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","肯定2")
	message("CO_101015_09020034")
	

	
	change_face(Arthur, "Normal")
	
	message("CO_101015_09020035")
	

	
	change_face(Arthur, "Serious")
	
	message("CO_101015_09020036")
	close_speech_window()

	
	move_camera(13, 23, 2.0)

	local NoirSet2 = create_coroutine(NoirMoveSet2) 
	local ArthurSet2 = create_coroutine(ArthurMoveSet2) 
	
	coroutine.resume(NoirSet2)  
	coroutine.resume(ArthurSet2)  


	pbadv_wait_coroutine(NoirSet2) 
	pbadv_wait_coroutine(ArthurSet2) 

	wait_camera()






















	
	dot_disp_unit(dotmob, true)
	dot_unit_dir(dotmob,2)

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","怒り")
	message("CO_101015_09020038")
	close_speech_window()

	
	dot_move_unit_seq(dotromaa, 19, 27)
	wait_seq()

	dot_unit_dir(dotromaa,2)
	dot_disp_weapon(dotromaa, true)

	move_camera(19, 27, 1.0)
	wait_camera()

	wait_time(1.0)

	move_camera(12, 23, 1.0)
	wait_camera()

	
	change_face(Arthur, "Surprise")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","悩む")
	message("CO_101015_09020040")
	

	
	change_face(Arthur, "Pain")
	
	message("CO_101015_09020074")
	close_speech_window()

	
	dot_move_unit_seq(dotArthur, 15, 27)
	wait_seq()
	dot_unit_dir(dotArthur,3)

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101015_09020042")
	close_speech_window()

	
	move_camera(17, 28, 2.0)
	dot_move_unit_seq(dotNoir2, 14, 26)
	wait_seq()
	wait_camera()

	dot_unit_dir(dotNoir2,3)

	
	open_speech_window("NPCNAME_0001", nil, nil)
	PlayPartVoice("男子1","悲しみ")
	message("CO_101015_09020044")
	close_speech_window()

	
	change_face(Arthur, "Anger")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","怒り")
	message("CO_101015_09020045")
	close_speech_window()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","笑い")
	message("CO_101015_09020046")
	close_speech_window()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	message("CO_101015_09020047")
	close_speech_window()

	
	wait_time(1.0)

	
	dot_unit_dir(dotArthur,2)
	wait_time(1.0)

	
	dot_unit_dir(dotArthur,3)

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","落胆")
	message("CO_101015_09020049")
	close_speech_window()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","驚き")
	message("CO_101015_09020050")
	close_speech_window()

	se_play("SE_ADV_CO_101015_0902_Wepon_Drop")
	dot_disp_weapon(dotArthur, false)
	wait_time(1.5)
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	
	message("CO_101015_09020052")
	

	
	dot_reserve_move_unit_seq(dotromaa, 20, 27)
	dot_reserve_move_unit_seq(dotmob,20, 28)

	exec_parallel_seq()

	wait_seq()

	dot_unit_dir(dotromaa,2)
	dot_unit_dir(dotmob,2)

	
	
	change_face(Arthur, "Smile")
	
	PlayPartVoice("アーサー","笑い")
	message("CO_101015_09020054")
	close_speech_window()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","気合い")
	message("CO_101015_09020055")
	close_speech_window()

	
	
	
	dot_reserve_move_unit_seq(dotromaa, 17, 27)
	dot_reserve_move_unit_seq(dotNoir2,16, 27)
	dot_reserve_move_unit_seq(dotmob,21, 28)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotromaa,2)
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotmob,2)

	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotromaa,6)
	dot_play_particle_unit(dotromaa,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","苦しみ")
	message("CO_101015_09020057")
	close_speech_window()

	
	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotromaa,1)

	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","肯定2")
	message("CO_101015_09020059")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","肯定2")
	message("CO_101015_09020060")
	close_speech_window()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","悲しみ")
	message("CO_101015_09020061")
	close_speech_window()
	
	se_play("SE_ADV_CO_101015_0902_War_Voice")
	wait_time(1.3)
	
	open_speech_window("NPCNAME_0221", nil, nil)
	message("CO_101015_09020062")
	close_speech_window()
	
	
	
	
	


	

	
	open_speech_window("NPCNAME_0223", nil, nil)
	PlayPartVoice("兵士3","悲しみ")
	message("CO_101015_09020064")
	close_speech_window()

	
	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	PlayPartVoice("ガウェイン","気合い")
	message("CO_101015_09020066")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	
	message("CO_101015_09020067")
	close_speech_window()

	
	open_speech_window("NPCNAME_0221", nil, nil)
	PlayPartVoice("兵士2","悲しみ")
	message("CO_101015_09020068")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")

	
	dot_reserve_move_unit_seq(dotromac,32, 18)
	dot_reserve_move_unit_seq(dotromab,32, 19)
	dot_reserve_move_unit_seq(dotromaa, 32, 20)

	exec_parallel_seq()

	dot_unit_dir(dotNoir2,2)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール","悩む")
	message("CO_101015_09020070")
	

	
	change_face(Noir2, "Normal")
	
	message("CO_101015_09020071")
	close_speech_window()

	
	
	change_face(Arthur, "Smile")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	PlayPartVoice("アーサー","喜び")
	message("CO_101015_09020073")
	close_speech_window()

	local trustParam2 = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")	
	trustParam2.UpdateRankup()	
	open_trust_rank_up(Arthur, trustParam2)	
	
	
	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 3, 23,0)
	pbadv_setup_101015_Arthur_preload(0,true, 4, 23,0)
	setup_101013_Gawain_preload(nil, nil, 0, false)
	preload_sound("BGM_ADV_Antagonism")
end
