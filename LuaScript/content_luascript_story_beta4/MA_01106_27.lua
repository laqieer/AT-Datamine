Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Brian()

end

function Play()
	Play_start(false)


	
	change_face(Brian, "Normal")
	open_speech_window("CHRNAME_BRIAN", nil, Brian)
	message("MA_01106_270002")
	
	change_face(Brian, "Normal")
	message("MA_01106_270003")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Brian_preload()
end
