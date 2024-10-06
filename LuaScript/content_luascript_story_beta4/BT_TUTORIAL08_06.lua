Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

disableTextBox = true

function Load()

	demo_setup_nofade()

	setup2D_Noir()
	setup2D_Tyrfing()

end

function Play()
	Play_start(false)

	--ダイアログ
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(68))
	wait_proccess(OpenTutorialPopup())
	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Tyrfing_preload()
end
