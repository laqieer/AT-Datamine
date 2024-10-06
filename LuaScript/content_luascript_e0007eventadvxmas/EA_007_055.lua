Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Mordred()
	Clarice = set_chara_unknown()
	character2DFull(Clarice, "Clarice", 101023003 )

end

function Play()
	Play_start(false)

	
	change_face(Mordred,"Normal")
	PlayPartVoiceDirect("モルドレッド","0019")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("EA_007_0550002")
	close_speech_window()

	change_face(Noir2,"Normal")
	open_speech_window("PLAYERNAME_NOIR",Noir2,nil)
	message("EA_007_0550003")
	close_speech_window()
	
	change_face(Mordred,"Smile")
	PlayPartVoiceDirect("モルドレッド","0010")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("EA_007_0550004")
	close_speech_window()
	
	open_speech_window("NPCNAME_0386",nil,nil)
	message("EA_007_0550005")
	close_speech_window()
	
	change_face(Mordred,"Normal")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("EA_007_0550006")
	close_speech_window()

	open_speech_window("NPCNAME_0386",nil,nil)
	message("EA_007_0550007")
	close_speech_window()

	change_face(Mordred,"Surprise")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("EA_007_0550009")
	close_speech_window()

	change_face(Clarice,"Smile")
	open_speech_window("CHRNAME_CLARICE",Clarice,nil)
	PlayPartVoiceDirect("クラリス","0011")
	message("EA_007_0550010")
	close_speech_window()

	change_face(Mordred,"Normal")
	PlayPartVoiceDirect("モルドレッド","0021")
	open_speech_window("CHRNAME_MORDRED",Mordred,nil)
	message("EA_007_0550011")
	close_speech_window()


	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Mordred_preload()
	character2DFull_Preload(Clarice, "Clarice", 101023003)
end
