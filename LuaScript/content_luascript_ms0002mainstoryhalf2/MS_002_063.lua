Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_S_Alham()

end

function Play()
	Play_start(false)

	change_face(Alham,"Normal")
	open_speech_window("NPCNAME_0313",Alham,nil)
	message("MS_002_0630004")
	
	message("MS_002_0630005")
	
    change_face(Alham,"Anger")
    PlayPartVoiceDirect("アルハン","0035")
	message("MS_002_0630006")
	close_speech_window()

	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Alham_preload()
end
