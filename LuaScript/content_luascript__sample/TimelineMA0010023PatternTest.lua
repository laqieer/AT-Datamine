Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript__sample", "label_camera")

-- アセットなどを読み込む
function Load()
	demo_setup()
end

-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	open_select_window_direct(nil, "Normal", "男性１", "女性１", "男性２", "女性２", "男性３", "女性３")
	if is_select(1) then
		initialize_MA0010023(101003)
	elseif is_select(2) then
		initialize_MA0010023(101004)
	elseif is_select(3) then
		initialize_MA0010023(101005)
	elseif is_select(4) then
		initialize_MA0010023(101006)
	elseif is_select(5) then
		initialize_MA0010023(101007)
	elseif is_select(6) then
		initialize_MA0010023(101008)
	end

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
