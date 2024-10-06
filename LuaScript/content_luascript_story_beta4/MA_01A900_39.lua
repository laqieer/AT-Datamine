
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
	pbadv_setup_101030_Elaine(1,true, 21, 24,0)  

setup_complete_unit()


	
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotGuinevere1, 3)
	dot_unit_dir(dotLucius2, 2)
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotGuinevere1, false)
	dot_disp_weapon(dotLucius2, false)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(20, 10, 0.0)
	
	
load_image("103020120", "content_still_10302012_image", "103020120_StillImage")

load_image("103020130", "content_still_10302013_image", "103020130_StillImage")

load_image("103020140", "content_still_10302014_image", "103020140_StillImage")

load_image("103020150", "content_still_10302015_image", "103020150_StillImage")

load_image("103020160", "content_still_10302016_image", "103020160_StillImage")

load_image("103020170", "content_still_10302017_image", "103020170_StillImage")

load_image("103020180", "content_still_10302018_image", "103020180_StillImage")

load_image("103030060", "content_still_10303006_image", "103030060_StillImage")

end



function Play()
	fadein(0)
	Play_start(true)
	

	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_390002")
	close_speech_window()

	
	change_face(Lucius2, "Normal")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius2)
	message("MA_01A900_390003")
	close_speech_window()

	
	change_face(Guinevere1, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2", Guinevere1, nil)
	message("MA_01A900_390004")
	close_speech_window()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")
	
	

	on_cameraframe(2)
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103020120", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
	
	
	open_simple_window("CHRNAME_GUINEVERE2")	
	message("MA_01A900_390006")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 







	
	
	


 
 


show_image("103020130", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_GUINEVERE2")	
	message("MA_01A900_390008")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	


 
 


show_image("103020140", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_ELAINE")	
	message("MA_01A900_390010")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 








	
	
	


 
 


show_image("103020150", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_ELAINE")	
	message("MA_01A900_390012")
	close_simple_window()

	
	open_simple_window("CHRNAME_GUINEVERE2")	
	message("MA_01A900_390013")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	
	


 
 	


show_image("103030060", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_ELAINE")	
	message("MA_01A900_390015")
	close_simple_window()
	
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 







	


 
 


show_image("103020160", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)


	
	open_simple_window("CHRNAME_GUINEVERE2")	
	message("MA_01A900_390017")
	close_simple_window()
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	


 
 


show_image("103020170", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN) 

	
	open_simple_window("CHRNAME_ELAINE")	
	message("MA_01A900_390019")
	close_simple_window()
	
	
	
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 


 






	
	
	
	


 
 


show_image("103020180", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)

	
	open_simple_window("CHRNAME_GUINEVERE2")
	message("MA_01A900_390021")
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
	pbadv_setup_101030_Elaine_preload(1,true, 21, 24,0)
load_image_preload("103020120", "content_still_10302012_image", "103020120_StillImage")
load_image_preload("103020130", "content_still_10302013_image", "103020130_StillImage")
load_image_preload("103020140", "content_still_10302014_image", "103020140_StillImage")
load_image_preload("103020150", "content_still_10302015_image", "103020150_StillImage")
load_image_preload("103020160", "content_still_10302016_image", "103020160_StillImage")
load_image_preload("103020170", "content_still_10302017_image", "103020170_StillImage")
load_image_preload("103020180", "content_still_10302018_image", "103020180_StillImage")
load_image_preload("103030060", "content_still_10303006_image", "103030060_StillImage")
end
