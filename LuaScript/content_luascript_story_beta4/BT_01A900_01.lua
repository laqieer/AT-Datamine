Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Lola()

end

function Play()
	Play_start(false)
	
	
	
	
	
	change_face(Lola3,"Sad")
	open_speech_window("CHRNAME_LOLA2",nil,Lola3)
	message("BT_01A900_0103")
	
	
	change_face(Lola3,"Pain")
	message("BT_01A900_0104")
	
	
	change_face(Lola3,"Surprise")
	message("BT_01A900_0105")
	close_speech_window()
	
	
	bgm_play("Reset_BGM_Bus_Volume")
	
	
Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lola_preload()
end
