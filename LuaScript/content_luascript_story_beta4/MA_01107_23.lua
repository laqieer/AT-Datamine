Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	Isolde_2=set_chara_unknown()
	character2DFull(Isolde_2,"Isolde_2",101019001)
	
	
	init_psbattleadv("201060001","201060001")
	change_time_and_weather(1,1)
	

	
	load_image("MA011072301","content_still_10101007_image","101010070_StillImage")
	
	
	pbadv_setup_101009_Noir(2,true,5,38,0)	
	pbadv_setup_101012_Dinatan(0,true,4,38,0)	
	
	pbadv_setup_101017_Maladisant(0,true,4,39,0)	
	pbadv_setup_101017_Maladisant(1,true,38,38,0)	
	
	pbadv_setup_101014_Tristan(0,true,2,37,0)	
	
	pbadv_setup_101019_Isolde(0,true,2,38,0)	
	pbadv_setup_101019_Isolde(1,true,25,14,0)	
	
	pbadv_setup_101051_Lucius(0,true,6,38,0)	
	pbadv_setup_101052_Vernarth(0,true,7,38,0)	
	
	pbadv_setup_101001_Tyrfing(1,true,34,15,0)	
	pbadv_setup_101010_Lancelot(0,true,27,15,0)	
	
	
	pbadv_setup_101021_Bruno(0,true,0,0,0)	
	
	
	pbadv_setup_101042_Moronoe(true,36,16,0)	
	pbadv_setup_101044_Gliten(true,35,16,0)	
	pbadv_setup_101045_Glitonea(true,34,16,0)	
	pbadv_setup_101046_Gliton(true,33,16,0)	
	
	barbaroi0=dot_reserve_enemy(3,32,17,0)	
	
	barbaroi2=dot_reserve_enemy(3,33,17,0)	
	barbaroi3=dot_reserve_enemy(1100,33,14,0)	
	barbaroi4=dot_reserve_enemy(1100,34,14,0)	
	barbaroi5=dot_reserve_enemy(1100,35,14,0)	
	barbaroi6=dot_reserve_enemy(1100,34,13,0)	
	barbaroi7=dot_reserve_enemy(49,34,12,0)	
	barbaroi8=dot_reserve_enemy(1301,33,13,0)	
	barbaroi9=dot_reserve_enemy(1301,35,13,0)	
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(barbaroi0,3)
	dot_unit_dir(barbaroi2,3)
	
	
	
	dot_disp_weapon(dotLucius,false)
	dot_disp_weapon(dotVernarth,false)
	dot_disp_weapon(dotDinatan,false)
	dot_disp_weapon(dotMaladisant,false)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotTristan,false)
	dot_disp_weapon(dotIsolde,false)
	
	
	
	
	dot_disp_unit(dotTyrfing1,false)
	dot_disp_unit(dotLancelot,false)
	dot_disp_unit(dotMaladisant1,false)
	dot_disp_unit(dotIsolde1,false)
	
	dot_disp_unit(dotMoronoe,false)
	dot_disp_unit(dotGliten,false)
	dot_disp_unit(dotGlitonea,false)
	dot_disp_unit(dotGliton,false)
	dot_disp_unit(barbaroi0,false)
	
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi6,false)
	dot_disp_unit(barbaroi7,false)
	dot_disp_unit(barbaroi8,false)
	dot_disp_unit(barbaroi9,false)
	

	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(45.0,0.0)

	
	
	move_camera(4,38,0.0)
	
	Ef_Change_W1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	Ef_Change_W2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	Ef_Shockwave01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_Portal_E1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_VibesAura=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_Killers=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Change_K=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_Emblem04_1=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	Ef_Emblem04_2=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	Ef_PivotCenter_018=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_018",false,true)
	Ef_PivotCenter_020=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_020",false,true)
	Ef_PivotCenter_021=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_021",false,true)
	Ef_PivotCenter_022=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_022",false,true)
	Ef_Witch_Spr_AtkAura1=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true) 
	Ef_Witch_Spr_AtkAura2=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true) 
	Ef_Witch_Spr_AtkAura3=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true) 
	Ef_Witch_Spr_AtkAura4=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true) 
	Ef_Hit_Witch_Spe1=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	Ef_Hit_Witch_Spe2=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	Ef_Hit_Witch_Spe3=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	Ef_Hit_Witch_Spe4=load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	load_sound("BGM_ADV_Serious2")
	
end





function Play()
	fadein(0)
	Play_start(true)



	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_230002")
	close_speech_window()


	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230003")
	close_speech_window()


	change_face(Maladisant,"Surprise")
	open_speech_window("CHRNAME_MALADISANT",Maladisant,nil)
	message("MA_01107_230004")
	close_speech_window()


	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230005")
	close_speech_window()

	dot_unit_dir(dotMaladisant,2)

	change_face(Maladisant,"Normal")
	open_speech_window("CHRNAME_MALADISANT",Maladisant,nil)
	message("MA_01107_230006")
	close_speech_window()
	
	

	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_230007")
	close_speech_window()

	dot_unit_dir(dotLucius,2)
	dot_unit_dir(dotVernarth,2)

	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_230008")
	close_speech_window()


	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230009")
	close_speech_window()


	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_230010")
	close_speech_window()


	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230011")
	close_speech_window()


	change_face(Isolde_2,"Surprise")
	open_speech_window("CHRNAME_ISOLDE",Isolde_2,nil)
	message("MA_01107_230012")
	close_speech_window()

	dot_unit_dir(dotLucius,3)

	change_face(Lucius,"Surprise")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01107_230013")
	close_speech_window()


	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01107_230014")
	close_speech_window()


	change_face(Dinatan,"Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230015")
	close_speech_window()


	fadeout(0,0,0,0,1.0)
	wait_time(1.0)
	
	
	dot_place_unit(dotNoir2,35,18)
	dot_place_unit(dotDinatan,36,19)
	dot_place_unit(dotMaladisant,36,20)
	dot_place_unit(dotTristan,23,14)

	
	dot_remove_unit(dotLucius)
	dot_remove_unit(dotVernarth)

	
	move_camera(36,18,0.0)
	change_camera_angle(34.0,0.0)
	
	wait_time(1.0)
	
	fadein(1.0)
	wait_time(1.0)
	


	change_face(Maladisant,"Normal")
	open_speech_window("CHRNAME_MALADISANT",Maladisant,nil)
	message("MA_01107_230017")


	change_face(Maladisant,"Sad")
	message("MA_01107_230018")


	change_face(Maladisant, "Normal")
	message("MA_01107_230019")
	close_speech_window()


	change_face(Dinatan,"Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230020")
	close_speech_window()


	change_face(Maladisant,"Normal")
	open_speech_window("CHRNAME_MALADISANT",Maladisant,nil)
	message("MA_01107_230021")
	close_speech_window()


	change_face(Dinatan,"Smile")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230022")
	close_speech_window()


	move_camera(34,18,0.1)


	
	on_active(Ef_PivotCenter_018)

	local gridpos = get_grid_position(36, 16)
	gridpos[2] = 5.0
	set_pos(Ef_PivotCenter_018, gridpos)
	turn(Ef_PivotCenter_018,90, 0, 0, 0.0)
	play_particle(Ef_PivotCenter_018)
	
	on_active(Ef_Witch_Spr_AtkAura1)

	set_pos(Ef_Witch_Spr_AtkAura1, gridpos)
	turn(Ef_Witch_Spr_AtkAura1,90, 0, 0, 0.0)
	play_particle(Ef_Witch_Spr_AtkAura1)
	
	local gridpos = get_grid_position(36, 16)
	gridpos[2] = 1.61
	
	slidemove(Ef_PivotCenter_018, gridpos, 0.1)
	slidemove(Ef_Witch_Spr_AtkAura1, gridpos, 0.1)
	
	on_active(Ef_Hit_Witch_Spe1)

	local gridpos = get_grid_position(36, 16)
	gridpos[2] = 0.01
	set_pos(Ef_Hit_Witch_Spe1, gridpos)
	play_particle(Ef_Hit_Witch_Spe1)
	
	stop_particle(Ef_Witch_Spr_AtkAura1)
	
	dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",36,16)
	
	
	on_active(Ef_PivotCenter_020)

	local gridpos = get_grid_position(35, 16)
	gridpos[2] = 5.0
	set_pos(Ef_PivotCenter_020, gridpos)
	turn(Ef_PivotCenter_020,90, 0, 0, 0.0)
	play_particle(Ef_PivotCenter_020)
	
	on_active(Ef_Witch_Spr_AtkAura2)

	set_pos(Ef_Witch_Spr_AtkAura2, gridpos)
	turn(Ef_Witch_Spr_AtkAura2,90, 0, 0, 0.0)
	play_particle(Ef_Witch_Spr_AtkAura2)
	
	local gridpos = get_grid_position(35, 16)
	gridpos[2] = 1.61
	
	slidemove(Ef_PivotCenter_020, gridpos, 0.1)
	slidemove(Ef_Witch_Spr_AtkAura2, gridpos, 0.1)
	
	on_active(Ef_Hit_Witch_Spe2)

	local gridpos = get_grid_position(35, 16)
	gridpos[2] = 0.01
	set_pos(Ef_Hit_Witch_Spe2, gridpos)
	play_particle(Ef_Hit_Witch_Spe2)
	
	stop_particle(Ef_Witch_Spr_AtkAura2)
	
	dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",35,16)
	
	
	on_active(Ef_PivotCenter_021)

	local gridpos = get_grid_position(34, 16)
	gridpos[2] = 5.0
	set_pos(Ef_PivotCenter_021, gridpos)
	turn(Ef_PivotCenter_021,90, 0, 0, 0.0)
	play_particle(Ef_PivotCenter_021)
	
	on_active(Ef_Witch_Spr_AtkAura3)

	set_pos(Ef_Witch_Spr_AtkAura3, gridpos)
	turn(Ef_Witch_Spr_AtkAura3,90, 0, 0, 0.0)
	play_particle(Ef_Witch_Spr_AtkAura3)
	
	local gridpos = get_grid_position(34, 16)
	gridpos[2] = 1.61
	
	slidemove(Ef_PivotCenter_021, gridpos, 0.1)
	slidemove(Ef_Witch_Spr_AtkAura3, gridpos, 0.1)
	
	on_active(Ef_Hit_Witch_Spe3)

	local gridpos = get_grid_position(34, 16)
	gridpos[2] = 0.01
	set_pos(Ef_Hit_Witch_Spe3, gridpos)
	play_particle(Ef_Hit_Witch_Spe3)
	
	stop_particle(Ef_Witch_Spr_AtkAura3)
	
	dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",34,16)
	
	
	on_active(Ef_PivotCenter_022)

	local gridpos = get_grid_position(33, 16)
	gridpos[2] = 5.0
	set_pos(Ef_PivotCenter_022, gridpos)
	turn(Ef_PivotCenter_022,90, 0, 0, 0.0)
	play_particle(Ef_PivotCenter_022)
	
	on_active(Ef_Witch_Spr_AtkAura4)

	set_pos(Ef_Witch_Spr_AtkAura4, gridpos)
	turn(Ef_Witch_Spr_AtkAura4,90, 0, 0, 0.0)
	play_particle(Ef_Witch_Spr_AtkAura4)
	
	local gridpos = get_grid_position(33, 16)
	gridpos[2] = 1.61
	
	slidemove(Ef_PivotCenter_022, gridpos, 0.1)
	slidemove(Ef_Witch_Spr_AtkAura4, gridpos, 0.1)
	
	on_active(Ef_Hit_Witch_Spe4)

	local gridpos = get_grid_position(33, 16)
	gridpos[2] = 0.01
	set_pos(Ef_Hit_Witch_Spe4, gridpos)
	play_particle(Ef_Hit_Witch_Spe4)
	
	stop_particle(Ef_Witch_Spr_AtkAura4)
	
	dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",33,16)

	wait_time(0.5)
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotDinatan,2)
	dot_unit_dir(dotMaladisant,2)
	dot_unit_dir(dotMaladisant1,2)

	bgm_play("Stop_BGM_Bus_2")

	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230024")
	close_speech_window()
	
	dot_disp_weapon(dotDinatan,true)
	dot_disp_weapon(dotMaladisant,true)
	dot_disp_weapon(dotNoir2,true)


	on_active(Ef_Change_W1)
	local gridpos=get_grid_position(36,16)
	set_pos(Ef_Change_W1,gridpos)
	play_particle(Ef_Change_W1)
	
	stop_particle(Ef_PivotCenter_018)
	stop_particle(Ef_Hit_Witch_Spe1)
	wait_time(1.8)
	
	dot_disp_unit(dotMoronoe,true)
	
	dot_move_height(dotMoronoe,1.5,0.5,2)
	bgm_play("BGM_ADV_Serious2")

	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01107_230026")
	close_speech_window()


	local gridpos=get_grid_position(35,16)
	set_pos(Ef_Change_W1,gridpos)
	play_particle(Ef_Change_W1)

	stop_particle(Ef_PivotCenter_020)
	stop_particle(Ef_Hit_Witch_Spe2)
	wait_time(1.8)

	dot_disp_unit(dotGliten,true)
	
	dot_move_height(dotGliten,1.5,0.5,2)


	change_face(Gliten,"Smile")
	open_speech_window("CHRNAME_SISTERS_3",nil,Gliten)
	message("MA_01107_230028")
	close_speech_window()


	on_active(Ef_Change_W2)

	local gridpos=get_grid_position(34,16)
	set_pos(Ef_Change_W1,gridpos)
	play_particle(Ef_Change_W1)

	stop_particle(Ef_PivotCenter_021)
	stop_particle(Ef_Hit_Witch_Spe3)
	
	local gridpos=get_grid_position(33,16)
	set_pos(Ef_Change_W2,gridpos)
	play_particle(Ef_Change_W2)

	stop_particle(Ef_PivotCenter_022)
	stop_particle(Ef_Hit_Witch_Spe4)
	
	wait_time(1.8)

	dot_disp_unit(dotGlitonea,true)
	dot_disp_unit(dotGliton,true)
	
	dot_move_height(dotGlitonea,1.5,0.5,2)
	dot_move_height(dotGliton,1.5,0.5,2)

	change_face(Glitonea,"Smile")
	open_speech_window("CHRNAME_SISTERS_4",nil,Glitonea)
	message("MA_01107_230030")




	
	MA_01107_23_select1()

	open_select_window_tag(Noir2,"Normal","MA_01107_230032","MA_01107_230033")
	
	close_speech_window()

	if is_select(1) then			
		MA_01107_23_select1_1()

	else		
		MA_01107_23_select1_2()

	end
	MA_01107_23_end()

	end

	function MA_01107_23_select1()

	end

	function MA_01107_23_select1_1()


	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230035")
	close_speech_window()


	change_face(Gliten,"Normal")
	open_speech_window("CHRNAME_SISTERS_3",nil,Gliten)
	message("MA_01107_230036")
	close_speech_window()


	change_face(Gliton,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,Gliton)
	message("MA_01107_230037")
	close_speech_window()


	change_face(Moronoe,"Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01107_230044")
	close_speech_window()	

end
 
function MA_01107_23_select1_2()


	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230039")
	close_speech_window()


	change_face(Dinatan,"Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230040")
	close_speech_window()


	change_face(Glitonea,"Smile")
	open_speech_window("CHRNAME_SISTERS_4",nil,Glitonea)
	message("MA_01107_230041")
	close_speech_window()


	change_face(Moronoe,"Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01107_230042")


	change_face(Moronoe,"Smile")
	message("MA_01107_230044")
	close_speech_window()	
	
end
 
 
function MA_01107_23_end()




	dot_disp_unit(dotTyrfing1,true)
	
	dot_attack_seq(dotTyrfing1,dotGlitonea)
	wait_seq()

	dot_damage_seq(dotTyrfing1,dotGlitonea,true)
	dot_damage_seq(dotTyrfing1,dotGliton,true)

	wait_time(0.5)

	
	
	dot_move_fly(dotGliton,32,16,1.5,0.5,2)
	dot_move_fly(dotGlitonea,33,16,1.5,0.5,2)
	dot_move_unit_seq(dotTyrfing1,34,17)

	wait_seq()
	
	
	
	move_camera(34,18,0.5)
	dot_unit_dir(dotTyrfing1,0)



	dot_move_height(dotMoronoe,2.5,0.5,2)
	dot_move_height(dotGliten,2.5,0.5,2)
	dot_move_height(dotGlitonea,2.5,0.5,2)
	dot_move_height(dotGliton,2.5,0.5,2)
	wait_time(0.5)



	change_face(Moronoe,"Anger")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01107_230046")
	close_speech_window()


	change_face(Tyrfing1,"Sad")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_230048")
	close_speech_window()


	change_face(Gliten,"Smile")
	open_speech_window("CHRNAME_SISTERS_3",nil,Gliten)
	message("MA_01107_230049")
	close_speech_window()


	change_face(Tyrfing1,"Anger")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_230050")
	close_speech_window()


	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230051")
	close_speech_window()


	change_face(Gliton,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,Gliton)
	message("MA_01107_230052")
	close_speech_window()


	change_face(Dinatan,"Surprise")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230053")
	close_speech_window()


	
	change_face(Moronoe,"Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01107_230054")
	close_speech_window()


	dot_unit_dir(dotTyrfing1,2)
	wait_time(0.5)
	
	on_active(Ef_Portal_E1)
	local gridpos=get_grid_position(33,17)
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	
	wait_time(0.2)
	dot_disp_unit(barbaroi2,true)


	
	change_face(Tyrfing1,"Anger")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_230056")
	close_speech_window()


	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230058")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Moronoe,"Normal",0)

	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,nil)
	message("MA_01107_230059")


	change_face(Moronoe,"Normal")
	message("MA_01107_230061")


	
	change_face(Moronoe,"Normal")
	message("MA_01107_230062")
	close_speech_window()
	close_cutin()


	change_face(Tyrfing1,"Anger")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_230064")
	close_speech_window()


	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230065")
	close_speech_window()


	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01107_230066")
	close_speech_window()


	wait_time(0.5)




	local gridpos=get_grid_position(32,17)
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)

	wait_time(0.2)

	dot_disp_unit(barbaroi0,true)




	change_face(Dinatan,"Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230068")
	close_speech_window()
	
	on_active(Ef_Emblem04_1)
	on_active(Ef_Emblem04_2)
	local locatorpos = dot_get_unit_locator(dotDinatan,1)
	set_pos(Ef_Emblem04_1,locatorpos)
	local locatorpos = dot_get_unit_locator(dotMaladisant,1)
	set_pos(Ef_Emblem04_2,locatorpos)
	
	
	on_active(Ef_Killers)
	local gridpos = get_grid_position(36,20) 
	set_pos(Ef_VibesAura, gridpos)
	play_particle(Ef_Killers)

	on_active(Ef_VibesAura)
	local gridpos=get_grid_position(36,19)
	set_pos(Ef_Killers,gridpos)
	play_particle(Ef_VibesAura)

	change_face(Maladisant,"Normal")
	open_speech_window("CHRNAME_MALADISANT",Maladisant,nil)
	message("MA_01107_230069")
	close_speech_window()
	
	
	on_active(Ef_Change_K)

	
	
	
	wait_time(1.5)
	
	local gridpos=get_grid_position(36,20)
	set_pos(Ef_Change_K,gridpos)
	play_particle(Ef_Change_K)
	
	wait_time(0.7)
	
	dot_change_unit(dotMaladisant,dotMaladisant1,0.0)

	wait_time(1.5)

	stop_particle(Ef_Killers)
	stop_particle(Ef_Change_K)
	stop_particle(Ef_VibesAura)

	wait_time(1.5)
	

	change_face(Gliton,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,Gliton)
	message("MA_01107_230071")
	close_speech_window()



	change_face(Tristan,"Serious")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01107_230073")
	close_speech_window()

	local gridpos=get_grid_position(23,14)
	set_pos(Ef_VibesAura,gridpos)
	play_particle(Ef_VibesAura)
	
	
	


	change_face(Isolde_2,"Anger")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01107_230075")
	close_speech_window()


	change_face(Tristan,"Serious")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01107_230076")
	close_speech_window()


	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01107_230077")
	close_speech_window()

	dot_change_anim(dotTristan,3)
	dot_change_anim(dotIsolde1,3)



	


	

	show_image("MA011072301", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
	set_position_image(STILL_POS_LEFT,STILL_POS_LENGTH)
	set_scale_image(STILL_SCALE,STILL_SCALE)

	 wait_time(STILL_SWITCH_TIME)
	scale_to_image(1,1,STILL_MOVE_TIME2,2)
	move_to_image(0,0,STILL_MOVE_TIME2,2)
	 wait_time(STILL_ACTIVE_AFTER)

	dot_disp_unit(dotIsolde1,true)
	stop_particle(Ef_VibesAura)
	dot_unit_dir(dotTyrfing1,2)

	dot_unit_dir(dotGliton,2)
	dot_unit_dir(dotGlitonea,2)


	dot_damage_seq(dotGliton,dotIsolde1,false)
	wait_seq()


	change_face(Gliton,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,nil)
	message("MA_01107_230079")
	close_speech_window()


	
	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)



	move_camera(23,14,0.5)


	change_face(Tristan,"Serious")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	message("MA_01107_230081")
	close_speech_window()
	dot_change_anim(dotTristan,0)

	dot_change_anim(dotTristan,0)
	dot_change_anim(dotIsolde1,0)

	dot_change_anim(dotGliton,6)
	wait_time(0.3)
	move_camera(32,16,0.3)


	dot_disp_unit(dotLancelot,true)
	dot_move_unit_seq(dotLancelot,31,15)
	wait_seq()
	dot_move_unit_seq(dotLancelot,31,17)
	wait_seq()
	dot_unit_dir(barbaroi0,2)
	dot_unit_dir(barbaroi2,2)

	


	dot_attack_seq(dotLancelot,barbaroi0)
	wait_seq()

	on_active(Ef_Shockwave01)
	local gridpos=get_grid_position(32,17)
	set_pos(Ef_Shockwave01,gridpos)
	play_particle(Ef_Shockwave01)

	dot_change_anim(barbaroi0,6)
	dot_play_particle_unit(barbaroi0,"Ef_C_Cmn_N_Hit_Sla01",1,true)


	dot_change_anim(barbaroi2,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	wait_time(0.2)
	
	dot_play_particle_unit(barbaroi0,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi0,false)
	dot_disp_unit(barbaroi2,false)

	
	dot_remove_unit(barbaroi0)
	dot_remove_unit(barbaroi2)


	dot_change_anim(dotGliton,0)
	dot_change_anim(dotLancelot,0)

	move_camera(33,17,0.5)

	

	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230083")
	close_speech_window()


	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_230084")
	close_speech_window()


	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230085")
	close_speech_window()


	change_face(Tyrfing1,"Sad")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1,nil)
	message("MA_01107_230086")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Noir2,"Serious",0)

	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",nil,nil)
	message("MA_01107_230087")


	change_face(Noir2,"Serious")
	message("MA_01107_230088")
	close_speech_window()
	
	close_cutin()
	

	change_face(Gliton,"Normal")
	open_speech_window("CHRNAME_SISTERS_5",nil,Gliton)
	message("MA_01107_230090")
	close_speech_window()


	change_face(Dinatan,"Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01107_230091")
	close_speech_window()



	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230092")
	close_speech_window()


	change_face(Lancelot,"Smile")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_230094")
	close_speech_window()


	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01107_230095")
	close_speech_window()


	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01107_230096")
	close_speech_window()

	on_active(Ef_Portal_E1)
	on_active(Ef_Portal_E2)
	on_active(Ef_Portal_E3)
	on_active(Ef_Portal_E4)
	on_active(Ef_Portal_E5)
	on_active(Ef_Portal_E6)
	on_active(Ef_Portal_E7)

	local gridpos=get_grid_position(33,14)
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	
	local gridpos=get_grid_position(34,14)
	set_pos(Ef_Portal_E2,gridpos)
	set_scale(Ef_Portal_E2,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E2)
	
	local gridpos=get_grid_position(35,14)
	set_pos(Ef_Portal_E3,gridpos)
	set_scale(Ef_Portal_E3,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E3)
	
	local gridpos=get_grid_position(33,13)
	set_pos(Ef_Portal_E4,gridpos)
	set_scale(Ef_Portal_E4,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E4)
	
	local gridpos=get_grid_position(34,13)
	set_pos(Ef_Portal_E5,gridpos)
	set_scale(Ef_Portal_E5,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E5)
	
	local gridpos=get_grid_position(35,13)
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	
	local gridpos=get_grid_position(34,12)
	set_pos(Ef_Portal_E7,gridpos)
	set_scale(Ef_Portal_E7,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E7)
	
	wait_time(0.2)
	
	dot_disp_unit(barbaroi3,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)
	dot_disp_unit(barbaroi9,true)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Isolde_2,"Isolde_2",101019001)
	load_image_preload("MA011072301","content_still_10101007_image","101010070_StillImage")
	pbadv_setup_101009_Noir_preload(2,true,5,38,0)
	pbadv_setup_101012_Dinatan_preload(0,true,4,38,0)
	pbadv_setup_101017_Maladisant_preload(0,true,4,39,0)
	pbadv_setup_101017_Maladisant_preload(1,true,38,38,0)
	pbadv_setup_101014_Tristan_preload(0,true,2,37,0)
	pbadv_setup_101019_Isolde_preload(0,true,2,38,0)
	pbadv_setup_101019_Isolde_preload(1,true,25,14,0)
	pbadv_setup_101051_Lucius_preload(0,true,6,38,0)
	pbadv_setup_101052_Vernarth_preload(0,true,7,38,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,34,15,0)
	pbadv_setup_101010_Lancelot_preload(0,true,27,15,0)
	pbadv_setup_101021_Bruno_preload(0,true,0,0,0)
	pbadv_setup_101042_Moronoe_preload(true,36,16,0)
	pbadv_setup_101044_Gliten_preload(true,35,16,0)
	pbadv_setup_101045_Glitonea_preload(true,34,16,0)
	pbadv_setup_101046_Gliton_preload(true,33,16,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem04", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_018",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_020",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_021",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_022",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	preload_sound("BGM_ADV_Serious2")
end
