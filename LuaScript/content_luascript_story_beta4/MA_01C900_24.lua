

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "MovieFunctions")



function Load()
	Load_common(true)
	
	
	init_psbattleadv("201170000","201170000")	
	change_time_and_weather(BattleTime_Eclipse,BattleWeather_Eclipse)
	
	stillAnime = load_ui_effect("content_still_10104009_anim", "10104009_StillAnim", nil, nil, nil, "Root")


	pbadv_setup_101009_Noir(2,true,6,5,0)
	
	pbadv_setup_101012_Dinatan(1,true,5,6,0)
	pbadv_setup_101012_Dinatan(0,true,39,39,0)
	
	pbadv_setup_101051_Lucius(0,true,4,4,0)
	
	pbadv_setup_101022_Mordred(0,true,8,5,0)
	
	pbadv_setup_101042_Moronoe(true,3,5,0)
	
	pbadv_setup_101044_Gliten(true,9,4,0)	

	pbadv_setup_101045_Glitonea(true,3,4,0)	

	pbadv_setup_101046_Gliton(true,9,5,0)	
	
	pbadv_setup_101015_Arthur(1,true,40,40,0)
	pbadv_setup_101015_Arthur(2,true,6,3,0)
	
	
	dotArthur_D=dot_reserve_ally(201021001,5,2,0)
	dot_set_weapon(dotArthur_D,101010001)

	barbaroi1 = dot_reserve_enemy(303, 9, 3, 0)	
	barbaroi2 = dot_reserve_enemy(304, 8, 4, 0)	
	barbaroi3 = dot_reserve_enemy(504, 8, 5, 0)	
	barbaroi4 = dot_reserve_enemy(1, 8, 6, 0)
	barbaroi5 = dot_reserve_enemy(1, 9, 7, 0)
	barbaroi6 = dot_reserve_enemy(1, 2, 3, 0)
	barbaroi7 = dot_reserve_enemy(1, 1, 4, 0)
	barbaroi8 = dot_reserve_enemy(1, 2, 5, 0)

	
	
	setup_complete_unit()
	
	
	
	dot_unit_dir(dotNoir2,0)
	dot_unit_dir(dotDinatan1,2)
	dot_unit_dir(dotLucius,2)
	dot_unit_dir(dotArthur2,2)
	dot_unit_dir(dotMoronoe,3)
	dot_unit_dir(dotGliten,2)
	dot_unit_dir(dotGlitonea,3)
	dot_unit_dir(dotGliton,2)
	dot_unit_dir(dotArthur_D,2)


	dot_disp_unit(dotArthur1,false)
	dot_disp_unit(dotArthur_D,false)

	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi3,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi6,false)
	dot_disp_unit(barbaroi7,false)
	dot_disp_unit(barbaroi8,false)
	
	
	change_camera_distance(8.0,0.0)
	
	
	change_camera_angle(25.0,0.0)
	
	
	move_camera(6,4,0.0)
	
	load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image("103040040", "content_still_10304004_image", "103040040_StillImage")
	load_image("103040050", "content_still_10304005_image", "103040050_StillImage")
	load_image("103040060", "content_still_10304006_image", "103040060_StillImage")

	
	Ef_Die_W1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	Ef_Die_W2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	Ef_Die_W3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	Ef_Die_W4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	Ef_Flash1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)

	Ef_Roar01=load_particle("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)

	Ef_WitchSpear1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)

	Ef_WSpearAppea1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)

	Ef_WSpearAura1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)

	Ef_WitchSpearHit1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)

	Ef_bar1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar4 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar5 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar6 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar7 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	Ef_bar8 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)

	Ef_spout = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)

	Ef_Killers_Cancel=load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)

	Ef_Slash01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, false)
	
	movie_load("MA_01C900_24")

	load_image("10104021",  "content_still_10104021_image", "101040210_StillImage")

	load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
	Ef_WhiteDragon_A=load_particle("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Appearance",false,true)
	Ef_WhiteDragon_Flash=load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	Ef_DimensionHole=load_particle("content_effect3d_common_adv","Ef_C_Adv_DimensionHole",false,true)

end


function NoirMoveSet() 
	dot_target_attack(dotNoir2,dotArthur2,false)
	dot_change_anim(dotArthur2,6)
	wait_time(0.1)
	dot_change_anim(dotArthur2,0)

	wait_time(0.5)
	
	dot_move_unit(dotNoir2,6,4)

end

function ArthurMoveSet() 
	dot_target_attack(dotArthur2,dotNoir2,false)
	dot_change_anim(dotNoir2,6)
	wait_time(0.1)
	dot_change_anim(dotNoir2,0)
	dot_unit_dir(dotArthur2, 2)

	wait_time(0.5)

end


function MordredMoveSet() 
	dot_target_attack(dotMordred,dotGliton,false)

	local signal1 = dot_damage(dotGliten,dotMordred,false)
	wait_proccess(signal1)
	
	dot_change_anim(dotGliton,6)
	dot_change_anim(dotGliten,6)
	wait_time(0.1)
	dot_change_anim(dotMordred,0)

	wait_time(0.5)

end

function LuciusMoveSet() 
	dot_target_attack(dotLucius,dotGlitonea,false)
	local signal2 = dot_damage(dotMoronoe,dotLucius,false)
	wait_proccess(signal2)

	dot_change_anim(dotGlitonea,6)
	wait_time(0.1)
	dot_change_anim(dotLucius,0)
	dot_change_anim(dotMoronoe,6)

	wait_time(0.5)
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	wait_time(0.5)

	local NoirSet = create_coroutine(NoirMoveSet) 
	local ArthurSet = create_coroutine(ArthurMoveSet) 
	local MordredSet = create_coroutine(MordredMoveSet) 
	local LuciusSet = create_coroutine(LuciusMoveSet) 
	
	
	coroutine.resume(NoirSet)  
	coroutine.resume(ArthurSet)  
	wait_time(0.2)
	coroutine.resume(MordredSet)  
	coroutine.resume(LuciusSet)  
	


	pbadv_wait_coroutine(NoirSet) 
	pbadv_wait_coroutine(ArthurSet) 
	pbadv_wait_coroutine(MordredSet) 
	pbadv_wait_coroutine(LuciusSet) 
	

	dot_change_anim(dotDinatan1,0)
	dot_change_anim(dotLucius,0)
	dot_change_anim(dotMoronoe,1)
	dot_change_anim(dotGliton,1)
	dot_change_anim(dotGliten,1)
	dot_change_anim(dotGlitonea,1)
	
	
	dot_attack_seq(dotArthur2,dotNoir2)
	dot_damage_seq(dotNoir2,dotArthur2,true)
	
	
	wait_seq()

	dot_change_anim(dotNoir2,6)

	dot_move_knockback(dotNoir2,6,6,0.2,2)

	dot_change_anim(dotNoir2,1)
	wait_time(0.5)
	dot_change_anim(dotArthur2,0)

	dot_unit_dir(dotArthur2, 2)
	dot_unit_dir(dotLucius, 3)
	dot_unit_dir(dotMordred, 2)
	
	
	
	change_face(Lucius,"Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_240002")
	close_speech_window()

	dot_unit_dir(dotDinatan1,3)

	
	dot_move_unit_seq(dotLucius,6,4)
	wait_seq()

	dot_attack_seq(dotArthur2,dotLucius)
	dot_damage_seq(dotLucius,dotArthur2,true)
	wait_seq()

	dot_change_anim(dotLucius,6)

	dot_move_knockback(dotLucius,6,5,0.2,2)

	dot_change_anim(dotArthur2,0)
	dot_unit_dir(dotArthur2, 2)
	dot_change_anim(dotLucius,1)
	
	
	change_face(Arthur2,"Surprise")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240004")
	close_speech_window()

	
	dot_move_unit_seq(dotMordred,7,3)
	wait_seq()
	dot_unit_dir(dotMordred, 2)
	wait_time(0.5)

	dot_attack_seq(dotMordred,dotArthur2)
	dot_damage_seq(dotArthur2,dotMordred,false)
	wait_seq()
	dot_change_anim(dotArthur2,6)
	
	
	change_face(Mordred,"Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_240006")
	close_speech_window()
	dot_change_anim(dotMordred,0)
	dot_change_anim(dotArthur2,1)

	
	change_face(Arthur2,"Pain")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240007")
	close_speech_window()
	dot_change_anim(dotLucius,0)

	
	on_active(Ef_Die_W1)
	on_active(Ef_Die_W2)
	on_active(Ef_Die_W3)
	on_active(Ef_Die_W4)
	local gridpos=get_grid_position(9,4)
	set_pos(Ef_Die_W1,gridpos)
	play_particle(Ef_Die_W1)
	local gridpos=get_grid_position(3,4)
	set_pos(Ef_Die_W2,gridpos)
	play_particle(Ef_Die_W2)
	local gridpos=get_grid_position(9,5)
	set_pos(Ef_Die_W3,gridpos)
	play_particle(Ef_Die_W3)
	local gridpos=get_grid_position(3,5)
	set_pos(Ef_Die_W4,gridpos)
	play_particle(Ef_Die_W4)
	
	wait_time(1.0)
	dot_remove_unit(dotMoronoe)
	dot_remove_unit(dotGlitonea)
	dot_remove_unit(dotGliten)
	dot_remove_unit(dotGliton)
	wait_time(2.0)
	move_camera(6,4,0.1)
	wait_time(0.4)
	dot_change_anim(dotArthur2,0)
	dot_unit_dir(dotArthur2, 3)
	dot_unit_dir(dotDinatan1,3)
	wait_time(1.5)
	
	
	change_face(Mordred,"Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_240009")
	close_speech_window()

	
	change_face(Arthur2,"Serious")	
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240010")
	close_speech_window()

	
	dot_play_particle_unit(dotArthur2,"Ef_C_Buf_Heal01",2,true)
	
	
	change_face(Lucius,"Surprise")	
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_240012")
	close_speech_window()

	
	change_face(Arthur2,"Smile")	
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240013")

	
	change_face(Arthur1, "Normal")
	message("MA_01C900_240014")
	close_speech_window()

	
	change_face(Mordred,"Pain")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_240015")
	close_speech_window()

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240016")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240017")
	close_speech_window()

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240018")

	
	change_face(Arthur2,"Sad")
	message("MA_01C900_240019")
	close_speech_window()

	
	change_face(Dinatan1,"Surprise")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C900_240020")
	close_speech_window()

	
	change_face(Arthur2,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240022")

	
	change_face(Arthur2,"Anger")
	message("MA_01C900_240023")

	
	change_face(Arthur2,"Anger")
	message("MA_01C900_240024")
	close_speech_window()

	
	open_cutin(3,1)
	on_cutin(1,Lucius,"Surprise",1)
	on_cutin(2,Noir2,"Surprise",1)
	on_cutin(3,Mordred,"Surprise",1)
	wait_time(1.0)
	close_cutin()
	wait_time(0.8)
	
	
	change_face(Lucius,"Smile")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_240026")
	close_speech_window()

	
	change_face(Arthur2,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240027")
	close_speech_window()

	dot_attack_seq(dotArthur2,dotLucius)
	dot_damage_seq(dotLucius,dotArthur2,false)
	wait_seq()
	dot_change_anim(dotLucius,6)

	
	change_face(Lucius,"Anger")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_240028")
	close_speech_window()

	
	wait_time(1.0)
	
	
	dot_change_anim(dotArthur2,6)
	dot_attack_seq(dotLucius,dotArthur2)
	dot_damage_seq(dotArthur2,dotLucius,true)
	wait_seq()
	dot_change_anim(dotArthur2,6)

	
	change_face(Arthur2,"Pain")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240030")
	close_speech_window()

	
	dot_change_anim(dotArthur2,0)
	dot_change_anim(dotLucius,1)
	wait_time(0.7)
	
	
	change_face(Lucius,"Sad")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	message("MA_01C900_240032")
	close_speech_window()

	
	change_face(Arthur2, "Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240034")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Lucius,"Normal",0)
	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",nil,nil)
	message("MA_01C900_240035")

	on_cutin(1,Lucius,"Anger",0)
	
	change_face(Lucius,"Anger")
	message("MA_01C900_240036")
	close_speech_window()
	close_cutin()
	
	wait_time(0.0)

	
	dot_attack_seq(dotArthur2,dotLucius)
	dot_damage_seq(dotLucius,dotArthur2,true)
	wait_seq()

	dot_move_knockback(dotLucius,4,5,0.2,2)
	dot_change_anim(dotLucius,6)
	
	wait_time(0.2)
	
	dot_change_anim(dotLucius,1)
	
	
	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240038")
	close_speech_window()


	
	dot_unit_dir(dotNoir2,2)
	wait_time(0.5)

	dot_reserve_move_unit_seq(dotDinatan1,5,5)
	dot_reserve_move_unit_seq(dotNoir2,6,5)
	dot_reserve_move_unit_seq(dotArthur2,6,4)
	exec_parallel_seq()
	wait_seq()

	


	dot_change_anim(dotArthur2,3)

	on_active(Ef_Slash01)

	
	local gridpos = get_grid_position(6,4)
	set_pos(Ef_Slash01, gridpos)
	play_particle(Ef_Slash01)

	wait_time(0.3)

	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",1,true)
	dot_play_particle_unit(dotDinatan1,"Ef_C_Cmn_N_Hit_Sla01",1,true)

	dot_change_anim(dotNoir2,6)
	dot_change_anim(dotDinatan1,6)

	wait_time(0.3)



	dot_move_knockback(dotDinatan1,5,9,0.3,2)
	dot_move_knockback(dotNoir2,6,9,0.3,2)
	wait_time(0.3)
	

	move_camera(6,8,0.5)
	wait_camera()

	dot_change_anim(dotArthur2,0)
	dot_change_anim(dotNoir2,1)
	dot_change_anim(dotDinatan1,1)
	wait_time(0.5)

	local gridpos=get_grid_position(5,9)
	on_active(Ef_Killers_Cancel)
	set_pos(Ef_Killers_Cancel,gridpos)
	play_particle(Ef_Killers_Cancel)
	wait_time(0.6)
	dot_change_unit(dotDinatan1,dotDinatan,0.0)
	dot_change_anim(dotDinatan,1)
	wait_time(1.5)

	
	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240040")
	close_speech_window()


	wait_time(1.5)
	
	dot_move_unit_seq(dotArthur2,6,6)
	wait_time(0.1)
	dot_move_unit_seq(dotMordred,7,6)
	wait_seq()

	
	dot_unit_dir(dotMordred,2)
	dot_unit_dir(dotArthur2,3)
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotMordred)

	wait_time(0.5)

	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotArthur2)

	wait_seq()

	
	change_face(Mordred,"Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_240042")
	close_speech_window()

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotMordred)
	
	wait_time(0.5)

	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotArthur2)
	wait_seq()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240043")
	close_speech_window()

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotMordred)
	
	wait_time(0.5)
	
	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotArthur2)
	wait_seq()

	
	change_face(Arthur2,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240044")
	close_speech_window()

	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotMordred)
	
	wait_time(0.5)

	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotArthur2)
	wait_seq()

	open_cutin(1,1)
	on_cutin(1,Mordred,"Serious",0)
	
	
	open_speech_window("CHRNAME_MORDRED",nil,nil)
	message("MA_01C900_240045")
	
	
	change_face(Mordred,"Serious")
	message("MA_01C900_240046")

	
	
	change_face(Mordred,"Serious")
	message("MA_01C900_240047")

	
	
	
	message("MA_01C900_240048")
	close_speech_window()

	close_cutin()	
	wait_time(0.2)

	
	dot_attack_seq(dotMordred,dotArthur2)
	dot_damage_seq(dotArthur2,dotMordred,true)
	wait_seq()
	dot_change_anim(dotArthur2,6)
	wait_time(2.5)
	
	dot_change_anim(dotMordred,0)
	dot_change_anim(dotArthur2,1)
	

	
	change_face(Arthur2,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240051")
	close_speech_window()

	dot_play_particle_unit(dotArthur2,"Ef_C_Buf_Heal01",2,true)
	wait_time(0.2)
	
	dot_change_anim(dotArthur2,0)
	wait_time(0.5)
	
	
	change_face(Mordred,"Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_240052")

	
	change_face(Mordred,"Anger")
	message("MA_01C900_240053")

	
	change_face(Mordred,"Anger")
	message("MA_01C900_240054")
	
	
	change_face(Mordred,"Anger")
	message("MA_01C900_240055")
	close_speech_window()
	
	
	change_face(Arthur2,"Surprise")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240056")
	close_speech_window()

	
	wait_time(1.0)
	
	dot_change_anim(dotArthur2,3)
	dot_play_particle_unit(dotMordred,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotMordred)

	wait_time(0.5)

	dot_change_anim(dotMordred,3)
	dot_play_particle_unit(dotArthur2,"Ef_C_Swd_N_Atk01",3,true)
	wait_time(0.1)
	dot_dodge_seq(dotArthur2)
	wait_seq()
	
	dot_change_anim(dotMordred,0)
	
	
	change_face(Mordred,"Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("MA_01C900_240058")

	
	change_face(Mordred,"Pain")
	message("MA_01C900_240059")
	close_speech_window()

	
	dot_change_anim(dotMordred,3)

	dot_change_anim(dotArthur2,0)

	
	on_active(Ef_WSpearAppea1) 

	local gridpos = get_grid_position(8, 6) 
	gridpos[2] = 2.5	
	set_pos(Ef_WSpearAppea1, gridpos)
	turn(Ef_WSpearAppea1,0, 90, 0, 0.0) 
	play_particle(Ef_WSpearAppea1)

	wait_time(0.5)
	
	on_active(Ef_WitchSpear1) 

	local gridpos = get_grid_position(8, 6)
	gridpos[2] = 2.5 
	set_pos(Ef_WitchSpear1, gridpos)
	turn(Ef_WitchSpear1,0, 90, 0, 0.0) 
	play_particle(Ef_WitchSpear1)


	on_active(Ef_WSpearAura1) 

	set_pos(Ef_WSpearAura1, gridpos)
	turn(Ef_WSpearAura1,0, 100, 0, 0.0) 
	play_particle(Ef_WSpearAura1)
	
	

	wait_time(1.0)

	local gridpos = get_grid_position(7, 6) 
	gridpos[2] = 2.5

	slidemove(Ef_WitchSpear1, gridpos, 0.1) 
	slidemove(Ef_WSpearAura1, gridpos, 0.1) 

	wait_time(0.1)

	on_active(Ef_WitchSpearHit1) 

	local gridpos = get_grid_position(7, 6)
	set_pos(Ef_WitchSpearHit1, gridpos)
	play_particle(Ef_WitchSpearHit1)

	dot_change_anim(dotMordred,6)
	dot_play_particle_unit(dotMordred,"Ef_C_Cmn_N_Hit_Sla01",3,true)

	

	wait_time(1.5)

	
	show_image("10104021", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
	wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)

	
	open_simple_window("CHRNAME_MORDRED",nil,nil)
	message("MA_01C900_240061")
	close_simple_window()

	
	open_simple_window("CHRNAME_ARTHUR",nil,nil)
	message("MA_01C900_240062")



	stop_particle(Ef_WitchSpear1)
	stop_particle(Ef_WSpearAura1)

	
	dot_change_anim(dotArthur2,0)
	dot_change_anim(dotMordred,1)
	

	
	message("MA_01C900_240064")
	close_simple_window()

	
	open_simple_window("CHRNAME_NOIR",nil,nil)
	message("MA_01C900_240065")
	close_simple_window()


	open_simple_window("CHRNAME_MORDRED",nil,nil)
	message("MA_01C900_240066")

	
	message("MA_01C900_240067")
	close_simple_window()

	hide_image(STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
	
	dot_play_particle_unit(dotMordred,"Ef_C_Cmn_Die01",2,true)
	wait_time(0.5)

	dot_disp_unit(dotMordred, false)
	
	wait_time(1.0)
	move_camera(6,8,1.5)
	dot_remove_unit(dotMordred)

	
	change_face(Arthur2,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur2)
	message("MA_01C900_240069")

	
	change_face(Arthur2,"Anger")
	message("MA_01C900_240070")
	
	
	wait_time(0.5)
	dot_change_anim(dotArthur2,1)
	wait_time(1.0)
	dot_change_anim(dotArthur2,0)
	wait_time(0.3)
	
	
	change_face(Arthur2,"Surprise")
	message("MA_01C900_240072")
	
	dot_unit_dir(dotArthur2,2)

	
	change_face(Arthur2,"Normal")
	message("MA_01C900_240073")

	
	change_face(Arthur2,"Smile")
	message("MA_01C900_240074")
	close_speech_window()

	close_textbox_base()
	disableTextBox = true

	on_active(Ef_Flash1)
	local gridpos=get_grid_position(6,6)
	set_pos(Ef_Flash1,gridpos)
	play_particle(Ef_Flash1)

	wait_time(0.3)

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
	se_play("SE_ADV_MA_01A900_25_Earthquake_loop")
	wait_time(1.5)


	show_image("103040040", 0.0, 0.0, 0.0,true,false)
	fadein(1.5)
	wait_time(2)

	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(2)

	show_image("103040050", 0.0, 0.0, 0.0,true,false)
	fadein(1.5)
	wait_time(2)

	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(2)


	show_image("103040060", 0.0, 0.0, 0.0,true,false)
	fadein(1.5)
	wait_time(2)

	fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
	wait_time(2)

	hide_image(0)
	fadein(2)
	se_play("SE_ADV_Loop_Stop")
	wait_time(2.5)
	
	on_active(Ef_Flash1)
	local gridpos=get_grid_position(6,6)
	set_pos(Ef_Flash1,gridpos)
	play_particle(Ef_Flash1)

	wait_time(0.5)

	on_active(Ef_bar1) 

	local gridpos = get_grid_position(9, 3) 
	set_pos(Ef_bar1, gridpos)
	set_scale(Ef_bar1, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar1)

	on_active(Ef_bar2) 

	local gridpos = get_grid_position(8, 4) 
	set_pos(Ef_bar2, gridpos)
	set_scale(Ef_bar2, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar2)

	on_active(Ef_bar3) 

	local gridpos = get_grid_position(8, 5) 
	set_pos(Ef_bar3, gridpos)
	set_scale(Ef_bar3, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar3)

	on_active(Ef_bar4) 

	local gridpos = get_grid_position(8, 6) 
	set_pos(Ef_bar4, gridpos)
	set_scale(Ef_bar4, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar4)

	on_active(Ef_bar5) 

	local gridpos = get_grid_position(9, 7) 
	set_pos(Ef_bar5, gridpos)
	set_scale(Ef_bar5, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar5)

	on_active(Ef_bar6) 

	local gridpos = get_grid_position(2, 3) 
	set_pos(Ef_bar6, gridpos)
	set_scale(Ef_bar6, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar6)

	on_active(Ef_bar7) 

	local gridpos = get_grid_position(1, 4) 
	set_pos(Ef_bar7, gridpos)
	set_scale(Ef_bar7, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar7)

	on_active(Ef_bar8) 

	local gridpos = get_grid_position(2, 5) 
	set_pos(Ef_bar8, gridpos)
	set_scale(Ef_bar8, {0.8, 0.8, 0.8}) 
	play_particle(Ef_bar8)
	
	wait_time(0.2)
        
	dot_disp_unit(barbaroi1,true)
	dot_disp_unit(barbaroi2,true)
	dot_disp_unit(barbaroi3,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)

	wait_time(2.0)

	dot_reserve_move_unit_seq(barbaroi1, 5, 5)
	dot_reserve_move_unit_seq(barbaroi2, 6, 5)
	dot_reserve_move_unit_seq(barbaroi3, 7, 5)
	dot_reserve_move_unit_seq(barbaroi4, 5, 6)
	dot_reserve_move_unit_seq(barbaroi5, 7, 6)
	dot_reserve_move_unit_seq(barbaroi6, 5, 7)
	dot_reserve_move_unit_seq(barbaroi7, 6, 7)
	dot_reserve_move_unit_seq(barbaroi8, 7, 7)

	
	exec_parallel_seq()

	
	wait_seq()

	dot_unit_dir(barbaroi4, 3)
	dot_unit_dir(barbaroi8, 2)
	dot_unit_dir(barbaroi1, 3)
		
	
	wait_time(2.0)

	on_active(Ef_Flash1)
	local gridpos=get_grid_position(6,6)
	set_pos(Ef_Flash1,gridpos)
	play_particle(Ef_Flash1)
	

	wait_time(0.2)

	local gridpos = get_grid_position(6, 6)
	set_pos(Ef_spout, gridpos)

	on_active(Ef_spout)
	play_particle(Ef_spout)

	dot_change_unit(dotArthur2,dotArthur1,0)
	dot_remove_unit(barbaroi1)
	dot_remove_unit(barbaroi2)
	dot_remove_unit(barbaroi3)
	dot_remove_unit(barbaroi4)
	dot_remove_unit(barbaroi5)
	dot_remove_unit(barbaroi6)
	dot_remove_unit(barbaroi7)
	dot_remove_unit(barbaroi8)

	

	wait_time(FADE_TIME)

	disableTextBox = false
	open_textbox_base()
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240080")
	close_speech_window()

	
	
	change_face(Arthur1,"Pain")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240081")

	
	
	change_face(Arthur1,"Pain")
	message("MA_01C900_240083")
	close_speech_window()

	
	change_face(Dinatan,"Pain")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_240085")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Arthur1,"Anger",0)
	
	
	open_speech_window("CHRNAME_ARTHUR",nil,nil)
	message("MA_01C900_240086")

	
	change_face(Arthur1,"Anger")	
	message("MA_01C900_240087")




	
	
	
	message("MA_01C900_240088")
	close_speech_window()

	close_cutin()	
	
	close_textbox_base()
	disableTextBox = true

	off_active(Ef_Die_W1)
	off_active(Ef_Die_W2)
	off_active(Ef_Die_W3)
	off_active(Ef_Die_W4)
	off_active(Ef_Flash1)
	off_active(Ef_WitchSpear1)
	off_active(Ef_WSpearAppea1)
	off_active(Ef_WSpearAura1)
	off_active(Ef_WitchSpearHit1)
	off_active(Ef_bar1)
	off_active(Ef_bar2)
	off_active(Ef_bar3)
	off_active(Ef_bar4)
	off_active(Ef_bar5)
	off_active(Ef_bar6)
	off_active(Ef_bar7)
	off_active(Ef_bar8)
	off_active(Ef_Killers_Cancel)
	off_active(Ef_Slash01)	

	movie_set_active(true)
	
	
	movie_play()

	movie_wait_playing()
	movie_stop()
	

	wait_time(MOVIE_AFTER)
	
	disableTextBox = false
	open_textbox_base()

	open_cutin(1,1)
	on_cutin(1,Arthur1,"Serious",0)
	
	change_face(Arthur1,"Serious")	
	open_speech_window("CHRNAME_ARTHUR",nil,nil)
	
	message("MA_01C900_240090")
	
	message("MA_01C900_240092")

	
	message("MA_01C900_240093")
	

	close_cutin()	
	
	change_face(Dinatan,"Pain")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("MA_01C900_240094")
	close_speech_window()

	
	change_face(Arthur1,"Smile")	
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240095")

	
	change_face(Arthur1,"Normal")
	message("MA_01C900_240096")

	
	message("MA_01C900_240097")

	
	change_face(Arthur1,"Smile")
	message("MA_01C900_240098")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240099")
	close_speech_window()

	
	
	change_face(Arthur1,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240100")

	
	change_face(Arthur1,"Smile")
	message("MA_01C900_240102")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240103")
	close_speech_window()

	
	change_face(Arthur1,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240104")
	close_speech_window()

	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240105")
	close_speech_window()

	
	change_face(Arthur1,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240106")
	close_speech_window()

	
	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240107")

	
	
	change_face(Noir2,"Serious")
	message("MA_01C900_240108")
	close_speech_window()

	
	change_face(Arthur1,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240110")
	close_speech_window()

	
	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240111")
	close_speech_window()

	
	change_face(Arthur1,"Smile")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240113")
	close_speech_window()

	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240114")

	
	change_face(Noir2,"Anger")
	message("MA_01C900_240115")

	
	change_face(Noir2,"Pain")
	message("MA_01C900_240117")
	close_speech_window()

	
	change_face(Arthur1,"Sad")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240118")

	
	change_face(Arthur1,"Serious")
	message("MA_01C900_240119")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240120")
	close_speech_window()

	
	change_face(Arthur1,"Anger")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240121")
	close_speech_window()

	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240122")

	
	change_face(Noir2,"Normal")
	message("MA_01C900_240124")
	
	
	change_face(Noir2,"Sad")
	message("MA_01C900_240125")
	close_speech_window()
	
	close_textbox_base()
	disableTextBox = true

	
	
	show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
	set_scale_image(20,20)

	wait_time(BLACK_WHITE_WAIT_TIME)
	
	dot_disp_unit(dotArthur_D, true)

	hide_image(STILL_SWITCH_TIME) 
	
	
	
	stillAnime.SetActive(true)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	disableTextBox = false
	open_textbox_base()
	
	change_face(Noir2,"Surprise")
	open_simple_window("CHRNAME_NOIR",nil,nil)
	message("MA_01C900_240127")
	close_simple_window()

	
	change_face(Arthur1,"Sad")
	open_simple_window("CHRNAME_ARTHUR",nil,nil)
	message("MA_01C900_240128")
	close_simple_window()

	
	se_play("SE_ADV_MA_01C900_24_WhiteDrg_Fly")		

	se_play("SE_ADV_MA_01A112_31_Earthquake")	
		
	
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
	fadeout(0, 0, 0, 0, 0.5)
	wait_time(0.5)
	stillAnime.SetActive(false)
	fadein(BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C900_240129")
	close_speech_window()

	
	change_face(Arthur1,"Normal")
	open_speech_window("CHRNAME_ARTHUR",nil,Arthur1)
	message("MA_01C900_240130")

	
	message("MA_01C900_240131")

	
	change_face(Arthur1,"Serious")
	message("MA_01C900_240132")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_LongFade")

	
	dot_change_anim(dotArthur_D,3)

	on_active(Ef_Roar01)
	local gridpos=get_grid_position(6,5)
	set_pos(Ef_Roar01,gridpos)
	play_particle(Ef_Roar01)
	
	wait_time(1.5)

	
	fadeout(0,0,0,1,1.0)

	wait_time(1.0)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_ui_effect_preload("content_still_10104009_anim", "10104009_StillAnim", nil, nil, nil, "Root")
	pbadv_setup_101009_Noir_preload(2,true,6,5,0)
	pbadv_setup_101012_Dinatan_preload(1,true,5,6,0)
	pbadv_setup_101012_Dinatan_preload(0,true,39,39,0)
	pbadv_setup_101051_Lucius_preload(0,true,4,4,0)
	pbadv_setup_101022_Mordred_preload(0,true,8,5,0)
	pbadv_setup_101042_Moronoe_preload(true,3,5,0)
	pbadv_setup_101044_Gliten_preload(true,9,4,0)
	pbadv_setup_101045_Glitonea_preload(true,3,4,0)
	pbadv_setup_101046_Gliton_preload(true,9,5,0)
	pbadv_setup_101015_Arthur_preload(1,true,40,40,0)
	pbadv_setup_101015_Arthur_preload(2,true,6,3,0)
	load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	load_image_preload("103040040", "content_still_10304004_image", "103040040_StillImage")
	load_image_preload("103040050", "content_still_10304005_image", "103040050_StillImage")
	load_image_preload("103040060", "content_still_10304006_image", "103040060_StillImage")
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Die_Witch",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Roar01",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_PivotTip_018", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_Appearance", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Witch_Spr_AtkAura", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Spe", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_spout", false, true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, false)
	movie_load_preload("MA_01C900_24")
	load_image_preload("10104021",  "content_still_10104021_image", "101040210_StillImage")
	load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_WhiteDragon_Appearance",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_DimensionHole",false,true)
end
