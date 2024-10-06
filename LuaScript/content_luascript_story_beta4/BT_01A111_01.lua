Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Sisters_1()
	setup2D_Arthur()

end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Sisters_1,"Normal")
	open_speech_window("CHRNAME_SISTERS_1",nil,Sisters_1)
	PlayPartVoice("モーロノエー", "怒り")
	message("BT_01A111_010003")
	
	
	change_face(Sisters_1,"Anger")
	message("BT_01A111_010004")
	close_speech_window()	
	
	
	change_face(Arthur,"Serious")
	open_speech_window("CHRNAME_ARTHUR",Arthur,nil)
	PlayPartVoice("アーサー", "落胆")
	message("BT_01A111_010005")
	close_speech_window()	
	
	
	change_face(Sisters_1,"Smile")
	open_speech_window("CHRNAME_SISTERS_1",nil,Sisters_1)
	PlayPartVoice("モーロノエー", "喜び")
	message("BT_01A111_010006")
	
	
	change_face(Sisters_1,"Smile")
	message("BT_01A111_010007")
	
	
	change_face(Sisters_1,"Normal")
	message("BT_01A111_010008")
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
	setup2D_Arthur_preload()
end
