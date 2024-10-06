

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Lucius()
	
end

function Play()
	Play_start(false)


	
	
	
	change_face(Lucius3, "Normal")
	open_speech_window("CHRNAME_LUCIUS",nil , Lucius3)
	message("MA_01A900_420002")
	

	
	change_face(Lucius3, "Pain")
	
	message("MA_01A900_420003")
	close_speech_window()

	
	

	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lucius_preload()
end
