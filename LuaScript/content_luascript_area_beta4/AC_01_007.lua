----------------------------------------------------------------------------------------------------
-- β4版　施設利用：鍛冶屋の手伝い
-- ステージ：大工房
-- 登場キャラ：ノワール・店主
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_adv_advinst_112031_01","112031_01_h")

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
		message("AC_01_0070002")
	close_mind_window()

	-- 曜日効果説明
	if facility.Bonus.IsDayOfWeek then
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0070004")
		close_mind_window()
	end

	-- 施設を利用する/しない
	open_select_window_tag(Noir, "Normal", "AC_01_0070006", "AC_01_0070007")

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
			message("AC_01_0070011")
		close_mind_window()
	else
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0070009")
		close_mind_window()
	end

	-- 人間パラメータ獲得演出
	play_facility_effect(facility.GetHumanParam(), Noir)

	-- リザルト演出
	play_facility_result(facility.GetHumanParam(),Noir)

	open_speech_window("NPCNAME_0083", nil, nil)
		message("AC_01_0070028")
	close_speech_window()

	-- 章コイン獲得演出
	play_facility_workReward(facility)


	-- 終了
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0070013")
		close_mind_window()

	demo_end()
end

-- Main
function Load_Main_Scene()

--	load_area_scene(112031) -- 大工房
	load_sequence_area_scene(112031) -- 大工房　※時間帯対応

--	setup_101009_Noir({0.39, 0, -10.179,   197}, "Com_Std_Blacksmith_Loop_m", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
	setup_101009_Noir(CharaPos112031_01_001, "Com_Std_Blacksmith_Loop_m", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

	Hammer = set_object("content_prop_10105001", "10105001_PropModel", true)
	Sword = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
	on_parent(Hammer, Noir, "Loc_weapon_constrint_R", 0,0,0, 0,0,0)
	on_parent(Sword, Noir, "Loc_weapon_constrint_L", 0,0,0, 0,0,0)

	Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackSmith_Spark", true, true)
	on_parent(Ef_0001, Noir, "Loc_weapon_constrint_L", 0,0,0.46, 0,0,0)
	Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackSmith_Sword", true, true)
	on_parent(Ef_0002, Noir, "Loc_weapon_constrint_L", 0,0,0, 0,0,0)
	Ef_0003 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackSmith_Glow", true, true)
	on_parent(Ef_0003, Noir, "J_Root", -0.48,0.79,1.25, 0,0,0)

--	MAIN_CAMERA = set_camera(2.69039, 1.44389, -11.78741,   2.68901, 297.3037, 0,   26.99147)
	MAIN_CAMERA = create_camera()
	load_camera_anim(MAIN_CAMERA, CameraAssetBundleName112031_01, CameraPos112031_01_001)
			-- カメラ関連の明るさ、ビネット設定
			--シーン(背景明るさ,"背景カラー","キャラライト方向",キャラライト強度,ポスト背景グラーデーション強度)
			set_scene_light_effect_parameter(nil, "#000000", nil, nil, 0.05)
			set_scene_vignette_effect(0.5, 0.5, "#000000", 0.2, 0.3, true)

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
