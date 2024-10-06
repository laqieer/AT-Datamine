Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Lovein()
	setup2D_Elaine()

end

function Play()
	Play_start(false)
	
	
	
	
	
	change_face(Lovein2,"Normal")
	open_speech_window("CHRNAME_LOVEIN2",Lovein2,nil)
	PlayPartVoice("ラヴェイン", "肯定")
	message("BT_01A109_0203")
	close_speech_window()
	
	
	change_face(Elaine,"Normal")
	open_speech_window("CHRNAME_ELAINE",Elaine,nil)
	message("BT_01A109_0204")
	
	
	change_face(Elaine,"Smile")
	PlayPartVoice("エレイン", "笑い")
	message("BT_01A109_0205")
	close_speech_window()
	
	
	change_face(Lovein2,"Smile")
	open_speech_window("CHRNAME_LOVEIN2",Lovein2,nil)
	PlayPartVoice("ラヴェイン", "笑い")
	message("BT_01A109_0206")
	close_speech_window()

	bgm_play("BGM_To_Main")
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Lovein_preload()
	setup2D_Elaine_preload()
end
