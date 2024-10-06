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

	
	change_face(Laevatein,"Normal")
	open_speech_window("CHRNAME_LAEVATEIN",Laevatein,nil)
	PlayPartVoiceDirect("レーヴァテイン","0002")
	message("EA_010_0220006")
	
	message("EA_010_0220007")

	change_face(Laevatein,"Anger")
	PlayPartVoiceDirect("レーヴァテイン","0015")
	message("EA_010_0220008")

	PlayPartVoiceDirect("レーヴァテイン","0017")
	message("EA_010_0220009")
	close_speech_window()

	Play_end(false)
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Laevatein_preload()
end
