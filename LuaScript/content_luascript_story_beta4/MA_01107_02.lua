
Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	
	
	init_psbattleadv("201130000","201130000")
	change_time_and_weather(2,1)
	
	pbadv_setup_101021_Bruno(2,true,21,22,0)  
	
	pbadv_setup_101050_Brian(0,true,23,22,0)  
	
	
	
	
	
	
	setup_complete_unit()
	
	
	dot_unit_dir(dotBrian,2)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(22,22,0.0)
	
	on_cameraframe(1)
	
	
	
end





function Play()
	fadein(0)
	Play_start(true)
	

	
	

	wait_time(1.0)
	dot_move_unit_seq(dotBrian,22,22) 
	wait_seq()
	
	dot_unit_dir(dotBrian,2)
	
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	
	
	
	
	dot_dodge_seq(dotBruno2)
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	
	
	
	wait_time(0.3)
	
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	
	
	
	dot_dodge_seq(dotBruno2)
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	
	wait_time(0.2)

	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBruno2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	
	wait_time(0.1)
	
	move_camera(21,8,6.5)
	
	dot_move_unit_seq(dotBruno2,21,20) 
	wait_seq()
	
	dot_reserve_move_unit_seq(dotBruno2,21,18) 
	dot_reserve_move_unit_seq(dotBrian,22,20) 
	exec_parallel_seq()
	wait_seq()
	
	dot_change_anim(dotBrian,2)
	
	dot_reserve_move_unit_seq(dotBruno2,22,18) 
	dot_reserve_move_unit_seq(dotBrian,22,19) 
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotBruno2,3)
	dot_unit_dir(dotBrian,0)
	
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	
	
	
	dot_dodge_seq(dotBruno2)
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	
	wait_time(1.2)
	
	dot_move_unit_seq(dotBruno2,21,18) 
	wait_seq()
	
	dot_reserve_move_unit_seq(dotBruno2,21,15) 
	dot_reserve_move_unit_seq(dotBrian,22,15) 
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotBrian,2)
	dot_unit_dir(dotBruno2,3)
	
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBruno2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	wait_time(0.2)
	
	dot_move_unit_seq(dotBruno2,21,13) 
	wait_seq()
	
	dot_reserve_move_unit_seq(dotBruno2,21,10) 
	dot_reserve_move_unit_seq(dotBrian,22,10) 
	exec_parallel_seq()
	wait_seq()
	
	dot_unit_dir(dotBrian,2)
	dot_unit_dir(dotBruno2,3)
	
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBruno2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	
	
	
	
	wait_time(0.5)
	wait_seq()

	dot_reserve_move_unit_seq(dotBruno2,21,8) 
	dot_reserve_move_unit_seq(dotBrian,22,8) 
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotBrian,2)
	dot_unit_dir(dotBruno2,3)
	dot_change_anim(dotBrian,3)
	
	
	
	
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	wait_time(0.2)
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotBruno2,3)
	dot_dodge_seq(dotBruno2)
	
	
	
	
	
	wait_time(0.3)
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotBruno2,3)
	dot_dodge_seq(dotBruno2)
	
	
	
	
	
	wait_time(0.2)
	dot_change_anim(dotBrian,3)
	dot_play_particle_unit(dotBrian,"Ef_C_Swd_N_Atk01",3,true)
	
	dot_change_anim(dotBruno2,3)
	dot_play_particle_unit(dotBruno2,"Ef_C_Swd_N_Atk01",3,true)

	dot_damage_seq(dotBrian,dotBruno2,true)
	dot_play_particle_unit(dotBrian,"Ef_C_Cmn_N_Hit_Critical01",0,true)
	
	wait_seq()
	
	dot_change_anim(dotBrian,6)

	wait_time(1.5)
	dot_change_anim(dotBrian,1)
	wait_time(0.3)
	dot_change_anim(dotBruno2,0)
	

	change_face(Brian,"Pain")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020003")
	close_speech_window()


	change_face(Bruno2,"Normal")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020004")
	close_speech_window()


	change_face(Brian,"Pain")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020005")
	close_speech_window()



	change_face(Bruno2,"Sad")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020006")
	close_speech_window()


	
	change_face(Brian,"Pain")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020007")
	close_speech_window()



	change_face(Bruno2,"Normal")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020008")
	close_speech_window()

	wait_time(0.8)


	change_face(Brian,"Normal")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020009")



	change_face(Brian,"Smile")
	message("MA_01107_020010")



	change_face(Brian,"Normal")
	message("MA_01107_020011")



	message("MA_01107_020012")



	message("MA_01107_020013")



	message("MA_01107_020014")
	close_speech_window()



	change_face(Bruno2,"Normal")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020015")
	close_speech_window()



	change_face(Brian,"Smile")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020016")
	close_speech_window()
	
	wait_time(0.5)



	change_face(Bruno2,"Smile")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020017")
	close_speech_window()

	wait_time(0.1)


	change_face(Brian,"Surprise")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020018")
	close_speech_window()



	change_face(Bruno2,"Smile")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020019")
	close_speech_window()



	change_face(Brian,"Surprise")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020020")
	close_speech_window()



	change_face(Bruno2,"Sad")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020021")
	close_speech_window()



	change_face(Brian,"Surprise")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020022")
	close_speech_window()



	change_face(Bruno2,"Sad")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020023")
	close_speech_window()



	change_face(Brian,"Anger")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020024")
	close_speech_window()

	dot_change_anim(dotBruno2,3)


	change_face(Bruno2,"Serious")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020025")
	close_speech_window()



	change_face(Brian,"Anger")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020026")
	close_speech_window()



	change_face(Bruno2,"Anger")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020027")
	
	close_speech_window()
	dot_change_anim(dotBruno2,0)


	change_face(Brian,"Pain")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020028")
	close_speech_window()

	wait_time(0.5)


	change_face(Bruno2,"Normal")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020029")
	close_speech_window()



	wait_time(0.2)

	change_face(Brian,"Normal")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020031")
	close_speech_window()



	change_face(Bruno2,"Sad")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020032")
	close_speech_window()



	change_face(Brian,"Smile")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020033")
	close_speech_window()



	change_face(Bruno2,"Surprise")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020034")
	close_speech_window()



	change_face(Brian,"Surprise")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020035")
	close_speech_window()




	change_face(Bruno2,"Normal")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020036")
	close_speech_window()



	change_face(Brian,"Sad")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020038")
	close_speech_window()



	change_face(Bruno2,"Smile")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020039")
	close_speech_window()



	change_face(Brian,"Normal")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020040")
	close_speech_window()



	change_face(Bruno2,"Smile")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020041")
	close_speech_window()



	change_face(Brian,"Smile")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020042")
	close_speech_window()



	change_face(Bruno2,"Normal")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020043")
	close_speech_window()



	change_face(Brian,"Normal")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020044")
	close_speech_window()



	change_face(Bruno2,"Normal")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020045")
	close_speech_window()



	change_face(Brian,"Surprise")
	open_speech_window("CHRNAME_BRIAN",nil,Brian)
	message("MA_01107_020046")
	
	wait_time(0.3)



	change_face(Brian,"Anger")
	message("MA_01107_020047")
	close_speech_window()




	change_face(Bruno2,"Smile")
	open_speech_window("CHRNAME_BRUNO",Bruno2,nil)
	message("MA_01107_020048")
	close_speech_window()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101021_Bruno_preload(2,true,21,22,0)
	pbadv_setup_101050_Brian_preload(0,true,23,22,0)
end
