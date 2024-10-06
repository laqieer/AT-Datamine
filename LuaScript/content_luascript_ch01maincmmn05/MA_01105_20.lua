

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	
	init_psbattleadv("201080000", "201080000")
	
	load_image("10301005", "content_still_10301005_image", "103010050_StillImage")
	change_time_and_weather(1,2)

	
	
	
	pbadv_setup_101009_Noir(2,true,13,30,0)
	pbadv_setup_101001_Tyrfing(1,true,14,  30,0)
	pbadv_setup_101011_Guinevere(0,true,12, 29,0)
	pbadv_setup_101016_Gwenhwymawr(1,true,12, 30,0)
	pbadv_setup_101013_Gawain(0,true,11, 30,0)
	pbadv_setup_101018_Ragnar(1,true,10, 30,0)
	pbadv_setup_101020_Merlin(0,true,15, 29,0)

	
	
	
	
	barbaroi1 = dot_reserve_enemy(3, 32,9,  0)
	barbaroi2 = dot_reserve_enemy(3, 31,4,  0)
	barbaroi3 = dot_reserve_enemy(3, 26,3,  0)
	barbaroi5 = dot_reserve_enemy(3, 20, 6, 0)
	barbaroi6 = dot_reserve_enemy(3, 35, 13, 0)
	barbaroi7 = dot_reserve_enemy(3, 5, 7, 0)
	
	
	
	
	barbaroi8 = dot_reserve_ally(401037001,  4, 17,  0)
	barbaroi9 = dot_reserve_ally(401037001,  7, 17,  0)
	barbaroi10 = dot_reserve_ally(401037001,  9, 17,  0)
	barbaroi11 = dot_reserve_ally(401037001,  1, 16,  0)
	barbaroi12 = dot_reserve_ally(401037001,  7, 16,  0)
	barbaroi13 = dot_reserve_ally(401037001,  9, 16,  0)
	barbaroi14 = dot_reserve_ally(401037001, 25, 16,  0)
	barbaroi15 = dot_reserve_ally(401037001,  3, 14,  0)
	barbaroi16 = dot_reserve_ally(401037001,  5, 14,  0)
	barbaroi17 = dot_reserve_ally(401037001, 31, 14,  0)
	barbaroi18 = dot_reserve_ally(401037001, 13, 11,  0)
	barbaroi19 = dot_reserve_ally(401037001, 30, 10,  0)
	barbaroi20 = dot_reserve_ally(401037001, 31, 10,  0)
	barbaroi21 = dot_reserve_ally(401037001, 30,  9,  0)
	barbaroi22 = dot_reserve_ally(401037001, 37,  9,  0)
	barbaroi23 = dot_reserve_ally(401037001, 11,  8,  0)
	barbaroi24 = dot_reserve_ally(401037001, 15,  8,  0)
	barbaroi25 = dot_reserve_ally(401037001, 26,  8,  0)
	barbaroi26 = dot_reserve_ally(401037001, 27,  8,  0)
	barbaroi27 = dot_reserve_ally(401037001, 36,  8,  0)
	barbaroi28 = dot_reserve_ally(401037001, 11,  7,  0)
	barbaroi29 = dot_reserve_ally(401037001, 26,  7,  0)
	barbaroi30 = dot_reserve_ally(401037001, 27,  7,  0)
	barbaroi31 = dot_reserve_ally(401037001,  5,  6,  0)
	barbaroi32 = dot_reserve_ally(401037001, 11,  6,  0)
	barbaroi33 = dot_reserve_ally(401037001, 21,  6,  0)
	barbaroiR = dot_reserve_ally(401037001, 39,  6,  0)
	barbaroi34 = dot_reserve_ally(401037001, 21,  4,  0)
	barbaroiR3 = dot_reserve_ally(401037001, 39,  4,  0)
	barbaroi35 = dot_reserve_ally(401037001, 30,  3,  0)
	barbaroi36 = dot_reserve_ally(401037001, 25,  2,  0)
	barbaroi37 = dot_reserve_ally(401037001, 26,  2,  0)
	barbaroi38 = dot_reserve_ally(401037001, 30,  2,  0)
	barbaroi39 = dot_reserve_ally(401037001, 31,  2,  0)
	barbaroi40 = dot_reserve_ally(401037001, 14,  1,  0)
	barbaroi41 = dot_reserve_ally(401037001, 25,  1,  0)
	barbaroi42 = dot_reserve_ally(401037001, 26,  1,  0)
	
	
	soldier = dot_reserve_enemy(3, 27, 5, 0)
	soldier2 = dot_reserve_enemy(3, 7, 13, 0)
	soldier3 = dot_reserve_enemy(3,  4, 14,  0)
	soldier4 = dot_reserve_enemy(3, 34, 12,  0)
	soldier5 = dot_reserve_enemy(3, 15,  9,  0)
	soldier6 = dot_reserve_enemy(3,  6,  5,  0)
	soldier7 = dot_reserve_enemy(3, 15,  5,  0)
	soldier8 = dot_reserve_enemy(3, 21,  5,  0)
	soldier9 = dot_reserve_enemy(3, 31,  3,  0)
	soldier10 = dot_reserve_enemy(3, 31,  9,  0)
	soldier11 = dot_reserve_enemy(3, 39,  5,  0)
	
	dot_set_weapon(barbaroi8, 104010001)
	dot_set_weapon(barbaroi9, 104010001)
	dot_set_weapon(barbaroi10, 104010001)
	dot_set_weapon(barbaroi11, 104010001)
	dot_set_weapon(barbaroi12, 104010001)
	dot_set_weapon(barbaroi13, 104010001)
	dot_set_weapon(barbaroi14, 104010001)
	dot_set_weapon(barbaroi15, 104010001)
	dot_set_weapon(barbaroi16, 104010001)
	dot_set_weapon(barbaroi17, 104010001)
	dot_set_weapon(barbaroi18, 104010001)
	dot_set_weapon(barbaroi19, 104010001)
	dot_set_weapon(barbaroi20, 104010001)
	dot_set_weapon(barbaroi21, 104010001)
	dot_set_weapon(barbaroi22, 104010001)
	dot_set_weapon(barbaroi23, 104010001)
	dot_set_weapon(barbaroi24, 104010001)
	dot_set_weapon(barbaroi25, 104010001)
	dot_set_weapon(barbaroi26, 104010001)
	dot_set_weapon(barbaroi27, 104010001)
	dot_set_weapon(barbaroi28, 104010001)
	dot_set_weapon(barbaroi29, 104010001)
	dot_set_weapon(barbaroi30, 104010001)
	dot_set_weapon(barbaroi31, 104010001)
	dot_set_weapon(barbaroi32, 104010001)
	dot_set_weapon(barbaroi33, 104010001)
	dot_set_weapon(barbaroi34, 104010001)
	dot_set_weapon(barbaroi35, 104010001)
	dot_set_weapon(barbaroi36, 104010001)
	dot_set_weapon(barbaroi37, 104010001)
	dot_set_weapon(barbaroi38, 104010001)
	dot_set_weapon(barbaroi39, 104010001)
	dot_set_weapon(barbaroi40, 104010001)
	dot_set_weapon(barbaroi41, 104010001)
	dot_set_weapon(barbaroi42, 104010001)
	dot_set_weapon(barbaroiR, 104010001)
	dot_set_weapon(barbaroiR3, 104010001)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	dot_unit_dir(soldier11, 3)
	dot_unit_dir(barbaroi1, 2)
	dot_unit_dir(barbaroi2, 2)
	dot_unit_dir(barbaroi3, 2)
	dot_unit_dir(barbaroi5, 2)
	dot_unit_dir(barbaroi6, 2)
	dot_unit_dir(barbaroi7, 2)
	dot_unit_dir(barbaroiR, 3)
	dot_unit_dir(barbaroiR3, 3)
	dot_unit_dir(barbaroi8, 2)
	dot_unit_dir(barbaroi9, 2)
	dot_unit_dir(barbaroi10, 2)
	dot_unit_dir(barbaroi11, 2)
	dot_unit_dir(barbaroi12, 2)
	dot_unit_dir(barbaroi13, 2)
	dot_unit_dir(barbaroi14, 2)
	dot_unit_dir(barbaroi15, 2)
	dot_unit_dir(barbaroi16, 2)
	dot_unit_dir(barbaroi17, 2)
	dot_unit_dir(barbaroi18, 2)
	dot_unit_dir(barbaroi19, 2)
	dot_unit_dir(barbaroi20, 2)
	dot_unit_dir(barbaroi21, 2)
	dot_unit_dir(barbaroi22, 2)
	dot_unit_dir(barbaroi23, 2)
	dot_unit_dir(barbaroi24, 2)
	dot_unit_dir(barbaroi25, 2)
	dot_unit_dir(barbaroi26, 2)
	dot_unit_dir(barbaroi27, 2)
	dot_unit_dir(barbaroi28, 2)
	dot_unit_dir(barbaroi29, 2)
	dot_unit_dir(barbaroi30, 2)
	dot_unit_dir(barbaroi31, 2)
	dot_unit_dir(barbaroi32, 2)
	dot_unit_dir(barbaroi33, 2)
	dot_unit_dir(barbaroi34, 2)
	dot_unit_dir(barbaroi35, 2)
	dot_unit_dir(barbaroi36, 2)
	dot_unit_dir(barbaroi37, 2)
	dot_unit_dir(barbaroi38, 2)
	dot_unit_dir(barbaroi39, 2)
	dot_unit_dir(barbaroi40, 2)
	dot_unit_dir(barbaroi41, 2)
	dot_unit_dir(barbaroi42, 2)



	
	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotTyrfing1,false)
	dot_disp_weapon(dotGwenhwymawr1,false)
	dot_disp_weapon(dotGuinevere,false)
	dot_disp_weapon(dotRagnar1,false)
	dot_disp_weapon(dotGawain,false)
	
	
	
	
	
	dot_disp_unit(dotMerlin, false)
	
	
	
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(25.0, 0.0)

	
	
	move_camera(12, 30, 0.0)
	
	load_image("10201012",  "content_still_10201012_image", "102010120_StillImage")
	show_image("10201012", 0.0, 0.0, 0 ,true,false)
	
	Ef_WarpIN = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	Ef_WarpOut = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut2 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut3 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut4 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut5 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut6 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	Ef_WarpOut7 = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	end







function Play()
	fadein(0)
	Play_start(true)

	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)

	
	change_face(Tyrfing1,"Normal")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1 , nil)
	message("MA_01105_200002")
	close_speech_window()

	
	change_face(Gwenhwymawr1,"Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01105_200003")
	close_speech_window()

	dot_unit_dir(dotRagnar1,0)
	wait_time(1.0)
	wait_seq()
	
	
	
	change_camera_distance(10.0, 3.0)

	change_camera_angle(30.0, 3.0)
	move_camera(9, 13, 3.0)
	wait_time(4.5)
	move_camera(32,9, 3.0)
	wait_time(4.5)
	change_camera_distance(10.0, 3.0)
	change_camera_angle(30.0, 3.0)
	move_camera(12, 30, 3.0)
	change_camera_distance(8.0, 3.0)
	change_camera_angle(30.0, 3.0)
	wait_time(4.0)
	wait_seq()

	
	change_face(Ragnar1,"Surprise")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar1 , nil)
	message("MA_01105_200004")
	close_speech_window()
	
	dot_unit_dir(dotGwenhwymawr1,0)
	dot_unit_dir(dotNoir2,0)
	dot_unit_dir(dotGawain,0)
	dot_unit_dir(dotGuinevere,0)
	dot_unit_dir(dotTyrfing1,0)
	wait_seq()
	
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200006")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_200007")
	close_speech_window()

	
	change_face(Gwenhwymawr1,"Anger")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01105_200008")
	close_speech_window()

	
	change_face(Gawain,"Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01105_200009")
	close_speech_window()

	
	change_face(Ragnar1,"Sad")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar1, nil)
	message("MA_01105_200010")
	close_speech_window()
	
	dot_move_unit_seq(dotGuinevere, 12, 28)
	wait_seq()

	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200011")
	close_speech_window()
	
	wait_time(1.0)
	
	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200013")
	close_speech_window()
	
	
	change_face(Gwenhwymawr1,"Normal")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01105_200014")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200015")
	close_speech_window()

	
	change_face(Gwenhwymawr1,"Sad")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01105_200016")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200017")

	
	change_face(Guinevere,"Sad")
	message("MA_01105_200018")
	close_speech_window()

	
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01105_200019")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200020")
	close_speech_window()
	
	
	dot_unit_dir(dotTyrfing1, 2)
	
	
	change_face(Tyrfing1,"Sad")
	open_speech_window("CHRNAME_TYRFING",Tyrfing1 , nil)
	message("MA_01105_200021")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200022")
	close_speech_window()

	
	open_speech_window("CHRNAME_TYRFING",Tyrfing1 , nil)
	message("MA_01105_200023")
	close_speech_window()
	
	
	dot_move_unit_seq(dotGuinevere, 13, 29)
	wait_seq()
	
	
	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200024")
	close_speech_window()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_200025")
	close_speech_window()

	
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200027")

	
	message("MA_01105_200028")

	
	message("MA_01105_200029")
	close_speech_window()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301005", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
	
	
	open_simple_window("CHRNAME_NOIR")
	message("MA_01105_200031")
	
	
	
	
	message("MA_01105_200033")
	
	
	
	
	message("MA_01105_200035")
	close_narration_window()

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
	
	
	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01105_200037")
	close_speech_window()
	
	
	
	on_active(Ef_WarpIN) 

	local gridpos = get_grid_position(15, 29) 
	set_pos(Ef_WarpIN, gridpos)
	play_particle(Ef_WarpIN)

	wait_time(0.5)
	
	dot_disp_unit(dotMerlin, true)
	dot_unit_dir(dotMerlin, 2)
	
	wait_time(1.0)
	wait_seq()
	
	
	
	change_face(Merlin,"Anger")
	open_speech_window("CHRNAME_MERLIN",Merlin , nil)
	message("MA_01105_200039")
	close_speech_window()
	
	dot_unit_dir(dotTyrfing1, 3)

	
	change_face(Gawain,"Surprise")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01105_200040")
	close_speech_window()

	
	open_speech_window("CHRNAME_MERLIN", Merlin, nil)
	message("MA_01105_200041")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01105_200042")
	close_speech_window()
	
	
	
	change_face(Gwenhwymawr1,"Anger")
	open_speech_window("NPCNAME_0070",Gwenhwymawr1 , nil)
	message("MA_01105_200044")
	close_speech_window()

	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere , nil)
	message("MA_01105_200045")

	
	change_face(Guinevere,"Sad")
	message("MA_01105_200046")
	close_speech_window()
	
	on_active(Ef_WarpOut) 

	local gridpos = get_grid_position(15, 29) 
	set_pos(Ef_WarpOut, gridpos)
	play_particle(Ef_WarpOut)

	wait_time(0.3)
	
	dot_disp_unit(dotMerlin, false)
	
	wait_time(0.5)
	
	on_active(Ef_WarpOut2) 

	local gridpos = get_grid_position(13,30) 
	set_pos(Ef_WarpOut2, gridpos)
	play_particle(Ef_WarpOut2)
	
	dot_disp_unit(dotNoir2, false)
	
	on_active(Ef_WarpOut3) 

	local gridpos = get_grid_position(14, 30) 
	set_pos(Ef_WarpOut3, gridpos)
	play_particle(Ef_WarpOut3)
	
	dot_disp_unit(dotTyrfing1, false)
	
	on_active(Ef_WarpOut4) 

	local gridpos = get_grid_position(13, 29) 
	set_pos(Ef_WarpOut4, gridpos)
	play_particle(Ef_WarpOut4)
	
	dot_disp_unit(dotGuinevere, false) 
	
	on_active(Ef_WarpOut5) 

	local gridpos = get_grid_position(12, 30) 
	set_pos(Ef_WarpOut5, gridpos)
	play_particle(Ef_WarpOut5)
	
	dot_disp_unit(dotGwenhwymawr1, false)
	
	on_active(Ef_WarpOut6) 

	local gridpos = get_grid_position(11, 30) 
	set_pos(Ef_WarpOut6, gridpos)
	play_particle(Ef_WarpOut6)
	
	dot_disp_unit(dotGawain, false)
	
	on_active(Ef_WarpOut7) 

	local gridpos = get_grid_position(10, 30) 
	set_pos(Ef_WarpOut7, gridpos)
	play_particle(Ef_WarpOut7)

	wait_time(0.3)
	
	dot_disp_unit(dotRagnar1, false)
	
	wait_time(1.0)
	
	wait_seq()
	
	

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("10301005", "content_still_10301005_image", "103010050_StillImage")
	pbadv_setup_101009_Noir_preload(2,true,13,30,0)
	pbadv_setup_101001_Tyrfing_preload(1,true,14,  30,0)
	pbadv_setup_101011_Guinevere_preload(0,true,12, 29,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,12, 30,0)
	pbadv_setup_101013_Gawain_preload(0,true,11, 30,0)
	pbadv_setup_101018_Ragnar_preload(1,true,10, 30,0)
	pbadv_setup_101020_Merlin_preload(0,true,15, 29,0)
	load_image_preload("10201012",  "content_still_10201012_image", "102010120_StillImage")
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_OUT_ADV", false, true)
end
