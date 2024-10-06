

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	

	
	init_psbattleadv("201150000", "201150000")
	
	
	
	
    pbadv_setup_101009_Noir(2,true,29,34,0)
    
	pbadv_setup_101023_Clarice(0,true,30,35,0)
	
	pbadv_setup_101013_Gawain(0,true,30,34,0)
	
	pbadv_setup_101022_Mordred(0,true,29,36,0)
	
	pbadv_setup_101018_Ragnar(0,true,30,33,0)
	
	Kair  = dot_reserve_ally(401015001, 28, 34, 0)
	
	dot_set_weapon(Kair, 101010001)

	
	barbaroi    = dot_reserve_ally(401035001, 29,33, 0)
	dot_set_weapon(barbaroi, 101010001)
	barbaroi2   = dot_reserve_ally(401035001, 28,33, 0)
	dot_set_weapon(barbaroi2, 101010001)
	barbaroi3   = dot_reserve_ally(401035001, 28,35, 0)
	dot_set_weapon(barbaroi3, 101010001)
	
	
	change_time_and_weather(1,1)
	
	
	
	
	setup_complete_unit()
	
	dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotClarice, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotRagnar, 2)
	
	dot_disp_weapon(Kair, false)
	
	change_camera_distance(8.0, 0.0)

	
	
	change_camera_angle(30.0, 0.0)

	
	
	move_camera(38, 34, 0.0)
	
	Ef_Zoon=load_particle("content_effect3d_common_adv","Ef_C_Cmn_Destination_Lop",true,true)
	
end

function Play()
	fadein(0)
	Play_start(true)
	
	
	
	dot_reserve_move_unit_seq(dotRagnar ,40,33)
	dot_reserve_move_unit_seq(dotGawain ,40,34)
	dot_reserve_move_unit_seq(dotClarice ,40,35)
	dot_reserve_move_unit_seq(dotNoir2 ,39,34)
    exec_parallel_seq()
    wait_seq()
    dot_unit_dir(dotNoir2, 2)
	dot_unit_dir(dotClarice, 2)
	dot_unit_dir(dotGawain, 2)
	dot_unit_dir(dotRagnar, 2)
 

		-- @ガウェイン	つ、着いたぜ、これでなにが──…？	
		change_face(Gawain , "Anger")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	PlayPartVoiceDirect("ガウェイン","0015")
	message("EA_007_0330002")
	close_speech_window()
	
	

	-- @ログレス兵？A	どこへ行きやがる！	
	open_speech_window("NPCNAME_0390",nil , nil)
	message("EA_007_0330003")
	close_speech_window()
	
	--move_camera(37, 34, 1.0)
	dot_reserve_move_unit_seq(barbaroi ,37,34)
	dot_reserve_move_unit_seq(barbaroi2 ,35,33)
	dot_reserve_move_unit_seq(barbaroi3 ,35,35)
	dot_reserve_move_unit_seq(Kair ,35,34)
	dot_reserve_move_unit_seq(dotMordred ,30,34)
    exec_parallel_seq()
    wait_seq()

				--//ログレス兵？特定エリア付近へと駆ける。（複数いる場合は全員）
	-- @ラグネル	わーっ！あいつら来たよ！どうすればいいの！？	
	change_face(Ragnar , "Surprise")
	open_speech_window("CHRNAME_RAGNAR",Ragnar , nil)
	PlayPartVoiceDirect("ラグネル","0031")
	message("EA_007_0330005")
	close_speech_window()
	
	
	dot_change_anim(barbaroi2,6)
	dot_change_anim(barbaroi3,6)
	dot_play_particle_unit(barbaroi2,"Ef_C_Cmn_N_Hit_Str01",3,true)
	dot_play_particle_unit(barbaroi3,"Ef_C_Cmn_N_Hit_Str01",3,true)
	
	wait_time(0.2)
	
	dot_move_knockback(barbaroi2,37, 33,0.6,2)
	dot_move_knockback(barbaroi3,37, 35,0.6,2)
	wait_time(0.4)
	
	

				--//ログレス兵？に斬撃が走る
	-- @ログレス兵？B	な、にィッ………！？	
	open_speech_window("NPCNAME_0391",nil , nil)
	message("EA_007_0330007")
	close_speech_window()
	
	dot_unit_dir(barbaroi, 2)
	dot_change_anim(barbaroi2,1)
	dot_change_anim(barbaroi3,1)
	
	move_camera(35, 34, 2.0)
	
	dot_move_unit_seq(dotMordred ,34,34)
	wait_seq()
	dot_move_unit_seq(Kair ,33,34)
	wait_seq()
	dot_unit_dir(Kair, 3)
	
	wait_time(1.0)
	

				--//ログレス兵？、倒れる（バトルマップ上から消え）
				--//ログレス兵？の背後にモルドレッド登場
				--<in>モルドレッド
	-- @モルドレッド	セコいヤツらだな	
	change_face(Mordred , "Smile")
	open_speech_window("CHRNAME_MORDRED",Mordred , nil)
	PlayPartVoiceDirect("モルドレッド","0013")
	message("EA_007_0330011")
	close_speech_window()






	
	Play_end(true)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    pbadv_setup_101009_Noir_preload(2,true,29,34,0)
	pbadv_setup_101023_Clarice_preload(0,true,30,35,0)
	pbadv_setup_101013_Gawain_preload(0,true,30,34,0)
	pbadv_setup_101022_Mordred_preload(0,true,29,36,0)
	pbadv_setup_101018_Ragnar_preload(0,true,30,33,0)
	load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Destination_Lop",true,true)
end
