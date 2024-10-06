Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	
	Excelia=set_chara_unknown()
	character2DFull(Excelia,"Excelia",101034001)
	
	
	init_psbattleadv("201060001","201060001")	
	change_time_and_weather(1,1)
	


	pbadv_setup_101009_Noir(2,true,12,19,0)
	
	pbadv_setup_101034_Excelia(0,true,11 ,19 ,0)  --エクセリア
	
	pbadv_setup_101014_Tristan(0,true,10,32,0)
	
	pbadv_setup_101019_Isolde(0,true,10,33,0)
	
	dotbaroi=dot_reserve_ally(401011001,10,28,0)
	dot_set_weapon(dotbaroi,101010001)
	
	
	
	setup_complete_unit()
	
	
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotExcelia,false)
	dot_disp_weapon(dotbaroi,false)



	change_camera_distance(8.0,0.0)
	change_camera_angle(40.0,0.0)
	move_camera(7,21,0.0)
	
	Ef_Aura_Enemy_L=load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true) 

	load_sound("BGM_ADV_Painful2")
	
	
end





function Play()
	fadein(0)
	Play_start(true)

	
	dot_reserve_move_unit_seq(dotNoir2,7,20)
	dot_reserve_move_unit_seq(dotExcelia,6,20)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotNoir2,3)
	dot_unit_dir(dotExcelia,3)
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","挨拶")
	message("CO_101034_06020002")
	close_speech_window()
	
		
		
	
	change_face(Noir2,"Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","納得")
	message("CO_101034_06020004")
	close_speech_window()
	
	
	wait_seq()
	dot_move_unit_seq(dotbaroi,9,22)
	wait_seq()
	dot_unit_dir(dotbaroi,2)
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	PlayPartVoice("市民中年_男1","挨拶")
	message("CO_101034_06020006")
	close_speech_window()

	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","挨拶")
	message("CO_101034_06020007")
	close_speech_window()
	
	
	change_face(Excelia,"Smile")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定2")
	message("CO_101034_06020008")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	PlayPartVoice("市民中年_男1","肯定")
	message("CO_101034_06020009")
	close_speech_window()
	
	
	change_face(Excelia,"Smile")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定")
	message("CO_101034_06020010")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	PlayPartVoice("市民中年_男1","落胆")
	message("CO_101034_06020011")
	close_speech_window()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","肯定3")
	message("CO_101034_06020012")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	PlayPartVoice("市民中年_男1","肯定2")
	message("CO_101034_06020013")
	close_speech_window()
	
	
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","悩む")
	message("CO_101034_06020015")
	close_speech_window()
	
	
	
	
	change_face(Excelia,"Smile")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","挨拶")
	message("CO_101034_06020017")
	
	
	change_face(Excelia,"Normal")
	message("CO_101034_06020018")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	PlayPartVoice("市民中年_男1","肯定")
	message("CO_101034_06020019")
	close_speech_window()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	
	message("CO_101034_06020020")
	close_speech_window()
	
	
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定2")
	message("CO_101034_06020022")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	
	message("CO_101034_06020023")
	close_speech_window()
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定")
	message("CO_101034_06020024")
	close_speech_window()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","悩む")
	message("CO_101034_06020025")
	close_speech_window()
	
	
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","挨拶")
	message("CO_101034_06020027")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	PlayPartVoice("市民中年_男1","肯定")
	message("CO_101034_06020028")
	close_speech_window()
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","納得")
	message("CO_101034_06020029")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	
	message("CO_101034_06020030")
	close_speech_window()
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","驚き")
	message("CO_101034_06020031")
	close_speech_window()
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","否定")
	message("CO_101034_06020032")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	PlayPartVoice("市民中年_男1","肯定2")
	message("CO_101034_06020033")
	close_speech_window()
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","挨拶")
	message("CO_101034_06020034")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	message("CO_101034_06020035")
	close_speech_window()
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定2")
	message("CO_101034_06020036")
	close_speech_window()
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	message("CO_101034_06020037")
	close_speech_window()
	
	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","怒り")
	message("CO_101034_06020038")
	close_speech_window()
	
	
	dot_disp_weapon(dotNoir2,true)
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","落胆")
	message("CO_101034_06020040")
	close_speech_window()	

	wait_time(0.3)	
	move_camera(9,22,0.5)	
	
	wait_time(0.7)		
	
	dot_disp_weapon(dotExcelia,true)
	wait_time(0.2)
	on_active(Ef_Aura_Enemy_L)
	
	local gridpos=get_grid_position(9,22)
	set_pos(Ef_Aura_Enemy_L,gridpos)
	play_particle(Ef_Aura_Enemy_L)
	
	dot_disp_weapon(dotbaroi,true)

	
	wait_time(0.7)	
	
	
	change_face(Excelia,"Anger")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)	
	message("CO_101034_06020042")
	close_speech_window()
	
	
	change_face(Noir2,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","肯定2")
	message("CO_101034_06020043")
	close_speech_window()
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定")
	message("CO_101034_06020044")
	
	
	change_face(Excelia,"Normal")
	message("CO_101034_06020045")
	close_speech_window()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	
	message("CO_101034_06020046")
	close_speech_window()
	
	
	dot_move_unit_seq(dotNoir2,10,20)
	dot_move_unit_seq(dotExcelia,6,22)
	wait_seq()
	
	
	
	dot_unit_dir(dotbaroi,0)
	
	dot_disp_weapon(dotbaroi,false)
	move_camera(10,20,0.1)
	dot_unit_dir(dotNoir2,1)
	dot_change_anim(dotNoir2,3)
	dot_play_particle_unit(dotNoir2,"Ef_C_Cmn_N_Hit_Sla01",3,true)
	
	
	
	change_face(Excelia,"Sad")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","落胆")
	message("CO_101034_06020048")
	close_speech_window()
	
	dot_change_anim(dotNoir2,0)
	dot_unit_dir(dotNoir2,2)
	
	
	move_camera(7,22,0.5)
	wait_seq()
	wait_time(0.5)
	dot_attack_seq(dotExcelia,dotbaroi)
	dot_damage_seq(dotbaroi,dotExcelia,true)
	wait_seq()
	dot_change_anim(dotbaroi,1)
	dot_change_anim(dotExcelia,0)
	
	
	open_speech_window("NPCNAME_0287",nil,nil)
	message("CO_101034_06020050")
	close_speech_window()
	
	
	bgm_play("BGM_ADV_Painful2")
	
	change_face(Excelia,"Pain")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	
	message("CO_101034_06020051")
	close_speech_window()
	
	
	
	dot_change_anim(dotbaroi,1)
	wait_time(0.2)
	stop_particle(Ef_Aura_Enemy_L)
	
	dot_play_particle_unit(dotbaroi,"Ef_C_Cmn_DieEmy01",2,true)

	wait_time(0.5)

	dot_disp_unit(dotbaroi,false)

	
	dot_remove_unit(dotbaroi)
	
	fadeout(0,0,0,0,1.0)
	wait_time(2.0)
	
	fadein(1.0)
	
	wait_time(1.5)	
	
	change_face(Excelia,"Sad")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	message("CO_101034_06020053")
	
	
	change_face(Excelia,"Sad")
	message("CO_101034_06020054")
	
	
	
	CO_101034_0602_select1()

	open_select_window_tag(Noir2,"Normal","CO_101034_06020056","CO_101034_06020057")
	
	close_speech_window()

	if is_select(1) then			
		CO_101034_0602_select1_1()

	else		
		CO_101034_0602_select1_2()

	end
	CO_101034_0602_end()

	end

	function CO_101034_0602_select1()

	end

	function CO_101034_0602_select1_1()
	
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","落胆")
	message("CO_101034_06020059")
	close_speech_window()
	
	
	change_face(Excelia,"Sad")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	message("CO_101034_06020060")
	
	
	change_face(Excelia,"Sad")
	message("CO_101034_06020061")
	close_speech_window()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","肯定2")
	message("CO_101034_06020062")
	close_speech_window()
	
	
	change_face(Excelia,"Sad")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","落胆")
	message("CO_101034_06020063")
	close_speech_window()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","肯定")
	message("CO_101034_06020072")
	close_speech_window()
	
end
 
function CO_101034_0602_select1_2()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","怒り")
	message("CO_101034_06020065")
	
	
	change_face(Noir2,"Pain")
	message("CO_101034_06020066")
	close_speech_window()
	
	
	change_face(Excelia,"Sad")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","落胆")
	message("CO_101034_06020067")
	close_speech_window()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("CO_101034_06020068")
	close_speech_window()
	
	
	change_face(Excelia,"Normal")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	message("CO_101034_06020069")
	close_speech_window()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","肯定2")
	message("CO_101034_06020070")
	
	
	change_face(Noir2,"Sad")
	message("CO_101034_06020072")
	close_speech_window()
	
end
 
 
function CO_101034_0602_end()
	
	
	
	change_face(Excelia,"Sad")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定2")
	message("CO_101034_06020073")
	close_speech_window()
	
	
	fadeout(0,0,0,0,1.0)
	wait_time(1.0)
	
	
	
	dot_place_unit(dotNoir2,9,27)
	dot_place_unit(dotExcelia,10,27)
	dot_unit_dir(dotExcelia,2)
	dot_unit_dir(dotNoir2,3)
	move_camera(10,27,0.0)
	wait_time(1.0)
	
	fadein(1.0)
	
	wait_time(1.5)	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","悩む")
	message("CO_101034_06020075")
	close_speech_window()
	
	
	change_face(Excelia,"Smile")
	open_speech_window("CHRNAME_EXCELIA",Excelia,nil)
	PlayPartVoice("エクセリア","肯定")
	message("CO_101034_06020076")
	close_speech_window()
	
	
	move_camera(10,29,1.0)
	dot_reserve_move_unit_seq(dotTristan,10,29)
	dot_reserve_move_unit_seq(dotIsolde,11,30)
	exec_parallel_seq()
	dot_unit_dir(dotExcelia,3)
	wait_seq()
	
	wait_time(0.5)		
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	
	message("CO_101034_06020078")
	close_speech_window()
	
	
	change_face(Tristan,"Normal")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	PlayPartVoice("トリスタン","肯定")
	message("CO_101034_06020079")
	close_speech_window()
	
	
	change_face(Isolde,"Sad")
	open_speech_window("CHRNAME_ISOLDE",Isolde,nil)
	PlayPartVoice("イゾルデ","肯定2")
	message("CO_101034_06020080")
	close_speech_window()
	
	
	change_face(Tristan,"Sad")
	open_speech_window("CHRNAME_TRISTAN",Tristan,nil)
	PlayPartVoice("トリスタン","落胆")
	message("CO_101034_06020081")
	close_speech_window()
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール","落胆")
	message("CO_101034_06020082")
	close_speech_window()
	
	
	local trustParam2 = set_communication_rankup("エクセリア_コミュランク", "エクセリア_親密度")
	trustParam2.UpdateRankup()
	open_trust_rank_up(Excelia, trustParam2)

	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Excelia,"Excelia",101034001)
	pbadv_setup_101009_Noir_preload(2,true,12,19,0)
	pbadv_setup_101034_Excelia_preload(0,true,11 ,19 ,0)
	pbadv_setup_101014_Tristan_preload(0,true,10,32,0)
	pbadv_setup_101019_Isolde_preload(0,true,10,33,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
	preload_sound("BGM_ADV_Painful2")
end
