Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
	movie_load("MA_01100_04", nil)
	movie_load("MA_01104_15")
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	open_narration_window()
	message_direct("字幕あり動画再生")
	close_narration_window()
	movie_set_active(true)
	movie_play()
	movie_wait_playing()
	movie_stop()

	open_narration_window()
	message_direct("5秒後ポーズ動作確認")
	close_narration_window()
	
	movie_play_assign("MA_01100_04")
	
	wait_time(5.0)
	
	movie_pause()
	
	open_narration_window()
	message_direct("再開動作確認")
	close_narration_window()

	movie_play()

	movie_wait_playing()

	movie_stop()
	movie_set_active(false)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
	movie_load_preload("MA_01104_15")
end
