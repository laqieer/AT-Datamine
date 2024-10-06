----------------------------------------------------------------------------------------------------
-- 施設利用：勉強
-- ステージ：談話室（夜）
-- 登場キャラ：ノワール
-- スクリプト作成者：中嶋(悠)　古川
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_adv_advinst_110901_02","110901_02_h")

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
    AC_01_001_Inst_start()

--[[
	-- 天候効果説明
	if facility.Bonus.IsWeather then
		AC_01_001_Inst_bonus()
	end
]]

	-- 施設を利用する/しない
	open_select_window_tag(Noir, "Normal", "AC_01_0010006", "AC_01_0010007")

	if is_select(1) then	-- 勉強する
	        scene_change_ready()
	        Load_Main()
	        scene_change_end()
	elseif is_select(2) then	-- やめる
		--AC_01_001_Inst_cancel()
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
		AC_01_001_Main_item()
		close_footer_ui()
		selectedItem = facility_buffitem_menu(buffItems)
		open_footer_ui()
	end

	if selectedItem != nil then
		-- 効率化アイテム効果演出
		AC_01_001_Main_useitem(selectedItem.TextValue)
		AC_01_001_Main_noitem()
	else
		-- 通常（アイテム無し）演出
		AC_01_001_Main_noitem()
	end

--[[
	-- 天候効果演出
	if facility.Bonus.IsWeather then
		AC_01_001_Main_bonus()
	end
]]

	-- 人間パラメータ獲得演出
	play_facility_effect(facility.GetHumanParam(), Noir)

	-- リザルト演出
	play_facility_result(facility.GetHumanParam(),Noir)

	-- 終了
	AC_01_001_Main_end()

	demo_end()

	set_pos(Tea_set, {Tea_set_pos[1], Tea_set_pos[2], Tea_set_pos[3]})	-- 暫定対応としてカメラ外に移動させていた物を戻す
end

----------------------------------------------------------------------------------------------------

function Load_Main()

	load_sequence_area_scene(110901) -- 談話室　※時間帯対応

	setup_101009_Noir(CharaPos110901_02_001, "Com_Sit_studying_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

	Pen = set_object("content_prop_10106006", "10106006_PropModel", true)
	on_parent(Pen, Noir, "Loc_weapon_constrint_R", 0,0,0, 0,0,0)

	-- ノートを配置
	Note1 = set_object("content_prop_10106001", "10106001_PropModel", true)
	Note2 = set_object("content_prop_10106001", "10106001_PropModel", true)

	set_pos(Note1, CharaPos110901_02_002)
	set_rot(Note1, {0,CharaPos110901_02_002[4],0})

	set_pos(Note2, CharaPos110901_02_003)
	set_rot(Note2, {0,CharaPos110901_02_003[4],0})

	-- 本を配置
	Book1 = set_object("content_prop_10103001", "10103001_PropModel", true)
	Book2 = set_object("content_prop_10103002", "10103002_PropModel", true)
	Book3 = set_object("content_prop_10103003", "10103003_PropModel", true)
	Book4 = set_object("content_prop_10103004", "10103004_PropModel", true)

	set_pos(Book1, CharaPos110901_02_004)
	set_rot(Book1, {0,CharaPos110901_02_004[4],0})

	set_pos(Book2, CharaPos110901_02_005)
	set_rot(Book2, {0,CharaPos110901_02_005[4],0})

	set_pos(Book3, CharaPos110901_02_006)
	set_rot(Book3, {0,CharaPos110901_02_006[4],0})

	set_pos(Book4, CharaPos110901_02_007)
	set_rot(Book4, {0,CharaPos110901_02_007[4],0})

	-- ティーセットを非表示
	Tea_set_pos = {}
	Tea_set = get_object("geo_tea_set_02")
	--off_active(Tea_set)
	Tea_set_pos = get_pos(Tea_set)
	set_pos(Tea_set, {Tea_set_pos[1], Tea_set_pos[2]-5, Tea_set_pos[3]})	-- 暫定対応としてカメラ外に移動させて非表示に

	MAIN_CAMERA = create_camera()
	load_camera_anim(MAIN_CAMERA, CameraAssetBundleName110901_02, CameraPos110901_02_001)

		-- カメラ関連の明るさ、ビネット設定
		--シーン(背景明るさ,"背景カラー","キャラライト方向",キャラライト強度,ポスト背景グラーデーション強度)
		set_scene_light_effect_parameter(nil, "#000000", nil, 0.95, 0.05)
		set_scene_vignette_effect(0.5, 0.5, "#000000", 0.21, 0.3, true)

	on_camera(MAIN_CAMERA)

end

----------------------------------------------------------------------------------------------------

function AC_01_001_First_start()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0010017")
		message("AC_01_0010018")
	close_speech_window()

	local pageList = {
	    { "FacilityTutorialTestSubTitle1", "AC_01_0010015"},
	}
	open_page_popup("FacilityTutorialTestTitle", pageList)

end

function AC_01_001_Inst_start()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0010002")
		message("AC_01_0010004")
	close_speech_window()

end

function AC_01_001_Inst_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※天候ボーナス予告")
	close_speech_window()

end

function AC_01_001_Inst_cancel()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※キャンセル")
	close_speech_window()

end

function AC_01_001_Main_item()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0010009")
	close_speech_window()

end

function AC_01_001_Main_useitem(itemName)

	open_narration_window()
		message_replace("AC_ALL_0001", itemName)
	close_narration_window()

end

function AC_01_001_Main_noitem()

	change_face(Noir, "Normal")
	open_narration_window()
		message("AC_01_0010011")
	close_narration_window()

end

function AC_01_001_Main_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※天候ボーナス時の結果")
	close_speech_window()

end

function AC_01_001_Main_end()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0010013")
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
