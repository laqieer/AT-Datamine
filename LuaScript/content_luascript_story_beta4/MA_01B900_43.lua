Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

setup2D_Morgan()

end

function Play()
	Play_start(false)

	change_face(Morgan2, "Normal")
	open_speech_window("CHRNAME_MORGAN2", nil, Morgan2)
	message("MA_01B900_430002")
	
	change_face(Morgan2, "Normal")
	message("MA_01B900_430003")
	
	change_face(Morgan2, "Normal")
	message("MA_01B900_430004")
	
	change_face(Morgan2, "Normal")
	message("MA_01B900_430005")
	
	change_face(Morgan2, "Normal")
	message("MA_01B900_430006")
	
	change_face(Morgan2, "Normal")
	message("MA_01B900_430007")
	close_speech_window()

	bgm_play("BGM_To_Main")




	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup2D_Morgan_preload()
end