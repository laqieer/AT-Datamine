Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Gwenhwymawr()

	load_sound("BGM_Battle_Boss_Start")
	
end

function Play()
	Play_start(false) 

	change_face(Gwenhwymawr2, "Pain")
	open_speech_window("CHRNAME_GWENHWYMAWR2", nil, Gwenhwymawr2)	
		message("BT_01C201_0110")
		message("BT_01C201_0111")
	change_face(Gwenhwymawr2, "Smile")
		message("BT_01C201_0112")
		message("BT_01C201_0113")
	close_speech_window()	

	bgm_play("BGM_Battle_Boss_Start")
	


	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Gwenhwymawr_preload()
	preload_sound("BGM_Battle_Boss_Start")
end
