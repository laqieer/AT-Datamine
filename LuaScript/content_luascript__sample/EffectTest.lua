Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
	
	setup_Lancelot({0.000, 0.0, -5.440, 0.0})
	
	setup_Noir({1.050, 0.0, -1.610, 180.0})
	motion(Noir, "Sri_Sit_loop_m", 0.0, 1.0, true)
	
	setup_Guinevere({-1.430, 0.0,  0.050, 180.0})
	motion(Guinevere, "Nbl_Sit_loop_f", 0.0, 1.0, true)
	
	MobGirl01	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl02	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl03	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	
	
	FX_CLine = load_particle("effects_adv", "Ef_C_Adv_ELine_Holizonal01_Lop", false, true)
	set_parent(FX_CLine, Camera01, 0.0, 0.0, -3.0, 0.0, 0.0, 0.0)
	FX_ColorGrading = load_postprocess("effects_postprocess", "Ef_C_PP_ColorGrading", false)
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
		open_select_window_direct(Noir, "Normal", "パーティクル", "ポストプロセス", "終了")
		if is_select(1) then
			message_direct("パーティクルのテスト")
			open_select_window_direct(Noir, "Normal", "On/Off切り替え", "再生", "停止", "速度変更")
			if is_select(1) then
				if is_active(FX_CLine) then
					off_active(FX_CLine)
				else
					on_active(FX_CLine)
				end
			elseif is_select(2) then
				play_particle(FX_CLine)
			elseif is_select(3) then
				stop_particle(FX_CLine)
			else
				open_select_window_direct(Noir, "Normal", "x0.0", "x0.25", "x1.0", "x3.0")
				if is_select(1) then
					set_particle_speed(FX_CLine, 0.0)
				elseif is_select(2) then
					set_particle_speed(FX_CLine, 0.25)
				elseif is_select(3) then
					set_particle_speed(FX_CLine, 1.0)
				else
					set_particle_speed(FX_CLine, 3.0)
				end
			end
		elseif is_select(2) then
			message_direct("ポストプロセスのテスト")
			open_select_window_direct(Noir, "Normal", "On/Off切り替え", "結合荷重設定", "結合荷重アニメーション")
			if is_select(1) then
				if is_active(FX_ColorGrading) then
					off_active(FX_ColorGrading)
				else
					on_active(FX_ColorGrading)
				end
			elseif is_select(2) then
				message_direct("結合荷重値の設定")
				open_select_window_direct(Noir, "Normal", "0.0", "0.33", "0.66", "1.0")
				if is_select(1) then
					set_postprocess_weight(FX_ColorGrading, 0.0)
				elseif is_select(2) then
					set_postprocess_weight(FX_ColorGrading, 0.33)
				elseif is_select(3) then
					set_postprocess_weight(FX_ColorGrading, 0.66)
				else
					set_postprocess_weight(FX_ColorGrading, 1.0)
				end
			else
				message_direct("結合荷重値を１秒で変化")
				open_select_window_direct(Noir, "Normal", "0.0 -> 0.5", "0.0 -> 1.0", "0.5 -> 0.0", "1.0 -> 0.0")
				if is_select(1) then
					change_postprocess_weight(FX_ColorGrading, 0.0, 0.5, 1.0)
				elseif is_select(2) then
					change_postprocess_weight(FX_ColorGrading, 0.0, 1.0, 1.0)
				elseif is_select(3) then
					change_postprocess_weight(FX_ColorGrading, 0.5, 0.0, 1.0)
				else
					change_postprocess_weight(FX_ColorGrading, 1.0, 0.0, 1.0)
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









-- 初期化
function test_postprocess_init()
    -- ポスプロのWeightを初期設定
	set_postprocess_weight(FX_ColorGrading, 0.0)
	play_effect(FX_ColorGrading)
end

-- パーティクルテスト
function test_particle_playing()
	play_effect_at_camera(FX_CLine, MAIN_CAMERA)
	
	wait_time(3.0)
	-- 速度を下げる
	set_effect_speed(FX_CLine, 0.1)
	wait_time(3.0)
	
	-- 一時停止
	pose_effect(FX_CLine)
	wait_time(3.0)
	
	-- 速度を戻す
	set_effect_speed(FX_CLine, 1.0)
	resume_effect(FX_CLine)
	wait_time(3.0)
end

-- ポスプロテスト
function test_postprocess_playing()
    -- カラーグラディエントを5秒間0→1に変化。待たない
	set_postprocess_weight_linear(FX_ColorGrading, 0.0, 1.0, 5.0, false)
	-- wait_time(3.0)
end



--[[ シーケンスの実行
function Play()
    on_camera(MAIN_CAMERA)
    
    test_postprocess_init()
    
	Play_start(true)
	
    test_postprocess_playing()
    test_particle_playing()
    
    
    stop_effect(FX_CLine)
    stop_effect(FX_ColorGrading)
	-- シーンが終わったから消えたのか命令で消えたのかの確認のための待ち
	wait_time(3.0)
end
]]


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
	setup_Noir_preload({1.050, 0.0, -1.610, 180.0})
	setup_Guinevere_preload({-1.430, 0.0,  0.050, 180.0})
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	load_particle_preload("effects_adv", "Ef_C_Adv_ELine_Holizonal01_Lop", false, true)
	load_postprocess_preload("effects_postprocess", "Ef_C_PP_ColorGrading", false)
end
