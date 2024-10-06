Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201060001","201060001")
	change_time_and_weather(3,7)
	

	
	pbadv_setup_101009_Noir(2,true,21,18,0)

	
	pbadv_setup_101010_Lancelot(0,true,15,14,0)

	
	pbadv_setup_101012_Dinatan(0,true,17,14,0)
	
	
	pbadv_setup_101014_Tristan(0,true,29,18,0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotLancelot,1)

	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotLancelot,false)
	dot_disp_weapon(dotDinatan,false)
	dot_disp_weapon(dotTristan,false)

	
	
	dot_disp_unit(dotDinatan,false)
	dot_disp_unit(dotTristan,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(35.0,0.0)

	
	
	move_camera(22,18,0.0)
end





function Play()
	fadein(0)
	Play_start(true)




	dot_disp_unit(dotTristan,true)
	dot_move_unit_seq(dotTristan,23,18)
	wait_seq()
	dot_unit_dir(dotTristan,2)
	dot_disp_weapon(dotTristan,false)

	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220002")
	

	message("MA_01107_220004")


	message("MA_01107_220005")
	close_speech_window()
	

	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220006")
	close_speech_window()



	change_face(Tristan,"Smile")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220007")


	change_face(Tristan,"Normal")
	message("MA_01107_220009")
	close_speech_window()


	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220010")
	close_speech_window()


	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220011")
	

	message("MA_01107_220012")
	

	change_face(Tristan,"Smile")
	message("MA_01107_220013")
	close_speech_window()


	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220014")
	close_speech_window()


	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220015")
	close_speech_window()


	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220016")
	close_speech_window()


	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220017")
	close_speech_window()


	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220018")
	close_speech_window()



	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220019")




	
	MA_01107_22_select1()

	open_select_window_tag(Noir2,"Normal","MA_01107_220021","MA_01107_220022")  

	close_speech_window()

	if is_select(1) then			
		MA_01107_22_select1_1()

	else	
		MA_01107_22_select1_2()

	end
	MA_01107_22_end()

	end

	function MA_01107_22_select1()

	end

	function MA_01107_22_select1_1()


	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220024")
	close_speech_window()
	

	change_face(Tristan,"Smile")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220025")
	

	message("MA_01107_220026")
	close_speech_window()
	
end
 
 
function MA_01107_22_select1_2()


	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220028")
	close_speech_window()
	

	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220029")
	

	message("MA_01107_220030")
	close_speech_window()
	
end
 
 
function MA_01107_22_end()
 

	move_camera(15,14,1.0)
	wait_time(2.0)
	

	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_220043")
	close_speech_window()
	
	move_camera(22,18,1.0)
	wait_time(1.0)
	

	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220033")
	close_speech_window()
	

	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_220034")
	close_speech_window()
	

	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220035")
	

	message("MA_01107_220036")
	

	change_face(Tristan,"Smile")
	message("MA_01107_220037")
	

	message("MA_01107_220039")
	close_speech_window()
	

	wait_time(0,6)


	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_220041")
	close_speech_window()
	

	dot_move_unit_seq(dotTristan,29,20)
	wait_seq()
	dot_disp_unit(dotTristan,false)


	move_camera(15,14,0.5)



	dot_unit_dir(dotLancelot,3)
	

	change_face(Lancelot,"Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_220043")
	close_speech_window()
	

	dot_disp_unit(dotDinatan,true)
	dot_move_unit_seq(dotDinatan,16,14)
	wait_seq()
	dot_unit_dir(dotDinatan,2)
	dot_disp_weapon(dotDinatan,false)
	

	change_face(Dinatan,"Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_220045")
	close_speech_window()
	

	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_220047")
	close_speech_window()
	

	change_face(Dinatan,"Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_220048")
	close_speech_window()


	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_220049")
	close_speech_window()
	

	change_face(Dinatan,"Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_220050")
	close_speech_window()
	


	change_face(Lancelot,"Surprise")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_220052")
	close_speech_window()
	

	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_220053")
	close_speech_window()
	

	change_face(Lancelot,"Surprise")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_220054")
	close_speech_window()


	change_face(Dinatan,"Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_220055")
	

	change_face(Dinatan,"Smile")
	message("MA_01107_220056")
	close_speech_window()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,21,18,0)
	pbadv_setup_101010_Lancelot_preload(0,true,15,14,0)
	pbadv_setup_101012_Dinatan_preload(0,true,17,14,0)
	pbadv_setup_101014_Tristan_preload(0,true,29,18,0)
end
