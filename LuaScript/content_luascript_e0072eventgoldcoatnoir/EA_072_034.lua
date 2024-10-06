Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_S_Noir(3)
	setup2D_S_Laiens()
	setup2D_S_Elaine(5)
	setup2D_S_Lovein(2)

end

function Play()
	Play_start(false)

	change_face(Noir3,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir3,nil)
PlayPartVoiceDirect("ノワール","0029")
	message("EA_072_0340003")
	close_speech_window()

	change_face(Laiens,"Anger")
	open_speech_window("CHRNAME_LAIENS",nil,Laiens)
PlayPartVoiceDirect("ライエンス","0028")
	message("EA_072_0340004")
	close_speech_window()

	change_face(Lovein2,"Anger")
	open_speech_window("CHRNAME_LOVEIN2",Lovein2,nil)
voice_play("VO_101031_sp_0001_2")
	message("EA_072_0340005")
	message("EA_072_0340006")
	close_speech_window()

	change_face(Elaine5,"Anger")
	open_speech_window("CHRNAME_ELAINE",Elaine5,nil)
voice_play("VO_101030_sp_0001_2")
	message("EA_072_0340007")
	message("EA_072_0340008")
	close_speech_window()

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
end
