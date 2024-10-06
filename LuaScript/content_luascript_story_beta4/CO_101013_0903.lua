

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	init_psbattleadv("201000000", "201000000")
	
	change_time_and_weather(1,1)
	
	
	 
    pbadv_setup_101009_Noir(2,true,20,39,0)
    
    
	pbadv_setup_101013_Gawain(0,true,19,35,0)
	
	
	pbadv_setup_101018_Ragnar(1,true,24,37,0)
	
	

	dotsoldier   = dot_reserve_ally(401036001,18 ,23 , 0)
	dotsoldier2  = dot_reserve_ally(401036001,15 ,24 , 0)
	dotsoldier3  = dot_reserve_ally(401036001,18 ,26 , 0)
	dotsoldier4  = dot_reserve_ally(401036001,15 ,28 , 0)
	dotsoldier5  = dot_reserve_ally(401036001,20 ,28 , 0)
	dotsoldier6  = dot_reserve_ally(401036001,14 ,30 , 0)
	dotsoldier7  = dot_reserve_ally(401036001,18 ,30 , 0)
	dotsoldier8  = dot_reserve_ally(401036001,22 ,30 , 0)
	dotsoldier9  = dot_reserve_ally(401036001,11 ,22 , 0)
	dotsoldier10 = dot_reserve_ally(401036001,15 ,33 , 0)
	dotsoldier11 = dot_reserve_ally(401036001,24 ,33 , 0)
	
	
	dot_set_weapon(dotsoldier, 101010001)
	dot_set_weapon(dotsoldier2, 101010001)
	dot_set_weapon(dotsoldier3, 101010001)
	dot_set_weapon(dotsoldier4, 101010001)
	dot_set_weapon(dotsoldier5, 101010001)
	dot_set_weapon(dotsoldier6, 101010001)
	dot_set_weapon(dotsoldier7, 101010001)
	dot_set_weapon(dotsoldier8, 101010001)
	dot_set_weapon(dotsoldier9, 101010001)
	dot_set_weapon(dotsoldier10, 101010001)
	dot_set_weapon(dotsoldier11, 101010001)

	
	
	barbaroi6  = dot_reserve_enemy(3,12 ,22 , 0)	
	barbaroi7  = dot_reserve_enemy(3,19 ,23 , 0)
	barbaroi8  = dot_reserve_enemy(3,16 ,24 , 0)
	barbaroi9  = dot_reserve_enemy(3,19 ,26 , 0)
	barbaroi10 = dot_reserve_enemy(3,16 ,28 , 0)
	barbaroi11 = dot_reserve_enemy(3,21 ,28 , 0)
	barbaroi12 = dot_reserve_enemy(3,15 ,30 , 0)
	barbaroi13m = dot_reserve_enemy(3,19 ,30 , 0)
	barbaroi16 = dot_reserve_enemy(3,23 ,30 , 0)
	barbaroi19m = dot_reserve_enemy(3,20 ,35 , 0)
	barbaroi20 = dot_reserve_enemy(3,25 ,33 , 0)
	barbaroi22 = dot_reserve_enemy(3,16 ,33 , 0)
	barbaroi23m = dot_reserve_enemy(3,24 ,36 , 0)
	barbaroi24m = dot_reserve_enemy(3,25 ,36 , 0)
	barbaroi25m = dot_reserve_enemy(3,21 ,38 , 0)
	barbaroi26m = dot_reserve_enemy(3,21 ,39 , 0)
	
	
	
	
	
	setup_complete_unit()
	

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(21, 38, 0.0)
	
	Ef_sun= load_particle("content_effect3d_common_adv", "Ef_C_Adv_Sunbeams_Lop", false, true)
	Ef_reply= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_reply2= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_reply3= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_reply4= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_reply5= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_reply6= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	Ef_reply7= load_particle("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)

	load_sound("BGM_Area_Acoustic")
	
	
end




function Play()
	fadein(0)
	Play_start(true)


		
	
	CO_101013_0903_select1()
	open_select_window_tag(Noir2, "Normal", "CO_101013_09030016", "CO_101013_09030017")	
	close_speech_window()	

	if is_select(1) then			
		CO_101013_0903_select1_1()
		
	elseif is_select(2) then		
		CO_101013_0903_select1_2()
		

	end
	
	
	CO_101013_0903_select2()
	
	open_select_window_tag(Noir2, "Normal", "CO_101013_09030048", "CO_101013_09030049")	
	close_speech_window()	

	if is_select(1) then			
		CO_101013_0903_select2_1()

	elseif is_select(2) then		
		CO_101013_0903_select2_2()
		
		end
	

	CO_101013_0903_end()


	end

	function CO_101013_0903_select1()
	
	
	se_play("SE_ADV_MA_01108_46_RomeSolduar_Guard")
	wait_time(0.4)
	se_play("SE_ADV_MA_01108_46_RomeSolduar_Guard")
	wait_time(1.0)
	
	
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(barbaroi25m,6)
	dot_change_anim(barbaroi26m,6)
	dot_play_particle_unit(barbaroi25m,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	dot_play_particle_unit(barbaroi26m,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	wait_time(0.2)
	dot_dying_unit_seq(barbaroi25m)
	dot_dying_unit_seq(barbaroi26m)
	wait_time(1.0)
	wait_seq()
	dot_change_anim(dotNoir2,0)
	
	dot_change_anim(dotRagnar1,3)
	dot_play_particle_unit(dotRagnar1,"Ef_C_Axe_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(barbaroi24m,6)
	dot_change_anim(barbaroi23m,6)
	dot_play_particle_unit(barbaroi24m,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	dot_play_particle_unit(barbaroi23m,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	wait_time(0.2)
	dot_dying_unit_seq(barbaroi24m)
	dot_dying_unit_seq(barbaroi23m)
	wait_time(1.0)
	wait_seq()
	dot_change_anim(dotRagnar1,0)
	move_camera(21, 38, 1.0)
	
	wait_camera()
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "悩む")
	message("CO_101013_09030002")
	close_speech_window()
	
	dot_change_anim(dotsoldier3,3)
	dot_play_particle_unit(dotsoldier3,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(barbaroi9,6)
	wait_time(0.4)
	dot_change_anim(dotsoldier3,0)
	dot_change_anim(barbaroi9,0)
	
	dot_change_anim(barbaroi13m,3)
	dot_play_particle_unit(barbaroi13m,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_change_anim(dotsoldier7,6)
	wait_time(0.4)
	dot_change_anim(barbaroi13m,0)
	dot_change_anim(dotsoldier7,0)

	dot_unit_dir(dotRagnar1, 2)

	
	change_face(Ragnar1, "Normal")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1 , nil)
	PlayPartVoice("ラグネル", "肯定")
	message("CO_101013_09030003")
	close_speech_window()
	
	dot_change_anim(dotGawain,3)
	dot_play_particle_unit(dotGawain,"Ef_C_Ham_N_Atk01",3,true)
	wait_time(0.2)
	dot_change_anim(barbaroi19m,6)
	dot_play_particle_unit(barbaroi19m,"Ef_C_Cmn_N_Hit_Str01",3,true)
	wait_time(0.2)
	dot_dying_unit_seq(barbaroi19m)
	wait_time(1.0)
	wait_seq()
	dot_change_anim(dotGawain,0)	
	
	move_camera(21, 38, 1.0)

	
	change_face(Gawain, "Normal")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "怒り")
	message("CO_101013_09030004")
	close_speech_window()
	
	dot_change_anim(dotsoldier6,3)
	dot_play_particle_unit(dotsoldier6,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi12)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier6,0)
	dot_change_anim(barbaroi12,0)
	
	dot_change_anim(dotsoldier8,3)
	dot_play_particle_unit(dotsoldier8,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotsoldier9,3)
	dot_play_particle_unit(dotsoldier9,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi16)
	dot_dodge_seq(barbaroi6)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier9,0)
	dot_change_anim(dotsoldier8,0)
	dot_change_anim(barbaroi16,0)
	
	dot_change_anim(barbaroi9,3)
	dot_play_particle_unit(barbaroi9,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier3)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier3,0)
	dot_change_anim(barbaroi9,0)
	
	dot_change_anim(barbaroi13m,3)
	dot_play_particle_unit(barbaroi13m,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier7)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier7,0)
	dot_change_anim(barbaroi13m,0)
	
	

	
	
	
	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "落胆")
	message("CO_101013_09030006")
	close_speech_window()
	
	dot_change_anim(dotsoldier2,3)
	dot_play_particle_unit(dotsoldier2,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi8)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier2,0)
	dot_change_anim(barbaroi8,0)
	
	dot_change_anim(barbaroi8,3)
	dot_play_particle_unit(barbaroi8,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier2)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier2,0)
	dot_change_anim(barbaroi8,0)

	
	change_face(Ragnar1, "Sad")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1 , nil)
	PlayPartVoice("ラグネル", "落胆")
	message("CO_101013_09030007")
	close_speech_window()

	dot_change_anim(dotsoldier6,3)
	dot_play_particle_unit(dotsoldier6,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi12)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier6,0)
	dot_change_anim(barbaroi12,0)
	
	dot_change_anim(dotsoldier8,3)
	dot_play_particle_unit(dotsoldier8,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(dotsoldier9,3)
	dot_play_particle_unit(dotsoldier9,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi16)
	dot_dodge_seq(barbaroi6)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier9,0)
	dot_change_anim(dotsoldier8,0)
	dot_change_anim(barbaroi16,0)
	
	dot_change_anim(barbaroi9,3)
	dot_play_particle_unit(barbaroi9,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier3)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier3,0)
	dot_change_anim(barbaroi9,0)
	
	dot_change_anim(barbaroi13m,3)
	dot_play_particle_unit(barbaroi13m,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier7)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier7,0)
	dot_change_anim(barbaroi13m,0)

	wait_time(1.0)

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101013_09030009")
	close_speech_window()
	
	move_camera(18, 34, 1.0)
	dot_move_unit_seq(dotNoir2,18, 39)
	wait_seq()
	dot_move_unit_seq(dotNoir2,18, 35)
	wait_seq()
	dot_unit_dir(dotNoir2, 3)
	
	

	
	
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("CO_101013_09030011")
	close_speech_window()
	
	dot_unit_dir(dotGawain, 2)

	
	change_face(Gawain, "Normal")
	PlayPartVoice("ガウェイン", "肯定2")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	message("CO_101013_09030012")
	close_speech_window()
	
	dot_change_anim(dotsoldier3,3)
	dot_play_particle_unit(dotsoldier3,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi9)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier3,0)
	dot_change_anim(barbaroi9,0)
	
	dot_change_anim(barbaroi13m,3)
	dot_play_particle_unit(barbaroi13m,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier7)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(barbaroi13m,0)
	dot_change_anim(dotsoldier7,0)

	
	change_face(Noir2, "Normal")
	PlayPartVoice("ノワール", "肯定2")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("CO_101013_09030013")
	close_speech_window()
	
	dot_change_anim(barbaroi9,3)
	dot_play_particle_unit(barbaroi9,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier3)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier3,0)
	dot_change_anim(barbaroi9,0)
	
	dot_change_anim(barbaroi13m,3)
	dot_play_particle_unit(barbaroi13m,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier7)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier7,0)
	dot_change_anim(barbaroi13m,0)

	
	change_face(Gawain, "Surprise")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "驚き")
	message("CO_101013_09030014")
	



	
	end

function CO_101013_0903_select1_1()

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101013_09030019")
	

	
	
	message("CO_101013_09030020")
	close_speech_window()
	
	dot_change_anim(dotsoldier6,3)
	dot_play_particle_unit(dotsoldier6,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi12)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier6,0)
	dot_change_anim(barbaroi12,0)
	
	dot_change_anim(barbaroi8,3)
	dot_play_particle_unit(barbaroi8,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier2)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier2,0)
	dot_change_anim(barbaroi8,0)


	
	change_face(Gawain, "Sad")
	PlayPartVoice("ガウェイン", "悩む")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	message("CO_101013_09030021")
	close_speech_window()

	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101013_09030022")
	
	
	
	
	message("CO_101013_09030030")
	close_speech_window()
	
	end


function CO_101013_0903_select1_2()

	
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("CO_101013_09030024")
	close_speech_window()

	
	change_face(Gawain, "Sad")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "怒り")
	message("CO_101013_09030025")
	close_speech_window()
	
	dot_change_anim(dotsoldier6,3)
	dot_play_particle_unit(dotsoldier6,"Ef_C_Swd_N_Atk01",3,true)
	dot_dodge_seq(barbaroi12)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier6,0)
	dot_change_anim(barbaroi12,0)
	
	dot_change_anim(barbaroi8,3)
	dot_play_particle_unit(barbaroi8,"Ef_C_Swd_N_EmyAtk01",3,true)
	dot_dodge_seq(dotsoldier2)
	wait_time(0.4)
	wait_seq()
	dot_change_anim(dotsoldier2,0)
	dot_change_anim(barbaroi8,0)

	
	change_face(Noir2, "Normal")
	PlayPartVoice("ノワール", "肯定")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("CO_101013_09030026")
	close_speech_window()

	
	change_face(Ragnar1, "Smile")
	PlayPartVoice("ラグネル", "喜び")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1 , nil)
	message("CO_101013_09030027")
	close_speech_window()

	
	change_face(Gawain, "Sad")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "悩む")
	message("CO_101013_09030028")
	close_speech_window()
	
	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定2")
	message("CO_101013_09030030")
	close_speech_window()
	
	end

function CO_101013_0903_select2()	

	
	
	
	change_camera_distance(7.0, 1.0)
	move_camera(19, 34, 1.0)
	dot_move_unit_seq(dotGawain,19, 33)

	
	wait_seq()

	wait_time(1.0)

	play_particle(Ef_sun)
	on_active(Ef_sun)
	
	local gridpos = get_grid_position(19,33)
	set_pos(Ef_sun, gridpos)
	wait_time(1.0)
	

	
	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "肯定")
	message("CO_101013_09030032")
	

	
	
	message("CO_101013_09030033")
	

	
	change_face(Gawain, "Smile")
	
	message("CO_101013_09030034")
	
	
	
	dot_change_anim(dotGawain,3)

	
	change_face(Gawain, "Anger")
	
	PlayPartVoice("ガウェイン", "気合い")
	message("CO_101013_09030035")
	close_speech_window()
	
	dot_change_anim(dotGawain,0)
	dot_move_unit_seq(dotGawain,19, 31)
	wait_seq()
	dot_change_anim(dotGawain,3)
	dot_change_anim(barbaroi13m,6)
	wait_time(0.2)
	dot_play_particle_unit(barbaroi13m,"Ef_C_Cmn_N_Hit_Str01",3,true)
	wait_time(0.2)
	dot_dying_unit_seq(barbaroi13m)
	wait_time(1.0)
	wait_seq()
	dot_change_anim(dotGawain,0)
	

	
	
	
	change_face(Ragnar1, "Smile")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1 , nil)
	PlayPartVoice("ラグネル", "喜び")
	message("CO_101013_09030037")
	close_speech_window()
	

	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "喜び")
	message("CO_101013_09030038")
	close_speech_window()

	
	open_speech_window("NPCNAME_0124",nil, nil)
	PlayPartVoice("兵士3", "気合い")
	message("CO_101013_09030039")
	close_speech_window()

	bgm_play("BGM_Area_Acoustic")
	
	se_play("SE_ADV_CO_101015_0902_War_Voice")
	
	on_active(Ef_reply)
	on_active(Ef_reply2)
	on_active(Ef_reply3)
	on_active(Ef_reply4)
	on_active(Ef_reply5)
	on_active(Ef_reply6)
	on_active(Ef_reply7)
	
	
	local gridpos = get_grid_position(22,30)
	gridpos[2] = 1.5
	set_pos(Ef_reply, gridpos)
	play_particle(Ef_reply)
	
	local gridpos = get_grid_position(15,24)
	gridpos[2] = 1.5
	set_pos(Ef_reply2, gridpos)
	play_particle(Ef_reply2)
	
	local gridpos = get_grid_position(18,26)
	gridpos[2] = 1.5
	set_pos(Ef_reply3, gridpos)
	play_particle(Ef_reply3)
	
	local gridpos = get_grid_position(15,28)
	gridpos[2] = 1.5
	set_pos(Ef_reply4, gridpos)
	play_particle(Ef_reply4)
	
	local gridpos = get_grid_position(20,28)
	gridpos[2] = 1.5
	set_pos(Ef_reply5, gridpos)
	play_particle(Ef_reply5)
	
	local gridpos = get_grid_position(14,30)
	gridpos[2] = 1.5
	set_pos(Ef_reply6, gridpos)
	play_particle(Ef_reply6)
	
	local gridpos = get_grid_position(18,30)
	gridpos[2] = 1.5
	set_pos(Ef_reply7, gridpos)
	play_particle(Ef_reply7)

	
	
	wait_time(0.7)	
	
	fadeout(0,0,0,0,1.0)
	wait_time(1.5)
		
	stop_particle(Ef_reply)
	stop_particle(Ef_reply2)
	stop_particle(Ef_reply3)
	stop_particle(Ef_reply4)
	stop_particle(Ef_reply5)
	stop_particle(Ef_reply6)
	stop_particle(Ef_reply7)

	stop_particle(Ef_sun)
	
	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)
	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)
	dot_disp_unit(barbaroi16, false)
	dot_disp_unit(barbaroi20, false)
	dot_disp_unit(barbaroi22, false)
	dot_disp_unit(dotsoldier, false)
	dot_disp_unit(dotsoldier2, false)
	dot_disp_unit(dotsoldier3, false)
	dot_disp_unit(dotsoldier4, false)
	dot_disp_unit(dotsoldier5, false)
	dot_disp_unit(dotsoldier6, false)
	dot_disp_unit(dotsoldier7, false)
	dot_disp_unit(dotsoldier8, false)
	dot_disp_unit(dotsoldier9, false)
	dot_disp_unit(dotsoldier10, false)
	dot_disp_unit(dotsoldier11, false)
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotRagnar1, false)
	dot_disp_weapon(dotGawain, false)
	move_camera(19, 30, 0.0)

	wait_time(0.3)
	
	fadein(1.0)
	wait_time(1.0)
	

	dot_reserve_move_unit_seq(dotNoir2,18,31)
	dot_reserve_move_unit_seq(dotRagnar1,20,31)
	exec_parallel_seq()
	dot_unit_dir(dotRagnar1, 2)
	wait_seq()
	
	
	
	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("CO_101013_09030041")
	close_speech_window()

	
	change_face(Gawain, "Smile")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "肯定")
	message("CO_101013_09030042")
	close_speech_window()

	
	wait_time(1.0)
	dot_move_unit_seq(dotGawain,18, 31)

	
	
	change_face(Gawain, "Sad")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	message("CO_101013_09030044")
	

	
	
	message("CO_101013_09030045")
	

	
	
	message("CO_101013_09030046")
	

	
	


	end

function CO_101013_0903_select2_1()


	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("CO_101013_09030051")
	close_speech_window()
	
	dot_unit_dir(dotGawain, 2)

	
	change_face(Gawain, "Smile")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "照れ")
	message("CO_101013_09030052")
	

	
	change_face(Gawain, "Normal")
	
	message("CO_101013_09030053")
	
	
	
	change_face(Gawain, "Smile")
	
	PlayPartVoice("ガウェイン", "肯定")
	message("CO_101013_09030061")
	

	
	change_face(Gawain, "Smile")
	
	message("CO_101013_09030062")
	

	
	
	PlayPartVoice("ガウェイン", "笑い")
	message("CO_101013_09030063")
	close_speech_window()
	
end


function CO_101013_0903_select2_2()

	
	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101013_09030055")
	close_speech_window()
	
	dot_unit_dir(dotGawain, 2)

	
	change_face(Gawain, "Sad")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "落胆")
	message("CO_101013_09030056")
	

	
	
	message("CO_101013_09030057")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "驚き")
	message("CO_101013_09030058")
	close_speech_window()

	
	change_face(Ragnar1, "Smile")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1 , nil)
	PlayPartVoice("ラグネル", "笑い")
	message("CO_101013_09030059")
	close_speech_window()
	
	
	change_face(Gawain, "Normal")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "肯定")
	message("CO_101013_09030061")
	

	
	change_face(Gawain, "Normal")
	
	message("CO_101013_09030062")
	

	
	change_face(Gawain, "Smile")
	PlayPartVoice("ガウェイン", "笑い")
	
	message("CO_101013_09030063")
	close_speech_window()
	
end


function CO_101013_0903_end()

	

	
	change_face(Ragnar1, "Smile")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1 , nil)
	PlayPartVoice("ラグネル", "肯定")
	message("CO_101013_09030065")
	close_speech_window()

	
	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	PlayPartVoice("ノワール", "肯定")
	message("CO_101013_09030066")
	close_speech_window()

	
	change_face(Gawain, "Smile")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoice("ガウェイン", "照れ")
	message("CO_101013_09030067")
	close_speech_window()

	

	
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ9_4")

	EndPlay()
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,20,39,0)
	pbadv_setup_101013_Gawain_preload(0,true,19,35,0)
	pbadv_setup_101018_Ragnar_preload(1,true,24,37,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Sunbeams_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Emo_Waiwai01_Lop", false, true)
	preload_sound("BGM_Area_Acoustic")
end
