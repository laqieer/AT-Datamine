Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "BranchSelect")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)

	load_branch_select()
	change_scene("")
	-- 選択シーンを非アクティブにする


	movie_load("MA_01108_48_1")
end

-- シーケンスの実行
function Play()

	
	fadein(0)
	Play_start(true)

	movie_set_active(true)

	movie_play()
	movie_wait_playing()

	movie_load("MA_01108_48_2")
	movie_play()
	movie_wait_playing()

	movie_load("MA_01108_48_3")
	movie_play()
	movie_wait_playing()

	fadeout(1.0, 1.0, 1.0, 1.0, 0.5)
	wait_time(0.5)

	movie_set_active(false)

	fadein(0)
	play_branch_select()


	fadeout(1.0, 1.0, 1.0, 1.0, 0.0)
	set_selected_option()
	-- 選択シーンを非アクティブにする
	change_scene("")

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	movie_load_preload("MA_01108_48_1")
end
