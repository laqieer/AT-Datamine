Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Lucius()

end

function Play()
	Play_start(false)




	change_face(Lucius, "Sad")
	open_speech_window("CHRNAME_LUCIUS", nil, Lucius)
	PlayPartVoice("ルーシャス", "悲しみ")
	message("BT_01B111_0311")


		message("BT_01B111_0312")


	change_face(Lucius, "Normal")
		message("BT_01B111_0313")

	PlayPartVoice("ルーシャス", "悩む")
	message("BT_01B111_0314")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lucius_preload()
end
