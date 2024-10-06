

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	init_psbattleadv("201020000", "201020000")
	change_time_and_weather(1,1) 
	
	
    pbadv_setup_101009_Noir(2,true,14,19,0)
    pbadv_setup_101012_Dinatan(1,true,13,20,0)
	pbadv_setup_101052_Vernarth(0,true,26,24,0)
	pbadv_setup_101037_Rasia(0,true,16,19,0)
	pbadv_setup_101039_Fren(0,true,15,20,0)
	
	
	barubaroi1 = dot_reserve_enemy(1100, 25, 23, 0)
	barubaroi2 = dot_reserve_enemy(1100, 24, 24, 0)
	barubaroi3 = dot_reserve_enemy(49, 25, 25, 0)
	barubaroi4 = dot_reserve_enemy(1100, 27, 23, 0)
	barubaroi5 = dot_reserve_enemy(49, 28, 24, 0)
	barubaroi6 = dot_reserve_enemy(49, 27, 25, 0)
	
	
	
	dotroma1 = dot_reserve_ally(401039001, 24, 22, 0)
	dot_set_weapon(dotroma1, 101010005)		
	dotroma2 = dot_reserve_ally(401039001, 28, 26, 0)
	dot_set_weapon(dotroma2, 101010005)		
	
	setup_complete_unit()
	
	
	dot_disp_weapon(dotNoir2, false)
	dot_disp_weapon(dotDinatan1, false)
	dot_disp_weapon(dotRasia, false)
	dot_disp_weapon(dotFren, false)

	
	dot_unit_dir(dotVernarth, 2)
	dot_unit_dir(dotNoir2, 3)
	dot_unit_dir(dotDinatan1, 3)
	dot_unit_dir(dotRasia, 3)
	dot_unit_dir(dotFren, 3)
	dot_unit_dir(barubaroi1, 3)
	dot_unit_dir(barubaroi2, 3)
	dot_unit_dir(barubaroi3, 3)
	dot_unit_dir(barubaroi4, 2)	
	dot_unit_dir(barubaroi5, 2)
	dot_unit_dir(barubaroi6, 2)	
	dot_unit_dir(dotroma2, 2)	

	
	dot_change_anim(dotroma1, 1)
	dot_change_anim(dotroma2, 1)
	dot_change_anim(dotVernarth, 1)

	
	change_camera_distance(8.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(14, 20, 0.0)

end


function Play()
	fadein(0)
	Play_start(true)
	
	change_face(Fren, "Surprise") 
	open_speech_window("CHRNAME_FREN",Fren, nil)
	message("MA_01C111_320002")
	close_speech_window()

	
	change_face(Rasia, "Anger") 
	open_speech_window("CHRNAME_RASIA",Rasia, nil)
	message("MA_01C111_320003")
	close_speech_window()

	
	move_camera(26, 24, 0.9)
	wait_camera()
	
	wait_time(0.3)	

	
	change_face(Vernarth, "Surprise") 
	open_speech_window("CHRNAME_VERNARTH",Vernarth , nil)
	message("MA_01C111_320005")
	close_speech_window()

	
	move_camera(14, 20, 0.9)
	wait_camera()

	
	change_face(Fren, "Anger") 	
	open_speech_window("CHRNAME_FREN",Fren, nil)
	message("MA_01C111_320006")
	close_speech_window()




	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,14,19,0)
    pbadv_setup_101012_Dinatan_preload(1,true,13,20,0)
	pbadv_setup_101052_Vernarth_preload(0,true,26,24,0)
	pbadv_setup_101037_Rasia_preload(0,true,16,19,0)
	pbadv_setup_101039_Fren_preload(0,true,15,20,0)
end
