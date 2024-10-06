Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	Camera02 = set_camera(-2.74, 1.531, 1.382, 0.0, 90.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
--	on_camera(Camera02)
	fadein(0)
	Play_start(true)

	shake_camera(Camera02, 3.0, 30)

	-- テストの対象を決める
	open_narration_window()
	message_direct("カメラクエイクのテスト開始")
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "normal", "通常確認", "カメラ切り替え確認", "終了")
		if is_select(1) then
			while true do
				on_camera(Camera01)
				open_select_window_direct(nil, "normal", "強度0.5の１秒", "強度1の２秒", "強度1.5の無限", "停止", "終了")
				if is_select(1) then
					shake_camera(Camera01, 0.5, 1)
					message_direct("強度0.5の１秒")
				elseif is_select(2) then
					shake_camera(Camera01, 1, 2)
					message_direct("強度1の２秒")
				elseif is_select(3) then
					shake_camera(Camera01, 1.5, 0)
					message_direct("強度1.5の無限")
				elseif is_select(4) then
					stop_shake_camera(Camera01)
				else
					break
				end
			end
		elseif is_select(2) then
			while true do
				open_select_window_direct(nil, "normal", "カメラ１振動", "カメラ２振動", "カメラ１へ", "カメラ２へ", "終了")
				if is_select(1) then
					shake_camera(Camera01, 0.5, 20)
					message_direct("カメラ１強度0.5の２０秒")
				elseif is_select(2) then
					shake_camera(Camera02, 1, 20)
					message_direct("カメラ２強度1の２０秒")
				elseif is_select(3) then
					on_camera(Camera01)
					message_direct("カメラ１")
				elseif is_select(4) then
					on_camera(Camera02)
					message_direct("カメラ２")
				else
					stop_shake_camera(Camera01)
					stop_shake_camera(Camera02)
					break
				end
			end
		else
			break
		end
	end
	message_direct("終了します")
	close_speech_window()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
end
