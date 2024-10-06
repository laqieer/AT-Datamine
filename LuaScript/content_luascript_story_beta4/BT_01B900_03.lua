Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Lancelot()
	setup2D_Percival()
	setup2D_Dindrane()
	setup2D_Bors()
	setup2D_Clare()
	setup2D_Galahad()

end

function Play()

	Play_start(false)

	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	message("BT_01B900_030004")
	close_speech_window()	


	change_face(Lancelot2, "Anger")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2, nil)
	message("BT_01B900_030005")
	close_speech_window()	
	
	
	open_cutin(2,1)
	
	
	on_cutin(1,Noir2,"Serious",nil)
	on_cutin(2,Lancelot2,"Serious",nil)
	
	
	open_speech_window("CHRNAME_NOIR_LANCELOT",nil,nil)
	message("BT_01B900_030006")
	close_speech_window()
	
	
	close_cutin()

	open_speech_window("CHRNAME_NAMELES",nil, nil)
	message("BT_01B900_030007")
	close_speech_window()	


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil)	
	message("BT_01B900_030009")
	close_speech_window()	


	change_face(Dindrane2, "Normal")
	open_speech_window("CHRNAME_DINDRANE2",Dindrane2, nil)
	message("BT_01B900_030011")
	close_speech_window()	

	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	message("BT_01B900_030012")
	close_speech_window()	


	change_face(Percival, "Surprise")
	open_speech_window("CHRNAME_PERCIVAL",Percival, nil)
	message("BT_01B900_030014")
	close_speech_window()	


	change_face(Dindrane2, "Anger")
	open_speech_window("CHRNAME_DINDRANE2",Dindrane2, nil)
	message("BT_01B900_030015")
	close_speech_window()	


	open_speech_window("CHRNAME_NAMELES",nil, nil)
	message("BT_01B900_030016")
	close_speech_window()	


	change_face(Lancelot2, "Surprise")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2, nil)
	message("BT_01B900_030018")
	close_speech_window()	


	change_face(Clare2, "Normal")
	open_speech_window("CHRNAME_CLARE2",Clare2, nil)
	message("BT_01B900_030020")
	close_speech_window()	


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	message("BT_01B900_030021")
	close_speech_window()	


	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS",Bors, nil)
	message("BT_01B900_030023")
	close_speech_window()	

	change_face(Clare2, "Normal")
	open_speech_window("CHRNAME_CLARE2",Clare2, nil)
	message("BT_01B900_030024")

	change_face(Clare2, "Normal")
	message("BT_01B900_030026")
	close_speech_window()	


	change_face(Galahad2, "Normal")
	open_speech_window("CHRNAME_GALAHAD",Galahad2, nil)
	message("BT_01B900_030027")
	close_speech_window()	


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	message("BT_01B900_030028")
	close_speech_window()	
		

	open_speech_window("CHRNAME_GALAHAD",Galahad2, nil)
	message("BT_01B900_030029")

	message("BT_01B900_030030")

	message("BT_01B900_030031")
	close_speech_window()	


	change_face(Lancelot2, "Normal")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2, nil)
	message("BT_01B900_030032")
	close_speech_window()	


	change_face(Clare2, "Normal")
	open_speech_window("CHRNAME_CLARE2",Clare2, nil)
	message("BT_01B900_030033")
	close_speech_window()	


	change_face(Galahad2, "Anger")
	open_speech_window("CHRNAME_GALAHAD",Galahad2, nil)
	message("BT_01B900_030034")

	message("BT_01B900_030036")

	change_face(Galahad2, "Sad")

	message("BT_01B900_030037")

	change_face(Galahad2, "Smile")

	message("BT_01B900_030038")
	close_speech_window()	


	change_face(Lancelot2, "Smile")
	open_speech_window("CHRNAME_LANCELOT2",Lancelot2, nil)
	message("BT_01B900_030039")
	close_speech_window()	


	change_face(Noir2, "Surprise")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	message("BT_01B900_030040")
	close_speech_window()	


	open_speech_window("CHRNAME_LANCELOT2",Lancelot2, nil)
	message("BT_01B900_030041")
	close_speech_window()


	change_face(Noir2, "Smile")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) 
	message("BT_01B900_030042")
	close_speech_window()


	open_speech_window("CHRNAME_LANCELOT2",Lancelot2, nil)
	message("BT_01B900_030043")
	close_speech_window()	

	bgm_play("Reset_BGM_Bus_Volume")

	Play_end(false)

end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Lancelot_preload()
	setup2D_Percival_preload()
	setup2D_Dindrane_preload()
	setup2D_Bors_preload()
	setup2D_Clare_preload()
	setup2D_Galahad_preload()
end
