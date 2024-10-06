Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

disableTextBox = true

function Load()
	demo_setup_nofade()

end

-- プレイヤーフェイズ3
function Play()

	-- ノワールを選択しダブル解除を指示

	-- 左におろす
	-- manual_command_release_double(1, 9, 12, 8, 12)

	-- 下におろす
	manual_command_release_double(1, 9, 12, 9, 13)


	-- チュートリアルダイアログ：ダブルの解除について
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(3))
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
