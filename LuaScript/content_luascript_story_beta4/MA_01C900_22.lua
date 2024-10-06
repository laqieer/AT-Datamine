

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201170000","201170000")	
change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)


	pbadv_setup_101009_Noir(2,true,36,35,0)
	
	pbadv_setup_101012_Dinatan(0,true,35,35,0)
	
	pbadv_setup_101051_Lucius(0,true,37,36,0)
	
	pbadv_setup_101022_Mordred(0,true,38,36,0)
	
	pbadv_setup_101015_Arthur(2,true,36,33,0)
	
	pbadv_setup_101042_Moronoe(true,17,3,0)
	
	pbadv_setup_101044_Gliten(true,39,4,0)	
	
	pbadv_setup_101045_Glitonea(true,6,24,0)	
	
	pbadv_setup_101046_Gliton(true,21,40,0)	
	
	
	setup_complete_unit()
	

	dot_unit_dir(dotArthur2,2)
	dot_unit_dir(dotMoronoe,2)
	dot_unit_dir(dotGliten,2)
	dot_unit_dir(dotGlitonea,2)
	dot_unit_dir(dotGliton,2)
	
	
	dot_disp_unit(dotMoronoe,false)
	dot_disp_unit(dotGliten,false)
	dot_disp_unit(dotGlitonea,false)
	dot_disp_unit(dotGliton,false)
	
	
	dot_disp_unit(dotMoronoe,false)
	dot_disp_unit(dotGliten,false)
	dot_disp_unit(dotGlitonea,false)
	dot_disp_unit(dotGliton,false)
	
	
	
	change_camera_distance(8.0,0.0)
	
	
	change_camera_angle(25.0,0.0)
	
	
	move_camera(36,35,0.0)
	
	
	Ef_Portal_W=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	Ef_Portal_W2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	Ef_Portal_W3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	Ef_Portal_W4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	Ef_Portal_W5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)

	Ef_BlackFeather=load_particle("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)

	load_image("10204004",  "content_still_10204004_image", "102040040_StillImage")

	load_image("101010141", "content_still_10101014_image", "101010140_StillImage")

	show_image("101010141", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)

end

function Play()
	fadein(0)
	Play_start(true)
	
	wait_time(0.5)

	open_narration_window()
	message("MA_01C900_221001")
	message("MA_01C900_221002")
	message("MA_01C900_221003")
	message("MA_01C900_221004")
	message("MA_01C900_221005")
	close_narration_window()	
	
	fadeout(0,0,0,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)	

	show_image("10204004", 0.0, 0.0, 0 ,true,false)
	
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN) 	

	wait_time(MAP_TIME_ACTIVE)
	hide_image(MAP_TIME_END) 
	wait_time(MAP_TIME_END + MAP_TIME_END_AFTER)

	
	change_face(Arthur2,"Surprise")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220002")

	
	change_face(Arthur2,"Sad")
	message("MA_01C900_220003")

	
	change_face(Arthur2,"Normal")
	message("MA_01C900_220004")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_220005")
	close_speech_window()

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220006")

	
	change_face(Arthur2,"Smile")
	message("MA_01C900_220007")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_220008")
	close_speech_window()

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220009")
	close_speech_window()

	
	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_220010")
	close_speech_window()

	
	change_face(Arthur2,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220011")

	
	change_face(Arthur2,"Normal")
	message("MA_01C900_220012")
	close_speech_window()

	
	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_220013")
	close_speech_window()

	
	change_face(Arthur2,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220014")

	
	change_face(Arthur2,"Sad")
	message("MA_01C900_220015")

	
	change_face(Arthur2,"Sad")
	message("MA_01C900_220016")

	
	change_face(Arthur2,"Anger")	
	message("MA_01C900_220017")

	
	
	change_face(Arthur2,"Anger")
	message("MA_01C900_220018")

	
	change_face(Arthur2,"Anger")
	message("MA_01C900_220020")

	
	
	change_face(Arthur2,"Anger")
	message("MA_01C900_220021")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_220023")
	close_speech_window()

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220024")

	
	change_face(Arthur2,"Smile")
	message("MA_01C900_220026")

	
	change_face(Arthur2,"Smile")
	message("MA_01C900_220027")

	
	change_face(Arthur2,"Smile")
	message("MA_01C900_220028")

	
	change_face(Arthur2,"Smile")
	message("MA_01C900_220029")

	
	change_face(Arthur2,"Serious")
	message("MA_01C900_220030")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_220032")
	close_speech_window()

	
	change_face(Arthur2,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220034")
	close_speech_window()

	
	change_face(Dinatan,"Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_220035")
	close_speech_window()

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220036")

	
	change_face(Arthur2,"Sad")
	message("MA_01C900_220037")

	
	change_face(Arthur2,"Anger")
	message("MA_01C900_220038")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_220039")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Arthur2,"Serious",0)
	
	change_face(Arthur2,"Serious")
	open_speech_window("CHRNAME_ARTHUR",nil,nil)
	message("MA_01C900_220040")
	close_speech_window()
	
	close_cutin()	
	wait_time(0.3)
	dot_move_unit_seq(dotArthur2,36,30)
	wait_seq()
	
	local gridpos=get_grid_position(36,30) 
	on_active(Ef_Portal_W)
	set_pos(Ef_Portal_W,gridpos)
	play_particle(Ef_Portal_W)
	wait_time(1.0)
	dot_disp_unit(dotArthur2,false)
	wait_time(2.0)

	
	move_camera(17,3,1.5)
	wait_camera()

	on_active(Ef_Portal_W2)
	local gridpos=get_grid_position(17,3)
	set_pos(Ef_Portal_W2,gridpos)
	set_scale(Ef_Portal_W2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Portal_W2)

	on_active(Ef_BlackFeather)
	local gridpos=get_grid_position(17,3)
	set_pos(Ef_BlackFeather,gridpos)
	play_particle(Ef_BlackFeather)
	
	wait_time(0.5)
	
	dot_disp_unit(dotMoronoe,true)
	
	wait_time(0.8)
	move_camera(39,4,1.5)
	wait_camera()
	
	on_active(Ef_Portal_W3)
	local gridpos=get_grid_position(39,4)
	set_pos(Ef_Portal_W3,gridpos)
	set_scale(Ef_Portal_W3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Portal_W3)
	
	local gridpos=get_grid_position(39,4)
	set_pos(Ef_BlackFeather,gridpos)
	play_particle(Ef_BlackFeather)
	
	wait_time(0.5)
	
	dot_disp_unit(dotGliten,true)
	wait_time(0.8)
	
	move_camera(6,24,1.5)
	wait_camera()
	

	on_active(Ef_Portal_W4)
	local gridpos=get_grid_position(6,24)
	set_pos(Ef_Portal_W4,gridpos)
	set_scale(Ef_Portal_W4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Portal_W4)
	
	local gridpos=get_grid_position(6,24)
	set_pos(Ef_BlackFeather,gridpos)
	play_particle(Ef_BlackFeather)
	
	wait_time(0.5)
	
	dot_disp_unit(dotGlitonea,true)
	wait_time(0.8)
	

	
	move_camera(21,40,1.5)
	wait_camera()
	
	on_active(Ef_Portal_W5)
	local gridpos=get_grid_position(21,40)
	set_pos(Ef_Portal_W5,gridpos)
	set_scale(Ef_Portal_W5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_Portal_W5)
	
	local gridpos=get_grid_position(21,40)
	set_pos(Ef_BlackFeather,gridpos)
	play_particle(Ef_BlackFeather)
	
	wait_time(0.5)
	
	dot_disp_unit(dotGliton,true)
	wait_time(0.8)
	
	
	
	dot_disp_unit(dotArthur2,true)
	move_camera(6,3,0.0)
	wait_camera()

    dot_place_unit(dotArthur2,6,6)
	dot_move_unit_seq(dotArthur2,6,3)
	wait_seq()
	
	
	change_face(Arthur2,"Serious")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_220042")

	
	change_face(Arthur2,"Serious")
	message("MA_01C900_220043")
	close_speech_window()



	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,36,35,0)
	pbadv_setup_101012_Dinatan_preload(0,true,35,35,0)
	pbadv_setup_101051_Lucius_preload(0,true,37,36,0)
	pbadv_setup_101022_Mordred_preload(0,true,38,36,0)
	pbadv_setup_101015_Arthur_preload(2,true,36,33,0)
	pbadv_setup_101042_Moronoe_preload(true,17,3,0)
	pbadv_setup_101044_Gliten_preload(true,39,4,0)
	pbadv_setup_101045_Glitonea_preload(true,6,24,0)
	pbadv_setup_101046_Gliton_preload(true,21,40,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	load_image_preload("10204004",  "content_still_10204004_image", "102040040_StillImage")
	load_image_preload("101010141", "content_still_10101014_image", "101010140_StillImage")
end
