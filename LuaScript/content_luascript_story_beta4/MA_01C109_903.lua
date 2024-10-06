Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system","BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Mordred()
	
	
end

function Play()
	Play_start(false)



	
	change_face(Mordred,"Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	 --PlayPartVoice("モルドレッド","挨拶")
	message("MA_01C109_9030001")
	

	
	change_face(Mordred,"Smile")
	
	message("MA_01C109_9030002")
	

	
	change_face(Mordred,"Normal")
	
	 --PlayPartVoice("モルドレッド","肯定2")
	message("MA_01C109_9030003")
	

	
	change_face(Mordred,"Smile")
	
	message("MA_01C109_9030004")
	close_speech_window()

	bgm_play("BGM_To_Main")




	
	Play_end(false) 
end














function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Mordred_preload()
end
