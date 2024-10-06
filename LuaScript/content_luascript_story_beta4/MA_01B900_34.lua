Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Kay()
setup2D_Noir()
setup2D_Lancelot()
setup2D_Galahad()

end

function Play()
	Play_start(false)

	
	change_face(Lancelot2, "Anger")
	open_speech_window("CHRNAME_LANCELOT2", Lancelot2, nil)
	message("MA_01B900_340003")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("MA_01B900_340004")
	
	change_face(Noir2, "Anger")
	message("MA_01B900_340005")
	close_speech_window()

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B900_340006")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup2D_Kay_preload()
setup2D_Noir_preload()
setup2D_Lancelot_preload()
setup2D_Galahad_preload()
end
