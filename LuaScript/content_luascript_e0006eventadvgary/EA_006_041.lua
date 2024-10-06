Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Gareth()

end

function Play()
	Play_start(false)
	
	change_face(Gareth2,"Laugh")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	PlayPartVoiceDirect("ガレス","0009")
	message("EA_006_0410004")
	
	message("EA_006_0410005")
	close_speech_window()
	
	open_speech_window("NPCNAME_0396",nil,nil)
	message("EA_006_0410007")
	close_speech_window()

	change_face(Gareth2,"Surprise")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	PlayPartVoiceDirect("ガレス","0028")
	message("EA_006_0410009")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Gareth_preload()
end
