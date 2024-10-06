Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室
	
	setup_Noir({1.050, 0.0, -1.610, 180.0})

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	while true do
	
			open_speech_window(nil, nil, nil)
			message_direct("ああああああああああああああああああああああいいいいいいいいいい")
			close_speech_window()

			open_mind_window(nil, nil, nil)
			message_direct("ああああああああああああああああああああああいいいいいいいいいい")
			close_mind_window()

			open_simple_window(nil)
			message_direct("ああああああああああああああああああああああいいいいいいいいいい")
			close_simple_window()

			open_narration_window()
			message_direct("ああああああああああああああああああああああいいいいいいいいいい")
			close_narration_window()

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
	setup_Noir_preload({1.050, 0.0, -1.610, 180.0})
end
