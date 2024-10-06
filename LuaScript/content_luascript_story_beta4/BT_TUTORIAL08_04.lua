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

-- プレイヤーフェイズ2
function Play()
	Play_start(false)

	--ティルフィングセリフ
	change_face(Tyrfing2, "Normal")
	open_speech_window("CHRNAME_TYRFING",Tyrfing2,nil) --ティルフィング
	message("BT_TUTORIAL08_040001") --マスター、ヴィジョン・シフトで～
	close_speech_window()

	--ノワールセリフ
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir2,nil) --ノワール
	message("BT_TUTORIAL08_040002") --わかった！
	close_speech_window()

	--ダイアログ
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(69))
	wait_proccess(OpenTutorialPopup())

	--ノワール計略
	manual_command_skill(1, 8, 5, 9, 6, 1)
	
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
