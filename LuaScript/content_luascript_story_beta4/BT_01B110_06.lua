Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Sisters_1()

end

function Play()
	Play_start(false)




	change_face(Sisters_1, "Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil,Sisters_1)
	PlayPartVoice("モーロノエー", "笑い")
		message("BT_01B110_060004")
	PlayPartVoice("モーロノエー", "喜び")
		message("BT_01B110_060005")
	close_speech_window()	

	bgm_play("BGM_To_Main")

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Sisters_1_preload()
end
