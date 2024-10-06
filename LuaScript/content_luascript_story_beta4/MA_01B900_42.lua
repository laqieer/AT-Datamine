Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)
	
	setup2D_Lancelot()
	setup2D_Morgan()
	
end

function Play()

	Play_start(false)
	
	
	change_face(Morgan2,"Normal")
	open_speech_window("CHRNAME_MORGAN2",nil,Morgan2)
	message("MA_01B900_420002")
	
	
	change_face(Morgan2,"Anger")
	message("MA_01B900_420003")
	
	
	change_face(Morgan2,"Anger")
	message("MA_01B900_420004")
	
	
	change_face(Morgan2,"Anger")
	message("MA_01B900_420005")
	
	
	change_face(Morgan2,"Anger")
	message("MA_01B900_420008")
	close_speech_window()
	
	
	change_face(Lancelot2,"Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2,nil)
	message("MA_01B900_420006")
	
	
	change_face(Lancelot2,"Normal")
	message("MA_01B900_420007")
	close_speech_window()
	
	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lancelot_preload()
	setup2D_Morgan_preload()
end
