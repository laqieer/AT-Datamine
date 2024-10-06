Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	
	
	
	init_psbattleadv("201030000","201030000")
	
	
	
	pbadv_setup_101009_Noir(2,true,12,34,0)
	
	pbadv_setup_101012_Dinatan(1,true,13,34,0)
	
	pbadv_setup_101032_Gareth(0,true,12,33,0)
	
	pbadv_setup_101033_Lyoness(1,true,13,33,0)
	
	pbadv_setup_101017_Maladisant(1,true,14,33,0)
	
	dotTyunenB=dot_reserve_ally(401011001,3,32,0)
	dot_set_weapon(dotTyunenB,101010001)
	
	barbaroi1=dot_reserve_enemy(500,2,35,0)
	barbaroi2=dot_reserve_enemy(1301,2,36,0)
	barbaroi3=dot_reserve_enemy(1104,3,35,0)
	barbaroi4=dot_reserve_enemy(600,3,36,0)
	barbaroi5=dot_reserve_enemy(500,4,35,0)
	barbaroi6=dot_reserve_enemy(1301,4,36,0)
	barbaroi7=dot_reserve_enemy(600,5,35,0)
	barbaroi8=dot_reserve_enemy(1301,5,36,0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	
	
	
	dot_disp_weapon(dotTyunenB,false)
	
	
	
	dot_disp_unit(dotLyoness1,false)
	dot_disp_unit(dotGareth,false)
	dot_disp_unit(dotNoir2,false)
	dot_disp_unit(dotMaladisant1,false)
	dot_disp_unit(dotDinatan1,false)
	dot_disp_unit(barbaroi1,false)
	dot_disp_unit(barbaroi2,false)
	dot_disp_unit(barbaroi4,false)
	dot_disp_unit(barbaroi5,false)
	dot_disp_unit(barbaroi6,false)
	dot_disp_unit(barbaroi7,false)
	dot_disp_unit(barbaroi8,false)
	
	
	
	
	change_camera_distance(8.0,0.0)
	
	
	
	change_camera_angle(25.0,0.0)
	
	
	
	move_camera(3,34,0.0)
	
	
	Ef_Portal_E1=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_Portal_E2=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_Portal_E3=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_Portal_E4=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_Portal_E5=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_Portal_E6=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
	Ef_Portal_E7=load_particle("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true) 
end





function Play()
	fadein(0)
	Play_start(true)

	
	
	
	
	
	open_speech_window("NPCNAME_0086",nil,nil)
	 --PlayPartVoice("市民_男2", "悲しみ")
	message("MA_01C111_120002")
	close_speech_window()
	
	
	
	change_face(Lyoness1,"Anger")
	open_speech_window("CHRNAME_LYONESS2",Lyoness1,nil)
	 --PlayPartVoice("リオネス", "気合い")
	message("MA_01C111_120003")
	close_speech_window()
	
	dot_move_unit_seq(barbaroi3,3,34)
	
	
	dot_disp_unit(dotLyoness1,true)
	dot_move_unit_seq(dotLyoness1,3,33)
	
	wait_time(0.2)
	
	dot_attack_seq(dotLyoness1,barbaroi3)
	dot_damage_seq(barbaroi3,dotLyoness1,true)
	
	
	
	
	wait_seq()
	dot_disp_unit(dotGareth,true)
	dot_reserve_move_unit_seq(dotTyunenB,4,31) 
	dot_reserve_move_unit_seq(dotGareth,4,33) 
	exec_parallel_seq()
	dot_change_anim(barbaroi3,6)
	dot_move_knockback(barbaroi3,3,35,0.1,2)
	dot_change_anim(dotLyoness1,0)
	wait_seq()
	dot_change_anim(barbaroi3,0)
	dot_unit_dir(dotGareth,3)
	
	change_face(Gareth,"Surprise")
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	message("MA_01C111_120005")
	close_speech_window()
	
	
	
	on_active(Ef_Portal_E1)
	on_active(Ef_Portal_E2)
	on_active(Ef_Portal_E3)
	on_active(Ef_Portal_E4)
	on_active(Ef_Portal_E5)
	on_active(Ef_Portal_E6)
	on_active(Ef_Portal_E7)
	
	local gridpos=get_grid_position(2,35) 
	set_pos(Ef_Portal_E1,gridpos)
	set_scale(Ef_Portal_E1,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E1)
	local gridpos=get_grid_position(2,36) 
	set_pos(Ef_Portal_E2,gridpos)
	set_scale(Ef_Portal_E2,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E2)
	local gridpos=get_grid_position(3,36) 
	set_pos(Ef_Portal_E3,gridpos)
	set_scale(Ef_Portal_E3,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E3)
	local gridpos=get_grid_position(4,35) 
	set_pos(Ef_Portal_E4,gridpos)
	set_scale(Ef_Portal_E4,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E4)
	local gridpos=get_grid_position(4,36) 
	set_pos(Ef_Portal_E5,gridpos)
	set_scale(Ef_Portal_E5,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E5)
	local gridpos=get_grid_position(5,35) 
	set_pos(Ef_Portal_E6,gridpos)
	set_scale(Ef_Portal_E6,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E6)
	local gridpos=get_grid_position(5,36) 
	set_pos(Ef_Portal_E7,gridpos)
	set_scale(Ef_Portal_E7,{0.8,0.8,0.8})
	play_particle(Ef_Portal_E7)
	
	wait_time(0.2)
	
	dot_disp_unit(barbaroi1,true)
	dot_disp_unit(barbaroi2,true)
	dot_disp_unit(barbaroi4,true)
	dot_disp_unit(barbaroi5,true)
	dot_disp_unit(barbaroi6,true)
	dot_disp_unit(barbaroi7,true)
	dot_disp_unit(barbaroi8,true)
	
	
	dot_disp_unit(dotNoir2,true)
	dot_disp_unit(dotMaladisant1,true)
	dot_disp_unit(dotDinatan1,true)
	
	dot_reserve_move_unit_seq(dotDinatan1,4,32) 
	dot_reserve_move_unit_seq(dotMaladisant1,5,33) 
	dot_reserve_move_unit_seq(dotNoir2,3,32)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotDinatan1,3)
	dot_unit_dir(dotMaladisant1,3)
	
	
	change_face(Maladisant1,"Normal")
	open_speech_window("CHRNAME_MALADISANT2",Maladisant1,nil)
	 --PlayPartVoice("マルディサント", "落胆")
	message("MA_01C111_120007")
	close_speech_window()
	

	
	change_face(Noir2,"Normal")	
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "肯定2")
	message("MA_01C111_120008")
	close_speech_window()

	
	change_face(Dinatan1,"Anger")
	open_speech_window("CHRNAME_DINATAN2",Dinatan1,nil)
	message("MA_01C111_120009")
	close_speech_window()


	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,12,34,0)
	pbadv_setup_101012_Dinatan_preload(1,true,13,34,0)
	pbadv_setup_101032_Gareth_preload(0,true,12,33,0)
	pbadv_setup_101033_Lyoness_preload(1,true,13,33,0)
	pbadv_setup_101017_Maladisant_preload(1,true,14,33,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Portal_Enemy",false,true)
end
