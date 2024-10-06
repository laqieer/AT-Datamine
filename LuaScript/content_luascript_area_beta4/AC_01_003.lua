----------------------------------------------------------------------------------------------------
-- β4版　施設利用：裁縫
-- ステージ：教室A(ノワール)
-- 登場キャラ：ノワール
-- スクリプト作成者：中嶋(悠)　古川
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_adv_advinst_110011_01","110011_01_h")

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
	AC_01_003_Inst_start()

--[[
	-- 天候効果説明
	if facility.Bonus.IsWeather then
		AC_01_003_Inst_bonus()
	end
]]

	-- 施設を利用する/しない
	open_select_window_tag(Noir, "Normal", "AC_01_0030006", "AC_01_0030007")

	if is_select(1) then	-- 勉強する
	        scene_change_ready()
	        Load_Main()
	        scene_change_end()
	elseif is_select(2) then	-- やめる
		--AC_01_003_Inst_cancel()
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
		AC_01_003_Main_item()
		close_footer_ui()
		selectedItem = facility_buffitem_menu(buffItems)
		open_footer_ui()
	end

	if selectedItem != nil then
		-- 効率化アイテム効果演出
		AC_01_003_Main_useitem(selectedItem.TextValue)
		AC_01_003_Main_noitem()
	else
		-- 通常（アイテム無し）演出
		AC_01_003_Main_noitem()
	end

--[[
	-- 天候効果演出
	if facility.Bonus.IsWeather then
		AC_01_003_Main_bonus()
	end
]]

	-- 人間パラメータ獲得演出
	play_facility_effect(facility.GetHumanParam(), Noir)

	-- リザルト演出
	play_facility_result(facility.GetHumanParam(),Noir)

	-- 終了
	AC_01_003_Main_end()

	demo_end()
end

----------------------------------------------------------------------------------------------------

function Load_Main()

--	load_area_scene(110011) -- 教室A(ノワール)
	load_sequence_area_scene(110011) -- 教室A(ノワール)　※時間帯対応

--	setup_101009_Noir({2.463, 0, 0.17,   180}, "Com_Sit_Sewing_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
	setup_101009_Noir(CharaPos110011_01_001, "Com_Sit_Sewing_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

	Sewing = set_object("content_prop_10108001", "10108001_PropModel", true)
	set_object_name(Sewing,"10108001_PropModel")
	on_parent(Sewing, Noir, "Loc_weapon_constrint_R", 0,0,0, 0,0,0)

--	MAIN_CAMERA = set_camera(3.55736, 1.04036, -1.16598,   357.0098, 316.2567, 0,   26.99147)
	MAIN_CAMERA = create_camera()
	load_camera_anim(MAIN_CAMERA, CameraAssetBundleName110011_01, CameraPos110011_01_001)

		-- カメラ関連の明るさ、ビネット設定
		--シーン(背景明るさ,"背景カラー","キャラライト方向",キャラライト強度,ポスト背景グラーデーション強度)
		set_scene_light_effect_parameter(nil, "#000000", nil, nil, 0.05)
		set_scene_vignette_effect(0.5, 0.5, "#000000", 0.2, 0.3, true)
	on_camera(MAIN_CAMERA)


end

----------------------------------------------------------------------------------------------------

function AC_01_003_First_start()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0030017")
		message("AC_01_0030018")
	close_speech_window()

	local pageList = {
	    { "FacilityTutorialTestSubTitle1", "AC_01_0030015"},
	}
	open_page_popup("FacilityTutorialTestTitle", pageList)

end

function AC_01_003_Inst_start()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0030002")
		message("AC_01_0030004")
	close_speech_window()

end

function AC_01_003_Inst_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※天候ボーナス予告")
	close_speech_window()

end

function AC_01_003_Inst_cancel()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※キャンセル")
	close_speech_window()

end


function AC_01_003_Main_item()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0030009")
	close_speech_window()

end

function AC_01_003_Main_useitem(itemName)

	open_narration_window()
		message_replace("AC_ALL_0001", itemName)
	close_narration_window()

end

function AC_01_003_Main_noitem()

	change_face(Noir, "Normal")
	open_narration_window()
		message("AC_01_0030011")
	close_narration_window()

end

function AC_01_003_Main_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("※仮テキスト<br>※天候ボーナス時の結果")
	close_speech_window()

end

function AC_01_003_Main_end()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message("AC_01_0030013")
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