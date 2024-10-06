Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_S_Noir(3)
	setup2D_S_Laiens()
	setup2D_S_Elaine(5)
	setup2D_S_Lovein(2)

	load_sound("BGM_ADV_Noir_Theme")

end

function Play()
	Play_start(false)

	change_face(Noir3,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir3,nil)
voice_play("VO_101009_sp_0036_1")
	message("EA_072_0350002")
	close_speech_window()

	change_face(Lovein2,"Anger")
	open_speech_window("CHRNAME_LOVEIN2",Lovein2,nil)
	message("EA_072_0350003")
PlayPartVoiceDirect("ラヴェイン","0032")
	message("EA_072_0350004")
	close_speech_window()

	change_face(Laiens,"Surprise")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
PlayPartVoiceDirect("ライエンス","0024")
	message("EA_072_0350005")
	close_speech_window()

	change_face(Lovein2,"Anger")
	open_speech_window("CHRNAME_LOVEIN2",Lovein2,nil)
	message("EA_072_0350006")
	message("EA_072_0350008")
	close_speech_window()

	change_face(Laiens,"Sad")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
bgm_play("Stop_BGM_Bus_LongFade")
PlayPartVoiceDirect("ライエンス","0022")
	message("EA_072_0350009")
	close_speech_window()

	change_face(Noir3,"Serious")
	open_speech_window("CHRNAME_NOIR",Noir3,nil)
	message("EA_072_0350010")
	close_speech_window()

	change_face(Elaine5,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine5,nil)
bgm_play("BGM_ADV_Noir_Theme")
voice_play("VO_101030_sp_0001_3")
	message("EA_072_0350011")
	close_speech_window()

	change_face(Noir3,"Laugh")
	open_speech_window("CHRNAME_NOIR",Noir3,nil)
PlayPartVoiceDirect("ノワール","0036")
	message("EA_072_0350012")
	close_speech_window()

	change_face(Elaine5,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine5,nil)
	message("EA_072_0350013")
	close_speech_window()

	change_face(Noir3,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir3,nil)
	message("EA_072_0350014")
	close_speech_window()

	change_face(Elaine5,"Smile")
	open_speech_window("CHRNAME_ELAINE",Elaine5,nil)
PlayPartVoiceDirect("エレイン_005","0002")
	message("EA_072_0350016")
	close_speech_window()

bgm_play("Stop_BGM_Bus_MidFade")

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(3)
	setup2D_S_Laiens_preload()
	setup2D_S_Elaine_preload(5)
	setup2D_S_Lovein_preload(2)
	preload_sound("BGM_ADV_Noir_Theme")
end
