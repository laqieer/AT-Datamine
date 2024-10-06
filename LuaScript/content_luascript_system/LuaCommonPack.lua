--[[
	Lua関数や処理の基本的なものをまとめたもの
]]

Include("content_luascript_system", "SystemFunctions")
Include("content_luascript_system", "ObjectFunctions")
Include("content_luascript_system", "EffectFunctions")
Include("content_luascript_system", "CharacterFunctions")
Include("content_luascript_system", "CameraFunctions")
Include("content_luascript_system", "UiFunctions")
Include("content_luascript_system", "FacilityFunctions", { "get_facility", "facility_buffitem_menu", "play_facility_result", "play_reading" })
Include("content_luascript_system", "StudyFunctions")
Include("content_luascript_system", "CommunicationFunctions", { "set_communication_acquired", "set_communication_intro", "set_communication", "set_communication_rankup", "normal_commu_item_menu", "get_npc_communication" })

-- 下のUIは表示優先度に影響し、下ほど手前
Include("content_luascript_system", "UiIrisOut", { "irisout_set_pos","irisout_set","irisout_set_to","irisout_set_to_wait"  }) -- 0
Include("content_luascript_system", "UiImage2D", { "load_image", "show_image", "hide_image" }) -- 100
Include("content_luascript_system", "UiPersonalUp", { "effect_personal_up" }) -- 200
Include("content_luascript_system", "UiFriendshipUp", { "set_friendship_up" })  -- 300
Include("content_luascript_system", "UiTextBox") -- 400
Include("content_luascript_system", "UiItemWindow", { "open_item_window", "open_item_window_general" }) -- 600
Include("content_luascript_system", "UiMenuWindow", { "open_menu_window" }) -- 600
Include("content_luascript_system", "UiCommunicationPlaceWindow", { "open_communication_place_window", "communication_place_select" }) -- 600
Include("content_luascript_system", "UiBookListPopup") -- 600
Include("content_luascript_system", "UiQuestWindow", { "open_areaeventquest_window_receipt", "open_areaeventquest_window_progress", "open_areaeventquest_window_complete", "open_subquest_window_complete" }) -- 700
Include("content_luascript_system", "UiSelectWindow", { "open_select_window_tag", "open_select_window_direct", "open_select_window" }) -- 800
Include("content_luascript_system", "UiTrustGauge", { "open_trust_gauge" }) -- 900
Include("content_luascript_system", "UiTrustUp", { "open_trust_up", "open_trust_rank_up" }) -- 1000
Include("content_luascript_system", "UiTrustRelease", { "open_trust_release" }) -- 1100
Include("content_luascript_system", "Ui1stAppearance", { "open_1st_appeaerance", "OpenFirstAppearance" }) -- 1200
Include("content_luascript_system", "UiParameterUp", { "open_parameter_up" }) -- 1200
Include("content_luascript_system", "UiBranchPoint") -- 1300
Include("content_luascript_system", "UiCutin", { "open_cutin", "open_cutin_r", "open_cutin_l" }) -- 1400
Include("content_luascript_system", "UiPopup", { "open_popup_direct", "open_popup" }) -- 1500
Include("content_luascript_system", "uiPopupConfirmeButton", { "open_popup_confirme_button" }) -- 1500

Include("content_luascript_system", "UiPopupButton", { "open_button_popup" }) -- 1600
Include("content_luascript_system", "UiPopupPage", { "open_page_popup" }) -- 1700
Include("content_luascript_system", "UiLog") -- 1800
Include("content_luascript_system", "UiHeaderFooter", { "open_footer_ui" }) -- 1900
Include("content_luascript_system", "UiSystemMenu") -- 2000
Include("content_luascript_system", "UiTutorial", {"open_tutorial_popup", "set_active_arrow", "active_tutorial_mask", "open_tutorial_dialog", "send_tutorial_progless"})
Include("content_luascript_system", "UiEffect")

-- Load()関数での共通処理
--  useFade = フェードを使って開始するか
function Load_common(useFade)
	-- フェードインの準備　※ゲームシーケンス内では不要だが、現状ではビューアーで必要
	if useFade != nil and useFade then
		fadeout(0.0, 0.0, 0.0, 1.0, 0.0)
		transitionin()
	end
	-- 基本SEのロード　※ゲームシーケンス内では不要だが、現状ではビューアーで必要
	system.LoadSoundFile("staq_E_S")
	system.LoadSoundFile("se")
	-- 使っているUIのロード　※常駐も想定して扱いを検討
	load_ui()

	-- バトルADVはホームボタンを非表示にする
	initialize_globalmenu_button()

	-- スクリプトに必要なポストエフェクトがあった場合のロード待ち
	wait_load_post_effect_list()
end

-- Play()関数での共通開始処理
--  useFade = フェードを使って開始するか
-- openFooter = フッターメニューを表示するか
function Play_start(useFade, openFooter)
    if openFooter == nil or openFooter then
	    open_footer_ui(true)
    end
	if useFade != nil and useFade then
		transitionout()
		wait_time(1.0)
	end
end

-- Play()関数での共通終了処理
--  useFade = フェードを使って開始するか
-- openedFooter = フッターメニューを表示していたか
function Play_end(useFade)
    if isOpenFooter then
        close_footer_ui()
	end
	if useFade != nil and useFade then
		transitionin()
		wait_time(1.0)
	end
	while FooterUI.IsProccessing() do
		coroutine.yield()
	end
	if 	ForwardDownEvent then
		-- 押下時倍速処理が有効の場合倍速をもとに戻しておく
		system.SetPlaySpeed(1.0)
		ForwardDownEvent = false
	end
end

-- 画面のフェードインをシーケンス内で待つ
--  duration = 秒数
function fadein_wait(duration)
	fadein(duration)
	wait_time(duration)
end

-- ホームボタンを表示/非表示にする
function initialize_globalmenu_button()
	local flag = true -- trueだと表示
              
	if system.IsFinishedIntroduction() == false then	-- 導入シーン中は非表示
		flag = false
	end
	if system.IsPsBattleAdv() == true then	-- 疑似バトルADVは非表示
		flag = false
	end
	if system.IsBattleAdv() == true then			-- バトルADVは非表示
		flag = false
	end

	ShowGlobalMenuButton(flag)
end

-- トラッキング通知用
function SetTrackingId(id)
	system.SetTrackingId(id)
end