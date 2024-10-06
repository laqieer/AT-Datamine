Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()

	demo_setup_nofade()

	setup2D_Noir()

	load_sound("VO_story01_op")
end

function Play()
	Play_start(false)

	--ノワールセリフ
	change_face(Noir2, "Pain")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) --ノワール
	message("BT_TUTORIAL08_020001") --なんだこいつ…！
	close_speech_window()

	--ダイアログ
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(67))
	wait_proccess(OpenTutorialPopup())

	-- ティル待機
	unit_command_stay(2, false)
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	preload_sound("VO_story01_op")
end
