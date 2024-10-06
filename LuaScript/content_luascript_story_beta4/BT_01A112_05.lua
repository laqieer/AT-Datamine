Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Guinevere()
	setup2D_Fren()

end

function Play()
	Play_start(false)
	
	
	
				
	
	
	change_face(Fren2,"Smile")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("BT_01A112_050004")
	close_speech_window()

	
	change_face(Guinevere2,"Sad")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	message("BT_01A112_050005")
	close_speech_window()

	
	change_face(Fren2,"Smile")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("BT_01A112_050006")
	close_speech_window()

	
	change_face(Guinevere2,"Anger")
	open_speech_window("CHRNAME_GUINEVERE2",Guinevere2,nil)
	message("BT_01A112_050007")
	close_speech_window()

	
	change_face(Fren2,"Smile")
	open_speech_window("CHRNAME_FREN2",nil,Fren2)
	message("BT_01A112_050008")

	
	change_face(Fren2,"Smile")
	message("BT_01A112_050009")
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
	setup2D_Fren_preload()
end
