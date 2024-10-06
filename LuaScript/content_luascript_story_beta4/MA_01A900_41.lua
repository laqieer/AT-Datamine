
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
	
	
	init_psbattleadv("201150100", "201150100")
	
	
	change_time_and_weather(4, 4)

	
	pbadv_setup_101009_Noir(2,true, 19, 10,0)  
	pbadv_setup_101011_Guinevere(1,true, 19, 9,0)  
	pbadv_setup_101051_Lucius(2,true, 21, 9,0)  
	pbadv_setup_101021_Bruno(0,true, 0, 0,0)  
	pbadv_setup_101050_Brian(0,true, 1, 1,0)  


setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotGuinevere1, 3)
	dot_unit_dir(dotLucius2, 2)
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere1, false)
	dot_disp_weapon(dotLucius2, false)
	
	
	dot_disp_unit(dotBruno, false)
	dot_disp_unit(dotBrian, false)
	
	
	Ef_Gine = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(20, 10, 0.0)
	
	
load_image("103010260", "content_still_10301026_image", "103010260_StillImage")

	
load_image("103020190", "content_still_10302019_image", "103020190_StillImage")

load_image("101010150", "content_still_10101015_image", "101010150_StillImage")

load_image("101010270", "content_still_10101027_image", "101010270_StillImage")




end


function Play()
	fadein(0)
	Play_start(true)
	
	
	on_active(Ef_Gine) 
	local locatorpos = dot_get_unit_locator(dotGuinevere1,1)
	set_pos(Ef_Gine, locatorpos)
	
	
	wait_time(0.5)
	

	
	change_face(Guinevere1, "Sad")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_410002")
	
	change_face(Guinevere1, "Normal")
	message("MA_01A900_410003")
	
	change_face(Guinevere1, "Normal")
	message("MA_01A900_410004")
	
	
	change_face(Guinevere1, "Smile")
	message("MA_01A900_410006")
	close_speech_window()

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_410007")
	close_speech_window()

	
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01A900_410008")
	close_speech_window()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	

	

	on_cameraframe(2)
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103020190", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
	
	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	open_simple_window("CHRNAME_BRUNO2")	
	message("MA_01A900_410010")
	close_simple_window()
	
	

	
	open_simple_window("CHRNAME_NOIR")	
	message("MA_01A900_410012")
	close_simple_window()

	

fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  
on_cameraframe(2) 
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("101010270", 0.0, 0.0, 0.0) 
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)	
	
	

	
	open_simple_window("NPCNAME_0163")	
	message("MA_01A900_410014")
	close_simple_window()
	
	

	
	open_simple_window("CHRNAME_NOIR")	
	message("MA_01A900_410016")
	close_simple_window()
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)


show_image("103010260", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_BRIAN")	
	message("MA_01A900_410018")
	close_simple_window()

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 

hide_image()
 

off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
	
	
	off_cameraframe()
	

open_cutin(1,1)

on_cutin(1,Noir2,"Serious") 


	
	bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	open_speech_window("CHRNAME_NOIR", nil, nil)
	message("MA_01A900_410020")
	close_speech_window()


close_cutin()


	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true, 19, 10,0)
	pbadv_setup_101011_Guinevere_preload(1,true, 19, 9,0)
	pbadv_setup_101051_Lucius_preload(2,true, 21, 9,0)
	pbadv_setup_101021_Bruno_preload(0,true, 0, 0,0)
	pbadv_setup_101050_Brian_preload(0,true, 1, 1,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false, true)
load_image_preload("103010260", "content_still_10301026_image", "103010260_StillImage")
load_image_preload("103020190", "content_still_10302019_image", "103020190_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010270", "content_still_10101027_image", "101010270_StillImage")
end
