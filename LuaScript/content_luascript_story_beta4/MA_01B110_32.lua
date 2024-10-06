Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)
	
	setup2D_Galahad()
	setup2D_Liliana()

end




function Play()
	Play_start(false)

	
	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B110_320002")

	
	message("MA_01B110_321001")
	close_speech_window()

	
	change_face(Liliana2, "Sad")
	open_speech_window("CHRNAME_LILIANA2",  nil, Liliana2)
	message("MA_01B110_320003")
	close_speech_window()
	
	
	change_face(Galahad2, "Anger")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	message("MA_01B110_320004")
	
	
	message("MA_01B110_320005")

	
	message("MA_01B110_320006")
	
	
	message("MA_01B110_320007")
	
	
	change_face(Galahad2, "Normal")
	message("MA_01B110_320009")
	
	
	message("MA_01B110_320010")
	close_speech_window()
				

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Galahad_preload()
	setup2D_Liliana_preload()
end
