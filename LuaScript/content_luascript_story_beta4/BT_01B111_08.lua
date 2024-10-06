Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Lola()

end

function Play()
	Play_start(false)




	change_face(Lola, "Sad")
	open_speech_window("CHRNAME_LOLA", nil, Lola)
		message("BT_01B111_0329")


	PlayPartVoice("ローラ", "落胆")
	message("BT_01B111_0330")
	close_speech_window()

	bgm_play("BGM_To_Main")

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lola_preload()
end
