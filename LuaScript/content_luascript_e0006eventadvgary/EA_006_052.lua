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

	open_speech_window("NPCNAME_0397",nil,nil)
	message("EA_006_0520003")
	close_speech_window()

	open_speech_window("NPCNAME_0398",nil,nil)
	message("EA_006_0520004")
	close_speech_window()

	change_face(Gareth2,"Surprise")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	PlayPartVoiceDirect("ガレス","0029")
	message("EA_006_0520006")
	
	message("EA_006_0520007")
	close_speech_window()
	
	change_face(Lancelot,"Normal")
	open_speech_window("CHRNAME_LANCELOT",Lancelot,nil)
	PlayPartVoiceDirect("ランスロット","0007")
	message("EA_006_0520008")
	close_speech_window()

	change_face(Gareth2,"Normal")
	open_speech_window("CHRNAME_GARETH",Gareth2,nil)
	message("EA_006_0520009")
	
	change_face(Gareth2,"Laugh")
	message("EA_006_0520010")
	
	change_face(Gareth2,"Smile")
	PlayPartVoiceDirect("ガレス","0011")
	message("EA_006_0520011")
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
