Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Galahad()
	setup2D_Excelia()

end


function Play()
	Play_start(false)

	
	
	
	
	change_face(Galahad2, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B110_190002")
	close_speech_window()
	
	
	
	change_face(Excelia2, "Normal")
	open_speech_window("CHRNAME_EXCELIA2", nil, Excelia2)
	message("MA_01B110_190003")
	close_speech_window()
	
	
	
	change_face(Galahad2, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B110_190004")
	
	
	
	message("MA_01B110_190005")
	
	
	
	message("MA_01B110_190006")
	
	
	
	message("MA_01B110_190007")
	
	
	
	change_face(Galahad2, "Normal")
	message("MA_01B110_190009")
	
	
	
	message("MA_01B110_190010")
	close_speech_window()

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Galahad_preload()
	setup2D_Excelia_preload()
end
