

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	

	
	
	
	
	init_psbattleadv("201070000", "201070000")
	
	
	change_time_and_weather(1,7)
	
	
	
	
	
	
	

	
	pbadv_setup_101009_Noir(2,true,17,12,0)

	
	pbadv_setup_101010_Lancelot(3,true,16,11,0)

	
	pbadv_setup_101010_Lancelot(1,true,16,11,0)
	
	
	pbadv_setup_101028_Galahad(1,true,19,12,0)
	
	
	pbadv_setup_101036_Viena(1,true,18,11,0)
	
	
	

	
	


	
	

	
	
	
	
	
	
	
	
	
	
	
	
	barbaroi7 = dot_reserve_enemy(600, 21, 7, 0)
	
	barbaroi8= dot_reserve_enemy(600, 21, 5, 0)
	
	barbaroi9 = dot_reserve_enemy(600, 18, 4, 0)
	
	barbaroi10 = dot_reserve_enemy(506, 24, 4, 0)
	
	barbaroi11 = dot_reserve_enemy(506, 25, 6, 0)
	

	
	
	
	setup_complete_unit()

	
	
	
	
	
	
	

	
	
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotLancelot3, false)
	dot_disp_weapon(dotLancelot1, false)
	dot_disp_weapon(dotGalahad1, false)
	dot_disp_weapon(dotViena1, false)
	
	
	

	
	
	
	
	dot_disp_unit(dotLancelot1, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(21, 4, 0.0)
	
	
	Ef_Roar = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	
	
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)

	load_sound("BGM_Battle_AfterLancelot_General1_Start")

	load_image("10201013",  "content_still_10201013_image", "102010130_StillImage")
	show_image("10201013", 0.0, 0.0, 0 ,true,false)

end





function Play()
	fadein(0)
	Play_start(true)

	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)


	
	move_camera(17, 12, 2.5)
	
	wait_time(3.0)
	
	dot_unit_dir(dotGalahad1, 2)


	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","挨拶")
	message("MA_01B109_250002")
	



	change_face(Galahad1, "Normal")
	
	message("MA_01B109_250003")
	close_speech_window()

	dot_unit_dir(dotViena1, 2)



	change_face(Viena1, "Normal")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	 --PlayPartVoice("フィエナ","挨拶")
	message("MA_01B109_250004")
	

	
	
 
    
    MA_01B109_25_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B109_250005", "MA_01B109_250006")  
 
 	if is_select(1) then            
        MA_01B109_25_select1_1()

    else                            
        MA_01B109_25_select1_2()
 
    end
    MA_01B109_25_end()
 
end
 
function MA_01B109_25_select1()
 
end
 
function MA_01B109_25_select1_1()
 

 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","肯定2")
	message("MA_01B109_250008")
	



	change_face(Noir2, "Normal")
	
	message("MA_01B109_250009")
	



	change_face(Noir2, "Normal")
	
	message("MA_01B109_250010")
	close_speech_window()


 
      
end
 
 
function MA_01B109_25_select1_2()
 

 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","肯定2")
	message("MA_01B109_250012")
	



	change_face(Noir2, "Sad")
	
	message("MA_01B109_250013")
	close_speech_window()



	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	 --PlayPartVoice("フィエナ","驚き")
	message("MA_01B109_250014")
	close_speech_window()

 
    
end

function MA_01B109_25_end()


			

	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","驚き")
	message("MA_01B109_250016")
	



	change_face(Galahad1, "Normal")
	
	message("MA_01B109_250017")
	



	change_face(Galahad1, "Normal")
	
	message("MA_01B109_250018")
	



	change_face(Galahad1, "Sad")
	
	message("MA_01B109_250019")
	



	change_face(Galahad1, "Sad")
	
	 --PlayPartVoice("ガラハッド","挨拶")
	message("MA_01B109_250020")
	








    
    MA_01B109_25_2_select2()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B109_250021", "MA_01B109_250022", "MA_01B109_250023")  
 
    if is_select(1) then            
        MA_01B109_25_2_select2_1()
 
    elseif is_select(2) then        
        MA_01B109_25_2_select2_2()
 
    elseif is_select(3) then        
        MA_01B109_25_2_select2_3()
 
    end
    MA_01B109_25_2_select2_end()
 
end
 
function MA_01B109_25_2_select2()
 
end
 
function MA_01B109_25_2_select2_1()
 

 

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","驚き")
	message("MA_01B109_250025")
	close_speech_window()



	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","驚き")
	message("MA_01B109_250026")
	



	change_face(Galahad1, "Sad")
	
	message("MA_01B109_250027")
	
 
      
end
 
 
function MA_01B109_25_2_select2_2()
 

 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_250029")
	close_speech_window()



	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","怒り")
	message("MA_01B109_250030")
	



	change_face(Galahad1, "Normal")
	
	message("MA_01B109_250031")
	
 
    
end
 
 
function MA_01B109_25_2_select2_3()
 

     
	dot_unit_dir(dotNoir2, 2)
 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","肯定2")
	message("MA_01B109_250033")
	



	change_face(Noir2, "Normal")
	
	message("MA_01B109_250034")
	close_speech_window()



	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B109_250035")
	close_speech_window()



	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","納得")
	message("MA_01B109_250036")
	
 
 
        
end
 
 
function MA_01B109_25_2_select2_end()





	change_face(Galahad1, "Normal")
	
	message("MA_01B109_250038")
	



	change_face(Galahad1, "Normal")
	
	message("MA_01B109_250039")
	close_speech_window()
	
	move_camera(21, 4, 1.0)
	
	wait_time(1.0)
	
	
	dot_change_anim(barbaroi7,5)
	on_active(Ef_BriB )

	local gridpos = get_grid_position(21,7)
	set_pos(Ef_BriB , gridpos)
	play_particle(Ef_BriB )
	
	wait_time(1.0)
	
	dot_change_anim(barbaroi7,0)

	wait_time(1.0)

	move_camera(17, 12, 1.0)

	dot_unit_dir(dotViena1, 3)

	wait_time(1.5)
			

	change_face(Viena1, "Sad")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	 --PlayPartVoice("フィエナ","悲しみ")
	message("MA_01B109_250041")
	close_speech_window()

	dot_unit_dir(dotNoir2, 3)



	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_250043")
	close_speech_window()



	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","挨拶")
	message("MA_01B109_250044")
	close_speech_window()



	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","肯定2")
	message("MA_01B109_250045")
	


			

	change_face(Noir2, "Normal")
	
	message("MA_01B109_250047")
	


			

	change_face(Noir2, "Normal")
	
	message("MA_01B109_250049")
	


	change_face(Noir2, "Normal")
	
	message("MA_01B109_250051")
	
	

	change_face(Noir2, "Normal")
	
	message("MA_01B109_250052")
	close_speech_window()
			

	change_face(Lancelot3, "Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット","肯定")
	message("MA_01B109_250054")
	close_speech_window()



	change_face(Galahad1, "Surprise")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_250055")
	close_speech_window()



	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット","挨拶")
	message("MA_01B109_250056")
	close_speech_window()

	dot_unit_dir(dotViena1, 2)


	change_face(Viena1, "Surprise")
	open_speech_window("CHRNAME_VIENA2", Viena1, nil)
	 --PlayPartVoice("フィエナ","驚き")
	message("MA_01B109_250057")
	close_speech_window()



	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	 --PlayPartVoice("ガラハッド","肯定")
	message("MA_01B109_250058")
	close_speech_window()


	bgm_play("BGM_Battle_AfterLancelot_General1_Start")		

	change_face(Lancelot3, "Smile")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	 --PlayPartVoice("ランスロット","笑い")
	message("MA_01B109_250060")
	close_speech_window()


			

	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","笑い")
	message("MA_01B109_250062")
	
	
	dot_unit_dir(dotNoir2, 2)


	change_face(Noir2, "Normal")
	
	message("MA_01B109_250063")
	close_speech_window()
	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)
	
	on_active(Ef_Emblem2) 
	local locatorpos = dot_get_unit_locator(dotNoir2, 1)
	set_pos(Ef_Emblem2, locatorpos)

	on_active(Ef_Emblem1) 
	local locatorpos = dot_get_unit_locator(dotLancelot3, 1)
	set_pos(Ef_Emblem1, locatorpos)
	wait_time(2.0)
	
	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(16, 11)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(17,12)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)



	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B109_250064")
	close_speech_window()



	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_250066")
	close_speech_window()
	
	
	

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(16, 11)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	dot_change_unit(dotLancelot3, dotLancelot1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)
	
	wait_time(2.0)
	


	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B109_250068")
	close_speech_window()

	dot_unit_dir(dotNoir2, 3)


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B109_250069")
	close_speech_window()



	change_face(Lancelot1, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot1, nil)
	 --PlayPartVoice("ランスロット","肯定")
	message("MA_01B109_250070")
	close_speech_window()


			

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	 --PlayPartVoice("ノワール","肯定2")
	message("MA_01B109_250072")
	close_speech_window()




	

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,17,12,0)
	pbadv_setup_101010_Lancelot_preload(3,true,16,11,0)
	pbadv_setup_101010_Lancelot_preload(1,true,16,11,0)
	pbadv_setup_101028_Galahad_preload(1,true,19,12,0)
	pbadv_setup_101036_Viena_preload(1,true,18,11,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	preload_sound("BGM_Battle_AfterLancelot_General1_Start")
	load_image_preload("10201013",  "content_still_10201013_image", "102010130_StillImage")
end
