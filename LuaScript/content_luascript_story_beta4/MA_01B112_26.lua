Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Galahad()
setup2D_Astera()

end

function Play()
	Play_start(false)


	
	change_face(Astera2, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera2)
	 --PlayPartVoice("アステラ","落胆")
	message("MA_01B112_260004")
	
	change_face(Astera2, "Normal")
	message("MA_01B112_260005")
	close_speech_window()

	
	change_face(Galahad2, "Smile")
	open_speech_window("CHRNAME_GALAHAD", Galahad2, nil)
	 --PlayPartVoice("ガラハッド","笑い")
	message("MA_01B112_260007")
	close_speech_window()

	
	change_face(Astera2, "Normal")
	open_speech_window("CHRNAME_ASTERA2", nil, Astera2)
	 --PlayPartVoice("アステラ","肯定2")
	message("MA_01B112_260008")
	
	change_face(Astera2, "Normal")
	message("MA_01B112_260010")
	close_speech_window()





	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup2D_Galahad_preload()
setup2D_Astera_preload()
end
