Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Laiens()

end

function Play()
	Play_start(false)


	
	change_face(Laiens2, "Normal")
	open_speech_window("CHRNAME_LAIENS", nil, Laiens2)
	message("MA_01108_330001")
	
	change_face(Laiens2, "Normal")
	message("MA_01108_330002")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Laiens_preload()
end
