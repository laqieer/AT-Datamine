Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")


function Load()
	Load_common(true)
	
	
	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	

	
	
	init_psbattleadv("201150100","201150100")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)
	
	pbadv_setup_101051_Lucius(2,true,20,8,0)
	
	pbadv_setup_101011_Guinevere(1,true,19,20,0)
	
	pbadv_setup_101009_Noir(2,true,20,20,0)
	
	
	dotArthur_D=dot_reserve_ally(201021001,19,4,0)
	dot_set_weapon(dotArthur_D,101010001)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotLucius2,2)
	dot_unit_dir(dotArthur_D,2)

	
	

	
	
	dot_disp_unit(dotArthur_D,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(28.0,0.0)

	
	
	move_camera(20,9,0.0)
	
	
	Ef_Aura_Enemy_spout=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_spout",false,true)
	Ef_Aura_Enemy_Lop=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
	Ef_DimensionHole=load_particle("content_effect3d_common_adv","Ef_C_Adv_DimensionHole",false,true)
	Ef_Flash01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Roar01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	Ef_WhiteDragon_A=load_particle("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Appearance",false,true)
	Ef_WhiteDragon_Flash=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	
	movie_load("MA_01A900_36")
	
end





function Play()
	fadein(0)
	Play_start(true)

	dot_move_height(dotArthur_D,2.0,0.5,2)


	

	

	

	
	dot_reserve_move_unit_seq(dotNoir2,20,10)
	dot_reserve_move_unit_seq(dotGuinevere1,19,10)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotGuinevere1,3)

	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360002")

	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360003")

	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360004")

	
	change_face(Lucius2, "Smile")
	message("MA_01A900_360005")

	
	change_face(Lucius2, "Normal")
	message("MA_01A900_360006")
	

	
	
	
	MA_01A900_36_select1()

	open_select_window_tag(Noir2,"Normal","MA_01A900_360008","MA_01A900_360009")
	close_speech_window()
	
	if is_select(1) then			
		MA_01A900_36_select1_1()
	
	else		
		MA_01A900_36_select1_2()
	
	end
	MA_01A900_36_end()
	
	end
	
	function MA_01A900_36_select1()
	
	end
	
	function MA_01A900_36_select1_1()


	
	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_360011")
	close_speech_window()

	
	change_face(Lucius2,"Smile")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360012")

	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360013")

	
	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360019")

	
	change_face(Lucius2,"Smile")
	message("MA_01A900_360020")
	close_speech_window()
	
end
 
 
function MA_01A900_36_select1_2()

	
	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_360015")
	close_speech_window()

	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360016")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_360017")
	close_speech_window()

	
	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360019")

	
	change_face(Lucius2,"Smile")
	message("MA_01A900_360020")
	close_speech_window()

	
end
 
 
function MA_01A900_36_end()

	
	on_active(Ef_Aura_Enemy_spout)
	local gridpos=get_grid_position(20,8)
	set_pos(Ef_Aura_Enemy_spout,gridpos)
	play_particle(Ef_Aura_Enemy_spout)
	wait_time(1.0)
	on_active(Ef_Aura_Enemy_Lop)
	local gridpos=get_grid_position(20,8)
	set_pos(Ef_Aura_Enemy_Lop,gridpos)
	play_particle(Ef_Aura_Enemy_Lop)
	
	
	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_360022")
	close_speech_window()

	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360023")
	close_speech_window()

	
	change_face(Guinevere1,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_360024")
	close_speech_window()

	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360025")
	close_speech_window()

	close_textbox_base()
	disableTextBox = true
	
	move_camera(20,4,1.0)
	change_camera_distance(10.0,1.0)
	wait_time(0.8)

	on_active(Ef_DimensionHole)
	local gridpos=get_grid_position(20,5)
	gridpos[2]=3.0
	set_pos(Ef_DimensionHole,gridpos)
	set_scale(Ef_DimensionHole,{1.5,1.5,1.5})
	play_particle(Ef_DimensionHole)
	wait_time(1.5)
	
	
	on_active(Ef_WhiteDragon_A)
	local gridpos=get_grid_position(20,5)
	gridpos[2]=3.0
	set_pos(Ef_WhiteDragon_A,gridpos)
	play_particle(Ef_WhiteDragon_A)	
	
	wait_time(1.5)
	
	on_active(Ef_WhiteDragon_Flash)
	local gridpos=get_grid_position(20,5)
	gridpos[2]=3.0
	set_pos(Ef_WhiteDragon_Flash,gridpos)
	play_particle(Ef_WhiteDragon_Flash)	
	
	wait_time(0.2)
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)

	
	wait_time(BLACK_WHITE_WAIT_TIME)
	
	
	
	movie_set_active(true)
	
	fadein(0)
	Play_start(true)
	
	movie_play()
	hide_image(STILL_SWITCH_TIME) 
	
	
	movie_wait_playing()
	movie_stop()
	
	dot_disp_unit(dotArthur_D, true)
	
	stop_particle(Ef_DimensionHole)
	stop_particle(Ef_WhiteDragon_A)
	stop_particle(Ef_WhiteDragon_Flash)
	move_camera(20,4,0.0)
	wait_time(MOVIE_AFTER)
	
	
	wait_time(0.5)

	move_camera(20,8,1.0)
	
	wait_time(2.0)

	disableTextBox = false
	open_textbox_base()

	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_360027")
	close_speech_window()

	
	change_face(Guinevere1,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_360028")
	close_speech_window()

	
	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360030")

	
	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360032")

	
	change_face(Lucius2,"Smile")
	message("MA_01A900_360034")
	close_speech_window()

	
	on_active(Ef_Flash01)
	local gridpos=get_grid_position(19,10)
	set_pos(Ef_Flash01,gridpos)
	play_particle(Ef_Flash01)
	
	dot_change_anim(dotArthur_D,3)
	dot_unit_dir(dotArthur_D,1)
	
	se_play("SE_ADV_MA_01A900_36_WhiteDrg_Roar")
	
	on_active(Ef_Roar01)
	local gridpos=get_grid_position(20,5)
	set_pos(Ef_Roar01,gridpos)
	play_particle(Ef_Roar01)
	wait_time(0.5)
	
	
	change_face(Guinevere1,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_360036")
	close_speech_window()

	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360037")
	close_speech_window()

	

	dot_unit_dir(dotArthur_D,2)
	dot_change_anim(dotArthur_D,0)

	
	change_face(Guinevere1,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_360038")
	close_speech_window()

	
	change_face(Lucius2,"Smile")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360039")

	
	
	change_face(Lucius2,"Smile")
	message("MA_01A900_360041")

	
	change_face(Lucius2,"Smile")
	message("MA_01A900_360042")

	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360043")

	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360044")

	
	
	
	MA_01A900_36_select2()
	
	open_select_window_tag(Noir2,"Normal","MA_01A900_360046","MA_01A900_360047")
	
	close_speech_window()
	
	if is_select(1) then		
		MA_01A900_36_select2_1()
	
	else		
		MA_01A900_36_select2_2()
	
	end
	MA_01A900_36_2_end()
	
	end
	
	function MA_01A900_36_select2()
	
	end
	
	function MA_01A900_36_select2_1()
	
	
	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_360049")
	close_speech_window()

	
	change_face(Lucius2,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360050")

	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360051")

	
	change_face(Lucius2,"Normal")
	message("MA_01A900_360052")
	close_speech_window()
	
end
 
 
function MA_01A900_36_select2_2()

	
	
	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_360054")
	close_speech_window()

	
	change_face(Lucius2,"Smile")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius2)
	message("MA_01A900_360055")
	
	change_face(Guinevere1,"Smile")
	message("MA_01A900_360056")
	close_speech_window()
	
end
 
 
function MA_01A900_36_2_end()

	



	wait_time(0.2)


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	pbadv_setup_101051_Lucius_preload(2,true,20,8,0)
	pbadv_setup_101011_Guinevere_preload(1,true,19,20,0)
	pbadv_setup_101009_Noir_preload(2,true,20,20,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_spout",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_DimensionHole",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Appearance",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	movie_load_preload("MA_01A900_36")
end
