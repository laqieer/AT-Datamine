Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201010000","201010000")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)



	pbadv_setup_101030_Elaine(1,true,31,16,0)
	
	pbadv_setup_101031_Lovein(1,true,30,15,0)
	
	pbadv_setup_101037_Rasia(1,true,34,16,0)
	
	barbaroi1 = dot_reserve_enemy(301, 35, 13, 0)
	barbaroi2 = dot_reserve_enemy(301, 36, 13, 0)
	barbaroi3 = dot_reserve_enemy(301, 32, 6, 0)
	barbaroi4 = dot_reserve_enemy(301, 32, 7, 0)
	barbaroi5 = dot_reserve_enemy(301, 32, 8, 0)
	barbaroi6 = dot_reserve_enemy(301, 32, 9, 0)
	barbaroi7 = dot_reserve_enemy(301, 32, 10, 0)
	
	dotroma1=dot_reserve_ally(401040001,35,14,0)
	dot_set_weapon(dotroma1,101010001)
	dotroma2=dot_reserve_ally(401040001,36,14,0)
	dot_set_weapon(dotroma2,101010001)
	dotroma3=dot_reserve_ally(401040001,33,6,0)
	dot_set_weapon(dotroma3,101010001)
	dotroma4=dot_reserve_ally(401040001,33,7,0)
	dot_set_weapon(dotroma4,101010001)
	dotroma5=dot_reserve_ally(401040001,33,8,0)
	dot_set_weapon(dotroma5,101010001)
	dotroma6=dot_reserve_ally(401040001,33,9,0)
	dot_set_weapon(dotroma6,101010001)
	dotroma7=dot_reserve_ally(401040001,33,10,0)
	dot_set_weapon(dotroma7,101010001)
	
	dotroma8=dot_reserve_ally(401039001,32,4,0)
	dot_set_weapon(dotroma8,105010001)
	dotroma9=dot_reserve_ally(401039001,32,5,0)
	dot_set_weapon(dotroma9,105010001)
	dotroma10=dot_reserve_ally(401039001,33,4,0)
	dot_set_weapon(dotroma10,105010001)
	dotroma11=dot_reserve_ally(401039001,33,5,0)
	dot_set_weapon(dotroma11,105010001)
	dotroma12=dot_reserve_ally(401039001,37,13,0)
	dot_set_weapon(dotroma12,105010001)
	dotroma13=dot_reserve_ally(401039001,37,14,0)
	dot_set_weapon(dotroma13,105010001)
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotRasia1,2)
	dot_unit_dir(dotroma1,2)
	dot_unit_dir(dotroma2,2)
	dot_unit_dir(dotroma3,2)
	dot_unit_dir(dotroma4,2)
	dot_unit_dir(dotroma5,2)
	dot_unit_dir(dotroma6,2)
	dot_unit_dir(dotroma7,2)
	dot_unit_dir(dotroma8,2)
	dot_unit_dir(dotroma9,2)
	dot_unit_dir(dotroma10,2)
	dot_unit_dir(dotroma11,2)
	dot_unit_dir(dotroma12,2)
	dot_unit_dir(dotroma13,2)

	
	

	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(35.0,0.0)

	
	
	move_camera(32,16,0.0)
	
	Ef_Shockwave01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_Hit_Enemy=load_particle("content_effect3d_common_adv","Ef_C_Adv_Hit_Enemy",false,true)
end





function Play()
	fadein(0)
	Play_start(true)



	dot_reserve_move_unit_seq(dotRasia1,33,16)
	dot_reserve_move_unit_seq(dotElaine1,32,16)
	exec_parallel_seq()
	wait_seq()

	
	

	dot_change_anim(dotRasia1,3)
	dot_play_particle_unit(dotRasia1,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)

	
	
	
	
	
	
	wait_time(0.5)
	
	dot_move_knockback(dotRasia1,34,16,0.1,2)
	dot_move_knockback(dotElaine1,31,16,0.1,2)
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotRasia1,2)
	dot_unit_dir(dotElaine1,3)

	dot_change_anim(dotRasia1,0)
	dot_change_anim(dotElaine1,0)

	
	change_face(Elaine1,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_370002")
	close_speech_window()
	

	
	change_face(Rasia1,"Anger")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia1)
	message("MA_01A900_370003")

	dot_reserve_move_unit_seq(dotRasia1,33,16)
	dot_reserve_move_unit_seq(dotElaine1,32,16)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotRasia1,2)
	dot_unit_dir(dotElaine1,3)
	dot_attack_seq(dotRasia1,dotElaine1)

	wait_seq()

	dot_dodge_seq(dotElaine1)
	
	dot_attack_seq(dotElaine1,dotRasia1)
	wait_seq()

	dot_dodge_seq(dotRasia1)
	
	wait_seq()
	dot_change_anim(dotElaine1,0)
	dot_change_anim(dotElaine1,0)
	wait_time(0.2)
	
	
	change_face(Rasia1,"Anger")
	message("MA_01A900_370004")

	dot_change_anim(dotRasia1,3)
	dot_play_particle_unit(dotRasia1,"Ef_C_Swd_N_Atk01",3,true)
	dot_play_particle_unit(dotElaine1,"Ef_C_Cmn_N_Hit_Sla01",2,true)
	
	
	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)
	dot_play_particle_unit(dotRasia1,"Ef_C_Cmn_N_Hit_Spe01",2,true)


	wait_time(0.5)
	
	dot_move_knockback(dotRasia1,34,16,0.1,2)
	dot_move_knockback(dotElaine1,31,16,0.1,2)
	exec_parallel_seq()
	wait_seq()
	dot_change_anim(dotElaine1,0)
	dot_change_anim(dotRasia1,0)

	dot_unit_dir(dotRasia1,2)
	dot_unit_dir(dotElaine1,3)

	
	change_face(Rasia1,"Anger")
	message("MA_01A900_370005")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotRasia1,34,16)
	dot_reserve_move_unit_seq(dotElaine1,31,16)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotRasia1,2)
	dot_unit_dir(dotElaine1,3)

	dot_move_unit_seq(dotLovein1,31,15)
	dot_move_unit_seq(dotRasia1,32,16)
	wait_seq()

	
	
	

	
	
	
	
	
	
	


	dot_change_anim(dotRasia1,3)
	dot_play_particle_unit(dotRasia1,"Ef_C_Swd_N_Atk01",3,true)
	
	on_active(Ef_Hit_Enemy)
	local gridpos=get_grid_position(31,16)
	set_pos(Ef_Hit_Enemy,gridpos)
	play_particle(Ef_Hit_Enemy)
	wait_time(0.3)
	
	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)
	dot_change_anim(dotLovein1,3)
	dot_play_particle_unit(dotLovein1,"Ef_C_Spr_N_Atk01",3,true)

	wait_time(0.5)
	dot_play_particle_unit(dotRasia1,"Ef_C_Cmn_N_Hit_Spe01",2,true)
	

	
	

	dot_move_knockback(dotRasia1,34,16,0.2,2)
	wait_seq()

	dot_unit_dir(dotRasia1,2)

	dot_change_anim(dotLovein1,0)
	dot_change_anim(dotElaine1,0)
	dot_change_anim(dotRasia1,0)
	
	
	
	change_face(Rasia1,"Anger")	
	open_speech_window("CHRNAME_RASIA2",nil,Rasia1)
	message("MA_01A900_370007")
	close_speech_window()
	
	
	change_face(Elaine1,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_370008")
	close_speech_window()

	
	wait_time(0.5)
	
	dot_reserve_move_unit_seq(dotRasia1,33,16)
	dot_reserve_move_unit_seq(dotElaine1,32,16)
	exec_parallel_seq()
	wait_seq()

	dot_change_anim(dotRasia1,3)
	dot_play_particle_unit(dotRasia1,"Ef_C_Swd_N_Atk01",3,true)

	dot_play_particle_unit(dotElaine1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	on_active(Ef_Shockwave01)
	local gridpos=get_grid_position(32,16)
	set_pos(Ef_Shockwave01,gridpos)
	play_particle(Ef_Shockwave01)
	wait_seq()

	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)

	dot_play_particle_unit(dotRasia1,"Ef_C_Cmn_N_Hit_Spe01",1,true)

	local gridpos=get_grid_position(33,16)
	set_pos(Ef_Shockwave01,gridpos)
	play_particle(Ef_Shockwave01)
	wait_seq()
	
	wait_time(0.2)
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101030_Elaine_preload(1,true,31,16,0)
	pbadv_setup_101031_Lovein_preload(1,true,30,15,0)
	pbadv_setup_101037_Rasia_preload(1,true,34,16,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Hit_Enemy",false,true)
end
