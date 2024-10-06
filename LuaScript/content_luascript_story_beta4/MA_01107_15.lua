Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201100100","201100100")
	change_time_and_weather(1,1)
	


	pbadv_setup_101009_Noir(2,true,12,17,0)
	
	pbadv_setup_101011_Guinevere(0,true,13,16,0)
	
	pbadv_setup_101014_Tristan(0,true,13,17,0)
	
	pbadv_setup_101013_Gawain(0,true,11,16,0)
	
	

	pbadv_setup_101051_Lucius(0,true,10,17,0)	
	
	pbadv_setup_101052_Vernarth(0,true,10,16,0)	
	
	pbadv_setup_101039_Fren(0,true,17,16,0)
	
	pbadv_setup_101038_Lola(0,true,17,15,0)
	
	pbadv_setup_101037_Rasia(3,true,17,17,0)
	
	dotroma1=dot_reserve_ally(401039001,9,19,0)
	dot_set_weapon(dotroma1,101010001)
	dotroma2=dot_reserve_ally(401039001,10,19,0)
	dot_set_weapon(dotroma2,101010001)
	dotroma3=dot_reserve_ally(401039001,11,19,0)
	dot_set_weapon(dotroma3,101010001)
	dotroma4=dot_reserve_ally(401039001,12,19,0)
	dot_set_weapon(dotroma4,101010001)
	dotroma5=dot_reserve_ally(401039001,13,19,0)
	dot_set_weapon(dotroma5,101010001)
	dotroma6=dot_reserve_ally(401039001,14,19,0)
	dot_set_weapon(dotroma6,101010001)
	dotroma7=dot_reserve_ally(401039001,15,19,0)
	dot_set_weapon(dotroma7,101010001)
	dotroma8=dot_reserve_ally(401039001,16,19,0)
	dot_set_weapon(dotroma8,101010001)
	dotroma9=dot_reserve_ally(401040001,8,19,0)
	dot_set_weapon(dotroma9,105010001)
	dotroma10=dot_reserve_ally(401040001,7,19,0)
	dot_set_weapon(dotroma10,105010001)
	dotroma12=dot_reserve_ally(401040001,17,19,0)
	dot_set_weapon(dotroma12,101010001)
	dotroma13=dot_reserve_ally(401040001,18,19,0)
	dot_set_weapon(dotroma13,101010001)
	dotroma14=dot_reserve_ally(401040001,19,19,0)
	dot_set_weapon(dotroma14,105010001)
	dotroma22=dot_reserve_ally(401040001,7,18,0)
	dot_set_weapon(dotroma22,105010001)
	dotroma23=dot_reserve_ally(401040001,7,17,0)
	dot_set_weapon(dotroma23,105010001)
	dotroma24=dot_reserve_ally(401040001,7,16,0)
	dot_set_weapon(dotroma24,105010001)
	dotroma25=dot_reserve_ally(401040001,7,15,0)
	dot_set_weapon(dotroma25,105010001)
	dotroma26=dot_reserve_ally(401040001,7,14,0)
	dot_set_weapon(dotroma26,105010001)
	dotroma27=dot_reserve_ally(401040001,8,18,0)
	dot_set_weapon(dotroma27,101010001)
	dotroma28=dot_reserve_ally(401040001,8,17,0)
	dot_set_weapon(dotroma28,101010001)
	dotroma29=dot_reserve_ally(401040001,8,16,0)
	dot_set_weapon(dotroma29,101010001)
	dotroma30=dot_reserve_ally(401040001,8,15,0)
	dot_set_weapon(dotroma30,101010001)
	dotroma31=dot_reserve_ally(401040001,8,14,0)
	dot_set_weapon(dotroma31,101010001)
	dotroma32=dot_reserve_ally(401040001,9,14,0)
	dot_set_weapon(dotroma32,101010001)
	dotroma33=dot_reserve_ally(401040001,10,14,0)
	dot_set_weapon(dotroma33,101010001)
	dotroma34=dot_reserve_ally(401040001,11,14,0)
	dot_set_weapon(dotroma34,101010001)
	dotroma35=dot_reserve_ally(401040001,12,14,0)
	dot_set_weapon(dotroma35,101010001)
	dotroma36=dot_reserve_ally(401040001,13,14,0)
	dot_set_weapon(dotroma36,101010001)
	dotroma47=dot_reserve_ally(401040001,14,14,0)
	dot_set_weapon(dotroma47,101010001)
	dotroma48=dot_reserve_ally(401040001,15,14,0)
	dot_set_weapon(dotroma48,101010001)
	dotroma49=dot_reserve_ally(401040001,16,14,0)
	dot_set_weapon(dotroma49,101010001)
	dotroma50=dot_reserve_ally(401040001,17,14,0)
	dot_set_weapon(dotroma50,101010001)
	dotroma37=dot_reserve_ally(401040001,18,18,0)
	dot_set_weapon(dotroma37,101010001)
	dotroma38=dot_reserve_ally(401040001,18,17,0)
	dot_set_weapon(dotroma38,101010001)
	dotroma39=dot_reserve_ally(401040001,18,16,0)
	dot_set_weapon(dotroma39,101010001)
	dotroma40=dot_reserve_ally(401040001,18,15,0)
	dot_set_weapon(dotroma40,101010001)
	dotroma41=dot_reserve_ally(401040001,18,14,0)
	dot_set_weapon(dotroma41,101010001)
	dotroma42=dot_reserve_ally(401040001,19,18,0)
	dot_set_weapon(dotroma42,105010001)
	dotroma43=dot_reserve_ally(401040001,19,17,0)
	dot_set_weapon(dotroma43,105010001)
	dotroma44=dot_reserve_ally(401040001,19,16,0)
	dot_set_weapon(dotroma44,105010001)
	dotroma45=dot_reserve_ally(401040001,19,15,0)
	dot_set_weapon(dotroma45,105010001)
	dotroma46=dot_reserve_ally(401039001,19,14,0)
	dot_set_weapon(dotroma46,105010001)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotGawain,2)
	dot_unit_dir(dotFren,2)
	dot_unit_dir(dotLola,2)
	dot_unit_dir(dotRasia3,2)
	dot_unit_dir(dotroma5,2)
	dot_unit_dir(dotroma6,2)
	dot_unit_dir(dotroma7,2)
	dot_unit_dir(dotroma8,2)
	dot_unit_dir(dotroma12,2)
	dot_unit_dir(dotroma13,2)
	dot_unit_dir(dotroma14,2)
	dot_unit_dir(dotroma36,2)
	dot_unit_dir(dotroma37,2)
	dot_unit_dir(dotroma38,2)
	dot_unit_dir(dotroma39,2)
	dot_unit_dir(dotroma40,2)
	dot_unit_dir(dotroma41,2)
	dot_unit_dir(dotroma42,2)
	dot_unit_dir(dotroma43,2)
	dot_unit_dir(dotroma44,2)
	dot_unit_dir(dotroma45,2)
	dot_unit_dir(dotroma46,2)
	dot_unit_dir(dotroma47,2)
	dot_unit_dir(dotroma48,2)
	dot_unit_dir(dotroma49,2)
	dot_unit_dir(dotroma50,2)

	
	

	
	
	dot_disp_unit(dotLucius,false)
	dot_disp_unit(dotFren,false)
	dot_disp_unit(dotLola,false)
	dot_disp_unit(dotRasia3,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(13,17,0.0)
end





function Play()
	fadein(0)
	Play_start(true)




	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01107_150002")
	close_speech_window()


	dot_attack_seq(dotVernarth,dotGawain)
	dot_damage_seq(dotGawain,dotVernarth,true)
	

	wait_seq()
	dot_move_knockback(dotGawain,12,16,0.1,2)
	dot_change_anim(dotGawain,6)
	

	change_face(Gawain,"Pain")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01107_150003")
	close_speech_window()


	dot_change_anim(dotGawain,1)
	dot_change_anim(dotVernarth,0)



	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_150005")
	close_speech_window()


	
	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01107_150006")
	close_speech_window()


	dot_disp_unit(dotLucius,true)
	wait_time(0.5)


	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_150008")
	close_speech_window()


	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_150009")
	close_speech_window()	


	dot_disp_unit(dotFren,true)
	dot_disp_unit(dotLola,true)
	dot_disp_unit(dotRasia3,true)
	dot_reserve_move_unit_seq(dotFren,15,16)
	dot_reserve_move_unit_seq(dotLola,15,15)
	dot_reserve_move_unit_seq(dotRasia3,15,17)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotFren,2)
	dot_unit_dir(dotLola,2)
	dot_unit_dir(dotRasia3,2)
	wait_seq()


	change_face(Rasia3,"Normal")
	open_speech_window("CHRNAME_RASIA",nil,Rasia3)
	message("MA_01107_150011")
	close_speech_window()


	change_face(Tristan,"Sad")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_150012")
	close_speech_window()


	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_150013")
	close_speech_window()


	change_face(Lola,"Normal")
	open_speech_window("CHRNAME_LOLA",nil,Lola)
	message("MA_01107_150014")
	close_speech_window()


	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_150015")
	close_speech_window()


	change_face(Fren,"Normal")
	open_speech_window("CHRNAME_FREN",nil,Fren)
	message("MA_01107_150017")
	close_speech_window()


	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_150018")
	close_speech_window()


	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_150019")


	message("MA_01107_150020")


	
	message("MA_01107_150021")




	change_face(Lucius,"Smile")
	message("MA_01107_150023")
	close_speech_window()


	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_150025")



	change_face(Tristan,"Sad")
	message("MA_01107_150027")
	close_speech_window()


	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01107_150028")
	close_speech_window()




	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,12,17,0)
	pbadv_setup_101011_Guinevere_preload(0,true,13,16,0)
	pbadv_setup_101014_Tristan_preload(0,true,13,17,0)
	pbadv_setup_101013_Gawain_preload(0,true,11,16,0)
	pbadv_setup_101051_Lucius_preload(0,true,10,17,0)
	pbadv_setup_101052_Vernarth_preload(0,true,10,16,0)
	pbadv_setup_101039_Fren_preload(0,true,17,16,0)
	pbadv_setup_101038_Lola_preload(0,true,17,15,0)
	pbadv_setup_101037_Rasia_preload(3,true,17,17,0)
end
