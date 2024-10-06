

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)

	
	init_psbattleadv("201150000","201150000")	
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)


	pbadv_setup_101009_Noir(2,true,20, 20,0)

	pbadv_setup_101022_Mordred(0,true, 25, 12,0)  
	pbadv_setup_101023_Clarice(0,true, 21, 20,0) 
	
	pbadv_setup_101015_Arthur(2,true,20,13,0)

	pbadv_setup_101020_Merlin(2,true, 20, 21,0)  

	pbadv_setup_101042_Moronoe(true, 9, 4,0)  

	
	
	setup_complete_unit()
	
	
	
	dot_unit_dir(dotArthur2,2)
	dot_unit_dir(dotMoronoe,2)

	dot_disp_unit(dotMoronoe,false)
	dot_disp_unit(dotMordred,false)

	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotClarice,false)
	dot_disp_weapon(dotMerlin2,false)
	dot_disp_weapon(dotArthur2,false)



	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(20,14,0.0)

	Ef_WitchPortal = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	Ef_Fog = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	Ef_fogvanish = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	Ef_C_Adv_Flash_White01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White01",false,true)

end

function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Arthur2,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	 --PlayPartVoice("アーサー", "挨拶")
	message("MA_01C900_410002")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "驚き")
	message("MA_01C900_410003")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotNoir2, 20, 15)
	dot_reserve_move_unit_seq(dotClarice, 21, 15)
	
	
	exec_parallel_seq()

	
	wait_seq()
	
	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_410005")
	close_speech_window()

	
	change_face(Clarice,"Surprise")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "驚き")
	message("MA_01C900_410006")
	close_speech_window()

	
	change_face(Arthur2,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_410007")
	close_speech_window()


	
	change_face(Clarice,"Anger")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "落胆")
	message("MA_01C900_410009")
	

	
	message("MA_01C900_410010")
	close_speech_window()


	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	 --PlayPartVoice("アーサー", "肯定3")
	message("MA_01C900_410011")
	close_speech_window()


	
	change_face(Clarice,"Sad")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "悲しみ")
	message("MA_01C900_410012")

	

	
	change_face(Clarice,"Smile")
	message("MA_01C900_410014")
	close_speech_window()

	
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01C900_410016")
	close_speech_window()


	
	

	dot_reserve_move_unit_seq(dotNoir2, 19, 15)
	dot_reserve_move_unit_seq(dotClarice, 21, 15)
	
	exec_parallel_seq()

	
	wait_seq()
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotClarice,2)
	
	dot_attack_seq(dotMerlin2,dotArthur2)
	dot_damage_seq(dotArthur2,dotMerlin2,false)
	
	wait_seq()

	

	dot_move_unit_seq(dotMerlin2, 20, 15)

	
	change_face(Merlin2,"Anger")
	open_speech_window("CHRNAME_MERLIN",Merlin2,nil)
	message("MA_01C900_410018")
	close_speech_window()


	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	 --PlayPartVoice("アーサー", "挨拶")
	message("MA_01C900_410020")
	close_speech_window()


	
	change_face(Merlin2,"Anger")
	open_speech_window("CHRNAME_MERLIN",Merlin2,nil)
	message("MA_01C900_410021")
	close_speech_window()


	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "落胆")
	message("MA_01C900_410022")
	close_speech_window()


	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	 --PlayPartVoice("アーサー", "肯定")
	message("MA_01C900_410023")


	
	message("MA_01C900_410024")
	close_speech_window()

	
	dot_disp_unit(dotMordred,true)

	dot_move_unit_seq(dotMordred, 21, 13)
	dot_attack_seq(dotMordred,dotArthur2)
	dot_damage_seq(dotArthur2,dotMordred,false)
	
	wait_seq()

	
	change_face(Mordred,"Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定2")
	message("MA_01C900_410026")
	close_speech_window()


	
	change_face(Arthur2,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	 --PlayPartVoice("アーサー", "否定")
	message("MA_01C900_410028")
	close_speech_window()

	
	dot_change_anim(dotMordred,0)
	
	
	change_face(Mordred,"Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定3")
	message("MA_01C900_410030")
	close_speech_window()
	

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_410031")
	close_speech_window()
	
	
	on_active(Ef_Fog) 

	local gridpos = get_grid_position(20, 13)
	set_pos(Ef_Fog, gridpos)
	play_particle(Ef_Fog)

	
	change_face(Mordred,"Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "激怒")
	message("MA_01C900_410033")
	close_speech_window()


	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_410034")
	close_speech_window()

	
	on_active(Ef_C_Adv_Flash_White01)
	local gridpos=get_grid_position(20,13) 
	set_pos(Ef_C_Adv_Flash_White01,gridpos)
	play_particle(Ef_C_Adv_Flash_White01)
	wait_time(0.2)

	dot_change_unit(dotArthur2,dotMoronoe,0)

	wait_time(1.0)

	
	change_face(Moronoe,"Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	 --PlayPartVoice("モーロノエー", "笑い")
	message("MA_01C900_410036")
	
	dot_disp_weapon(dotNoir2,true)
	dot_disp_weapon(dotClarice,true)
	dot_disp_weapon(dotMerlin2,true)

	
	 --PlayPartVoice("モーロノエー", "肯定2")
	message("MA_01C900_410038")

	
	change_face(Moronoe,"Normal")
	message("MA_01C900_410039")
	close_speech_window()
	
	stop_particle(Ef_Fog)
	
	
	on_active(Ef_fogvanish)

	local gridpos = get_grid_position(20, 13)
	set_pos(Ef_fogvanish, gridpos)
	play_particle(Ef_fogvanish)

	wait_time(1.0)
	dot_remove_unit(dotMoronoe)
	wait_time(2.0)

	dot_unit_dir(dotMerlin2,2)
	dot_disp_weapon(dotMordred,false)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotClarice,false)
	dot_disp_weapon(dotMerlin2,false)

	
	change_face(Merlin2,"Sad")
	open_speech_window("CHRNAME_MERLIN",Merlin2,nil)
	 --PlayPartVoice("マーリン", "悲しみ")
	message("MA_01C900_410041")


	
	message("MA_01C900_410042")
	close_speech_window()


	
	change_face(Mordred,"Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "挨拶")
	message("MA_01C900_410043")
	close_speech_window()


	
	change_face(Clarice,"Sad")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "落胆")
	message("MA_01C900_410045")
	close_speech_window()

	dot_unit_dir(dotMerlin2,3)

	
	change_face(Merlin2,"Sad")
	open_speech_window("CHRNAME_MERLIN",Merlin2,nil)
	 --PlayPartVoice("マーリン", "落胆")
	message("MA_01C900_410046")
	close_speech_window()

	
	change_face(Mordred,"Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "納得")
	message("MA_01C900_410047")
	close_speech_window()


	
	change_face(Merlin2,"Sad")
	open_speech_window("CHRNAME_MERLIN",Merlin2,nil)
	 --PlayPartVoice("マーリン", "悲しみ")
	message("MA_01C900_410048")
	close_speech_window()

	
	change_face(Clarice,"Sad")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "悩む")
	message("MA_01C900_410049")
	close_speech_window()


	
	change_face(Mordred,"Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定2")
	message("MA_01C900_410050")
	close_speech_window()
	

	
	change_face(Clarice,"Anger")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "激怒")
	message("MA_01C900_410051")
	close_speech_window()
	
	dot_unit_dir(dotMerlin2,2)

	
	change_face(Merlin2,"Sad")
	open_speech_window("CHRNAME_MERLIN",Merlin2,nil)
	message("MA_01C900_410053")


	
	change_face(Merlin2,"Sad")
	 --PlayPartVoice("マーリン", "落胆")
	message("MA_01C900_410054")
	

	
	message("MA_01C900_410055")

	
	message("MA_01C900_410056")

	
	message("MA_01C900_410057")

	
	change_face(Merlin2,"Anger")
	message("MA_01C900_410058")
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,20, 20,0)
	pbadv_setup_101022_Mordred_preload(0,true, 25, 12,0)
	pbadv_setup_101023_Clarice_preload(0,true, 21, 20,0)
	pbadv_setup_101015_Arthur_preload(2,true,20,13,0)
	pbadv_setup_101020_Merlin_preload(2,true, 20, 21,0)
	pbadv_setup_101042_Moronoe_preload(true, 9, 4,0)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog_vanish", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White01",false,true)
end
