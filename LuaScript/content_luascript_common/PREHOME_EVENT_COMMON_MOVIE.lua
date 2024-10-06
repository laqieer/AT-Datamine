Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	simple_movie_load(PreHomeEventArg1, nil, PreHomeEventArg2 == "true", tonumber(PreHomeEventArg3), tonumber(PreHomeEventArg4), PreHomeEventArg5=="vertical")
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	simple_movie_set_active(true)
	simple_movie_play()
	simple_movie_wait_playing()
	simple_movie_stop()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	simple_movie_load_preload(PreHomeEventArg1, nil, PreHomeEventArg2 == "true", tonumber(PreHomeEventArg3), tonumber(PreHomeEventArg4), PreHomeEventArg5=="vertical")
end
