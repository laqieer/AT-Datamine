Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Gareth()
	setup2D_Lancelot()

end

function Play()
	Play_start(false)

	change_face(Gareth2,"Normal")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	PlayPartVoiceDirect("ガレス","0034")
	message("EA_006_0340003")
	close_speech_window()
	
	open_speech_window("NPCNAME_0086",nil,nil)
	message("EA_006_0340004")
	close_speech_window()

	change_face(Lancelot,"Surprise")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	PlayPartVoiceDirect("ランスロット","0002")
	message("EA_006_0340006")
	close_speech_window()

	change_face(Gareth2,"Surprise")
	PlayPartVoiceDirect("ガレス","0028")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	message("EA_006_0340007")
	close_speech_window()

	change_face(Lancelot,"Sad")
	PlayPartVoiceDirect("ランスロット","0021")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	message("EA_006_0340008")
	close_speech_window()

	open_speech_window("NPCNAME_0086",nil,nil)
	message("EA_006_0340009")
	close_speech_window()

	change_face(Gareth2,"Normal")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	message("EA_006_0340010")

	change_face(Gareth2,"Surprise")
	PlayPartVoiceDirect("ガレス","0029")
	message("EA_006_0340011")
	close_speech_window()

	open_speech_window("NPCNAME_0396",nil,nil)
	message("EA_006_0340012")
	close_speech_window()

	change_face(Gareth2,"Anger")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	message("EA_006_0340013")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Gareth_preload()
	setup2D_Lancelot_preload()
end
