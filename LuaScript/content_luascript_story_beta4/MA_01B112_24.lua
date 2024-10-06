


Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	init_psbattleadv("201130000", "201130000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)
	
	
	
	
    pbadv_setup_101009_Noir(2,true,20,10,0)
    
    
    pbadv_setup_101010_Lancelot(3,true,19,10,0)    
	
    
    pbadv_setup_101010_Lancelot(1,true,19,10,0)	
	
    
    pbadv_setup_101026_Percival(0,true,23,12,0)

    
    pbadv_setup_101027_Dindrane(0,true,22,12,0)    
    
    
    pbadv_setup_101027_Dindrane(2,true,22,12,0)	
	
	
    pbadv_setup_101028_Galahad(1,true,21,9,0)
    
    
    pbadv_setup_101036_Viena(0,true,22,9,0)
    
    
    pbadv_setup_101036_Viena(1,true,22,9,0)
    
    
    pbadv_setup_101024_Bors(0,true,19,12,0)

    
    pbadv_setup_101025_Clare(0,true,20,12,0)
    
    
    pbadv_setup_101025_Clare(1,true,20,12,0)
    
    
    pbadv_setup_101029_Astera(0,true,21,0,0)
    
    
    pbadv_setup_101029_Astera(1,true,21,0,0)
    
    
    pbadv_setup_101015_Arthur(0,true,21,13,0)
    
	
	
	
	
	barbaroi1 = dot_reserve_enemy(1204, 17, 1, 0)
	barbaroi2 = dot_reserve_enemy(1204, 18, 3, 0)
	barbaroi3 = dot_reserve_enemy(1, 17, 4, 0)
	barbaroi4 = dot_reserve_enemy(1, 19, 4, 0)
	barbaroi5 = dot_reserve_enemy(1204, 25, 1, 0)
	barbaroi6 = dot_reserve_enemy(1204, 24, 3, 0)
	barbaroi7 = dot_reserve_enemy(1, 25, 4, 0)
	barbaroi8 = dot_reserve_enemy(1, 23, 4, 0)

	barbaroi9 = dot_reserve_enemy(1, 18, 7, 0)
	barbaroi10 = dot_reserve_enemy(1, 19, 6, 0)
	barbaroi11 = dot_reserve_enemy(1, 24, 7, 0)
	barbaroi12 = dot_reserve_enemy(1, 23, 6, 0)
	
	
	
	setup_complete_unit()

	
	
	
	
	
	
	
	dot_unit_dir(dotAstera, 2)
	dot_unit_dir(dotAstera1, 2)
	dot_unit_dir(dotGalahad1, 1)
	dot_unit_dir(dotViena, 2)
	dot_unit_dir(dotViena1, 2)
	dot_unit_dir(dotPercival, 2)
	dot_unit_dir(dotDindrane, 2)
	dot_unit_dir(dotDindrane2, 2)
	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dotDindrane, false)
	dot_disp_weapon(dotGalahad1, false)
	dot_disp_weapon(dotViena, false)
	dot_disp_weapon(dotBors, false)
	dot_disp_weapon(dotClare, false)
	dot_disp_weapon(dotAstera, false)
	dot_disp_weapon(dotArthur, false)
	
	
	
	
	dot_disp_unit(dotAstera, false)	
	dot_disp_unit(dotAstera1, false)
	dot_disp_unit(dotLancelot1, false)	
	dot_disp_unit(dotDindrane2, false)	
	dot_disp_unit(dotViena1, false)
	dot_disp_unit(dotClare1, false)
	dot_disp_unit(barbaroi9, false)	
	dot_disp_unit(barbaroi10, false)	
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(45.0, 0.0)

	
	
	move_camera(21,10, 0)
	
	
		
	Ef_Killers1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Killers2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Killers3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Killers4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Killers5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 
	Ef_Emblem3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true) 
	Ef_Emblem4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true) 
	Ef_Emblem5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true) 
	Ef_Emblem6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true) 
	Ef_Emblem7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true) 
	Ef_Emblem8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true) 
	Ef_Emblem9 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem14", false, true) 
	
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 


	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

end



function Play()
	fadein(0)
	Play_start(true)

	wait_time(1.5)

	dot_disp_unit(dotAstera, true)	
	dot_move_unit_seq(dotAstera, 21,2)

	change_camera_angle(45.0, 2.0)
	move_camera(21, 1, 2.0)

	wait_seq()

	dot_unit_dir(dotAstera, 2)
	wait_camera()

	

	change_face(Astera, "Normal")
	open_speech_window("CHRNAME_ASTERA", nil, Astera)
	 --PlayPartVoice("アステラ", "挨拶")
	message("MA_01B112_240002")
	close_speech_window()

	dot_disp_weapon(dotAstera, true)	

	change_camera_angle(25.0, 2.5)
	move_camera(21,10, 2.5)	
	wait_camera()


	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_240004")
	close_speech_window()
	
	dot_disp_weapon(dotGalahad1, true)	
				

	change_face(Astera, "Normal")
	open_speech_window("CHRNAME_ASTERA", nil, Astera)
	message("MA_01B112_240006")
	close_speech_window()	
	

	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	 --PlayPartVoice("フィエナ", "激怒")
	message("MA_01B112_240007")
	close_speech_window()	



	move_camera(21,1, 1)	
	wait_camera()

	
	
	on_active(Ef_Emblem9)

	local locatorpos = dot_get_unit_locator(dotAstera,1)
	set_pos(Ef_Emblem9, locatorpos)

	play_particle(Ef_Emblem9)

	wait_time(1.0)

	on_active(Ef_Killers5)

	local gridpos = get_grid_position(21, 2)
	set_pos(Ef_Killers5, gridpos)
	play_particle(Ef_Killers5)

	wait_time(1.5)

	on_active(Ef_KillChan5)

	local gridpos = get_grid_position(21, 2)
	set_pos(Ef_KillChan5, gridpos)
	play_particle(Ef_KillChan5)

	wait_time(0.7)
	
	dot_change_unit(dotAstera, dotAstera1, 0)

	wait_time(1.0)

	stop_particle(Ef_Killers5)

	wait_time(0.5)

	move_camera(21,11, 1)	
	dot_move_unit_seq(dotAstera1, 21,6)
	wait_seq()

	dot_unit_dir(dotAstera1, 2)
	wait_camera()




	change_face(Astera1, "Special")
	debug_print("TEST")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	 --PlayPartVoice("アステラ", "肯定2")
	message("MA_01B112_240009")
	close_speech_window()	


	on_active(Ef_bar1) 

	local gridpos = get_grid_position(18, 7) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)


	on_active(Ef_bar2) 

	local gridpos = get_grid_position(19, 6) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)


	on_active(Ef_bar3) 

	local gridpos = get_grid_position(24, 7) 
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar3)


	on_active(Ef_bar4) 

	local gridpos = get_grid_position(23, 6) 
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar4)

	wait_time(0.2)

	dot_disp_unit(barbaroi9, true)	
	dot_disp_unit(barbaroi10, true)	
	dot_disp_unit(barbaroi11, true)	
	dot_disp_unit(barbaroi12, true)	

	wait_time(2.0)


	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_240011")
	close_speech_window()	
	

	change_face(Astera1, "Anger")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	message("MA_01B112_240012")
	
	

	change_face(Astera1, "Anger")
	
	message("MA_01B112_240013")
	close_speech_window()	
	

	change_face(Arthur, "Serious")
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	 --PlayPartVoice("アーサー", "肯定2")
	message("MA_01B112_240014")
	close_speech_window()	
			

	change_face(Bors, "Smile")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	 --PlayPartVoice("ヴォールス", "笑い")
	message("MA_01B112_240016")
	close_speech_window()	
	

	change_face(Percival, "Smile")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	 --PlayPartVoice("パーシヴァル", "笑い")
	message("MA_01B112_240017")
	close_speech_window()	
			

	change_face(Clare, "Smile")
	open_speech_window("CHRNAME_CLARE", Clare, nil)
	 --PlayPartVoice("クレア", "笑い")
	message("MA_01B112_240019")
	close_speech_window()	
	
	dot_unit_dir(dotDindrane, 3)
	

	change_face(Dindrane, "Normal")
	open_speech_window("CHRNAME_DINDRANE", Dindrane, nil)
	 --PlayPartVoice("ディンドラン", "落胆")
	message("MA_01B112_240020")
	close_speech_window()	
	

	change_face(Percival, "Smile")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	 --PlayPartVoice("パーシヴァル", "肯定2")
	message("MA_01B112_240021")
	close_speech_window()	
	

	change_face(Dindrane, "Normal")
	open_speech_window("CHRNAME_DINDRANE", Dindrane, nil)
	 --PlayPartVoice("ディンドラン", "笑い")
	message("MA_01B112_240022")
	close_speech_window()	
	
	dot_unit_dir(dotPercival, 2)
	

	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("MA_01B112_240023")
	close_speech_window()	
	

	change_face(Dindrane, "Smile")
	open_speech_window("CHRNAME_DINDRANE", Dindrane, nil)
	 --PlayPartVoice("ディンドラン", "肯定")
	message("MA_01B112_240024")
	close_speech_window()

	bgm_play("BGM_To_Main")
	
	dot_unit_dir(dotDindrane, 2)

	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)
	on_active(Ef_Emblem3)
	on_active(Ef_Emblem4)
	on_active(Ef_Emblem5)
	on_active(Ef_Emblem6)
	on_active(Ef_Emblem7)
	on_active(Ef_Emblem8)


	local locatorpos = dot_get_unit_locator(dotLancelot3,1)
	set_pos(Ef_Emblem1, locatorpos)

	play_particle(Ef_Emblem1)


	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_Emblem2, locatorpos)

	play_particle(Ef_Emblem2)


	local locatorpos = dot_get_unit_locator(dotDindrane,1)
	set_pos(Ef_Emblem3, locatorpos)

	play_particle(Ef_Emblem3)


	local locatorpos = dot_get_unit_locator(dotPercival,1)
	set_pos(Ef_Emblem4, locatorpos)

	play_particle(Ef_Emblem4)


	local locatorpos = dot_get_unit_locator(dotClare,1)
	set_pos(Ef_Emblem5, locatorpos)

	play_particle(Ef_Emblem5)


	local locatorpos = dot_get_unit_locator(dotBors,1)
	set_pos(Ef_Emblem6, locatorpos)

	play_particle(Ef_Emblem6)


	local locatorpos = dot_get_unit_locator(dotViena,1)
	set_pos(Ef_Emblem7, locatorpos)

	play_particle(Ef_Emblem7)


	local locatorpos = dot_get_unit_locator(dotGalahad1,1)
	set_pos(Ef_Emblem8, locatorpos)

	play_particle(Ef_Emblem8)

	wait_time(1.0)

	on_active(Ef_Killers1)
	on_active(Ef_Killers2)
	on_active(Ef_Killers3)
	on_active(Ef_Killers4)
	on_active(Ef_Vibes1)
	on_active(Ef_Vibes2)
	on_active(Ef_Vibes3)
	on_active(Ef_Vibes4)

	local gridpos = get_grid_position(19, 10)
	set_pos(Ef_Killers1, gridpos)
	play_particle(Ef_Killers1)

	local gridpos = get_grid_position(20, 10)
	set_pos(Ef_Vibes1, gridpos)
	play_particle(Ef_Vibes1)

	local gridpos = get_grid_position(22, 12)
	set_pos(Ef_Killers2, gridpos)
	play_particle(Ef_Killers2)

	local gridpos = get_grid_position(23, 12)
	set_pos(Ef_Vibes2, gridpos)
	play_particle(Ef_Vibes2)

	local gridpos = get_grid_position(20, 12)
	set_pos(Ef_Killers3, gridpos)
	play_particle(Ef_Killers3)

	local gridpos = get_grid_position(19, 12)
	set_pos(Ef_Vibes3, gridpos)
	play_particle(Ef_Vibes3)

	local gridpos = get_grid_position(22, 9)
	set_pos(Ef_Killers4, gridpos)
	play_particle(Ef_Killers4)

	local gridpos = get_grid_position(21, 9)
	set_pos(Ef_Vibes4, gridpos)
	play_particle(Ef_Vibes4)

	wait_time(1.5)

	on_active(Ef_KillChan1)
	on_active(Ef_KillChan2)
	on_active(Ef_KillChan3)
	on_active(Ef_KillChan4)

	local gridpos = get_grid_position(19, 10)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	local gridpos = get_grid_position(22, 12)
	set_pos(Ef_KillChan2, gridpos)
	play_particle(Ef_KillChan2)

	local gridpos = get_grid_position(20, 12)
	set_pos(Ef_KillChan3, gridpos)
	play_particle(Ef_KillChan3)

	local gridpos = get_grid_position(22, 9)
	set_pos(Ef_KillChan4, gridpos)
	play_particle(Ef_KillChan4)

	wait_time(0.7)

	dot_change_unit(dotLancelot3, dotLancelot1, 0)
	dot_change_unit(dotDindrane, dotDindrane2, 0)
	dot_change_unit(dotViena, dotViena1, 0)
	dot_change_unit(dotClare, dotClare1, 0)

	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotPercival, true)
	dot_disp_weapon(dotBors, true)


	wait_time(1.5)

	stop_particle(Ef_Killers1)
	stop_particle(Ef_Killers2)
	stop_particle(Ef_Killers3)
	stop_particle(Ef_Killers4)

	stop_particle(Ef_Vibes1)
	stop_particle(Ef_Vibes2)
	stop_particle(Ef_Vibes3)
	stop_particle(Ef_Vibes4)


	wait_time(1.0)	
	
	
    MA_01B112_24_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B112_240025", "MA_01B112_240026")  
	
	
    if is_select(1) then            
        MA_01B112_24_select1_1()

    else                            
        MA_01B112_24_select1_2()

    end
    MA_01B112_24_end()
    
end
 
function MA_01B112_24_select1()
 
end
 
function MA_01B112_24_select1_1()
 

 
 	dot_unit_dir(dotNoir2, 2)
 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_240028")
	close_speech_window()	
	

	change_face(Lancelot1, "Smile")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	 --PlayPartVoice("ランスロット", "肯定")
	message("MA_01B112_240029")

	change_face(Lancelot1, "Normal")

	message("MA_01B112_240030")
	close_speech_window()	
	 
	 dot_unit_dir(dotNoir2, 3)
	 
      
end
 
 
function MA_01B112_24_select1_2()
 

 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B112_240032")
	close_speech_window()	
	
	dot_unit_dir(dotGalahad1, 2)
	

	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_240033")
	
	
	

	change_face(Galahad1, "Normal")
	
	message("MA_01B112_240034")
	close_speech_window()	
	
	dot_unit_dir(dotGalahad1, 3)

    
end



function MA_01B112_24_end()    		
	
			

	change_face(Viena1, "Anger")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	 --PlayPartVoice("フィエナ", "肯定")
	message("MA_01B112_240036")
	close_speech_window()	
	

	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド", "肯定3")
	message("MA_01B112_240037")
	close_speech_window()	
	
	
	se_play("SE_ADV_Emy001_Cry")
	wait_time(1.0)
	
	open_cutin(1,1)
	
	on_cutin(1,Astera1, "Smile") 

	
	


	open_speech_window("CHRNAME_ASTERA2", nil, nil)
	 --PlayPartVoice("アステラ", "笑い")
	message("MA_01B112_240039")
	close_speech_window()	
	

	
	close_cutin()



	change_face(Galahad1, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B112_240040")
	
	

	change_face(Galahad1, "Anger")
	
	 --PlayPartVoice("ガラハッド", "気合い")
	message("MA_01B112_240041")
	close_speech_window()	
	

	change_face(Astera1, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera1)
	 --PlayPartVoice("アステラ", "肯定2")
	message("MA_01B112_240042")
	
	

	change_face(Astera1, "Anger")
	
	message("MA_01B112_240043")
	close_speech_window()
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,20,10,0)
    pbadv_setup_101010_Lancelot_preload(3,true,19,10,0)
    pbadv_setup_101010_Lancelot_preload(1,true,19,10,0)
    pbadv_setup_101026_Percival_preload(0,true,23,12,0)
    pbadv_setup_101027_Dindrane_preload(0,true,22,12,0)
    pbadv_setup_101027_Dindrane_preload(2,true,22,12,0)
    pbadv_setup_101028_Galahad_preload(1,true,21,9,0)
    pbadv_setup_101036_Viena_preload(0,true,22,9,0)
    pbadv_setup_101036_Viena_preload(1,true,22,9,0)
    pbadv_setup_101024_Bors_preload(0,true,19,12,0)
    pbadv_setup_101025_Clare_preload(0,true,20,12,0)
    pbadv_setup_101025_Clare_preload(1,true,20,12,0)
    pbadv_setup_101029_Astera_preload(0,true,21,0,0)
    pbadv_setup_101029_Astera_preload(1,true,21,0,0)
    pbadv_setup_101015_Arthur_preload(0,true,21,13,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem10", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem17", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem14", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
end
