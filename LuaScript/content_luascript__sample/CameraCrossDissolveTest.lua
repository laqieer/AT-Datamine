Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript__sample", "label_camera")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室
	
	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	Camera02 = set_camera(-2.74, 1.531, 1.382, 0.0, 90.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	setup_Noir({0.0, 0, -1.15, 0});
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	while true do
		open_select_window_direct(nil, "Normal", "カメラ１からカメラ２へ", "カメラ２からカメラ１へ", "キャプチャカメラ１からカメラ２へ", "キャプチャカメラ２からカメラ１へ", "終了")
		if is_select(1) then
			on_camera(Camera01)
			crossdissolve(Camera02, 5.0, false)
			wait_time(5.0)
		elseif is_select(2) then
			on_camera(Camera02)
			crossdissolve(Camera01, 5.0, false)
			wait_time(5.0)
		elseif is_select(3) then
			on_camera(Camera01)
			crossdissolve(Camera02, 5.0, true)
			wait_time(5.0)
		elseif is_select(4) then
			on_camera(Camera02)
			crossdissolve(Camera01, 5.0, true)
			wait_time(5.0)
		elseif is_select(5) then
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
	load_scene_preload("content_areascene_110011", "Area110011")
	setup_Noir_preload({0.0, 0, -1.15, 0})
end
