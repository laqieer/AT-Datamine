Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	-- テストの対象を決める
	open_narration_window()
	while true do
		message_direct("テストの対象を選択します")
		open_select_window_direct(nil, "Normal", "フォグON", "フォグOFF", "フォグ設定", "フォグリセット", "終了")
		if is_select(1) then
			fog_active()
		elseif is_select(2) then
			fog_deactive()
		elseif is_select(3) then
			open_select_window_direct(nil, "Normal", "フォグ白,0～10,0.5", "フォグ黒,0～10,0.5", "フォグ白,5～10,0.01", "フォグ黒,5～10,0.01", "終了")
			if is_select(1) then
				fog_set_parameter("#FFFFFF", 0, 10, 0.5)
			elseif is_select(2) then
				fog_set_parameter("#000000", 0, 10, 0.5)
			elseif is_select(3) then
				fog_set_parameter("#FFFFFF", 5, 10, 0.01)
			elseif is_select(4) then
				fog_set_parameter("#000000", 5, 10, 0.01)
			else
			end	
		elseif is_select(4) then
			fog_reset()
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
