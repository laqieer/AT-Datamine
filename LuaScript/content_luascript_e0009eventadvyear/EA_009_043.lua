Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Lovein()

end

function Play()
	Play_start(false)
	
	
	open_speech_window("NPCNAME_0393",nil,nil)
	message("EA_009_0430002")
	--close_speech_window()
	
	
	--open_speech_window("NPCNAME_0393",nil,nil)
	message("EA_009_0430003")
	close_speech_window()
	
	change_face(Lovein2,"Sad")
	open_speech_window("CHRNAME_LOVEIN2",Lovein2,nil)
	PlayPartVoiceDirect("ラヴェイン","0025")
	message("EA_009_0430004")
	--close_speech_window()
	
	--open_speech_window("CHRNAME_LOVEIN2",Lovein2,nil)
	message("EA_009_0430005")
	close_speech_window()
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("EA_009_0430006")
	close_speech_window()
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Lovein_preload()
end
