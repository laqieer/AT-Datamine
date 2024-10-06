-- 倍速再生演出UIを読み込む
SkipUI = system.LinkUI("2D_Root/SafeArea/effect_story_skip", 1800)
UiLoadList[#UiLoadList + 1] = SkipUI

-- ログUIを読み込む
LogUI = system.LinkFrontUI("Front2D_Root/SafeArea/Adv_TextBox_log_List", 1801)
UiLoadList[#UiLoadList + 1] = LogUI
LogUI.ResetAdvLogList();

-- フッターUIを読み込む
FooterUI = system.LinkFrontUI("Front2D_Root/SafeArea/Container_Adv_Footer", 1802)
UiLoadList[#UiLoadList + 1] = FooterUI

-- フッターを開いているか
isOpenFooter = false

-- スクリプト終了フラグ
ScriptEndFlag = false;

-- 倍速時のスケール速度
fastSpeed = 16

-- lua生存期間で初めて開いた状態管理フラグ
_internal_global_footer_firstOpen = true

-- フッターを開く
function open_footer_ui(firstOpen)
	FooterUI.SetActive("Hide_Root", true)
	FooterUI.SetActive("Log_Root", true)
	FooterUI.SetActive("Auto_Root", true)
	FooterUI.SetActive("AllFast_Root", true)
	FooterUI.SetActive("Fast_Root", true)
	FooterUI.SetActive("Skip_Root", false)
	FooterUI.SetActive("Forward_Root", true)
	FooterUI.SetActive("GlobalMenu", (LuaBattleAdv == nil and LuaPsBattleAdv == nil))

	FooterUI.SetButtonFunction("Hide", onClickButtonHide, true)
	FooterUI.SetButtonFunction("Log", onClickButtonLog, true)
	FooterUI.SetButtonFunction("LogClose", onClickButtonLogClose, true)
	FooterUI.SetButtonFunction("Auto", onClickButtonAuto, true)
	FooterUI.SetButtonFunction("AutoStop", onClickButtonAuto, true)
	FooterUI.SetButtonFunction("AllFast", onClickButtonAllFast, true)
	FooterUI.SetButtonFunction("AllFastStop", onClickButtonAllFastStop, true)
	FooterUI.SetButtonFunction("Fast", onClickButtonFast, true)
	FooterUI.SetButtonFunction("FastStop", onClickButtonFastStop, true)
	FooterUI.SetButtonFunction("Skip", onClickButtonSkip, true)
	FooterUI.SetEventFunction("Forward", "PointerDown", onDownButtonForward, true)
	FooterUI.SetEventFunction("Forward", "PointerUp", onUpButtonForward, false)
	FooterUI.SetButtonFunction("GlobalMenu", onClickButtonGlobalMenu, true)
	FooterUIFullScreenButton(false)

	FooterUI.SetButtonsInteractable(true)

	-- ログインADVモード スキップとオートのみ 存在
	local loginAdvMode = system.IsPreHomeAdvSituation()
	if loginAdvMode then
		FooterUI.SetActive("Hide_Root", false)
		FooterUI.SetActive("Log_Root", false)
		FooterUI.SetActive("Auto_Root", true)
		FooterUI.SetActive("AllFast_Root", false)
		FooterUI.SetActive("Fast_Root", false)
		FooterUI.SetActive("Forward_Root", false)
		FooterUI.SetActive("Skip_Root", true)
		FooterUI.SetActive("GlobalMenu_Root", false)
	end
	
	FooterUI.Play("In", true)
	-- 主に倍速再生の準備のため、C#側にフッターが開いた事を伝える
	SkipUI.SetActive(true)
	if firstOpen == nil then
		firstOpen = false
	end
	FooterUI.SetOpenFooter(SkipUI, firstOpen, _internal_global_footer_firstOpen)
	_internal_global_footer_firstOpen = false;
	isOpenFooter = true

	-- 初期値
	footerUiActive("Auto", false)
	footerUiActive("AllFast", false)
	footerUiActive("Fast", false)

	-- SetOpenFooter時にセーブされている値が反映されるため、そのあとにヘッダ機能設定を適用する
	_apply_footer_auto_btn_by_auto_status()
	if system.IsBattleAdv() == true then 
		_fast_setting_by_battle_setting()
	else
		_apply_fast_by_header_setting()
	end
	init_adv_log()
end

function _apply_footer_auto_btn_by_auto_status()
	local playMode = system.GetPlayMode()
	if playMode == 1 then
		footerUiActive("Auto", true)
	else
		footerUiActive("Auto", false)
	end
end

function _fast_setting_by_battle_setting()
	-- スキップできるバトルADV
	if system.IsSkippableBattleAdv() then 
		if system.IsFastBattleAdv() then
		-- battle設定でfastなので倍速
			SetPlaySpeed(fastSpeed)
			footerUiActive("Fast", true)
	        FooterUIFullScreenButton(true, onClickButtonFullScreenFast)
		else
		-- battle設定でfastされていないのでADV設定に準ずる
			_apply_fast_by_header_setting()
		end
	else
	-- スキップしてはいけないADVなので等速
		system.SetSettingAlreadyReadFast(false)
		footerUiActive("Fast", false)
	end
end

function _apply_fast_by_header_setting()
	-- 設定状況にもとづいて効果、ボタンの適用
	system.SetPlaySpeed(1)
	if system.GetSettingAlreadyReadFast() then -- 既読飛ばし設定か
		if system.IsAlreadyReadNow() then -- 既読
			SetPlaySpeed(fastSpeed)
			footerUiActive("Fast", true)
	        FooterUIFullScreenButton(true, onClickButtonFullScreenFast)
		else -- 未読
			system.SetSettingAlreadyReadFast(false) -- 「未読状況ではボタンonにできない」と扱う
			footerUiActive("Fast", false)
		end
	end
	if system.GetSettingAllFast() then -- 全飛ばし
		SetPlaySpeed(fastSpeed)
		footerUiActive("AllFast", true)
        FooterUIFullScreenButton(true, onClickButtonFullScreenAllFast)
	end
end

-- フッターを閉じる
function close_footer_ui()
	-- 処理中に押せないようする
	FooterUI.SetButtonsInteractable(false)

	FooterUI.Play("Out", false)
	isOpenFooter = false
end

-- フッターのログボタンを押したときに呼ばれる関数
function onClickButtonLog()
	debug_print("onClickButtonLog")
	if system.IsAdvLogMode() == True then
		return
	end
	
	FooterUI.SetActive("Log_Logo", false)
	FooterUI.SetActive("Close_Logo", true)
	
	system.StopVoiceAll()

	-- All倍速は Fastは off
	system.SetSettingAllFast(false)
	system.SetSettingAlreadyReadFast(false)
	footerSetNormalSpeedNotForward()

	local op
	op = create_coroutine(open_adv_log)
	coroutine.resume(op)
end

-- ログを閉じるボタンを押したときに呼ばれる関数
-- backkeyでc#から呼ばれることがあります
function onClickButtonLogClose()
	debug_print("onClickButtonLogClose")
	if system.IsAdvLogMode() == false then
		return
	end
	
	FooterUI.SetActive("Log_Logo", true)
	FooterUI.SetActive("Close_Logo", false)
	
	system.StopVoiceAll()
	
	local op
	op = create_coroutine(close_adv_log)
	coroutine.resume(op)
end

-- 通常再生にする
function footerSetNormalSpeed()
	SetPlaySpeed(1.0)
	footerUiActive("AllFast", false)
	footerUiActive("Fast", false)
	FooterUIFullScreenButton(false)
end

-- 早送りボタンが押されていなければ通常再生
function footerSetNormalSpeedNotForward()
	if not ForwardDownEvent then
		footerSetNormalSpeed()
	end
end

-- 早送り系のボタン切替
function footerUiActive(buttonName, active)
	local startLabel = buttonName.."_Start"
	local stopLabel = buttonName.."_Stop"
	FooterUI.SetActive(startLabel, not(active))
	FooterUI.SetActive(stopLabel, active)

    if active == false then
        FooterUI.ResetSelectedObject(startLabel)
    else
        FooterUI.ResetSelectedObject(stopLabel)
    end
end

-- フッターのオートボタンを押したときに呼ばれる関数
function onClickButtonAuto()
	debug_print("onClickButtonAuto")
	local flag = false
	if system.GetPlayMode() <= 0 then
		-- Autoはon
		system.SetPlayMode(1)
		flag = true
	else
		-- autoはoff
		system.SetPlayMode(0)
	end
	
	-- All倍速は Fast倍速はoff
	system.SetSettingAllFast(false)
	system.SetSettingAlreadyReadFast(false)
	footerSetNormalSpeedNotForward()
	
	footerUiActive("Auto", flag)
end

-- フッターのスキップボタンを押したときに呼ばれる関数
function onClickButtonSkip()
	if system.IsAdvLogMode() == true then
		close_adv_log()
		FooterUI.SetActive("Log_Logo", true)
		FooterUI.SetActive("Close_Logo", false)
	end
	
	if ScriptEndFlag == false then
		ScriptEndFlag = true
		
		-- autoを止める挙動仕様
		-- ボタン状態は _checkFooterButtonによって更新される処理想定
		system.SetPlayMode(0)
		
		-- スキップ確認ポップアップの表示
		local pop = create_coroutine(runSkipPopup)
		coroutine.resume(pop) 
		close_footer_ui()
	end
end

-- スキップポップアップ
function runSkipPopup()
	
	local win = system.CreateSkipPopup()
	local open = win.Open()
	while open.IsProccessing() do
		coroutine.yield()
	end
	
	-- スキップ確認ポップアップでの選択結果の反映
	if win.IsSkepped() then
		system.OpenSkip()
	else
		ScriptEndFlag = false
		open_footer_ui(false)
	end
	
end

-- 既読早送り
function onClickButtonFast()
	debug_print("onClickButtonFast")
	-- Fast はon All倍速はoff
	system.SetSettingAllFast(false)
	footerUiActive("AllFast", false)

	if system.IsAlreadyReadNow() then
		SetPlaySpeed(fastSpeed)
		footerUiActive("Fast", true)
		system.SetSettingAlreadyReadFast(true)
		FooterUIFullScreenButton(true, onClickButtonFullScreenFast)
	else
		footerSetNormalSpeedNotForward()
	end
end

-- 既読早送り停止
function onClickButtonFastStop()
	debug_print("onClickButtonFastStop")
	-- Fast はoff All倍速はoff
	system.SetSettingAlreadyReadFast(false)
	system.SetSettingAllFast(false)
	footerSetNormalSpeedNotForward()
	FooterUIFullScreenButton(false)
end


-- 早送り
function onClickButtonAllFast()
	debug_print("onClickButtonAllFast")

	-- All倍速は on
	system.SetSettingAllFast(true)
	SetPlaySpeed(fastSpeed)
	footerUiActive("AllFast", true)

	-- 既読早送りと共存しない
	footerUiActive("Fast", false)
	system.SetSettingAlreadyReadFast(false)

	FooterUIFullScreenButton(true, onClickButtonFullScreenAllFast)
end

-- 早送り停止
function onClickButtonAllFastStop()
	debug_print("onClickButtonAllFastStop")
	-- All倍速は off
	system.SetSettingAllFast(false)
	if system.GetSettingAlreadyReadFast() then
		if not system.IsAlreadyReadNow() then
			footerSetNormalSpeedNotForward()
		end
	else
		footerSetNormalSpeedNotForward()
	end
	FooterUIFullScreenButton(false)
end

-- ADV終了時に手動倍速で速度変わっていた場合はもとに戻すためのフラグ
ForwardDownEvent = false

function onDownButtonForward()
	debug_print("onDownButtonForward")

	if ForwardDownEvent then
		do return end
	end
	
	-- Autoは off
	system.SetPlayMode(0)

	-- 手動早送りはon  All倍速はoff Fastはoff
	ForwardDownEvent = true
	SetPlaySpeed(fastSpeed)
	system.SetSettingAllFast(false)
	system.SetSettingAlreadyReadFast(false)
	
	footerUiActive("Auto", false)
	footerUiActive("AllFast", false)
	footerUiActive("Fast", false)
end

-- 外部から呼ばれる コールバックが取れない状況があるため
function onUpButtonForward()
	debug_print("onUpButtonForward")
	if not ForwardDownEvent then
		do return end
	end
	
	-- Autoは off
	system.SetPlayMode(0)
	
	-- 手動早送りはoff All倍速はoff Fastはoff
	ForwardDownEvent = false
	system.SetSettingAllFast(false)
	system.SetSettingAlreadyReadFast(false)
	footerSetNormalSpeed()
	
	footerUiActive("Auto", false)
end

function onClickButtonGlobalMenu()
	if system.IsAdvLogMode() == true then
		close_adv_log()
		FooterUI.SetActive("Log_Logo", true)
		FooterUI.SetActive("Close_Logo", false)
	end

	if TextBox ~= nill then
		if_opened_hide_ui_textbox()
	end

	--OpenHome()処理中にボタンを押せないように実行
	close_footer_ui()
	system.OpenHome()
end

function onClickButtonHide()
	FooterUIFullScreenButton(true, onClickButtonHideOff)

	FooterUI.Play("Out", true)
	hide_ui_textbox()
	system.DateOut()
	-- 全機能を解除して 非表示を行う
	system.SetPlayMode(0)
	SetPlaySpeed(1.0)
	system.SetSettingAlreadyReadFast(false)
	system.SetSettingAllFast(false)
	footerUiActive("Auto", false)
	
	footerUiActive("AllFast", false)
	footerUiActive("Fast", false)
end

function onClickButtonHideOff()
	FooterUI.Play("In", true)
	system.DateIn()
	show_ui_textbox()

	FooterUIFullScreenButton(false)
end


function onClickButtonFullScreenAllFast()
	system.SetSettingAllFast(false)
	footerUiActive("AllFast", false)
	if not(system.GetSettingAlreadyReadFast()) then
		SetPlaySpeed(1.0)
	end
	FooterUIFullScreenButton(false)
end

function onClickButtonFullScreenFast()
	system.SetSettingAlreadyReadFast(false)
	footerUiActive("Fast", false)
	SetPlaySpeed(1.0)
	FooterUIFullScreenButton(false)
end

-- 全画面ボタン
function FooterUIFullScreenButton(flag, callback)
	local buttonLabel = "FullScreenButton"
	FooterUI.SetActive(buttonLabel, flag)
	if callback ~= nil then 
	    FooterUI.SetButtonFunction(buttonLabel, callback, true)
	end
end


function SetPlaySpeed(speed)
	system.SetPlaySpeed(speed)
	if simple_movie_set_playback_speed != nil then
		simple_movie_set_playback_speed(speed)
	end
end


-- グローバルメニューボタンのみ非表示　現代編で隠すため
function ShowGlobalMenuButton(flag)
	FooterUI.SetActive("GlobalMenu_Root", flag)
	FooterUI.SetActive("GlobalMenu_Logo", flag)
	FooterUI.SetButtonInteractable("GlobalMenu", flag)
end

-- Advログ開閉時の機能ボタンの反応off/on 外部から呼ぶ用
function SetFooterButtonInteractableInAdvLog(flag)
	FooterUI.SetButtonInteractable("Auto", flag)
	FooterUI.SetButtonInteractable("Skip", flag)
	FooterUI.SetButtonInteractable("Fast", flag)
	FooterUI.SetButtonInteractable("AllFast", flag)
	FooterUI.SetButtonInteractable("Forward", flag)
	FooterUI.SetButtonInteractable("Hide", flag)
	FooterUI.SetButtonInteractable("AutoStop", flag)
	FooterUI.SetButtonInteractable("FastStop", flag)
	FooterUI.SetButtonInteractable("AllFastStop", flag)
	FooterUI.SetButtonInteractable("Forward", flag)
	FooterUI.SetButtonInteractable("HideOff", flag)
end

-- resume時の処理
function uiHeaderFooterOnEnable()
	onUpButtonForward()
end
