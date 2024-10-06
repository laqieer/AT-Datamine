Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	FX_Diffusion = load_postprocess("content_adv_postprocess_diffusion", "Ef_C_PP_Diffusion", false)
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	off_screencolor()
	fadein(0)
	Play_start(true)

	-- テストの対象を決める
	open_narration_window()
	message_direct("ディヒュージョンエフェクトのテスト開始")
	while true do
		message_direct("選択してください")
		open_select_window_direct(nil, "Normal", "ディヒュージョンON", "ディヒュージョンOFF", "ディヒュージョンフェードイン", "ディヒュージョンフェードアウト", "終了")
		if is_select(1) then
			on_active(FX_Diffusion)
			set_postprocess_weight(FX_Diffusion, 1.0)
			message_direct("ディヒュージョンON")
		elseif is_select(2) then
			off_active(FX_Diffusion)
			message_direct("ディヒュージョンOFF")
		elseif is_select(3) then
			on_active(FX_Diffusion)
			set_postprocess_weight(FX_Diffusion, 0.0)
			message_direct("タップでディヒュージョンフェードイン開始")
			change_postprocess_weight(FX_Diffusion, 0.0, 1.0, 2.0)
			wait_time(2)
			message_direct("ディヒュージョンフェードイン終了")
		elseif is_select(4) then
			on_active(FX_Diffusion)
			set_postprocess_weight(FX_Diffusion, 1.0)
			message_direct("タップでディヒュージョンフェードアウト開始")
			change_postprocess_weight(FX_Diffusion, 1.0, 0.0, 2.0)
			wait_time(2)
			message_direct("ディヒュージョンフェードアウト終了")
			off_active(FX_Diffusion)
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
	load_area_scene_preload(110011)
	load_postprocess_preload("content_adv_postprocess_diffusion", "Ef_C_PP_Diffusion", false)
end
