Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Sisters_3()
	
end

function Play()
	Play_start(false) 

	change_face(Sisters_3, "Smile")
	open_speech_window("CHRNAME_SISTERS_3",nil, Sisters_3)
	PlayPartVoice("グリーテン", "笑い")
	message("BT_01C111_0106")
	
	change_face(Sisters_3, "Smile")
	
	message("BT_01C111_0107")
	close_speech_window()

	bgm_play("BGM_To_Main")

	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Sisters_3_preload()
end
