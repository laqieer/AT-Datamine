Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	FX_Refractive = load_postprocess("content_adv_postprocess_refractive", "Ef_C_PP_Refractive", false)
	FX_Distortion = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Distortion", false, true)
	set_pos(FX_Distortion, {0, 1, -2})
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	off_screencolor()
	fadein(0)
	Play_start(true)

	-- テストの対象を決める
	open_narration_window()
	message_direct("歪みエフェクトのテスト開始")
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "ポストエフェクト", "オブジェクト", "終了")
		if is_select(1) then
			while true do
				message_direct("選択してください")
				open_select_window_direct(nil, "Normal", "ON", "OFF", "フェードイン", "フェードアウト", "終了")
				if is_select(1) then
					on_active(FX_Refractive)
					set_postprocess_weight(FX_Refractive, 1.0)
					message_direct("ON")
				elseif is_select(2) then
					off_active(FX_Refractive)
					message_direct("OFF")
				elseif is_select(3) then
					on_active(FX_Refractive)
					change_postprocess_weight(FX_Refractive, 0.0, 1.0, 2.0)
					wait_time(2)
					message_direct("フェードイン終了")
				elseif is_select(4) then
					on_active(FX_Refractive)
					change_postprocess_weight(FX_Refractive, 1.0, 0.0, 2.0)
					wait_time(2)
					message_direct("フェードアウト終了")
					off_active(FX_Refractive)
				else
					break
				end
			end
		elseif is_select(2) then
			while true do
				message_direct("選択してください")
				open_select_window_direct(nil, "Normal", "オブジェクト有効", "オブジェクト無効", "終了")
				if is_select(1) then
					on_active(FX_Distortion)
				elseif is_select(2) then
					off_active(FX_Distortion)
				else
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
	load_area_scene_preload(110011)
	load_postprocess_preload("content_adv_postprocess_refractive", "Ef_C_PP_Refractive", false)
	load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Distortion", false, true)
end
