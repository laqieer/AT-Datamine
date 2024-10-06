Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 0, -1.15)

	FX_RadialBlur = load_postprocess("content_adv_postprocess_radialblur", "Ef_C_PP_RadialBlur", false)
	FX_MotionBlur = load_postprocess("content_adv_postprocess_motionblur", "Ef_C_PP_MotionBlur", false)
	FX_LinearBlur = load_postprocess("content_adv_postprocess_linearblur", "Ef_C_PP_LinearBlur", false)
	setup_Noir({0.0, 0, -1.15, 0});

	center_x = 0.5
	center_y = 0.5
	radius = 0.01
	iterationCount = 3

	motionblur_quality = "Low"
	motionblur_intensity = 0.5
	motionblur_clamp = 0.05

	intensity = 1
	direction = 0
	frequency = 50
	density = 1
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	off_screencolor()
	fadein(0)
	Play_start(true)

	-- テストの対象を決める
	open_narration_window()
	message_direct("Blurエフェクトのテスト開始")
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "radialblur", "motionblur", "linearblur", "終了")
		if is_select(1) then
			on_active(FX_RadialBlur)
			off_active(FX_MotionBlur)
			off_active(FX_LinearBlur)
			radialblur_test()
		elseif is_select(2) then
			off_active(FX_RadialBlur)
			off_active(FX_LinearBlur)
			on_active(FX_MotionBlur)
			motionblur_test()
		elseif is_select(3) then
			off_active(FX_RadialBlur)
			off_active(FX_MotionBlur)
			on_active(FX_LinearBlur)
			linearblur_test()
		else
			break
		end
	end
	message_direct("終了します")
	close_speech_window()

	Play_end(true)
end

function radialblur_test()
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "有効化", "無効化", "設定", "終了")
		if is_select(1) then
			on_active(FX_RadialBlur)
			message_direct("RadialBlur有効化")
		elseif is_select(2) then
			off_active(FX_RadialBlur)
			message_direct("RadialBlur無効化")
		elseif is_select(3) then
			set_radialblur_postprocess_parameter()
		else
			break
		end
	end
end

function set_radialblur_postprocess_parameter()
	while true do
		open_select_window_direct(nil, "Normal", "center x変更", "center y変更", "radius変更",  "iterationCount変更", "戻る")
		if is_select(1) then
			while true do
				message_direct_nowait("center_x = " .. center_x)
				open_select_window_direct(nil, "Normal", "+0.1", "-0.1", "リセット", "設定", "戻る")
				if is_select(1) then
					center_x = center_x + 0.1
				elseif is_select(2) then
					center_x = center_x - 0.1
				elseif is_select(3) then
					center_x = 0.5
				elseif is_select(4) then
					set_postprocess_vector2_paramter(FX_RadialBlur, "RadialBlurPostProcessVolume", "center", center_x, center_y)
				else
					break
				end
			end
		elseif is_select(2) then
			while true do
				message_direct_nowait("center_y = " .. center_y)
				open_select_window_direct(nil, "Normal", "+0.1", "-0.1", "リセット", "設定", "戻る")
				if is_select(1) then
					center_y = center_y + 0.1
				elseif is_select(2) then
					center_y = center_y - 0.1 
				elseif is_select(3) then
					center_y = 0.5
				elseif is_select(4) then
					set_postprocess_vector2_paramter(FX_RadialBlur, "RadialBlurPostProcessVolume", "center", center_x, center_y)
				else
					break
				end
			end
		elseif is_select(3) then
			while true do
				message_direct_nowait("radius = " .. radius)
				open_select_window_direct(nil, "Normal", "+0.005", "-0.005", "リセット", "設定", "戻る")
				if is_select(1) then
					radius = radius + 0.005
				elseif is_select(2) then
					radius = radius - 0.005 
				elseif is_select(3) then
					radius = 0.01
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_RadialBlur, "RadialBlurPostProcessVolume", "radius", radius)
				else
					break
				end
			end
		elseif is_select(4) then
			while true do
				message_direct_nowait("iterationCount = " .. iterationCount)
				open_select_window_direct(nil, "Normal", "+1", "-1", "リセット", "設定", "戻る")
				if is_select(1) then
					iterationCount = iterationCount + 1
				elseif is_select(2) then
					iterationCount = iterationCount - 1
				elseif is_select(3) then
					iterationCount = 3
				elseif is_select(4) then
					set_postprocess_int_paramter(FX_RadialBlur, "RadialBlurPostProcessVolume", "iterationCount", iterationCount)
				else
					break
				end
			end
		else
			break
		end
	end
end

function motionblur_test()
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "有効化", "無効化", "設定", "いろいろ動かす", "終了")
		if is_select(1) then
			on_active(FX_MotionBlur)
			message_direct("MotionBlur有効化")
		elseif is_select(2) then
			off_active(FX_MotionBlur)
			message_direct("MotionBlur無効化")
		elseif is_select(3) then
			set_motionblur_postprocess_parameter()
		elseif is_select(4) then
			move_object()
		else
			break
		end
	end
end

function set_motionblur_postprocess_parameter()
	while true do
		open_select_window_direct(nil, "Normal", "Quality変更", "Intensity変更", "Clamp変更", "戻る")
		if is_select(1) then
			while true do
				message_direct_nowait("motionblur_quality = " .. motionblur_quality)
				open_select_window_direct(nil, "Normal", "Low", "Medium", "High", "設定", "戻る")
				if is_select(1) then
					motionblur_quality = "Low"
				elseif is_select(2) then
					motionblur_quality = "Medium"
				elseif is_select(3) then
					motionblur_quality = "High"
				elseif is_select(4) then
					set_postprocess_enum_paramter(FX_MotionBlur, "UnityEngine.Rendering.Universal.MotionBlur", "UnityEngine.Rendering.Universal.MotionBlurQualityParameter", "quality", "UnityEngine.Rendering.Universal.MotionBlurQuality", motionblur_quality)
				else
					break
				end
			end
		elseif is_select(2) then
			while true do
				message_direct_nowait("motionblur_intensity = " .. motionblur_intensity)
				open_select_window_direct(nil, "Normal", "+0.1", "-0.1", "リセット", "設定", "戻る")
				if is_select(1) then
					motionblur_intensity = motionblur_intensity + 0.1
				elseif is_select(2) then
					motionblur_intensity = motionblur_intensity - 0.1 
				elseif is_select(3) then
					motionblur_intensity = 0.5
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_MotionBlur, "UnityEngine.Rendering.Universal.MotionBlur", "intensity", motionblur_intensity)
				else
					break
				end
			end
		elseif is_select(3) then
			while true do
				message_direct_nowait("motionblur_clamp = " .. motionblur_clamp)
				open_select_window_direct(nil, "Normal", "+0.005", "-0.005", "リセット", "設定", "戻る")
				if is_select(1) then
					motionblur_clamp = motionblur_clamp + 0.05
				elseif is_select(2) then
					motionblur_clamp = motionblur_clamp - 0.05 
				elseif is_select(3) then
					motionblur_clamp = 0.05
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_RadialBlur, "UnityEngine.Rendering.Universal.MotionBlur", "clamp", motionblur_clamp)
				else
					break
				end
			end
		else
			break
		end
	end
end

function move_object()
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "ノアール移動",　"カメラ移動", "カメラシェイク", "カメラシェイク停止", "戻る")
		if is_select(1) then
			local signal = slidemove(Noir, 0, 0, 1.15, 0.5)
			while signal.IsProccessing() do
				coroutine.yield()
			end
			local signal = slidemove(Noir, 0, 0, -1.15, 0.5)
			while signal.IsProccessing() do
				coroutine.yield()
			end
		elseif is_select(2) then
			local signal = slidemove(Camera01, -0.74, 1.531, 1.382, 0.5)
			while signal.IsProccessing() do
				coroutine.yield()
			end
			local signal = slidemove(Camera01, -2.74, 1.531, 1.382, 0.5)
			while signal.IsProccessing() do
				coroutine.yield()
			end
		elseif is_select(3) then
			shake_camera(Camera01, 3, -1)
		elseif is_select(4) then
			stop_shake_camera(Camera01)
		else
			break
		end
	end
end

function linearblur_test()
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "有効化", "無効化", "設定", "終了")
		if is_select(1) then
			on_active(FX_LinearBlur)
			message_direct("MotionBlur有効化")
		elseif is_select(2) then
			off_active(FX_LinearBlur)
			message_direct("MotionBlur無効化")
		elseif is_select(3) then
			set_linearblur_postprocess_parameter()
		else
			break
		end
	end
end


function set_linearblur_postprocess_parameter()
	while true do
		open_select_window_direct(nil, "Normal", "Intensity変更", "Direction変更", "Frequency変更",  "Density変更", "戻る")
		if is_select(1) then
			while true do
				message_direct_nowait("intensity = " .. intensity)
				open_select_window_direct(nil, "Normal", "+1", "-1", "リセット", "設定", "戻る")
				if is_select(1) then
					intensity = intensity + 1
				elseif is_select(2) then
					intensity = intensity - 1
				elseif is_select(3) then
					intensity = 1
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_LinearBlur, "LinearBlur", "intensity", intensity)
				else
					break
				end
			end
		elseif is_select(2) then
			while true do
				message_direct_nowait("direction = " .. direction)
				open_select_window_direct(nil, "Normal", "+10", "-10", "リセット", "設定", "戻る")
				if is_select(1) then
					direction = direction + 10
				elseif is_select(2) then
					direction = direction - 10 
				elseif is_select(3) then
					direction = 0
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_LinearBlur, "LinearBlur", "direction", direction)
				else
					break
				end
			end
		elseif is_select(3) then
			while true do
				message_direct_nowait("frequency = " .. frequency)
				open_select_window_direct(nil, "Normal", "+10", "-10", "リセット", "設定", "戻る")
				if is_select(1) then
					frequency = frequency + 10
				elseif is_select(2) then
					frequency = frequency - 10 
				elseif is_select(3) then
					frequency = 50
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_LinearBlur, "LinearBlur", "frequency", frequency)
				else
					break
				end
			end
		elseif is_select(4) then
			while true do
				message_direct_nowait("density = " .. density)
				open_select_window_direct(nil, "Normal", "+0.1", "-0.1", "リセット", "設定", "戻る")
				if is_select(1) then
					density = density + 0.1
				elseif is_select(2) then
					density = density - 0.1
				elseif is_select(3) then
					density = 1
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_LinearBlur, "LinearBlur", "density", density)
				else
					break
				end
			end
		else
			break
		end
	end
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
	load_postprocess_preload("content_adv_postprocess_radialblur", "Ef_C_PP_RadialBlur", false)
	load_postprocess_preload("content_adv_postprocess_motionblur", "Ef_C_PP_MotionBlur", false)
	load_postprocess_preload("content_adv_postprocess_linearblur", "Ef_C_PP_LinearBlur", false)
	setup_Noir_preload({0.0, 0, -1.15, 0})
	center_x = 0.5
	center_y = 0.5
	radius = 0.01
	iterationCount = 3
	motionblur_quality = "Low"
	motionblur_intensity = 0.5
	motionblur_clamp = 0.05
	intensity = 1
	direction = 0
	frequency = 50
	density = 1
end
