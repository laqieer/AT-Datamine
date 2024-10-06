Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Lancelot()
setup2D_Sisters_1()

end

function Play()
	Play_start(false)

	
	change_face(Sisters_1, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Sisters_1)
	message("MA_01107_240002")
	close_speech_window()

	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01107_240003")
	close_speech_window()

	
	change_face(Sisters_1, "Normal")
	open_speech_window("CHRNAME_SISTERS_1", nil, Sisters_1)
	message("MA_01107_240004")
	close_speech_window()

	
	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
	message("MA_01107_240006")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup2D_Lancelot_preload()
setup2D_Sisters_1_preload()
end
