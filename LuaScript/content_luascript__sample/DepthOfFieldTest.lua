Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 0, -1.15)

	FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)

	setup_Noir({0.0, 0, -1.15, 0});

	gaussian_start = 10
	gaussian_end = 30
	gaussian_max_radius = 1
	focus_distance = 10
	aperture = 5
	focal_length = 50
	blade_count = 3
	blade_curvature = 0
	blade_rotation = 0
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	off_screencolor()
	fadein(0)
	Play_start(true)

	-- テストの対象を決める
	open_narration_window()
	message_direct("DepthOfFieldエフェクトのテスト開始")
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "有効化", "無効化", "gaussian設定", "bokehで設定", "終了")
		if is_select(1) then
			on_active(FX_DoF)
			message_direct("DepthOfField有効化")
		elseif is_select(2) then
			off_active(FX_DoF)
			message_direct("DepthOfField無効化")
		elseif is_select(3) then
			set_gaussian();
		elseif is_select(4) then
			set_bokeh();
		else
			break
		end
	end
	message_direct("終了します")
	close_speech_window()

	Play_end(true)
end

function set_gaussian()
	set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
	while true do
		open_select_window_direct(nil, "Normal", "Start変更", "End変更", "MaxRadius変更", "戻る")
		if is_select(1) then
			while true do
				message_direct_nowait("gaussian_start = " .. gaussian_start)
				open_select_window_direct(nil, "Normal", "Start +1", "Start -1", "Start リセット", "設定", "戻る")
				if is_select(1) then
					gaussian_start = gaussian_start + 1
				elseif is_select(2) then
					gaussian_start = gaussian_start - 1
				elseif is_select(3) then
					gaussian_start = 10
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start)
				else
					break
				end
			end
		elseif is_select(2) then
			while true do
				message_direct_nowait("gaussian_end = " .. gaussian_end)
				open_select_window_direct(nil, "Normal", "End +1", "End -1", "End リセット", "設定", "戻る")
				if is_select(1) then
					gaussian_end = gaussian_end + 1
				elseif is_select(2) then
					gaussian_end = gaussian_end - 1
				elseif is_select(3) then
					gaussian_end = 30
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end)
				else
					break
				end
			end
		elseif is_select(3) then
			while true do
				message_direct_nowait("gaussian_max_radius = " .. gaussian_max_radius)
				open_select_window_direct(nil, "Normal", "MaxRadius +0.1", "MaxRadius -0.1", "MaxRadius リセット", "設定", "戻る")
				if is_select(1) then
					gaussian_max_radius = gaussian_max_radius + 0.1
				elseif is_select(2) then
					gaussian_max_radius = gaussian_max_radius - 0.1
				elseif is_select(3) then
					gaussian_max_radius = 1
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius)
				else
					break
				end
			end
		else
			break
		end
	end
end

function set_bokeh()
	set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Bokeh")
	while true do
		open_select_window_direct(nil, "Normal", "FocusDistance変更", "FocalLength変更", "Aperture変更", "Blade変更", "戻る")
		if is_select(1) then
			while true do
				message_direct_nowait("focus_distance = " .. focus_distance)
				open_select_window_direct(nil, "Normal", "+1", "-1", "リセット", "設定", "戻る")
				if is_select(1) then
					focus_distance = focus_distance + 1
				elseif is_select(2) then
					focus_distance = focus_distance - 1
				elseif is_select(3) then
					focus_distance = 10
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "focusDistance", focus_distance)
				else
					break
				end
			end
		elseif is_select(2) then
			while true do
				message_direct_nowait("focal_length = " .. focal_length)
				open_select_window_direct(nil, "Normal", "+10", "-10", "リセット", "設定", "戻る")
				if is_select(1) then
					focal_length = focal_length + 10
				elseif is_select(2) then
					focal_length = focal_length - 10
				elseif is_select(3) then
					focal_length = 50
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "focalLength", focal_length)
				else
					break
				end
			end
		elseif is_select(3) then
			while true do
				message_direct_nowait("aperture = " .. aperture)
				open_select_window_direct(nil, "Normal", "+1", "-1", "リセット", "設定", "戻る")
				if is_select(1) then
					aperture = aperture + 1
				elseif is_select(2) then
					aperture = aperture - 1
				elseif is_select(3) then
					aperture = 5
				elseif is_select(4) then
					set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "aperture", aperture)
				else
					break
				end
			end
		elseif is_select(4) then
			while true do
				open_select_window_direct(nil, "Normal", "BladeCount変更", "BladeCurvature変更", "BladeRotation変更", "戻る")
				if is_select(1) then
					while true do
						message_direct_nowait("blade_count = " .. blade_count)
						open_select_window_direct(nil, "Normal", "+1", "-1", "リセット", "設定", "戻る")
						if is_select(1) then
							blade_count = blade_count + 1
						elseif is_select(2) then
							blade_count = blade_count - 1
						elseif is_select(3) then
							blade_count = 3
						elseif is_select(4) then
							set_postprocess_int_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "bladeCount", blade_count)
						else
							break
						end
					end
				elseif is_select(2) then
					while true do
						message_direct_nowait("blade_curvature = " .. blade_curvature)
						open_select_window_direct(nil, "Normal", "+0.1", "-0.1", "リセット", "設定", "戻る")
						if is_select(1) then
							blade_curvature = blade_curvature + 0.1
						elseif is_select(2) then
							blade_curvature = blade_curvature - 0.1
						elseif is_select(3) then
							blade_curvature = 0
						elseif is_select(4) then
							set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "bladeCurvature", blade_curvature)
						else
							break
						end
					end
				elseif is_select(3) then
					while true do
						message_direct_nowait("blade_rotation = " .. blade_rotation)
						open_select_window_direct(nil, "Normal", "+10", "-10", "リセット", "設定", "戻る")
						if is_select(1) then
							blade_rotation = blade_rotation + 1
						elseif is_select(2) then
							blade_rotation = blade_rotation - 1
						elseif is_select(3) then
							blade_rotation = 0
						elseif is_select(4) then
							set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "bladeRotation", blade_rotation)
						else
							break
						end
					end
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
	load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	setup_Noir_preload({0.0, 0, -1.15, 0})
	gaussian_start = 10
	gaussian_end = 30
	gaussian_max_radius = 1
	focus_distance = 10
	aperture = 5
	focal_length = 50
	blade_count = 3
	blade_curvature = 0
	blade_rotation = 0
end
