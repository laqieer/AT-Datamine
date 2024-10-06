

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	init_psbattleadv("201200001", "201200001")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	
	
	
	
	pbadv_setup_101009_Noir(2,true,16,29,0)

	
	pbadv_setup_101010_Lancelot(3,true,15,28,0)
	pbadv_setup_101010_Lancelot(1,true,0,0,0)

	
	pbadv_setup_101011_Guinevere(0,true,17,28,0)

	
	pbadv_setup_101016_Gwenhwymawr(0,true,18,29,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,1,1,0)

	
	pbadv_setup_101030_Elaine(0,true,20,37,0)

	
	pbadv_setup_101031_Lovein(0,true,19,37,0)

	pbadv_setup_101013_Gawain(0,true, 16, 31,0)  

	
	pbadv_setup_101036_Viena(0,true,15,30,0)
	pbadv_setup_101036_Viena(1,true,2,2,0)

	
	pbadv_setup_101028_Galahad(1,true,14,30,0)


	dotLog1 = dot_reserve_ally(401036001, 19, 38, 0) 
	dot_set_weapon(dotLog1, 101010001)
	
	dotLog2 = dot_reserve_ally(401036001, 20, 38, 0) 
	dot_set_weapon(dotLog2, 101010001)
	
	dotLog3 = dot_reserve_ally(401036001, 19, 39, 0) 
	dot_set_weapon(dotLog3, 101010001)
	
	dotLog4 = dot_reserve_ally(401036001, 20, 39, 0) 
	dot_set_weapon(dotLog4, 101010001)




	dotfriendly_forces1_1 = dot_reserve_ally(401035001, 14, 32, 0)
	dot_set_weapon(dotfriendly_forces1_1, 101010001)
	
	dotfriendly_forces1_2 = dot_reserve_ally(401035001, 15, 32, 0)
	dot_set_weapon(dotfriendly_forces1_2, 104010001)
	
	dotfriendly_forces1_3 = dot_reserve_ally(401035001, 16, 32, 0)
	dot_set_weapon(dotfriendly_forces1_3, 108010001)
	
	dotfriendly_forces1_4 = dot_reserve_ally(401035001, 17, 32, 0)
	dot_set_weapon(dotfriendly_forces1_4, 102020001)
	
	
	dotfriendly_forces2_1 = dot_reserve_ally(401035001, 14, 33, 0)
	dot_set_weapon(dotfriendly_forces2_1, 102020001)
	
	dotfriendly_forces2_2 = dot_reserve_ally(401035001, 15, 33, 0)
	dot_set_weapon(dotfriendly_forces2_2, 105010001)
	
	dotfriendly_forces2_3 = dot_reserve_ally(401035001, 16, 33, 0)
	dot_set_weapon(dotfriendly_forces2_3, 103010001)
	
	dotfriendly_forces2_4 = dot_reserve_ally(401035001, 17, 33, 0)
	dot_set_weapon(dotfriendly_forces2_4, 108010001)
	
	
	
	dotRoma1 = dot_reserve_ally(401040001, 39, 1, 0) 
	dot_set_weapon(dotRoma1, 101010001)
	
	dotRoma2 = dot_reserve_ally(401040001, 38, 1, 0) 
	dot_set_weapon(dotRoma2, 101010001)
	
	dotRoma3 = dot_reserve_ally(401040001, 37, 1, 0) 
	dot_set_weapon(dotRoma3, 101010001)
	
	dotRoma4 = dot_reserve_ally(401040001, 40, 1, 0) 
	dot_set_weapon(dotRoma4, 101010001)

	dotRoma5 = dot_reserve_ally(401040001, 39, 3, 0) 
	dot_set_weapon(dotRoma5, 101010001)
	
	dotRoma6 = dot_reserve_ally(401040001, 38, 3, 0) 
	dot_set_weapon(dotRoma6, 101010001)
	
	dotRoma7 = dot_reserve_ally(401040001, 37, 3, 0) 
	dot_set_weapon(dotRoma7, 101010001)
	
	dotRoma8 = dot_reserve_ally(401040001, 40, 3, 0) 
	dot_set_weapon(dotRoma8, 101010001)

	dotRoma9 = dot_reserve_ally(401040001, 39, 2, 0) 
	dot_set_weapon(dotRoma9, 101010001)
	
	dotRoma10 = dot_reserve_ally(401040001, 38, 2, 0) 
	dot_set_weapon(dotRoma10, 101010001)
	
	dotRoma11 = dot_reserve_ally(401040001, 37, 2, 0) 
	dot_set_weapon(dotRoma11, 101010001)
	
	dotRoma12 = dot_reserve_ally(401040001, 40, 2, 0) 
	dot_set_weapon(dotRoma12, 101010001)

	dotRoma13 = dot_reserve_ally(401040001, 39, 0, 0) 
	dot_set_weapon(dotRoma13, 101010001)
	
	dotRoma14 = dot_reserve_ally(401040001, 38, 0, 0) 
	dot_set_weapon(dotRoma14, 101010001)
	
	dotRoma15 = dot_reserve_ally(401040001, 37, 0, 0) 
	dot_set_weapon(dotRoma15, 101010001)
	
	dotRoma16 = dot_reserve_ally(401040001, 40, 0, 0) 
	dot_set_weapon(dotRoma16, 101010001)

	dotRoma17 = dot_reserve_ally(401040001, 39, 4, 0) 
	dot_set_weapon(dotRoma17, 101010001)
	
	dotRoma18 = dot_reserve_ally(401040001, 38, 4, 0) 
	dot_set_weapon(dotRoma18, 101010001)
	
	dotRoma19 = dot_reserve_ally(401040001, 37, 4, 0) 
	dot_set_weapon(dotRoma19, 101010001)
	
	dotRoma20 = dot_reserve_ally(401040001, 40, 4, 0) 
	dot_set_weapon(dotRoma20, 101010001)

	dotRoma21 = dot_reserve_ally(401040001, 41, 0, 0) 
	dot_set_weapon(dotRoma21, 101010001)
	
	dotRoma22 = dot_reserve_ally(401040001, 41, 1, 0) 
	dot_set_weapon(dotRoma22, 101010001)
	
	dotRoma23 = dot_reserve_ally(401040001, 41, 2, 0) 
	dot_set_weapon(dotRoma23, 101010001)
	
	dotRoma24 = dot_reserve_ally(401040001, 41, 3, 0) 
	dot_set_weapon(dotRoma24, 101010001)

	dotRoma25 = dot_reserve_ally(401040001, 41, 4, 0) 
	dot_set_weapon(dotRoma25, 101010001)
	
	
	
	setup_complete_unit()

	
	
	dot_unit_dir(dotRoma1, 2)
	dot_unit_dir(dotRoma2, 2)
	dot_unit_dir(dotRoma3, 2)
	dot_unit_dir(dotRoma4, 2)
	dot_unit_dir(dotRoma5, 2)
	dot_unit_dir(dotRoma6, 2)
	dot_unit_dir(dotRoma7, 2)
	dot_unit_dir(dotRoma8, 2)
	dot_unit_dir(dotRoma9, 2)
	dot_unit_dir(dotRoma10, 2)
	dot_unit_dir(dotRoma11, 2)
	dot_unit_dir(dotRoma12, 2)
	dot_unit_dir(dotRoma13, 2)
	dot_unit_dir(dotRoma14, 2)
	dot_unit_dir(dotRoma15, 2)
	dot_unit_dir(dotRoma16, 2)
	dot_unit_dir(dotRoma17, 2)
	dot_unit_dir(dotRoma18, 2)
	dot_unit_dir(dotRoma19, 2)
	dot_unit_dir(dotRoma20, 2)
	dot_unit_dir(dotRoma21, 2)
	dot_unit_dir(dotRoma22, 2)
	dot_unit_dir(dotRoma23, 2)
	dot_unit_dir(dotRoma24, 2)
	dot_unit_dir(dotRoma25, 2)

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(39, 2, 0.0)

		
	Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_Killers2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	Ef_Killers3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)

	Ef_Vibes1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true) 
	Ef_Emblem4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true) 
	Ef_Emblem5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true) 
	Ef_Emblem6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true) 

end







function Play()
	fadein(0)
	Play_start(true)




	wait_time(1.5)

	move_camera(16, 29, 3.0)
	wait_camera()


	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220002")
	close_speech_window()
	
	dot_reserve_move_unit_seq(dotElaine, 19,31)
	dot_reserve_move_unit_seq(dotLovein, 18,31)
	dot_reserve_move_unit_seq(dotLog1, 18,32)
	dot_reserve_move_unit_seq(dotLog2, 19,32)
	dot_reserve_move_unit_seq(dotLog3, 18,33)
	dot_reserve_move_unit_seq(dotLog4, 19,33)
	
	
	exec_parallel_seq()

	
	wait_seq()

	dot_unit_dir(dotElaine, 2)
	dot_unit_dir(dotLovein, 2)
	dot_unit_dir(dotLog1, 2)
	dot_unit_dir(dotLog2, 2)
	dot_unit_dir(dotLog3, 2)
	dot_unit_dir(dotLog4, 2)

	move_camera(17, 30,1.0)
	wait_camera()


	
	change_face(Lovein, "Normal")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01B111_220004")
	close_speech_window()
	
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220005")
	close_speech_window()
	
	

	change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01B111_220007")
	close_speech_window()
	
	
	change_face(Lovein, "Normal")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01B111_220009")
	close_speech_window()
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220010")
	close_speech_window()
	
	

	change_face(Lovein, "Normal")
	open_speech_window("CHRNAME_LOVEIN", Lovein, nil)
	message("MA_01B111_220011")
	close_speech_window()
	
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220013")
	close_speech_window()
	
	

	change_face(Elaine, "Sad")
	open_speech_window("CHRNAME_ELAINE", Elaine, nil)
	message("MA_01B111_220015")
	close_speech_window()
	
	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220017")


	wait_time(0.5)
	
	dot_reserve_move_unit_seq(dotLog3, 19,39)
	dot_reserve_move_unit_seq(dotLog4, 20,39)

	dot_reserve_move_unit_seq(dotLog1, 19,38)
	dot_reserve_move_unit_seq(dotLog2, 20,38)

	dot_reserve_move_unit_seq(dotElaine, 18,37)
	dot_reserve_move_unit_seq(dotLovein, 19,37)
	
	
	exec_parallel_seq()

	
	wait_seq()

	move_camera(16, 29, 1.0)
	wait_camera()


	
	MA_01B111_22_select1()

	open_select_window_tag(Noir2, "Normal", "MA_01B111_220018", "MA_01B111_220019")	
	close_speech_window()	

	if is_select(1) then			
		MA_01B111_22_select1_1()

	else							
		MA_01B111_22_select1_2()

	end
	MA_01B111_22_end()

end

function MA_01B111_22_select1()

end

function MA_01B111_22_select1_1()






	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_220021")
	close_speech_window()
	
	dot_unit_dir(dotGuinevere, 2)

	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220022")
	
	
	change_face(Guinevere, "Normal")
	message("MA_01B111_220023")
	
	
	change_face(Guinevere, "Normal")
	message("MA_01B111_220024")
	
	
	change_face(Guinevere, "Smile")
	message("MA_01B111_220025")
	close_speech_window()

	wait_time(0.5)

		
end


function MA_01B111_22_select1_2()




	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_220027")
	close_speech_window()

	dot_unit_dir(dotGuinevere, 2)

	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220028")
	
	
	message("MA_01B111_220030")
	close_speech_window()
	
	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_220031")
	close_speech_window()
	
	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220032")
	close_speech_window()

	wait_time(0.5)
	
		
end


function MA_01B111_22_end()




	dot_unit_dir(dotNoir2, 2)

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_220034")
	close_speech_window()
	
	
	change_face(Viena, "Normal")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B111_220035")
	close_speech_window()
	
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220036")
	close_speech_window()

	dot_move_unit_seq(dotGuinevere, 17, 30)
	
	
	wait_seq()
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotGuinevere, 2)
	
	
	open_cutin(1,1)
	
	on_cutin(1, Guinevere, "Anger", 1)
	

	
	open_speech_window("CHRNAME_GUINEVERE", nil, nil)
	change_face(Guinevere, "Normal")
	message("MA_01B111_220038")
	
	
	change_face(Guinevere, "Anger")
	message("MA_01B111_220039")
	
	
	change_face(Guinevere, "Anger")
	message("MA_01B111_220040")
	
	
	change_face(Guinevere, "Normal")
	message("MA_01B111_220041")
	
	
	change_face(Guinevere, "Normal")
	message("MA_01B111_220042")
	
	
	change_face(Guinevere, "Anger")
	message("MA_01B111_220043")
	

	
	close_cutin()
	wait_time(0.5)

	
	
	



    
    MA_01B111_22_select2()
 
    open_select_window_tag(Noir2, "Normal", "MA_01B111_220044", "MA_01B111_220045", "MA_01B111_220046")  
 	close_speech_window()
 	
    if is_select(1) then            
        MA_01B111_22_select2_1()
 
    elseif is_select(2) then        
        MA_01B111_22_select2_2()
 
    elseif is_select(3) then        
        MA_01B111_22_select2_3()
 
    end
    MA_01B111_22_2_end()
 
end
 
function MA_01B111_22_select2()
 
end
 
function MA_01B111_22_select2_1()
 

 

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_220048")
	close_speech_window()
	
	
	change_face(Guinevere, "Smile")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220049")
	close_speech_window()

	dot_unit_dir(dotGwenhwymawr, 2)

	
	change_face(Gwenhwymawr, "Smile")
	open_speech_window("CHRNAME_GWENHWYMAWR", Gwenhwymawr, nil)
	message("MA_01B111_220050")
	close_speech_window()
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220051")
	close_speech_window()
 
      
end
 
 
function MA_01B111_22_select2_2()
 

 

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_220053")
	close_speech_window()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_220054")
	close_speech_window()

	dot_unit_dir(dotViena, 2)

	
	change_face(Viena, "Smile")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B111_220055")
	
	
	change_face(Viena, "Normal")
	message("MA_01B111_220056")
	close_speech_window()
 
    
end
 
 
function MA_01B111_22_select2_3()
 

     
 

	
	change_face(Noir2, "Serious")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B111_220058")
	close_speech_window()
	
	
	change_face(Lancelot3, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot3, nil)
	message("MA_01B111_220059")
	close_speech_window()
	
	
	change_face(Galahad1, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad1, nil)
	message("MA_01B111_220060")
	close_speech_window()

	dot_unit_dir(dotViena, 2)

	
	change_face(Viena, "Smile")
	open_speech_window("CHRNAME_VIENA", Viena, nil)
	message("MA_01B111_220061")
	close_speech_window()
 
 
        
end
 
 
function MA_01B111_22_2_end()







	dot_unit_dir(dotGwenhwymawr, 2)
	dot_unit_dir(dotViena, 3)

	
	change_face(Gwenhwymawr, "Anger")
	open_speech_window("CHRNAME_GWENHWYMAWR", Gwenhwymawr, nil)
	message("MA_01B111_220063")
	close_speech_window()
	
	dot_unit_dir(dotGuinevere, 3)

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01B111_220064")
	close_speech_window()
	

	
	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)
	on_active(Ef_Emblem3)
	on_active(Ef_Emblem4)
	on_active(Ef_Emblem5)
	on_active(Ef_Emblem6)

	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_Emblem1, locatorpos)
	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotLancelot3,1)
	set_pos(Ef_Emblem2, locatorpos)
	play_particle(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_Emblem3, locatorpos)
	play_particle(Ef_Emblem3)

	local locatorpos = dot_get_unit_locator(dotGwenhwymawr,1)
	set_pos(Ef_Emblem4, locatorpos)
	play_particle(Ef_Emblem4)

	local locatorpos = dot_get_unit_locator(dotGalahad1,1)
	set_pos(Ef_Emblem5, locatorpos)
	play_particle(Ef_Emblem5)

	local locatorpos = dot_get_unit_locator(dotViena,1)
	set_pos(Ef_Emblem6, locatorpos)
	play_particle(Ef_Emblem6)

	wait_time(2.0)

	on_active(Ef_Killers)
	on_active(Ef_Killers2)
	on_active(Ef_Killers3)

	on_active(Ef_Vibes1)
	on_active(Ef_Vibes2)
	on_active(Ef_Vibes3)

	
	local gridpos = get_grid_position(15,28)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(16,29)
	set_pos(Ef_Vibes1, gridpos)
	play_particle(Ef_Vibes1)
	

	local gridpos = get_grid_position(18,29)
	set_pos(Ef_Killers2, gridpos)
	play_particle(Ef_Killers2)

	local gridpos = get_grid_position(17,30)
	set_pos(Ef_Vibes2, gridpos)
	play_particle(Ef_Vibes2)

	local gridpos = get_grid_position(15,30)
	set_pos(Ef_Killers3, gridpos)
	play_particle(Ef_Killers3)

	local gridpos = get_grid_position(14,30)
	set_pos(Ef_Vibes3, gridpos)
	play_particle(Ef_Vibes3)

	wait_time(2.0)

	on_active(Ef_KillChan1)
	on_active(Ef_KillChan2)
	on_active(Ef_KillChan3)

	local gridpos = get_grid_position(15,28)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)
	
	dot_change_unit(dotLancelot3, dotLancelot1, 0.0)

	local gridpos = get_grid_position(18,29)
	set_pos(Ef_KillChan2, gridpos)
	play_particle(Ef_KillChan2)
	
	dot_change_unit(dotGwenhwymawr, dotGwenhwymawr1, 0.0)

	local gridpos = get_grid_position(15,30)
	set_pos(Ef_KillChan3, gridpos)
	play_particle(Ef_KillChan3)
	dot_change_unit(dotViena, dotViena1, 0.0)

	wait_time(1.5)

	stop_particle(Ef_Killers)
	stop_particle(Ef_Killers2)
	stop_particle(Ef_Killers3)
	
	stop_particle(Ef_Vibes1)
	stop_particle(Ef_Vibes2)
	stop_particle(Ef_Vibes3)

	wait_time(2.5)



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,16,29,0)
	pbadv_setup_101010_Lancelot_preload(3,true,15,28,0)
	pbadv_setup_101010_Lancelot_preload(1,true,0,0,0)
	pbadv_setup_101011_Guinevere_preload(0,true,17,28,0)
	pbadv_setup_101016_Gwenhwymawr_preload(0,true,18,29,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,1,1,0)
	pbadv_setup_101030_Elaine_preload(0,true,20,37,0)
	pbadv_setup_101031_Lovein_preload(0,true,19,37,0)
	pbadv_setup_101013_Gawain_preload(0,true, 16, 31,0)
	pbadv_setup_101036_Viena_preload(0,true,15,30,0)
	pbadv_setup_101036_Viena_preload(1,true,2,2,0)
	pbadv_setup_101028_Galahad_preload(1,true,14,30,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem18", false, true)
end
