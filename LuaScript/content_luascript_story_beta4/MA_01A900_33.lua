Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201150000","201150000")
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)



	pbadv_setup_101009_Noir(2,true,19,40,0)
	
	pbadv_setup_101011_Guinevere(1,true,19,41,0)
	
	pbadv_setup_101017_Maladisant(1,true,24,21,0)
	
	pbadv_setup_101012_Dinatan(0,true,25,21,0)
	
	pbadv_setup_101016_Gwenhwymawr(1,true,15,23,0)
	
	pbadv_setup_101015_Arthur(0,true,17,14,0)
	
	pbadv_setup_101010_Lancelot(0,true,23,14,0)
	
	pbadv_setup_101042_Moronoe(true,20,23,0)
	
	pbadv_setup_101039_Fren(2,true,21,39,0)
	
	pbadv_setup_101038_Lola(2,true,21,40,0)
	
	
	
	
	barbaroi4=dot_reserve_enemy(303,20,22,0)
	
	
	
	
	
	barbaroi10=dot_reserve_enemy(1,19,23,0)
	barbaroi11=dot_reserve_enemy(1,21,23,0)
	
	
	
	
	barbaroi16=dot_reserve_enemy(1201,19,21,0)
	barbaroi17=dot_reserve_enemy(1201,20,21,0)
	barbaroi18=dot_reserve_enemy(1201,21,21,0)
	
	
	
	
	
	barbaroi24=dot_reserve_enemy(601,20,20,0)
	
	
	
	
	
	
	
	
	barbaroi33=dot_reserve_enemy(1301,19,5,0)
	barbaroi34=dot_reserve_enemy(1200,19,6,0)
	
	
	
	
	barbaroi39=dot_reserve_enemy(505,20,4,0)
	barbaroi40=dot_reserve_enemy(1301,20,5,0)
	barbaroi41=dot_reserve_enemy(1200,20,6,0)
	
	
	
	
	
	barbaroi47=dot_reserve_enemy(1301,21,5,0)
	barbaroi48=dot_reserve_enemy(1200,21,6,0)
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_unit_dir(dotDinatan,2)
	dot_unit_dir(dotMaladisant1,2)
	dot_unit_dir(dotLancelot,2)

	
	

	
	
	dot_disp_unit(dotMoronoe,false)
	dot_disp_unit(dotGwenhwymawr1,false)
	
	
	
	dot_disp_unit(barbaroi4,false)
	
	
	
	
	
	dot_disp_unit(barbaroi10,false)
	dot_disp_unit(barbaroi11,false)
	
	
	dot_disp_unit(dotLancelot,false)
	dot_disp_unit(dotArthur,false)
	dot_disp_unit(dotDinatan,false)
	dot_disp_unit(dotMaladisant1,false)
	dot_disp_unit(dotFren2,false)
	dot_disp_unit(dotLola2,false)
	
	
	
	
	
	
	dot_disp_unit(barbaroi33,false)
	dot_disp_unit(barbaroi34,false)
	
	
	
	
	dot_disp_unit(barbaroi39,false)
	dot_disp_unit(barbaroi40,false)
	dot_disp_unit(barbaroi41,false)
	
	
	
	
	
	dot_disp_unit(barbaroi47,false)
	dot_disp_unit(barbaroi48,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(30.0,0.0)

	
	
	move_camera(20,39,0.0)
	
	

	Ef_Change_W=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)

	Ef_Portal_E1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E11=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E12=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E13=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E14=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E15=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E16=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E17=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E18=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E19=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E20=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Portal_E21=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	Ef_Emblem02=load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem02",false,true)
	Ef_BlackFeather=load_particle("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)

	Ef_Flash01_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_8=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_9=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_10=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_11=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_12=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_13=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_14=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_15=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_16=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_17=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_18=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_19=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_20=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	Ef_Flash01_21=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)

	Ef_Black_fog_vanish=load_particle("content_effect3d_common_adv","Ef_C_Adv_Black_fog_vanish",false,true)

	Ef_VibesAura=load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	
	Ef_Shockwave01_1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_Shockwave01_2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_Shockwave01_3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_Shockwave01_4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_Shockwave01_5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_Shockwave01_6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	Ef_PivotCenter_018=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_018",false,true)
	Ef_Witch_Spr_AtkAura1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_AtkAura",false,true)
	Ef_Hit_Witch_Spe1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Hit_Witch_Spe",false,true)
	Ef_Change_W1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)


end
function Fren2MoveSet() 
	dot_place_unit(dotFren2,21,22)

	dot_disp_unit(dotFren2,true)
	
	dot_move_unit_seq(dotFren2,21,15)
	
	wait_seq()
end

function Lola2MoveSet() 
	dot_place_unit(dotLola2,19,22)
	
	dot_disp_unit(dotLola2,true)
	
	dot_move_unit_seq(dotLola2,19,15)
	
	wait_seq()
end





function Play()
	fadein(0)
	Play_start(true)




	
	move_camera(20,25,3.0)

	dot_reserve_move_unit_seq(dotNoir2,20,29)
	dot_reserve_move_unit_seq(dotGuinevere1,19,29)
	exec_parallel_seq()
	wait_seq()

	dot_reserve_move_unit_seq(dotNoir2,20,26)
	dot_reserve_move_unit_seq(dotGuinevere1,19,26)
	exec_parallel_seq()
	wait_seq()

	
	
	dot_change_anim(dotGuinevere1,1)

	dot_move_unit_seq(dotNoir2,20,25)
	wait_seq()

	dot_unit_dir(dotNoir2,2)

	

	
	
	


	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_330002")
	close_speech_window()
	
	dot_move_unit_seq(dotNoir2,20,26)
	wait_seq()

	dot_unit_dir(dotNoir2,2)

	
	change_face(Guinevere1,"Pain")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330003")

	
	
	on_active(Ef_PivotCenter_018)

	local gridpos = get_grid_position(20,23)
	gridpos[2] = 5.0
	set_pos(Ef_PivotCenter_018, gridpos)
	turn(Ef_PivotCenter_018,90, 0, 0, 0.0)
	play_particle(Ef_PivotCenter_018)
	
	on_active(Ef_Witch_Spr_AtkAura1)

	set_pos(Ef_Witch_Spr_AtkAura1, gridpos)
	turn(Ef_Witch_Spr_AtkAura1,90, 0, 0, 0.0)
	play_particle(Ef_Witch_Spr_AtkAura1)
	
	local gridpos = get_grid_position(20,23)
	gridpos[2] = 1.11
	
	slidemove(Ef_PivotCenter_018, gridpos, 0.1)
	slidemove(Ef_Witch_Spr_AtkAura1, gridpos, 0.1)
	
	on_active(Ef_Hit_Witch_Spe1)

	local gridpos = get_grid_position(20,23)
	gridpos[2] = 0.01
	set_pos(Ef_Hit_Witch_Spe1, gridpos)
	play_particle(Ef_Hit_Witch_Spe1)
	
	stop_particle(Ef_Witch_Spr_AtkAura1)
	
	dot_play_particle_grid("Ef_C_Cmn_N_Hit_Spe01",20,23)
	
	
	change_face(Guinevere1,"Anger")
	message("MA_01A900_330005")

	
	on_active(Ef_Change_W1)
	on_active(Ef_BlackFeather)
	
	local gridpos=get_grid_position(20,23)
	set_pos(Ef_BlackFeather,gridpos)
	play_particle(Ef_BlackFeather)
	
	local gridpos=get_grid_position(20,23)
	set_pos(Ef_Change_W1,gridpos)
	play_particle(Ef_Change_W1)
	
	
	wait_time(1.0)
	
	stop_particle(Ef_PivotCenter_018)
	stop_particle(Ef_Hit_Witch_Spe1)
	dot_disp_unit(dotMoronoe,true)
	
	wait_time(1,0)
	
	




	on_active(Ef_Portal_E6)
	
	



	on_active(Ef_Portal_E12)
	on_active(Ef_Portal_E13)
	
	
























	local gridpos=get_grid_position(20,22)
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	
	
























	local gridpos=get_grid_position(19,23)
	set_pos(Ef_Portal_E12,gridpos)
	set_scale(Ef_Portal_E12,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E12)
	
	local gridpos=get_grid_position(21,23)
	set_pos(Ef_Portal_E13,gridpos)
	set_scale(Ef_Portal_E13,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E13)
	
	wait_time(0.2)
	
	


	dot_disp_unit(barbaroi4,true)
	




	dot_disp_unit(barbaroi10,true)
	dot_disp_unit(barbaroi11,true)
	

	
	
	change_face(Guinevere1,"Anger")
	message("MA_01A900_330007")
	close_speech_window()

	
	change_face(Moronoe,"Anger")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01A900_330008")

	
	change_face(Moronoe,"Anger")
	message("MA_01A900_330009")
	

	

	
	
	MA_01A900_33_select1()
	
	open_select_window_tag(Noir2,"Normal","MA_01A900_330011","MA_01A900_330012")
	close_speech_window()

	if is_select(1) then			
		MA_01A900_33_select1_1()
	
	else	
		MA_01A900_33_select1_2()
	
	end
	MA_01A900_33_end()
	
	end
	
	function MA_01A900_33_select1()
	
	end
	
	function MA_01A900_33_select1_1()

	
	
	dot_move_unit_seq(dotNoir2,20,25)
	wait_seq()

	dot_attack_seq(dotNoir2,dotMoronoe)
	wait_seq()

	dot_change_anim(dotMoronoe,5)
	dot_play_particle_unit(dotMoronoe,"Ef_C_Cmn_Guard01",1,true)
	wait_time(0.8)
	dot_change_anim(dotMoronoe,0)
	dot_change_anim(dotNoir2,0)
	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_330014")
	close_speech_window()

	
	change_face(Moronoe,"Anger")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01A900_330015")
	close_speech_window()

	
	change_face(Guinevere1,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330016")
	close_speech_window()
	
end
 
 
function MA_01A900_33_select1_2()

	
	dot_move_unit_seq(dotNoir2,19,25)
	wait_seq()

	dot_unit_dir(dotNoir2,3)

	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_330018")
	close_speech_window()

	
	change_face(Moronoe,"Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01A900_330019")
	close_speech_window()

	
	change_face(Guinevere1,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330020")
	close_speech_window()

	
end
 
 
function MA_01A900_33_end()

	
	
	
	
	

	


	on_active(Ef_Flash01_4)
	
	on_active(Ef_Flash01_6)
	on_active(Ef_Flash01_7)
	

	on_active(Ef_Flash01_10)
	on_active(Ef_Flash01_11)
	on_active(Ef_Flash01_12)
	

	
	


	dot_change_anim(barbaroi4,6)
	




	dot_change_anim(barbaroi10,6)
	dot_change_anim(barbaroi11,6)
	

	
	
	











	local gridpos=get_grid_position(20,22)
	set_pos(Ef_Flash01_4,gridpos)
	play_particle(Ef_Flash01_4)

	

















	dot_play_particle_unit(barbaroi39,"Ef_C_Spr_N_Atk01",3,true)
	dot_play_particle_unit(dotMoronoe,"Ef_C_Cmn_N_Hit_Spe01",3,true)

	local gridpos=get_grid_position(19,23)
	set_pos(Ef_Flash01_10,gridpos)
	play_particle(Ef_Flash01_10)

	local gridpos=get_grid_position(20,23)
	set_pos(Ef_Flash01_11,gridpos)
	play_particle(Ef_Flash01_11)

	local gridpos=get_grid_position(21,23)
	set_pos(Ef_Flash01_12,gridpos)
	play_particle(Ef_Flash01_12)

	







	dot_change_anim(dotMoronoe,6)
	
	wait_time(0.2)
	
	


	dot_remove_unit(barbaroi4)
	




	dot_remove_unit(barbaroi10)
	dot_remove_unit(barbaroi11)
	

	
	
	dot_move_unit_seq(dotNoir2,19,25)
	wait_seq()
	wait_time(0.5)
	
	
	change_face(Moronoe,"Anger")
	open_speech_window("CHRNAME_SISTERS_1",nil,Moronoe)
	message("MA_01A900_330022")
	close_speech_window()

	
	dot_change_anim(dotMoronoe,1)
	
	
	
	
	change_face(Gwenhwymawr1,"Anger")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01A900_330024")
	close_speech_window()

	
	on_active(Ef_Black_fog_vanish)
	local gridpos=get_grid_position(20,23)
	set_pos(Ef_Black_fog_vanish,gridpos)
	play_particle(Ef_Black_fog_vanish)

	wait_time(1.5)
	dot_remove_unit(dotMoronoe)
	
	
	dot_move_unit_seq(dotGwenhwymawr1,19,23)

	wait_time(0.1)
	dot_disp_unit(dotGwenhwymawr1,true)
	
	wait_seq()
	dot_change_anim(dotGuinevere1,0)
	
	change_face(Guinevere1,"Smile")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330026")
	close_speech_window()

	
	

	
	change_face(Gwenhwymawr1,"Smile")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1,nil)
	message("MA_01A900_330027")
	close_speech_window()

	dot_reserve_move_unit_seq(dotFren2,21,30)
	dot_reserve_move_unit_seq(dotLola2,19,30)
	exec_parallel_seq()
	
	
	on_active(Ef_Shockwave01_1)
	

	on_active(Ef_Shockwave01_4)
	on_active(Ef_Shockwave01_5)
	on_active(Ef_Shockwave01_6)
	
	se_play("SE_ADV_MA_01A900_33_Axe_Impact")
	
	dot_play_particle_unit(barbaroi39,"Ef_C_Axe_N_Atk01",3,true)
	dot_play_particle_unit(barbaroi17,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	
	local gridpos=get_grid_position(20,21)
	set_pos(Ef_Shockwave01_1,gridpos)
	play_particle(Ef_Shockwave01_1)
	





	local gridpos=get_grid_position(20,20)
	set_pos(Ef_Shockwave01_4,gridpos)
	play_particle(Ef_Shockwave01_4)
	local gridpos=get_grid_position(21,21)
	set_pos(Ef_Shockwave01_5,gridpos)
	play_particle(Ef_Shockwave01_5)
	local gridpos=get_grid_position(19,21)
	set_pos(Ef_Shockwave01_6,gridpos)
	play_particle(Ef_Shockwave01_6)
	
	
	
	dot_change_anim(barbaroi24,6)
	dot_change_anim(barbaroi16,6)
	dot_change_anim(barbaroi17,6)
	dot_change_anim(barbaroi18,6)
	
	wait_time(0.2)
	
	
	

	dot_remove_unit(barbaroi16)
	dot_remove_unit(barbaroi17)
	dot_remove_unit(barbaroi18)
	




	dot_remove_unit(barbaroi24)
	



	
	dot_change_anim(dotMaladisant1,3)
	dot_disp_unit(dotDinatan,true)
	dot_disp_unit(dotMaladisant1,true)

	wait_time(1.0)
	

	
	
	change_face(Maladisant1,"Anger")
	open_speech_window("CHRNAME_MALADISANT2",Maladisant1,nil)
	message("MA_01A900_330029")
	close_speech_window()

	
	
	change_face(Dinatan,"Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01A900_330031")
	close_speech_window()
	
	dot_change_anim(dotMaladisant1,0)

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_330032")
	close_speech_window()

	
	change_face(Dinatan,"Anger")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01A900_330033")
	close_speech_window()

	dot_reserve_move_unit_seq(dotNoir2,21,25)
	dot_reserve_move_unit_seq(dotGuinevere1,20,25)
	exec_parallel_seq()
	wait_seq()

	dot_reserve_move_unit_seq(dotNoir2,21,23)
	dot_reserve_move_unit_seq(dotGuinevere1,20,23)
	exec_parallel_seq()
	wait_seq()

	move_camera(20,15,1.0)
	
	dot_reserve_move_unit_seq(dotGwenhwymawr1,19,12)
	dot_reserve_move_unit_seq(dotNoir2,21,12)
	dot_reserve_move_unit_seq(dotGuinevere1,20,12)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotNoir2,2)

	
	


	
	
	local Fren2Set = create_coroutine(Fren2MoveSet) 
	local Lola2rSet = create_coroutine(Lola2MoveSet) 
	
	coroutine.resume(Fren2Set)  
	coroutine.resume(Lola2rSet)  
	
	
	
	change_face(Fren2,"Anger")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_330035")
	close_speech_window()

	
	change_face(Lola2,"Anger")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_330036")
	close_speech_window()

	
	
	
	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01A900_330038")
	close_speech_window()

	pbadv_wait_coroutine(Fren2Set) 
	pbadv_wait_coroutine(Lola2rSet) 
	
	dot_disp_unit(dotLancelot,true)
	dot_disp_unit(dotArthur,true)
	dot_reserve_move_unit_seq(dotLancelot,21,14)
	dot_reserve_move_unit_seq(dotArthur,19,14)
	exec_parallel_seq()
	wait_seq()
	
	
	change_face(Lola2,"Surprise")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("MA_01A900_330039")
	close_speech_window()
	
	dot_unit_dir(dotLancelot,1)
	dot_unit_dir(dotArthur,1)
	
	dot_change_anim(dotLancelot,3)
	dot_change_anim(dotArthur,3)

	dot_change_anim(dotLola2,6)
	dot_play_particle_unit(dotLola2,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	dot_change_anim(dotFren2,6)
	dot_play_particle_unit(dotFren2,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	
	dot_change_anim(dotLola2,6)
	dot_change_anim(dotFren2,6)
	dot_move_knockback(dotFren2,21,16,0.2,2)
	dot_move_knockback(dotLola2,19,16,0.2,2)
	wait_time(0.6)
	dot_change_anim(dotLola2,1)
	dot_change_anim(dotFren2,1)
	
	change_face(Fren2,"Pain")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("MA_01A900_330041")
	close_speech_window()
	
	dot_unit_dir(dotLancelot,2)
	dot_unit_dir(dotArthur,3)
	dot_change_anim(dotLancelot,0)
	dot_change_anim(dotArthur,0)
	
	
	
	change_face(Arthur,"Normal")
	open_speech_window("CHRNAME_NAMELES",nil,nil)
	message("MA_01A900_330043")
	close_speech_window()

	
	
	
	change_face(Arthur,"Smile")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	message("MA_01A900_330045")

	
	
	change_face(Arthur,"Serious")
	message("MA_01A900_330046")
	close_speech_window()

	
	

	dot_unit_dir(dotGuinevere1,2)

	
	change_face(Guinevere1,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330048")
	close_speech_window()

	
	
	change_face(Arthur,"Smile")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	message("MA_01A900_330050")
	close_speech_window()

	
	
	change_face(Guinevere1,"Smile")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330052")
	close_speech_window()

	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_330053")
	close_speech_window()

	
	
	
	
	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("MA_01A900_330054")

	
	
	change_face(Lancelot,"Normal")
	message("MA_01A900_330055")
	close_speech_window()

	open_cutin(2,1)
	
	on_cutin(1,Arthur,"Anger",0)
	on_cutin(2,Lancelot,"Anger",0)

	
	
	open_speech_window("CHRNAME_ARTHUR_LANCELOT",nil,nil)
	message("MA_01A900_330057")
	close_speech_window()

	
	close_cutin()

	open_cutin(2,1)
	
	on_cutin(1,Noir2,"Anger",0)
	on_cutin(2,Guinevere1,"Anger",0)

	
	
	open_speech_window("CHRNAME_NOIR_GUINEVERE",nil,nil)
	message("MA_01A900_330058")
	close_speech_window()

	
	close_cutin()

	
	move_camera(20,10,0.3)

	dot_reserve_move_unit_seq(dotLancelot,19,17)
	dot_reserve_move_unit_seq(dotArthur,21,17)

	on_active(Ef_Portal_E7)
	on_active(Ef_Portal_E14)
	




	on_active(Ef_Portal_E20)
	on_active(Ef_Portal_E21)

	
























	local gridpos=get_grid_position(19,5)
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	
	local gridpos=get_grid_position(19,6)
	set_pos(Ef_Portal_E7,gridpos)
	set_scale(Ef_Portal_E7,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E7)
	
	


















	
	local gridpos=get_grid_position(20,4)
	set_pos(Ef_Portal_E12,gridpos)
	set_scale(Ef_Portal_E12,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E12)
	
	local gridpos=get_grid_position(20,5)
	set_pos(Ef_Portal_E13,gridpos)
	set_scale(Ef_Portal_E13,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E13)
	
	local gridpos=get_grid_position(20,6)
	set_pos(Ef_Portal_E14,gridpos)
	set_scale(Ef_Portal_E14,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E14)
	
	
























	local gridpos=get_grid_position(21,5)
	set_pos(Ef_Portal_E20,gridpos)
	set_scale(Ef_Portal_E20,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E20)
	
	local gridpos=get_grid_position(21,6)
	set_pos(Ef_Portal_E21,gridpos)
	set_scale(Ef_Portal_E21,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E21)
	
	wait_time(0.2)
	
	




	dot_disp_unit(barbaroi33,true)
	dot_disp_unit(barbaroi34,true)
	



	dot_disp_unit(barbaroi39,true)
	dot_disp_unit(barbaroi40,true)
	dot_disp_unit(barbaroi41,true)
	




	dot_disp_unit(barbaroi47,true)
	dot_disp_unit(barbaroi48,true)
	
	dot_reserve_move_unit_seq(dotGwenhwymawr1,19,11)
	dot_reserve_move_unit_seq(dotNoir2,21,11)
	dot_reserve_move_unit_seq(dotGuinevere1,20,11)
	exec_parallel_seq()
	wait_seq()

	dot_unit_dir(dotNoir2,2)
	dot_unit_dir(dotGuinevere1,2)

	dot_move_unit_seq(dotGwenhwymawr1,20,9)
	
	
	
	wait_seq()

	dot_unit_dir(dotGwenhwymawr1,3)
	
	
	
	on_active(Ef_Emblem02)
	local locatorpos = dot_get_unit_locator(dotGwenhwymawr1,1)
	set_pos(Ef_Emblem02,locatorpos)
	
	on_active(Ef_VibesAura)
	local gridpos=get_grid_position(20,9)
	set_pos(Ef_VibesAura,gridpos)
	play_particle(Ef_VibesAura)
	
	
	wait_time(0.5)
	
	
	change_face(Gwenhwymawr1,"Smile")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1,nil)
	message("MA_01A900_330060")
	close_speech_window()

	wait_time(1.0)
	
	
	change_face(Guinevere1,"Smile")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330062")
	close_speech_window()

	
	dot_attack_seq(dotGwenhwymawr1,barbaroi41)
	dot_damage_seq(barbaroi41,dotGwenhwymawr1,true)
	stop_particle(Ef_VibesAura)

	


	on_active(Ef_Flash01_18)
	on_active(Ef_Flash01_19)
	

	
	



















	local gridpos=get_grid_position(19,5)
	set_pos(Ef_Flash01_6,gridpos)
	play_particle(Ef_Flash01_6)
	
	local gridpos=get_grid_position(19,6)
	set_pos(Ef_Flash01_7,gridpos)
	play_particle(Ef_Flash01_7)
	
	







	local gridpos=get_grid_position(20,4)
	set_pos(Ef_Flash01_10,gridpos)
	play_particle(Ef_Flash01_10)
	
	local gridpos=get_grid_position(20,5)
	set_pos(Ef_Flash01_11,gridpos)
	play_particle(Ef_Flash01_11)

	local gridpos=get_grid_position(20,6)
	set_pos(Ef_Flash01_12,gridpos)
	play_particle(Ef_Flash01_12)

	



















	local gridpos=get_grid_position(21,5)
	set_pos(Ef_Flash01_18,gridpos)
	play_particle(Ef_Flash01_18)

	local gridpos=get_grid_position(21,6)
	set_pos(Ef_Flash01_19,gridpos)
	play_particle(Ef_Flash01_19)
	
	







	wait_time(0.2)

	




	dot_remove_unit(barbaroi33)
	dot_remove_unit(barbaroi34)
	



	dot_remove_unit(barbaroi39)
	dot_remove_unit(barbaroi40)
	dot_remove_unit(barbaroi41)
	




	dot_remove_unit(barbaroi47)
	dot_remove_unit(barbaroi48)
	
	
	
	
	wait_time(1.3)
	
	dot_change_anim(dotGwenhwymawr1,0)
	
	
	change_face(Gwenhwymawr1,"Anger")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1,nil)
	message("MA_01A900_330064")
	close_speech_window()


	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01A900_330065")
	close_speech_window()

	
	change_face(Gwenhwymawr1,"Anger")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1,nil)
	message("MA_01A900_330066")
	close_speech_window()

	
	change_face(Guinevere1,"Sad")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere1,nil)
	message("MA_01A900_330067")
	close_speech_window()

	
	change_face(Gwenhwymawr1,"Sad")
	open_speech_window("CHRNAME_GWENHWYMAWR2",Gwenhwymawr1,nil)
	message("MA_01A900_330068")
	close_speech_window()

	wait_time(0.5)
	open_cutin(2,1)
	on_cutin(1,Gwenhwymawr1,"Smile",0)
	on_cutin(2,Guinevere1,"Smile",0)
	
	
	open_speech_window("CHRNAME_GUINEVERE2",nil,nil)
	message("MA_01A900_330069")
	close_speech_window()

	wait_time(0.7)
	
	
	
	open_speech_window("CHRNAME_GWENHWYMAWR2",nil,nil)
	message("MA_01A900_330070")
	close_speech_window()

	close_cutin()	
	

	dot_reserve_move_unit_seq(dotNoir2,21,9)
	dot_reserve_move_unit_seq(dotGuinevere1,21,10)
	
	exec_parallel_seq()
	wait_seq()

	dot_reserve_move_unit_seq(dotNoir2,21,8)
	dot_reserve_move_unit_seq(dotGuinevere1,21,9)
	exec_parallel_seq()
	wait_seq()

	move_camera(20,0,1.5)

	dot_reserve_move_unit_seq(dotNoir2,20,8)
	dot_reserve_move_unit_seq(dotGuinevere1,21,8)
	exec_parallel_seq()
	wait_seq()

	dot_reserve_move_unit_seq(dotNoir2,20,1)
	dot_reserve_move_unit_seq(dotGuinevere1,21,1)
	exec_parallel_seq()

	wait_time(0.3)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,19,40,0)
	pbadv_setup_101011_Guinevere_preload(1,true,19,41,0)
	pbadv_setup_101017_Maladisant_preload(1,true,24,21,0)
	pbadv_setup_101012_Dinatan_preload(0,true,25,21,0)
	pbadv_setup_101016_Gwenhwymawr_preload(1,true,15,23,0)
	pbadv_setup_101015_Arthur_preload(0,true,17,14,0)
	pbadv_setup_101010_Lancelot_preload(0,true,23,14,0)
	pbadv_setup_101042_Moronoe_preload(true,20,23,0)
	pbadv_setup_101039_Fren_preload(2,true,21,39,0)
	pbadv_setup_101038_Lola_preload(2,true,21,40,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem02",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BlackFeather",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Black_fog_vanish",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Shockwave01",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_PivotCenter_018",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Witch_Spr_AtkAura",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Hit_Witch_Spe",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Change_Witch",false,true)
end
