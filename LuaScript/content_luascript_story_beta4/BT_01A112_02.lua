Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Guinevere()
	setup2D_Rasia()

end

function Play()
	Play_start(false)
	
	
	
	change_face(Rasia2,"Pain")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("BT_01A112_0112")
	close_speech_window()
	
	
	change_face(Guinevere2,"Normal")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	message("BT_01A112_0113")
	close_speech_window()
	
	
	change_face(Rasia2,"Anger")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("BT_01A112_0114")
	close_speech_window()
	
	
	change_face(Guinevere2,"Normal")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	message("BT_01A112_0115")
	close_speech_window()
	
	
	change_face(Rasia2,"Pain")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("BT_01A112_0116")
	close_speech_window()
	
	
	change_face(Guinevere2,"Normal")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	message("BT_01A112_0117")
	
	
	change_face(Guinevere2,"Sad")
	message("BT_01A112_0118")
	close_speech_window()
	
	
	change_face(Rasia2,"Pain")
	open_speech_window("CHRNAME_RASIA2",nil,Rasia2)
	message("BT_01A112_0119")
	close_speech_window()

	bgm_play("BGM_To_Main")
	
	
	

	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Guinevere_preload()
	setup2D_Rasia_preload()
end
