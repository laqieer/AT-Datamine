Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Galahad()

end

function Play()
	Play_start(false)




	change_face(Galahad2, "Pain")
	open_speech_window("CHRNAME_GALAHAD",Galahad2, nil)
	PlayPartVoice("ガラハッド", "苦しみ")
		message("BT_01B110_0303")
	

		message("BT_01B110_0304")
	close_speech_window()

	bgm_play("BGM_To_Main")
	



	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Galahad_preload()
end
