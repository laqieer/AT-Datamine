Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	init_psbattleadv("201040000","201040000")
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101009_Noir(2,true,29,36,0)
	
	pbadv_setup_101011_Guinevere(0,true,30,37,0)
	
	pbadv_setup_101016_Gwenhwymawr(1,true,29,38,0)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	

	
	
	dot_disp_weapon(dotNoir2,true)
	dot_disp_weapon(dotGuinevere,false)
	dot_disp_weapon(dotGwenhwymawr1,true)

	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(35.0,0.0)

	
	
	move_camera(31,38,0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	dot_reserve_move_unit_seq(dotGuinevere,32,37)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,31,38)
	dot_reserve_move_unit_seq(dotNoir2,31,36)
	exec_parallel_seq()
	wait_seq()
	

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_190002")
	close_speech_window()
	
	
	wait_time(0,5)
	dot_unit_dir(dotGuinevere,2)
	wait_time(0,5)
	dot_unit_dir(dotGuinevere,3)
	wait_time(0,5)
	
	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_190004")
	close_speech_window()
	
	
	change_face(Gwenhwymawr1,"Normal")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1,nil)
	message("MA_01107_190005")
	close_speech_window()
	
	
	
	
	dot_move_unit_seq(dotGwenhwymawr1,40,38)
	wait_time(2.5)
	se_play("SE_ADV_MA_01107_19_Pickel")
	wait_time(3.5)
	dot_move_unit_seq(dotGwenhwymawr1,32,38)
	wait_seq()
	dot_unit_dir(dotGwenhwymawr1,3)
	
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_190007")
	close_speech_window()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_190008")
	close_speech_window()



	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,29,36,0)
	pbadv_setup_101011_Guinevere_preload(0,true,30,37,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,29,38,0)
end
