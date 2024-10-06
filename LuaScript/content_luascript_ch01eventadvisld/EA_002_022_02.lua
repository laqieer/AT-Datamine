Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Gawain()
	setup2D_Ragnar()

end

function Play()
	Play_start(false)

	show_current_script()
	
	sortie_troops(3, 2)
	wait_seq()

	--EA_002_022010		ガウェイン	"今日という日を待ってたぜ！ 待ってろランチ！！"
	change_face(Gawain, "Smile")
	open_speech_window("CHRNAME_GAWAIN", Gawain, nil)
	PlayPartVoiceDirect("ガウェイン", "0011")
	message("EA_002_022010")
	close_speech_window()

	--EA_002_022011		ノワール	ガウェイン、ラグネル！？
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0028")
	message("EA_002_022011")
	close_speech_window()

	--EA_002_022012		ラグネル	"うきうきしてきたあ！ 食べるぞ～～～っ！"
	change_face(Ragnar, "Smile")
	open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
	PlayPartVoiceDirect("ラグネル", "0011")
	message("EA_002_022012")
	close_speech_window()

	bgm_play("Reset_BGM_Bus_Volume")


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Gawain_preload()
	setup2D_Ragnar_preload()
end
