Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	Fren=set_chara_unknown()
	character2DFull(Fren,"Fren",101039001)
	Lola=set_chara_unknown()
	character2DFull(Lola,"Lola",101038001)

	
	
	init_psbattleadv("201150000","201150000")
	change_time_and_weather(1,1)
	
	load_image("101010060","content_still_10101006_image","101010060_StillImage")
	
    
    pbadv_setup_101051_Lucius(0,true,25,22,0)	
    
	pbadv_setup_101052_Vernarth(0,true,26,23,0)	
	
	dotFren=dot_reserve_ally(101039001,18,22,0)
	dot_set_weapon(dotFren,101010001)
	
	dotLola=dot_reserve_ally(101038001,22,22,0)
	dot_set_weapon(dotLola,101010001)
	
	dotkyame1=dot_reserve_ally(401005001,14,21,0)
	dot_set_weapon(dotkyame1,101010001)
	dotkyame2=dot_reserve_ally(401005001,14,22,0)
	dot_set_weapon(dotkyame2,101010001)
	dotkyame3=dot_reserve_ally(401006001,14,23,0)
	dot_set_weapon(dotkyame3,101010001)
	dotkyame4=dot_reserve_ally(401005001,15,21,0)
	dot_set_weapon(dotkyame4,101010001)
	dotkyame5=dot_reserve_ally(401006001,15,22,0)
	dot_set_weapon(dotkyame5,101010001)
	dotkyame6=dot_reserve_ally(401006001,15,23,0)
	dot_set_weapon(dotkyame6,101010001)

	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotVernarth,2)
	dot_unit_dir(dotLucius,2)
	dot_unit_dir(dotLola,2)
	
	
	
	dot_disp_weapon(dotLucius,false)
	dot_disp_weapon(dotVernarth,false)
	dot_disp_weapon(dotkyame1,false)
	dot_disp_weapon(dotkyame2,false)
	dot_disp_weapon(dotkyame3,false)
	dot_disp_weapon(dotkyame4,false)
	dot_disp_weapon(dotkyame5,false)
	dot_disp_weapon(dotkyame6,false)

	
	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(20,23,0.0)
end





function Play()
	fadein(0)
	Play_start(true)


	


		show_image("101010060", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
		set_scale_image(STILL_SCALE,STILL_SCALE)
		wait_time(STILL_SWITCH_TIME)
		
		


		 scale_to_image(1,1,STILL_MOVE_TIME,2)
		 
		 se_play("SE_ADV_MA_01108_12_Flight")
		wait_time(1.0)
		
		se_play("SE_ADV_MA_01C111_21_Sword")
		wait_time(1.0)
		 
		wait_time(STILL_ACTIVE_AFTER)
		
		
	
	dot_place_unit(dotFren,19,22)
	dot_place_unit(dotLola,21,22)
	
	wait_time(1.0)
	hide_image(STILL_SWITCH_TIME)
	
	se_play("SE_ADV_MA_01C110_39_Cheers")
	wait_time(1.0)

	se_play("SE_ADV_MA_01C110_41_Cheers_01")
	wait_time(1.0)
	
	se_play("SE_ADV_MA_01C110_41_Cheers_02")
	wait_time(2.0)
	
	wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
	
	

	dot_change_anim(dotFren,0)
	dot_change_anim(dotLola,0)
	
	wait_time(1.8)
	
	se_play("SE_ADV_MA_01107_06_Lucius_Crap")
	
	wait_time(0.8)
	dot_change_anim(dotFren,0)
	dot_change_anim(dotLola,0)
	dot_unit_dir(dotLola,3)
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)



	move_camera(21,23,0.5)
	dot_reserve_move_unit_seq(dotLucius,23,22)
	dot_reserve_move_unit_seq(dotVernarth,24,23)
	exec_parallel_seq()
	wait_seq()
	dot_disp_weapon(dotVernarth,false)
	dot_disp_weapon(dotLucius,false)
	dot_unit_dir(dotLucius,2)
	dot_unit_dir(dotVernarth,2)


	wait_time(0.3)

	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060002")



	dot_move_unit_seq(dotLola,20,22) 
	wait_seq()
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)
	dot_move_unit_seq(dotLola,20,21) 
	wait_seq()
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)
	dot_move_unit_seq(dotLola,18,21) 
	wait_seq()
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)
	dot_reserve_move_unit_seq(dotFren,20,22) 
	dot_reserve_move_unit_seq(dotLola,18,22) 
	exec_parallel_seq()
	wait_seq()
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)
	dot_move_unit_seq(dotLola,19,22) 
	wait_seq()
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)
	wait_time(0.5)


	change_face(Lucius,"Normal")
	message("MA_01107_060004")
	close_speech_window()



	change_face(Fren,"Normal")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060005")
	OpenFirstAppearance(Fren)
	close_speech_window()



	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060006")



	change_face(Lucius,"Normal")
	message("MA_01107_060007")
	close_speech_window()


	change_face(Lola,"Sad")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01107_060009")
	OpenFirstAppearance(Lola)
	close_speech_window()


	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060011")
	close_speech_window()



	change_face(Lola,"Surprise")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01107_060012")
	close_speech_window()



	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060013")
	close_speech_window()



	change_face(Lola,"Sad")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01107_060014")
	close_speech_window()



	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060015")
	close_speech_window()



	dot_move_unit_seq(dotFren,21,22)
	wait_seq()
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)


	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060017")
	close_speech_window()

	se_play("SE_ADV_MA_01107_06_Crowds")
	
	dot_unit_dir(dotkyame1,1)
	dot_unit_dir(dotkyame2,1)
	dot_unit_dir(dotkyame3,0)
	dot_unit_dir(dotkyame4,1)
	dot_unit_dir(dotkyame5,0)
	dot_unit_dir(dotkyame6,0)
	
	
	wait_time(1.5)
	dot_unit_dir(dotkyame1,3)
	dot_unit_dir(dotkyame2,3)
	dot_unit_dir(dotkyame3,3)
	dot_unit_dir(dotkyame4,3)
	dot_unit_dir(dotkyame5,3)
	dot_unit_dir(dotkyame6,3)
	


	change_face(Lola,"Surprise")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01107_060019")
	close_speech_window()



	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060020")
	close_speech_window()



	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060021")
	close_speech_window()



	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060022")
	close_speech_window()

	

	dot_unit_dir(dotkyame1,1)
	dot_unit_dir(dotkyame2,1)
	dot_unit_dir(dotkyame3,0)
	dot_unit_dir(dotkyame4,1)
	dot_unit_dir(dotkyame5,0)
	dot_unit_dir(dotkyame6,0)
	
	
	
	wait_time(1.0)
	
	dot_unit_dir(dotkyame1,3)
	dot_unit_dir(dotkyame2,3)
	dot_unit_dir(dotkyame3,3)
	dot_unit_dir(dotkyame4,3)
	dot_unit_dir(dotkyame5,3)
	dot_unit_dir(dotkyame6,3)
	


	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01107_060024")
	close_speech_window()



	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060025")
	close_speech_window()

	se_play("SE_ADV_MA_01107_06_Crowds")


	change_face(Lola,"Surprise")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01107_060026")
	close_speech_window()





	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060028")
	close_speech_window()
	


	change_face(Lola,"Surprise")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01107_060030")
	close_speech_window()



	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060031")
	close_speech_window()



	change_face(Lucius,"Surprise")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060032")


	change_face(Lucius,"Normal")
	message("MA_01107_060034")
	close_speech_window()



	change_face(Fren,"Surprise")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060035")
	close_speech_window()



	dot_move_unit_seq(dotLucius,22,22)
		wait_seq()
	dot_unit_dir(dotLucius,2)
	dot_disp_weapon(dotLucius,false)


	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060037")
	close_speech_window()





	change_face(Fren, "Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060039")
	close_speech_window()




	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060040")
	close_speech_window()


	open_cutin(1,2)
	on_cutin(1,Fren,"Anger")

	wait_time(1.0)
	close_cutin()
	wait_time(0.2)	

	dot_change_anim(dotFren,3)

	wait_time(0.2)

	dot_change_anim(dotLucius,6)
	se_play("SE_ADV_MA_01107_06_Hand_Slap")
	
	wait_time(0.5)
	
	se_play("SE_ADV_MA_01107_06_Crowds")
	se_play("SE_ADV_MA_01C110_42_Crowd")
	
	dot_unit_dir(dotkyame1,1)
	dot_unit_dir(dotkyame2,0)
	dot_unit_dir(dotkyame3,2)
	dot_unit_dir(dotkyame4,1)
	dot_unit_dir(dotkyame5,0)
	dot_unit_dir(dotkyame6,3)	
	
	wait_time(1.0)

	dot_change_anim(dotFren,0)
	dot_change_anim(dotLucius,0)
	
	dot_unit_dir(dotkyame1,3)
	dot_unit_dir(dotkyame2,3)
	dot_unit_dir(dotkyame3,3)
	dot_unit_dir(dotkyame4,3)
	dot_unit_dir(dotkyame5,3)
	dot_unit_dir(dotkyame6,3)
	

	change_face(Lola,"Surprise")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01107_060042")
	close_speech_window()



	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060044")
	close_speech_window()
	dot_change_anim(dotFren,0)



	dot_move_unit_seq(dotLola,20,22) 
	wait_seq()
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)
	dot_reserve_move_unit_seq(dotFren,19,22) 
	dot_reserve_move_unit_seq(dotLola,18,22)
	dot_reserve_move_unit_seq(dotVernarth,21,23)
	exec_parallel_seq() 
	dot_unit_dir(dotLola,3)
	dot_unit_dir(dotFren,3)
	wait_seq()
	dot_unit_dir(dotLola,3)
	dot_unit_dir(dotFren,3)
	dot_unit_dir(dotVernarth,2)
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLola,false)
	dot_disp_weapon(dotVernarth,false)
	wait_time(0.2)


	change_face(Vernarth,"Anger")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01107_060046")
	close_speech_window()




	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060048")
	close_speech_window()



	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060049")
	close_speech_window()

	dot_unit_dir(dotLucius,3)

	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060051")
	close_speech_window()
	
	move_camera(24,23,0.5)
	dot_reserve_move_unit_seq(dotLucius,27,22)
	dot_reserve_move_unit_seq(dotVernarth,26,23)
	exec_parallel_seq()
	wait_seq()
	wait_camera()

	dot_disp_weapon(dotLucius,false)
	dot_disp_weapon(dotVernarth,false)
	
	
	dot_reserve_move_unit_seq(dotFren,23,22) 
	dot_reserve_move_unit_seq(dotLola,22,22)
	exec_parallel_seq() 
	wait_seq()

	change_face(Fren,"Anger")
	open_speech_window("CHRNAME_FREN",Fren,nil)
	message("MA_01107_060052")
	close_speech_window()



	
	wait_seq()
	dot_disp_weapon(dotLucius,false)
	dot_unit_dir(dotLucius,2)
	
	


	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_060054")
	close_speech_window()
	dot_reserve_move_unit_seq(dotLucius,36,22)
	dot_reserve_move_unit_seq(dotVernarth,35,23)
	exec_parallel_seq()
	wait_time(0.2)



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Fren,"Fren",101039001)
	character2DFull_Preload(Lola,"Lola",101038001)
	load_image_preload("101010060","content_still_10101006_image","101010060_StillImage")
    pbadv_setup_101051_Lucius_preload(0,true,25,22,0)
	pbadv_setup_101052_Vernarth_preload(0,true,26,23,0)
end
