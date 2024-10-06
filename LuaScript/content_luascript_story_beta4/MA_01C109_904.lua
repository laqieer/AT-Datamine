Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_system","PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	
Include("content_luascript_system","BattleAdvFunctions")
	
function Load()
    Load_common(false)
	
	setup2D_Clarice()
	
	
end

function Play()
	Play_start(false)



	
	change_face(Clarice2,"Smile")
	open_speech_window("CHRNAME_CLARICE2",Clarice2,nil)
	 --PlayPartVoice("クラリス","喜び")
	message("MA_01C109_9040001")
	

	
	change_face(Clarice2,"Anger")
	
	message("MA_01C109_9040002")
	close_speech_window()

	bgm_play("BGM_To_Main")




	
	Play_end(false) 
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Clarice_preload()
end
