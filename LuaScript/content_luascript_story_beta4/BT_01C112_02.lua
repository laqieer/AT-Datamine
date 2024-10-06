Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Lucius()
	setup2D_Noir()
	
end

function Play()
	Play_start(false) 

	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	PlayPartVoice("ノワール", "肯定")
		message("BT_01C112_0106")
		message("BT_01C112_0107")
	close_speech_window()
	
	change_face(Lucius, "Normal")
	open_speech_window("CHRNAME_LUCIUS", Lucius,nil) 
	PlayPartVoice("ルーシャス", "笑い")
		message("BT_01C112_0108")
		message("BT_01C112_0109")
	close_speech_window()	

	bgm_play("BGM_To_Main")
	

	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lucius_preload()
	setup2D_Noir_preload()
end
