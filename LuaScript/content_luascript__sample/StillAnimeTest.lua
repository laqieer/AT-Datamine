Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript__sample", "label_camera")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室
	
	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	setup_Noir({0.0, 0, -1.15, 0});

	stillAnime = load_ui_effect("content_still_10102015_anim", "10102015_StillAnim", nil, nil, nil, "Root")
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	close_textbox_base()

	fadeout(0, 0, 0, 1, 0.5)
	wait_time(0.5)
	stillAnime.SetActive(true)
	local signal = play_ui_timeline_controller_in(stillAnime)
	fadein(0)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	wait_time(3)	

	open_textbox_base()
	open_narration_window()
	message_direct("いいと思います")
	close_narration_window()
	close_textbox_base()

	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	fadeout(0, 0, 0, 1, 0)
	stillAnime.SetActive(false)
	fadein(0.5)
	wait_time(0.5)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
	setup_Noir_preload({0.0, 0, -1.15, 0})
	load_ui_effect_preload("content_still_10103013_anim", "10103013_StillAnim", nil, nil, nil, "Root")
end
