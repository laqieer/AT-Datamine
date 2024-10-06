
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	init_psbattleadv("201040000", "201040000")
	change_time_and_weather(1,1) 
	
	
	pbadv_setup_101009_Noir(2,true, 0, 5, 0)  
	pbadv_setup_101024_Bors(0,true, 2, 3, 0)  
	pbadv_setup_101025_Clare(0,true, 2, 5, 0)  
	pbadv_setup_101036_Viena(0,true, 0, 3, 0)  
	
				
	
	
	
	pbadv_setup_101042_Moronoe(true,11,4,0)  

	dotman1 = dot_reserve_ally(401011001, 22, 5, 0)
	dot_set_weapon(dotman1, 101010001)

	dotman2 = dot_reserve_ally(401011001, 23, 6, 0) 
	dot_set_weapon(dotman2, 101010001)

	dotman3 = dot_reserve_ally(401011001, 24, 5, 0) 
	dot_set_weapon(dotman3, 101010001)

	barbaroi1 = dot_reserve_enemy(1200, 23, 11, 0) 
	barbaroi2 = dot_reserve_enemy(1200, 24, 11, 0) 

	barbaroi5 = dot_reserve_enemy(304, 25, 11, 0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotman1, 2)
	dot_unit_dir(dotman2, 2)
	dot_unit_dir(dotman3, 2)

	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotBors, false)
	dot_disp_weapon(dotClare, false)
	dot_disp_weapon(dotViena, false)

	dot_disp_weapon(dotman1, false)
	dot_disp_weapon(dotman2, false)
	dot_disp_weapon(dotman3, false)


	
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi5, false)

	dot_disp_unit(dotMoronoe, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(6, 5, 0.0)

	
	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)

	Ef_Change1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	Ef_Change2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	Ef_Change3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)

	dot_move_height(dotMoronoe,7.5,0, 1)

	load_sound("BGM_Battle_AfterLancelot_General2_Start")
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	dot_reserve_move_unit_seq(dotBors, 6, 3)
	dot_reserve_move_unit_seq(dotClare, 6, 5)
	dot_reserve_move_unit_seq(dotNoir2, 4, 5)
	dot_reserve_move_unit_seq(dotViena, 4, 3)
	exec_parallel_seq()
	wait_seq()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	 --PlayPartVoice("ヴォールス", "納得")
	message("MA_01B110_240002")
	close_speech_window()

	
	
	
	move_camera(22, 6, 1.0)
	wait_camera()

	dot_reserve_move_unit_seq(dotman1, 19, 5, 0.5)
	dot_reserve_move_unit_seq(dotman2, 20, 6, 0.5)
	dot_reserve_move_unit_seq(dotman3, 21, 5, 0.5)
	exec_parallel_seq()

	wait_time(1.5)

	move_camera(5, 5, 1.0)
	wait_camera()
	wait_seq()

	
	change_face(Viena, "Surprise")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	 --PlayPartVoice("フィエナ", "驚き")
	message("MA_01B110_240004")
	close_speech_window()




    MA_01B110_24_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B110_240005", "MA_01B110_240006", "MA_01B110_240007")  
 
    if is_select(1) then            
        MA_01B110_24_select1_1()
 
    elseif is_select(2) then        
        MA_01B110_24_select1_2()
 
    elseif is_select(3) then        
        MA_01B110_24_select1_3()
 
    end
    MA_01B110_24_1_end()
 
end
 
function MA_01B110_24_select1()
 
end
 
function MA_01B110_24_select1_1()
 

 
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	 --PlayPartVoice("ノワール", "納得")
	message("MA_01B110_240009")
	close_speech_window()

	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	 --PlayPartVoice("フィエナ", "悩む")
	message("MA_01B110_240010")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	 --PlayPartVoice("ヴォールス", "肯定")
	message("MA_01B110_240011")
	

	
	
	change_face(Bors, "Normal")
	 --PlayPartVoice("ヴォールス", "落胆")
	message("MA_01B110_240021")
	close_speech_window()

 
      
end
 
 
function MA_01B110_24_select1_2()
 

 
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	
	message("MA_01B110_240013")
	close_speech_window()

	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	 --PlayPartVoice("フィエナ", "怒り")
	message("MA_01B110_240014")
	close_speech_window()

	
	change_face(Clare, "Anger")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	 --PlayPartVoice("クレア", "肯定")
	message("MA_01B110_240015")
	close_speech_window()

	
	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	 --PlayPartVoice("ヴォールス", "落胆")
	message("MA_01B110_240021")
	close_speech_window()


    
end
 
 
function MA_01B110_24_select1_3()
 

     
 
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	 --PlayPartVoice("ノワール", "肯定2")
	message("MA_01B110_240017")
	close_speech_window()

	
	change_face(Viena, "Anger")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	 --PlayPartVoice("フィエナ", "肯定3")
	message("MA_01B110_240018")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	 --PlayPartVoice("ヴォールス", "肯定")
	message("MA_01B110_240019")
	
 
	
	
	change_face(Bors, "Normal")
	 --PlayPartVoice("ヴォールス", "落胆")
	message("MA_01B110_240021")
	close_speech_window()

 
        
end
 
 
function MA_01B110_24_1_end()



	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	 --PlayPartVoice("モーロノエー", "挨拶")
	message("MA_01B110_240023")
	

	
	
	
	
	
	message("MA_01B110_240025")
	

	
	
	
	message("MA_01B110_240027")
	

	
	
	 --PlayPartVoice("モーロノエー", "笑い")
	message("MA_01B110_240028")
	

	
	
	
	message("MA_01B110_240029")
	close_speech_window()



    MA_01B110_24_select2()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B110_240030", "MA_01B110_240031")  
 
  if is_select(1) then            
        MA_01B110_24_select2_1()

    else                            
        MA_01B110_24_select2_2()

   end
    MA_01B110_24_2_end()
 
end
 
function MA_01B110_24_select2()
 
end
 
function MA_01B110_24_select2_1()


 
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	 --PlayPartVoice("ノワール", "肯定")
	message("MA_01B110_240033")
	close_speech_window()

	
	change_face(Viena, "Smile")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	 --PlayPartVoice("フィエナ", "肯定")
	message("MA_01B110_240034")
	close_speech_window()

	
	change_face(Moronoe, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	 --PlayPartVoice("モーロノエー", "笑い")
	message("MA_01B110_240035")
	close_speech_window()
 
      
end
 
 
function MA_01B110_24_select2_2()
 

 
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	 --PlayPartVoice("ノワール", "肯定")
	message("MA_01B110_240037")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	 --PlayPartVoice("ヴォールス", "肯定")
	message("MA_01B110_240038")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	 --PlayPartVoice("モーロノエー", "肯定")
	message("MA_01B110_240039")
	close_speech_window()
 
    
end

function MA_01B110_24_2_end()



	
	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	 --PlayPartVoice("クレア", "否定")
	message("MA_01B110_240041")
	

	
	change_face(Clare, "Normal")
	
	message("MA_01B110_240042")
	close_speech_window()

	
	change_face(Viena, "Surprise")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_240043")
	close_speech_window()

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	 --PlayPartVoice("クレア", "肯定")
	message("MA_01B110_240044")
	

	
	change_face(Clare, "Normal")
	
	message("MA_01B110_240045")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_240046")
	close_speech_window()

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	message("MA_01B110_240047")
	close_speech_window()

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_240048")
	close_speech_window()

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	message("MA_01B110_240049")
	close_speech_window()

	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_240050")
	close_speech_window()

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	message("MA_01B110_240051")
	

	
	change_face(Clare, "Normal")
	
	message("MA_01B110_240052")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_240053")
	close_speech_window()

	
	dot_move_unit_seq(dotBors, 5, 3)
	dot_move_unit_seq(dotBors, 5, 5)
	wait_seq()
	dot_unit_dir(dotBors, 2)

	dot_move_unit_seq(dotNoir2, 3, 5)
	dot_move_unit_seq(dotNoir2, 3, 3)
	wait_seq()
	dot_unit_dir(dotNoir2, 2)
	
	
	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_240055")
	close_speech_window()

	
	change_face(Clare, "Anger")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	 --PlayPartVoice("クレア", "否定")
	message("MA_01B110_240056")
	close_speech_window()

	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_240057")
	close_speech_window()

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	message("MA_01B110_240058")
	

	
	change_face(Clare, "Normal")
	
	message("MA_01B110_240059")
	close_speech_window()

	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_240060")
	close_speech_window()

	
	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	message("MA_01B110_240061")
	close_speech_window()

	
	change_face(Viena, "Sad")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	message("MA_01B110_240063")
	close_speech_window()

	
	dot_unit_dir(dotClare, 2)
	dot_unit_dir(dotBors, 3)
	wait_time(1.0)

	dot_move_unit_seq(dotBors, 2, 5)
	dot_move_unit_seq(dotBors, 2, 3)
	wait_seq()

	dot_unit_dir(dotClare, 3)
	dot_unit_dir(dotBors, 2)

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	 --PlayPartVoice("クレア", "肯定")
	message("MA_01B110_240065")
	close_speech_window()

	dot_unit_dir(dotNoir2, 3)

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",  Noir2, nil)
	message("MA_01B110_240066")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotman1, 9, 3)
	dot_reserve_move_unit_seq(dotman2, 9, 5)
	dot_reserve_move_unit_seq(dotman3, 10, 4)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotman3, 2)


    MA_01B110_24_select3()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B110_240067", "MA_01B110_240068", "MA_01B110_240069")  
 
    if is_select(1) then            
        MA_01B110_24_select3_1()
 
    elseif is_select(2) then        
        MA_01B110_24_select3_2()
 
    elseif is_select(3) then        
        MA_01B110_24_select3_3()
 
    end
    MA_01B110_24_3_end()
 
end
 
function MA_01B110_24_select3()
 
end
 
function MA_01B110_24_select3_1()
 

 

	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	 --PlayPartVoice("モーロノエー", "挨拶")
	message("MA_01B110_240071")
	
 
      
end
 
 
function MA_01B110_24_select3_2()
 


	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	 --PlayPartVoice("モーロノエー", "挨拶")
	message("MA_01B110_240071")
	
 
    
end
 
 
function MA_01B110_24_select3_3()
 

     
	
	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	 --PlayPartVoice("モーロノエー", "挨拶")
	message("MA_01B110_240071")
	
 
 
        
end
 
 
function MA_01B110_24_3_end()


	
	
	
	
	change_face(Moronoe, "Smile")
	
	message("MA_01B110_240072")
	close_speech_window()

	
	wait_time(1.0)
	dot_disp_weapon(dotBors, true)
	wait_time(0.5)

	bgm_play("Stop_BGM_Bus_MidFade")
	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_240074")
	
	bgm_play("BGM_Battle_AfterLancelot_General2_Start")
	
	change_face(Bors, "Normal")
	 --PlayPartVoice("ヴォールス", "肯定")
	message("MA_01B110_240075")
	close_speech_window()

	bgm_play("BGM_To_Main")

	change_face(Viena, "Surprise")
	open_speech_window("CHRNAME_VIENA",  Viena, nil)
	 --PlayPartVoice("フィエナ", "驚き")
	message("MA_01B110_240076")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotBors, 4, 4)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotBors, 2)

	dot_reserve_move_unit_seq(dotClare, 5, 5)
	dot_reserve_move_unit_seq(dotNoir2, 6, 4)
	dot_reserve_move_unit_seq(dotViena, 5, 3)
	exec_parallel_seq()
	wait_seq()

	dot_disp_weapon(dotClare, true)
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotViena, true)

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	 --PlayPartVoice("ヴォールス", "肯定2")
	message("MA_01B110_240078")
	

	
	change_face(Bors, "Normal")
	
	message("MA_01B110_240079")
	close_speech_window()

	
	on_active(Ef_WSpearAppea1) 

	local gridpos = get_grid_position(10, 3)
	gridpos[2] = 10.0 
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,90, 0, 0, 0.0) 
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)

	on_active(Ef_WitchSpear1) 

	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,30, 90, 0, 0.0) 
	play_particle(Ef_WitchSpear1)

	on_active(Ef_WSpearAura1) 

	set_pos(Ef_WSpearAura1, gridpos)
	turn(Ef_WSpearAura1,30, 90, 0, 0.0) 
	play_particle(Ef_WSpearAura1)

	wait_time(1.0)

	local gridpos = get_grid_position(7, 3) 
	gridpos[2] = 6.11

	slidemove(Ef_WitchSpear1, gridpos, 0.1) 
	slidemove(Ef_WSpearAura1, gridpos, 0.1) 

	wait_time(0.1)
	
	on_active(Ef_WitchSpearHit1) 

	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)

	wait_time(0.1)

	
	local gridpos = get_grid_position(11, 4) 
	gridpos[2] = 7.5

	slidemove(Ef_WitchSpear1, gridpos, 0.1, 2) 
	slidemove(Ef_WSpearAura1, gridpos, 0.1, 2) 

	wait_time(0.1)

	dot_change_anim(dotNoir2,0)

	
	dot_unit_dir(dotClare, 3)
	dot_unit_dir(dotBors, 3)

	
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",  Bors, nil)
	message("MA_01B110_240081")
	close_speech_window()

	
	change_face(Moronoe, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",  nil, Moronoe)
	 --PlayPartVoice("モーロノエー", "肯定3")
	message("MA_01B110_240082")
	close_speech_window()


	
	
	move_camera(7, 5, 1.0)
	wait_camera()

	dot_unit_dir(dotman3, 2)

	turn(Ef_WitchSpear1,95, 0, 0, 1.0) 
	turn(Ef_WSpearAura1,95, 0, 0, 1.0) 
	
	wait_time(1.5)

	on_active(Ef_BlFeather)
	on_active(Ef_WitchChange1)

	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)

	set_pos(Ef_WitchChange1, gridpos)
	play_particle(Ef_WitchChange1)

	wait_time(0.5)
	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)

	wait_time(0.5)
	dot_disp_unit(dotMoronoe, true)

	wait_time(2.0)

	dot_move_height(dotMoronoe, 6.11, 2.0, 2)

	on_active(Ef_Change1)
	on_active(Ef_Change2)
	on_active(Ef_Change3)

	local gridpos = get_grid_position(9, 3)
	set_pos(Ef_Change1, gridpos)
	play_particle(Ef_Change1)

	local gridpos = get_grid_position(9, 5)
	set_pos(Ef_Change2, gridpos)
	play_particle(Ef_Change2)

	local gridpos = get_grid_position(10, 4)
	set_pos(Ef_Change3, gridpos)
	play_particle(Ef_Change3)

	wait_time(1.0)

	dot_change_unit(dotman1, barbaroi1, 0.0)
	dot_change_unit(dotman2, barbaroi2, 0.0)
	dot_change_unit(dotman3, barbaroi5, 0.0)

	wait_time(2.0)

	
	change_face(Clare, "Normal")
	open_speech_window("CHRNAME_CLARE",  Clare, nil)
	 --PlayPartVoice("クレア", "肯定2")
	message("MA_01B110_240084")
	close_speech_window()

	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 0, 5, 0)
	pbadv_setup_101024_Bors_preload(0,true, 2, 3, 0)
	pbadv_setup_101025_Clare_preload(0,true, 2, 5, 0)
	pbadv_setup_101036_Viena_preload(0,true, 0, 3, 0)
	pbadv_setup_101042_Moronoe_preload(true,11,4,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	preload_sound("BGM_Battle_AfterLancelot_General2_Start")
end
