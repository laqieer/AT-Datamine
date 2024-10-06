Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Guinevere()
	setup2D_Sisters_3()
	setup2D_Sisters_5()

end

function Play()
	Play_start(false)

	
	
	change_face(Guinevere,"Surprise")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil)
	 --PlayPartVoice("ギネヴィア","驚き")
	message("MA_01C111_040002")
	close_speech_window()

	
	change_face(Sisters_5,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	 --PlayPartVoice("グリートン","喜び")
	message("MA_01C111_040003")
	close_speech_window()

	
	change_face(Sisters_3,"Normal")
	open_speech_window("CHRNAME_SISTERS_3",nil,Sisters_3)
	message("MA_01C111_040004")

	
	change_face(Sisters_3,"Smile")
	 --PlayPartVoice("グリーテン","喜び")
	message("MA_01C111_040005")
	close_speech_window()

	
	change_face(Sisters_5,"Normal")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	 --PlayPartVoice("グリートン","笑い")
	message("MA_01C111_040006")
	close_speech_window()

	
	change_face(Noir2,"Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール","驚き")
	message("MA_01C111_040007")
	close_speech_window()

	
	change_face(Sisters_3,"Anger")
	open_speech_window("CHRNAME_SISTERS_3",nil,Sisters_3)
	 --PlayPartVoice("グリーテン","挨拶")
	message("MA_01C111_040008")
	close_speech_window()

	
	
	
	change_face(Sisters_5,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	 --PlayPartVoice("グリートン","肯定2")
	message("MA_01C111_040010")
	close_speech_window()


	open_cutin(2,1)
	on_cutin(1,Sisters_3,"Smile",0)
	on_cutin(2,Sisters_5,"Smile",0)

	
	open_speech_window("CHRNAME_SISTERS_3_5",nil,nil)
	message("MA_01C111_040011")
	close_speech_window()

	close_cutin()
	
	


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Guinevere_preload()
	setup2D_Sisters_3_preload()
	setup2D_Sisters_5_preload()
end
