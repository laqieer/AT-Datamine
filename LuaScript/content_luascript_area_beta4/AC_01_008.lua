----------------------------------------------------------------------------------------------------
-- β4版　施設利用：商店の手伝い
-- ステージ：マーケット
-- 登場キャラ：ノワール・店主
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_adv_advinst_112021_01","112021_01_h")

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
		message("AC_01_0080002")
	close_mind_window()

	-- 曜日効果説明
	if facility.Bonus.IsDayOfWeek then
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0080004")
		close_mind_window()
	end

	-- 施設を利用する/しない
	open_select_window_tag(Noir, "Normal", "AC_01_0080006", "AC_01_0080007")

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
			message("AC_01_0080011")
		close_mind_window()
	else
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0080009")
		close_mind_window()
	end

	-- 人間パラメータ獲得演出
	play_facility_effect(facility.GetHumanParam(), Noir)

	-- リザルト演出
	play_facility_result(facility.GetHumanParam(),Noir)

	open_speech_window("CHRNAME_MARIL", nil, nil)
		message("AC_01_0080025")
	close_speech_window()

	-- 章コイン獲得演出
	play_facility_workReward(facility)

	-- 終了
		open_mind_window("PLAYERNAME_NOIR", nil, nil)
			message("AC_01_0080013")
		close_mind_window()

	demo_end()
end

-- Main
function Load_Main_Scene()

--	load_area_scene(112021) -- マーケット
	load_sequence_area_scene(112021) -- マーケット　※時間帯対応

--	setup_101009_Noir({-1.281, 0, -3.333,   0}, "Mob_ShopClerk_Loop_m", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
	setup_101009_Noir(CharaPos112021_01_001, "Mob_ShopClerk_Loop_m", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

--	MAIN_CAMERA = set_camera(0.04506, 2.07461, -0.46559,   14.94472, 206.5256, 0,   26.99147)
	MAIN_CAMERA = create_camera()
	load_camera_anim(MAIN_CAMERA, CameraAssetBundleName112021_01, CameraPos112021_01_001)
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
