Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Lancelot()
	
end

function Play()
	Play_start(false) 

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2, nil) 
		message("BT_01C112_0303")
	PlayPartVoice("ノワール", "怒り")
		message("BT_01C112_0304")
	close_speech_window()	


	change_face(Lancelot, "Normal")
	open_speech_window("CHRNAME_LANCELOT", nil, Lancelot) 
	PlayPartVoice("ランスロット", "悩む")
		message("BT_01C112_0305")
		message("BT_01C112_0306")
		message("BT_01C112_0307")
	change_face(Lancelot, "Sad")
	PlayPartVoice("ランスロット", "落胆")
		message("BT_01C112_0308")
	close_speech_window()	

	change_face(Noir2, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir2, nil) 
	PlayPartVoice("ノワール", "驚き")
		message("BT_01C112_0309")
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
	setup2D_Lancelot_preload()
end
