Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")
function Load()
	Load_common(false)

	setup2D_Dinatan() 
	
end

function Play()
	Play_start(false) 

	change_face(Dinatan2, "Surprise")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2, nil)
	PlayPartVoice("ディナタン", "驚き")	
		message("BT_01C109_0102") 
		change_face(Dinatan2, "Anger")
		message("BT_01C109_0103")

	change_face(Dinatan2, "Anger")
		message("BT_01C109_0104")

		bgm_play("BGM_To_Main")

	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Dinatan_preload()
end
