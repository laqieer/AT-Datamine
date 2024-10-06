

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)


	
	init_psbattleadv("201090000", "201090000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

    
	dotnoir = dot_reserve_ally(101009001, 19, 24, 0)
	dot_set_weapon(dotnoir, 101010001)    


	dotarthur = dot_reserve_ally(101015001, 19, 23, 0)
	dot_set_weapon(dotarthur, 101010001)    

	dotsoldier1 = dot_reserve_ally(401035001, 17, 24, 0)
	dot_set_weapon(dotsoldier1, 101010001)    


	dotsoldier2 = dot_reserve_ally(401035001, 18, 24, 0)
	dot_set_weapon(dotsoldier2, 101010001)    


	dotsoldier3 = dot_reserve_ally(401035001, 20, 24, 0)
	dot_set_weapon(dotsoldier3, 101010001)    

	dotsoldier4 = dot_reserve_ally(401035001, 18, 25, 0)
	dot_set_weapon(dotsoldier4, 101010001)    

	dotsoldier5 = dot_reserve_ally(401035001, 19, 25, 0)
	dot_set_weapon(dotsoldier5, 101010001)    


	dotsoldier7 = dot_reserve_ally(401035001, 24, 26, 0)
	dot_set_weapon(dotsoldier7, 101010001)    

	dotsoldier8 = dot_reserve_ally(401035001, 18, 27, 0)
	dot_set_weapon(dotsoldier8, 101010001)    

	dotsoldier9 = dot_reserve_ally(401035001, 22, 26, 0)
	dot_set_weapon(dotsoldier9, 101010001)    

	dotsoldier10 = dot_reserve_ally(401035001, 15, 26, 0)
	dot_set_weapon(dotsoldier10, 101010001)    

	

	barbaroi1 = dot_reserve_enemy(3, 20, 22, 0)
	barbaroi2 = dot_reserve_enemy(3, 21, 22, 0)
	barbaroi3 = dot_reserve_enemy(3, 22, 22, 0)
	barbaroi4 = dot_reserve_enemy(3, 23, 22, 0)
	barbaroi5 = dot_reserve_enemy(3, 24, 22, 0)
	barbaroi6 = dot_reserve_enemy(3, 25, 22, 0)
	
	barbaroi7 = dot_reserve_enemy(3, 17, 23, 0)
	barbaroi8 = dot_reserve_enemy(3, 25, 26, 0)
	barbaroi9 = dot_reserve_enemy(3, 17, 27, 0)
	barbaroi10 = dot_reserve_enemy(3, 22, 27, 0)
	barbaroi11 = dot_reserve_enemy(3, 16, 26, 0)
	
	
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotsoldier8, 2)
	dot_unit_dir(barbaroi9, 3)
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(35.0, 0.0)

	
	
	move_camera(19, 23, 0.0)
	
	Ef_Slash01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, false)

end




function Play()
	fadein(0)
	Play_start(true)

	change_camera_distance(6.0, 1.0)
	wait_camera()

	dot_change_anim(dotarthur, 3)
	wait_time(0.5)
	dot_change_anim(dotarthur, 0)
	wait_time(1.0)

	dot_reserve_move_unit_seq(dotnoir, 21, 23)
	dot_reserve_move_unit_seq(dotarthur, 22, 23)

	
	exec_parallel_seq()

	
	wait_seq()

	
	move_camera(22, 23, 1.0)
	wait_camera()

	dot_unit_dir(dotarthur, 0)
	dot_change_anim(dotarthur,3)

	on_active(Ef_Slash01)

	
	local gridpos = get_grid_position(22, 23)
	set_pos(Ef_Slash01, gridpos)
	play_particle(Ef_Slash01)
	
	wait_time(0.3)

	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_N_Hit_Sla01",1,true)


	dot_change_anim(barbaroi1,6)
	dot_change_anim(barbaroi2,6)
	dot_change_anim(barbaroi3,6)
	dot_change_anim(barbaroi4,6)
	dot_change_anim(barbaroi5,6)
	dot_change_anim(barbaroi6,6)
	
	
	dot_change_anim(dotnoir, DotAnim_Idle)		
	dot_change_anim(dotarthur, DotAnim_Idle)		


	dot_unit_dir(barbaroi1, 3)
	dot_unit_dir(barbaroi2, 3)
	dot_unit_dir(barbaroi3, 3)

	dot_change_anim(barbaroi1, 1)
	dot_change_anim(barbaroi2, 1)
	dot_change_anim(barbaroi3, 1)
	dot_change_anim(barbaroi4, 1)
	dot_change_anim(barbaroi5, 1)
	dot_change_anim(barbaroi6, 1)

	wait_time(0.4)

	dot_move_knockback(barbaroi1, 19, 22,0.1,2)
	dot_move_knockback(barbaroi6, 26, 22,0.1,2)
	dot_move_knockback(barbaroi2, 20, 22,0.1,2)
	dot_move_knockback(barbaroi5, 25, 22,0.1,2)
	dot_move_knockback(barbaroi3, 21, 22,0.1,2)
	dot_move_knockback(barbaroi4, 24, 22,0.1,2)


	wait_time(1.0)
	
	move_camera(22, 26, 0.0)
	wait_camera()

	dot_attack_seq(dotsoldier9, barbaroi10)			
	dot_damage_seq(barbaroi10, dotsoldier9, false)	
	wait_seq()									

	move_camera(16, 26, 0.0)
	wait_camera()

	dot_attack_seq(barbaroi11, dotsoldier10)			
	dot_damage_seq(dotsoldier10, barbaroi11, false)	
	wait_seq()									

	move_camera(25, 26, 0.0)
	wait_camera()

	dot_attack_seq(barbaroi8, dotsoldier7)			
	dot_damage_seq(dotsoldier7, barbaroi8, false)	
	wait_seq()									

	move_camera(18, 27, 0.0)
	wait_camera()

	dot_attack_seq(dotsoldier8, barbaroi9)			
	dot_damage_seq(barbaroi9, dotsoldier8, false)	
	wait_seq()									

	move_camera(17, 23, 0.0)
	wait_camera()

	dot_attack_seq(dotsoldier1, barbaroi7)			
	dot_damage_seq(barbaroi7, dotsoldier1, false)	
	wait_seq()									

		
	dot_change_anim(dotsoldier1, 0)


	change_camera_distance(8.0, 1.0)
	move_camera(22, 23, 1.0)
	wait_camera()
	
	dot_reserve_move_unit_seq(dotnoir, 22, 21)
	dot_reserve_move_unit_seq(dotarthur, 22, 20)

	dot_reserve_move_unit_seq(dotsoldier2, 21, 23)
	dot_reserve_move_unit_seq(dotsoldier3, 22, 22)

	dot_reserve_move_unit_seq(dotsoldier4, 22, 23)
	dot_reserve_move_unit_seq(dotsoldier5, 23, 23)

	
	exec_parallel_seq()

	
	wait_seq()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, false)
end
