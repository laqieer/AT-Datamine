----------------------------------------------------------------------------------------------------
-- β4版　施設利用：犬の世話の手伝い
-- ステージ：ログレス住居区
-- 登場キャラ：ノワール　犬
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_adv_advinst_110151_01","110151_01_h")

-- アセットなどを読み込む
function Load()
	demo_setup_nofade()

	Noir = area_setup_101009_Noir("Player", "Com_Std01_Loop_m")

end

-- シーケンスの実行
function Play()
	demo_start_nofade()

	local facility = get_facility()

	-- 導入会話
	open_mind_window("PLAYERNAME_NOIR", nil, nil)
		message("AC_01_0100002")
	close_mind_window()

	-- 曜日効果説明
	if facility.Bonus.IsDayOfWeek then
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0100004")
		close_mind_window()
	end

	-- 施設を利用する/しない
	open_select_window_tag(Noir, "Normal", "AC_01_0100006", "AC_01_0100007")

	if is_select(1) then	-- 手伝う
		scene_change_ready()
		Load_Main_Scene()
		scene_change_end()
	elseif is_select(2) then	-- 手伝わない
		system.CancelFacility()
		demo_end_nofade()
		return -- 終了
	else				-- どれも選ばれなかった（エラー）
		system.Cancel()
		demo_end_nofade()
		return -- 終了
	end

	if facility.Bonus.IsDayOfWeek then
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0100011")
		close_mind_window()
	else
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0100009")
		close_mind_window()
	end

	-- 人間パラメータ獲得演出
	play_facility_effect(facility.GetHumanParam(), Noir)

	-- リザルト演出
	play_facility_result(facility.GetHumanParam(),Noir)

	open_speech_window("CHRNAME_KAY", nil, nil)
		message("AC_01_0100024")
	close_speech_window()

	-- 章コイン獲得演出
	play_facility_workReward(facility)

	-- 終了
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0100013")
		close_mind_window()

	demo_end()
end

-- Main
function Load_Main_Scene()

--	load_area_scene(110151) -- ログレス住居区
	load_sequence_area_scene(110151) -- ログレス住居区　※時間帯対応

--	setup_101009_Noir({6.104, 3.75, -25.452,   41}, "Com_Std_DogCare_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
--	Dog1 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", {6.227, 3.75, -24.937,   126}, "Dog_Care_loop", "Normal")
--	Dog2 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", {6.522, 3.75, -25.375,   198}, "Dog_Sleep_loop", "Normal")
--	Dog3 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", {5.188, 3.75, -24.938,   94.99999}, "Dog_Tailwag_loop", "Normal")

	setup_101009_Noir(CharaPos110151_01_001, "Com_Std_DogCare_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
	Dog1 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_004, "Dog_Care_loop", "Normal")
	Dog2 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_005, "Dog_Sleep_loop", "Normal")
	Dog3 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_006, "Dog_Tailwag_loop", "Normal")

--	MAIN_CAMERA = set_camera(8.8237, 3.79165, -23.41712,   351.0505, 236.5748, 0,   26.99147)
	MAIN_CAMERA = create_camera()
	load_camera_anim(MAIN_CAMERA, CameraAssetBundleName110151_01, CameraPos110151_01_001)
		-- カメラ関連の明るさ、ビネット設定
		--シーン(背景明るさ,"背景カラー","キャラライト方向",キャラライト強度,ポスト背景グラーデーション強度)
		set_scene_light_effect_parameter(nil, "#000000", nil, 0.95, 0.05)
		set_scene_vignette_effect(0.5, 0.5, "#000000", 0.23, 0.3, true)
	on_camera(MAIN_CAMERA)

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	area_setup_101009_Noir_preload("Player", "Com_Std01_Loop_m")
end
