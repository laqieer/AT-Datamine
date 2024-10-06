Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201010000","201010000")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)

	pbadv_setup_101009_Noir(2,true,7,38,0)
	
	pbadv_setup_101011_Guinevere(1,true,7,39,0)
	
	pbadv_setup_101030_Elaine(1,true,6,33,0)
	
	pbadv_setup_101031_Lovein(1,true,6,32,0)
	
	pbadv_setup_101037_Rasia(2,true,10,39,0)
	
	pbadv_setup_101039_Fren(2,true,2,38,0)
	
	pbadv_setup_101038_Lola(2,true,2,39,0)
	
    dotbaroi1=dot_reserve_enemy(1,3,38,0)
	dotbaroi2=dot_reserve_enemy(1,3,39,0)

	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotRasia2,2)
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotGuinevere1,2)
	dot_unit_dir(dotbaroi1,3)
	dot_unit_dir(dotbaroi2,3)

	
	
	dot_disp_weapon(dotGuinevere1,false)

	
	
	dot_disp_unit(dotLovein1,false)
	dot_disp_unit(dotElaine1,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(4,40,0.0)
	
	
	dot_change_anim(dotGuinevere1,1)

	load_sound("BGM_Battle_Running")
end





function Play()
	fadein(0)
	Play_start(true)


	
	dot_change_anim(dotGuinevere1,1)

	
	
	

	
	

	dot_reserve_move_unit_seq(dotbaroi2,5,39)
	dot_reserve_move_unit_seq(dotLola2,4,39)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotLovein1,2)
	dot_unit_dir(dotElaine1,2)

	dot_change_anim(dotbaroi2,3)
	dot_play_particle_unit(dotbaroi2,"Ef_C_Swd_N_EmyAtk01",3,true)

	dot_change_anim(dotLola2,3)
	dot_play_particle_unit(dotLola2,"Ef_C_Swd_N_Atk01",3,true)

	dot_play_particle_unit(dotGuinevere1,"Ef_C_Cmn_Guard01",0,true)

	wait_time(0.5)

	dot_reserve_move_unit_seq(dotLola2,2,39)
	dot_reserve_move_unit_seq(dotbaroi2,3,39)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotLola2,3)
	dot_unit_dir(dotbaroi2,3)

	
	
	

	
	

	
	
	
	
	

	
	


	
	
	
	

	

	
	
	change_face(Elaine1,"Anger")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01A900_320002")
	close_speech_window()

	bgm_play("BGM_Battle_Running")

	

	
	dot_disp_unit(dotLovein1,true)
	dot_disp_unit(dotElaine1,true)

	dot_reserve_move_unit_seq(dotElaine1,6,39)
	dot_reserve_move_unit_seq(dotLovein1,6,38)

	exec_parallel_seq()
	wait_seq()
	dot_move_unit_seq(dotLovein1,5,38)

	dot_unit_dir(dotLovein1,2)
	dot_unit_dir(dotElaine1,2)

	
	
	
	
	change_face(Elaine1,"Anger")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320004")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_320005")
	close_speech_window()

	dot_unit_dir(dotElaine1,3)
	dot_disp_weapon(dotElaine1,false)

	
	change_face(Elaine1,"Smile")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320006")
	close_speech_window()

	
	change_face(Guinevere1,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_320007")
	close_speech_window()

	
	change_face(Fren2,"Surprise")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_320008")
	close_speech_window()

	
	change_face(Lovein1,"Smile")
	open_speech_window("CHRNAME_LOVEIN2",Lovein1,nil)
	message("MA_01A900_320009")
	close_speech_window()
	
	dot_unit_dir(dotElaine1,2)
	dot_disp_weapon(dotElaine1,true)
	
	
	change_face(Elaine1,"Normal")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320010")
	close_speech_window()

	
	change_face(Lola2,"Anger")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_320011")
	close_speech_window()

	
	wait_time(0.2)
	dot_disp_weapon(dotElaine1,false)
	dot_unit_dir(dotElaine1,3)
	wait_time(0.3)
	
	
	change_face(Elaine1,"Normal")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320013")
	close_speech_window()

	
	
	change_face(Guinevere1,"Smile")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_320015")
	close_speech_window()

	
	wait_time(0.5)
	dot_change_anim(dotGuinevere1,0)
	wait_time(0.2)
	 
	
	change_face(Elaine1,"Anger")	
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320017")
	close_speech_window()

	
	change_face(Guinevere1,"Normal")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_320018")
	

	
	

	MA_01A900_32_select1()

	open_select_window_tag(Noir2,"Normal","MA_01A900_320020","MA_01A900_320021")
	close_speech_window()

	if is_select(1) then			
		MA_01A900_32_select1_1()
	
	else		
		MA_01A900_32_select1_2()
	
	end
	MA_01A900_32_end()
	
	end
	
	function MA_01A900_32_select1()
	
	end
	
	function MA_01A900_32_select1_1()

	

	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_320023")
	close_speech_window()

	
	change_face(Guinevere1,"Smile")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_320024")
	close_speech_window()

	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_320025")
	close_speech_window()
	
	
	change_face(Guinevere1,"Smile")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_320031")
	close_speech_window()

	
end
 
 
function MA_01A900_32_select1_2()

	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_320027")
	close_speech_window()

	
	change_face(Elaine1,"Normal")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320028")

	
	change_face(Elaine1,"Smile")
	message("MA_01A900_320029")
	close_speech_window()
	
	
	change_face(Guinevere1,"Normal")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_320031")
	close_speech_window()

	
end
 
 
function MA_01A900_32_end()



	wait_time(0.2)
	dot_disp_weapon(dotElaine1,true)
	dot_unit_dir(dotElaine1,2)
	wait_time(0.3)

	open_cutin(1,1)
	on_cutin(1,Elaine1,"Anger",0)
	
	change_face(Elaine1,"Anger")
	open_speech_window("CHRNAME_ELAINE",nil,nil)
	message("MA_01A900_320032")
	close_speech_window()
	
	close_cutin()	

	
	dot_disp_weapon(dotGuinevere1,true)
	
	dot_reserve_move_unit_seq(dotNoir2,8,34)
	dot_reserve_move_unit_seq(dotGuinevere1,7,34)
	exec_parallel_seq()
	wait_seq()
	
	open_cutin(1,1)
	on_cutin(1,Lola2,"Anger",0)
	
	change_face(Lola2,"Anger")
	open_speech_window("CHRNAME_LOLA2",nil,nil)
	message("MA_01A900_320034")
	close_speech_window()
	close_cutin()	
	
	
	
	change_face(Fren2,"Anger")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_320036")
	close_speech_window()

	dot_reserve_move_unit_seq(dotNoir2,13,30)
	dot_reserve_move_unit_seq(dotGuinevere1,13,31)
	
	dot_reserve_move_unit_seq(dotFren2,7,34)
	dot_reserve_move_unit_seq(dotLola2,6,34)

	exec_parallel_seq()
	wait_seq()
	dot_remove_unit(dotNoir2)
	dot_remove_unit(dotGuinevere1)

	dot_unit_dir(dotElaine1,3)
	dot_unit_dir(dotLovein1,3)
	 
	
	change_face(Elaine1,"Anger")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320037")
	close_speech_window()

	
	

	change_camera_distance(7.0,1.5)
	move_camera(7,35,1.5)

	dot_reserve_move_unit_seq(dotFren2,12,34)
	dot_reserve_move_unit_seq(dotLola2,11,34)

	dot_reserve_move_unit_seq(dotRasia2,9,35)

	dot_reserve_move_unit_seq(dotLovein1,6,34)
	dot_reserve_move_unit_seq(dotElaine1,6,35)

	exec_parallel_seq()
	wait_seq()

	dot_reserve_move_unit_seq(dotRasia2,8,35)

	dot_reserve_move_unit_seq(dotLovein1,7,34)
	dot_reserve_move_unit_seq(dotElaine1,7,35)

	dot_reserve_move_unit_seq(dotFren2,13,34)
	dot_reserve_move_unit_seq(dotLola2,12,34)

	exec_parallel_seq()
	wait_seq()
	
	dot_remove_unit(dotFren2)
	dot_remove_unit(dotLola2)

	dot_change_anim(dotRasia2,3)
	dot_play_particle_unit(dotRasia2,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)
	
	wait_time(0.5)


	dot_reserve_move_unit_seq(dotRasia2,9,35)
	dot_reserve_move_unit_seq(dotElaine1,6,35)

	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotElaine1,3)
	dot_unit_dir(dotLovein1,3)
	dot_unit_dir(dotRasia2,2)

	
	dot_change_anim(dotLovein1,0)
	dot_change_anim(dotRasia2,0)
	dot_change_anim(dotElaine1,0)
	
	
	change_face(Rasia2,"Anger")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("MA_01A900_320039")
	close_speech_window()

	
	change_face(Elaine1,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine1,nil)
	message("MA_01A900_320040")
	close_speech_window()

	
	change_face(Rasia2,"Normal")	
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("MA_01A900_320041")

	
	change_face(Rasia2,"Anger")
	message("MA_01A900_320042")

	
	change_face(Rasia2,"Anger")
	message("MA_01A900_320043")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotRasia2,8,35)
	dot_reserve_move_unit_seq(dotElaine1,7,35)
	exec_parallel_seq()
	wait_seq()

	
	
	

	
	

	dot_change_anim(dotRasia2,3)
	dot_play_particle_unit(dotRasia2,"Ef_C_Swd_N_Atk01",3,true)

	dot_change_anim(dotElaine1,3)
	dot_play_particle_unit(dotElaine1,"Ef_C_Spr_N_Atk01",3,true)
	
	
	wait_time(1.0)


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,7,38,0)
	pbadv_setup_101011_Guinevere_preload(1,true,7,39,0)
	pbadv_setup_101030_Elaine_preload(1,true,6,33,0)
	pbadv_setup_101031_Lovein_preload(1,true,6,32,0)
	pbadv_setup_101037_Rasia_preload(2,true,10,39,0)
	pbadv_setup_101039_Fren_preload(2,true,2,38,0)
	pbadv_setup_101038_Lola_preload(2,true,2,39,0)
	preload_sound("BGM_Battle_Running")
end
