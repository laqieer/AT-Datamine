
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	load_image("102020060",  "content_still_10202006_image", "102020060_StillImage")
show_image("102020060", 0.0, 0.0, 0 ,true,false)
	
	init_psbattleadv("201060001", "201060001")
	change_time_and_weather(1,1) 

	
	pbadv_setup_101009_Noir(2,true, 28, 20,0)  
	pbadv_setup_101026_Percival(0,true, 29, 20,0)  

	
	dani = dot_reserve_ally(401005001, 30,  19, 0)
	dot_set_weapon(dani, 101010005)		
	
	jan = dot_reserve_ally(401005001, 30,  21, 0)
	dot_set_weapon(jan, 101010005)		
	
	barbaroi1 = dot_reserve_enemy(1, 18, 21, 0)
	barbaroi2 = dot_reserve_enemy(1, 17, 20, 0)
	barbaroi3 = dot_reserve_enemy(1, 17, 22, 0)
	
	barbaroi4 = dot_reserve_enemy(1, 29, 26, 0)
	

setup_complete_unit()


	
	dot_unit_dir(dotPercival, 2)
	dot_unit_dir(dani, 2)
	dot_unit_dir(jan, 2)
	dot_unit_dir(barbaroi1, 3)
	dot_unit_dir(barbaroi2, 3)
	dot_unit_dir(barbaroi3, 3)

	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotPercival, false)
	dot_disp_weapon(dani, false)
	dot_disp_weapon(jan, false)


	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)

	



	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(40.0, 0.0)
	move_camera(29, 20, 0.0)
	
	
	FriendshipUp = set_friendship_up(false)        
	trustParam = set_communication("パーシヴァル_コミュランク", "パーシヴァル_親密度")    

	load_sound("BGM_ADV_Antagonism")
	load_sound("BGM_ADV_Reconnaissance")
end



function Play()
	fadein(0)
	Play_start(true)
	
	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "肯定")
	message("CO_101026_07020002")
	
	change_face(Percival, "Normal")
	message("CO_101026_07020003")
	
	
	
	
	
    
    CO_101026_0702_select1()
 
    open_select_window_tag(Noir2, "Normal", "CO_101026_07020005", "CO_101026_07020006")  
 	close_speech_window()

	
	trustParam.UpdateRankup()    
    
    if is_select(1) then            
        CO_101026_0702_select1_1()
 
    elseif is_select(2) then        
        CO_101026_0702_select1_2()
 

    end
    CO_101026_0702_end()
 
end
 
function CO_101026_0702_select1()
 
end
 
function CO_101026_0702_select1_1()
 


	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101026_07020008")
	close_speech_window()

	
	
    
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)

	message("CO_101026_07020009")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "否定")
	message("CO_101026_07020010")
	close_speech_window()

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "肯定")
	message("CO_101026_07020011")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "落胆")
	message("CO_101026_07020012")
	close_speech_window()

 
      
end
 
 
function CO_101026_0702_select1_2()
 

 
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101026_07020014")
	close_speech_window()

	
	
	
	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "笑い")
	message("CO_101026_07020015")
	close_speech_window()

	
	open_speech_window("NPCNAME_0243", nil, nil)
	PlayPartVoice("男子1", "笑い")
	message("CO_101026_07020016")
	close_speech_window()

	
	open_speech_window("NPCNAME_0246", nil, nil)
	message("CO_101026_07020017")
	close_speech_window()
 
    
end
 
function CO_101026_0702_end()	
	


	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "悩む")
	message("CO_101026_07020019")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101026_07020020")
	close_speech_window()
	
	
	fadeout(0,0,0,1.0, FADE_TIME)
	
		
	dot_reserve_move_unit_seq(dotNoir2, 20, 19)
	dot_reserve_move_unit_seq(dotPercival, 29, 30)
	dot_reserve_move_unit_seq(dani, 30, 31)
	dot_reserve_move_unit_seq(jan, 30, 32)
	
	exec_parallel_seq()
	wait_seq()
	
	
	
	


	wait_time(FADE_TIME)
	

	
	
	dot_disp_unit(dotPercival, false)
	dot_disp_unit(dani, false)
	dot_disp_unit(jan, false)
	
	
	dot_place_unit(dotNoir2,28, 20,0)

	
	
	wait_time(0.1)

	
	wait_time(0.2)
	
	
	dot_unit_dir(dotNoir2, 3)
	
	fadein(FADE_TIME)

	wait_time(FADE_TIME)	

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "悩む")
	message("CO_101026_07020022")
	close_speech_window()
	
	
	
	dot_disp_unit(dotPercival, true)
	dot_disp_unit(dani, true)
	dot_disp_unit(jan, true)
	
	dot_reserve_move_unit_seq(dotPercival, 29, 22)
	dot_reserve_move_unit_seq(dani, 29,  21)
	dot_reserve_move_unit_seq(jan, 29,  23)
	
	exec_parallel_seq()
	wait_seq()

	dot_reserve_move_unit_seq(dotPercival, 29, 20)
	dot_reserve_move_unit_seq(dani, 30,  19)
	dot_reserve_move_unit_seq(jan, 30,  21)
	
	exec_parallel_seq()
	wait_seq()
	
	
	dot_unit_dir(dotPercival, 2)
	dot_unit_dir(dani, 2)
	dot_unit_dir(jan, 2)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101026_07020024")
	
	change_face(Noir2, "Normal")
	message("CO_101026_07020025")
	close_speech_window()

	
	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "落胆")
	message("CO_101026_07020026")
	
	change_face(Percival, "Normal")
	message("CO_101026_07020027")
	
	
	
	
    
    CO_101026_0702_select2()
 
    open_select_window_tag(Noir2, "Normal", "CO_101026_07020029", "CO_101026_07020030")  
	close_speech_window()
 
    if is_select(1) then            
        CO_101026_0702_select2_1()
 
    elseif is_select(2) then        
        CO_101026_0702_select2_2()
 
    end
    CO_101026_0702_2_end()
 
end
 
function CO_101026_0702_select2()
 
end
 
function CO_101026_0702_select2_1()
 


	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "否定")
	message("CO_101026_07020032")
	close_speech_window()

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "肯定")
	message("CO_101026_07020033")
	
	change_face(Percival, "Normal")
	message("CO_101026_07020034")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101026_07020042")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")

 
      
end
 
 
function CO_101026_0702_select2_2()
 

 
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101026_07020036")
	close_speech_window()
	
	dot_unit_dir(dani, 3)
	dot_unit_dir(jan, 3)
	wait_time(2.0)
	dot_unit_dir(dotPercival, 3)
	wait_time(2.0)
	dot_unit_dir(dotPercival, 2)

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "否定")
	message("CO_101026_07020038")
	
	change_face(Percival, "Normal")
	message("CO_101026_07020039")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101026_07020040")
	
	change_face(Noir2, "Normal")
	message("CO_101026_07020042")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_2")
 
    
end
 
function CO_101026_0702_2_end()	
		
	
	dot_disp_unit(barbaroi1, true)
	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)

	
	move_camera(21, 20, 0.8)
	
	
	dot_reserve_move_unit_seq(barbaroi1, 21, 20)
	dot_reserve_move_unit_seq(barbaroi2, 20, 19)
	dot_reserve_move_unit_seq(barbaroi3, 20, 21)
	
	exec_parallel_seq()
	wait_seq()
	
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotPercival, 2)
	dot_unit_dir(dani, 2)
	dot_unit_dir(jan, 2)
	
	
	wait_time(1.5)
	
	
	move_camera(29, 20, 0.7)
	wait_camera()	

	bgm_play("BGM_ADV_Antagonism")
	
	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "驚き")
	message("CO_101026_07020044")
	
	dot_unit_dir(dotPercival, 3)
	
	
	change_face(Percival, "Anger")
	message("CO_101026_07020046")
	close_speech_window()

	dot_unit_dir(dotPercival, 2)

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101026_07020048")
	close_speech_window()
	





	
	move_camera(21, 20, 0.8)


	
	dot_reserve_move_unit_seq(dotPercival, 22, 21)
	dot_reserve_move_unit_seq(dotNoir2, 22, 19)
	
	exec_parallel_seq()
	wait_seq()

	
	dot_disp_weapon(dotNoir2, true)
	dot_disp_weapon(dotPercival, true)

	dot_unit_dir(dotPercival, 2)

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "笑い")
	message("CO_101026_07020050")
	
	change_face(Percival, "Normal")
	message("CO_101026_07020051")
	
	change_face(Percival, "Normal")
	message("CO_101026_07020052")
	close_speech_window()
	
	
	dot_attack_seq(dotPercival, barbaroi3)
	dot_damage_seq(barbaroi3, dotPercival, true)
	
		
	wait_seq()
	
	
	dot_change_anim(barbaroi3,6)

	wait_time(0.2)

	dot_dying_unit_seq(barbaroi3)

	
	

	
	move_camera(30, 20, 0.7)
	wait_camera()

	
	open_speech_window("NPCNAME_0243", nil, nil)
	message("CO_101026_07020054")
	close_speech_window()
	

	dot_change_anim(dotPercival, 0)

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("CO_101026_07020056")
	close_speech_window()
	
	
	move_camera(30, 22, 0.7)
	
	
	dot_disp_unit(barbaroi4, true)
	dot_reserve_move_unit_seq(barbaroi4, 30, 22)	
	
	exec_parallel_seq()
	wait_seq()

	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("CO_101026_07020057")
	close_speech_window()
	
	
	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "驚き")
	message("CO_101026_07020059")
	close_speech_window()
	
	dot_reserve_move_unit_seq(dotPercival, 28, 22)	
	dot_reserve_move_unit_seq(dotNoir2, 28, 21)	
	
	exec_parallel_seq()
	wait_seq()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "悲しみ")
	message("CO_101026_07020061")
	close_speech_window()
	
	
	dot_attack_seq(barbaroi4, jan)
	dot_damage_seq(jan, barbaroi4, true)
	
		
	wait_seq()
	
	
	dot_change_anim(jan,1)


	
	open_speech_window("NPCNAME_0243", nil, nil)
	PlayPartVoice("男子1", "苦しみ")
	message("CO_101026_07020063")
	close_speech_window()
	
	
	dot_attack_seq(dotPercival, barbaroi4)
	dot_damage_seq(barbaroi4, dotPercival, true)
	
		
	wait_seq()
	
	
	dot_change_anim(barbaroi4,6)

	wait_time(0.2)

	dot_dying_unit_seq(barbaroi4)

	
	
	dot_change_anim(dotPercival, 0)

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	message("CO_101026_07020064")
	close_speech_window()
	
	
	dot_reserve_move_unit_seq(dani, 30, 20)
	
	exec_parallel_seq()
	wait_seq()
	
	
	dot_unit_dir(dani, 2)	

	
	open_speech_window("NPCNAME_0246", nil, nil)
	PlayPartVoice("男子2", "悲しみ")
	message("CO_101026_07020066")
	close_speech_window()
	
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotPercival, 2)
	
	
	wait_time(0.5)

	
	change_face(Percival, "Anger")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoiceDirect("パーシヴァル","0026")
	message("CO_101026_07020067")
	
	change_face(Percival, "Anger")
	PlayPartVoice("パーシヴァル", "気合い")
	message("CO_101026_07020068")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	
	fadeout(0,0,0,1.0, FADE_TIME)
	
	
	dot_reserve_move_unit_seq(dotPercival, 22, 21)
	dot_reserve_move_unit_seq(dotNoir2, 22, 19)
	
	exec_parallel_seq()
	wait_seq()	

	wait_time(0.3)
	
	
	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)



	
	dot_place_unit(dani,30,20)
	dot_place_unit(dotNoir2,28, 20)
	dot_place_unit(dotPercival,28, 21)		
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotPercival, false)
	
	dot_change_anim(dani,0)	
	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotPercival,0)
	
	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotPercival, 3)
	
	
	move_camera(29, 20, 0.0)
	
	wait_time(0.5)
        
	fadein(FADE_TIME)

	wait_time(FADE_TIME)	

	bgm_play("BGM_ADV_Reconnaissance")
	
	open_speech_window("NPCNAME_0246", nil, nil)
	PlayPartVoice("男子2", "悲しみ")
	message("CO_101026_07020070")
	close_speech_window()

	dot_change_anim(dotPercival,1)

	
	change_face(Percival, "Sad")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "悲しみ")
	message("CO_101026_07020071")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101026_07020072")
	close_speech_window()

	dot_change_anim(dotPercival,0)

	
	change_face(Percival, "Normal")
	open_speech_window("CHRNAME_PERCIVAL", Percival, nil)
	PlayPartVoice("パーシヴァル", "驚き")
	message("CO_101026_07020073")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("CO_101026_07020074")
	close_speech_window()


	local trustParam2 = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")    
	trustParam2.UpdateRankup()    
	open_trust_rank_up(Percival, trustParam2)    
	

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("102020060",  "content_still_10202006_image", "102020060_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 28, 20,0)
	pbadv_setup_101026_Percival_preload(0,true, 29, 20,0)
	preload_sound("BGM_ADV_Antagonism")
	preload_sound("BGM_ADV_Reconnaissance")
end
