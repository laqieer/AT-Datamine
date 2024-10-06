Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Gawain()
	setup2D_Vernarth()

end

function Play()
	Play_start(false)
	
	
				
	
	change_face(Gawain,"Pain")
	open_speech_window("CHRNAME_GAWAIN",Gawain,nil)
	PlayPartVoice("ガウェイン", "怒り")
	message("BT_01A110_0214")
	close_speech_window()
	
	
	change_face(Vernarth,"Anger")
	open_speech_window("CHRNAME_VERNARTH",nil,Vernarth)
	PlayPartVoice("ヴェルナルス", "激怒")
	message("BT_01A110_0215")
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
end
