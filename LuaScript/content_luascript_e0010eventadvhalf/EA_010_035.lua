Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Laevatein()

end

function Play()
	Play_start(false)

	
	change_face(Laevatein,"Pain")
	open_speech_window("CHRNAME_LAEVATEIN",Laevatein,nil)
	message("EA_010_0350002")
	
	change_face(Laevatein,"Pain")
	message("EA_010_0350003")

	change_face(Laevatein,"Pain")
	message("EA_010_0350005")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Laevatein_preload()
end
