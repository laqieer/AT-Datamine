Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript__sample", "label_camera")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_duel_scene(101000021)
	
	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	setup_Noir({0.0, 0, -1.15, 0});
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	while true do
		open_select_window_direct(nil, "Normal", "曇り", "雨", "終了")
		if is_select(1) then
			change_weather_cloudy(true)
			wait_time(5.0)
		elseif is_select(2) then
			change_weather_cloudy(false)
			wait_time(5.0)
		elseif is_select(3) then
			break;
		end
	end

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_duel_scene_preload(101000021)
	setup_Noir_preload({0.0, 0, -1.15, 0})
end
