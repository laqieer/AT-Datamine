Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Lancelot()

end

function Play()
	Play_start(false)

	
	change_face(Lancelot3,"Normal")
	open_speech_window("CHRNAME_LANCELOT3",nil,Lancelot3)
	PlayPartVoiceDirect("ランスロット_007","0002")
	message("EA_010_0450002")
	close_speech_window()
	
	change_face(Lancelot2,"Anger")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2,nil)
	PlayPartVoiceDirect("ランスロット","0016")
	message("EA_010_0450003")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lancelot_preload()
end
