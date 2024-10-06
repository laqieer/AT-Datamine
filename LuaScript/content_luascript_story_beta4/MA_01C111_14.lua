Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Dinatan()
	setup2D_Maladisant()
	setup2D_Gareth()
	setup2D_Lyoness()

end

function Play()
	Play_start(false)
	
	
	
	change_face(Gareth,"Normal")
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	 --PlayPartVoice("ガレス", "落胆")
	message("MA_01C111_140002")
	close_speech_window()

	
	open_speech_window("NPCNAME_0086",nil,nil)
	 --PlayPartVoice("市民_男2", "喜び")
	message("MA_01C111_140003")

	
	message("MA_01C111_140004")
	close_speech_window()

	
	change_face(Lyoness2,"Smile")
	open_speech_window("CHRNAME_LYONESS2",Lyoness2,nil)
	 --PlayPartVoice("リオネス", "肯定2")
	message("MA_01C111_140005")
	close_speech_window()

	
	
	change_face(Noir2,"Sad")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "悩む")
	message("MA_01C111_140007")
	close_speech_window()

	
	change_face(Gareth,"Normal")
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	 --PlayPartVoice("ガレス", "悩む")
	message("MA_01C111_140008")
	close_speech_window()

	
	change_face(Dinatan2,"Sad")
	open_speech_window("CHRNAME_DINATAN2",Dinatan2,nil)
	 --PlayPartVoice("ディナタン", "悩む")
	message("MA_01C111_140009")
	close_speech_window()

	
	change_face(Maladisant2,"Normal")
	open_speech_window("CHRNAME_MALADISANT2",Maladisant2,nil)
	 --PlayPartVoice("マルディサント", "落胆")
	message("MA_01C111_140010")
	close_speech_window()

	
	change_face(Gareth,"Smile")
	open_speech_window("CHRNAME_GARETH",Gareth,nil)
	 --PlayPartVoice("ガレス", "笑い")
	message("MA_01C111_140011")
	close_speech_window()

	
	change_face(Noir2,"Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	 --PlayPartVoice("ノワール", "肯定2")
	message("MA_01C111_140012")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Dinatan_preload()
	setup2D_Maladisant_preload()
	setup2D_Gareth_preload()
	setup2D_Lyoness_preload()
end
