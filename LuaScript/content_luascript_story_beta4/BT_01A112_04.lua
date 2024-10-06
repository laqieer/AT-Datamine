Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Merlin()

end

function Play()
	Play_start(false)
	
	
	
	change_face(Merlin2,"Normal")
	open_speech_window("CHRNAME_MERLIN2",Merlin2,nil)
	PlayPartVoice("マーリン", "肯定2")
	message("BT_01A112_0404")
	
	
	change_face(Merlin2,"Sad")
	PlayPartVoice("マーリン", "落胆")
	message("BT_01A112_0405")
	
	
	change_face(Merlin2,"Sad")
	message("BT_01A112_0406")
	
	
	change_face(Merlin2,"Anger")
	message("BT_01A112_0407")
	close_speech_window()

	bgm_play("BGM_To_Main")
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Merlin_preload()
end
