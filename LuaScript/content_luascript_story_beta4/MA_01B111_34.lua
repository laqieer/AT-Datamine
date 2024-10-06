

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)

	
	
	init_psbattleadv("201200001", "201200001")
	
	
	change_time_and_weather(1, 5)
	
	pbadv_setup_101009_Noir(2,true, 19, 2,0)  

	pbadv_setup_101010_Lancelot(1,true, 18, 4,0)  
	pbadv_setup_101011_Guinevere(0,true,2,2,0)  
	pbadv_setup_101013_Gawain(0,true,2,3,0)  
	pbadv_setup_101026_Percival(0,true, 5, 8,0)  
	pbadv_setup_101027_Dindrane(1,true, 5, 7,0)  

	pbadv_setup_101024_Bors(0,true, 18, 13,0)  
	pbadv_setup_101025_Clare(1,true, 16, 13,0)  

	pbadv_setup_101028_Galahad(1,true, 17, 9,0)  
	pbadv_setup_101053_Mathajim(2,true, 16, 9,0)  
	pbadv_setup_101054_Adam(2,true, 18, 9,0)  
	pbadv_setup_101055_Owen(2,true, 17, 8,0)  
	pbadv_setup_101056_Perez(1,true, 16, 5,0)  
	pbadv_setup_101042_Moronoe(true, 13, 9,0)  
	
	
	barubaroi1 = dot_reserve_enemy(1100, 17, 2, 0)
	barubaroi2 = dot_reserve_enemy(49, 17, 3, 0)
	barubaroi3 = dot_reserve_enemy(1100, 20, 2, 0)
	barubaroi4 = dot_reserve_enemy(49, 19, 3, 0)
	barubaroi5 = dot_reserve_enemy(1100, 16, 4, 0)
	barubaroi6 = dot_reserve_enemy(49, 19, 1, 0)

	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotNoir2, 3)	
	dot_unit_dir(dotLancelot1, 2)	

	dot_unit_dir(dotGalahad1, 2)	
	dot_unit_dir(dotMoronoe, 3)
	dot_unit_dir(dotPerez1, 3)
	dot_unit_dir(dotMathajim2, 3)
	dot_unit_dir(dotAdam2, 2)
	dot_unit_dir(dotOwen2, 2)

	dot_unit_dir(barubaroi1, 3)
	dot_unit_dir(barubaroi2, 3)	
	dot_unit_dir(barubaroi3, 2)
	dot_unit_dir(barubaroi4, 2)
	
	dot_unit_dir(dotBors, 2)	
	
	
	dot_disp_unit(dotBors, false)
	dot_disp_unit(dotClare1, false)

	
	
	dot_change_anim(dotGalahad1, 1)
	dot_change_anim(barubaroi5, 1)
	dot_change_anim(barubaroi6, 1)
	dot_change_anim(barubaroi4, 1)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(17, 8, 0.0)
end

function MathajimSet() 
	dot_target_attack(dotMathajim2, dotClare1,false)
	
	dot_change_anim(dotClare1, 6)	
	
	dot_move_knockback(dotClare1, 16, 12,0.1, 2)	
	
	wait_time(0.5)
	
	dot_change_anim(dotClare1, 0)
	
end
function AdamSet() 
	dot_target_attack(dotAdam2, dotBors,false)
	
	dot_change_anim(dotBors, 6)	
	
	dot_move_knockback(dotBors, 18, 12,0.1, 2)	
	
	wait_time(0.4)
	
	dot_change_anim(dotBors, 0)	
	
end

function Play()
	fadein(0)
	Play_start(true)
	

	
	wait_time(1.0)

	
	
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_340002")
	
	change_face(Moronoe, "Normal")
	message("MA_01B111_340003")
	
	change_face(Moronoe, "Normal")
	message("MA_01B111_340004")
	
	change_face(Moronoe, "Smile")
	message("MA_01B111_340005")
	close_speech_window()
	
	
	
	move_camera(17, 8, 0.3)	
	
		
	wait_time(0.5)

	
	
	dot_attack_seq(dotOwen2, dotGalahad1)
	dot_damage_seq(dotGalahad1, dotOwen2, true)

		
	wait_time(0.7)	
	
	
	dot_change_anim(dotGalahad1, 1)
	
		
	wait_time(0.6)	

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_340007")
	close_speech_window()

	
	
	move_camera(19, 3, 0.5)	
	
		
	wait_time(0.7)	
	
	
	dot_attack_seq(dotNoir2, barubaroi3)
	dot_damage_seq(barubaroi3, dotNoir2, true)
	
	
		
	wait_time(0.5)	
	
	
	dot_change_anim(barubaroi4, 1)
	
		
	wait_time(0.8)	
	
		
	move_camera(17, 8, 0.6)
	
		
	wait_time(0.7)	
	

open_cutin(1,1)

on_cutin(1,Moronoe,"Normal") 


	

	open_speech_window("CHRNAME_SISTERS_1", nil, nil)
	message("MA_01B111_340009")
	close_speech_window()


close_cutin()


	
	
	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_340011")
	close_speech_window()

	
	
	dot_disp_unit(dotBors, true)
	dot_disp_unit(dotClare1, true)
	
	
	move_camera(17, 11, 0.3)
	
	
	dot_reserve_move_unit_seq(dotBors, 18, 12)
	dot_reserve_move_unit_seq(dotClare1, 16, 12)
	exec_parallel_seq()
	wait_seq()	
	
	
	change_face(Clare1, "Normal")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B111_340013")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_340014")
	close_speech_window()

	
	
	dot_reserve_move_unit_seq(dotMathajim2, 16, 10)
	dot_reserve_move_unit_seq(dotAdam2, 18, 10)
	exec_parallel_seq()
	wait_seq()	
	
	
	change_face(Bors, "Anger")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	message("MA_01B111_340016")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_340017")

	
	
	change_face(Moronoe, "Smile")
	message("MA_01B111_340019")
	close_speech_window()

	
	
	dot_reserve_move_unit_seq(dotBors, 18, 11)
	dot_reserve_move_unit_seq(dotClare1, 16, 11)
	exec_parallel_seq()
	wait_seq()		
	
	
	change_face(Clare1, "Anger")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B111_340021")
	close_speech_window()
	
	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_340022")

	
	
	change_face(Moronoe, "Normal")
	message("MA_01B111_340024")

	
	
	change_face(Moronoe, "Normal")
	message("MA_01B111_340026")
	close_speech_window()

	
	change_face(Clare1, "Anger")
	open_speech_window("CHRNAME_CLARE2", Clare1, nil)
	message("MA_01B111_340027")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01B111_340028")
	close_speech_window()

	
		
	wait_time(0.5)	
	

	local MathajimSet = create_coroutine(MathajimSet) 
	local AdamSet = create_coroutine(AdamSet) 
	
	coroutine.resume(MathajimSet)  
	coroutine.resume(AdamSet)  
	
	pbadv_wait_coroutine(MathajimSet) 
	pbadv_wait_coroutine(AdamSet) 

	
	
	
	dot_attack_seq(dotOwen2, dotGalahad1)
	dot_damage_seq(dotGalahad1, dotOwen2, true)
	
		
	wait_time(0.5)
	
	dot_change_anim(dotGalahad1, 6)
	
	
	dot_move_knockback(dotGalahad1, 17, 11,0.3, 2)
	
		
	wait_time(0.3)	
	
	
	dot_change_anim(dotGalahad1, 1)

	dot_move_unit_seq(dotOwen2, 17, 10)	
	
		
	wait_time(0.8)	


	
	move_camera(16, 7, 0.5)	
	
		
	wait_time(0.8)	
	
	
	dot_reserve_move_unit_seq(dotPerez1, 16, 7)
	exec_parallel_seq()
	wait_seq()	

	
	wait_time(1.0)	
	






	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 19, 2,0)
	pbadv_setup_101010_Lancelot_preload(1,true, 18, 4,0)
	pbadv_setup_101011_Guinevere_preload(0,true,2,2,0)
	pbadv_setup_101013_Gawain_preload(0,true,2,3,0)
	pbadv_setup_101026_Percival_preload(0,true, 5, 8,0)
	pbadv_setup_101027_Dindrane_preload(1,true, 5, 7,0)
	pbadv_setup_101024_Bors_preload(0,true, 18, 13,0)
	pbadv_setup_101025_Clare_preload(1,true, 16, 13,0)
	pbadv_setup_101028_Galahad_preload(1,true, 17, 9,0)
	pbadv_setup_101053_Mathajim_preload(2,true, 16, 9,0)
	pbadv_setup_101054_Adam_preload(2,true, 18, 9,0)
	pbadv_setup_101055_Owen_preload(2,true, 17, 8,0)
	pbadv_setup_101056_Perez_preload(1,true, 16, 5,0)
	pbadv_setup_101042_Moronoe_preload(true, 13, 9,0)
end
