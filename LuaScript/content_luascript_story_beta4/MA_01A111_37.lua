Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201200000","201200000")
	change_time_and_weather(1,1)
	
	
	load_image("101010150","content_still_10101015_image", "101010150_StillImage")
	load_image("101030070","content_still_10103007_image", "101030070_StillImage")
	
	
	pbadv_setup_101009_Noir(2,true,11,35,0)
	pbadv_setup_101011_Guinevere(1,true,11,36,0)
	pbadv_setup_101030_Elaine(0,true,10,35,0)
	pbadv_setup_101031_Lovein(1,true,10,36,0)
	pbadv_setup_101013_Gawain(0,true,9,37,0)
	pbadv_setup_101018_Ragnar(1,true,9,36,0)
	
	
	pbadv_setup_101052_Vernarth(0,true,21,34,0)
	pbadv_setup_101037_Rasia(3,true,20,34,0)
	
	pbadv_setup_101037_Rasia(2,true,0,5,0)
	
	pbadv_setup_101044_Gliten(true,0,6,0)
	
	
	dotbaroi1=dot_reserve_enemy(42,0,0,0)
	dotbaroi2=dot_reserve_enemy(42,0,1,0)
	dotbaroi3=dot_reserve_enemy(42,0,2,0)
	dotbaroi4=dot_reserve_enemy(42,0,3,0)
	dotbaroi5=dot_reserve_enemy(42,1,0,0)
	dotbaroi6=dot_reserve_enemy(42,1,1,0)
	
	
	dotroma1=dot_reserve_ally(401039001,28,31,0)
	dot_set_weapon(dotroma1,103010001)
	dotroma2=dot_reserve_ally(401039001,29,31,0)
	dot_set_weapon(dotroma2,103010001)
	dotroma3=dot_reserve_ally(401039001,30,31,0)
	dot_set_weapon(dotroma3,101010001)
	dotroma4=dot_reserve_ally(401039001,31,31,0)
	dot_set_weapon(dotroma4,101010001)
	dotroma5=dot_reserve_ally(401040001,28,32,0)
	dot_set_weapon(dotroma5,101010001)
	dotroma6=dot_reserve_ally(401040001,29,32,0)
	dot_set_weapon(dotroma6,101010001)
	dotroma7=dot_reserve_ally(401040001,30,32,0)
	dot_set_weapon(dotroma7,103010001)
	dotroma8=dot_reserve_ally(401040001,31,32,0)
	dot_set_weapon(dotroma8,103010001)
	dotroma9=dot_reserve_ally(401040001,28,33,0)
	dot_set_weapon(dotroma9,105010001)
	dotroma10=dot_reserve_ally(401040001,29,33,0)
	dot_set_weapon(dotroma10,105010001)
	dotroma11=dot_reserve_ally(401040001,30,33,0)
	dot_set_weapon(dotroma11,105010001)
	dotroma12=dot_reserve_ally(401040001,31,33,0)
	dot_set_weapon(dotroma12,105010001)

		
	
	
	setup_complete_unit()
	
	
	dot_disp_unit(dotGliten,false)
	dot_disp_unit(dotroma1,false)
	dot_disp_unit(dotroma2,false)
	dot_disp_unit(dotroma3,false)
	dot_disp_unit(dotroma4,false)
	dot_disp_unit(dotroma5,false)
	dot_disp_unit(dotroma6,false)
	dot_disp_unit(dotroma7,false)
	dot_disp_unit(dotroma8,false)
	dot_disp_unit(dotroma9,false)
	dot_disp_unit(dotroma10,false)
	dot_disp_unit(dotroma11,false)
	dot_disp_unit(dotroma12,false)
	
	dot_disp_unit(dotbaroi1,false)
	dot_disp_unit(dotbaroi2,false)
	dot_disp_unit(dotbaroi3,false)
	dot_disp_unit(dotbaroi4,false)
	dot_disp_unit(dotbaroi5,false)
	dot_disp_unit(dotbaroi6,false)
	
	
	dot_unit_dir(dotVernarth,DotDir_Left)
	
	dot_disp_weapon(dotVernarth,false)
	dot_disp_weapon(dotRasia3,false)
	
	dot_change_anim(dotVernarth,1)

	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(30.0,0.0)

	
	
	move_camera(20,34,0.0)
	
	Ef_Portal_E1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_VibesAura=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_VibesAura1=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_Killers=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_Change_K=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	Ef_PivotCenter_020=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_020",false,true)
	Ef_Change_W=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	Ef_Witch_Spr_AtkAura=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_AtkAura",false,true)
	Ef_Hit_Witch_Spe=load_particle("content_effect3d_common_adv","Ef_C_Adv_Hit_Witch_Spe",false,true)
	Ef_C_Adv_Emblem13_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem13",false,true)
	Ef_C_Adv_Emblem13_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem13",false,true)
	Ef_Change_W1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	Ef_C_Adv_Flash_White01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White01",false,true)

	load_sound("BGM_Battle_Tragedy_TragedyStart")
	
end





function Play()
	fadein(0)
	Play_start(true)


	

	

	
	
	
	
	
	change_face(Rasia3,"Sad")
	open_speech_window("CHRNAME_RASIA",Rasia3,nil)
	message("MA_01A111_370002")
	close_speech_window()

	
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01A111_370004")
	close_speech_window()

	
	change_face(Rasia3,"Pain")
	open_speech_window("CHRNAME_RASIA",Rasia3,nil)
	message("MA_01A111_370005")
	close_speech_window()
	
	
	
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01A111_370007")
	close_speech_window()
	
	wait_time(0.7)
	
	change_face(Rasia3,"Normal")
	open_speech_window("CHRNAME_RASIA",Rasia3,nil)
	message("MA_01A111_370008")
	close_speech_window()
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01A111_370009")
	close_speech_window()
	
	
	change_face(Rasia3,"Anger")
	open_speech_window("CHRNAME_RASIA",Rasia3,nil)
	message("MA_01A111_370010")
	close_speech_window()
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01A111_370011")
	close_speech_window()
	
	
	on_active(Ef_C_Adv_Emblem13_1)
	
	local locatorpos=dot_get_unit_locator(dotRasia3,1)
	set_pos(Ef_C_Adv_Emblem13_1,locatorpos)
	
	on_active(Ef_C_Adv_Emblem13_2)
	local locatorpos=dot_get_unit_locator(dotVernarth,1)
	set_pos(Ef_C_Adv_Emblem13_2,locatorpos)
	
	on_active(Ef_VibesAura)
	local gridpos = get_grid_position(20,34) 
	set_pos(Ef_VibesAura, gridpos)
	play_particle(Ef_VibesAura)
	
	on_active(Ef_Killers)
	local gridpos=get_grid_position(21,34)
	set_pos(Ef_Killers,gridpos)
	play_particle(Ef_Killers)
	
	
	change_face(Rasia3,"Anger")
	open_speech_window("CHRNAME_RASIA",Rasia3,nil)
	message("MA_01A111_370013")
	close_speech_window()
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",Vernarth,nil)
	message("MA_01A111_370014")
	close_speech_window()
	
	
	change_face(Gawain,"Surprise")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01A111_370016")
	close_speech_window()
	
	move_camera(19,34,0.8)
	dot_reserve_move_unit_seq(dotNoir2,18,33)
	dot_reserve_move_unit_seq(dotGuinevere1,18,34)
	dot_reserve_move_unit_seq(dotElaine,17,34)
	dot_reserve_move_unit_seq(dotLovein1,17,35)
	dot_reserve_move_unit_seq(dotGawain,16,35)
	dot_reserve_move_unit_seq(dotRagnar1,16,34)
	exec_parallel_seq()
	
	wait_time(1.5)
	
	
	change_face(Rasia3,"Anger")
	open_speech_window("CHRNAME_RASIA",nil,Rasia3)
	message("MA_01A111_370017")
	close_speech_window()
	
	
	change_face(Guinevere1,"Pain")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A111_370019")
	close_speech_window()
	
	
	change_face(Rasia3,"Smile")
	open_speech_window("CHRNAME_RASIA",nil,Rasia3)
	message("MA_01A111_370020")
	close_speech_window()
	
	
	change_face(Elaine,"Pain")
	open_speech_window("CHRNAME_ELAINE",Elaine,nil)
	message("MA_01A111_370021")
	close_speech_window()
	
	wait_time(0.5)
	dot_unit_dir(dotRasia3,DotDir_Left)
	
	change_face(Rasia3,"Anger")
	open_speech_window("CHRNAME_RASIA",nil,Rasia3)
	message("MA_01A111_370022")
	
	
	change_face(Rasia3,"Anger")
	message("MA_01A111_370023")
	
	
	
	change_face(Rasia3,"Pain")
	message("MA_01A111_370025")
	close_speech_window()
	
	
	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01A111_370026")
	close_speech_window()
	
	
	wait_time(0/6)
	
	dot_disp_weapon(dotVernarth,true)
	
	move_camera(17,34,1.0)
	wait_time(1.0)
	
	change_face(Ragnar1,"Pain")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1,nil)
	message("MA_01A111_370028")
	close_speech_window()
	
	
	change_face(Gawain,"Surprise")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01A111_370029")
	close_speech_window()
	
	move_camera(19,34,1.0)
	wait_time(1.0)
	
	change_face(Vernarth,"Normal")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01A111_370030")
	close_speech_window()
	
	
	change_face(Lovein1,"Anger")
	open_speech_window("CHRNAME_LOVEIN2",Lovein1,nil)
	message("MA_01A111_370031")
	
	
	change_face(Lovein1,"Anger")
	message("MA_01A111_370032")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_LongFade")
	
	
	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01A111_370033")
	close_speech_window()
	
	
	
	on_active(Ef_C_Adv_Flash_White01)
	local gridpos=get_grid_position(20,34) 
	set_pos(Ef_C_Adv_Flash_White01,gridpos)
	play_particle(Ef_C_Adv_Flash_White01)
	wait_time(0.3)
	
	show_image("101010150",0.0,0.0,BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)
	wait_time(BLACK_WHITE_TIME)
	
	
	open_simple_window("CHRNAME_VERNARTH",nil,nil)
	message("MA_01A111_370035")
	
	
	message("MA_01A111_370036")
	close_speech_window()
	
	
	open_simple_window("CHRNAME_RASIA",nil,nil)
	message("MA_01A111_370037")
	close_speech_window()
	
	
	
	open_simple_window("CHRNAME_VERNARTH",nil,nil)
	message("MA_01A111_370039")
	close_speech_window()
	
	open_cutin(2,1)
	
	on_cutin(1,Rasia3,"Anger",0)
	on_cutin(2,Vernarth,"Anger",0)
	bgm_play("BGM_Battle_Tragedy_TragedyStart")
	
	open_simple_window("CHRNAME_VERNARTH_RASIA",nil,nil)
	message("MA_01A111_370040")
	close_speech_window()
	
	close_cutin()
	
	
	
	stop_particle(Ef_Killers)
	stop_particle(Ef_VibesAura)
	fadeout(255,255,255,1.0, BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME)
	
	show_image("101030070",0.0,0.0,0,true,false)
	dot_change_unit(dotRasia3,dotRasia2,0.0)
	
	fadein(STILL_SWITCH_TIME+STILL_ACTIVE_AFTER)
	wait_time(STILL_SWITCH_TIME+STILL_ACTIVE_AFTER)
	
	
	
	open_simple_window("CHRNAME_RASIA2",nil,nil)
	message("MA_01A111_370042")
	close_speech_window()

	
	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
	
	
	
	
	change_face(Elaine,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine,nil)
	message("MA_01A111_370044")
	close_speech_window()

	
	change_face(Rasia2,"Normal")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("MA_01A111_370045")
	close_speech_window()

	
	on_active(Ef_PivotCenter_020)
	
	dot_move_knockback(dotGawain,15,34,0.1,2)
	dot_move_knockback(dotRagnar1,15,35,0.1,2)
	dot_move_knockback(dotElaine,16,34,0.1,2)
	dot_move_knockback(dotLovein1,16,35,0.1,2)
	wait_seq()
	dot_unit_dir(dotGawain,DotDir_Right)
	dot_unit_dir(dotRagnar1,DotDir_Right)
	dot_unit_dir(dotElaine,DotDir_Right)
	dot_unit_dir(dotLovein1,DotDir_Right)
	
	dot_unit_dir(dotNoir2,DotDir_Right)
	dot_unit_dir(dotGuinevere1,DotDir_Right)
	on_active(Ef_PivotCenter_020)

	local gridpos=get_grid_position(17,34)
	gridpos[2]=5.0
	set_pos(Ef_PivotCenter_020, gridpos)
	turn(Ef_PivotCenter_020,90,0,0,0.0)
	play_particle(Ef_PivotCenter_020)
	
	on_active(Ef_Witch_Spr_AtkAura)

	set_pos(Ef_Witch_Spr_AtkAura,gridpos)
	turn(Ef_Witch_Spr_AtkAura,90,0,0,0.0)
	play_particle(Ef_Witch_Spr_AtkAura)
	
	local gridpos=get_grid_position(17,34)
	gridpos[2]=1.01
	
	slidemove(Ef_PivotCenter_020,gridpos,0.1)
	slidemove(Ef_Witch_Spr_AtkAura,gridpos,0.1)
	
	on_active(Ef_Hit_Witch_Spe)

	local gridpos=get_grid_position(17,34)
	gridpos[2]=0.01
	set_pos(Ef_Hit_Witch_Spe,gridpos)
	play_particle(Ef_Hit_Witch_Spe)
	
	stop_particle(Ef_Witch_Spr_AtkAura)
	
	
	dot_unit_dir(dotNoir2,DotDir_Left)
	dot_unit_dir(dotGuinevere1,DotDir_Left)
	
	
	wait_time(0.7)
	on_active(Ef_Change_W1)
	local gridpos=get_grid_position(17,34)
	set_pos(Ef_Change_W1,gridpos)
	play_particle(Ef_Change_W1)

	stop_particle(Ef_PivotCenter_020)
	stop_particle(Ef_Hit_Witch_Spe)
	wait_time(1.8)

	dot_disp_unit(dotGliten,true)
	dot_place_unit(dotGliten,17,34)
	
	
	
	change_face(Gliten,"Smile")
	open_speech_window("CHRNAME_SISTERS_3",nil,Gliten)
	message("MA_01A111_370047")
	close_speech_window()

	on_active(Ef_Portal_E1)
	on_active(Ef_Portal_E2)
	on_active(Ef_Portal_E3)
	on_active(Ef_Portal_E4)
	on_active(Ef_Portal_E5)
	on_active(Ef_Portal_E6)
	
	dot_move_knockback(dotGawain,13,34,0.2,2)
	dot_move_knockback(dotRagnar1,13,35,0.2,2)
	dot_move_knockback(dotElaine,14,34,0.2,2)
	dot_move_knockback(dotLovein1,14,35,0.2,2)
	wait_seq()
	
	
	
	
	
	
	
	dot_unit_dir(dotGawain,DotDir_Right)
	dot_unit_dir(dotRagnar1,DotDir_Right)
	dot_unit_dir(dotElaine,DotDir_Right)
	dot_unit_dir(dotLovein1,DotDir_Right)
	
	local gridpos=get_grid_position(15,34)
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	
	local gridpos=get_grid_position(15,35)
	set_pos(Ef_Portal_E2,gridpos)
	set_scale(Ef_Portal_E2,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E2)
	
	local gridpos=get_grid_position(15,36)
	set_pos(Ef_Portal_E3,gridpos)
	set_scale(Ef_Portal_E3,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E3)
	
	local gridpos=get_grid_position(16,34)
	set_pos(Ef_Portal_E4,gridpos)
	set_scale(Ef_Portal_E4,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E4)
	
	local gridpos=get_grid_position(16,35)
	set_pos(Ef_Portal_E5,gridpos)
	set_scale(Ef_Portal_E5,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E5)
	
	local gridpos=get_grid_position(16,36)
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	
	wait_time(0.2)
	
	dot_disp_unit(dotbaroi1,true)
	dot_disp_unit(dotbaroi2,true)
	dot_disp_unit(dotbaroi3,true)
	dot_disp_unit(dotbaroi4,true)
	dot_disp_unit(dotbaroi5,true)
	dot_disp_unit(dotbaroi6,true)
	
	dot_place_unit(dotbaroi1,15,34)
	dot_place_unit(dotbaroi2,15,35)
	dot_place_unit(dotbaroi3,15,36)
	dot_place_unit(dotbaroi4,16,34)
	dot_place_unit(dotbaroi5,16,35)
	dot_place_unit(dotbaroi6,16,36)
	
	move_camera(19,34,1.0)
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A111_370049")
	close_speech_window()
	
	

	
	change_face(Ragnar1,"Surprise")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1,nil)
	message("MA_01A111_370050")
	close_speech_window()

	dot_change_anim(dotVernarth,0)

	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01A111_370051")
	close_speech_window()

	
	change_face(Ragnar1,"Anger")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1,nil)
	message("MA_01A111_370052")
	close_speech_window()

	
	change_face(Gawain,"Anger")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("MA_01A111_370053")

	
	change_face(Gawain,"Anger")
	message("MA_01A111_370054")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotGliten,4,40)
	dot_reserve_move_unit_seq(dotGawain,0,39)
	dot_reserve_move_unit_seq(dotRagnar1,0,40)
	dot_reserve_move_unit_seq(dotElaine,1,39)
	dot_reserve_move_unit_seq(dotLovein1,1,40)
	dot_reserve_move_unit_seq(dotbaroi1,2,39)
	dot_reserve_move_unit_seq(dotbaroi2,2,40)
	dot_reserve_move_unit_seq(dotbaroi3,2,41)
	dot_reserve_move_unit_seq(dotbaroi4,3,39)
	dot_reserve_move_unit_seq(dotbaroi5,3,40)
	dot_reserve_move_unit_seq(dotbaroi6,3,41)
	exec_parallel_seq()
	wait_time(0.8)
	
	change_face(Lovein1,"Anger")
	open_speech_window("CHRNAME_LOVEIN2",Lovein1,nil)
	message("MA_01A111_370056")
	close_speech_window()

	
	change_face(Elaine,"Anger")
	open_speech_window("CHRNAME_ELAINE",Elaine,nil)
	message("MA_01A111_370057")
	close_speech_window()

	
	change_face(Rasia2,"Normal")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("MA_01A111_370058")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotroma1,21,31)
	dot_reserve_move_unit_seq(dotroma2,22,31)
	dot_reserve_move_unit_seq(dotroma3,23,31)
	dot_reserve_move_unit_seq(dotroma4,24,31)
	dot_reserve_move_unit_seq(dotroma5,21,32)
	dot_reserve_move_unit_seq(dotroma6,22,32)
	dot_reserve_move_unit_seq(dotroma7,23,32)
	dot_reserve_move_unit_seq(dotroma8,24,32)
	dot_reserve_move_unit_seq(dotroma9,21,33)
	dot_reserve_move_unit_seq(dotroma10,22,33)
	dot_reserve_move_unit_seq(dotroma11,23,33)
	dot_reserve_move_unit_seq(dotroma12,24,33)
	exec_parallel_seq()
	
	dot_disp_unit(dotroma1,true)
	dot_disp_unit(dotroma2,true)
	dot_disp_unit(dotroma3,true)
	dot_disp_unit(dotroma4,true)
	dot_disp_unit(dotroma5,true)
	dot_disp_unit(dotroma6,true)
	dot_disp_unit(dotroma7,true)
	dot_disp_unit(dotroma8,true)
	dot_disp_unit(dotroma9,true)
	dot_disp_unit(dotroma10,true)
	dot_disp_unit(dotroma11,true)
	dot_disp_unit(dotroma12,true)
	
	wait_seq()
	
	dot_unit_dir(dotroma1,2)
	dot_unit_dir(dotroma2,2)
	dot_unit_dir(dotroma3,2)
	dot_unit_dir(dotroma4,2)
	dot_unit_dir(dotroma5,2)
	dot_unit_dir(dotroma6,2)
	dot_unit_dir(dotroma7,2)
	dot_unit_dir(dotroma8,2)
	dot_unit_dir(dotroma9,2)
	dot_unit_dir(dotroma10,2)
	dot_unit_dir(dotroma11,2)
	dot_unit_dir(dotroma12,2)
	
	dot_unit_dir(dotNoir2,DotDir_Right)
	dot_unit_dir(dotGuinevere1,DotDir_Right)
	
	dot_change_anim(dotNoir2,12)
	dot_change_anim(dotGuinevere1,12)
	
	wait_seq()
	move_camera(19,34,0.8)
	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A111_370060")
	close_speech_window()

	
	change_face(Guinevere1,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A111_370061")
	close_speech_window()

	
	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("MA_01A111_370062")
	close_speech_window()
	
	
	
	change_face(Rasia2,"Anger")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("MA_01A111_370064")
	close_speech_window()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("101010150","content_still_10101015_image", "101010150_StillImage")
	load_image_preload("101030070","content_still_10103007_image", "101030070_StillImage")
	pbadv_setup_101009_Noir_preload(2,true,11,35,0)
	pbadv_setup_101011_Guinevere_preload(1,true,11,36,0)
	pbadv_setup_101030_Elaine_preload(0,true,10,35,0)
	pbadv_setup_101031_Lovein_preload(1,true,10,36,0)
	pbadv_setup_101013_Gawain_preload(0,true,9,37,0)
	pbadv_setup_101018_Ragnar_preload(1,true,9,36,0)
	pbadv_setup_101052_Vernarth_preload(0,true,21,34,0)
	pbadv_setup_101037_Rasia_preload(3,true,20,34,0)
	pbadv_setup_101037_Rasia_preload(2,true,0,5,0)
	pbadv_setup_101044_Gliten_preload(true,0,6,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_020",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_AtkAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Hit_Witch_Spe",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem13",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem13",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White01",false,true)
	preload_sound("BGM_Battle_Tragedy_TragedyStart")
end
