Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Lyoness()

end

function Play()
	Play_start(false)

	show_current_script()
	
	sortie_troops(3, 2)
	wait_seq()

	--EA_002_022014		リオネス・タスラム	いらっしゃいませ！！
	change_face(Lyoness2, "Smile")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	PlayPartVoiceDirect("リオネス", "0010")
	message("EA_002_022014")
	close_speech_window()

	--EA_002_022015		ノワール	リオネス！？なんで！？
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0028")
	message("EA_002_022015")
	close_speech_window()

	--EA_002_022016		リオネス・タスラム	いらっしゃいませ！！
	change_face(Lyoness2, "Smile")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	PlayPartVoiceDirect("リオネス", "0011")
	message("EA_002_022016")
	close_speech_window()

	--EA_002_022017		ノワール	<ruby=ファクタライズ>因枢分解</ruby>してまで、なんで──…！？
	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール", "0029")
	message("EA_002_022017")
	close_speech_window()

	--EA_002_022018		リオネス・タスラム	いらっしゃいませーっ！！
	change_face(Lyoness2, "Anger")
	open_speech_window("CHRNAME_LYONESS2", Lyoness2, nil)
	PlayPartVoiceDirect("リオネス", "0035")
	message("EA_002_022018")
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
	setup2D_Lyoness_preload()
end
