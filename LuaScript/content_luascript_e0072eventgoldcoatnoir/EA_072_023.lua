Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_S_Noir(3)
	setup2D_S_Elaine(7)

end

function Play()
	Play_start(false)

	change_face(Noir3,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir3,nil)
PlayPartVoiceDirect("ノワール","0029")
	message("EA_072_0230004")
	change_face(Noir3,"Serious")
	message("EA_072_0230005")
	message("EA_072_0230006")
	close_speech_window()

	change_face(Elaine7,"Normal")
	open_speech_window("CHRNAME_NAMELES",Elaine7,nil)
bgm_play("Set_BGM_Bus_LPF_Volume_1")
PlayPartVoiceDirect("エレイン_005","0035")
	message("EA_072_0230008")
	close_speech_window()

	change_face(Noir3,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir3,nil)
	message("EA_072_0230009")
	close_speech_window()

	change_face(Elaine7,"Normal")
	open_speech_window("CHRNAME_NAMELES",Elaine7,nil)
	message("EA_072_0230010")
	message("EA_072_0230011")
	close_speech_window()

bgm_play("Reset_BGM_Bus_LPF_Volume_2")

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(3)
	setup2D_S_Elaine_preload(7)
end
