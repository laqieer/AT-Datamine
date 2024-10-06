Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Lancelot()
	setup2D_Sisters_6()

end

function Play()
	Play_start(false)

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2, nil) 
		message("BT_01B111_0103")
		message("BT_01B111_0104")
	close_speech_window()	


	change_face(Sisters_6, "Normal")
	open_speech_window("CHRNAME_SISTERS_6",nil,Sisters_6) 
		message("BT_01B111_0105")
	close_speech_window()	

	change_face(Lancelot2, "Normal")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot2, nil) 
		message("BT_01B111_0106")
	close_speech_window()	

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2, nil) 
		message("BT_01B111_0107")
	close_speech_window()	


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Lancelot_preload()
	setup2D_Sisters_6_preload()
end
