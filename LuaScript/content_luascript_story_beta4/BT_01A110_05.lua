Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Guinevere()
	setup2D_Lola()
	setup2D_Noir()
	setup2D_Sisters_4()
	
end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Guinevere2,"Normal")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	message("BT_01A110_0503")
	close_speech_window()
	
	
	change_face(Lola2,"Pain")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("BT_01A110_0504")
	close_speech_window()
	
	
	change_face(Guinevere2,"Sad")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	message("BT_01A110_0505")
	close_speech_window()
	
	
	change_face(Lola2,"Sad")
	open_speech_window("CHRNAME_LOLA2",nil,Lola2)
	message("BT_01A110_0506")
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
	setup2D_Lola_preload()
	setup2D_Noir_preload()
	setup2D_Sisters_4_preload()
end
