Include("content_luascript_system", "SystemFunctions")
Include("content_luascript_system", "CameraFunctions")
Include("content_luascript_system", "UiFunctions")
Include("content_luascript_system", "UiHeaderFooter", { "open_footer_ui" })

-- アセットなどを読み込む
function Load()
	load_ui()
    Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
    set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
end

-- シーケンスの実行
function Play()
	fadein(0)
	open_footer_ui()
	
	while true do
		coroutine.yield()
	end
	
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
