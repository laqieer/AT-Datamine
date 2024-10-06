Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_S_Freikugel(2)

end

function Play()
	Play_start(false)
	
	change_face(Freikugel2,"Laugh")
	open_speech_window("CHRNAME_FREIKUGEL",Freikugel2,nil)
	voice_play("VO_101070001_sp_0001_1")
	message("MS_002_0840002")
	
	change_face(Freikugel2,"Smile")
	PlayPartVoiceDirect("フライクーゲル","0069")
	message("MS_002_0840003")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Freikugel_preload(2)
end
