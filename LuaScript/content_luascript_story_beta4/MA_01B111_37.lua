

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)

	
	
	init_psbattleadv("201200001", "201200001")
	
	
	change_time_and_weather(1, 5)

	pbadv_setup_101009_Noir(2,true, 13, 14,0)  
	pbadv_setup_101010_Lancelot(1,true, 13, 15,0)  
	pbadv_setup_101010_Lancelot(0,true, 2, 4,0)  
	
	pbadv_setup_101011_Guinevere(0,true, 4, 4,0)  
	pbadv_setup_101013_Gawain(0,true, 3, 3,0)  
	pbadv_setup_101026_Percival(0,true, 20, 30,0)  
	pbadv_setup_101027_Dindrane(2,true, 21, 30,0)  
	pbadv_setup_101028_Galahad(1,true, 24, 30,0)  
	
	pbadv_setup_101015_Arthur(0,true, 19, 24,0)  
	pbadv_setup_101020_Merlin(2,true, 18, 25,0)  

	pbadv_setup_101036_Viena(0,true, 20, 30,0)  

	pbadv_setup_101029_Astera(1,true, 11, 24,0) 

	
	

	pbadv_setup_101053_Mathajim(2,true, 11, 24,0)  
	pbadv_setup_101054_Adam(2,true, 11, 23,0)  
	pbadv_setup_101055_Owen(2,true, 11, 25,0)  

	pbadv_setup_101056_Perez(1,true, 22, 24,0)  

	
	barubaroi1 = dot_reserve_enemy(1100, 12, 14, 0)
	barubaroi2 = dot_reserve_enemy(49, 12, 15, 0)
	barubaroi3 = dot_reserve_enemy(1100, 14, 14, 0)
	barubaroi4 = dot_reserve_enemy(49, 14, 15, 0)
	barubaroi5 = dot_reserve_enemy(1100, 11, 16, 0)
	barubaroi6 = dot_reserve_enemy(49, 15, 15, 0)

	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotMerlin2, 3)
	dot_unit_dir(dotPerez1, 2)
	dot_unit_dir(dotMathajim2, 3)
	dot_unit_dir(dotAdam2, 3)
	dot_unit_dir(dotOwen2, 3)
	dot_unit_dir(barubaroi1, 3)
	dot_unit_dir(barubaroi2, 3)
	dot_unit_dir(barubaroi5, 3)
	dot_unit_dir(dotAstera1, 2)
	dot_unit_dir(dotPercival, 2)
	dot_unit_dir(dotDindrane2, 2)

	dot_disp_unit(dotGalahad1,false)
	dot_disp_unit(dotAstera1,false)
	dot_disp_unit(dotViena,false)

	
	
	
	Ef_Aura = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(20, 24, 0.0)
	
	load_sound("BGM_ADV_Tragedy")

end

function PerezAtkSet() 
	dot_play_particle_unit(dotPerez1,"Ef_C_Mag_R_Cha01",1,true)	
	
	
	wait_time(1.0)	
	
	dot_play_particle_unit(dotPerez1,"Ef_C_Mag_R_Atk01",1,true)
	
	dot_change_anim(dotPerez1,4)		
	
	
	wait_time(0.5)	
	
	dot_play_particle_grid("Ef_C_Mag_R_Hit01",19, 24)
	
	wait_time(0.5)	
end

function ArthurMoveSet() 
	wait_time(1.5)
	dot_change_anim(dotArthur, 3)
	
	wait_time(0.5)	
end

function Perez2Set() 
	dot_move_unit(dotPerez1, 22, 24)
	wait_seq()
	dot_unit_dir(dotPerez1, 2)
end
function AsteraMoveSet() 
	dot_target_attack(dotAstera1, dotArthur,false)
	wait_seq()
end

	
	
	

function Play()
	fadein(0)
	Play_start(true)



	
	
	
	
	
	change_face(Arthur, "Normal")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B111_370002")
	close_speech_window()

	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370003")
	close_speech_window()


	
	
	on_active(Ef_Aura )
	local gridpos = get_grid_position(22,24)
	set_pos(Ef_Aura , gridpos)
	play_particle(Ef_Aura )
	wait_time(1.0)		
	
	
	move_camera(13, 15, 0.8)
	wait_camera(1.0)	
	
	
	change_face(Lancelot, "Anger")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01B111_370005")
	close_speech_window()

	
	move_camera(20, 24, 0.8)

	
	dot_reserve_move_unit_seq(dotMathajim2, 12, 23)
	dot_reserve_move_unit_seq(dotAdam2, 12, 24)
	dot_reserve_move_unit_seq(dotOwen2, 12, 25)
	exec_parallel_seq()
	wait_seq()	
	
	dot_reserve_move_unit_seq(dotMathajim2, 15, 23)
	dot_reserve_move_unit_seq(dotAdam2, 15, 24)
	dot_reserve_move_unit_seq(dotOwen2, 15, 25)
	exec_parallel_seq()
	wait_seq()	
	
	
	dot_unit_dir(dotMathajim2, 3)
	dot_unit_dir(dotAdam2, 3)
	dot_unit_dir(dotOwen2, 3)
	
	dot_unit_dir(dotMerlin2, 2)
	
	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370007")
	close_speech_window()

	
	
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B111_370009")
	close_speech_window()

	
	dot_move_height(dotMerlin2,1.0,0.7, 0)	
	wait_time(1.0)	

	dot_play_particle_unit(dotMerlin2,"Ef_C_Mag_I_Cha01",1,true)	
	
	
	wait_time(1.0)	
	dot_change_anim(dotMerlin2, 3)	
	dot_play_particle_unit(dotMerlin2,"Ef_C_Mag_I_Atk01",1,true)
	
	
	wait_time(0.5)	
	
	dot_play_particle_unit(dotMathajim2,"Ef_C_Mag_I_Hit01",1,true)
	dot_play_particle_unit(dotAdam2,"Ef_C_Mag_I_Hit01",1,true)
	dot_play_particle_unit(dotOwen2,"Ef_C_Mag_I_Hit01",1,true)	
	
	dot_change_anim(dotMathajim2, 1)
	dot_change_anim(dotAdam2, 1)
	dot_change_anim(dotOwen2, 1)
	
	
	wait_time(1.0)	
	
	dot_change_anim(dotMerlin2, 0)	
		
	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370011")
	close_speech_window()
	

	
	local PerezSet = create_coroutine(PerezAtkSet) 
	local ArthurSet = create_coroutine(ArthurMoveSet) 
	
	coroutine.resume(PerezSet)  
	coroutine.resume(ArthurSet)  
	

	




	pbadv_wait_coroutine(PerezSet) 
	pbadv_wait_coroutine(ArthurSet) 

	dot_change_anim(dotArthur, 0)	
	dot_change_anim(dotPerez1, 0)
	
	
	
	
	stop_particle(Ef_Aura)	
	
	
	change_face(Arthur, "Sad")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B111_370013")
	close_speech_window()
	
	
	move_camera(18, 24, 0.5)

	
	wait_time(0.5)	
	
	
	dot_change_anim(dotArthur, 0)
	
	
	wait_time(0.2)	
	
	dot_unit_dir(dotArthur, 2)
	
	
	wait_time(0.3)		


	
	
	dot_attack_seq(dotArthur, dotAdam2)
	
	wait_time(0.8)		

	dot_play_particle_unit(dotMathajim2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotAdam2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotOwen2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	dot_change_anim(dotMathajim2, 6)	
	dot_change_anim(dotAdam2, 6)	
	dot_change_anim(dotOwen2, 6)	
	

	
	wait_time(0.3)		

	
	dot_move_knockback(dotMathajim2, 12, 23,0.2, 2)
	dot_move_knockback(dotAdam2, 12, 24,0.2, 2)
	dot_move_knockback(dotOwen2, 12, 25,0.2, 2)
	wait_time(0.2)	
	

	
	dot_move_fly(dotMerlin2, 14, 25,1.0,0.6,2)
	exec_parallel_seq()
	wait_seq()	
	
	
	move_camera(20, 24, 0.5)
	wait_camera()	
	
	dot_change_anim(dotArthur, 0)
	
	wait_time(0.3)	
	
	
	
	dot_place_unit(dotMathajim2, 7, 21)
	dot_place_unit(dotAdam2, 8, 22)
	dot_place_unit(dotOwen2, 7, 23)
	dot_place_unit(dotMerlin2, 10, 22)
	dot_unit_dir(dotMerlin2, 3)
	dot_unit_dir(dotMathajim2, 3)
	dot_unit_dir(dotAdam2, 3)
	dot_unit_dir(dotOwen2, 3)	
	
	
	
	dot_unit_dir(dotArthur, 3)

	
	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370015")
	close_speech_window()

	
	dot_play_particle_unit(dotPerez1,"Ef_C_Mag_R_Cha01",1,true)	
	
	
	wait_time(1.0)	
	
	
	dot_change_anim(dotMathajim2, 0)
	dot_change_anim(dotAdam2, 0)
	dot_change_anim(dotOwen2, 0)
	
	
	
	
	
	dot_play_particle_unit(dotPerez1,"Ef_C_Mag_R_Atk01",1,true)
	
	dot_change_anim(dotPerez1,4)
	
	wait_time(0.5)	
	dot_play_particle_grid("Ef_C_Mag_R_Hit01",19, 24)

	dot_reserve_move_unit_seq(dotArthur, 20, 24)
	dot_reserve_move_unit_seq(dotPerez1, 21, 24)
	exec_parallel_seq()
	wait_seq()	
	
	
	wait_time(0.3)	

	dot_change_anim(dotArthur, 3)
	dot_change_anim(dotPerez1, 3)

	
	wait_time(0.2)	

	dot_play_particle_unit(dotArthur,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotPerez1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	wait_time(0.3)	
	
	dot_move_knockback(dotArthur, 19, 24,0.1, 2)
	wait_time(0.2)	

	
	dot_change_anim(dotArthur, 1)
	
	
	wait_time(0.3)	
			
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_370017")
	close_speech_window()
	
	
	move_camera(18, 24, 0.3)
	
	
	wait_time(0.5)	

	
	
	dot_disp_unit(dotAstera1,true)	
	dot_move_unit_seq(dotAstera1, 16, 24)	
	wait_seq()	
	

	
	
	dot_unit_dir(dotAstera1, 3)
	
	bgm_play("Stop_BGM_Bus_MidFade")
	
	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_ASTERA2", Astera1, nil)
	message("MA_01B111_370019")
	close_speech_window()
	
	
	local AsteraSet = create_coroutine(AsteraMoveSet) 
	local Perez2Set = create_coroutine(Perez2Set) 
	
	coroutine.resume(AsteraSet)  
	coroutine.resume(Perez2Set)  
	
	

	pbadv_wait_coroutine(AsteraSet) 
	pbadv_wait_coroutine(Perez2Set) 

	
	dot_change_anim(dotArthur, 1)
	
	dot_unit_dir(dotPerez1, 2)
		
	
	wait_time(0.1)
	
	
	bgm_play("BGM_ADV_Tragedy")
	
	change_face(Arthur, "Surprise")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B111_370021")
	close_speech_window()
	
	
	move_camera(9, 23, 0.6)
	wait_camera()
	
	
	change_face(Merlin2, "Surprise")
	open_speech_window("CHRNAME_MERLIN", Merlin2, nil)
	message("MA_01B111_370022")
	close_speech_window()

	
	dot_change_anim(dotAstera1, 0)
	dot_unit_dir(dotPerez1, 2)

	
	move_camera(21, 30, 0.7)
	wait_camera()
	
	
	wait_time(0.5)	
	
	
	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B111_370024")
	close_speech_window()
	
	
	move_camera(18, 24, 1.0)
	
	dot_move_unit_seq(dotDindrane2, 20, 28)
	exec_parallel_seq()
	wait_seq()	
	
	dot_move_unit_seq(dotDindrane2, 19, 26)
	exec_parallel_seq()
	wait_seq()	

	dot_move_unit_seq(dotDindrane2, 17, 24)
	exec_parallel_seq()
	wait_seq()	
	
	dot_unit_dir(dotDindrane2, 2)

	
	
	change_face(Dindrane2, "Anger")
	open_speech_window("CHRNAME_DINDRANE2", Dindrane2, nil)
	message("MA_01B111_370026")
	close_speech_window()
	
	
	dot_disp_unit(dotViena,true)
	
	
	dot_attack_seq(dotDindrane2, dotAstera1)
	dot_damage_seq(dotAstera1, dotDindrane2, true)
	wait_seq()	
	
	dot_change_anim(dotAstera1, 6)
	dot_move_knockback(dotAstera1, 13, 24,0.4, 2)
	wait_time(0.3)	

	dot_reserve_move_unit_seq(dotDindrane2, 14, 24)
	exec_parallel_seq()
	wait_seq()	

	
	
	move_camera(21, 24, 0.3)

	
	dot_reserve_move_unit_seq(dotViena, 20, 24)
	exec_parallel_seq()
	wait_seq()
	
	
	dot_unit_dir(dotArthur, 3)
	dot_unit_dir(dotViena, 3)

	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B111_370028")
	close_speech_window()

	
	
	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370030")
	close_speech_window()

	
	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B111_370032")
	close_speech_window()

	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370033")
	close_speech_window()

	
	
	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B111_370035")

	
	
	
	message("MA_01B111_370037")

	
	
	change_face(Viena, "Sad")
	message("MA_01B111_370039")
	close_speech_window()
	
	
	dot_place_unit(dotMathajim2, 8, 2)
	dot_place_unit(dotAdam2, 9, 3)
	dot_place_unit(dotOwen2, 10, 4)
	dot_place_unit(dotAstera1, 7, 2)
	dot_place_unit(dotGuinevere, 8, 5)
	dot_place_unit(dotMerlin2, 9, 5)
	dot_place_unit(dotDindrane2, 21, 30)
	dot_change_anim(dotAstera1, 0)
	

	
	
	dot_reserve_move_unit_seq(dotPerez1, 16, 23)
	exec_parallel_seq()
	wait_seq()
	
	
	
	dot_place_unit(dotMathajim2, 8, 22)
	dot_place_unit(dotAdam2, 9, 22)
	dot_place_unit(dotOwen2, 10, 22)
	dot_place_unit(dotAstera1, 7, 22)
	dot_place_unit(dotGuinevere, 8, 23)
	dot_place_unit(dotMerlin2, 9, 23)
	
	dot_change_anim(dotMerlin2, 1)
	dot_change_anim(dotGuinevere, 1)
	
	
	
	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370041")
	
	change_face(Perez1, "Normal")
	message("MA_01B111_370042")
	close_speech_window()
	
	dot_move_unit_seq(dotPerez1, 12, 23)

	
	move_camera(11, 23, 1.0)
	wait_camera()

	

	wait_time(0.5)

	
	dot_unit_dir(dotPerez1, 2)
	

	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370044")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_370045")
	close_speech_window()

	
	change_face(Arthur, "Surprise")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message("MA_01B111_370046")
	close_speech_window()

	
	change_face(Perez1, "Normal")
	open_speech_window("CHRNAME_PEREZ", nil, Perez1)
	message("MA_01B111_370047")

	
	change_face(Perez1, "Normal")
	message("MA_01B111_370048")
	close_speech_window()

	
	
	

	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 13, 14,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 13, 15,0)
	pbadv_setup_101010_Lancelot_preload(0,true, 2, 4,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 4, 4,0)
	pbadv_setup_101013_Gawain_preload(0,true, 3, 3,0)
	pbadv_setup_101026_Percival_preload(0,true, 20, 30,0)
	pbadv_setup_101027_Dindrane_preload(2,true, 21, 30,0)
	pbadv_setup_101028_Galahad_preload(1,true, 24, 30,0)
	pbadv_setup_101015_Arthur_preload(0,true, 19, 24,0)
	pbadv_setup_101020_Merlin_preload(2,true, 18, 25,0)
	pbadv_setup_101036_Viena_preload(0,true, 20, 30,0)
	pbadv_setup_101029_Astera_preload(1,true, 11, 24,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 11, 24,0)
	pbadv_setup_101054_Adam_preload(2,true, 11, 23,0)
	pbadv_setup_101055_Owen_preload(2,true, 11, 25,0)
	pbadv_setup_101056_Perez_preload(1,true, 22, 24,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	preload_sound("BGM_ADV_Tragedy")
end
