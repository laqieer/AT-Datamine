-- α5版　ギネヴィア立ちモーション確認 -------------------------------------------------------------------------------
-- ステージ：前庭
-- スクリプト作成者：古川

Include("content_luascript_system", "LuaCommonPack")


-- アセットなどを読み込む
function Load()
	load_ui()
	load_scene("content_areascene_110071", "Area110071") -- 前庭

	Guinevere	= set_chara("content_chr_1010003_101000301_model", "Chr_1010003_101000301_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",	3.416072,	0,	43.07916,	143.071, "Nbl_Std_loop_f", "Normal")

	character2D(Guinevere, "Guinevere", "content_unit_100010101", "100010301_UnitFace", nil)

	-- カメラ設定
	MAIN_CAMERA = set_camera(4.8118, 1.848, 40.98468, 23.164, -27.774, -0.9350001, 45)

end

-- シーケンスの実行
function Play()

	on_camera(MAIN_CAMERA)
	open_narration_window()

	TestMotion("Nbl_Std_loop_f")
	TestMotion("Nbl_Std_nod_m")
	TestMotion("Nbl_Std_angry_f")
	TestMotion("Nbl_Std_angry_loop_f")
	TestMotion("Nbl_Std_sad_f")
	TestMotion("Nbl_Std_sad_loop_f")
	TestMotion("Nbl_Std_surprise_f")
	TestMotion("Nbl_Std_surprise_loop_f")
	TestMotion("Nbl_Std_talk_loop_f")
	TestMotion("Nbl_Std_lookdown_f")
	TestMotion("Nbl_Std_puthand_f")
	TestMotion("Nbl_Std_puthand_loop_f")
	TestMotion("Nbl_Std_puthand_release_f")
	TestMotion("Nbl_Std_away_f")
	TestMotion("Nbl_Std_away_run_f")
	TestMotion("Nbl_Std_away_loop_f")
	TestMotion("Nbl_Std_away_idle_f")
	TestMotion("Nbl_Std_lean_loop_f")
	TestMotion("Nbl_Std_lean_talk_loop_f")
	TestMotion("Nbl_Std_lean_stand_f")
	TestMotion("Nbl_Std_wait_f")
	TestMotion("Nbl_Std_sad_stand_f")
	TestMotion("Nbl_Sit_loop_f")
	TestMotion("Nbl_Sit_angry_loop_f")
	TestMotion("Nbl_Wlk_loop_f")
	TestMotion("Nbl_Run_loop_f")
	TestMotion("Nbl_Wlk_Std_f")
	TestMotion("Nbl_Std_180turn_right_f")
	TestMotion("Nbl_Std_posing_f")
	TestMotion("Nbl_Std_accent_f")
	TestMotion("Nbl_Std_shy_f")
	TestMotion("Nbl_Std_shy_loop_f")
	TestMotion("Nbl_Std_joy_f")
	TestMotion("Nbl_Std_joy_loop_f")
	TestMotion("Nbl_Std_laugh_loop_f")
	TestMotion("Nbl_Std_worry_f")
	TestMotion("Nbl_Std_worry_loop_f")
	TestMotion("Std_posing_Chr_501_01")
	TestMotion("Std_accent_Chr_501_01")

	close_narration_window()

end


function TestMotion(motion_name)
	motion(Guinevere, motion_name, 0.3, 1.0, true)
	message(motion_name)
	wait_time(0.5)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110071", "Area110071")
	set_chara_preload("content_chr_1010003_101000301_model", "Chr_1010003_101000301_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",	3.416072,	0,	43.07916,	143.071, "Nbl_Std_loop_f", "Normal")
end
