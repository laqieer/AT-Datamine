Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201020000","201020000")
	change_time_and_weather(1,1)
	


	
	pbadv_setup_101051_Lucius(0,true,17,28,0)	
	
	pbadv_setup_101052_Vernarth(0,true,16,27,0)	
	
	pbadv_setup_101038_Lola(0,true,18,20,0)
	
	pbadv_setup_101042_Moronoe(true,17,22,0)

	pbadv_setup_101044_Gliten(true,19,22,0)

	pbadv_setup_101045_Glitonea(true,19,21,0)

	pbadv_setup_101046_Gliton(true,17,21,0)
	
	pbadv_setup_101013_Gawain(1,true,17,18,0)
	
	pbadv_setup_101018_Ragnar(1,true,18,18,0)
	
	dotroma1=dot_reserve_ally(401040001,5,19,0)
	dot_set_weapon(dotroma1,101010001)
	dotroma2=dot_reserve_ally(401040001,9,19,0)
	dot_set_weapon(dotroma2,101010001)
	dotroma3=dot_reserve_ally(401040001,10,19,0)
	dot_set_weapon(dotroma3,101010001)
	dotroma4=dot_reserve_ally(401040001,12,19,0)
	dot_set_weapon(dotroma4,101010001)
	dotroma5=dot_reserve_ally(401040001,13,19,0)
	dot_set_weapon(dotroma5,101010001)
	dotroma6=dot_reserve_ally(401040001,14,19,0)
	dot_set_weapon(dotroma6,101010001)
	dotroma7=dot_reserve_ally(401040001,15,19,0)
	dot_set_weapon(dotroma7,101010001)
	dotroma8=dot_reserve_ally(401040001,16,19,0)
	dot_set_weapon(dotroma8,101010001)
	dotroma9=dot_reserve_ally(401039001,17,19,0)
	dot_set_weapon(dotroma9,101010001)
	dotroma10=dot_reserve_ally(401039001,18,19,0)
	dot_set_weapon(dotroma10,101010001)
	dotroma11=dot_reserve_ally(401040001,19,19,0)
	dot_set_weapon(dotroma11,101010001)
	dotroma12=dot_reserve_ally(401040001,20,19,0)
	dot_set_weapon(dotroma12,101010001)
	dotroma13=dot_reserve_ally(401040001,22,19,0)
	dot_set_weapon(dotroma13,101010001)
	dotroma14=dot_reserve_ally(401040001,23,19,0)
	dot_set_weapon(dotroma14,101010001)
	dotroma17=dot_reserve_ally(401040001,24,19,0)
	dot_set_weapon(dotroma17,101010001)
	dotroma18=dot_reserve_ally(401040001,25,19,0)
	dot_set_weapon(dotroma18,101010001)
	dotroma19=dot_reserve_ally(401040001,26,19,0)
	dot_set_weapon(dotroma19,101010001)
	dotroma20=dot_reserve_ally(401040001,7,20,0)
	dot_set_weapon(dotroma20,104010001)
	dotroma21=dot_reserve_ally(401040001,8,20,0)
	dot_set_weapon(dotroma21,104010001)
	dotroma22=dot_reserve_ally(401040001,9,20,0)
	dot_set_weapon(dotroma22,104010001)
	dotroma23=dot_reserve_ally(401040001,10,20,0)
	dot_set_weapon(dotroma23,104010001)
	dotroma24=dot_reserve_ally(401040001,13,20,0)
	dot_set_weapon(dotroma24,104010001)
	dotroma25=dot_reserve_ally(401040001,14,20,0)
	dot_set_weapon(dotroma25,104010001)
	dotroma26=dot_reserve_ally(401040001,15,20,0)
	dot_set_weapon(dotroma26,104010001)
	dotroma27=dot_reserve_ally(401040001,16,20,0)
	dot_set_weapon(dotroma27,104010001)
	dotroma28=dot_reserve_ally(401040001,20,20,0)
	dot_set_weapon(dotroma28,104010001)
	dotroma29=dot_reserve_ally(401040001,21,20,0)
	dot_set_weapon(dotroma29,104010001)
	dotroma30=dot_reserve_ally(401040001,22,20,0)
	dot_set_weapon(dotroma30,104010001)
	dotroma31=dot_reserve_ally(401040001,23,20,0)
	dot_set_weapon(dotroma31,104010001)
	dotroma32=dot_reserve_ally(401040001,24,20,0)
	dot_set_weapon(dotroma32,104010001)
	dotroma33=dot_reserve_ally(401040001,25,20,0)
	dot_set_weapon(dotroma33,104010001)
	dotroma34=dot_reserve_ally(401040001,26,20,0)
	dot_set_weapon(dotroma34,104010005)
	
	
	
	
	
	
	
	
	
	
	
	

	
	barbaroi1=dot_reserve_enemy(1300,18,23,0)
	barbaroi2=dot_reserve_enemy(1300,19,23,0)
	barbaroi3=dot_reserve_enemy(1300,16,23,0)
	barbaroi4=dot_reserve_enemy(1300,17,23,0)
	barbaroi5=dot_reserve_enemy(1300,20,23,0)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	barbaroi88=dot_reserve_enemy(1,14,17,0)
	barbaroi89=dot_reserve_enemy(1,15,17,0)
	barbaroi90=dot_reserve_enemy(1,16,17,0)
	
	barbaroi92=dot_reserve_enemy(1,19,17,0)
	barbaroi93=dot_reserve_enemy(1,20,17,0)
	barbaroi94=dot_reserve_enemy(1,21,17,0)
	
	
	
	barbaroi98=dot_reserve_enemy(1,7,18,0)
	barbaroi99=dot_reserve_enemy(1,8,18,0)
	barbaroi100=dot_reserve_enemy(1,9,18,0)
	barbaroi101=dot_reserve_enemy(1,10,18,0)
	barbaroi102=dot_reserve_enemy(1,11,18,0)
	barbaroi103=dot_reserve_enemy(1,12,18,0)
	barbaroi104=dot_reserve_enemy(1,13,18,0)
	barbaroi105=dot_reserve_enemy(1,14,18,0)
	barbaroi106=dot_reserve_enemy(1,15,18,0)
	barbaroi107=dot_reserve_enemy(1,16,18,0)
	
	
	barbaroi110=dot_reserve_enemy(1,19,18,0)
	barbaroi111=dot_reserve_enemy(1,20,18,0)
	barbaroi112=dot_reserve_enemy(1,21,18,0)
	barbaroi113=dot_reserve_enemy(1,22,18,0)
	barbaroi114=dot_reserve_enemy(1,23,18,0)
	barbaroi115=dot_reserve_enemy(1,24,18,0)
	barbaroi116=dot_reserve_enemy(1,25,18,0)
	barbaroi121=dot_reserve_enemy(1,26,18,0)
	barbaroi117=dot_reserve_enemy(1,5,20,0)
	barbaroi118=dot_reserve_enemy(1,7,19,0)
	barbaroi119=dot_reserve_enemy(1,6,19,0)
	barbaroi120=dot_reserve_enemy(1,6,20,0)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotVernarth,0)
	dot_unit_dir(dotLucius,2)
	dot_unit_dir(dotLola,0)
	dot_unit_dir(dotMoronoe,3)
	dot_unit_dir(dotGlitonea,3)
	dot_unit_dir(dotGliton,3)
	dot_unit_dir(dotGliten,3)
	dot_unit_dir(dotGawain1,2)
	dot_unit_dir(dotRagnar1,2)
	dot_unit_dir(barbaroi98,1)
	dot_unit_dir(barbaroi99,1)
	dot_unit_dir(barbaroi100,1)
	dot_unit_dir(barbaroi101,1)
	dot_unit_dir(barbaroi102,1)
	dot_unit_dir(barbaroi103,1)
	dot_unit_dir(barbaroi104,1)
	dot_unit_dir(barbaroi105,1)
	dot_unit_dir(barbaroi106,1)
	dot_unit_dir(barbaroi107,1)
	
	
	dot_unit_dir(barbaroi110,1)
	dot_unit_dir(barbaroi111,1)
	dot_unit_dir(barbaroi112,1)
	dot_unit_dir(barbaroi113,1)
	dot_unit_dir(barbaroi114,1)
	dot_unit_dir(barbaroi115,1)
	dot_unit_dir(barbaroi116,1)
	dot_unit_dir(barbaroi117,1)
	dot_unit_dir(barbaroi118,1)
	dot_unit_dir(barbaroi119,1)
	dot_unit_dir(barbaroi120,1)
	dot_unit_dir(barbaroi121,1)

	dot_unit_dir(dotroma20,2)

	dot_unit_dir(barbaroi1,3)
	dot_unit_dir(barbaroi2,3)
	dot_unit_dir(barbaroi3,3)
	dot_unit_dir(barbaroi4,3)
	dot_unit_dir(barbaroi5,3)
	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(45.0,0.0)

	
	
	move_camera(7,19,0.0)
end





function Play()
	fadein(0)
	Play_start(true)





	dot_change_anim(barbaroi118,3)
	dot_play_particle_unit(barbaroi118,"Ef_C_Swd_N_EmyAtk01",3,true)

	dot_change_anim(barbaroi119,3)
	dot_play_particle_unit(barbaroi119,"Ef_C_Swd_N_EmyAtk01",3,true)

	dot_change_anim(barbaroi120,3)
	dot_play_particle_unit(barbaroi120,"Ef_C_Swd_N_EmyAtk01",3,true)
	
	dot_change_anim(dotroma1,6)
	dot_play_particle_unit(dotroma1,"Ef_C_Cmn_N_Hit_EmySla01",3,true)
	
	dot_change_anim(dotroma20,6)
	dot_play_particle_unit(dotroma20,"Ef_C_Cmn_N_Hit_EmySla01",3,true)

	wait_time(0.5)

	dot_unit_dir(barbaroi118,1)
	dot_unit_dir(barbaroi120,1)
	
	dot_change_anim(barbaroi118,0)
	dot_change_anim(barbaroi119,0)
	dot_change_anim(barbaroi120,0)

	dot_play_particle_unit(dotroma1,"Ef_C_Cmn_Die01",1,true)
	dot_play_particle_unit(dotroma20,"Ef_C_Cmn_Die01",1,true)
	
	

	wait_time(0.3)

	dot_remove_unit(dotroma1)
	dot_remove_unit(dotroma20)

	wait_time(0.5)






	wait_time(0.2)
	move_camera(26,19,1.5)
	
	wait_camera()

	dot_change_anim(barbaroi115,3)
	dot_play_particle_unit(barbaroi115,"Ef_C_Swd_N_EmyAtk01",3,true)

	dot_change_anim(barbaroi116,3)
	dot_play_particle_unit(barbaroi116,"Ef_C_Swd_N_EmyAtk01",3,true)

	dot_change_anim(barbaroi121,3)
	dot_play_particle_unit(barbaroi121,"Ef_C_Swd_N_EmyAtk01",3,true)

	dot_change_anim(dotroma17,6)
	dot_play_particle_unit(dotroma17,"Ef_C_Cmn_N_Hit_EmySla01",3,true)
	
	dot_change_anim(dotroma18,6)
	dot_play_particle_unit(dotroma18,"Ef_C_Cmn_N_Hit_EmySla01",3,true)
	
	dot_change_anim(dotroma19,6)
	dot_play_particle_unit(dotroma19,"Ef_C_Cmn_N_Hit_EmySla01",3,true)

	wait_time(0.5)

	dot_unit_dir(barbaroi115,1)
	dot_unit_dir(barbaroi116,1)
	dot_unit_dir(barbaroi121,1)
	
	dot_change_anim(barbaroi115,0)
	dot_change_anim(barbaroi116,0)
	dot_change_anim(barbaroi121,0)

	dot_play_particle_unit(dotroma17,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma18,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma19,"Ef_C_Cmn_DieEmy01",1,true)

	wait_time(0.5)

	dot_remove_unit(dotroma17)
	dot_remove_unit(dotroma18)
	dot_remove_unit(dotroma19)

	wait_time(0.5)

	move_camera(18,20,0.5)
	wait_camera()


	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	




	
	change_face(Lola,"Anger")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	 --PlayPartVoice("ローラ", "激怒")
	message("MA_01C111_390002")
	close_speech_window()

	
	change_face(Gliten,"Smile")
	open_speech_window("CHRNAME_SISTERS_3",Gliten,nil)
	 --PlayPartVoice("グリーテン", "笑い")
	message("MA_01C111_390003")
	close_speech_window()

	
	change_face(Glitonea,"Smile")
	open_speech_window("CHRNAME_SISTERS_4",Glitonea,nil)
	 --PlayPartVoice("グリートーネア", "笑い")
	message("MA_01C111_390004")
	close_speech_window()

	
	change_face(Gliton,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",Gliton,nil)
	 --PlayPartVoice("グリートン", "笑い")
	message("MA_01C111_390005")
	close_speech_window()

	
	change_face(Lola,"Pain")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	 --PlayPartVoice("ローラ", "悲しみ")
	message("MA_01C111_390006")
	close_speech_window()

	dot_unit_dir(dotGawain1,1)
	dot_unit_dir(dotRagnar1,1)

	
	dot_change_anim(barbaroi98,3)
	dot_change_anim(barbaroi99,3)
	dot_change_anim(barbaroi100,3)
	dot_change_anim(barbaroi101,3)
	dot_change_anim(barbaroi102,3)
	dot_change_anim(barbaroi103,3)
	dot_change_anim(barbaroi104,3)
	dot_change_anim(barbaroi105,3)
	dot_change_anim(barbaroi106,3)
	dot_change_anim(barbaroi107,3)
	dot_change_anim(barbaroi110,3)
	dot_change_anim(barbaroi111,3)
	dot_change_anim(barbaroi112,3)
	dot_change_anim(barbaroi113,3)
	dot_change_anim(barbaroi114,3)
	dot_change_anim(barbaroi115,3)
	dot_change_anim(barbaroi116,3)
	dot_change_anim(barbaroi117,3)
	dot_change_anim(barbaroi118,3)
	dot_change_anim(barbaroi119,3)
	dot_change_anim(barbaroi120,3)
	dot_change_anim(barbaroi121,3)

	dot_change_anim(dotGawain1,3)
	dot_change_anim(dotRagnar1,3)
	
	dot_change_anim(dotroma2,6)
	dot_change_anim(dotroma3,6)
	dot_change_anim(dotroma4,6)
	dot_change_anim(dotroma5,6)
	dot_change_anim(dotroma6,6)
	dot_change_anim(dotroma7,6)
	dot_change_anim(dotroma8,6)
	dot_change_anim(dotroma9,6)
	dot_change_anim(dotroma10,6)
	dot_change_anim(dotroma11,6)
	dot_change_anim(dotroma12,6)
	dot_change_anim(dotroma13,6)
	dot_change_anim(dotroma14,6)
	dot_change_anim(dotroma17,6)
	dot_change_anim(dotroma18,6)
	dot_change_anim(dotroma19,6)

	wait_time(0.5)
	
	
	dot_play_particle_unit(dotroma2,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma3,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma4,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma5,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma6,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma7,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma8,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma9,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma10,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma11,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma12,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma13,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma14,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma17,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma18,"Ef_C_Cmn_DieEmy01",1,true)
	dot_play_particle_unit(dotroma19,"Ef_C_Cmn_DieEmy01",1,true)
	
	wait_time(0.3)
	
	
	dot_remove_unit(dotroma2)
	dot_remove_unit(dotroma3)
	dot_remove_unit(dotroma4)
	dot_remove_unit(dotroma5)
	dot_remove_unit(dotroma6)
	dot_remove_unit(dotroma7)
	dot_remove_unit(dotroma8)
	dot_remove_unit(dotroma9)
	dot_remove_unit(dotroma10)
	dot_remove_unit(dotroma11)
	dot_remove_unit(dotroma12)
	dot_remove_unit(dotroma13)
	dot_remove_unit(dotroma14)
	dot_remove_unit(dotroma17)
	dot_remove_unit(dotroma18)
	dot_remove_unit(dotroma19)
	wait_seq()
	
	
	wait_time(0.5)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

	dot_change_anim(barbaroi98,0)
	dot_change_anim(barbaroi99,0)
	dot_change_anim(barbaroi100,0)
	dot_change_anim(barbaroi101,0)
	dot_change_anim(barbaroi102,0)
	dot_change_anim(barbaroi103,0)
	dot_change_anim(barbaroi104,0)
	dot_change_anim(barbaroi105,0)
	dot_change_anim(barbaroi106,0)
	dot_change_anim(barbaroi107,0)
	
	
	dot_change_anim(barbaroi110,0)
	dot_change_anim(barbaroi111,0)
	dot_change_anim(barbaroi112,0)
	dot_change_anim(barbaroi113,0)
	dot_change_anim(barbaroi114,0)
	dot_change_anim(barbaroi115,0)
	dot_change_anim(barbaroi116,0)
	dot_change_anim(barbaroi117,0)
	dot_change_anim(barbaroi118,0)
	dot_change_anim(barbaroi119,0)
	dot_change_anim(barbaroi120,0)
	dot_change_anim(barbaroi121,0)

	
	dot_reserve_move_unit_seq(dotGawain1,17, 19)
	dot_reserve_move_unit_seq(dotRagnar1,18, 19)
	exec_parallel_seq()
	
	wait_seq()


	dot_unit_dir(dotGawain1,2)
	dot_unit_dir(dotRagnar1,2)
	
	
	change_face(Gawain1,"Normal")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	 --PlayPartVoice("ガウェイン", "肯定2")
	message("MA_01C111_390008")
	close_speech_window()

	
	change_face(Lola,"Pain")
	open_speech_window("CHRNAME_LOLA",Lola,nil)
	message("MA_01C111_390009")
	close_speech_window()

	
	
	change_face(Ragnar1,"Sad")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar1)
	message("MA_01C111_390011")
	close_speech_window()

	
	change_face(Moronoe,"Smile")
	open_speech_window("CHRNAME_SISTERS_1",Moronoe,nil)
	 --PlayPartVoice("モーロノエー", "笑い")
	message("MA_01C111_390012")
	close_speech_window()

	
	change_face(Ragnar1,"Sad")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar1)
	message("MA_01C111_390013")
	close_speech_window()

	
	
	
	dot_attack_seq(dotRagnar1,dotLola)
	dot_damage_seq(dotLola,dotRagnar1,false)
	wait_time(0.2)
	dot_change_anim(dotLola,6)
	wait_time(0.5)
	dot_attack_seq(dotLola,dotRagnar1)
	dot_damage_seq(dotRagnar1,dotLola,false)
	wait_seq()
	
	
	
	move_camera(16,28,0.7)
	wait_time(0.9)
	
	
	
	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "肯定")
	message("MA_01C111_390015")
	close_speech_window()

	
	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	 --PlayPartVoice("ヴェルナルス", "肯定3")
	message("MA_01C111_390016")
	close_speech_window()

	
	change_face(Lucius,"Surprise")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C111_390017")
	close_speech_window()

	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01C111_390018")
	close_speech_window()

	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "挨拶")
	message("MA_01C111_390019")
	close_speech_window()

	
	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01C111_390020")
	close_speech_window()

	
	change_face(Lucius,"Sad")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "悩む")
	message("MA_01C111_390021")
	close_speech_window()

	
	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01C111_390022")
	close_speech_window()



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101051_Lucius_preload(0,true,17,28,0)
	pbadv_setup_101052_Vernarth_preload(0,true,16,27,0)
	pbadv_setup_101038_Lola_preload(0,true,18,20,0)
	pbadv_setup_101042_Moronoe_preload(true,17,22,0)
	pbadv_setup_101044_Gliten_preload(true,19,22,0)
	pbadv_setup_101045_Glitonea_preload(true,19,21,0)
	pbadv_setup_101046_Gliton_preload(true,17,21,0)
	pbadv_setup_101013_Gawain_preload(1,true,17,18,0)
	pbadv_setup_101018_Ragnar_preload(1,true,18,18,0)
end
