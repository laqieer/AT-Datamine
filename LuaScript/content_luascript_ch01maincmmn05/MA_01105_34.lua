

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201080100", "201080100")
	
	change_time_and_weather(1,1)
	
	
	pbadv_setup_101009_Noir(2,true,2,4,0)
	pbadv_setup_101001_Tyrfing(1,true,2,2,0)
	pbadv_setup_101011_Guinevere(0,true,4,4,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,3,3,0)
	pbadv_setup_101013_Gawain(0,true,2,1,0)
	pbadv_setup_101018_Ragnar(2,true,2,0,0)
	pbadv_setup_101057_Leodgrains(0,true,15,3,0)
	pbadv_setup_101057_Leodgrains(1,true,20,0,0)
	pbadv_setup_101042_Moronoe(true,13,3,0)
	
	
	barbaroi1 = dot_reserve_enemy(42, 13,4, 0)
	barbaroi2 = dot_reserve_enemy(49, 14,4, 0)
	barbaroi3 = dot_reserve_enemy(42, 13,1, 0)
	barbaroi4 = dot_reserve_enemy(49, 14,1, 0)
	
	gridposEf_bar_1 = get_grid_position(13,4)
	gridposEf_bar_2 = get_grid_position(14,4)
	gridposEf_bar_3 = get_grid_position(13,1)
	gridposEf_bar_4 = get_grid_position(14,1)
		
	
	
	
	setup_complete_unit()
	
	
	dot_disp_unit(dotLeodgrains1,false)
	dot_disp_unit(dotMoronoe,false)
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(barbaroi4,false)
	
	dot_unit_dir(barbaroi1, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	dot_unit_dir(barbaroi4, 2)
	
	

	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(12,4, 0.0)
	
	
	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange  = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true) 
	Ef_Change_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true) 

	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar_scale = {0.8,0.8,0.8}
	
	dot_unit_dir(dotLeodgrains,DotDir_Left)
	dot_disp_weapon(dotLeodgrains,false)
	
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WitchSpear2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	Ef_WSpearAppea2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	Ef_WSpearAura2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	Ef_BlFeather = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	Ef_WitchChange1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	Ef_WitchChange2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	Ef_Witch2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	Ef_Black2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)

	load_sound("BGM_ADV_Serious2")
	
	
end





function Play()
	fadein(0)
	Play_start(true)


	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	





	
	
	
	
	
	
	
	
	wait_time(0.5)
	
	dot_reserve_move_unit_seq(dotGuinevere,11,3)
	dot_reserve_move_unit_seq(dotNoir2,10,4)
	dot_reserve_move_unit_seq(dotGwenhwymawr1,11,2)
	dot_reserve_move_unit_seq(dotTyrfing1,10,5)
	dot_reserve_move_unit_seq(dotGawain,10,1)
	dot_reserve_move_unit_seq(dotRagnar2,9,0)
	exec_parallel_seq()
	wait_seq()
	
	wait_time(0.5)
	
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_340002")
	
	open_select_window_tag(Noir2,"Normal","MA_01105_340004","MA_01105_340005")
	close_speech_window()
	
	if is_select(1) then
	
	dot_move_unit_seq(dotNoir2,11,4)
	wait_seq()
	
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340007")
	close_speech_window()
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01105_340008")
	close_speech_window()
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340009")
	
	
	elseif is_select(2) then
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340011")
	close_speech_window()
	
	change_face(Gwenhwymawr1,"Sad")
	open_speech_window("NPCNAME_0070",Gwenhwymawr1 , nil)
	message("MA_01105_340012")
	close_speech_window()
	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_340013")
	
	end
	
	
	
	change_face(Guinevere,"Normal")
	message("MA_01105_340015")
	close_speech_window()
	
	change_face(Leodgrains,"Normal")
	open_speech_window("CHRNAME_LEODEGRAINS", Leodgrains, nil)
	message("MA_01105_340016")
	close_speech_window()
	
	change_face(Guinevere,"Smile")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_340017")
	close_speech_window()
	
	open_speech_window("CHRNAME_LEODEGRAINS", Leodgrains, nil)
	message("MA_01105_340018")
	close_speech_window()
	
	change_face(Gawain,"Normal")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	message("MA_01105_340019")
	close_speech_window()
	
	
	dot_move_unit_seq(dotRagnar2,10,0)
	wait_seq()
	dot_unit_dir(dotRagnar2, DotDir_Right )
	
	
	change_face(Ragnar2,"Anger")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2 , nil)
	message("MA_01105_340020")
	close_speech_window()
	
	
	change_face(Guinevere,"Smile")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_340021")
	close_speech_window()
	
	open_speech_window("CHRNAME_LEODEGRAINS",Leodgrains , nil)
	message("MA_01105_340022")
	close_speech_window()
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340023")
	close_speech_window()
	
	change_face(Gwenhwymawr1,"Smile")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1 , nil)
	message("MA_01105_340024")
	close_speech_window()
	
	change_face(Guinevere,"Shy")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340025")
	close_speech_window()
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01105_340026")
	close_speech_window()
	
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_340027")
	message("MA_01105_340028")
	
	
	open_select_window_tag(Noir2,"Normal","MA_01105_340030","MA_01105_340031")
	close_speech_window()
	
	
	if is_select(1) then
	
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01105_340033")
	close_speech_window()
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340034")
	
	
	
	
	change_face(Guinevere,"Smile")
	message("MA_01105_340036")
	
	elseif is_select(2) then
	
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01105_340038")
	close_speech_window()
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340040")
	
	message("MA_01105_340042")
	
	end
	
	dot_move_unit_seq(dotGuinevere,12,3)
	wait_seq()
	
	
	change_face(Guinevere,"Normal")
	message("MA_01105_340044")
	close_speech_window()
	
	
	on_active(Ef_WitchSpear2) 
	on_active(Ef_WSpearAppea2) 
	on_active(Ef_WSpearAura2) 
	
	
	local gridpos = get_grid_position(16, 3)
	gridpos[2] = 2.0
	set_pos(Ef_WSpearAppea2, gridpos)
	turn(Ef_WSpearAppea2,45, 90, 0, 0.0)
	play_particle(Ef_WSpearAppea2)

	
	local gridpos = get_grid_position(16, 3)
	gridpos[2] = 2.0
	set_pos(Ef_WSpearAppea2, gridpos)
	turn(Ef_WSpearAppea2,45, 90, 0, 0.0)
	play_particle(Ef_WSpearAppea2)
	
	
	local gridpos = get_grid_position(16, 3)
	gridpos[2] = 2.0
	set_pos(Ef_WitchSpear2, gridpos)
	turn(Ef_WitchSpear2, 45, 90, 0, 0.0)
	play_particle(Ef_WitchSpear2)
	
	set_pos(Ef_WSpearAura2, gridpos)
	turn(Ef_WSpearAura2,45, 90, 0, 0.0)
	play_particle(Ef_WSpearAura2)
	
	wait_time(1.0)
	
	local gridpos = get_grid_position(13, 3)
	gridpos[2] = 0.11
	
	slidemove(Ef_WitchSpear2, gridpos, 0.1)
	slidemove(Ef_WSpearAura2, gridpos, 0.1)
	
	se_play("SE_ADV_MA_01106_15_Whitch_Spr_Ground")
	
	wait_time(0.1)
	
	
	dot_move_unit_seq(dotGuinevere,11,3)
	wait_seq()
	
	dot_unit_dir(dotGuinevere,DotDir_Right)
	
	bgm_play("Stop_BGM_Bus_2")
	
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340046")
	close_speech_window()
	
	
	
	open_speech_window("CHRNAME_NAMELES",nil , nil)
	message("MA_01105_340048")
	close_speech_window()
	
	
	
	stop_particle(Ef_WitchSpear2)
	stop_particle(Ef_WSpearAura2)
	
	on_active(Ef_BlFeather)
	on_active(Ef_WitchChange)

	local gridpos = get_grid_position(13, 3)
	set_pos(Ef_BlFeather, gridpos)
	play_particle(Ef_BlFeather)

	set_pos(Ef_WitchChange, gridpos)
	play_particle(Ef_WitchChange)

	wait_time(1.0)
	
	stop_particle(Ef_WitchSpear2)
	dot_disp_unit(dotMoronoe,true)

	wait_time(2.0)

	
	
	open_speech_window("CHRNAME_NAMELES",nil , Moronoe)
	message("MA_01105_340050")
	close_speech_window()
	
	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01105_340051")
	close_speech_window()

	
	bgm_play("BGM_ADV_Serious2")
	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil,Moronoe)
	message("MA_01105_340052")
	
	change_face(Moronoe,"Smile")
	message("MA_01105_340053")
	close_speech_window()
	
	
	change_face(Ragnar2,"Surprise")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	message("MA_01105_340054")
	close_speech_window()
	
	
	change_face(Gwenhwymawr1,"Anger")
	open_speech_window("CHRNAME_GWENHWYMAWR2", Gwenhwymawr1, nil)
	message("MA_01105_340055")
	close_speech_window()
	
	
	dot_move_unit_seq(dotMoronoe, 15,2)
	wait_seq()
	dot_unit_dir(dotMoronoe,DotDir_Left)
	
	
	open_speech_window("CHRNAME_SISTERS_1", nil,Moronoe)
	message("MA_01105_340056")
	close_speech_window()
	
	
	
	
	dot_change_unit(dotLeodgrains, dotLeodgrains1, 1.0)
	
	local gridpos2 = get_grid_position(15, 3)
	set_pos(Ef_Change_Enemy, gridpos2)
	on_active(Ef_Change_Enemy)
	wait_time(3.0)
	
	
	change_face(Leodgrains1,"Anger")
	open_speech_window("CHRNAME_LEODEGRAINS", nil, Leodgrains1)
	message("MA_01105_340058")
	close_speech_window()
	
	
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01105_340059")
	
	
	
	on_active(Ef_bar3)　
	set_pos(Ef_bar3, gridposEf_bar_3)
	set_scale(Ef_bar3, Ef_bar_scale)
	play_particle(Ef_bar3)
	
	wait_time(0.2)
	
	dot_disp_unit(barbaroi3,true)
	
	wait_time(0.5)
	
	on_active(Ef_bar4) 
	set_pos(Ef_bar4, gridposEf_bar_4)
	set_scale(Ef_bar4, Ef_bar_scale)
	play_particle(Ef_bar4)
	
	wait_time(0.2)
	
	dot_disp_unit(barbaroi4,true)
	
	wait_time(0.5)
	
	on_active(Ef_bar1) 
	set_pos(Ef_bar1, gridposEf_bar_1)
	set_scale(Ef_bar1, Ef_bar_scale)
	play_particle(Ef_bar1)
	
	wait_time(0.2)
	
	dot_disp_unit(barbaroi1,true)
	
	wait_time(0.5)
	
	on_active(Ef_bar2) 
	set_pos(Ef_bar2, gridposEf_bar_2)
	set_scale(Ef_bar2, Ef_bar_scale)
	play_particle(Ef_bar2)
	
	wait_time(0.2)
	
	dot_disp_unit(barbaroi2,true)
	
	wait_time(2.0)
	
	wait_seq()

	
	
	
	message("MA_01105_340061")
	close_speech_window()
	
	
	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_340062")
	close_speech_window()

	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1" , ni,Moronoe)
	message("MA_01105_340063")
	close_speech_window()
	
	
	change_face(Gawain,"Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01105_340064")
	close_speech_window()
	
	
	open_speech_window("CHRNAME_SISTERS_1", nil, Moronoe)
	message("MA_01105_340065")
	
	
	change_face(Moronoe,"Smile")
	message("MA_01105_340067")
	close_speech_window()

	
	Play_end(true)
	
	
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,2,4,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,2,2,0)
	pbadv_setup_101011_Guinevere_preload(0,true,4,4,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,3,3,0)
	pbadv_setup_101013_Gawain_preload(0,true,2,1,0)
	pbadv_setup_101018_Ragnar_preload(2,true,2,0,0)
	pbadv_setup_101057_Leodgrains_preload(0,true,15,3,0)
	pbadv_setup_101057_Leodgrains_preload(1,true,20,0,0)
	pbadv_setup_101042_Moronoe_preload(true,13,3,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar_scale = {0.8,0.8,0.8}
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Spr", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, true)
	preload_sound("BGM_ADV_Serious2")
end
