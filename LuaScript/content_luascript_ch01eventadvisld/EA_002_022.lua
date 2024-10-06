Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Isolde()

end

function Play()
	Play_start(false)

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0030")
	message("EA_002_022002")
	close_speech_window()

	change_face(Isolde, "Normal")
	open_speech_window("CHRNAME_ISOLDE", Isolde, nil)
	PlayPartVoiceDirect("イゾルデ","0008")	
	message("EA_002_022003")


	change_face(Isolde, "Normal")
	message("EA_002_022004")


	change_face(Isolde, "Normal")
	message("EA_002_022005")
	close_speech_window()

	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0028")
	message("EA_002_022006")
	close_speech_window()

	change_face(Isolde, "Normal")
	open_speech_window("CHRNAME_ISOLDE", Isolde, nil)
	PlayPartVoiceDirect("イゾルデ", "0042")
	message("EA_002_022007")
	close_speech_window()


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Isolde_preload()
end
