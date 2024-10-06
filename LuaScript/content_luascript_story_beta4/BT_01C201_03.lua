Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)
	
	setup2D_Guinevere()

	load_sound("BGM_Battle_Boss_Start")
	
end

function Play()
	Play_start(false) 

	change_face(Guinevere, "Pain")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)	
		message("BT_01C201_0116")
		message("BT_01C201_0117")
		message("BT_01C201_0118")
	change_face(Guinevere, "Sad")
		message("BT_01C201_0119")
	close_speech_window()	

	bgm_play("BGM_Battle_Boss_Start")
	

	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Guinevere_preload()
	preload_sound("BGM_Battle_Boss_Start")
end
