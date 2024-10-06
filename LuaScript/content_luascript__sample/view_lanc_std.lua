-- α5版　ランスロット立ちモーション確認 ------------------------------------------------------------------------------
-- ステージ：教室
-- スクリプト作成者：古川

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	load_ui()
	load_scene("content_areascene_110011", "Area110011") -- 教室

	setup_Lancelot({0.000, 0.0, -5.440, 0.0})

	MAIN_CAMERA = set_camera(0, 1.531, (3.25-7), 3.549,-180,0, 60)

end

-- シーケンスの実行
function Play()

	on_camera(MAIN_CAMERA)
	open_narration_window()

	TestMotion("Col_Std_loop_m")
	TestMotion("Col_Std_joy_m")
	TestMotion("Col_Std_joy_loop_m")
	TestMotion("Col_Std_angry_m")
	TestMotion("Col_Std_angry_loop_m")
	TestMotion("Col_Std_sad_m")
	TestMotion("Col_Std_sad_loop_m")
	TestMotion("Col_Std_surprise_m")
	TestMotion("Col_Std_surprise_loop_m")
	TestMotion("Col_Std_talk01_loop_m")
	TestMotion("Col_Std_talk02_loop_m")
	TestMotion("Col_Std_handout_m")
	TestMotion("Col_Std_clap_m")
	TestMotion("Col_Std_nod_m")
	TestMotion("Col_Std_yes_m")
	TestMotion("Col_Std_no_m")
	TestMotion("Col_Wlk_loop_m")
	TestMotion("Col_Std_shy_m")
	TestMotion("Col_Std_shy_loop_m")
	TestMotion("Col_Std_laugh_loop_m")
	TestMotion("Col_Std_worry_m")
	TestMotion("Col_Std_worry_loop_m")
	TestMotion("Std_posing_Chr_001_01")
	TestMotion("Std_accent_Chr_001_01")

	close_narration_window()

end


function TestMotion(motion_name)
	motion(Lancelot, motion_name, 0.3, 1.0, true)
	message(motion_name)
	wait_time(0.5)

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
end
