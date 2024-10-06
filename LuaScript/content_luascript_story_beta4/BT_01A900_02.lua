Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Fren()

end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Fren3,"Pain")
	open_speech_window("CHRNAME_FREN2",nil,Fren3)
	message("BT_01A900_0108")
	
	
	change_face(Fren3,"Pain")
	message("BT_01A900_0109")
	
	
	change_face(Fren3,"Sad")
	message("BT_01A900_0110")
	
	
	change_face(Fren3,"Sad")
	message("BT_01A900_0111")
	close_speech_window()
	
	
	bgm_play("Reset_BGM_Bus_Volume")
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Fren_preload()
end
