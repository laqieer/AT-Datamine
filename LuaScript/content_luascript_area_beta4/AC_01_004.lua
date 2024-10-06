----------------------------------------------------------------------------------------------------
-- β4版　施設利用：絵を描く
-- ステージ：遺跡前
-- 登場キャラ：ノワール
-- スクリプト作成者：中嶋(悠)　古川
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_adv_advinst_112011_01","112011_01_h")

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
	AC_01_004_Inst_start()

--[[
	-- 天候効果説明
	if facility.Bonus.IsWeather then
		AC_01_004_Inst_bonus()
	end
]]

	-- 施設を利用する/しない
	open_select_window_tag(Noir, "Normal", "AC_01_0040006", "AC_01_0040007")

	if is_select(1) then	-- 勉強する
	        scene_change_ready()
	        Load_Main()
	        scene_change_end()
	elseif is_select(2) then	-- やめる
		--AC_01_004_Inst_cancel()
		system.CancelFacility()
		demo_end_nofade()
		return -- 終了
	else
		-- どれも選ばれなかった（エラー）
		system.Cancel()
		demo_end_nofade()
		return -- 終了
	end

	-- 効率化アイテム判定
	local buffItems = facility.GetBuffItems()
	local selectedItem = nil

	if #buffItems > 0 then
		AC_01_004_Main_item()
		close_footer_ui()
		selectedItem = facility_buffitem_menu(buffItems)
		open_footer_ui()
	end

	if selectedItem != nil then
		-- 効率化アイテム効果演出
		AC_01_004_Main_useitem(selectedItem.TextValue)
		AC_01_004_Main_noitem()
	else
		-- 通常（アイテム無し）演出
		AC_01_004_Main_noitem()
	end

--[[
	-- 天候効果演出
	if facility.Bonus.IsWeather then
		AC_01_004_Main_bonus()
	end
]]

	-- 人間パラメータ獲得演出
	play_facility_effect(facility.GetHumanParam(), Noir)

	-- リザルト演出
	play_facility_result(facility.GetHumanParam(),Noir)

	-- 終了
	AC_01_004_Main_end()

	demo_end()
end

----------------------------------------------------------------------------------------------------

function Load_Main()

--	load_area_scene(112011) -- 遺跡前
	load_sequence_area_scene(112011) -- 遺跡前　※時間帯対応

	setup_101009_Noir({5.451, 0.05, 2.934,   225}, "Com_Sit_Picture_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
--	setup_101009_Noir(CharaPos112011_01_001, "Com_Sit_Picture_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

	Brush = set_object("content_prop_10109002", "10109002_PropModel", true)
	on_parent(Brush, Noir, "Loc_weapon_constrint_R", 0,0,0, 0,0,0)

	Canvas = set_object("content_prop_10109001", "10109001_PropModel", true)
	set_pos(Canvas, {4.951,0.000,2.539})
	set_rot(Canvas, {0,61.000,0})

--	MAIN_CAMERA = set_camera(6.47265, 1.85959, 1.18232,   21.63404, 324.1603, 0,   26.99147)
	MAIN_CAMERA = create_camera()
	load_camera_anim(MAIN_CAMERA, CameraAssetBundleName112011_01, CameraPos112011_01_001)
			-- カメラ関連の明るさ、ビネット設定
			--シーン(背景明るさ,"背景カラー","キャラライト方向",キャラライト強度,ポスト背景グラーデーション強度)
			set_scene_light_effect_parameter(nil, "#000000", nil, nil, 0.05)
			set_scene_vignette_effect(0.5, 0.5, "#000000", 0.2, 0.3, true)

	on_camera(MAIN_CAMERA)

end

----------------------------------------------------------------------------------------------------

function AC_01_004_First_start()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0040017")
		message("AC_01_0040018")
	close_speech_window()

	local pageList = {
	    { "FacilityTutorialTestSubTitle1", "AC_01_0040015"},
	}
	open_page_popup("FacilityTutorialTestTitle", pageList)

end

function AC_01_004_Inst_start()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0040002")
		message("AC_01_0040004")
	close_speech_window()

end

function AC_01_004_Inst_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※天候ボーナス予告")
	close_speech_window()

end

function AC_01_004_Inst_cancel()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※キャンセル")
	close_speech_window()

end

function AC_01_004_Main_item()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0040009")
	close_speech_window()

end

function AC_01_004_Main_useitem(itemName)

	open_narration_window()
		message_replace("AC_ALL_0001", itemName)
	close_narration_window()

end

function AC_01_004_Main_noitem()

	change_face(Noir, "Normal")
	open_narration_window()
		message("AC_01_0040011")
	close_narration_window()

end

function AC_01_004_Main_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※天候ボーナス時の結果")
	close_speech_window()

end

function AC_01_004_Main_end()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0040013")
	close_speech_window()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	area_setup_101009_Noir_preload("Player", "Com_Std01_Loop_m")
end
