Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Merlin()
	setup2D_Sisters_5()
	setup2D_Sisters_4()
	setup2D_Noir()

end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Sisters_5,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	 --PlayPartVoice("グリートン", "喜び")
	message("MA_01C111_280002")
	close_speech_window()
	
	
	change_face(Sisters_4,"Normal")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	message("MA_01C111_280003")
	close_speech_window()
	
	
	
	change_face(Merlin,"Anger")
	open_speech_window("CHRNAME_MERLIN",Merlin,nil)
	 --PlayPartVoice("マーリン", "怒り")
	message("MA_01C111_280005")
	close_speech_window()
	
	
	
	change_face(Sisters_5,"Anger")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	 --PlayPartVoice("グリートン", "肯定3")
	message("MA_01C111_280007")
	close_speech_window()
		
	
	change_face(Merlin,"Anger")
	open_speech_window("CHRNAME_MERLIN",Merlin,nil)
	 --PlayPartVoice("マーリン", "肯定2")
	message("MA_01C111_280008")
	close_speech_window()
	
	
	change_face(Sisters_4,"Normal")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	message("MA_01C111_280009")
	
	
	change_face(Sisters_4,"Smile")
	 --PlayPartVoice("グリートーネア", "笑い")
	message("MA_01C111_280010")
	close_speech_window()
	
	
	change_face(Sisters_5,"Smile")
	open_speech_window("CHRNAME_SISTERS_5",nil,Sisters_5)
	 --PlayPartVoice("グリートン", "笑い")
	message("MA_01C111_280011")
	close_speech_window()
	
	
	change_face(Merlin,"Pain")
	open_speech_window("CHRNAME_MERLIN",Merlin,nil)
	 --PlayPartVoice("マーリン", "苦しみ")
	message("MA_01C111_280012")
	close_speech_window()
	
	
	change_face(Sisters_4,"Smile")
	open_speech_window("CHRNAME_SISTERS_4",nil,Sisters_4)
	 --PlayPartVoice("グリートーネア", "喜び")
	message("MA_01C111_280013")
	close_speech_window()
	
	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("MA_01C111_280015")
	close_speech_window()
	
	
	change_face(Merlin,"Anger")
	open_speech_window("CHRNAME_MERLIN",Merlin,nil)
	message("MA_01C111_280016")
	close_speech_window()
	
	
				
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Merlin_preload()
	setup2D_Sisters_5_preload()
	setup2D_Sisters_4_preload()
	setup2D_Noir_preload()
end
