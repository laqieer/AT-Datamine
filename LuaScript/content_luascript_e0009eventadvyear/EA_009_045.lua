

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	init_psbattleadv("201210000", "25010201")
	change_time_and_weather(BattleTime_Sunset,BattleWeather_Shiny)
	
	
	pbadv_setup_101009_Noir(2,true, 20, 9,0)  
	
	pbadv_setup_101012_Dinatan(0,true,20,11,0)
	
	pbadv_setup_101030_Elaine(1,true,21 ,11 ,0)  
	
	pbadv_setup_101031_Lovein(1,true,19 ,11 ,0)  
	
	Tyr = dot_reserve_facility(52, 20, 0, DotDir_Up, 1, true)
	
	barbaroi = dot_reserve_ally(201020001, 19, 6, 0)
	magic = dot_reserve_ally(401011001, 20, 6, 0)
	dot_set_weapon(magic, 107010001) 
	dot_set_weapon(barbaroi, 107010001) 
	
	setup_complete_unit()
	
	dot_disp_weapon(barbaroi, false)
	dot_disp_unit(magic,false)
	
	dot_unit_dir(barbaroi, 2)
	dot_unit_dir(magic, 2)
	
	change_camera_distance(8.0, 0.0)

	change_camera_angle(25.0, 0.0)
	
	move_camera(20, 9, 0.0)
	
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_Fog2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_Fog3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	Ef_EnemyDie = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	
	dot_disp_facility(Tyr,true)

	load_sound("BGM_ADV_Painful")
	
	
end

	



function Play()
	fadein(0)
	Play_start(true)

	-- @ノワール	ハアアアアッ！
	change_face(Noir2, "Anger")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	PlayPartVoiceDirect("ノワール","0035")
	message("EA_009_0450002")
	close_speech_window()

	--ノワール攻撃
	dot_unit_dir(dotNoir2, 0)
	dot_unit_dir(barbaroi, 1)
	wait_seq()
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Swd_N_Atk01",3,true)
	dot_change_anim(barbaroi,6)
	dot_unit_dir(barbaroi, 2)
	dot_play_particle_unit(barbaroi,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_move_knockback(barbaroi,19, 4,0.4,2)
	wait_time(0.4)

	wait_time(0.4)
	dot_change_anim(barbaroi,1)
	dot_change_anim(dotNoir2,0)
	
	--姿が戻る
	
	on_active(Ef_Fog) 

	local gridpos = get_grid_position(20, 6)
	set_pos(Ef_Fog, gridpos)
	set_scale(Ef_Fog, {1.6, 1.6, 1.6})
	play_particle(Ef_Fog)
	
	on_active(Ef_EnemyDie) 
	local gridpos = get_grid_position(20, 6)
	set_pos(Ef_EnemyDie, gridpos)
	play_particle(Ef_EnemyDie)
	
	wait_time(1.2)
	
	dot_change_anim(magic,1)
	dot_disp_unit(magic, true)
	dot_disp_unit(barbaroi, false)
	
	
	
	wait_time(1.7)
	
	wait_seq()
	
	
	-- @魔術師	ば、バカな…
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0450004")
	close_speech_window()
	
	stop_particle(Ef_Fog)
	dot_change_anim(magic,0)
	move_camera(20, 4, 3.0)
	wait_time(0.5)
	dot_move_unit_seq(magic ,20,3,0.1)
	
	--ふらふらと祭壇へ近づく

	bgm_play("BGM_ADV_Painful")
	-- @魔術師	私は継承者、選ばれた存在なのだだから、負けるはずがないのに――…
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0450006")
	--close_speech_window()

	-- @魔術師	そう、私は継承者として皆を救う――家族を、村の皆を、まもる――
	--open_speech_window("",nil , nil)
	message("EA_009_0450007")
	--close_speech_window()
	
	-- @魔術師	すくう――バルバロイを滅して――あれ？
	--open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0450008")
	close_speech_window()
	
	--足を止める
	--一人のみ映るように調整
	wait_time(1.0)
	dot_unit_dir(magic, 2)
	on_active(Ef_Fog) 

	local gridpos = get_grid_position(20, 3)
	set_pos(Ef_Fog, gridpos)
	set_scale(Ef_Fog, {1.0, 1.0, 1.0})
	play_particle(Ef_Fog)
	
	wait_time(1.0)
	

	bgm_play("Stop_BGM_Bus_LongFade")
	-- @魔術師	あれ――じゃあ、なんで私は――
	open_speech_window("NPCNAME_0393",nil , nil)
	message("EA_009_0450009")
	close_speech_window()
	
	wait_time(0.5)
	--少し待って消滅
	
	
	
	on_active(Ef_EnemyDie) 

	local gridpos = get_grid_position(20, 3)
	set_pos(Ef_EnemyDie, gridpos)
	set_scale(Ef_EnemyDie, {1.0, 1.0, 1.0})
	play_particle(Ef_EnemyDie)
	
	wait_time(0.7)
	
	dot_disp_unit(magic, false)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 20, 9,0)
	pbadv_setup_101012_Dinatan_preload(0,true,20,11,0)
	pbadv_setup_101030_Elaine_preload(1,true,21 ,11 ,0)
	pbadv_setup_101031_Lovein_preload(1,true,19 ,11 ,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	preload_sound("BGM_ADV_Painful")
end
