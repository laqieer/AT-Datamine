-- α5版　ノワール立ちモーション確認 ---------------------------------------------------------------------------------
-- ステージ：前庭
-- スクリプト作成者：古川

Include("content_luascript_system", "LuaCommonPack")


-- アセットなどを読み込む
function Load()
	load_ui()
	load_scene("content_areascene_110071", "Area110071") -- 前庭

	Noir	= set_chara("content_chr_1010001_101000102_model", "Chr_1010001_101000102_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",	3.416072,	0,	43.07916,	143.071, "Sri_Std_loop_m", "Normal")

	character2D(Noir, "Noir", "content_unit_200010101", "200010101_UnitFace", nil)

	-- カメラ設定
	MAIN_CAMERA = set_camera(4.8118, 1.848, 40.98468, 23.164, -27.774, -0.9350001, 45)

end

-- シーケンスの実行
function Play()

	on_camera(MAIN_CAMERA)
	open_narration_window()

	TestMotion("Mob_Std_loop_m")
	TestMotion("Mob_Sit_loop_m")
	TestMotion("Mob_Wlk_loop_m")
	TestMotion("Mob_Std_90turn_right_m")
	TestMotion("Mob_Std_90turn_left_m")
	TestMotion("Mob_Std_180turn_right_m")
	TestMotion("Mob_Std_180turn_left_m")
	TestMotion("Mob_Std_yes_m")
	TestMotion("Mob_Std_no_m")
	TestMotion("Mob_Std_think_loop_m")
	TestMotion("Mob_Std_greeting_m")
	TestMotion("Mob_Std_wavehands_loop_m")
	TestMotion("Mob_Std_depressed_loop_m")

--[[
	motion_inloop(Noir, "Mob_Std_yes_m", "Mob_Std_loop_m", 0.3, 1.0)
	wait_time(0.3)
	motion(Noir, "Sri_Std_loop_m", 0.3, 1.0, true)
	message("SELECT_YES")

	motion_inloop(Noir, "Mob_Std_yes_m", "Mob_Std_loop_m", 0.3, 1.0)
	wait_time(0.3)
	motion(Noir, "Sri_Std_loop_m", 0.3, 1.0, true)
	message("SELECT_YES")

	motion_inloop(Noir, "Mob_Std_yes_m", "Mob_Std_loop_m", 0.3, 1.0)
	wait_time(0.3)
	motion(Noir, "Sri_Std_loop_m", 0.3, 1.0, true)
	message("SELECT_YES")

	motion_inloop(Noir, "Mob_Std_yes_m", "Col_Std_loop_m", 0.5, 1.0)
	message("SELECT_YES")
	motion_inloop(Noir, "Mob_Std_yes_m", "Sri_Std_loop_m", 0.5, 1.0)
	message("SELECT_YES")
	motion_inloop(Noir, "Mob_Std_yes_m", "Col_Std_loop_m", 0.5, 1.0)
	message("SELECT_YES")
	motion_inloop(Noir, "Mob_Std_yes_m", "Sri_Std_loop_m", 0.5, 1.0)
	message("SELECT_YES")
	motion_inloop(Noir, "Mob_Std_yes_m", "Col_Std_loop_m", 0.5, 1.0)
	message("SELECT_YES")
]]
	close_narration_window()

end


function TestMotion(motion_name)
	motion(Noir, motion_name, 0.3, 1.0, true)
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
	set_chara_preload("content_chr_1010001_101000102_model", "Chr_1010001_101000102_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",	3.416072,	0,	43.07916,	143.071, "Sri_Std_loop_m", "Normal")
end
