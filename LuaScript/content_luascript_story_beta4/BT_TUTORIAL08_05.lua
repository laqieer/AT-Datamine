Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()

	demo_setup_nofade()

	setup2D_Noir()
	setup2D_Tyrfing()

	load_sound("VO_story01_op")
end

function Play()
	Play_start(false)

	--ノワールセリフ
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) --ノワール
	message("BT_TUTORIAL08_050001") --バリアを破った！
	close_speech_window()

	--ティルフィングセリフ
	change_face(Tyrfing2, "Anger")
	open_speech_window("CHRNAME_TYRFING",Tyrfing2,nil) --ティルフィング
	message("BT_TUTORIAL08_050002") --万物を切り裂く魔剣の切れ味…
	close_speech_window()

	--ティルシングル
	manual_command_skill(2, 8, 7, 9, 7, 2)
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Tyrfing_preload()
	preload_sound("VO_story01_op")
end
