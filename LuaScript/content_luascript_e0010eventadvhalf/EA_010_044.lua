Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Guinevere()

end

function Play()
	Play_start(false)

	
	change_face(Guinevere3,"Normal")
	open_speech_window("CHRNAME_GUINEVERE3",nil,Guinevere3)
	PlayPartVoiceDirect("ギネヴィア_007","0002")
	message("EA_010_0440002")
	close_speech_window()
	
	change_face(Guinevere2,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	PlayPartVoiceDirect("ギネヴィア","0015")
	message("EA_010_0440004")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Guinevere_preload()
end
