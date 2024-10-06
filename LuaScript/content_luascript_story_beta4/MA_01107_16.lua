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
	
	pbadv_setup_101013_Gawain(0,true,12,16,0)	

	pbadv_setup_101010_Lancelot(3,true,12,30,0)	
	
	
	
	pbadv_setup_101051_Lucius(0,true,10,17,0)	
	
	pbadv_setup_101052_Vernarth(0,true,10,16,0)	
	
	pbadv_setup_101039_Fren(0,true,15,16,0) 
	
	pbadv_setup_101038_Lola(0,true,15,15,0) 
	
	pbadv_setup_101037_Rasia(3,true,15,17,0) 

	
	dotroma3=dot_reserve_ally(401039001,11,19,0)
	dot_set_weapon(dotroma3,101010001)
	dotroma4=dot_reserve_ally(401039001,12,19,0)
	dot_set_weapon(dotroma4,101010001)
	dotroma5=dot_reserve_ally(401039001,13,19,0)
	dot_set_weapon(dotroma5,101010001)
	dotroma6=dot_reserve_ally(401039001,14,19,0)
	dot_set_weapon(dotroma6,101010001)
	dotroma12=dot_reserve_ally(401040001,15,18,0)
	dot_set_weapon(dotroma12,101010001)
	dotroma13=dot_reserve_ally(401040001,16,18,0)
	dot_set_weapon(dotroma13,101010001)
	dotroma14=dot_reserve_ally(401040001,17,18,0)
	dot_set_weapon(dotroma14,101010001)
	dotroma15=dot_reserve_ally(401040001,10,18,0)
	dot_set_weapon(dotroma15,101010001)
	dotroma16=dot_reserve_ally(401040001,9,18,0)
	dot_set_weapon(dotroma16,101010001)
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
	dotroma47=dot_reserve_ally(401040001,14,14,0)
	dot_set_weapon(dotroma47,101010001)
	dotroma48=dot_reserve_ally(401040001,15,14,0)
	dot_set_weapon(dotroma48,101010001)
	dotroma49=dot_reserve_ally(401040001,16,14,0)
	dot_set_weapon(dotroma49,101010001)
	dotroma50=dot_reserve_ally(401040001,17,14,0)
	dot_set_weapon(dotroma50,101010001)

	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	dot_unit_dir(dotNoir2,2)	
	dot_unit_dir(dotGawain,2)	
	dot_unit_dir(dotFren,2)
	dot_unit_dir(dotLola,2)
	dot_unit_dir(dotRasia3,2)
	
	dot_unit_dir(dotroma5,2)
	dot_unit_dir(dotroma6,2)
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

	
	
	dot_disp_weapon(dotGawain,false)
	dot_disp_weapon(dotVernarth,true)
	dot_disp_weapon(dotLucius,true)

	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(12,17,0.0)
	
	dot_change_anim(dotGawain,1)
	dot_change_anim(dotNoir2,1)
	dot_change_anim(dotGuinevere,1)
	dot_change_anim(dotTristan,1)
	
	Ef_Shockwave02=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true)
end





function Play()
	fadein(0)
	Play_start(true)







	dot_disp_unit(dotLancelot3,true)
	dot_move_unit_seq(dotLancelot3,12,20)
	wait_seq()

	dot_attack_seq(dotLancelot3,dotroma5)
	wait_seq()

	on_active(Ef_Shockwave02)
	local gridpos=get_grid_position(12,19)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)

	
	dot_change_anim(dotroma3,6)
	dot_change_anim(dotroma4,6)
	dot_change_anim(dotroma5,6)
	dot_change_anim(dotroma6,6)
	dot_play_particle_unit(dotroma4,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotroma5,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotroma3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotroma6,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	

	
	
	
	
	
	dot_move_knockback(dotroma3,10,19,0.1,2)
	dot_move_knockback(dotroma4,11,19,0.1,2)
	dot_move_knockback(dotroma6,15,19,0.1,2)
	dot_move_knockback(dotroma5,14,19,0.1,2)
	
	wait_time(0.7)
	
	dot_remove_unit(dotroma3)
	dot_remove_unit(dotroma4)
	dot_remove_unit(dotroma5)
	dot_remove_unit(dotroma6)

	dot_move_unit_seq(dotLancelot3,12,19)
	wait_seq()

	dot_unit_dir(dotLancelot3,2)




	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160002")
	



	change_face(Lancelot3, "Normal")
	message("MA_01107_160004")
	close_speech_window()



	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160006")
	close_speech_window()


	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160007")
	close_speech_window()


	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160008")
	close_speech_window()


	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160009")
	close_speech_window()


	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_160010")
	close_speech_window()


	dot_move_unit_seq(dotLancelot3,11,19)
	wait_seq()
	dot_move_unit_seq(dotLancelot3,11,17)
	wait_seq()

	dot_unit_dir(dotLancelot3,2)



	change_face(Lancelot3,"Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160012")
	close_speech_window()


	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_160013")
	close_speech_window()



	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160015")
	



	
	MA_01107_16_select1()
	
	open_select_window_tag(Noir2,"Normal","MA_01107_160017","MA_01107_160018")	
	close_speech_window()

	if is_select(1) then			
		MA_01107_16_select1_1()
 
	else       
		MA_01107_16_select1_2()
 
	end
	MA_01107_16_end()
 
end
 
function MA_01107_16_select1()
 
end
 
function MA_01107_16_select1_1()



	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_160020")
	close_speech_window()


	change_face(Lancelot3,"Smile")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160021")


	message("MA_01107_160022")


	change_face(Lancelot3,"Smile")
	message("MA_01107_160023")
	close_speech_window()
	
end
 
 
function MA_01107_16_select1_2()




	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_160025")
	close_speech_window()



	change_face(Lancelot3,"Sad")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160027")


	change_face(Lancelot3,"Normal")
	message("MA_01107_160028")
	close_speech_window()
	
end
 
 
function MA_01107_16_end()






	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160030")


	message("MA_01107_160031")
	close_speech_window()


	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_160032")
	close_speech_window()	


	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160033")
	close_speech_window()
	
	move_camera(14,17,0.5)
	wait_time(1.0)


	change_face(Fren,"Normal")
	open_speech_window("CHRNAME_FREN",nil,Fren)
	message("MA_01107_160034")
	close_speech_window()
	
	move_camera(12,17,0.5)


	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01107_160035")


	message("MA_01107_160036")
	close_speech_window()	


	dot_move_unit_seq(dotGawain,13,16)
	wait_seq()
	dot_reserve_move_unit_seq(dotGuinevere,14,29)
	dot_reserve_move_unit_seq(dotNoir2,12,30)
	dot_reserve_move_unit_seq(dotTristan,13,30)
	dot_reserve_move_unit_seq(dotGawain,12,29)
	exec_parallel_seq()
	wait_seq()


	dot_reserve_move_unit_seq(dotFren,14,16)
	dot_reserve_move_unit_seq(dotLola,14,15)
	dot_reserve_move_unit_seq(dotLancelot3,13,17)
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotFren,2)
	dot_unit_dir(dotLola,2)

	dot_remove_unit(dotGuinevere)	
	dot_remove_unit(dotNoir2)	
	dot_remove_unit(dotTristan)	

	

	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160038")
	close_speech_window()


	dot_move_unit_seq(dotVernarth,11,17)	
	wait_seq()
	dot_unit_dir(dotVernarth,3)
	dot_unit_dir(dotLancelot3,2)


	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01107_160040")
	close_speech_window()


	change_face(Lucius,"Surprise")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160041")
	close_speech_window()


	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01107_160042")


	message("MA_01107_160043")
	

	message("MA_01107_160044")


	message("MA_01107_160045")
	close_speech_window()


	change_face(Lucius,"Sad")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160046")
	close_speech_window()
	
	
	wait_time(1.0)



	dot_disp_weapon(dotVernarth,false)
	dot_disp_weapon(dotRasia3,false)
	dot_disp_weapon(dotLola,false)
	dot_disp_weapon(dotFren,false)
	dot_disp_weapon(dotLucius,false)

	wait_time(1.0)

	dot_disp_weapon(dotroma3,false)
	dot_disp_weapon(dotroma4,false)
	dot_disp_weapon(dotroma5,false)
	dot_disp_weapon(dotroma6,false)
	dot_disp_weapon(dotroma12,false)
	dot_disp_weapon(dotroma13,false)
	dot_disp_weapon(dotroma14,false)
	dot_disp_weapon(dotroma15,false)
	dot_disp_weapon(dotroma16,false)
	dot_disp_weapon(dotroma22,false)
	dot_disp_weapon(dotroma23,false)
	dot_disp_weapon(dotroma24,false)
	dot_disp_weapon(dotroma25,false)
	dot_disp_weapon(dotroma26,false)
	dot_disp_weapon(dotroma27,false)
	dot_disp_weapon(dotroma28,false)
	dot_disp_weapon(dotroma29,false)
	dot_disp_weapon(dotroma30,false)
	dot_disp_weapon(dotroma30,false)
	dot_disp_weapon(dotroma31,false)
	dot_disp_weapon(dotroma32,false)
	dot_disp_weapon(dotroma33,false)
	dot_disp_weapon(dotroma34,false)
	dot_disp_weapon(dotroma35,false)
	dot_disp_weapon(dotroma36,false)
	dot_disp_weapon(dotroma37,false)
	dot_disp_weapon(dotroma38,false)
	dot_disp_weapon(dotroma39,false)
	dot_disp_weapon(dotroma40,false)
	dot_disp_weapon(dotroma41,false)
	dot_disp_weapon(dotroma42,false)
	dot_disp_weapon(dotroma43,false)
	dot_disp_weapon(dotroma44,false)
	dot_disp_weapon(dotroma45,false)
	dot_disp_weapon(dotroma46,false)
	dot_disp_weapon(dotroma47,false)
	dot_disp_weapon(dotroma48,false)
	dot_disp_weapon(dotroma49,false)
	dot_disp_weapon(dotroma50,false)

	wait_time(0.1)

	dot_disp_weapon(dotLancelot3,false)


	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160048")
	close_speech_window()


	move_camera(12,19,1.0)
	dot_move_unit_seq(dotGawain,12,20)
	wait_seq()
	dot_unit_dir(dotGawain,2)
	

	change_face(Gawain,"Smile")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01107_160050")
	close_speech_window()


	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01107_160051")


	change_face(Vernarth,"Normal")
	message("MA_01107_160052")
	close_speech_window()


	change_face(Gawain,"strange")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01107_160053")
	close_speech_window()


	change_face(Vernarth,"Smile")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01107_160054")


	message("MA_01107_160055")
	close_speech_window()


	change_face(Gawain,"Surprise")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01107_160056")


	change_face(Gawain,"Sad")
	message("MA_01107_160057")
	close_speech_window()


	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160058")
	
	


	message("MA_01107_160059")


	message("MA_01107_160061")
	close_speech_window()	


	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot3,nil)
	message("MA_01107_160062")
	close_speech_window()


	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius)
	message("MA_01107_160063")


	change_face(Lucius,"Smile")
	message("MA_01107_160064")



	message("MA_01107_160066")
	close_speech_window()


	wait_time(0.5)

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
	pbadv_setup_101013_Gawain_preload(0,true,12,16,0)
	pbadv_setup_101010_Lancelot_preload(3,true,12,30,0)
	pbadv_setup_101051_Lucius_preload(0,true,10,17,0)
	pbadv_setup_101052_Vernarth_preload(0,true,10,16,0)
	pbadv_setup_101039_Fren_preload(0,true,15,16,0)
	pbadv_setup_101038_Lola_preload(0,true,15,15,0)
	pbadv_setup_101037_Rasia_preload(3,true,15,17,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true)
end
