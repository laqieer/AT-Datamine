

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	init_psbattleadv("201170000","201170000")	
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)



	pbadv_setup_101009_Noir(2,true,6,9,0)
	
	pbadv_setup_101012_Dinatan(0,true,5,9,0)
	
	pbadv_setup_101012_Dinatan(1,true,5,41,0)
	
	pbadv_setup_101011_Guinevere(1,true,5,6,0)
	
	pbadv_setup_101010_Lancelot(1,true,7,6,0)
	
	pbadv_setup_101015_Arthur(1,true,6,5,0)

	dotArthur_D=dot_reserve_ally(201021001,5,2,0)
	dot_set_weapon(dotArthur_D,101010001)
	
	
	
	
	setup_complete_unit()


	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")

	
	
	dot_unit_dir(dotGuinevere1,2)
	dot_unit_dir(dotLancelot1,2)
	dot_unit_dir(dotArthur1,2)
	dot_unit_dir(dotArthur_D,2)

	
	dot_disp_weapon(dotGuinevere1,false)
	dot_disp_weapon(dotLancelot1,false)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotDinatan,false)
	dot_disp_weapon(dotArthur1,false)
	
	
	
	dot_disp_unit(dotGuinevere1,false)
	dot_disp_unit(dotLancelot1,false)
	dot_disp_unit(dotArthur1,false)
	dot_disp_unit(dotArthur_D,false)


	dot_change_anim(dotNoir2,1)
	dot_change_anim(dotDinatan,1)
	
	
	
	change_camera_distance(8.0,0.0)
	
	
	change_camera_angle(25.0,0.0)
	
	
	move_camera(6,8,0.0)
	
	show_image("101010140", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

	Ef_Shockwave02=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true)
	Ef_Killers=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	Ef_Vibes = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true) 

	Ef_Emblem1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true) 
	Ef_Emblem2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true) 

	Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
	Ef_spout = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	Ef_spout2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)

	Ef_Flash = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)

	load_sound("BGM_Battle_IllusionWar_Start")

end





function Play()
	fadein(0)
	Play_start(true)

	

	
	open_narration_window()
	message("MA_01C900_250001")

	
	
	message("MA_01C900_250002")

	
	
	message("MA_01C900_250003")

	
	
	message("MA_01C900_250004")
	close_narration_window()


	open_cutin(1,1)
	on_cutin(1,Lancelot1,"Sad",0)

	
	

	
	dot_disp_unit(dotLancelot1,true)
	
	
	open_speech_window("CHRNAME_LANCELOT",nil,nil)
	message("MA_01C900_250006")
	close_speech_window()

	close_cutin()

	open_cutin(2,1)
	on_cutin(1,Guinevere1,"Sad",0)
	on_cutin(2,Lancelot1,"Sad",0)

	
	dot_disp_unit(dotGuinevere1,true)
	
	
	open_speech_window("CHRNAME_GUINEVERE",nil,nil)
	message("MA_01C900_250008")
	close_speech_window()

	close_cutin()

	
	

	fadeout(255,255,255,1.0, FADE_TIME)

	wait_time(FADE_TIME)
	dot_change_anim(dotDinatan,0)

	wait_time(0.5)
	
	fadein(FADE_TIME)

	wait_time(FADE_TIME)

	



	dot_place_unit(dotDinatan,6,7)

	
	hide_image(BLACK_WHITE_TIME)
	
	
	
	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_250011")

	bgm_play("BGM_ADV_Revenge")
	
	change_face(Dinatan,"Normal")
	message("MA_01C900_250012")
	close_speech_window()

	
	wait_time(0.5)

	on_active(Ef_Emblem1)
	on_active(Ef_Emblem2)

	local locatorpos = dot_get_unit_locator(dotDinatan,1)
	set_pos(Ef_Emblem1, locatorpos)

	play_particle(Ef_Emblem1)

	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_Emblem2, locatorpos)

	play_particle(Ef_Emblem2)

	wait_time(2.0)
	
	on_active(Ef_Killers)
	on_active(Ef_Vibes)

	local gridpos = get_grid_position(6, 7)
	set_pos(Ef_Killers, gridpos)
	play_particle(Ef_Killers)

	local gridpos = get_grid_position(6, 9)
	set_pos(Ef_Vibes, gridpos)
	play_particle(Ef_Vibes)

	wait_time(1.5)

	on_active(Ef_KillChan1)

	local gridpos = get_grid_position(6, 7)
	set_pos(Ef_KillChan1, gridpos)
	play_particle(Ef_KillChan1)

	wait_time(0.7)
	
	dot_change_unit(dotDinatan,dotDinatan1,0.0)

	wait_time(1.5)

	stop_particle(Ef_Vibes)
	stop_particle(Ef_Killers)

	wait_time(2.5)
	
	
	change_face(Guinevere1,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere1,nil)
	message("MA_01C900_250014")

	
	change_face(Guinevere1,"Smile")
	message("MA_01C900_250015")
	close_speech_window()

	
	change_face(Lancelot1,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot1,nil)
	message("MA_01C900_250016")

	
	change_face(Lancelot1,"Smile")
	message("MA_01C900_250017")
	close_speech_window()

	fadeout(0,0,0,1.0, FADE_TIME)

	wait_time(FADE_TIME)

	
	
	dot_disp_unit(dotArthur1,true)
	dot_disp_unit(dotArthur_D,true)
	move_camera(6,7,0.8)
	
	
	dot_remove_unit(dotGuinevere1)
	
	dot_remove_unit(dotLancelot1)
	
	fadein(FADE_TIME)

	wait_time(FADE_TIME)


	
	change_face(Arthur1,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250019")
	close_speech_window()

	
	change_face(Dinatan1,"Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_250020")
	close_speech_window()

	
	change_face(Arthur1,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250021")
	close_speech_window()

	
	change_face(Dinatan1,"Normal")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_250022")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_250023")
	close_speech_window()

	
	
	change_face(Arthur1,"Anger")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250024")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_250026")
	close_speech_window()

	
	change_face(Arthur1,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250027")

	
	message("MA_01C900_250028")
	close_speech_window()

	
	change_face(Dinatan1,"Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_250029")
	close_speech_window()

	
	change_face(Arthur1,"Anger")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250031")
	close_speech_window()

	move_camera(6,5,1.0)
	wait_camera()

	
	local gridpos = get_grid_position(6, 5)
	set_pos(Ef_spout, gridpos)

	on_active(Ef_spout)
	play_particle(Ef_spout)

	wait_time(1.5)

	gridpos[2] = 2.8

	slidemove(Ef_spout, gridpos, 0.8)
	dot_move_height(dotArthur1,3,0.8,2)
	wait_time(1.8)


	local gridpos = get_grid_position(6, 2)
	set_pos(Ef_Flash, gridpos)
	

	on_active(Ef_Flash)
	
	play_particle(Ef_Flash)

	

	stop_particle(Ef_spout)

	wait_time(0.5)

	dot_remove_unit(dotArthur1)

	local gridpos = get_grid_position(6, 4)
	set_pos(Ef_spout2, gridpos)

	on_active(Ef_spout2)
	play_particle(Ef_spout2)
	set_scale(Ef_spout2, {1.5, 1.5, 1.5})
	wait_time(2)

	move_camera(6,8,1.0)
	wait_camera()

	

	
	
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_250033")

	
	change_face(Noir2,"Normal")
	message("MA_01C900_250034")
	close_speech_window()
	
	
	
	
	
	
	
	change_face(Arthur1,"Normal")	
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250035")
	close_speech_window()

	
	
	
	
	
	change_face(Noir2,"Sad")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_250036")

	
	
	
	change_face(Noir2,"Pain")
	message("MA_01C900_250037")
	close_speech_window()

	
	
	
	change_face(Dinatan1,"Pain")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_250039")
	close_speech_window()

	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_250040")
	close_speech_window()

	
	change_face(Arthur1,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250041")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_250042")

	
	change_face(Noir2,"Normal")
	message("MA_01C900_250043")

	
	dot_disp_weapon(dotNoir2,true)

	dot_change_anim(dotNoir2,12)

	wait_time(0.3)
	
	
	change_face(Noir2,"Normal")
	message("MA_01C900_250045")

	
	
	
	change_face(Noir2,"Serious")
	message("MA_01C900_250047")
	close_speech_window()

	
	
	
	
	
	
	
	
	change_face(Arthur1,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250049")

	
	change_face(Arthur1,"Anger")
	message("MA_01C900_250051")
	close_speech_window()

	
	change_face(Dinatan1,"Pain")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_250052")
	close_speech_window()

	
	change_face(Arthur1,"Anger")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250053")

	bgm_play("BGM_Battle_IllusionWar_Start")

	
	
	
	change_face(Arthur1,"Anger")
	message("MA_01C900_250055")
	close_speech_window()

	
	on_active(Ef_Shockwave02)
	
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	wait_time(0.2)
	local gridpos=get_grid_position(6,4)
	set_pos(Ef_Shockwave02,gridpos)
	play_particle(Ef_Shockwave02)
	
	dot_move_unit_seq(dotDinatan1,6,6)
	
	
	change_face(Dinatan1,"Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_250057")
	close_speech_window()
	
	wait_seq()
	
	
	change_face(Arthur1,"Pain")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_250058")
	close_speech_window()

	
	change_face(Dinatan1,"Normal")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_250059")
	close_speech_window()

	
	open_cutin(1,1)
	on_cutin(1,Dinatan1,"Smile",0)
	
	
	open_speech_window("CHRNAME_DINATAN2",nil,nil)
	message("MA_01C900_250061")
	close_speech_window()

	wait_time(0.5)
	close_cutin()

	wait_time(0.5)


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,6,9,0)
	pbadv_setup_101012_Dinatan_preload(0,true,5,9,0)
	pbadv_setup_101012_Dinatan_preload(1,true,5,41,0)
	pbadv_setup_101011_Guinevere_preload(1,true,5,6,0)
	pbadv_setup_101010_Lancelot_preload(1,true,7,6,0)
	pbadv_setup_101015_Arthur_preload(1,true,6,5,0)
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave02",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Flash_White03", false, true)
	preload_sound("BGM_Battle_IllusionWar_Start")
end
