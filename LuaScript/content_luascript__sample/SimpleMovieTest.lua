Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
	simple_movie_load("ADV/MV_hoshimachi", nil, false)
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	open_narration_window()
	message_direct("DLC内動画再生")
	close_narration_window()
	simple_movie_set_active(true)
	simple_movie_play()
	simple_movie_wait_playing()
	simple_movie_stop()
	simple_movie_set_active(false)

	open_narration_window()
	message_direct("RawData動画再生")
	close_narration_window()
	simple_movie_load("Tutorial/tutorial_customskill", nil, true)
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
	load_area_scene_preload(110011)
	simple_movie_load_preload("ADV/MV_hoshimachi", nil)
	system.PreDownloadMovieRequest("Tutorial/tutorial_customskill", true)
end
