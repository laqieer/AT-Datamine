Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

disableTextBox = true

function Load()

	demo_setup_nofade()

end

function Play()
	Play_start(false)

	--ダイアログ
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(57))
	wait_proccess(OpenTutorialPopup())

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
