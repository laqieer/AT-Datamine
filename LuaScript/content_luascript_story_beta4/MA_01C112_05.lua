Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system","BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Noir()
	setup2D_Lucius()
	
end

function Play()
	Play_start(false)

	
	change_face(Lucius,"Normal")
	
	change_face(Lucius,"Normal")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "悩む")
	message("MA_01C112_050001")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "落胆")
	message("MA_01C112_050002")
	close_speech_window()

	
	change_face(Lucius,"Sad")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "激怒")
	message("MA_01C112_050003")
	

	
	
	message("MA_01C112_050004")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "納得")
	message("MA_01C112_050005")
	close_speech_window()

	
	
	change_face(Lucius,"Surprise")
	open_speech_window("CHRNAME_LUCIUS",Lucius,nil)
	 --PlayPartVoice("ルーシャス", "肯定2")
	message("MA_01C112_050007")
	

	
	change_face(Lucius,"Smile")
	
	 --PlayPartVoice("ルーシャス", "肯定3")
	message("MA_01C112_050008")
	close_speech_window()

				


	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Lucius_preload()
end
