Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Gawain()
	setup2D_Vernarth()
	setup2D_Ragnar()
	setup2D_Rasia()
	setup2D_Guinevere()

end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("BT_01A112_0103")
	close_speech_window()
	
	
	change_face(Gawain,"Pain")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("BT_01A112_0104")
	close_speech_window()
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("BT_01A112_0105")
	
	
	change_face(Vernarth,"Smile")
	message("BT_01A112_0106")
	close_speech_window()
	
	
	change_face(Ragnar2,"Sad")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2,nil)
	message("BT_01A112_0107")
	close_speech_window()
	
	
	change_face(Vernarth,"Sad")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("BT_01A112_0108")
	close_speech_window()
	
	
	
	change_face(Gawain,"Sad")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("BT_01A112_0110")
	close_speech_window()

	bgm_play("BGM_To_Main")
	

	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Gawain_preload()
	setup2D_Vernarth_preload()
	setup2D_Ragnar_preload()
	setup2D_Rasia_preload()
	setup2D_Guinevere_preload()
end
