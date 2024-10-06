Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Clarice()

end

function Play()
	Play_start(false)

	
	change_face(Clarice2,"Normal")
	open_speech_window("CHRNAME_CLARICE2",Clarice2,nil)
	PlayPartVoiceDirect("クラリス","0007")
	message("EA_007_0430002")
	close_speech_window()
	
	change_face(Noir2,"Normal")
	open_speech_window("PLAYERNAME_NOIR",Noir2,nil)
	message("EA_007_0430003")
	close_speech_window()
	
	change_face(Clarice2,"Smile")
	open_speech_window("CHRNAME_CLARICE2",Clarice2,nil)
	PlayPartVoiceDirect("クラリス","0010")
	message("EA_007_0430004")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Clarice_preload()
end
