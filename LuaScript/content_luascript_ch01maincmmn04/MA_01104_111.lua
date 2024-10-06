-- MA_01104_111
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")

function Load()
	Load_common(true)

	
	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(BattleTime_Sunset , BattleWeather_Shiny)

	pbadv_setup_101009_Noir(2,true, 20, 22,0) --ノワール
	pbadv_setup_101012_Dinatan(0,true, 22, 14,0)  --ディナタン
	pbadv_setup_101001_Tyrfing(1,true, 19, 22,0)  --ティルフィング（キラーズ）
	pbadv_setup_101010_Lancelot(0,true, 20,29,0)  --ランスロット
	pbadv_setup_101013_Gawain(0,true, 19, 33,0)  --ガウェイン
	pbadv_setup_101018_Ragnar(1,true, 21, 33,0)  --ラグネル・ガラティン
	pbadv_setup_101014_Tristan(0,true, 17, 33,0)  --トリスタン
	pbadv_setup_101019_Isolde(1,true, 18, 33,0)  --イゾルデ・フェイルノート


	barbaroiB1 = dot_reserve_ally(201026001, 19, 17, 0)
	dot_set_weapon(barbaroiB1, 102020001)

	barbaroiB2 = dot_reserve_ally(201026001, 14, 21, 0)
	dot_set_weapon(barbaroiB2, 102020001)

	barbaroiB3 = dot_reserve_ally(201026001, 24, 21, 0)
	dot_set_weapon(barbaroiB3, 102020001)

	barbaroi1 = dot_reserve_enemy(1, 18, 20, 0)
	barbaroi2 = dot_reserve_enemy(1, 19, 20, 0)
	barbaroi3 = dot_reserve_enemy(1, 20, 20, 0)
	barbaroi4 = dot_reserve_enemy(1, 21, 20, 0)
	barbaroi5 = dot_reserve_enemy(1, 22, 20, 0)

	barbaroi6 = dot_reserve_enemy(1, 18, 24, 0)
	barbaroi7 = dot_reserve_enemy(1, 19, 24, 0)
	barbaroi8 = dot_reserve_enemy(1, 20, 24, 0)
	barbaroi9 = dot_reserve_enemy(1, 21, 24, 0)
	barbaroi10 = dot_reserve_enemy(1, 22, 24, 0)

	barbaroi11 = dot_reserve_enemy(1, 18, 21, 0)
	barbaroi12 = dot_reserve_enemy(1, 18, 22, 0)
	barbaroi13 = dot_reserve_enemy(1, 18, 23, 0)

	barbaroi14 = dot_reserve_enemy(1, 22, 21, 0)
	barbaroi15 = dot_reserve_enemy(1, 22, 22, 0)
	barbaroi16 = dot_reserve_enemy(1, 22, 23, 0)

	setup_complete_unit()

	dot_disp_unit(dotGawain,false)
	dot_disp_unit(dotRagnar1,false)

	dot_disp_unit(dotTristan,false)
	dot_disp_unit(dotIsolde1,false)

	dot_disp_unit(dotLancelot,false)

	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
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

	dot_disp_unit(barbaroiB1,false)
	dot_disp_unit(barbaroiB2,false)
	dot_disp_unit(barbaroiB3,false)

	dot_change_anim(dotNoir2, 1)
	dot_change_anim(dotDinatan, 1)

	dot_unit_dir(barbaroiB1,2)
	dot_unit_dir(barbaroiB3,2)

	dot_unit_dir(barbaroi1,3)
	dot_unit_dir(barbaroi6,3)
	dot_unit_dir(barbaroi2,3)
	dot_unit_dir(barbaroi7,3)
	dot_unit_dir(barbaroi11,3)
	dot_unit_dir(barbaroi12,3)
	dot_unit_dir(barbaroi13,3)

	change_camera_distance(8.0, 0.0)
	
	change_camera_angle(25.0, 0.0)
	
	move_camera(20, 22, 0.0)
	
	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar9 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar10 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar11 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar12 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar13 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar14 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar15 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar16 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_bar11 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar12 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar13 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_fh1 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	Ef_fh2 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	Ef_fh3 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)

	Ef_Roar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	Ef_Roar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	Ef_Roar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)

	Ef_Killers1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 
	Ef_Killers2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true) 

	Ef_Vibes1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_Vibes2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 
	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_KillChan2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 

end

function Play()
	Play_start(true)
	fadein(0)

	-- @ティルフィング	己を責めないでください。マスター	
	change_face(Tyrfing1, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1110002")
	close_speech_window()

	-- @ノワール	はぁ…、はぁ…、はぁ…！まだ、終わってない…！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110003")
	close_speech_window()

	-- @ティルフィング	マスター残りは私が引き受けます	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1110004")
	close_speech_window()

	-- @ノワール	まだ戦える、まだ！！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110005")
	close_speech_window()


	on_active(Ef_bar1) 

	local gridpos = get_grid_position(18, 20)
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8})
	play_particle(Ef_bar1)

	on_active(Ef_bar2) 

	local gridpos = get_grid_position(19, 20)
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8})
	play_particle(Ef_bar2)

	on_active(Ef_bar3) 

	local gridpos = get_grid_position(20, 20)
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8})
	play_particle(Ef_bar3)

	on_active(Ef_bar4) 

	local gridpos = get_grid_position(21, 20)
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8})
	play_particle(Ef_bar4)

	on_active(Ef_bar5) 

	local gridpos = get_grid_position(22, 20)
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8})
	play_particle(Ef_bar5)

	on_active(Ef_bar6) 

	local gridpos = get_grid_position(18, 24)
	set_pos(Ef_bar6, gridpos)
	set_scale(Ef_bar6, {0.8, 0.8, 0.8})
	play_particle(Ef_bar6)

	on_active(Ef_bar7) 

	local gridpos = get_grid_position(19, 24)
	set_pos(Ef_bar7, gridpos)
	set_scale(Ef_bar7, {0.8, 0.8, 0.8})
	play_particle(Ef_bar7)

	on_active(Ef_bar8) 

	local gridpos = get_grid_position(20, 24)
	set_pos(Ef_bar8, gridpos)
	set_scale(Ef_bar8, {0.8, 0.8, 0.8})
	play_particle(Ef_bar8)

	on_active(Ef_bar9) 

	local gridpos = get_grid_position(21, 24)
	set_pos(Ef_bar9, gridpos)
	set_scale(Ef_bar9, {0.8, 0.8, 0.8})
	play_particle(Ef_bar9)

	on_active(Ef_bar10) 

	local gridpos = get_grid_position(18, 21)
	set_pos(Ef_bar10, gridpos)
	set_scale(Ef_bar10, {0.8, 0.8, 0.8})
	play_particle(Ef_bar10)

	on_active(Ef_bar11) 

	local gridpos = get_grid_position(18, 22)
	set_pos(Ef_bar11, gridpos)
	set_scale(Ef_bar11, {0.8, 0.8, 0.8})
	play_particle(Ef_bar11)

	on_active(Ef_bar12) 

	local gridpos = get_grid_position(18, 23)
	set_pos(Ef_bar12, gridpos)
	set_scale(Ef_bar12, {0.8, 0.8, 0.8})
	play_particle(Ef_bar12)

	on_active(Ef_bar13) 

	local gridpos = get_grid_position(22, 21)
	set_pos(Ef_bar13, gridpos)
	set_scale(Ef_bar13, {0.8, 0.8, 0.8})
	play_particle(Ef_bar14)

	on_active(Ef_bar14) 

	local gridpos = get_grid_position(22, 22)
	set_pos(Ef_bar14, gridpos)
	set_scale(Ef_bar14, {0.8, 0.8, 0.8})
	play_particle(Ef_bar14)

	on_active(Ef_bar15) 

	local gridpos = get_grid_position(22, 23)
	set_pos(Ef_bar15, gridpos)
	set_scale(Ef_bar15, {0.8, 0.8, 0.8})
	play_particle(Ef_bar15)

	on_active(Ef_bar16) 

	local gridpos = get_grid_position(22, 24)
	set_pos(Ef_bar16, gridpos)
	set_scale(Ef_bar16, {0.8, 0.8, 0.8})
	play_particle(Ef_bar16)


	wait_time(0.2)

	dot_disp_unit(barbaroi1,true)
	dot_disp_unit(barbaroi2,true)
	dot_disp_unit(barbaroi3,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)
	dot_disp_unit(barbaroi9,true)
	dot_disp_unit(barbaroi10,true)
	dot_disp_unit(barbaroi11,true)
	dot_disp_unit(barbaroi12,true)
	dot_disp_unit(barbaroi13,true)
	dot_disp_unit(barbaroi14,true)
	dot_disp_unit(barbaroi15,true)
	dot_disp_unit(barbaroi16,true)
	
	wait_time(2.0)

	dot_unit_dir(dotTyrfing1, 2)
	wait_time(0.5)
	dot_unit_dir(dotTyrfing1, 3)
	
	-- @ティルフィング	マスター、お退きを…！	
	change_face(Tyrfing1, "Surprise")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1110007")
	close_speech_window()


	on_active(Ef_bar11) 

	local gridpos = get_grid_position(20, 17)
	set_pos(Ef_bar11, gridpos)
	set_scale(Ef_bar11, {1.2, 1.2, 1.2})
	play_particle(Ef_bar11)

	on_active(Ef_bar12) 

	local gridpos = get_grid_position(15, 22)
	set_pos(Ef_bar12, gridpos)
	set_scale(Ef_bar12, {1.2, 1.2, 1.2})
	play_particle(Ef_bar12)

	on_active(Ef_bar13) 

	local gridpos = get_grid_position(25, 22)
	set_pos(Ef_bar13, gridpos)
	set_scale(Ef_bar13, {1.2, 1.2, 1.2})
	play_particle(Ef_bar13)


	wait_time(1.0)

	on_active(Ef_fh1)
	local gridpos=get_grid_position(20,17)
	gridpos[2]=1.0
	set_pos(Ef_fh1,gridpos)
	set_scale(Ef_fh1, {1.2, 1.2, 1.2})
	play_particle(Ef_fh1)	

	on_active(Ef_fh2)
	local gridpos=get_grid_position(15,22)
	gridpos[2]=1.0
	set_pos(Ef_fh2,gridpos)
	set_scale(Ef_fh2, {1.2, 1.2, 1.2})
	play_particle(Ef_fh2)	

	on_active(Ef_fh3)
	local gridpos=get_grid_position(25,22)
	gridpos[2]=1.0
	set_pos(Ef_fh3,gridpos)
	set_scale(Ef_fh3, {1.2, 1.2, 1.2})
	play_particle(Ef_fh3)	

	wait_time(0.2)

	dot_disp_unit(barbaroiB1,true)
	dot_disp_unit(barbaroiB2,true)
	dot_disp_unit(barbaroiB3,true)
	
	wait_time(2.0)
		
	dot_change_anim(dotNoir2, 0)

	-- @ノワール	往こう、ティルフィング	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110009")
	close_speech_window()

	-- @ティルフィング	マスター…！	
	change_face(Tyrfing1, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1110010")
	close_speech_window()

	-- @ノワール	往くんだ！！	
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110011")
	close_speech_window()

	dot_move_unit_seq(barbaroi15, 21, 22)
	wait_seq()
	
	-- @バルバロイ	アアアアアアアアア！！	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MA_01104_1110012")
	close_speech_window()

	-- @？？？	「つがえて、<ruby=ひ>弾</ruby>いて」	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_1110015")
	close_speech_window()


	dot_disp_unit(dotTristan,true)
	dot_disp_unit(dotIsolde1,true)

	dot_attack_seq(dotTristan, barbaroi15)
	dot_damage_seq(barbaroi15, dotTristan, false)
	wait_seq()

	dot_change_anim(dotTristan, DotAnim_Idle)

	dot_change_anim(barbaroi15,6)

	wait_time(0.2)

	dot_dying_unit_seq(barbaroi15)
	wait_seq()

	on_active(Ef_Killers1)
	on_active(Ef_Vibes1)

	local gridpos = get_grid_position(18, 33)
	set_pos(Ef_Killers1, gridpos)
	play_particle(Ef_Killers1)

	local gridpos = get_grid_position(17, 33)
	set_pos(Ef_Vibes1, gridpos)
	play_particle(Ef_Vibes1)
	
	-- @？？？	「<ruby=かな>奏</ruby>でる<ruby=つるね>弦音</ruby>、<ruby=まと>的</ruby>を<ruby=い>射</ruby>て」	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_1110021")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Tristan,"Normal",0)

	-- @クールな少年	イゾルデ──<ruby=ファクタライズ>因枢分解</ruby>・フェイルノート	
	open_speech_window("NPCNAME_0074", nil, nil)
	message("MA_01104_1110024")
	close_speech_window()

	close_cutin()	

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(18, 33)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	stop_particle(Ef_Vibes1)
	stop_particle(Ef_Killers1)


	move_camera(18, 33, 3.0)
	wait_camera()
	

	dot_attack_seq(dotTristan, barbaroi2)
	dot_attack_seq(dotIsolde1, barbaroi5)
	wait_seq()

	dot_change_anim(dotTristan, DotAnim_Idle)
	dot_change_anim(dotIsolde1, DotAnim_Idle)

	move_camera(20, 22, 1.0)
	wait_camera()

	wait_time(0.3)

	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_play_particle_unit(barbaroi14,"Ef_C_Cmn_N_Hit_Spe01",1,true)
	dot_play_particle_unit(barbaroi16,"Ef_C_Cmn_N_Hit_Spe01",1,true)


	dot_change_anim(barbaroi1,6)
	dot_change_anim(barbaroi2,6)
	dot_change_anim(barbaroi3,6)
	dot_change_anim(barbaroi4,6)
	dot_change_anim(barbaroi5,6)
	dot_change_anim(barbaroi14,6)
	dot_change_anim(barbaroi16,6)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi4,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi5,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi14,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi16,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi1, false)
	dot_disp_unit(barbaroi2, false)
	dot_disp_unit(barbaroi3, false)
	dot_disp_unit(barbaroi4, false)
	dot_disp_unit(barbaroi5, false)
	dot_disp_unit(barbaroi14, false)
	dot_disp_unit(barbaroi16, false)

	dot_remove_unit(barbaroi1)
	dot_remove_unit(barbaroi2)
	dot_remove_unit(barbaroi3)
	dot_remove_unit(barbaroi4)
	dot_remove_unit(barbaroi5)
	dot_remove_unit(barbaroi14)
	dot_remove_unit(barbaroi16)

	wait_time(0.5)

	-- @クールな少年	ガウェインッ！	
	change_face(Tristan, "Anger")
	open_speech_window("NPCNAME_0074", Tristan, nil)
	message("MA_01104_1110029")
	close_speech_window()


	dot_disp_unit(dotGawain,true)
	dot_disp_unit(dotRagnar1,true)

	on_active(Ef_Killers2)
	on_active(Ef_Vibes2)

	local gridpos = get_grid_position(21, 33)
	set_pos(Ef_Killers2, gridpos)
	play_particle(Ef_Killers2)

	local gridpos = get_grid_position(19, 33)
	set_pos(Ef_Vibes2, gridpos)
	play_particle(Ef_Vibes2)
	
	-- @ガウェイン	「<ruby=ひ>陽</ruby>よ昇れ、夜に<ruby=さ>差</ruby>せ、暗きを<ruby=い>出</ruby>で」！	
	change_face(Gawain, "Anger")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	message("MA_01104_1110031")
	close_speech_window()

	-- @？？？	「来たる光を<ruby=みえ>三重</ruby>に宿せ」！	
	open_speech_window("CHRNAME_NAMELES", nil, nil)
	message("MA_01104_1110034")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Gawain,"Anger",0)

	-- @ガウェイン	ラグネル――<ruby=ファクタライズ>因枢分解</ruby>・ガラティン！	
	open_speech_window("CHRNAME_GAWAIN", nil, nil)
	message("MA_01104_1110036")
	close_speech_window()

	close_cutin()	

	move_camera(20, 23, 1.0)
	wait_camera()

	on_active(Ef_KillChan2)

	local gridpos = get_grid_position(21, 33)
	set_pos(Ef_KillChan2, gridpos)
	play_particle(Ef_KillChan2)
	
	dot_reserve_move_unit_seq(dotGawain, 19, 25)
	dot_reserve_move_unit_seq(dotRagnar1, 21, 25)
	
	exec_parallel_seq()

	wait_seq()

	stop_particle(Ef_Vibes2)
	stop_particle(Ef_Killers2)

	dot_attack_seq(dotGawain, barbaroi7)
	dot_attack_seq(dotRagnar1, barbaroi9)
	wait_seq()

	wait_time(0.3)

	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_play_particle_unit(barbaroi8,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi9,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi10,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroi11,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_play_particle_unit(barbaroi12,"Ef_C_Cmn_N_Hit_Str01",1,true)
	dot_play_particle_unit(barbaroi13,"Ef_C_Cmn_N_Hit_Str01",1,true)

	dot_change_anim(barbaroi6,6)
	dot_change_anim(barbaroi7,6)
	dot_change_anim(barbaroi8,6)
	dot_change_anim(barbaroi9,6)
	dot_change_anim(barbaroi10,6)
	dot_change_anim(barbaroi11,6)
	dot_change_anim(barbaroi12,6)
	dot_change_anim(barbaroi13,6)

	dot_change_anim(dotGawain, DotAnim_Idle)
	dot_change_anim(dotRagnar1, DotAnim_Idle)

	wait_time(0.2)

	dot_play_particle_unit(barbaroi6,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi7,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi8,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi9,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi10,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi11,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi12,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroi13,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(barbaroi6, false)
	dot_disp_unit(barbaroi7, false)
	dot_disp_unit(barbaroi8, false)
	dot_disp_unit(barbaroi9, false)
	dot_disp_unit(barbaroi10, false)
	dot_disp_unit(barbaroi11, false)
	dot_disp_unit(barbaroi12, false)
	dot_disp_unit(barbaroi13, false)

	dot_remove_unit(barbaroi6)
	dot_remove_unit(barbaroi7)
	dot_remove_unit(barbaroi8)
	dot_remove_unit(barbaroi9)
	dot_remove_unit(barbaroi10)
	dot_remove_unit(barbaroi11)
	dot_remove_unit(barbaroi12)
	dot_remove_unit(barbaroi13)

	wait_time(0.5)

	move_camera(20, 22, 1.0)
	wait_camera()
	
	-- @ノワール	（…ケタが、違う──…！）	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110039")
	close_speech_window()

	on_active(Ef_Roar1)

	local gridpos = get_grid_position(19, 17)
	set_pos(Ef_Roar1, gridpos)
	play_particle(Ef_Roar1)

	on_active(Ef_Roar2)

	local gridpos = get_grid_position(14, 21)
	set_pos(Ef_Roar2, gridpos)
	play_particle(Ef_Roar2)

	on_active(Ef_Roar3)

	local gridpos = get_grid_position(24, 21)
	set_pos(Ef_Roar3, gridpos)
	play_particle(Ef_Roar3)

	wait_time(0.2)
	
	-- @巨大バルバロイ	アアアアアアアアアアアアアアア！！！！	
	open_speech_window("NPCNAME_0365", nil, nil)
	message("MA_01104_1110041")
	close_speech_window()

	dot_reserve_move_unit_seq(barbaroiB1, 19, 19)
	dot_reserve_move_unit_seq(barbaroiB2, 15, 21)
	dot_reserve_move_unit_seq(barbaroiB3, 23, 21)
	
	exec_parallel_seq()

	wait_seq()
	dot_unit_dir(barbaroiB1, 2)

	dot_attack_seq(barbaroiB1, dotNoir2)
	dot_damage_seq(dotNoir2, barbaroiB1, false)
	wait_seq()

	dot_change_anim(barbaroiB1, DotAnim_Idle)
	dot_change_anim(dotNoir2,6)
	dot_change_anim(dotTyrfing1,6)
	dot_unit_dir(barbaroiB1, 2)
	
	dot_move_knockback(dotTyrfing1,19,23,0.1,2)

	-- @ティルフィング	マスター！！	
	change_face(Tyrfing1, "Anger")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1110044")
	close_speech_window()

	dot_change_anim(dotNoir2,1)
	dot_change_anim(dotTyrfing1,1)

	dot_reserve_move_unit_seq(barbaroiB2, 16, 21)
	dot_reserve_move_unit_seq(barbaroiB3, 22, 21)
	
	exec_parallel_seq()

	wait_seq()

	-- @ノワール	ッ！？	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110046")
	close_speech_window()

	dot_disp_unit(dotLancelot,true)

	dot_play_particle_unit(barbaroiB1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroiB2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(barbaroiB3,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(barbaroiB1,6)
	dot_change_anim(barbaroiB2,6)
	dot_change_anim(barbaroiB3,6)

	wait_time(1.0)

	dot_play_particle_unit(barbaroiB1,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroiB2,"Ef_C_Cmn_DieEmy01",2,true)
	dot_play_particle_unit(barbaroiB3,"Ef_C_Cmn_DieEmy01",2,true)
	wait_time(0.5)

	dot_disp_unit(barbaroiB1, false)
	dot_disp_unit(barbaroiB2, false)
	dot_disp_unit(barbaroiB3, false)

	dot_remove_unit(barbaroiB1)
	dot_remove_unit(barbaroiB2)
	dot_remove_unit(barbaroiB3)

	wait_time(0.5)
	
	-- @ノワール	…！	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110048")
	close_speech_window()


	dot_move_unit_seq(dotLancelot, 21, 22)
	
	wait_seq()
	
	dot_unit_dir(dotLancelot, 2)

	-- @ノワール	………<ruby=ランスロット>最強、騎士</ruby>	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110050")
	close_speech_window()

	-- @ランスロット	無事か、ノワール	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01104_1110052")
	close_speech_window()

	dot_change_anim(dotNoir2,0)
	dot_change_anim(dotTyrfing1,0)

	-- @ノワール	…あ、いや	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110053")
	close_speech_window()

	-- @ランスロット	すこし学園を離れると、これか	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01104_1110055")
	close_speech_window()

	dot_reserve_move_unit_seq(dotGawain, 22, 21)
	dot_reserve_move_unit_seq(dotRagnar1, 23, 21)
	exec_parallel_seq()

	wait_seq()
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotRagnar1, 2)

	dot_reserve_move_unit_seq(dotTristan, 22, 23)
	dot_reserve_move_unit_seq(dotIsolde1, 23, 23)
	
	exec_parallel_seq()

	wait_seq()

	dot_unit_dir(dotLancelot, 3)
	dot_unit_dir(dotTristan, 2)
	dot_unit_dir(dotIsolde1, 2)	
	
	-- @ランスロット	ラグネル、ガウェイン！民への対処、任せる！	
	change_face(Lancelot, "Anger")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01104_1110057")

	-- @ランスロット	俺は残敵を殲滅する！イゾルデ、トリスタン、援護を！	
	message("MA_01104_1110058")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Lancelot,"Anger",0)

	-- @ランスロット	スタンド・バイ・ユアラウンド！（円卓の責務を果たせ）	
	open_speech_window("CHRNAME_LANCELOT", nil, nil)
	message("MA_01104_1110059")
	close_speech_window()

	close_cutin()	

	-- @一同	フォー・ラウンド！（円卓のために）	
	open_speech_window("NPCNAME_0126", nil, nil)
	message("MA_01104_1110061")
	close_speech_window()


	dot_reserve_move_unit_seq(dotLancelot, 20, 36)
	dot_reserve_move_unit_seq(dotGawain, 18, 36)
	dot_reserve_move_unit_seq(dotRagnar1, 19, 36)

	dot_reserve_move_unit_seq(dotTristan, 21, 36)
	dot_reserve_move_unit_seq(dotIsolde1, 22, 36)
	
	exec_parallel_seq()

	wait_seq()

	-- @ティルフィング	…私も、周囲の警戒を	
	change_face(Tyrfing1, "Sad")
	open_speech_window("CHRNAME_TYRFING", Tyrfing1, nil)
	message("MA_01104_1110063")
	close_speech_window()

	
	dot_move_unit_seq(dotTyrfing1, 20, 35)
	wait_seq()

	-- @ノワール	………くそ	
	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1110065")

	bgm_play("Stop_BGM_Bus_MidFade")
	-- @ノワール	また、俺は	
	message("MA_01104_1110066")
	close_speech_window()

	wait_time(0.5)

	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 22,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 22, 14,0)
	pbadv_setup_101001_Tyrfing_preload(1,true, 19, 22,0)
	pbadv_setup_101010_Lancelot_preload(0,true, 20,29,0)
	pbadv_setup_101013_Gawain_preload(0,true, 19, 33,0)
	pbadv_setup_101018_Ragnar_preload(1,true, 21, 33,0)
	pbadv_setup_101014_Tristan_preload(0,true, 17, 33,0)
	pbadv_setup_101019_Isolde_preload(1,true, 18, 33,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
end
