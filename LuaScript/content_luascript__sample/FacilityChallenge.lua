Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
    demo_setup()
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	demo_start()
	
	open_narration_window()
	message_direct("挑戦します")
	close_narration_window()
	
	-- 難易度を内部で判定して指定したfunctionに処理を移動する
	-- 成功していればsuccess
	-- 失敗していればfail
	play_challenge(success, fail)
	
	demo_end()
end

-- 成功時処理
function success(humanParam)
    open_narration_window()
	message_direct("挑戦成功")
	close_narration_window()
	play_result(humanParam)
end

-- 失敗時処理
-- string message = 失敗理由
function fail(message)
    open_narration_window()
	message_direct("挑戦失敗")
	message_direct(message)
	close_narration_window()
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
end
