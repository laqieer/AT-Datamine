Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Sisters_1()
	setup2D_Clarice()
	setup2D_Viena()
	setup2D_Bors()
end

function Play()
	Play_start(false)




	change_face(Sisters_1, "Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Sisters_1)
		PlayPartVoice("モーロノエー", "笑い")
		message("BT_01B110_0213")
	

		message("BT_01B110_0214")
	close_speech_window()

	bgm_play("BGM_To_Main")
	



	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Sisters_1_preload()
	setup2D_Clarice_preload()
	setup2D_Viena_preload()
	setup2D_Bors_preload()
end
