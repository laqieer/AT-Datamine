Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript__sample", "label_camera")

-- アセットなどを読み込む
function Load()
	demo_setup()

	initialize_MA0010023(-1)
end

-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	play_MA0010023()

	Play_end(true)
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
