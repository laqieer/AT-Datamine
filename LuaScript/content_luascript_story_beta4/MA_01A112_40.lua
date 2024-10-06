

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Arthur()
	setup2D_Merlin()
	setup2D_Morgan()
	
end

function Play()
	Play_start(false)


	
	change_face(Morgan2, "Anger")
	open_speech_window("CHRNAME_MORGAN2",nil , Morgan2)
	message("MA_01A112_400001")
	close_speech_window()

	
	change_face(Arthur, "Anger")
	open_speech_window("CHRNAME_ARTHUR",Arthur , nil)
	message("MA_01A112_400002")
	close_speech_window()

	
	change_face(Merlin2, "Anger")
	open_speech_window("CHRNAME_MERLIN2",Merlin2 , nil)
	message("MA_01A112_400003")
	close_speech_window()
















	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Arthur_preload()
	setup2D_Merlin_preload()
	setup2D_Morgan_preload()
end
