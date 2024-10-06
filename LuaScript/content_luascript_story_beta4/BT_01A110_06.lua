Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Sisters_4()
	setup2D_Noir()

end

function Play()
	Play_start(false)
	
	
	
	change_face(Sisters_4,"Smile")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	message("BT_01A110_0509")
	close_speech_window()
	
	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("BT_01A110_0510")
	close_speech_window()
	
	
	change_face(Sisters_4,"Anger")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	message("BT_01A110_0511")
	close_speech_window()	

	bgm_play("BGM_To_Main")
	
	
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Sisters_4_preload()
	setup2D_Noir_preload()
end
