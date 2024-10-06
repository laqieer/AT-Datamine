----------------------------------------------------------------------------------------------------
-- β3版　施設利用・メイン：裏バイト
-- 登場キャラ：ノワール
-- スクリプト作成者：中嶋(悠)
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup_nofade()

	Noir = get_chara("Player")
	character2D(Noir, "Noir", "content_unit_101000102", "101000102_UnitFace", "101000102_UnitCutin", "101000102_UnitThumb", "101000102_UnitImage_Full", "101000102_UnitImage_HiRes")
	motion(Noir, "Sri_Std_loop_m", 0.3, 1.0, true)
	
	debug_print("★character2D")

end

-- シーケンスの実行
function Play()
	demo_start_nofade()

	debug_print("★play start")

	local facility = get_facility()

	debug_print("★facilityParam")
	
	if facility.IsTutorial == true then
    	open_narration_window()
    	    message_direct("施設「".. facility.Name .. "」のチュートリアル開始")
    	close_narration_window()
    	
    	local pageList = {
    	    { "FacilityTutorialTestSubTitle1", "FacilityTutorialTestPage1"},
    	    { "FacilityTutorialTestSubTitle2", "FacilityTutorialTestPage2"},
    	}
    	open_page_popup("FacilityTutorialTestTitle", pageList)
	end
	
	-- 導入会話
	AC_01_000001_Inst_start()

	-- 天候効果説明
	if facility.Bonus.IsWeather then
		AC_01_000001_Inst_bonus()
	end

	-- 施設を利用する/しない
	open_select_window_direct(Noir, "Normal", "勉強していく", "今はやめておく")

	if is_select(1) then	-- 勉強していく

        scene_change_ready()
        Load_Main()
        scene_change_end()

	elseif is_select(2) then	-- やめる

		AC_01_000001_Inst_cancel()
		system.Cancel()
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
		AC_01_000001_Main_item()

		selectedItem = facility_buffitem_menu(buffItems)
    end
    
    if selectedItem != nil then
		-- 効率化アイテム効果演出
		AC_01_000001_Main_useitem(selectedItem.TextValue)
	else
		-- 通常（アイテム無し）演出
		AC_01_000001_Main_noitem()
	end

	-- 天候効果演出
	if facility.Bonus.IsWeather then
		AC_01_000001_Main_bonus()
	end

	-- リザルト演出
	play_facility_result(facility.GetHumanParam())

	-- 終了
	AC_01_000001_Main_end()

    demo_end()
end


function Load_Main()
    
    Noir.SetActive(false)
    
	debug_print("★load start")
    
	load_scene("content_areascene_110901", "Area110901") -- 談話室

	debug_print("★load_scene")

	Noir		= set_chara("content_unit_200010101_model", "Model200010101", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -3.715695, 0.06, -4.960591, 90, "Sit_study_loop_Chr_002_01", "Normal")
	character2D(Noir, "Noir", "content_unit_101000102", "101000102_UnitFace", "101000102_UnitCutin", "101000102_UnitThumb", "101000102_UnitImage_Full", "101000102_UnitImage_HiRes")
    
--[[
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
]]

	-- カメラ設定
	MAIN_CAMERA = set_camera(-1.827, 1.506, -2.397, 9.969, -152.709, 0, 21)

	on_camera(MAIN_CAMERA)
	debug_print("★set_camera")
	
end

function AC_01_000001_Inst_start()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("自習用の机が空いてるな。<br>授業の復習でもしておくか…？")
	close_speech_window()

	open_narration_window()
		message_direct("ここで勉強することで<br>ノワールの知識がアップします。")
	close_narration_window()

end

function AC_01_000001_Inst_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)

		message_direct("今日は雨のせいか、人影もまばらだ。<br>これなら集中して勉強できるぞ。")
	close_speech_window()

	open_narration_window()
		message_direct("雨天の場合は<br>知識のアップ量が増加します。")
	close_narration_window()

end

function AC_01_000001_Inst_cancel()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("今はいいか。")
	close_speech_window()

end


function AC_01_000001_Main_item()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("そうだ。勉強が捗るものを持ってたな。<br>あれを使って勉強してみるか…？")
	close_speech_window()

	open_narration_window()
		message_direct("効率化アイテムを使うことで<br>勉強時の知識アップ量が増加します。")
	close_narration_window()

end

function AC_01_000001_Main_useitem(itemName)

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("…。")
		message_direct("…！")
	close_speech_window()

	open_narration_window()
		message_direct("「"..itemName.."」のおかげで<br>難しい問題もスラスラ解けた！")
		message_direct("少し賢くなった気がする。")
	close_narration_window()

end

function AC_01_000001_Main_noitem()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("…。")
	close_speech_window()

	open_narration_window()
		message_direct("ちょっとだけ賢くなった気がする。")
	close_narration_window()

end

function AC_01_000001_Main_bonus()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("天気のせいか周りが静かで、<br>いつもより集中することができた。")
	close_speech_window()

end

function AC_01_000001_Main_end()

	change_face(Noir, "Normal")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("もうこんな時間か、<br>そろそろ終わりにしよう。")
	close_speech_window()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	get_chara_preload("Player")
end
