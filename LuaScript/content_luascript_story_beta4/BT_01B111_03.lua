Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Vernarth()
	setup2D_Lucius()
	setup2D_Fren()
	setup2D_Lola()
	setup2D_Rasia()
end

function Play()
	Play_start(false)





	open_speech_window("NPCNAME_0302", nil, nil) 
	PlayPartVoice("兵士2", "落胆")
	message("BT_01B111_0304")


	PlayPartVoice("兵士2", "悲しみ")
		message("BT_01B111_0305")
	close_speech_window()


	change_face(Vernarth, "Anger")
	open_speech_window("CHRNAME_VERNARTH", nil, Vernarth) 
		message("BT_01B111_0306")
	close_speech_window()


	change_face(Vernarth, "Normal")
	PlayPartVoice("ヴェルナルス", "悲しみ")
	open_mind_window("CHRNAME_VERNARTH", nil, Vernarth) 

	message("BT_01B111_0307")


	change_face(Vernarth, "Surprise")
		message("BT_01B111_0308")
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
	setup2D_Lucius_preload()
	setup2D_Fren_preload()
	setup2D_Lola_preload()
	setup2D_Rasia_preload()
end
