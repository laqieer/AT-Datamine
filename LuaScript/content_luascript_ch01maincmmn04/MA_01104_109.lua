-- MA_01104_109
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "MovieFunctions")

function Load()
	Load_common(true)

	
	init_psbattleadv("201150000", "201150000")
	change_time_and_weather(BattleTime_Sunset , BattleWeather_Shiny)

	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image("101010170", "content_still_10101017_image", "101010170_StillImage")

	pbadv_setup_101009_Noir(2,true, 16, 40,0) --ノワール
	pbadv_setup_101068_Urrie(0,true,15,40,0) --ウレリー
	pbadv_setup_101012_Dinatan(0,true, 20, 7,0)  --ディナタン


	dotsoldier1 = dot_reserve_ally(401036001, 18, 35, 0)
	dot_set_weapon(dotsoldier1, 101010001)    

	dotsoldier2 = dot_reserve_ally(401036001, 19, 35, 0)
	dot_set_weapon(dotsoldier2, 101010001)    

	dotsoldier3 = dot_reserve_ally(401036001, 20, 35, 0)
	dot_set_weapon(dotsoldier3, 101010001)    

	dotsoldier4 = dot_reserve_ally(401036001, 21, 35, 0)
	dot_set_weapon(dotsoldier4, 101010001)    


	dotsoldier5 = dot_reserve_ally(401035001, 20, 25, 0)
	dot_set_weapon(dotsoldier5, 101010001)    

	dotsoldier6 = dot_reserve_ally(401036001, 19, 26, 0)
	dot_set_weapon(dotsoldier6, 101010001)    


	barbaroiB = dot_reserve_ally(201026001, 19, 15, 0)
	dot_set_weapon(barbaroiB, 102020001)
	
	barbaroi1 = dot_reserve_enemy(1, 18, 37, 0)
	barbaroi2 = dot_reserve_enemy(1, 19, 36, 0)
	barbaroi3 = dot_reserve_enemy(1, 20, 36, 0)
	barbaroi4 = dot_reserve_enemy(1, 21, 37, 0)

	barbaroi5 = dot_reserve_enemy(1, 25, 40, 0)
	barbaroi6 = dot_reserve_enemy(1, 24, 40, 0)
	barbaroi7 = dot_reserve_enemy(1, 23, 41, 0)

	setup_complete_unit()

	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotUrrie,false)
	dot_disp_weapon(dotDinatan,false)

	dot_unit_dir(barbaroiB,2)

	dot_disp_unit(dotNoir2,false)
	dot_disp_unit(dotUrrie,false)
	dot_disp_unit(dotDinatan,false)
	dot_disp_unit(barbaroiB,false)

	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi6,false)
	dot_disp_unit(barbaroi7,false)

	change_camera_distance(8.0, 0.0)
	
	change_camera_angle(45.0, 0.0)
	
	move_camera(20, 36, 0.0)

	movie_load("MA_01104_109")

	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")

	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)

	Ef_Roar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)

	load_sound("BGM_ADV_Painful2")

end

function Play()
	Play_start(true)
	fadein(0)


	dot_attack_seq(dotsoldier3,barbaroi3)
	dot_damage_seq(barbaroi3,dotsoldier3,false)
	dot_attack_seq(dotsoldier2,barbaroi2)
	dot_damage_seq(barbaroi2,dotsoldier2,false)
	wait_seq()

	dot_attack_seq(barbaroi3,dotsoldier3)
	dot_damage_seq(dotsoldier3,barbaroi3,false)
	wait_seq()

	dot_change_anim(dotsoldier3,6)

	dot_attack_seq(barbaroi2,dotsoldier2)
	dot_damage_seq(dotsoldier2,barbaroi2,false)
	wait_seq()


	dot_play_particle_unit(dotsoldier1,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotsoldier2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotsoldier3,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotsoldier4,"Ef_C_Cmn_N_Hit_Sla01",1,true)


	dot_change_anim(barbaroi2,0)
	dot_change_anim(barbaroi3,0)

	dot_change_anim(dotsoldier1,1)
	dot_change_anim(dotsoldier2,1)
	dot_change_anim(dotsoldier3,1)
	dot_change_anim(dotsoldier4,1)

	wait_time(0.4)

	dot_move_knockback(dotsoldier1, 18, 34,0.1,2)
	dot_move_knockback(dotsoldier2, 19, 34,0.1,2)
	dot_move_knockback(dotsoldier3, 20, 34,0.1,2)
	dot_move_knockback(dotsoldier4, 21, 34,0.1,2)

	wait_time(0.5)

	dot_play_particle_unit(dotsoldier1,"Ef_C_Cmn_Die01",2,true)
	dot_play_particle_unit(dotsoldier2,"Ef_C_Cmn_Die01",2,true)
	dot_play_particle_unit(dotsoldier3,"Ef_C_Cmn_Die01",2,true)
	dot_play_particle_unit(dotsoldier4,"Ef_C_Cmn_Die01",2,true)
	wait_time(0.5)

	dot_remove_unit(dotsoldier1)
	dot_remove_unit(dotsoldier2)
	dot_remove_unit(dotsoldier3)
	dot_remove_unit(dotsoldier4)

	move_camera(20, 27, 2.0)
	wait_camera()
	
	-- @ログレス兵B	何が起きた！？	
	open_speech_window("NPCNAME_0364", nil, nil)
	message("MA_01104_1090002")
	close_speech_window()

	-- @ログレス兵A	じょ、城門が突破されました！！敵の群れが駆けて来て…！	
	open_speech_window("NPCNAME_0363", nil, nil)
	message("MA_01104_1090003")
	close_speech_window()

	-- @ログレス兵A	こんなこと、これまでなかったのに何が、どうして！？！？	
	open_speech_window("NPCNAME_0363", nil, nil)
	message("MA_01104_1090005")
	close_speech_window()


	dot_reserve_move_unit_seq(barbaroi1, 18, 26)
	dot_reserve_move_unit_seq(barbaroi2, 19, 27)
	dot_reserve_move_unit_seq(barbaroi3, 20, 26)
	dot_reserve_move_unit_seq(barbaroi4, 21, 25)

	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(barbaroi3,2)
	dot_unit_dir(barbaroi1,3)

	-- @テロップ	「バルバロイと戦える猛者たちもほとんどが喰い殺された」	

	open_narration_window()
	message("MA_01104_1090007")
	close_narration_window()


	dot_disp_unit(dotNoir2,true)
	dot_disp_unit(dotUrrie,true)
	dot_reserve_move_unit_seq(dotUrrie, 19, 40)
	dot_reserve_move_unit_seq(dotNoir2, 20, 40)
	
	exec_parallel_seq()
	wait_seq()
	
	
	move_camera(20, 35, 2.0)

	dot_reserve_move_unit_seq(dotUrrie, 19, 34)
	dot_reserve_move_unit_seq(dotNoir2, 20, 34)
	
	exec_parallel_seq()
	wait_seq()

	wait_camera()

	dot_remove_unit(dotsoldier5)
	dot_remove_unit(dotsoldier6)

	-- @ノワール	まさか──	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090009")
	close_speech_window()

	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)

	dot_place_unit(barbaroi5, 19, 38)
	dot_place_unit(barbaroi6, 20, 38)
	dot_place_unit(barbaroi7, 21, 38)
	
	dot_reserve_move_unit_seq(barbaroi5, 19, 36)
	dot_reserve_move_unit_seq(barbaroi6, 20, 36)
	dot_reserve_move_unit_seq(barbaroi7, 21, 36)
	exec_parallel_seq()

	wait_seq()


	-- @テロップ	「遠征中の円卓の騎士が何名もいて学園に残った兵も先のブリテン平定戦で疲弊」	

	open_narration_window()
	message("MA_01104_1090011")
	close_narration_window()

	move_camera(20, 15, 2.0)
	wait_camera()

	on_active(Ef_bar1)

	local gridpos = get_grid_position(20, 16)
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {1.2, 1.2, 1.2})
	play_particle(Ef_bar1)

	wait_time(1.0)


	change_camera_distance(6.0, 0.5)
	wait_camera()

	on_active(Ef_bar2)
	local gridpos=get_grid_position(20,16)
	gridpos[2]=1.0
	set_pos(Ef_bar2,gridpos)
	play_particle(Ef_bar2)	
	
	wait_time(0.2)
	close_textbox_base()
	disableTextBox = true

	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)

	move_camera(20, 16, 0.0)

	wait_time(BLACK_WHITE_WAIT_TIME)

	dot_disp_unit(barbaroiB,true)
	dot_disp_weapon(barbaroiB,true)

	off_active(Ef_bar1)
	off_active(Ef_bar2)

	movie_set_active(true)
	movie_play()

	hide_image(STILL_SWITCH_TIME) 
	change_camera_distance(8.0, 0)

	movie_wait_playing()
	movie_stop()
	
	wait_time(MOVIE_AFTER)


	move_camera(20, 35, 2.0)
	wait_camera()


	disableTextBox = false
	open_textbox_base()

	-- @ウレリー	うそ	
	change_face(Urrie, "Surprise")
	open_speech_window("CHRNAME_URRIE", Urrie, nil)
	message("MA_01104_1090013")
	close_speech_window()


	dot_disp_weapon(dotNoir2,true)

	-- @ノワール	逃げろ、俺が止める！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090014")
	close_speech_window()

	dot_move_unit_seq(dotUrrie, 18, 32)
	wait_seq()

	-- @ウレリー	ノワールくん、待って…こんなの見たことない貴方も逃げなきゃ──	
	change_face(Urrie, "Serious")
	open_speech_window("CHRNAME_URRIE", Urrie, nil)
	message("MA_01104_1090015")
	close_speech_window()

	move_camera(25, 23, 2.0)
	
	dot_move_unit_seq(dotNoir2, 26, 22)

	wait_seq()

	dot_unit_dir(dotNoir2,2)
	wait_camera()

	-- @ノワール	こっちだ！俺を狙え！！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090017")
	close_speech_window()

	
	dot_reserve_move_unit_seq(barbaroi1, 24, 21)
	dot_reserve_move_unit_seq(barbaroi2, 25, 22)
	dot_reserve_move_unit_seq(barbaroi3, 25, 23)
	dot_reserve_move_unit_seq(barbaroi4, 24, 24)
	dot_reserve_move_unit_seq(barbaroi5, 23, 22)
	dot_reserve_move_unit_seq(barbaroi6, 23, 23)
	dot_reserve_move_unit_seq(barbaroi7, 23, 24)

	exec_parallel_seq()

	wait_seq()


	-- @ノワール	今戦えるのは俺たちしかいないそうじゃなくても見過ごせない…！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090019")
	close_speech_window()

	dot_attack_seq(barbaroi2,dotNoir2)
	dot_dodge_seq(dotNoir2)
	wait_seq()

	dot_attack_seq(dotNoir2,barbaroi2)
	dot_damage_seq(barbaroi2,dotNoir2,false)
	wait_seq()

	dot_change_anim(barbaroi2,6)
	dot_change_anim(dotNoir2,0)

	wait_time(0.2)

	dot_dying_unit_seq(barbaroi2)

	wait_seq()

	dot_reserve_move_unit_seq(barbaroi5, 25, 22)
	dot_reserve_move_unit_seq(barbaroiB, 20, 21)
	
	exec_parallel_seq()

	wait_seq()

	
	-- @ウレリー	キリがない…！だめだよ！ノワールくんが喰われちゃう、逃げなきゃ──	
	change_face(Urrie, "Surprise")
	open_speech_window("CHRNAME_URRIE", Urrie, nil)
	message("MA_01104_1090021")
	close_speech_window()

	dot_disp_unit(dotDinatan,true)

	move_camera(20, 18, 2.0)
	dot_move_unit_seq(dotDinatan, 20, 14)
	wait_seq()
	wait_camera()

	-- @ディナタン	兄さん！？！？	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1090023")
	close_speech_window()

	-- @ノワール	ディナタン！？だめだ、来るなッ！！	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090024")
	close_speech_window()

	dot_move_unit_seq(barbaroiB, 19, 17)
	wait_seq()

	-- @ディナタン	え………っ	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1090026")
	close_speech_window()

	move_camera(22, 19, 1.0)

	dot_reserve_move_unit_seq(dotNoir2, 23, 20)

	dot_reserve_move_unit_seq(barbaroi1, 23, 19)
	dot_reserve_move_unit_seq(barbaroi3, 22, 20)
	dot_reserve_move_unit_seq(barbaroi4, 24, 19)
	
	exec_parallel_seq()

	wait_seq()
	dot_unit_dir(barbaroi3,3)

	wait_camera()
	
	-- @ノワール	ディナタン！！！！	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090028")
	close_speech_window()

	move_camera(18, 32, 2.0)
	wait_camera()
	
	-- @ウレリー	にげなきゃ、にげなきゃ	
	change_face(Urrie, "Sad")
	open_speech_window("CHRNAME_URRIE", Urrie, nil)
	message("MA_01104_1090029")
	close_speech_window()

	move_camera(22, 18, 1.0)
	wait_camera()
	
	dot_move_unit_seq(barbaroiB, 19, 16)
	wait_seq()

	on_active(Ef_Roar1)

	local gridpos = get_grid_position(19, 16)
	set_pos(Ef_Roar1, gridpos)
	play_particle(Ef_Roar1)

	dot_unit_dir(barbaroiB,2)
	dot_change_anim(barbaroiB,3)
		
	-- @バルバロイ	アアアアアアアアアアアアアアッッ！！	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MA_01104_1090030")
	close_speech_window()

	dot_change_anim(barbaroiB,0)

	-- @ウレリー	にげなきゃ	
	change_face(Urrie, "Sad")
	open_speech_window("CHRNAME_URRIE", Urrie, nil)
	message("MA_01104_1090031")
	close_speech_window()

	dot_place_unit(dotUrrie,17,25)

	move_camera(20, 15, 2.0)
	dot_move_unit_seq(dotUrrie, 19, 14)
	wait_seq()
	wait_camera()

	dot_unit_dir(dotUrrie,3)
	dot_change_anim(dotUrrie,3)

	wait_time(0.2)
	dot_change_anim(dotDinatan,6)
	dot_move_knockback(dotDinatan, 22, 14,0.1,2)
	wait_time(0.5)
	dot_change_anim(dotDinatan,1)

	-- @ディナタン	ウレリーさん！？	
	change_face(Dinatan, "Surprise")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message("MA_01104_1090033")
	close_speech_window()

	dot_move_unit_seq(dotUrrie, 20, 14)
	wait_seq()

	open_cutin(1,1)
	on_cutin(1,Urrie,"Anger",0)

	-- @ウレリー	こっちだッッ！！！！	
	open_speech_window("CHRNAME_URRIE", nil, nil)
	message("MA_01104_1090035")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")

	close_cutin()	

	dot_move_unit_seq(barbaroiB, 19, 15)
	wait_seq()
	dot_unit_dir(barbaroiB,2)


	fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
	wait_time(2)


	show_image("101010170", 0.0, 0.0, 0.0,true,false)
	fadein(1.5)
	wait_time(2)

	bgm_play("BGM_ADV_Painful2")
	-- @ウレリー	にげて	
	open_simple_window("CHRNAME_URRIE", nil, nil)
	message("MA_01104_1090040")
	close_simple_window()

	-- @ディナタン	ウレリーさん！！！！	
	open_simple_window("CHRNAME_DINATAN", nil, nil)
	message("MA_01104_1090041")
	close_simple_window()

	-- @ウレリー	おにいさんが、かなしむよ	
	open_simple_window("CHRNAME_URRIE", nil, nil)
	message("MA_01104_1090042")
	close_simple_window()

	-- @ノワール	ウレリー！？	
	open_simple_window("CHRNAME_NOIR", nil, nil)
	message("MA_01104_1090043")
	close_simple_window()

	-- @ウレリー	こわくないよ、ワタシこわくないから	
	open_simple_window("CHRNAME_URRIE", nil, nil)
	message("MA_01104_1090044")
	close_simple_window()

	-- @ノワール	やめろ、やめろおおおっっ！！	
	open_simple_window("CHRNAME_NOIR", nil, nil)
	message("MA_01104_1090045")
	close_simple_window()

	-- @ウレリー	………わすれないで	
	open_simple_window("CHRNAME_URRIE", nil, nil)
	message("MA_01104_1090046")

	-- @ウレリー	むりなの、わかってるだけど約束、だから、おねがい、おねがい	
	message("MA_01104_1090047")

	-- @ウレリー	わすれないで、わすれないで、やだぁっあああっ、わすれないで、わすれないで、わすれ	
	message("MA_01104_1090048")
	close_simple_window()



	fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
	wait_time(2)

	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,true)
	set_scale_image(20,20)
	fadein(1)
	wait_time(1)


	-- @ウレリー	ナい　デぇ　　うっエぁああああいやああああああああああああああああああああ	
	open_speech_window("CHRNAME_URRIE", nil, nil)
	message("MA_01104_1090051")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_LongFade")

	-- @ノワール	！？！？	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090052")
	close_speech_window()

	-- @バルバロイ	バリッ、バリッ、ゴリッ	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MA_01104_1090054")
	close_speech_window()

	-- @ウレリー	のぁア　ァる　　っあ？	
	open_speech_window("CHRNAME_URRIE", nil, nil)
	message("MA_01104_1090056")
	close_speech_window()

	-- @ノワール	あ、………ああ、あ…！？	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01104_1090057")
	close_speech_window()

	-- @@バルバロイ	ゴクン	
	open_speech_window("CHRNAME_BARBAROI", nil, nil)
	message("MA_01104_1090058")
	close_speech_window()


	Play_end(true)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_image_preload("101010170", "content_still_10101017_image", "101010170_StillImage")
	pbadv_setup_101009_Noir_preload(2,true, 16, 40,0)
	pbadv_setup_101068_Urrie_preload(0,true,15,40,0)
	pbadv_setup_101012_Dinatan_preload(0,true, 20, 7,0)
	movie_load_preload("MA_01104_109")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar01", false, true)
	preload_sound("BGM_ADV_Painful2")
end
