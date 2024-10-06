

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	

	
	init_psbattleadv("201140000","201140000")
	change_time_and_weather(BattleTime_Day,BattleWeather_Shiny)

	pbadv_setup_101009_Noir(2,true,10,13,0)
	
	pbadv_setup_101012_Dinatan(0,true,10,12,0)
	
	pbadv_setup_101032_Gareth(0,true,9,13,0)
	
	pbadv_setup_101033_Lyoness(0,true,9,12,0)
	
	pbadv_setup_101051_Lucius(0,true,9,14,0)
	
	pbadv_setup_101022_Mordred(0,true,8,13,0)
	
	pbadv_setup_101023_Clarice(0,true,8,12,0)
	
	
	pbadv_setup_101018_Ragnar(2,true, 17, 12,0)  
	
	pbadv_setup_101013_Gawain(1,true,16,13,0)
	
	barbaroi1=dot_reserve_enemy(1100,13,11,0)
	barbaroi2=dot_reserve_enemy(204,14,11,0)
	barbaroi3=dot_reserve_enemy(1100,15,11,0)
	barbaroi4=dot_reserve_enemy(1204,16,11,0)
	barbaroi5=dot_reserve_enemy(49,17,11,0)
	barbaroi6=dot_reserve_enemy(1100,13,15,0)
	barbaroi7=dot_reserve_enemy(49,14,15,0)
	barbaroi8=dot_reserve_enemy(1100,15,15,0)
	barbaroi9=dot_reserve_enemy(303,16,15,0)
	barbaroi10=dot_reserve_enemy(1103,17,15,0)
	
	
	
	setup_complete_unit()
	

	
	dot_unit_dir(dotGawain1,2)

	
	
	dot_disp_weapon(dotRagnar2,false)
	dot_disp_weapon(dotGawain1,false)
	
	
	
	
	dot_disp_unit(dotNoir2,false)
	dot_disp_unit(dotDinatan,false)
	dot_disp_unit(dotGareth,false)
	dot_disp_unit(dotLyoness,false)
	dot_disp_unit(dotLucius,false)
	dot_disp_unit(dotMordred,false)
	dot_disp_unit(dotClarice,false)
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi6,false)
	dot_disp_unit(barbaroi7,false)
	dot_disp_unit(barbaroi8,false)
	dot_disp_unit(barbaroi9,false)
	dot_disp_unit(barbaroi10,false)
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(25.0,0.0)

	
	
	move_camera(16,13,0.0)
	
	
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
end





function Play()
	fadein(0)
	Play_start(true)




	
	change_face(Gawain1,"Normal")	
	open_speech_window("CHRNAME_GAWAIN",Gawain1,nil)
	message("MA_01C900_130002")
	close_speech_window()

	
	change_face(Ragnar2,"Normal")	
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2,nil)
	message("MA_01C900_130004")
	close_speech_window()

	
	change_face(Gawain1,"Normal")	
	open_speech_window("CHRNAME_GAWAIN",Gawain1,nil)
	message("MA_01C900_130005")
	close_speech_window()

	
	change_face(Ragnar2,"Sad")	
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2,nil)
	message("MA_01C900_130006")
	close_speech_window()

	
	change_face(Gawain1,"Sad")	
	open_speech_window("CHRNAME_GAWAIN",Gawain1,nil)
	message("MA_01C900_130007")
	close_speech_window()

	
	change_face(Ragnar2,"Normal")	
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2,nil)
	message("MA_01C900_130008")
	close_speech_window()

	
	change_face(Gawain1,"Normal")	
	open_speech_window("CHRNAME_GAWAIN",Gawain1,nil)
	message("MA_01C900_130009")

	
	message("MA_01C900_130010")
	close_speech_window()

	dot_disp_weapon(dotRagnar2,true)
	dot_disp_weapon(dotGawain1,true)
	
	dot_unit_dir(dotRagnar2,2)
	dot_disp_unit(dotNoir2,true)
	dot_disp_unit(dotDinatan,true)
	dot_disp_unit(dotGareth,true)
	dot_disp_unit(dotLyoness,true)
	dot_disp_unit(dotLucius,true)
	dot_disp_unit(dotMordred,true)
	dot_disp_unit(dotClarice,true)
	dot_reserve_move_unit_seq(dotNoir2,14,13)
	dot_reserve_move_unit_seq(dotDinatan,14,12)
	dot_reserve_move_unit_seq(dotGareth,13,13)
	dot_reserve_move_unit_seq(dotLyoness,13,12)
	dot_reserve_move_unit_seq(dotLucius,13,14)
	dot_reserve_move_unit_seq(dotMordred,12,13)
	dot_reserve_move_unit_seq(dotClarice,12,12)
	exec_parallel_seq()
	wait_seq()
	move_camera(15,14,1.0)
	
	
	change_face(Noir2,"Normal")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_130012")
	close_speech_window()

	
	change_face(Gawain1,"Normal")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130013")
	close_speech_window()

	
	
	change_face(Lucius,"Surprise")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_130015")
	close_speech_window()

	
	change_face(Dinatan,"Sad")	
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_130016")
	close_speech_window()

	
	change_face(Ragnar2,"Normal")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar2)
	message("MA_01C900_130017")
	close_speech_window()

	
	
	
	change_face(Gawain1,"Serious")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130019")
	close_speech_window()

	
	change_face(Mordred,"Smile")	
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_130020")
	close_speech_window()

	
	change_face(Lyoness,"Sad")	
	open_speech_window("CHRNAME_LYONESS",Lyoness,nil)
	message("MA_01C900_130021")
	close_speech_window()

	
	change_face(Gawain1,"Sad")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130022")
	close_speech_window()

	
	change_face(Gareth,"Sad")	
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C900_130023")

	
	change_face(Gareth,"Anger")	
	message("MA_01C900_130024")
	close_speech_window()

	
	change_face(Gawain1,"Normal")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130025")
	close_speech_window()

	
	change_face(Gareth,"Normal")	
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C900_130026")
	close_speech_window()

	
	change_face(Noir2,"Normal")		
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_130027")
	close_speech_window()

	
	change_face(Gawain1,"Serious")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130028")
	close_speech_window()

	
	change_face(Noir2,"Serious")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_130029")
	close_speech_window()

	
	change_face(Gawain1,"Serious")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130030")
	close_speech_window()

	
	change_face(Dinatan,"Pain")	
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_130031")
	close_speech_window()

	
	change_face(Ragnar2,"Sad")		
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar2)
	message("MA_01C900_130032")
	close_speech_window()

	
	change_face(Noir2,"Serious")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_130033")
	close_speech_window()

	
	change_face(Ragnar2,"Anger")	
	open_speech_window("CHRNAME_RAGNAR2",nil,Ragnar2)
	message("MA_01C900_130034")
	close_speech_window()

	
	change_face(Gawain1,"Pain")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130035")
	close_speech_window()

	
	
	on_active(Ef_Portal_E1)
	on_active(Ef_Portal_E2)
	on_active(Ef_Portal_E3)
	on_active(Ef_Portal_E4)
	on_active(Ef_Portal_E5)
	on_active(Ef_Portal_E6)
	on_active(Ef_Portal_E7)
	on_active(Ef_Portal_E8)
	on_active(Ef_Portal_E9)
	on_active(Ef_Portal_E10)
	
	local gridpos=get_grid_position(13,11)
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	
	local gridpos=get_grid_position(14,11)
	set_pos(Ef_Portal_E2,gridpos)
	set_scale(Ef_Portal_E2,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E2)
	
	local gridpos=get_grid_position(15,11)
	set_pos(Ef_Portal_E3,gridpos)
	set_scale(Ef_Portal_E3,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E3)
	
	local gridpos=get_grid_position(16,11)
	set_pos(Ef_Portal_E4,gridpos)
	set_scale(Ef_Portal_E4,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E4)
	
	local gridpos=get_grid_position(17,11)
	set_pos(Ef_Portal_E5,gridpos)
	set_scale(Ef_Portal_E5,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E5)
	
	local gridpos=get_grid_position(13,15)
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	
	local gridpos=get_grid_position(14,15)
	set_pos(Ef_Portal_E7,gridpos)
	set_scale(Ef_Portal_E7,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E7)
	
	local gridpos=get_grid_position(15,15)
	set_pos(Ef_Portal_E8,gridpos)
	set_scale(Ef_Portal_E8,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E8)
	
	local gridpos=get_grid_position(16,15)
	set_pos(Ef_Portal_E9,gridpos)
	set_scale(Ef_Portal_E9,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E9)
	
	local gridpos=get_grid_position(17,15)
	set_pos(Ef_Portal_E10,gridpos)
	set_scale(Ef_Portal_E10,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E10)
	
	wait_time(0.2)
	dot_disp_unit(barbaroi1,true)
	dot_disp_unit(barbaroi2,true)
	dot_disp_unit(barbaroi3,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)
	dot_disp_unit(barbaroi9,true)
	dot_disp_unit(barbaroi10,true)
	
	wait_time(2.0)
	
	change_face(Gawain1,"Serious")	
	open_speech_window("CHRNAME_GAWAIN",nil,Gawain1)
	message("MA_01C900_130037")
	close_speech_window()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,10,13,0)
	pbadv_setup_101012_Dinatan_preload(0,true,10,12,0)
	pbadv_setup_101032_Gareth_preload(0,true,9,13,0)
	pbadv_setup_101033_Lyoness_preload(0,true,9,12,0)
	pbadv_setup_101051_Lucius_preload(0,true,9,14,0)
	pbadv_setup_101022_Mordred_preload(0,true,8,13,0)
	pbadv_setup_101023_Clarice_preload(0,true,8,12,0)
	pbadv_setup_101018_Ragnar_preload(2,true, 17, 12,0)
	pbadv_setup_101013_Gawain_preload(1,true,16,13,0)
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
end
