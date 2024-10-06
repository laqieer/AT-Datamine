Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Dinatan() 
	setup2D_BRUNO()
	
end

function Play()
	Play_start(false) 

	change_face(BRUNO2, "Normal")
	open_speech_window("CHRNAME_BRUNO2",nil, BRUNO2)
	message("BT_01C110_0110")
	


	change_face(BRUNO2, "Sad")
	
	PlayPartVoice("ブルーノ", "否定")
	message("BT_01C110_0111")
	


	change_face(BRUNO2, "Sad")
	
	message("BT_01C110_0112")
	close_speech_window()	


	change_face(Dinatan2, "Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2, nil)
	PlayPartVoice("ディナタン", "落胆")
		message("BT_01C110_0113")
	close_speech_window()

	bgm_play("BGM_To_Main")
	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Dinatan_preload()
	setup2D_BRUNO_preload()
end
