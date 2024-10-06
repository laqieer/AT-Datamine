Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_S_Laevatein()
	setup2D_S_Liliana(2)

end

function Play()
	Play_start(false)
	
	change_face(Liliana2,"Anger")
	open_speech_window("CHRNAME_LONGINUS",Liliana2,nil)
	PlayPartVoiceDirect("リリアーナ","0043")
	message("MS_002_0530002")
	
	message("MS_002_0530003")
	close_speech_window()

	open_speech_window("CHRNAME_LAEVATEIN",Laevatein,nil)
	PlayPartVoiceDirect("レーヴァテイン","0002")
	message("MS_002_0530004")

    message("MS_002_0530005")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Laevatein_preload()
	setup2D_S_Liliana_preload(2)
end
