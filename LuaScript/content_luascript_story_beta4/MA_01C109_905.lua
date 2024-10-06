

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201000002","201000002")
	change_time_and_weather(2,7)
	



	pbadv_setup_101009_Noir(2,true,27,20,0)
	
	
	
	pbadv_setup_101022_Mordred(0,true,29,19,0)
	
	pbadv_setup_101015_Arthur(0,true,30,9,0)
	
	pbadv_setup_101023_Clarice(0,true,28,18,0)
	
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	
	dot_disp_unit(dotArthur,false)

	
	
	
	dot_disp_weapon(dotMordred,false)
	dot_disp_weapon(dotClarice,false)
	dot_disp_weapon(dotNoir2,false)
	dot_disp_weapon(dotArthur,false)
	
	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(40.0,0.0)

	
	
	move_camera(28,20,0.0)


end





function Play()
	fadein(0)
	Play_start(true)


	
	change_face(Arthur,"Normal")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	 --PlayPartVoice("アーサー", "肯定3")
	message("MA_01C109_9050001")
	close_speech_window()
	
	
	
	dot_disp_unit(dotArthur,true)
	
	dot_move_unit_seq(dotArthur,30,18)
	wait_seq()
	dot_unit_dir(dotArthur,2)
	
	
	change_face(Arthur,"Smile")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	 --PlayPartVoice("アーサー", "喜び")
	message("MA_01C109_9050002")
	close_speech_window()
	
	
	change_face(Clarice,"Surprise")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "挨拶")
	message("MA_01C109_9050003")
	close_speech_window()
	
	
	change_face(Arthur,"Smile")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	 --PlayPartVoice("アーサー", "肯定2")
	message("MA_01C109_9050004")
	
	
	change_face(Arthur,"Smile")
	message("MA_01C109_9050005")
	close_speech_window()
	
	
	change_face(Mordred,"Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定3")
	message("MA_01C109_9050006")
	close_speech_window()
	
	
	dot_move_unit_seq(dotMordred,29,25)
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "驚き")
	message("MA_01C109_9050007")
	close_speech_window()
	
	
	change_face(Clarice,"Smile")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "喜び")
	message("MA_01C109_9050008")
	close_speech_window()
	
	wait_seq()
	
	dot_move_unit_seq(dotMordred,29,22)
	wait_seq()
	
	change_face(Mordred,"Anger")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "激怒")
	message("MA_01C109_9050009")
	close_speech_window()
	
	
	dot_move_unit_seq(dotMordred,29,30)
	
	
	change_face(Clarice,"Smile")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "笑い")
	message("MA_01C109_9050010")
	
	
	change_face(Clarice,"Normal")
	message("MA_01C109_9050011")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")
	
	
	dot_reserve_move_unit_seq(dotClarice,32,9)
	dot_reserve_move_unit_seq(dotNoir2,33,9)
	exec_parallel_seq()
	wait_seq()
	dot_unit_dir(dotArthur,3)
	
	
	
	change_face(Arthur,"Sad")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	 --PlayPartVoice("アーサー", "悲しみ")
	message("MA_01C109_9050012")
	close_speech_window()
	
	
	
	dot_move_unit_seq(dotArthur,34,9)
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,27,20,0)
	pbadv_setup_101022_Mordred_preload(0,true,29,19,0)
	pbadv_setup_101015_Arthur_preload(0,true,30,9,0)
	pbadv_setup_101023_Clarice_preload(0,true,28,18,0)
end
