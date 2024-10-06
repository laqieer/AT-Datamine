Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript__sample", "label_camera")

-- アセットなどを読み込む
function Load()
	demo_setup()

	load_timeline("content_adv_timeline_timelinemovietest_scene", "TimelineMovieTest")
	load_area_scene(110011) -- 教室
	load_sound("SE_ADV_Movie")

	Camera01 = set_camera(-4, 1.76, 3, 1.3, 130, 0.0, 26)
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	open_narration_window()
	message_direct("タイムラインテスト")
	close_narration_window()
	
	play_timeline("TimelineMovieTest", false, fadefunc)

	Play_end(true)
end

function fadefunc()
	fadeout(0, 0, 0, 0, 0.3)
	wait_time(0.3)
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_timeline_preload("content_adv_timeline_timelinemovietest_scene", "TimelineMovieTest")
	load_area_scene_preload(110011)
end
