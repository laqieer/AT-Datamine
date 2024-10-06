Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Elaine()
	setup2D_Dinatan()

end

function Play()
	Play_start(false)
	
	open_speech_window("NPCNAME_0393",nil,nil)
	message("EA_009_0440002")
	close_speech_window()
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("EA_009_0440003")
	--close_speech_window()
	
	change_face(Noir2,"Anger")
	--open_speech_window("CHRNAME_NOIR",Noir,nil)
	message("EA_009_0440004")
	--close_speech_window()
		

	message("EA_009_0440005")
	--close_speech_window()
		
	change_face(Noir2,"Serious")
	--表情は真剣だが自分自身にも跳ね返ってくるセリフなので下記のボイスを採用
	PlayPartVoiceDirect("ノワール","0021")
	message("EA_009_0440006")
	close_speech_window()
		
	change_face(Elaine2,"Sad")
	open_speech_window("CHRNAME_ELAINE",Elaine2,nil)
	voice_play("VO_101030_sp_0001_3")
	message("EA_009_0440007")
	close_speech_window()
	
		
	change_face(Dinatan,"Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan,nil)
	message("EA_009_0440008")
	close_speech_window()
		
	open_speech_window("NPCNAME_0393",nil,nil)
	message("EA_009_0440009")
	--close_speech_window()
		
	--open_speech_window("NPCNAME_0393",nil,nil)
	message("EA_009_0440010")
	--close_speech_window()
		
	--open_speech_window("NPCNAME_0393",nil,nil)
	message("EA_009_0440011")
	close_speech_window()
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Elaine_preload()
	setup2D_Dinatan_preload()
end
