

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	init_psbattleadv("201210000", "25010201")
	change_time_and_weather(BattleTime_Sunset,BattleWeather_Shiny)
	
	
	pbadv_setup_101009_Noir(2,true, 19, 1,0)  
	
	
	
	pbadv_setup_101011_Guinevere(0,true, 20, 1,0)  

	
	pbadv_setup_101016_Gwenhwymawr(0,true, 21, 1,0)  
	
	
	barbaroi = dot_reserve_enemy(1100, 19, 33, 0)
	barbaroi2 = dot_reserve_enemy(1100, 20, 33, 0)
	barbaroi3 = dot_reserve_enemy(1100, 21, 33, 0)
	barbaroi4 = dot_reserve_enemy(1100, 19, 34, 0)
	barbaroi5 = dot_reserve_enemy(1100, 20, 34, 0)
	barbaroi6 = dot_reserve_enemy(1100, 21, 34, 0)
	barbaroi7 = dot_reserve_enemy(1100, 19, 35, 0)
	barbaroi8 = dot_reserve_enemy(1100, 20, 35, 0)
	barbaroi9 = dot_reserve_enemy(1100, 21, 35, 0)
	

	Cal = dot_reserve_facility(52, 20, 0, DotDir_Down, 1, true)
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGwenhwymawr, 2)

	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotGuinevere,false)
	dot_disp_weapon(dotGwenhwymawr,false)
	
	dot_disp_facility(Cal,true)
	
	
	change_camera_distance(8.0, 0.0)

	change_camera_angle(25.0, 0.0)
	
	move_camera(20, 4, 0.0)
	

	Ef_Emblem01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)

	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)

	load_sound("BGM_ADV_Invasion2")

	load_image("10201011",  "content_still_10201011_image", "102010110_StillImage")
	show_image("10201011", 0.0, 0.0, 0 ,true,false)

end





function Play()
	fadein(0)
	Play_start(true)

	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180002")

	
	change_face(Guinevere, "Normal")
	message("MA_01104_180003")

	
	change_face(Guinevere, "Normal")
	message("MA_01104_180004")

	
	
	
	change_face(Guinevere, "Normal")
	message("MA_01104_180006")
	
    
    MA_01104_18_select1()

    open_select_window_tag(Noir2, "Normal", "MA_01104_180007", "MA_01104_180008")  
 	close_speech_window()

    if is_select(1) then            
        MA_01104_18_select1_1()

    else                            
        MA_01104_18_select1_2()

    end
    MA_01104_18_end()

end

function MA_01104_18_select1()

end

function MA_01104_18_select1_1()


	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180010")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180011")

	
	change_face(Guinevere, "Normal")
	message("MA_01104_180012")

	dot_unit_dir(dotGuinevere, 0)
	wait_time(0.5)
	dot_change_anim(dotGuinevere, 3)
	
	
	
	change_face(Guinevere, "Anger")
	message("MA_01104_180019")
	close_speech_window()

	wait_time(0.5)

	dot_change_anim(dotGuinevere, 0)
	wait_time(0.2)
	dot_unit_dir(dotGuinevere, 2)


      
end


function MA_01104_18_select1_2()



	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180014")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180015")

	
	
	change_face(Guinevere, "Normal")
	message("MA_01104_180017")

	dot_unit_dir(dotGuinevere, 0)
	wait_time(0.5)
	dot_change_anim(dotGuinevere, 3)

 	
	
	change_face(Guinevere, "Anger")
	message("MA_01104_180019")
	close_speech_window()

	wait_time(0.5)

	dot_change_anim(dotGuinevere, 0)
	wait_time(0.2)
	dot_unit_dir(dotGuinevere, 2)

	wait_time(0.5)

    
end




function MA_01104_18_end()
 

	
	
	change_face(Gwenhwymawr, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180021")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180022")

	
	change_face(Guinevere, "Sad")
	message("MA_01104_180023")

	
	change_face(Guinevere, "Normal")
	message("MA_01104_180024")
	


    MA_01104_18_select2()

    open_select_window_tag(Noir2, "Normal", "MA_01104_180025", "MA_01104_180026")  
	close_speech_window()

    if is_select(1) then            
        MA_01104_18_select2_1()

    else                            
        MA_01104_18_select2_2()

    end
	MA_01104_18_2_end()

end

function MA_01104_18_select2()

end

function MA_01104_18_select2_1()



	
	
	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180028")
	close_speech_window()

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180029")

	
	
	message("MA_01104_180030")
	close_speech_window()

      
end
 
 
function MA_01104_18_select2_2()
 


	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180032")
	close_speech_window()

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180033")

	
	change_face(Guinevere, "Normal")
	message("MA_01104_180034")
	close_speech_window()

	
	change_face(Gwenhwymawr, "Sad")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180035")
	close_speech_window()

    
end



function MA_01104_18_2_end()

	
	
	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_180037")
	close_speech_window()

	dot_unit_dir(dotNoir2, 2)
	wait_time(0.5)
	dot_unit_dir(dotNoir2, 3)
	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180038")
	close_speech_window()

	
	change_face(Gwenhwymawr, "Surprise")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180039")
	close_speech_window()

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180040")
	close_speech_window()

	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_180041")
	close_speech_window()

	
	change_face(Gwenhwymawr, "Sad")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180042")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_mind_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180043")
	close_mind_window()

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180044")
	close_speech_window()

	
	change_face(Gwenhwymawr, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180045")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180046")

	dot_reserve_move_unit_seq(dotGuinevere, 20, 2)
	dot_reserve_move_unit_seq(dotNoir2, 20, 1)
	
	
	exec_parallel_seq()

	
	wait_seq()

	dot_move_unit_seq(dotGuinevere, 19, 1)
	
	
	
	

	
	wait_seq()

	dot_unit_dir(dotGuinevere, 3)
	
	
	
	change_face(Guinevere, "Normal")
	message("MA_01104_180048")

 	dot_unit_dir(dotNoir2, 0)
	wait_time(0.5)
	dot_change_anim(dotNoir2, 3)
	
	
	
	change_face(Guinevere, "Anger")
	message("MA_01104_180050")
	close_speech_window()

	
	open_cutin(2, 1)
	
	on_cutin(1, Noir2, "Anger", 1)
	on_cutin(2, Guinevere, "Anger", 1)
	
	
	
	open_speech_window("CHRNAME_NOIR_GUINEVERE", nil, nil)
	message("MA_01104_180051")

	
	
	message("MA_01104_180052")

	
	
	open_speech_window("CHRNAME_NOIR_GUINEVERE", nil, nil)
	message("MA_01104_180053")
	close_speech_window()

	
	
	

	
	close_cutin()
	wait_time(0.5)
	
	on_active(Ef_Emblem01)

	
	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_Emblem01, locatorpos)

	
	
	
	play_particle(Ef_Emblem01)

	wait_time(1.5)

	stop_particle(Ef_Emblem01)

	wait_time(2.5)

	dot_change_anim(dotNoir2, 0)
	wait_time(0.2)
	dot_unit_dir(dotNoir2, 3)

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180055")
	close_speech_window()

	
	change_face(Gwenhwymawr, "Sad")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180056")
	close_speech_window()

	dot_unit_dir(dotNoir2, 2)

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180057")
	close_speech_window()

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180058")
	close_speech_window()

	


	on_active(Ef_Roar)

	
	local gridpos = get_grid_position(20, 10)
	set_pos(Ef_Roar, gridpos)
	set_scale(Ef_Roar, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Roar)

	wait_time(1.5)

	bgm_play("Stop_BGM_Bus_2")
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180060")
	close_speech_window()

	bgm_play("BGM_ADV_Invasion2")
	
	
	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MA_01104_180062")
	close_speech_window()

	move_camera(20, 35, 3.0)
	wait_camera()
	
	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180063")
	close_speech_window()

	move_camera(20, 4, 2.0)
	wait_camera()

	
	change_face(Gwenhwymawr, "Sad")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180064")
	close_speech_window()

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_180065")
	close_speech_window()

	
	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_180067")
	close_speech_window()

	dot_unit_dir(dotNoir2, 2)
	wait_time(0.5)
	dot_unit_dir(dotNoir2, 3)

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_180068")
	close_speech_window()

	
	change_face(Gwenhwymawr, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr, nil)
	message("MA_01104_180069")
	close_speech_window()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 19, 1,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 20, 1,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true, 21, 1,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	preload_sound("BGM_ADV_Invasion2")
	load_image_preload("10201011",  "content_still_10201011_image", "102010110_StillImage")
end
