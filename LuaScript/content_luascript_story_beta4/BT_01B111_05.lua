Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_Vernarth()

end

function Play()
	Play_start(false)




	change_face(Vernarth, "Anger")
	PlayPartVoice("ヴェルナルス", "苦しみ")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth) 
		message("BT_01B111_0317")
	close_speech_window()


	change_face(Vernarth, "Sad")
	open_mind_window("CHRNAME_VERNARTH", nil, Vernarth) 
		message("BT_01B111_0318")
	close_mind_window()

	bgm_play("BGM_To_Main")


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Vernarth_preload()
end
