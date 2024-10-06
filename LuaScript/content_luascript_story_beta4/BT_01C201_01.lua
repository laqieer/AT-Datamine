Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Guinevere()
	setup2D_Gwenhwymawr()
	
end

function Play()
	Play_start(false) 

	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)	
	PlayPartVoice("ギネヴィア", "挨拶")
		message("BT_01C201_0103")
		message("BT_01C201_0104")
	change_face(Guinevere, "Sad")
		message("BT_01C201_0105")
		message("BT_01C201_0106")
	close_speech_window()	


	change_face(Noir, "Sad")
	open_speech_window("CHRNAME_NOIR",Noir,nil)	
	PlayPartVoice("ノワール", "落胆")
		message("BT_01C201_0107")
	close_speech_window()	
	
	change_face(Guinevere, "Sad")
	PlayPartVoice("ギネヴィア", "落胆")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)	
		message("BT_01C201_0108")
	close_speech_window()

	bgm_play("BGM_To_Main")

		
	


	
	Play_end(false) 
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Guinevere_preload()
	setup2D_Gwenhwymawr_preload()
end
