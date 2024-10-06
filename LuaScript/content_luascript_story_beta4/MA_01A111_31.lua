

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system", "BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Rasia()
	setup2D_Vernarth()
	setup2D_Noir()
	setup2D_Guinevere()
	
end

function Play()
	Play_start(false)


	
	change_face(Rasia, "Anger")
	open_speech_window("CHRNAME_RASIA",nil ,Rasia )
	message("MA_01A111_310002")
	close_speech_window()

	
	change_face(Vernarth, "Anger")
	open_speech_window("CHRNAME_VERNARTH",nil , Vernarth)
	message("MA_01A111_310003")
	close_speech_window()

	
	
	
	open_speech_window("NPCNAME_0122",nil , nil)
	message("MA_01A111_310005")
	close_speech_window()

	
	change_face(Guinevere2, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2 , nil)
	message("MA_01A111_310006")
	close_speech_window()

	
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	message("MA_01A111_310007")
	close_speech_window()

	
	change_face(Guinevere2, "Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2 , nil)
	message("MA_01A111_310008")
	close_speech_window()



	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Rasia_preload()
	setup2D_Vernarth_preload()
	setup2D_Noir_preload()
	setup2D_Guinevere_preload()
end
