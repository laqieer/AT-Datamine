Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	load_image("MA01A9001301", "content_still_10103010_image", "101030100_StillImage")
	
	
	init_psbattleadv("201010000","201010000")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)


	pbadv_setup_101009_Noir(2,true,29,40,0)
	
	pbadv_setup_101011_Guinevere(0,true,29,41,0)
	
	pbadv_setup_101037_Rasia(1,true,16,41,0)
	
	pbadv_setup_101039_Fren(2,true,0,39,0)
	
	pbadv_setup_101038_Lola(2,true,0,38,0)
	
	dotbaroi1=dot_reserve_enemy(1,2,34,0)
	dotbaroi2=dot_reserve_enemy(1,4,32,0)
	dotbaroi3=dot_reserve_enemy(202,8,26,0)
	dotbaroi4=dot_reserve_enemy(303,0,26,0)
	dotbaroi5=dot_reserve_enemy(42,4,27,0)
	dotbaroi6=dot_reserve_enemy(500,7,30,0)
	
	dotbaroi7=dot_reserve_enemy(303,0,34,0)
	dotbaroi8=dot_reserve_enemy(303,0,35,0)
	dotbaroi9=dot_reserve_enemy(1103,0,36,0)
	dotbaroi10=dot_reserve_enemy(1208,0,37,0)
	dotbaroi11=dot_reserve_enemy(1302,0,40,0)
	dotbaroi12=dot_reserve_enemy(1401,0,41,0)
	dotbaroi13=dot_reserve_enemy(42,1,34,0)
	dotbaroi14=dot_reserve_enemy(42,1,35,0)
	dotbaroi15=dot_reserve_enemy(202,1,36,0)
	dotbaroi16=dot_reserve_enemy(202,1,37,0)
	dotbaroi17=dot_reserve_enemy(1,1,40,0)
	dotbaroi18=dot_reserve_enemy(1,1,41,0)

	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotRasia1,2)
	dot_unit_dir(dotbaroi1,3)
	dot_unit_dir(dotbaroi3,3)
	dot_unit_dir(dotbaroi5,3)
	dot_unit_dir(dotbaroi7,3)
	dot_unit_dir(dotbaroi8,3)
	dot_unit_dir(dotbaroi9,3)
	dot_unit_dir(dotbaroi10,3)
	dot_unit_dir(dotbaroi11,3)
	dot_unit_dir(dotbaroi12,3)
	dot_unit_dir(dotbaroi13,3)
	dot_unit_dir(dotbaroi14,3)
	dot_unit_dir(dotbaroi15,3)
	dot_unit_dir(dotbaroi16,3)
	dot_unit_dir(dotbaroi17,3)
	dot_unit_dir(dotbaroi18,3)

	
	
	dot_disp_weapon(dotNoir2,true)
	dot_disp_weapon(dotFren2,false)
	dot_disp_weapon(dotLola2,false)

	
	
	dot_disp_unit(dotFren2,false)
	dot_disp_unit(dotLola2,false)
	dot_disp_unit(dotRasia1,false)
	dot_disp_unit(dotbaroi7,false)
	dot_disp_unit(dotbaroi8,false)
	dot_disp_unit(dotbaroi9,false)
	dot_disp_unit(dotbaroi10,false)
	dot_disp_unit(dotbaroi11,false)
	dot_disp_unit(dotbaroi12,false)
	dot_disp_unit(dotbaroi13,false)
	dot_disp_unit(dotbaroi14,false)
	dot_disp_unit(dotbaroi15,false)
	dot_disp_unit(dotbaroi16,false)
	dot_disp_unit(dotbaroi17,false)
	dot_disp_unit(dotbaroi18,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(29,35,0.0)
	
	load_image("101010141", "content_still_10101014_image", "101010140_StillImage")
	
	Ef_Black_fog3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog11=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog12=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog13=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog14=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog15=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog16=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog17=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog18=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog19=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog20=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog21=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog22=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog23=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog24=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog25=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog26=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog27=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog28=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog29=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog40=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog41=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	Ef_Black_fog42=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)

	Ef_Emblem21=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem21",false,true)
	Ef_Emblem01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	
	Ef_Enemy_Lop1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
	Ef_Enemy_Lop2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)

	Ef_Killers_Lop=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	Ef_VibesAura=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)

	Ef_Aura_Lop1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Lop",false,true)
	Ef_Aura_Lop2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Lop",false,true)

	Ef_Aura_spout1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true)
	Ef_Aura_spout2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true)
	Ef_Change_K=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	
	Ef_C_Killers_G=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Killers_Guinevere",false,true)
	Ef_BriB = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
	
	show_image("101010141", 0.0, 0.0, 0,false,false)
	set_scale_image(20,20)
end





function Play()
	fadein(0)
	Play_start(true)

	wait_time(0.5)


	open_narration_window()
	message("MA_01A900_261001")
	message("MA_01A900_261002")
	message("MA_01A900_261003")
	close_narration_window()
	
	fadeout(0,0,0,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)
 

	hide_image()
 

	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)

	
	wait_time(1.0)
		
	
	

	

	
	dot_reserve_move_unit_seq(dotNoir2,29,35)
	dot_reserve_move_unit_seq(dotGuinevere,29,36)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,28,35)
	dot_reserve_move_unit_seq(dotGuinevere,29,35)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotGuinevere,2)
	dot_disp_weapon(dotNoir2,true)

	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_260002")
	close_speech_window()
	
	

	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260003")
	
	se_play("SE_ADV_Emy001_Cry")
	wait_time(0.8)

	
	change_face(Guinevere,"Sad")
	message("MA_01A900_260004")

	
	dot_unit_dir(dotNoir2,3)

	
	
	change_face(Guinevere,"Sad")
	message("MA_01A900_260006")

	
	change_face(Guinevere,"Pain")
	message("MA_01A900_260008")
	close_speech_window()

	
	on_active(Ef_Black_fog3)
	on_active(Ef_Black_fog4)
	on_active(Ef_Black_fog5)
	on_active(Ef_Black_fog6)
	on_active(Ef_Black_fog7)
	on_active(Ef_Black_fog8)
	on_active(Ef_Black_fog9)
	on_active(Ef_Black_fog10)
	on_active(Ef_Black_fog11)
	on_active(Ef_Black_fog12)
	on_active(Ef_Black_fog13)
	on_active(Ef_Black_fog14)
	on_active(Ef_Black_fog15)
	on_active(Ef_Black_fog16)
	on_active(Ef_Black_fog17)
	on_active(Ef_Black_fog18)
	on_active(Ef_Black_fog19)
	on_active(Ef_Black_fog20)
	on_active(Ef_Black_fog21)
	on_active(Ef_Black_fog22)
	on_active(Ef_Black_fog23)
	on_active(Ef_Black_fog24)
	on_active(Ef_Black_fog25)
	on_active(Ef_Black_fog26)
	on_active(Ef_Black_fog27)
	on_active(Ef_Black_fog28)
	on_active(Ef_Black_fog29)
	on_active(Ef_Black_fog40)
	on_active(Ef_Black_fog41)
	on_active(Ef_Black_fog42)

	local gridpos=get_grid_position(0,41)
	set_pos(Ef_Black_fog3,gridpos)
	play_particle(Ef_Black_fog3)
	local gridpos=get_grid_position(1,41)
	set_pos(Ef_Black_fog4,gridpos)
	play_particle(Ef_Black_fog4)
	local gridpos=get_grid_position(2,41)
	set_pos(Ef_Black_fog5,gridpos)
	play_particle(Ef_Black_fog5)
	local gridpos=get_grid_position(0,40)
	set_pos(Ef_Black_fog6,gridpos)
	play_particle(Ef_Black_fog6)
	local gridpos=get_grid_position(1,40)
	set_pos(Ef_Black_fog7,gridpos)
	play_particle(Ef_Black_fog7)
	local gridpos=get_grid_position(2,40)
	set_pos(Ef_Black_fog8,gridpos)
	play_particle(Ef_Black_fog8)
	local gridpos=get_grid_position(0,39)
	set_pos(Ef_Black_fog9,gridpos)
	play_particle(Ef_Black_fog9)
	local gridpos=get_grid_position(1,39)
	set_pos(Ef_Black_fog10,gridpos)
	play_particle(Ef_Black_fog10)
	local gridpos=get_grid_position(2,39)
	set_pos(Ef_Black_fog11,gridpos)
	play_particle(Ef_Black_fog11)
	local gridpos=get_grid_position(0,38)
	set_pos(Ef_Black_fog12,gridpos)
	play_particle(Ef_Black_fog12)
	local gridpos=get_grid_position(1,38)
	set_pos(Ef_Black_fog13,gridpos)
	play_particle(Ef_Black_fog13)
	local gridpos=get_grid_position(2,38)
	set_pos(Ef_Black_fog14,gridpos)
	play_particle(Ef_Black_fog14)
	local gridpos=get_grid_position(0,37)
	set_pos(Ef_Black_fog15,gridpos)
	play_particle(Ef_Black_fog15)
	local gridpos=get_grid_position(1,37)
	set_pos(Ef_Black_fog16,gridpos)
	play_particle(Ef_Black_fog16)
	local gridpos=get_grid_position(2,37)
	set_pos(Ef_Black_fog17,gridpos)
	play_particle(Ef_Black_fog17)
	local gridpos=get_grid_position(0,36)
	set_pos(Ef_Black_fog18,gridpos)
	play_particle(Ef_Black_fog18)
	local gridpos=get_grid_position(1,36)
	set_pos(Ef_Black_fog19,gridpos)
	play_particle(Ef_Black_fog19)
	local gridpos=get_grid_position(2,36)
	set_pos(Ef_Black_fog20,gridpos)
	play_particle(Ef_Black_fog20)
	local gridpos=get_grid_position(0,35)
	set_pos(Ef_Black_fog21,gridpos)
	play_particle(Ef_Black_fog21)
	local gridpos=get_grid_position(1,35)
	set_pos(Ef_Black_fog22,gridpos)
	play_particle(Ef_Black_fog22)
	local gridpos=get_grid_position(2,35)
	set_pos(Ef_Black_fog23,gridpos)
	play_particle(Ef_Black_fog23)
	local gridpos=get_grid_position(0,32)
	set_pos(Ef_Black_fog24,gridpos)
	play_particle(Ef_Black_fog24)
	local gridpos=get_grid_position(1,32)
	set_pos(Ef_Black_fog25,gridpos)
	play_particle(Ef_Black_fog25)
	local gridpos=get_grid_position(2,32)
	set_pos(Ef_Black_fog26,gridpos)
	play_particle(Ef_Black_fog26)
	local gridpos=get_grid_position(0,34)
	set_pos(Ef_Black_fog27,gridpos)
	play_particle(Ef_Black_fog27)
	local gridpos=get_grid_position(1,34)
	set_pos(Ef_Black_fog28,gridpos)
	play_particle(Ef_Black_fog28)
	local gridpos=get_grid_position(2,34)
	set_pos(Ef_Black_fog29,gridpos)
	play_particle(Ef_Black_fog29)
	local gridpos=get_grid_position(0,33)
	set_pos(Ef_Black_fog40,gridpos)
	play_particle(Ef_Black_fog40)
	local gridpos=get_grid_position(1,33)
	set_pos(Ef_Black_fog41,gridpos)
	play_particle(Ef_Black_fog41)
	local gridpos=get_grid_position(2,33)
	set_pos(Ef_Black_fog42,gridpos)
	play_particle(Ef_Black_fog42)

	
	dot_disp_weapon(dotGuinevere,false)
	dot_disp_weapon(dotNoir2,false)
	move_camera(7,40,5.5)
	dot_reserve_move_unit_seq(dotNoir2,26,37)
	dot_reserve_move_unit_seq(dotGuinevere,26,35)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,24,37)
	dot_reserve_move_unit_seq(dotGuinevere,26,37)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,21,37)
	dot_reserve_move_unit_seq(dotGuinevere,23,37)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,21,38)
	dot_reserve_move_unit_seq(dotGuinevere,22,37)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,21,39)
	dot_reserve_move_unit_seq(dotGuinevere,21,37)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,20,39)
	dot_reserve_move_unit_seq(dotGuinevere,21,38)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,19,39)
	dot_reserve_move_unit_seq(dotGuinevere,21,39)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,7,39)
	dot_reserve_move_unit_seq(dotGuinevere,9,39)
	exec_parallel_seq()
	wait_seq()
	dot_reserve_move_unit_seq(dotNoir2,7,38)
	dot_reserve_move_unit_seq(dotGuinevere,6,39)
	exec_parallel_seq()
	wait_seq()
	
	wait_time(1.0)
	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotGuinevere,3)
	dot_disp_weapon(dotGuinevere,true)
	dot_disp_weapon(dotNoir2,true)

	
	change_face(Guinevere,"Sad")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260010")
	close_speech_window()

	

	dot_reserve_move_unit_seq(dotbaroi1,2,10)
	dot_reserve_move_unit_seq(dotbaroi2,2,11)
	dot_reserve_move_unit_seq(dotbaroi3,14,10)
	dot_reserve_move_unit_seq(dotbaroi4,1,12)
	dot_reserve_move_unit_seq(dotbaroi5,2,13)
	dot_reserve_move_unit_seq(dotbaroi6,13,11)

	exec_parallel_seq()

	dot_unit_dir(dotGuinevere,2)

	wait_time(2.0)

	
	
	change_face(Fren2,"Normal")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01A900_260012")
	close_speech_window()
	
	
	dot_disp_weapon(dotFren2,false)
	dot_disp_weapon(dotLola2,false)
	stop_particle(Ef_Black_fog24)
	stop_particle(Ef_Black_fog25)
	stop_particle(Ef_Black_fog26)
	dot_disp_unit(dotFren2,true)
	dot_disp_unit(dotLola2,true)
	
	on_active(Ef_Enemy_Lop1)
	on_active(Ef_Enemy_Lop2)
	wait_camera()
	dot_reserve_move_unit_seq(dotLola2,3,38)
	dot_reserve_move_unit_seq(dotFren2,4,39)
	exec_parallel_seq()
	move_camera(5,40,1.5)
	wait_seq()
	local gridpos=get_grid_position(3,38)
	set_pos(Ef_Enemy_Lop1,gridpos)
	play_particle(Ef_Enemy_Lop1)
	local gridpos=get_grid_position(4,39)
	set_pos(Ef_Enemy_Lop2,gridpos)
	play_particle(Ef_Enemy_Lop2)

	
	
	change_face(Lola2,"Normal")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01A900_260014")
	close_speech_window()

	
	
	
	change_face(Lola2,"Normal")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260016")
	close_speech_window()

	
	dot_reserve_move_unit_seq(dotbaroi11,0,38)
	dot_reserve_move_unit_seq(dotbaroi12,0,39)
	dot_reserve_move_unit_seq(dotbaroi17,1,38)
	dot_reserve_move_unit_seq(dotbaroi18,1,39)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotbaroi11,3)
	dot_unit_dir(dotbaroi12,3)
	dot_unit_dir(dotbaroi17,3)
	dot_unit_dir(dotbaroi18,3)
	dot_disp_unit(dotbaroi7,true)
	dot_disp_unit(dotbaroi8,true)
	dot_disp_unit(dotbaroi9,true)
	dot_disp_unit(dotbaroi10,true)
	dot_disp_unit(dotbaroi11,true)
	dot_disp_unit(dotbaroi12,true)
	dot_disp_unit(dotbaroi13,true)
	dot_disp_unit(dotbaroi14,true)
	dot_disp_unit(dotbaroi15,true)
	dot_disp_unit(dotbaroi16,true)
	dot_disp_unit(dotbaroi17,true)
	dot_disp_unit(dotbaroi18,true)

	dot_remove_unit(dotbaroi1)
	dot_remove_unit(dotbaroi2)
	dot_remove_unit(dotbaroi3)
	dot_remove_unit(dotbaroi4)
	dot_remove_unit(dotbaroi5)
	dot_remove_unit(dotbaroi6)


	
	
	change_face(Fren2,"Normal")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_260018")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260019")
	close_speech_window()

	
	change_face(Lola2,"Normal")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260020")
	close_speech_window()

	
	open_cutin(2,1)
	
	on_cutin(1,Fren2,"Normal",0)
	on_cutin(2,Lola2,"Normal",0)

	
	
	open_speech_window("CHRNAME_FREN_LOLA",nil,nil)
	message("MA_01A900_260021")
	close_speech_window()

	
	close_cutin()

	
	change_face(Lola2,"Normal")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260022")
	close_speech_window()

	
	change_face(Fren2,"Normal")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_260023")
	close_speech_window()

	
	change_face(Lola2,"Normal")	
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260024")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_260025")
	close_speech_window()

	
	change_face(Fren2,"Normal")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_260026")
	close_speech_window()

	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260027")
	close_speech_window()

	
	change_face(Lola2,"Normal")	
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260028")
	close_speech_window()

	open_cutin(2,1)
	
	on_cutin(1,Fren2,"Normal",0)
	on_cutin(2,Lola2,"Normal",0)

	
	
	open_speech_window("CHRNAME_FREN_LOLA",nil,nil)
	message("MA_01A900_260029")
	close_speech_window()

	
	close_cutin()

	
	change_face(Lola2,"Normal")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260030")
	close_speech_window()

	
	
	change_face(Fren2,"Normal")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_260031")
	close_speech_window()

	
	change_face(Lola2,"Normal")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260033")
	close_speech_window()

	open_cutin(2,1)
	
	on_cutin(1,Fren2,"Normal",0)
	on_cutin(2,Lola2,"Normal",0)

	
	
	open_speech_window("CHRNAME_FREN_LOLA",nil,nil)
	message("MA_01A900_260034")
	

	
	dot_disp_weapon(dotFren2,true)
	dot_disp_weapon(dotLola2,true)
	
	
	
	
	message("MA_01A900_260036")
	close_speech_window()

	
	close_cutin()

	
	dot_move_unit_seq(dotGuinevere,7,39)
	wait_seq()
	dot_unit_dir(dotGuinevere,2)

	

	wait_time(1.5)

	
	
	change_face(Rasia1,"Normal")	
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01A900_260038")
	close_speech_window()

	
	move_camera(6,40,0.5)
	dot_disp_unit(dotRasia1,true)
	dot_unit_dir(dotNoir2,3)
	dot_move_unit_seq(dotRasia1,16,39)
	wait_seq()
	dot_move_unit_seq(dotRasia1,9,39)
	wait_seq()
	dot_unit_dir(dotRasia1,2)
	
	
	change_face(Lola2,"Surprise")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_260040")
	close_speech_window()

	
	change_face(Fren2,"Normal")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_260041")
	close_speech_window()

	
	change_face(Rasia1,"Surprise")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia1)
	message("MA_01A900_260042")
	close_speech_window()

	
	 
	
	change_face(Fren2,"Normal")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_260044")

	
	change_face(Fren2,"Smile")
	message("MA_01A900_260045")
	close_speech_window()

	
	change_face(Guinevere,"Anger")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260046")

	
	dot_move_unit_seq(dotGuinevere,6,39)
	wait_seq()
	
	
	dot_unit_dir(dotGuinevere,3)

	
	change_face(Guinevere,"Anger")
	message("MA_01A900_260048")
	close_speech_window()

	
	change_face(Rasia1,"Anger")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia1)
	message("MA_01A900_260049")

	
	change_face(Rasia1,"Anger")
	message("MA_01A900_260050")
	close_speech_window()

	

	dot_unit_dir(dotGuinevere,2)

	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260052")
	close_speech_window()

	
	change_face(Fren2,"Anger")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_260053")
	close_speech_window()

	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260054")

	
	change_face(Guinevere,"Normal")
	message("MA_01A900_260055")
	close_speech_window()

	bgm_play("Set_BGM_Bus_LPF_Volume_2")

	
	
	
	on_cameraframe(2)
	on_screencolor(IMAGE_COLOR, 0, -50)
	show_image("MA01A9001301", 0.0, 0.0, 0.0)
	fadein(IMAGE_TIME_IN_IN)
	wait_time(IMAGE_TIME_IN_IN)
	
	
	wait_time(2.5)
	
	

	
	open_narration_window()
	message("MA_01A900_260057")

	
	message("MA_01A900_260058")

	
	message("MA_01A900_260059")
	close_narration_window()

	
	
	
	
	
	
	change_face(Guinevere,"Smile")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260061")

	
	change_face(Guinevere,"Smile")
	message("MA_01A900_260062")

	
	change_face(Guinevere,"Smile")
	message("MA_01A900_260063")
	close_speech_window()
	
	move_camera(6,39,0.5)

	bgm_play("Reset_BGM_Bus_LPF_Volume_2")
	
	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(IMAGE_TIME_OUT_OUT)
	
	hide_image()
	
	off_cameraframe()
	off_screencolor()
	wait_time(IMAGE_TIME_WAIT_AFTER)
	fadein(IMAGE_TIME_OUT_IN)
	wait_time(IMAGE_TIME_OUT_IN)
	
	
	
	on_active(Ef_VibesAura)

	local gridpos=get_grid_position(6,39)
	set_pos(Ef_VibesAura,gridpos)
	play_particle(Ef_VibesAura)

	wait_time(1.0)

	on_active(Ef_Emblem01)
	on_active(Ef_Emblem21)
	
	local locatorpos = dot_get_unit_locator(dotNoir2,1)
	set_pos(Ef_Emblem21,locatorpos)
	local locatorpos = dot_get_unit_locator(dotGuinevere,1)
	set_pos(Ef_Emblem01,locatorpos)

	dot_unit_dir(dotNoir2,2)
	
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260065")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_260066")
	close_speech_window()

	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260067")

	
	dot_disp_weapon(dotGuinevere,false)
	dot_disp_weapon(dotNoir2,false)
	dot_unit_dir(dotGuinevere,3)
	
	
	change_face(Guinevere,"Smile")
	message("MA_01A900_260069")
	

	on_active(Ef_VibesAura)
	
	
	MA_01A900_26_select1()
	
	open_select_window_tag(Noir2,"Normal","MA_01A900_260071","MA_01A900_260072")
	close_speech_window()
	
	if is_select(1) then			
		MA_01A900_26_select1_1()
	
	else		
		MA_01A900_26_select1_2()
	
	end
	MA_01A900_26_end()
	
	end
	
	function MA_01A900_26_select1()
	
	end
	
	function MA_01A900_26_select1_1()

	
	
	dot_unit_dir(dotGuinevere,2)
	dot_move_unit_seq(dotNoir2,6,38)
	wait_seq()
	dot_unit_dir(dotGuinevere,2)

	
	
	
	on_active(Ef_Killers_Lop)
	local gridpos=get_grid_position(6,38)
	set_pos(Ef_Killers_Lop,gridpos)
	play_particle(Ef_Killers_Lop)
	
	
	change_face(Guinevere,"Smile")	
	open_mind_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260074")
	close_mind_window()
	
	
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260078")

	
	change_face(Guinevere,"Normal")
	message("MA_01A900_260079")
	close_speech_window()
	
end
 
 
function MA_01A900_26_select1_2()

	
	
	dot_move_unit_seq(dotNoir2,7,39)
	wait_seq()
	dot_unit_dir(dotGuinevere,3)
	dot_unit_dir(dotNoir2,2)
	
	
	on_active(Ef_Killers_Lop)
	on_active(Ef_Aura_Lop1)
	on_active(Ef_Aura_Lop2)
	on_active(Ef_Aura_spout1)
	on_active(Ef_Aura_spout2)
	
	local gridpos = get_grid_position(7,39)
	set_pos(Ef_Killers_Lop, gridpos)
	play_particle(Ef_Killers_Lop)
	local gridpos = get_grid_position(6,39)
	set_pos(Ef_VibesAura, gridpos)
	play_particle(Ef_VibesAura)
	
	wait_time(1.0)
	
	local gridpos=get_grid_position(7,39)
	set_pos(Ef_Aura_spout1,gridpos)
	play_particle(Ef_Aura_spout1)
	local gridpos=get_grid_position(6,39)
	set_pos(Ef_Aura_spout2,gridpos)
	play_particle(Ef_Aura_spout2)
	wait_time(1.5)
	local gridpos=get_grid_position(7,39)
	set_pos(Ef_Aura_Lop1,gridpos)
	play_particle(Ef_Aura_Lop1)
	local gridpos=get_grid_position(6,39)
	set_pos(Ef_Aura_Lop2,gridpos)
	play_particle(Ef_Aura_Lop2)
	wait_time(0.5)
	
	change_face(Guinevere,"Smile")
	open_mind_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260076")
	close_mind_window()

	
	
	change_face(Guinevere,"Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	message("MA_01A900_260078")

	wait_time(1.5)
	dot_unit_dir(dotGuinevere,2)

	
	change_face(Guinevere,"Normal")
	message("MA_01A900_260079")
	close_speech_window()

	
end
 
 
function MA_01A900_26_end()


	
	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_260080")
	close_speech_window()

	
	on_active(Ef_Change_K)

	
	local gridpos=get_grid_position(36,20)
	set_pos(Ef_Change_K,gridpos)
	play_particle(Ef_Change_K)

	
	
	
	
	on_active(Ef_C_Killers_G)
	
	local gridpos=get_grid_position(6,39)
	set_pos(Ef_C_Killers_G,gridpos)
	play_particle(Ef_C_Killers_G)
	
	stop_particle(Ef_Black_fog3)
	stop_particle(Ef_Black_fog4)
	stop_particle(Ef_Black_fog5)
	stop_particle(Ef_Black_fog6)
	stop_particle(Ef_Black_fog7)
	stop_particle(Ef_Black_fog8)
	stop_particle(Ef_Black_fog9)
	stop_particle(Ef_Black_fog10)
	stop_particle(Ef_Black_fog11)
	stop_particle(Ef_Black_fog12)
	stop_particle(Ef_Black_fog13)
	stop_particle(Ef_Black_fog14)
	stop_particle(Ef_Black_fog15)
	stop_particle(Ef_Black_fog16)
	stop_particle(Ef_Black_fog17)
	stop_particle(Ef_Black_fog18)
	stop_particle(Ef_Black_fog19)
	stop_particle(Ef_Black_fog20)
	stop_particle(Ef_Black_fog21)
	stop_particle(Ef_Black_fog22)
	stop_particle(Ef_Black_fog23)
	stop_particle(Ef_Black_fog24)
	stop_particle(Ef_Black_fog25)
	stop_particle(Ef_Black_fog26)
	wait_time(1.5)
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_image_preload("MA01A9001301", "content_still_10103010_image", "101030100_StillImage")
	pbadv_setup_101009_Noir_preload(2,true,29,40,0)
	pbadv_setup_101011_Guinevere_preload(0,true,29,41,0)
	pbadv_setup_101037_Rasia_preload(1,true,16,41,0)
	pbadv_setup_101039_Fren_preload(2,true,0,39,0)
	pbadv_setup_101038_Lola_preload(2,true,0,38,0)
	load_image_preload("101010141", "content_still_10101014_image", "101010140_StillImage")
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem21",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Lop",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_spout",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Killers_Guinevere",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Roar02", false, true)
end
