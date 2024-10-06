Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_BRUNO()
	setup2D_Noir()

end

function Play()
	Play_start(false)

	
	
	change_face(BRUNO2,"Smile")
	open_speech_window("CHRNAME_BRUNO2",nil,BRUNO2)
	 --PlayPartVoice("ブルーノ","納得")
	message("MA_01C110_080002")

	wait_time(0.5)
	
	
	change_face(BRUNO2,"Normal")
	message("MA_01C110_080003")
	close_speech_window()

	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール","落胆")
	message("MA_01C110_080005")
	close_speech_window()

	
	
	open_narration_window()
	message("MA_01C110_080007")
	close_narration_window()


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
