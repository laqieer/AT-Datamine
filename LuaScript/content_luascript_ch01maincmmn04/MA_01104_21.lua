

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)

	
	init_psbattleadv("201210000", "25010201")
	change_time_and_weather(BattleTime_Sunset,BattleWeather_Shiny)

	pbadv_setup_101013_Gawain(0,true, 16, 35,0)
	
	pbadv_setup_101011_Guinevere(0,true, 20, 34,0)

	pbadv_setup_101016_Gwenhwymawr(1,true, 20, 30,0)
	
	pbadv_setup_101018_Ragnar(0,true, 16, 34,0)

	
	
	barbaroi1 = dot_reserve_enemy(1, 21, 34, 0)
	barbaroi2 = dot_reserve_enemy(1100, 21, 35, 0)
	
	
	barbaroi3 = dot_reserve_enemy(1, 19, 33, 0)
	barbaroi4 = dot_reserve_enemy(1100, 20, 32, 0)
	
	
	barbaroi5 = dot_reserve_enemy(1, 19, 36, 0)	
	
	
	barbaroi7 = dot_reserve_enemy(1, 18, 34, 0)
	barbaroi8 = dot_reserve_enemy(1100, 18, 35, 0)

	
	setup_complete_unit()
	
	
	dot_unit_dir(dotGwenhwymawr1, 1)
	dot_unit_dir(barbaroi7, 3)
	dot_unit_dir(barbaroi8, 3)


	
	dot_disp_unit(dotGwenhwymawr1, false)
	dot_disp_unit(dotGawain, false)
	dot_disp_unit(dotRagnar, false)

	
	change_camera_distance(8.0, 0.0)
	
	
	change_camera_angle(55.0, 0.0)
	
	
	move_camera(20, 34, 0.0)
end






function Play()
	fadein(0)
	Play_start(true)
	

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_210002")

	
	message("MA_01104_210004")
	close_speech_window()

	
	dot_move_unit_seq(barbaroi4, 20, 33)
	
	wait_seq()
	
	dot_disp_unit(dotGwenhwymawr1, true)
	dot_move_unit_seq(dotGwenhwymawr1, 20, 32)
	wait_seq()

	dot_attack_seq(dotGwenhwymawr1, barbaroi3)			
	dot_damage_seq(barbaroi4, dotGwenhwymawr1, false)
	wait_seq()

	dot_change_anim(barbaroi4, 6)

	dot_damage_seq(barbaroi3, dotGwenhwymawr1, false)	
	wait_seq()

	dot_change_anim(dotGwenhwymawr1, DotAnim_Idle)		
	dot_change_anim(barbaroi3, 6)
	
	dot_dying_unit_seq(barbaroi4)
	dot_dying_unit_seq(barbaroi3)
	wait_seq()
	

	move_camera(20, 35, 1.0)
	dot_move_unit_seq(dotGwenhwymawr1, 20, 33)
	wait_seq()

	change_face(Gwenhwymawr1, "Smile")
	open_speech_window("NPCNAME_0070", Gwenhwymawr1, nil)
	message("MA_01104_210006")
	close_speech_window()

	
	change_face(Guinevere, "Anger")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_210008")
	close_speech_window()

	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01104_210010")
	close_speech_window()

	
	dot_disp_unit(dotGawain, true)
	dot_disp_unit(dotRagnar, true)

	dot_move_unit_seq(dotGawain, 17, 35)
	

	move_camera(17, 35, 1.0)
	wait_camera()
	wait_seq()

	dot_attack_seq(dotGawain, barbaroi8)
	dot_damage_seq(barbaroi8, dotGawain, false)	
	wait_seq()

	dot_change_anim(barbaroi8, 6)

	dot_attack_seq(dotRagnar, barbaroi7)
	dot_damage_seq(barbaroi7, dotRagnar, false)	

	wait_seq()
	dot_change_anim(barbaroi7, 6)

	dot_change_anim(dotGawain, DotAnim_Idle)
	dot_change_anim(dotRagnar, DotAnim_Idle)


	dot_dying_unit_seq(barbaroi8)
	dot_dying_unit_seq(barbaroi7)

	wait_seq()

	move_camera(17, 35, 1.0)

	dot_change_anim(dotGawain, 0)
	dot_change_anim(dotRagnar, 0)

	dot_unit_dir(dotGuinevere, 2)
	dot_unit_dir(dotGwenhwymawr1, 2)

	wait_camera()

	
	change_face(Guinevere, "Surprise")
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)
	message("MA_01104_210012")
	close_speech_window()

	
	change_face(Gawain, "Smile")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01104_210013")

	
	change_face(Gawain, "Normal")
	message("MA_01104_210014")
	close_speech_window()

	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101013_Gawain_preload(0,true, 16, 35,0)
	pbadv_setup_101011_Guinevere_preload(0,true, 20, 34,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true, 20, 30,0)
	pbadv_setup_101018_Ragnar_preload(0,true, 16, 34,0)
end
