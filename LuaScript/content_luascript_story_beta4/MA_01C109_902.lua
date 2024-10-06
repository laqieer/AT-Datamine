Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	



function Load()
	Load_common(true)
	
	
	
	

	
	
	init_psbattleadv("201000002","201000002")
	change_time_and_weather(1,7)
	



	pbadv_setup_101009_Noir(2,true,21,20,0)
	
	
	
	pbadv_setup_101022_Mordred(0,true,19,19,0)
	
	pbadv_setup_101015_Arthur(0,true,22,19,0)
	
	pbadv_setup_101023_Clarice(0,true,20,19,0)
	
	barbaroi1=dot_reserve_enemy(49,28,21,0)
	barbaroi2=dot_reserve_enemy(49,29,20,0)
	barbaroi3=dot_reserve_enemy(49,30,21,0)
	barbaroi4=dot_reserve_enemy(49,31,20,0)
	barbaroi5=dot_reserve_enemy(49,28,23,0)
	barbaroi6=dot_reserve_enemy(506,29,22,0)
	barbaroi7=dot_reserve_enemy(506,30,23,0)
	barbaroi8=dot_reserve_enemy(506,31,22,0)
	barbaroi9=dot_reserve_enemy(506,28,25,0)
	barbaroi10=dot_reserve_enemy(303,29,24,0)
	
	
	
	setup_complete_unit()
	
	
	
	
	
	
	

	
	

	
	
	
	
	
	
	change_camera_distance(8.0,0.0)

	
	
	change_camera_angle(33.0,0.0)

	
	
	move_camera(29,21,0.0)

	

end





function Play()
	fadein(0)
	Play_start(true)


				
	

	dot_reserve_move_unit_seq(barbaroi1,28,20)
	dot_reserve_move_unit_seq(barbaroi2,29,19)
	dot_reserve_move_unit_seq(barbaroi3,30,20)
	dot_reserve_move_unit_seq(barbaroi4,31,19)
	dot_reserve_move_unit_seq(barbaroi5,28,22)
	dot_reserve_move_unit_seq(barbaroi6,29,21)
	dot_reserve_move_unit_seq(barbaroi7,30,22)
	dot_reserve_move_unit_seq(barbaroi8,31,21)
	dot_reserve_move_unit_seq(barbaroi9,28,24)
	dot_reserve_move_unit_seq(barbaroi10,29,23)
	exec_parallel_seq()
	wait_seq()
	
	move_camera(21,20,1.0)
	wait_time(1.0)

	
	
	dot_unit_dir(barbaroi1,0)
	dot_unit_dir(barbaroi2,0)
	dot_unit_dir(barbaroi3,0)
	dot_unit_dir(barbaroi4,0)
	dot_unit_dir(barbaroi5,0)
	dot_unit_dir(barbaroi6,0)
	dot_unit_dir(barbaroi7,0)
	dot_unit_dir(barbaroi8,0)
	dot_unit_dir(barbaroi9,0)
	dot_unit_dir(barbaroi10,0)
	
	









	
	
	change_face(Clarice,"Surprise")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	 --PlayPartVoice("クラリス", "挨拶")
	message("MA_01C109_9020002")
	close_speech_window()
	
	
	change_face(Mordred,"Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定")
	message("MA_01C109_9020003")
	close_speech_window()
	
	dot_reserve_move_unit_seq(barbaroi1,28,19)
	dot_reserve_move_unit_seq(barbaroi2,29,18)
	dot_reserve_move_unit_seq(barbaroi3,30,19)
	dot_reserve_move_unit_seq(barbaroi4,31,18)
	dot_reserve_move_unit_seq(barbaroi5,28,21)
	dot_reserve_move_unit_seq(barbaroi6,29,20)
	dot_reserve_move_unit_seq(barbaroi7,30,21)
	dot_reserve_move_unit_seq(barbaroi8,31,20)
	dot_reserve_move_unit_seq(barbaroi9,28,23)
	dot_reserve_move_unit_seq(barbaroi10,29,22)
	exec_parallel_seq()
	wait_seq()
	



















	
	




















	
	open_cutin(1,2)
	on_cutin(1,Arthur,"Anger",0)
	
	



	
	
	
	open_speech_window("CHRNAME_ARTHUR",nil,nil)
	 --PlayPartVoice("アーサー", "怒り")
	message("MA_01C109_9020004")
	
	move_camera(29,21,1.0)
	wait_time(0.7)
	
	dot_change_anim(barbaroi1,6)
	dot_change_anim(barbaroi2,6)
	dot_change_anim(barbaroi3,6)
	dot_change_anim(barbaroi4,6)
	dot_change_anim(barbaroi5,6)
	dot_change_anim(barbaroi6,6)
	dot_change_anim(barbaroi7,6)
	dot_change_anim(barbaroi8,6)
	dot_change_anim(barbaroi9,6)
	dot_change_anim(barbaroi10,6)
	
	close_speech_window()
	
	
	
	wait_time(0.3)
	
	close_cutin()
	
	









	
	
	close_cutin()
	
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "驚き")
	message("MA_01C109_9020005")
	close_speech_window()
	
	
	change_face(Mordred,"Serious")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド", "肯定2")
	message("MA_01C109_9020006")
	close_speech_window()
	
	move_camera(21,20,1.0)
	wait_time(0.5)
	
	
	dot_change_anim(barbaroi1,0)
	dot_change_anim(barbaroi2,0)
	dot_change_anim(barbaroi3,0)
	dot_change_anim(barbaroi4,0)
	dot_change_anim(barbaroi5,0)
	dot_change_anim(barbaroi6,0)
	dot_change_anim(barbaroi7,0)
	dot_change_anim(barbaroi8,0)
	dot_change_anim(barbaroi9,0)
	dot_change_anim(barbaroi10,0)
	
	
	change_face(Arthur,"Anger")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	 --PlayPartVoice("アーサー", "肯定2")
	message("MA_01C109_9020007")
	close_speech_window()
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C109_9020008")
	close_speech_window()
	
	dot_move_unit_seq(dotArthur,27,15)
	
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	pbadv_setup_101009_Noir_preload(2,true,21,20,0)
	pbadv_setup_101022_Mordred_preload(0,true,19,19,0)
	pbadv_setup_101015_Arthur_preload(0,true,22,19,0)
	pbadv_setup_101023_Clarice_preload(0,true,20,19,0)
end
