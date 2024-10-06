Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)

	--ボタン制御
	ShowGlobalMenuButton(false)
	
	movie_load("MA_00100_08")
		movie_set_active(true)

	movie_play()

end

-- シーケンスの実行
function Play()

	fadein(0)
	Play_start(true)

	movie_wait_playing()

	movie_stop()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	movie_load_preload("MA_00100_08")
end
