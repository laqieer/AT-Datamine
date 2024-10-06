Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Isolde()


end

function Play()
	Play_start(false)


	
	change_face(Isolde, "Normal")
	open_speech_window("CHRNAME_ISOLDE", Isolde, nil)
	message("MA_01108_080002")
	
	change_face(Isolde, "Normal")
	message("MA_01108_080004")
	close_speech_window()



	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Isolde_preload()
end
