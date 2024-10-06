Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Sisters_6()

end

function Play()
	Play_start(false)

	
	change_face(Sisters_6, "Smile")
	open_speech_window("CHRNAME_SISTERS_6",nil,Sisters_6) 
	PlayPartVoice("ティーロノエー", "笑い")
		message("BT_01B111_0110")
		message("BT_01B111_0111")
	change_face(Sisters_6, "Normal")
		message("BT_01B111_0112")
		message("BT_01B111_0113")
	PlayPartVoice("ティーロノエー", "喜び")
		message("BT_01B111_0114")
	close_speech_window()	

	bgm_play("BGM_To_Main")


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Sisters_6_preload()
end
