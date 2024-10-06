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

	Emo_Angry01_Lop		= set_object("effects_emotion", "Ef_C_Emo_Angry01_Lop", false)
	Emo_Excl01		= set_object("effects_emotion", "Ef_C_Emo_Excl01", false)
	Emo_FelUp01		= set_object("effects_emotion", "Ef_C_Emo_FelUp01", false)
	Emo_FelUp02		= set_object("effects_emotion", "Ef_C_Emo_FelUp02", false)
	Emo_FelUp03		= set_object("effects_emotion", "Ef_C_Emo_FelUp03", false)
	Emo_Heart01		= set_object("effects_emotion", "Ef_C_Emo_Heart01", false)
	Emo_Moya01_Lop		= set_object("effects_emotion", "Ef_C_Emo_Moya01_Lop", false)
	Emo_Que01		= set_object("effects_emotion", "Ef_C_Emo_Que01", false)
	Emo_Sleep01_Lop		= set_object("effects_emotion", "Ef_C_Emo_Sleep01_Lop", false)
	Emo_StUP01		= set_object("effects_emotion", "Ef_C_Emo_StUP01", false)
	Emo_StUP02		= set_object("effects_emotion", "Ef_C_Emo_StUP02", false)
	Emo_StUP03		= set_object("effects_emotion", "Ef_C_Emo_StUP03", false)
	Emo_Sweat01		= set_object("effects_emotion", "Ef_C_Emo_Sweat01", false)
	Emo_Upset01__Lop	= set_object("effects_emotion", "Ef_C_Emo_Upset01__Lop", false)
	Emo_Waiwai01_Lop	= set_object("effects_emotion", "Ef_C_Emo_Waiwai01_Lop", false)

	-- カメラ設定
	MAIN_CAMERA = set_camera(4.8118, 1.848, 40.98468, 23.164, -27.774, -0.9350001, 45)

end

-- シーケンスの実行
function Play()

	on_camera(MAIN_CAMERA)
	open_narration_window()

--[[
	motion(Guinevere, "Nbl_Std_loop_f", 0.3, 1.0, true)
	message("WAIT_TAP")

	motion_inloop(Guinevere, "Mob_Std_yes_f", "Mob_Std_loop_f", 0.3, 1.0)
	message("WAIT_TAP")

	motion(Guinevere, "Nbl_Std_talk_loop_f", 0.3, 1.0, true)
	message("WAIT_TAP")

	motion_inloop(Guinevere, "Mob_Std_yes_f", "Nbl_Std_loop_f", 0.3, 1.0)
	message("WAIT_TAP")

	motion_inloop(Guinevere, "Mob_Std_yes_f", "Nbl_Std_loop_f", 1.0, 1.0)
	message("WAIT_TAP")

	motion_inloop(Guinevere, "Mob_Std_yes_f", "Mob_Std_loop_f", 0.3, 1.0)
	wait_time(1.0)
	motion(Guinevere, "Nbl_Std_loop_f", 0.3, 1.0, true)
	message("WAIT_TAP")

	motion(Guinevere, "Mob_Std_yes_f", 0.3, 1.0, true)
	wait_time(1.0)
	motion(Guinevere, "Nbl_Std_loop_f", 0.3, 1.0, true)
	message("WAIT_TAP")
	motion(Guinevere, "Nbl_Std_talk_loop_f", 0.3, 1.0, true)
	message("WAIT_TAP")
]]

	TestEmote("Emo_Angry01_Lop",	Emo_Angry01_Lop	)	--怒り
	TestEmote("Emo_Excl01",		Emo_Excl01	)	--びっくり
	TestEmote("Emo_FelUp01",	Emo_FelUp01	)	--ステアップ音符１
	TestEmote("Emo_FelUp02",	Emo_FelUp02	)	--ステアップ音符２
	TestEmote("Emo_FelUp03",	Emo_FelUp03	)	--ステアップ音符３
	TestEmote("Emo_Heart01",	Emo_Heart01	)	--ハート
	TestEmote("Emo_Moya01_Lop",	Emo_Moya01_Lop	)	--もやもや
	TestEmote("Emo_Que01",		Emo_Que01	)	--？
	TestEmote("Emo_Sleep01_Lop",	Emo_Sleep01_Lop	)	--ZZZ
	TestEmote("Emo_StUP01",		Emo_StUP01	)	--ステアップ音符１
	TestEmote("Emo_StUP02",		Emo_StUP02	)	--ステアップ音符２
	TestEmote("Emo_StUP03",		Emo_StUP03	)	--ステアップ音符３
	TestEmote("Emo_Sweat01",	Emo_Sweat01	)	--汗
	TestEmote("Emo_Upset01__Lop",	Emo_Upset01__Lop)	--あせあせ
	TestEmote("Emo_Waiwai01_Lop",	Emo_Waiwai01_Lop)	--わいわい

	TestMotion("Mob_Std_loop_f")
	TestMotion("Mob_Sit_loop_f")
	TestMotion("Mob_Wlk_loop_f")
	TestMotion("Mob_Std_90turn_right_f")
	TestMotion("Mob_Std_90turn_left_f")
	TestMotion("Mob_Std_180turn_right_f")
	TestMotion("Mob_Std_180turn_left_f")
	TestMotion("Mob_Std_yes_f")
	TestMotion("Mob_Std_no_f")
	TestMotion("Mob_Std_think_f")
	TestMotion("Mob_Std_wavehands_loop_f")
	TestMotion("Mob_Std_greeting_f")
	TestMotion("Mob_Std_depressed_loop_f")

	close_narration_window()

end


function TestMotion(motion_name)
	motion(Guinevere, motion_name, 0.3, 1.0, true)
	message(motion_name)
	wait_time(0.5)
end

function TestEmote(emote_name, emote_id)
	effect_at_character(Guinevere, "Head", emote_id, 0.0, 0.0, 0.0)
	message(emote_name)
	off_active(emote_id)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110071", "Area110071")
	set_chara_preload("content_chr_1010003_101000301_model", "Chr_1010003_101000301_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",	3.416072,	0,	43.07916,	143.071, "Nbl_Std_loop_f", "Normal")
	set_object_preload("effects_emotion", "Ef_C_Emo_Angry01_Lop", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Excl01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp02", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_FelUp03", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Heart01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Moya01_Lop", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Que01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Sleep01_Lop", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_StUP01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_StUP02", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_StUP03", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Sweat01", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Upset01__Lop", false)
	set_object_preload("effects_emotion", "Ef_C_Emo_Waiwai01_Lop", false)
end
