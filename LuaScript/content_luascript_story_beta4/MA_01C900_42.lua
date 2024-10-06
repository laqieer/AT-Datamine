

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	

	init_psbattleadv("201170000","201170000")
	change_time_and_weather(3,1)
	

	pbadv_setup_101009_Noir(2,true,18,27,0)
	
	pbadv_setup_101012_Dinatan(0,true,17,27,0)
	
	pbadv_setup_101051_Lucius(0,true,19,26,0)
	
	pbadv_setup_101022_Mordred(0,true,18,26,0)
	
	pbadv_setup_101023_Clarice(0,true,17,26,0)
	
	pbadv_setup_101023_Clarice(1,true,41,41,0)
	
	pbadv_setup_101043_Mazoe(true,13,1,0)

	pbadv_setup_101047_Tyronoe(true,15,0,0)

	pbadv_setup_101048_Thiten(true,17,0,0)

	pbadv_setup_101049_Thiton(true,19,1,0)
	
	
	barbaroi1=dot_reserve_enemy(1,12,41,0)
	barbaroi4=dot_reserve_enemy(1,13,41,0)
	barbaroi5=dot_reserve_enemy(1,19,40,0)
	barbaroi6=dot_reserve_enemy(1,19,41,0)
	barbaroi7=dot_reserve_enemy(1,20,40,0)
	barbaroi8=dot_reserve_enemy(1,20,41,0)
	barbaroi9=dot_reserve_enemy(1,14,40,0)
	barbaroi10=dot_reserve_enemy(1,18,41,0)
	barbaroi11=dot_reserve_enemy(1,15,41,0)
	barbaroi12=dot_reserve_enemy(1,16,41,0)
	barbaroi13=dot_reserve_enemy(1,17,41,0)
	barbaroi14=dot_reserve_enemy(1,15,40,0)
	barbaroi15=dot_reserve_enemy(1,16,40,0)
	barbaroi16=dot_reserve_enemy(1,17,40,0)
	barbaroi17=dot_reserve_enemy(1,14,41,0)
	barbaroi18=dot_reserve_enemy(1,18,40,0)
	
	
	
	
	setup_complete_unit()

	dot_move_height(dotMazoe,5,2,2)
	dot_move_height(dotTyronoe,5,2,2)
	dot_move_height(dotThiten,5,2,2)
	dot_move_height(dotThiton,5,2,2)
	
	
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotDinatan,2)
	dot_unit_dir(dotMordred,2)
	dot_unit_dir(dotClarice,2)
	dot_unit_dir(dotLucius,2)
	dot_unit_dir(dotMazoe,3)
	dot_unit_dir(dotTyronoe,3)

	dot_unit_dir(barbaroi1,3)
	dot_unit_dir(barbaroi4,3)
	dot_unit_dir(barbaroi9,3)
	dot_unit_dir(barbaroi17,3)
	dot_unit_dir(barbaroi11,3)
	dot_unit_dir(barbaroi14,3)
	
	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotDinatan,false)
	dot_disp_weapon(dotMordred,false)
	dot_disp_weapon(dotClarice,false)
	dot_disp_weapon(dotLucius,false)

	
	
	dot_disp_unit(dotMazoe,false)
	dot_disp_unit(dotTyronoe,false)
	dot_disp_unit(dotThiten,false)
	dot_disp_unit(dotThiton,false)
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi6,false)
	dot_disp_unit(barbaroi7,false)
	dot_disp_unit(barbaroi8,false)
	dot_disp_unit(barbaroi9,false)
	dot_disp_unit(barbaroi10,false)
	dot_disp_unit(barbaroi11,false)
	dot_disp_unit(barbaroi12,false)
	dot_disp_unit(barbaroi13,false)
	dot_disp_unit(barbaroi14,false)
	dot_disp_unit(barbaroi15,false)
	dot_disp_unit(barbaroi16,false)
	dot_disp_unit(barbaroi17,false)
	dot_disp_unit(barbaroi18,false)
	
	
	change_camera_distance(8.0,0.0)
	
	change_camera_angle(45.0,0.0)
	
	
	move_camera(16,27,0.0)
	
	Ef_01=load_particle("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	Ef_02=load_particle("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	Ef_03=load_particle("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	Ef_04=load_particle("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	Ef_Portal_E1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E11=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E13=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E14=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E15=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E16=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E17=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E18=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	
	Ef_19=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_20=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	
	
	Ef_Witch = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Witch4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true) 
	Ef_Killers1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	
	load_image("101040280", "content_still_10104028_image", "101040280_StillImage")

	load_image("10102001", "content_still_10102001_image", "101020010_StillImage")

	load_sound("BGM_ADV_Serious2")
	load_sound("BGM_ADV_Revenge")

end





function Play()
	fadein(0)
	Play_start(true)

	
	move_camera(14,18,2.0)
	dot_reserve_move_unit_seq(dotNoir2,15,18)
	dot_reserve_move_unit_seq(dotDinatan,14,18)
	dot_reserve_move_unit_seq(dotMordred,15,17)
	dot_reserve_move_unit_seq(dotClarice,14,17)
	dot_reserve_move_unit_seq(dotLucius,16,17)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotDinatan,2)
	dot_unit_dir(dotMordred,2)
	dot_unit_dir(dotClarice,2)
	dot_unit_dir(dotLucius,2)
	
	
	change_face(Mordred,"Surprise")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定3")
	message("MA_01C900_420002")
	close_speech_window()

	
	change_face(Clarice,"Smile")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "笑い")
	message("MA_01C900_420004")
	close_speech_window()

	
	change_face(Mordred,"Surprise")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "悲しみ")
	message("MA_01C900_420006")

	
	change_face(Mordred,"Surprise")	
	message("MA_01C900_420007")
	close_speech_window()

	
	
	change_face(Noir2,"Sad")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "落胆")
	message("MA_01C900_420008")
	close_speech_window()
	
	move_camera(15,12,0.8)
	dot_reserve_move_unit_seq(dotNoir2,16,12)
	dot_reserve_move_unit_seq(dotDinatan,15,12)
	dot_reserve_move_unit_seq(dotMordred,16,11)
	dot_reserve_move_unit_seq(dotClarice,15,11)
	dot_reserve_move_unit_seq(dotLucius,17,11)
	exec_parallel_seq()
	wait_seq()

	
	change_face(Mordred,"Surprise")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定2")
	message("MA_01C900_420009")

	
	
	change_face(Mordred,"Normal")	
	message("MA_01C900_420010")
	close_speech_window()

	
	change_face(Dinatan,"Sad")	
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_420012")
	close_speech_window()

	
	change_face(Mordred,"Surprise")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "驚き")
	message("MA_01C900_420013")
	close_speech_window()

	
	change_face(Clarice,"Anger")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "怒り")
	message("MA_01C900_420014")
	close_speech_window()

	
	change_face(Lucius,"Normal")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "肯定")
	message("MA_01C900_420015")
	close_speech_window()

	
	change_face(Mordred,"Normal")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定2")
	message("MA_01C900_420016")


	
	change_face(Mordred,"Smile")	
	message("MA_01C900_420018")

	
	change_face(Mordred,"Smile")	
	message("MA_01C900_420019")
	
	
	change_face(Mordred,"Smile")	
	message("MA_01C900_420021")

	
	change_face(Mordred,"Smile")	
	 --PlayPartVoice("モルドレッド", "喜び")
	message("MA_01C900_420022")

	
	change_face(Mordred,"Surprise")	
	message("MA_01C900_420023")
	close_speech_window()


	move_camera(16,3,2.0)
	dot_reserve_move_unit_seq(dotNoir2,16,4)
	dot_reserve_move_unit_seq(dotDinatan,15,4)
	dot_reserve_move_unit_seq(dotMordred,16,3)
	dot_reserve_move_unit_seq(dotClarice,15,3)
	dot_reserve_move_unit_seq(dotLucius,18,4)
	exec_parallel_seq()
	wait_seq()

	dot_move_unit_seq(dotLucius,17,4)
	wait_seq()
	dot_unit_dir(dotLucius,3)

	change_camera_angle(25.0,2.0)
	wait_camera()
	
	
	change_face(Mordred,"Surprise")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_420025")
	close_speech_window()

	bgm_play("BGM_ADV_Serious2")


	dot_move_height(dotMazoe,1,2,2)
	dot_move_height(dotTyronoe,1,2,2)
	dot_move_height(dotThiten,1,2,2)
	dot_move_height(dotThiton,1,2,2)

	
	dot_disp_unit(dotMazoe,true)
	dot_disp_unit(dotTyronoe,true)
	dot_disp_unit(dotThiten,true)
	dot_disp_unit(dotThiton,true)

	wait_time(1.0)
	
	dot_disp_weapon(dotNoir2,true)
	dot_disp_weapon(dotDinatan,true)
	dot_disp_weapon(dotMordred,true)
	dot_disp_weapon(dotClarice,true)
	dot_disp_weapon(dotLucius,true)
	
	wait_time(0.2)
	
	
	
	change_face(Mazoe,"Normal")	
	open_speech_window("CHRNAME_SISTERS_2",nil,Mazoe)
	 --PlayPartVoice("マゾエー", "肯定")
	message("MA_01C900_420027")
	close_speech_window()

	
	change_face(Mordred,"Smile")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定3")
	message("MA_01C900_420029")
	close_speech_window()
		
	
	show_image("101040280", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)--0.6秒+0.5秒	
	
	change_face(Tyronoe,"Smile")	
	open_simple_window("CHRNAME_SISTERS_6",nil,nil)
	 --PlayPartVoice("ティーロノエー", "笑い")
	message("MA_01C900_420030")
	close_simple_window()
	
	
	scale_to_image(1.3,1.3,5.0,EaseIn)
	move_to_image(-200,-270,5.0,EaseIn)	

	
	change_face(Thiten,"Normal")	
	open_simple_window("CHRNAME_SISTERS_7",nil,nil)
	 --PlayPartVoice("ティーテン", "肯定")
	message("MA_01C900_420031")
	close_simple_window()

	
	
	change_face(Lucius,"Surprise")	
	open_simple_window("CHRNAME_LUCIUS",nil,nil)
	 --PlayPartVoice("ルーシャス", "驚き")
	message("MA_01C900_420032")
	close_simple_window()

	
	change_face(Thiton,"Smile")	
	open_simple_window("CHRNAME_SISTERS_8",nil,nil)
	 --PlayPartVoice("ティートン", "笑い")
	message("MA_01C900_420034")
	close_simple_window()
	
	hide_image(STILL_SWITCH_TIME) --0.6秒
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒	
	
	dot_move_unit_seq(dotLucius,17,3)
	wait_seq()
	
	
	change_face(Lucius,"Normal")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "肯定")	
	message("MA_01C900_420036")
	close_speech_window()

	
	
	
	change_face(Mazoe,"Anger")	
	open_speech_window("CHRNAME_SISTERS_2",nil,Mazoe)
	 --PlayPartVoice("マゾエー", "怒り")	
	message("MA_01C900_420038")
	close_speech_window()

	
	change_face(Lucius,"Normal")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "悩む")	
	message("MA_01C900_420039")

	
	change_face(Lucius,"Normal")	
	message("MA_01C900_420040")
	close_speech_window()

	
	change_face(Clarice,"Sad")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "悲しみ")	
	message("MA_01C900_420041")
	close_speech_window()

	
	change_face(Tyronoe,"Anger")	
	open_speech_window("CHRNAME_SISTERS_6",nil,Tyronoe)
	 --PlayPartVoice("ティーロノエー", "怒り")	
	message("MA_01C900_420042")
	close_speech_window()

	
	change_face(Lucius,"Smile")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "笑い")	
	message("MA_01C900_420043")
	close_speech_window()

	
	
	
	on_active(Ef_Portal_E1)
	on_active(Ef_Portal_E4)
	on_active(Ef_Portal_E5)
	on_active(Ef_Portal_E6)
	on_active(Ef_Portal_E7)
	on_active(Ef_Portal_E8)
	on_active(Ef_Portal_E9)
	on_active(Ef_Portal_E10)
	on_active(Ef_Portal_E11)
	on_active(Ef_Portal_E13)
	on_active(Ef_Portal_E14)
	on_active(Ef_Portal_E15)
	on_active(Ef_Portal_E16)
	on_active(Ef_Portal_E17)
	on_active(Ef_Portal_E18)
	
	local gridpos=get_grid_position(12,2)
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	local gridpos=get_grid_position(13,4)
	set_pos(Ef_Portal_E4,gridpos)
	set_scale(Ef_Portal_E4,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E4)
	local gridpos=get_grid_position(19,3)
	set_pos(Ef_Portal_E5,gridpos)
	set_scale(Ef_Portal_E5,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E5)
	local gridpos=get_grid_position(19,4)
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	local gridpos=get_grid_position(20,3)
	set_pos(Ef_Portal_E7,gridpos)
	set_scale(Ef_Portal_E7,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E7)
	local gridpos=get_grid_position(18,6)
	set_pos(Ef_Portal_E8,gridpos)
	set_scale(Ef_Portal_E8,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E8)
	local gridpos=get_grid_position(14,5)
	set_pos(Ef_Portal_E9,gridpos)
	set_scale(Ef_Portal_E9,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E9)
	local gridpos=get_grid_position(15,6)
	set_pos(Ef_Portal_E10,gridpos)
	set_scale(Ef_Portal_E10,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E10)
	local gridpos=get_grid_position(14,4)
	set_pos(Ef_Portal_E11,gridpos)
	set_scale(Ef_Portal_E11,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E11)
	local gridpos=get_grid_position(18,7)
	set_pos(Ef_Portal_E13,gridpos)
	set_scale(Ef_Portal_E13,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E13)
	local gridpos=get_grid_position(15,7)
	set_pos(Ef_Portal_E14,gridpos)
	set_scale(Ef_Portal_E14,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E14)
	local gridpos=get_grid_position(16,7)
	set_pos(Ef_Portal_E15,gridpos)
	set_scale(Ef_Portal_E15,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E15)
	local gridpos=get_grid_position(16,6)
	set_pos(Ef_Portal_E16,gridpos)
	set_scale(Ef_Portal_E16,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E16)
	local gridpos=get_grid_position(17,7)
	set_pos(Ef_Portal_E17,gridpos)
	set_scale(Ef_Portal_E17,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E17)
	local gridpos=get_grid_position(17,6)
	set_pos(Ef_Portal_E18,gridpos)
	set_scale(Ef_Portal_E18,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E18)



	dot_place_unit(barbaroi1,12,2)
	dot_place_unit(barbaroi4,13,4)
	dot_place_unit(barbaroi5,19,3)
	dot_place_unit(barbaroi6,19,4)
	dot_place_unit(barbaroi7,20,3)
	dot_place_unit(barbaroi9,14,4)
	dot_place_unit(barbaroi10,18,7)
	dot_place_unit(barbaroi11,15,7)
	dot_place_unit(barbaroi12,16,7)
	dot_place_unit(barbaroi13,17,7)
	dot_place_unit(barbaroi14,15,6)
	dot_place_unit(barbaroi15,16,6)
	dot_place_unit(barbaroi16,17,6)
	dot_place_unit(barbaroi17,14,5)
	dot_place_unit(barbaroi18,18,6)
	
	
	wait_time(0.2)
	dot_disp_unit(barbaroi1,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi9,true)
	dot_disp_unit(barbaroi10,true)
	dot_disp_unit(barbaroi11,true)
	dot_disp_unit(barbaroi12,true)
	dot_disp_unit(barbaroi13,true)
	dot_disp_unit(barbaroi14,true)
	dot_disp_unit(barbaroi15,true)
	dot_disp_unit(barbaroi16,true)
	dot_disp_unit(barbaroi17,true)
	dot_disp_unit(barbaroi18,true)
	
	wait_time(1.5)
	
	
	
	change_face(Mazoe,"Anger")	
	open_speech_window("CHRNAME_SISTERS_2",nil,Mazoe)
	 --PlayPartVoice("マゾエー", "激怒")	
	message("MA_01C900_420045")
	close_speech_window()
	
	
	
	bgm_play("BGM_ADV_Revenge")
	
	change_face(Mordred,"Serious")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定")	
	message("MA_01C900_420047")
	close_speech_window()

	
	
	
	change_face(Clarice,"Normal")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "肯定")
	message("MA_01C900_420049")
	close_speech_window()
	
	
	change_face(Mordred,"Serious")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_420051")
	close_speech_window()

	
	change_face(Lucius,"Surprise")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "肯定2")	
	message("MA_01C900_420052")
	close_speech_window()

	
	
	change_face(Mordred,"Pain")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "苦しみ")	
	message("MA_01C900_420053")
	close_speech_window()

	
	change_face(Clarice,"Sad")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	message("MA_01C900_420055")
	close_speech_window()

	
	
	change_face(Mordred,"Serious")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定2")	
	message("MA_01C900_420057")
	close_speech_window()

	
	change_face(Clarice,"Normal")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	message("MA_01C900_420058")

	
	
	change_face(Clarice,"Smile")	
	 --PlayPartVoice("クラリス", "笑い")	
	message("MA_01C900_420060")
	close_speech_window()

	change_camera_angle(45.0,2.0)

	
	dot_unit_dir(dotClarice,2)

	dot_reserve_move_unit_seq(dotMordred,5,3)
	dot_reserve_move_unit_seq(dotLucius,4,3)
	dot_reserve_move_unit_seq(dotNoir2,5,4)
	dot_reserve_move_unit_seq(dotDinatan,3,4)
	exec_parallel_seq()
	wait_seq()

	wait_camera()
	
	
	change_face(Thiton,"Smile")	
	open_speech_window("CHRNAME_SISTERS_8",nil,Thiton)
	 --PlayPartVoice("ティートン", "笑い")	
	message("MA_01C900_420062")
	close_speech_window()

	
	dot_remove_unit(dotNoir2)
	dot_remove_unit(dotDinatan)
	dot_remove_unit(dotLucius)
	dot_remove_unit(dotMordred)

	
	change_face(Clarice,"Shy")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	message("MA_01C900_420064")
	close_speech_window()

	
	
	change_face(Tyronoe,"Normal")	
	open_speech_window("CHRNAME_SISTERS_6",nil,Tyronoe)
	 --PlayPartVoice("ティーロノエー", "落胆")	
	message("MA_01C900_420065")
	close_speech_window()

	
	dot_unit_dir(dotClarice,3)
	
	
	change_face(Clarice,"Normal")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "肯定")	
	message("MA_01C900_420067")
	close_speech_window()

	
	change_face(Thiten,"Normal")	
	open_speech_window("CHRNAME_SISTERS_7",nil,Thiten)
	message("MA_01C900_420068")
	close_speech_window()
	

	
	change_face(Clarice,"Anger")	
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	message("MA_01C900_420069")


	
	dot_change_anim(dotClarice,5)
	wait_time(0.7)
	
	
	change_face(Clarice,"Anger")	
	message("MA_01C900_420071")
	close_speech_window()

	
	on_active(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotClarice,1)
	set_pos(Ef_Emblem1, locatorpos)

	play_particle(Ef_Emblem1)

	wait_time(1.0)

	on_active(Ef_Killers1)

	local gridpos = get_grid_position(15, 3)
	set_pos(Ef_Killers1, gridpos)
	play_particle(Ef_Killers1)
	wait_time(1.5)

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(15, 3)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)



	wait_time(0.7)
	dot_change_unit(dotClarice,dotClarice1,0.0)
	dot_disp_weapon(dotClarice1,true)
	dot_change_anim(dotClarice1,5)

	wait_time(1.5)

	stop_particle(Ef_Killers1)

	wait_time(2.5)
	
	change_face(Clarice1,"Normal")	
	open_speech_window("CHRNAME_CLARICE2",Clarice1,nil)
	 --PlayPartVoice("クラリス", "肯定")	
	message("MA_01C900_420073")

	
	change_face(Clarice1,"Anger")	
	message("MA_01C900_420074")
	close_speech_window()

	
	se_play("SE_ADV_MA_01B111_03_Sword")	
	
	wait_time(0.3)
	open_cutin(1,1)
	on_cutin(1,Clarice1,"Normal",0)
	
	change_face(Clarice1,"Normal")	
	open_speech_window("CHRNAME_CLARICE2",nil,nil)
	message("MA_01C900_420076")
	close_speech_window()

	close_cutin()	
	
	dot_change_anim(dotClarice1,0)

	wait_time(1.0)


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,18,27,0)
	pbadv_setup_101012_Dinatan_preload(0,true,17,27,0)
	pbadv_setup_101051_Lucius_preload(0,true,19,26,0)
	pbadv_setup_101022_Mordred_preload(0,true,18,26,0)
	pbadv_setup_101023_Clarice_preload(0,true,17,26,0)
	pbadv_setup_101023_Clarice_preload(1,true,41,41,0)
	pbadv_setup_101043_Mazoe_preload(true,13,1,0)
	pbadv_setup_101047_Tyronoe_preload(true,15,0,0)
	pbadv_setup_101048_Thiten_preload(true,17,0,0)
	pbadv_setup_101049_Thiton_preload(true,19,1,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem09", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_image_preload("101040280", "content_still_10104028_image", "101040280_StillImage")
	load_image_preload("10102001", "content_still_10102001_image", "101020010_StillImage")
	preload_sound("BGM_ADV_Serious2")
	preload_sound("BGM_ADV_Revenge")
end
