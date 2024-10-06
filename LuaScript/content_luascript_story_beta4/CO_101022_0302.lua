
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")	
Include("content_luascript_common","DemoCommonPack")	

function Load()
	Load_common(true)
	init_psbattleadv("201060000", "201060000") 
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)


	pbadv_setup_101009_Noir(2,true, 25, 25,0)  

	pbadv_setup_101022_Mordred(0,true, 23, 27 ,0)  

	pbadv_setup_101023_Clarice(1,true, 21, 26 ,0) 


	enemy = dot_reserve_enemy(100, 26, 25, 0) 
	enemy2 = dot_reserve_enemy(100, 24, 27, 0) 
	enemy3 = dot_reserve_enemy(100, 21, 27, 0) 



	barbaroi2 = dot_reserve_enemy(3, 30, 25, 0) 
	barbaroi3 = dot_reserve_enemy(3, 26, 28, 0) 
	barbaroi4 = dot_reserve_enemy(3, 27, 28, 0) 

	setup_complete_unit() 


	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	

	dot_unit_dir(dotClarice1, 1)
	dot_unit_dir(enemy3, 0)


	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(26, 27, 0.0)


end



function Play()
	fadein(0)
	Play_start(true)


	
	CO_101022_0302_select1()
	open_select_window_tag(Noir2, "Normal", "CO_101022_03020030","CO_101022_03020031","CO_101022_03020032")
	close_speech_window()
	

   
	if is_select(1) then
		CO_101022_0302_select1_1()
	elseif is_select(2) then
		CO_101022_0302_select1_2()
	elseif is_select(3) then
		CO_101022_0302_select1_3()
	else
		
	end

	
	CO_101022_0302_select2()
	open_select_window_tag(Noir2, "Normal", "CO_101022_03020065","CO_101022_03020066")
	close_speech_window()
	

	if is_select(1) then
		CO_101022_0302_select2_1()
	elseif is_select(2) then
		CO_101022_0302_select2_2()
	else
		
	end

	CO_101022_0302_end()
end





function CO_101022_0302_select1()

	
	dot_attack_seq(dotNoir2,enemy) 
	dot_damage_seq(enemy, dotNoir2, false)
	
	
		wait_seq()
		wait_time(0.5)
	dot_dying_unit_seq(enemy)
	dot_change_anim(dotNoir2,0) 
	
	dot_attack_seq(dotMordred,enemy2) 
	dot_damage_seq(enemy2, dotMordred, false)
		wait_seq()
		wait_time(0.5)
	dot_dying_unit_seq(enemy2)
		wait_seq()
	dot_change_anim(dotMordred,0) 


	
	dot_attack_seq(dotClarice1,enemy3) 
	dot_damage_seq(enemy3, dotClarice1, false)
		wait_seq()
		wait_time(0.5)
	dot_dying_unit_seq(enemy3)
		wait_seq()
		wait_time(1.1)

	
	dot_change_anim(dotClarice1,1) 

	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "落胆")
		message("CO_101022_03020002") 
	close_speech_window()	

	move_camera(21, 27, 1.6) 
	
	
	dot_unit_dir(dotMordred, 2)
	dot_move_unit_seq(dotMordred,22, 27)
		wait_seq()
	dot_unit_dir(dotMordred, 2)

	dot_unit_dir(dotNoir2, 2)
	dot_move_unit_seq(dotNoir2,23, 25)
		wait_seq()
	dot_unit_dir(dotNoir2, 2)

	wait_camera()

	change_face(Mordred, "Anger")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "怒り")
		message("CO_101022_03020003") 
		message("CO_101022_03020004") 
	close_speech_window()	

	change_face(Clarice1, "Anger")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)	
	PlayPartVoice("クラリス", "悲しみ")
		message("CO_101022_03020005") 
	close_speech_window()

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
		message("CO_101022_03020006") 
	close_speech_window()

	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "笑い")
		message("CO_101022_03020007") 
	close_speech_window()	
		
	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "落胆")
		message("CO_101022_03020008") 
	close_speech_window()	
	
	change_face(Mordred, "Anger")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "肯定2")
		message("CO_101022_03020009") 
	close_speech_window()	

	change_face(Clarice1, "Sad")
	
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "悲しみ")
		message("CO_101022_03020010") 
	close_speech_window()	
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "笑い")
		message("CO_101022_03020011") 
	close_speech_window()	

	change_face(Clarice1, "Surprise")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "驚き")
		message("CO_101022_03020012") 
	close_speech_window()



	dot_disp_unit(barbaroi2, true)
	dot_disp_unit(barbaroi3, true)
	dot_disp_unit(barbaroi4, true)


	dot_reserve_move_unit_seq(barbaroi2,25, 25)
	dot_reserve_move_unit_seq(barbaroi3,26, 26)
	dot_reserve_move_unit_seq(barbaroi4,25, 27)

	exec_parallel_seq()



	dot_unit_dir(dotNoir2, 3)

	move_camera(23, 26, 1.6) 
	

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "驚き")
		message("CO_101022_03020014") 
	close_speech_window()	

	wait_camera()

	change_face(Mordred, "Anger")
	dot_unit_dir(dotMordred, 3)
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "挨拶")
		message("CO_101022_03020015") 
	close_speech_window()	

	dot_change_anim(dotClarice1,0) 
		wait_time(0.5)
	dot_unit_dir(dotClarice1, 3)
	
	change_face(Clarice1, "Surprise")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "肯定")
		message("CO_101022_03020016") 
	close_speech_window()	


	
	dot_reserve_move_unit_seq(dotNoir2,24, 25)
	dot_reserve_move_unit_seq(dotMordred,24, 27)
	
	exec_parallel_seq()
		wait_seq()

	dot_attack_seq(dotNoir2,barbaroi2) 
	dot_damage_seq(barbaroi2, dotNoir2, false)
		wait_seq()
	dot_attack_seq(dotMordred,barbaroi4) 
	dot_damage_seq(barbaroi4, dotMordred, false)
		wait_seq()

	
	
	
	dot_dying_unit_seq(barbaroi2)
	dot_dying_unit_seq(barbaroi4)
	
	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotMordred,0)


	dot_move_unit_seq(dotClarice1,25, 26)
		wait_seq()
	dot_attack_seq(dotClarice1,barbaroi3) 
	dot_damage_seq(barbaroi3, dotClarice1, false)
		wait_time(0.5)
	dot_dying_unit_seq(barbaroi3)
		wait_seq()
	dot_change_anim(dotClarice1,0)



	wait_time(1.1)

	move_camera(25, 26, 1.6) 
	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "悩む")
		message("CO_101022_03020018") 
	close_speech_window()	

	wait_camera()



	dot_unit_dir(dotNoir2, 1)
	dot_unit_dir(dotMordred, 0)
	dot_unit_dir(dotClarice1, 2)

	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "怒り")
		message("CO_101022_03020019") 
		message("CO_101022_03020021") 
	close_speech_window()	


	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)	
	PlayPartVoice("ノワール", "肯定2")
		message("CO_101022_03020022") 
		message("CO_101022_03020023") 
	close_speech_window()	

	change_face(Mordred, "Normal")		
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
		message("CO_101022_03020024") 
	close_speech_window()	
		
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
		message("CO_101022_03020025") 
		message("CO_101022_03020027") 
	close_speech_window()	
	
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "肯定2")
		message("CO_101022_03020028") 
	

end


function CO_101022_0302_select1_1()



	open_speech_window("CHRNAME_NOIR", Noir2,nil)	
	PlayPartVoice("ノワール", "肯定")
		message("CO_101022_03020034") 

	change_face(Noir2, "Pain")
		message("CO_101022_03020035") 
	close_speech_window()	

    
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "笑い")
		message("CO_101022_03020036") 

end


function CO_101022_0302_select1_2()



	open_speech_window("CHRNAME_NOIR", Noir2,nil)	
	PlayPartVoice("ノワール", "悩む")
		message("CO_101022_03020038") 
		message("CO_101022_03020039") 
	close_speech_window()	

    		
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "肯定")
		message("CO_101022_03020040") 
		message("CO_101022_03020041") 
	
end


function CO_101022_0302_select1_3()


	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "笑い")
		message("CO_101022_03020043") 
	close_speech_window()	

    
	change_face(Mordred, "Normal")
	open_speech_window("CHRNAME_MORDRED", Mordred, nil)	
	PlayPartVoice("モルドレッド", "笑い")
		message("CO_101022_03020044") 
		message("CO_101022_03020045") 

	
	
end


function CO_101022_0302_select2()


	dot_unit_dir(dotMordred, 2)
	wait_time(0.2)
		message("CO_101022_03020047") 
	close_speech_window()	



	dot_disp_weapon(dotMordred,false)
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "驚き")
		message("CO_101022_03020048") 
	close_speech_window()	


	dot_move_unit_seq(dotNoir2,24, 26)
	dot_unit_dir(dotNoir2, 1)



	dot_move_unit_seq(dotMordred,21, 27)
		wait_seq()
	dot_move_unit_seq(dotMordred,21, 28)
		wait_seq()
	dot_move_unit_seq(dotMordred,20, 28)
		wait_seq()
	dot_move_unit_seq(dotMordred,20, 33)
	
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
		message("CO_101022_03020050") 
	close_speech_window()	


	dot_disp_unit(dotMordred,false)

	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "悲しみ")
		message("CO_101022_03020051") 
	close_speech_window()	



	dot_unit_dir(dotNoir2, 3)
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "否定")
		message("CO_101022_03020052") 
	close_speech_window()	

	wait_time(2.0)


	open_speech_window("CHRNAME_NOIR", Noir2,nil)
		message("CO_101022_03020054") 
	close_speech_window()	

	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	
		message("CO_101022_03020055") 
	close_speech_window()	

	open_speech_window("CHRNAME_NOIR", Noir2,nil)	
	PlayPartVoice("ノワール", "悩む")
		message("CO_101022_03020056") 
	close_speech_window()	
		
	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "落胆")
		message("CO_101022_03020057") 


	change_face(Clarice1, "Normal")

		message("CO_101022_03020058") 
	close_speech_window()	

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "落胆")
		message("CO_101022_03020059") 
	close_speech_window()	

	change_face(Clarice1, "Normal")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "悲しみ")
		message("CO_101022_03020060") 
	change_face(Clarice1, "Sad")
		message("CO_101022_03020062") 
	close_speech_window()

	change_face(Noir2, "Pain")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	
		message("CO_101022_03020063") 
	

end

function CO_101022_0302_select2_1()


	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "悲しみ")
		message("CO_101022_03020068") 
	close_speech_window()

	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "悲しみ")
		message("CO_101022_03020069") 
	close_speech_window()

	open_speech_window("CHRNAME_NOIR", Noir2,nil) 
	PlayPartVoice("ノワール", "肯定")
		message("CO_101022_03020070")
	close_speech_window()

	change_face(Clarice1, "Surprise")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "否定")
		message("CO_101022_03020071") 
	close_speech_window()

end

function CO_101022_0302_select2_2()

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "悩む")
		message("CO_101022_03020073") 

	change_face(Noir2, "Serious")
		message("CO_101022_03020074") 
		message("CO_101022_03020075") 
	close_speech_window()

	change_face(Clarice1, "Normal")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "肯定")
		message("CO_101022_03020076") 
	close_speech_window()

	change_face(Noir2, "Normal")

end

function CO_101022_0302_end()

		wait_time(0.5)

	dot_unit_dir(dotClarice1, 3)
		wait_time(2.0)
	dot_unit_dir(dotClarice1, 2)
		wait_time(0.5)

	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "挨拶")
		message("CO_101022_03020078") 
	close_speech_window()

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "驚き")
		message("CO_101022_03020079") 
	close_speech_window()

	change_face(Clarice1, "Normal")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "悩む")
		message("CO_101022_03020080") 
	close_speech_window()

	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "笑い")
		message("CO_101022_03020082") 
	close_speech_window()

	change_face(Clarice1, "Surprise")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "驚き")
		message("CO_101022_03020083") 
	close_speech_window()

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "肯定2")
		message("CO_101022_03020084") 
		message("CO_101022_03020086") 
	close_speech_window()

	change_face(Clarice1, "Sad")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "悩む")
		message("CO_101022_03020087") 
	close_speech_window()

	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "笑い")
		message("CO_101022_03020088") 
		message("CO_101022_03020089") 
	close_speech_window()

	change_face(Clarice1, "Normal")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "肯定")
		message("CO_101022_03020091") 
		message("CO_101022_03020092") 
	close_speech_window()


	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "肯定")
		message("CO_101022_03020094") 
	close_speech_window()

	change_face(Clarice1, "Smile")
	open_speech_window("CHRNAME_CLARICE2", Clarice1, nil)
	PlayPartVoice("クラリス", "喜び")
		message("CO_101022_03020096") 
		message("CO_101022_03020097") 
	close_speech_window()

	open_speech_window("CHRNAME_NOIR", Noir2,nil)
	PlayPartVoice("ノワール", "肯定2")
		message("CO_101022_03020098") 
	close_speech_window()

	local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")   
	trustParam.UpdateRankup() 
	
	open_trust_rank_up(Mordred, trustParam)   
	
	



	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 25, 25,0)
	pbadv_setup_101022_Mordred_preload(0,true, 23, 27 ,0)
	pbadv_setup_101023_Clarice_preload(1,true, 21, 26 ,0)
end
