
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	init_psbattleadv("201000000", "201000000")
	change_time_and_weather(2,1)
	
	
	pbadv_setup_101009_Noir(2,true, 14, 14,0)  
	
	
	pbadv_setup_101011_Guinevere(0,true, 15, 14, 0)  
	pbadv_setup_101016_Gwenhwymawr(1,true, 17, 13, 0)  

	
	
	barbaroi1 = dot_reserve_enemy(1, 16, 14, 0)
	barbaroi2 = dot_reserve_enemy(1, 18, 13, 0)
	
	
	
	
	setup_complete_unit()
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(15, 14, 0.0)
	
end





function Play()
	fadein(0)
	Play_start(true)



	
	
	
	dot_change_anim(dotGuinevere,3)
	dot_play_particle_unit(dotGuinevere,"Ef_C_Spr_N_Atk01",3,true)

	wait_time(0.15)
	
	dot_change_anim(barbaroi1,6)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	
	wait_time(0.2)

	dot_change_anim(dotGuinevere,0)
	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",1,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi1, false)
	dot_remove_unit(barbaroi1) 


	dot_change_anim(dotGwenhwymawr1,3)
	dot_play_particle_unit(dotGwenhwymawr1,"Ef_C_Spr_N_Atk01",3,true)

	wait_time(0.15)
	
	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	
	wait_time(0.2)

	dot_change_anim(dotGwenhwymawr1,0)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",1,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi2, false)
	dot_remove_unit(barbaroi2) 

	wait_time(0.5)

	dot_move_unit_seq(dotGwenhwymawr1, 16, 13)
	wait_seq()
	
	dot_unit_dir(dotGuinevere,2)

	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr1, false)
	dot_disp_weapon(dotNoir2, false)
	
	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170001")
	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170003")
	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170004")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_170005")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170006")
	

	
	
	

    
    MA_01104_17_select1()
 
    open_select_window_tag(Noir2, "Normal", "MA_01104_170007", "MA_01104_170008")  
	close_speech_window()
 
    if is_select(1) then            
        MA_01104_17_select1_1()

    else                            
        MA_01104_17_select1_2()
 
    end
    MA_01104_17_end()
 
end
 
function MA_01104_17_select1()
 
end
 
function MA_01104_17_select1_1()
 

 
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_170010")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170011")
	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170012")
	close_speech_window()

	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_170013")
	close_speech_window()

	
	change_face(Guinevere, "Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170021")
	
 
      
end
 
 
function MA_01104_17_select1_2()
 

 
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_170015")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170016")
	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170017")
	

	
	
	change_face(Guinevere, "Shy")
	
	message("MA_01104_170019")
	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170021")
	

    
end
 
 
 
function MA_01104_17_end()


	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170022")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_170023")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170024")
	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170025")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_170026")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170027")
	close_speech_window()

	
	change_face(Gwenhwymawr1, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01104_170028")
	close_speech_window()

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170029")
	

	
	change_face(Guinevere, "Normal")
	
	message("MA_01104_170030")
	close_speech_window()

	
	change_face(Gwenhwymawr1, "Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01104_170031")
	

	
	change_face(Gwenhwymawr1, "Normal")
	
	message("MA_01104_170032")
	close_speech_window()

	
	open_cutin(2,1)
	
	on_cutin(1,Guinevere,"Normal") 
	on_cutin(2,Gwenhwymawr1,"Normal") 

	
	
	open_speech_window("CHRNAME_GUINEVERE_MAID", nil, nil)
	message("MA_01104_170034")
	close_speech_window()

	
	close_cutin()
	

	
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_170035")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_170036")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 14, 14,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 15, 14, 0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 17, 13, 0)
end
