

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Ragnar()
	setup2D_Gawain()
	setup2D_Vernarth()
	setup2D_Noir()
	setup2D_Rasia()
	setup2D_Guinevere()
	
	
end

function Play()
	Play_start(false)


	
	change_face(Gawain, "Serious")
	open_speech_window("CHRNAME_GAWAIN",Gawain , nil)
	message("MA_01A112_210001")
	close_speech_window()

	
	
	
	change_face(Ragnar2, "Anger")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2 , nil)
	message("MA_01A112_210003")
	close_speech_window()
	
		
	
	change_face(Vernarth, "Serious")
	open_speech_window("CHRNAME_VERNARTH",nil , Vernarth)
	message("MA_01A112_210006")
	

	
	
	message("MA_01A112_210007")
	

	
	
	message("MA_01A112_210008")
	

	
	change_face(Vernarth, "Anger")
	
	message("MA_01A112_210009")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01A112_210010")
	

	
	change_face(Noir2, "Serious")
	
	message("MA_01A112_210011")
	close_speech_window()

	
	change_face(Rasia2, "Anger")
	open_speech_window("CHRNAME_RASIA2",nil , Rasia2)
	message("MA_01A112_210012")
	close_speech_window()

	
	change_face(Guinevere2, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2, nil)
	message("MA_01A112_210013")
	close_speech_window()

	
	change_face(Vernarth, "Anger")
	open_speech_window("CHRNAME_VERNARTH",nil , Vernarth)
	message("MA_01A112_210014")
	close_speech_window()

	
	change_face(Rasia2, "Anger")
	open_speech_window("CHRNAME_RASIA2",nil , Rasia2)
	message("MA_01A112_210015")
	close_speech_window()





	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Ragnar_preload()
	setup2D_Gawain_preload()
	setup2D_Vernarth_preload()
	setup2D_Noir_preload()
	setup2D_Rasia_preload()
	setup2D_Guinevere_preload()
end
