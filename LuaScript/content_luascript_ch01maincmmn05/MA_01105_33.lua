

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201080100", "201080100")

	change_time_and_weather(1,1)
	
	pbadv_setup_101009_Noir(2,true,15,4,0)
	pbadv_setup_101001_Tyrfing(1,true,16,4,0)
	pbadv_setup_101011_Guinevere(0,true,13,3,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,14,4,0)
	pbadv_setup_101013_Gawain(0,true,12,4,0)
	pbadv_setup_101018_Ragnar(2,true,11,4,0)
	
	
	
	setup_complete_unit()
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotTyrfing1, false)
	dot_disp_weapon(dotGuinevere, false)
	dot_disp_weapon(dotGwenhwymawr1, false)
	dot_disp_weapon(dotGawain, false)
	dot_disp_weapon(dotRagnar2, false)
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(13, 2, 0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	
	
	
	
	





	


	
	
	
	dot_move_unit_seq(dotGuinevere,13,1)
	wait_seq()
	wait_time(0.5)
	
	wait_seq()
	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_330002") 
	change_face(Guinevere,"Surprise")
	
	
	dot_move_unit_seq(dotGuinevere,11,1)
	change_face(Guinevere,"Anger")
	
	message("MA_01105_330003") 
	wait_seq()
	close_speech_window()
	
	wait_time(1.5)
	
	dot_move_unit_seq(dotGuinevere,15,1)
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_330004")  
	wait_seq()
	close_speech_window()
	
	wait_time(1.5)
	
	dot_move_unit_seq(dotGuinevere,13,1)
	wait_seq()
	wait_time(1.0)
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_330005")  
	close_speech_window()
	wait_time(1.0)
	
	wait_seq()
	
	change_face(Gwenhwymawr1,"Sad")
	open_speech_window("NPCNAME_0070",Gwenhwymawr1 , nil)
	message("MA_01105_330007")  
	close_speech_window()
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_330008")  
	message("MA_01105_330009")  
	message("MA_01105_330010")  
	close_speech_window()
         
         
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,15,4,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,16,4,0)
	pbadv_setup_101011_Guinevere_preload(0,true,13,3,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,14,4,0)
	pbadv_setup_101013_Gawain_preload(0,true,12,4,0)
	pbadv_setup_101018_Ragnar_preload(2,true,11,4,0)
end
