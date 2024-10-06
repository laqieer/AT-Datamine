Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Elaine()
	setup2D_Rasia()

end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Rasia,"Pain")
	open_speech_window("CHRNAME_RASIA",nil,Rasia)
	message("BT_01A111_0210")
	
	
	change_face(Rasia,"Pain")
	message("BT_01A111_0211")
	
	
	change_face(Rasia,"Pain")
	message("BT_01A111_0212")
	close_speech_window()	
	
	
	change_face(Elaine,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine,nil)
	message("BT_01A111_0213")
	close_speech_window()	
	
	
	change_face(Rasia,"Anger")
	open_speech_window("CHRNAME_RASIA",nil,Rasia)
	message("BT_01A111_0214")
	close_speech_window()	
	
	
	change_face(Elaine,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine,nil)
	message("BT_01A111_0215")
	close_speech_window()
	
	
	change_face(Rasia,"Anger")
	open_speech_window("CHRNAME_RASIA",nil,Rasia)
	message("BT_01A111_0216")
	close_speech_window()	

	bgm_play("BGM_To_Main")
	
	
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Elaine_preload()
	setup2D_Rasia_preload()
end
