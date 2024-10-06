Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Ragnar()
	setup2D_Isolde()

end

function Play()
	Play_start(false)


	change_face(Ragnar2, "Normal")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	PlayPartVoiceDirect("ラグネル", "0008")
	message("EA_001_042002")
	close_speech_window()

	
	change_face(Isolde, "Normal")
	open_speech_window("CHRNAME_ISOLDE", Isolde, nil)
	PlayPartVoiceDirect("イゾルデ", "0008")
	message("EA_001_042003")
	close_speech_window()

	
	change_face(Ragnar2, "Laugh")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	PlayPartVoiceDirect("ラグネル", "0007")
	message("EA_001_042004")
	close_speech_window()

	
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0028")
	message("EA_001_042005")
	close_speech_window()

	
	change_face(Ragnar2, "Laugh")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	voice_play("VO_101018_sp_0001_1")
	message("EA_001_042006")
	close_speech_window()

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0040")
	message("EA_001_042007")
	close_speech_window()

	change_face(Ragnar2, "Laugh")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	message("EA_001_042008")
	close_speech_window()

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	message("EA_001_042009")
	close_speech_window()

	change_face(Ragnar2, "Smile")
	open_speech_window("CHRNAME_RAGNAR2", Ragnar2, nil)
	PlayPartVoiceDirect("ラグネル", "0011")
	message("EA_001_042010")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Ragnar_preload()
	setup2D_Isolde_preload()
end
