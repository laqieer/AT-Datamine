Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "BranchSelect")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)
end

-- シーケンスの実行
function Play()

	
	fadein(0)
	Play_start(true)

	-- 
	open_select_window_direct(nil, "Normal", "gld", "gl", "ld", "gd", "g", "l", "d")
	if is_select(1) then
		load_branch_select({101010001, 101011001, 101012001})
	elseif is_select(2) then
		load_branch_select({101010001, 101011001})
	elseif is_select(3) then
		load_branch_select({101010001, 101012001})
	elseif is_select(4) then
		load_branch_select({101011001, 101012001})
	elseif is_select(5) then
		load_branch_select({101011001})
	elseif is_select(6) then
		load_branch_select({101010001})
	elseif is_select(7) then
		load_branch_select({101012001})
	end
	play_branch_select()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
