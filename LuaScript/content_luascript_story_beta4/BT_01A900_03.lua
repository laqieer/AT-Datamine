Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Lucius()

end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Lucius3,"Pain")
	open_speech_window("CHRNAME_LUCIUS",nil,Lucius3)
	message("BT_01A900_0114")

	
	change_face(Lucius3,"Pain")
	message("BT_01A900_0115")
	
	
	change_face(Lucius3,"Pain")
	message("BT_01A900_0116")
	
	
	change_face(Lucius3,"Pain")
	message("BT_01A900_0117")
	
	
	change_face(Lucius3,"Pain")
	message("BT_01A900_0118")
	
	
	change_face(Lucius3,"Pain")
	message("BT_01A900_0119")
	
	
	change_face(Lucius3,"Pain")
	message("BT_01A900_0120")
	close_speech_window()
	
	
	bgm_play("Reset_BGM_Bus_Volume")
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lucius_preload()
end
