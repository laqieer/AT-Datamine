Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)
	
	setup2D_Galahad()
	setup2D_Noir()
	
end

function Play()
	Play_start(false)
	
	
	
	
	change_face(Galahad2,"Pain")
	open_speech_window("CHRNAME_GALAHAD",Galahad2,nil)
	message("BT_01A111_040003")
	close_speech_window()	
	
	
	change_face(Noir2,"Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)
	message("BT_01A111_040004")
	close_speech_window()	
	
	
	change_face(Galahad2,"Pain")
	open_speech_window("CHRNAME_GALAHAD",Galahad2,nil)
	message("BT_01A111_040005")
	
	
	change_face(Galahad2,"Pain")
	message("BT_01A111_040006")
	
	
	change_face(Galahad2,"Sad")
	message("BT_01A111_040007")
	
	
	change_face(Galahad2,"Sad")
	message("BT_01A111_040008")
	close_speech_window()	
	
	
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Galahad_preload()
	setup2D_Noir_preload()
end
