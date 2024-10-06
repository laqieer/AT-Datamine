----------------------------------------------------------------------------------------------------
-- β4版　施設利用：酒場の手伝い
-- ステージ：酒場
-- 登場キャラ：ノワール・店主
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_adv_advinst_112041_01","112041_01_h")

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
		message("AC_01_0060002")
	close_mind_window()

	-- 曜日効果説明
	if facility.Bonus.IsDayOfWeek then
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0060004")
		close_mind_window()
	end

	-- 施設を利用する/しない
	open_select_window_tag(Noir, "Normal", "AC_01_0060006", "AC_01_0060007")

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
			message("AC_01_0060011")
		close_mind_window()
	else
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0060009")
		close_mind_window()
	end

	-- 人間パラメータ獲得演出
	play_facility_effect(facility.GetHumanParam(), Noir)

	-- リザルト演出
	play_facility_result(facility.GetHumanParam(),Noir)

	open_speech_window("NPCNAME_0085", nil, nil)
		message("AC_01_0060032")
	close_speech_window()

	-- 章コイン獲得演出
	play_facility_workReward(facility)

	-- 終了
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0060013")
		close_mind_window()

	demo_end()
end

-- Main
function Load_Main_Scene()

--	load_area_scene(112041) -- 酒場
	load_sequence_area_scene(112041) -- 酒場　※時間帯対応

--	setup_101009_Noir({3.104, 0, 0.27,   257}, "Com_Std_wiping_Loop_m", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
	setup_101009_Noir(CharaPos112041_01_001, "Com_Std_wiping_Loop_m", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

	Cloth = set_object("content_prop_10108002", "10108002_PropModel", true)
	on_parent(Cloth, Noir, "Loc_weapon_constrint_R", 0,0,0, 0,0,0)

--	MAIN_CAMERA = set_camera(1.05693, 1.48257, -1.07008,   0.3571, 51.0218, 0,   26.99147)
	MAIN_CAMERA = create_camera()
	load_camera_anim(MAIN_CAMERA, CameraAssetBundleName112041_01, CameraPos112041_01_001)
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
