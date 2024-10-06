Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Sisters_1()
	setup2D_Noir()

end

function Play()
	Play_start(false)
	
	
	
	
	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	PlayPartVoice("ノワール", "驚き")
	message("BT_01A112_0303")
	close_speech_window()
	
	
	change_face(Sisters_1,"Smile")
	open_speech_window("NPCNAME_0166",nil,nil)
	message("BT_01A112_0304")
	
	
	change_face(Sisters_1,"Smile")
	message("BT_01A112_0305")
	close_speech_window()
	
	
	change_face(Noir2,"Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("BT_01A112_0306")
	close_speech_window()

	bgm_play("BGM_To_Main")
	
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Sisters_1_preload()
	setup2D_Noir_preload()
end
