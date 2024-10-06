Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_BRUNO()
	setup2D_Noir()

end

function Play()
	Play_start(false)

	change_face(BRUNO2, "Normal")
	open_speech_window("CHRNAME_BRUNO2",nil, BRUNO2)
	PlayPartVoice("ブルーノ", "挨拶")	
		message("BT_01C110_0104")
	

	change_face(BRUNO2, "Normal")
	
		message("BT_01C110_0105")
	
	
	change_face(BRUNO2, "Normal")
	

		message("BT_01C110_0106")
	close_speech_window()	

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	PlayPartVoice("ノワール", "悲しみ")
	message("BT_01C110_0107")
	close_speech_window()	

	bgm_play("BGM_To_Main")



	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_BRUNO_preload()
	setup2D_Noir_preload()
end
