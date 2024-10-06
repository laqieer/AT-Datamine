Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Lucius()


end

function Play()
	Play_start(false)
	
	
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", Lucius, nil)
	message("MA_01108_130002")
	
	message("MA_01108_130003")
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
