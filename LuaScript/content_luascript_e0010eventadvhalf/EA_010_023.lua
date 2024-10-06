Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Laevatein()

end

function Play()
	Play_start(false)

	
	change_face(Laevatein,"Surprise")
	open_speech_window("CHRNAME_LAEVATEIN",Laevatein,nil)
	PlayPartVoiceDirect("レーヴァテイン","0029")
	message("EA_010_0230002")
	
	change_face(Laevatein,"Surprise")
	message("EA_010_0230003")

	change_face(Laevatein,"Anger")
	PlayPartVoiceDirect("レーヴァテイン","0016")
	message("EA_010_0230004")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Laevatein_preload()
end
