Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Gawain()
	setup2D_Gareth()

end

function Play()
	Play_start(false)

	
	change_face(Gawain,"Surprise")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	PlayPartVoiceDirect("ガウェイン","0015")
	message("EA_006_0150003")
	close_speech_window()


	change_face(Gareth2,"Anger")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	PlayPartVoiceDirect("ガレス_002","0015")
	message("EA_006_0150004")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Gawain_preload()
	setup2D_Gareth_preload()
end
