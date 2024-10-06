Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Gawain()
	setup2D_Vernarth()
	setup2D_Ragnar()
	setup2D_Elaine()
	setup2D_Rasia()

end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Vernarth,"Surprise")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("BT_01A111_0203")
	close_speech_window()	

	
	change_face(Ragnar2,"Smile")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2,nil)
	message("BT_01A111_0204")
	close_speech_window()	

	
	change_face(Gawain,"Serious")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	message("BT_01A111_0205")
	close_speech_window()	

	
	change_face(Ragnar2,"Anger")
	open_speech_window("CHRNAME_RAGNAR2",Ragnar2,nil)
	message("BT_01A111_0206")
	close_speech_window()	

	
	change_face(Vernarth,"Serious")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	message("BT_01A111_0207")
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
	setup2D_Elaine_preload()
	setup2D_Rasia_preload()
end
