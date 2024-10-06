Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")


AD_EVENT_HOME_TUTORIAL_1 = 66
AD_EVENT_HOME_TUTORIAL_2 = 67
AD_EVENT_HOME_TUTORIAL_3 = 68
AD_EVENT_HOME_TUTORIAL_4 = 69
AD_EVENT_HOME_TUTORIAL_5 = 70
AD_EVENT_HOME_TUTORIAL_6 = 71
AD_EVENT_HOME_TUTORIAL_7 = 72
AD_EVENT_HOME_TUTORIAL_8 = 73
AD_EVENT_HOME_TUTORIAL_9 = 74

function Load()
	nofooter_setup()
	load_ui()

	Aruhan = set_chara_unknown()
	character2DFull(Aruhan, "Aruhan", 101059001)
	close_textbox_base()
end

function Play()
    nofooter_start()
	while system.ProcessingChangeScene() do
		coroutine.yield()
	end
    if TUTORIAL_SEQUENCE_PROGRESS >= 1100 and TUTORIAL_SEQUENCE_PROGRESS < 1200 then
		-- ディナタン持ってる場合は先に進む
		if system.HasStyle(101012001) then
			system.SetTutorialNextSequence()
		else
			PlayHome()
		end
	end
    if TUTORIAL_SEQUENCE_PROGRESS >= 1200 and TUTORIAL_SEQUENCE_PROGRESS < 1300 then
		-- ディナタン持ってる場合は先に進む
		if system.HasStyle(101012001) then
			system.SetTutorialNextSequence()
			SetTrackingId(AD_EVENT_HOME_TUTORIAL_2)
		else
			PlayGacha()
		end
	end
	if TUTORIAL_SEQUENCE_PROGRESS >= 1300 and TUTORIAL_SEQUENCE_PROGRESS < 1400 then
		PlayExpedition()
	end
	if TUTORIAL_SEQUENCE_PROGRESS >= 1400 and TUTORIAL_SEQUENCE_PROGRESS < 1500 then
		PlayOutGameMenu()
	end
	if TUTORIAL_SEQUENCE_PROGRESS >= 1500 and TUTORIAL_SEQUENCE_PROGRESS < 1600 then
		PlayHomeEnd()
	end
    nofooter_end()
end

function PlayHome()


	SetTrackingId(AD_EVENT_HOME_TUTORIAL_1)

	WaitAnimation("ContainerHomeScene")

	-- アルハンのセリフ
	open_textbox_base()
 	open_mind_window("NPCNAME_0313", Aruhan, nil)
		message("TU_01_01002")	--戻ったか
		change_face(Aruhan, "Sad")
		message("TU_01_01004")	--なんだ不思議そうな顔して～
		change_face(Aruhan, "Normal")
		message("TU_01_01005")	--ここは『六千年の武器庫』
		message("TU_01_01007")	--バルバロイという津波にさらされ～
		change_face(Aruhan, "Smile")
		message("TU_01_01008")	--今は理解できなくてもいい
		change_face(Aruhan, "Normal")
		message("TU_01_01010")	--それより視たか？
		message("TU_01_01011")	--欠損した歴史はいくつもの意訳が可能だ
		message("TU_01_01012")	--過去の継承者の意識と同調し～
		message("TU_01_01014")	--そうして過去を継承せよ～
		change_face(Aruhan, "Smile")
		message("TU_01_01016")	--では期待しているぞ最後の継承者
	close_mind_window()

	close_textbox_base()
	TextBox.SetActive(false)


	-- マスク出す
	active_tutorial_mask()
	set_mask_color("#0000007F")

	-- テキスト表示
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_01_02001")	--ホーム画面では様々なことができます
	close_tutorial_popup()
	system.SetTutorialNextSequence()
end

function PlayGacha()

	set_active_arrow(false)
	close_textbox_base()
	TextBox.SetActive(false)

	-- マスクの表示
	active_tutorial_mask()
	set_mask_color("#0000007F")

	-- テキストの表示
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_01_02003")	--次は『伝承召喚』で仲間を呼びましょう。～
	close_tutorial_popup()

	-- 矢印の表示
	set_active_arrow(true)
	active_unmask(1, true)

	-- ガチャボタン
	wait_get_accesser("Tutorial_SummonBtn")

	system.SetInteractableButton("Tutorial_ExpeditionBtn", false)
	system.SetInteractableButton("StoryBtn", false)

	set_mask_color("#0000007F")
	active_unmask(1, true)
	set_active_arrow(true)
	set_unmask_fittarget(1, "Tutorial_SummonBtn", false, true)
	set_position_target_arrow("Tutorial_SummonBtn", 0, 40)
	wait_button_click("Tutorial_SummonBtn")

	active_unmask(1, false)
	set_mask_color("#00000000")
	set_active_arrow(false)

	-- ガチャの表示がでるまで待つ
	wait_get_accesser("GachaFree1")

	-- アニメーションしてそうなら待つ
	wait_get_accesser("GachaTop")
	wait_play_ui_animation("GachaTop")
	wait_ui_animation("GachaTop")

	-- ガチャチュートリアルのダイアログ表示
	active_tutorial_mask()
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(5, true))
	wait_proccess(OpenTutorialPopup())

	-- マスクの表示
	active_tutorial_mask()
	set_mask_color("#0000007F")

	-- テキストの表示
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_46_01001")	--受け取った「チュートリアル召喚チケット」を使って～
	close_tutorial_popup()

	wait_get_accesser("GachaFree1")
	set_active_arrow(true)
	set_rotation_arrow(180)
	set_position_target_arrow("GachaFree1", 0, -40)
	active_unmask(1, true)
	set_unmask_fittarget(1, "GachaFree1", false, true)
	wait_button_click("GachaFree1")

	set_active_arrow(false)
	active_unmask(1, false)
	set_mask_color("#00000000")

	-- アニメーションしてそうなら待つ
	wait_get_accesser("PopupGachaStart")
	wait_play_ui_animation("PopupGachaStart")
	wait_ui_animation("PopupGachaStart")
	
	wait_get_accesser("GachaConfirm")
	set_active_arrow(true)
	active_unmask(1, true)
	set_unmask_fittarget(1, "GachaConfirm", false, true)
	set_rotation_arrow(180)
	set_position_target_arrow("GachaConfirm", 0, -40)
	wait_button_click("GachaConfirm")

	deactive_tutorial_mask()
	set_active_arrow(false)
	-- API発行完了待ち
	while not system.GetTutorialEvent("GachaPayRequestSuccess") do
		coroutine.yield()
	end
    system.SetTutorialNextSequence()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_2)

	-- ガチャ演出待ち
	wait_get_accesser("GachaManager")
	-- playされるまで待つ
	while not system.IsPlayGacha("GachaManager") do
		coroutine.yield()
	end
	-- playが終わるまで待つ
	while system.IsPlayGacha("GachaManager") do
		coroutine.yield()
	end

	-- アニメーションしてそうなら待つ
	wait_get_accesser("GachaResult")
	wait_play_ui_animation("GachaResult")
	wait_ui_animation("GachaResult")

	system.RegisterGachaCameraTutorialCamera("GachaManager")

	active_tutorial_mask()
	-- ガチャの結果画面でもどるボタンを押させる
	wait_get_accesser("GachaResultBack")
	set_active_arrow(true)
	set_unmask_fittarget(1, "GachaResultBack", false, true)
	set_rotation_arrow(0)
	set_position_target_arrow("GachaResultBack", 0, 40)
	wait_button_click("GachaResultBack")
	active_unmask(1,false)
	set_active_arrow(false)

	wait_play_ui_animation("GachaResult")
	wait_ui_animation("GachaResult")

	-- TOPボタンにもどるボタンを押させる
	set_active_arrow(true)
	active_unmask(1,true)
	set_mask_color("#0000007F")
	wait_get_accesser("OutGameTopBtn")
	set_unmask_fittarget(1, "OutGameTopBtn", false, true)
	set_rotation_arrow(0)
	set_position_target_arrow("OutGameTopBtn", 0, 40)
	wait_button_click("OutGameTopBtn")

	-- 一旦矢印を非表示にする
	set_active_arrow(false)
	set_mask_color("#00000000")
	active_unmask(1,false)

end

function PlayExpedition()
	set_active_arrow(false)
	close_textbox_base()
	TextBox.SetActive(false)
	
	-- バックキーを無効化
	system.SetEnableBackKeyTutorial(false)

	local continueStart = false
	-- マスクの表示
	set_mask_color("#00000000")
	active_tutorial_mask()
	WaitAnimation("ContainerHomeScene")

	if TUTORIAL_SEQUENCE_PROGRESS == 1300 then
		open_tutorial_popup(nil, 0, 0)
			set_message_tutorial_popup("TU_47_01001")	--『遠征』が解放されました。遠征ボタンから～
		close_tutorial_popup()
	else
		continueStart = true
		open_tutorial_popup(nil, 0, 0)
			set_message_tutorial_popup("TU_64_01001") -- 遠征チュートリアルが未完了です。<br>遠征ボタンから再開しましょう。
		close_tutorial_popup()
	end

	set_mask_color("#0000007F")
	-- 遠征ボタンを押させる
	system.SetInteractableButton("Tutorial_ExpeditionBtn", true)
	system.SetInteractableButton("Tutorial_SummonBtn", false)
	system.SetInteractableButton("StoryBtn", false)

	active_unmask(1, true)
	set_active_arrow(true)
	active_tutorial_mask()
	set_mask_color("#0000007F")
	set_rotation_arrow(0)
	set_position_target_arrow("Tutorial_ExpeditionBtn", 0, 40)
	set_unmask_fittarget(1, "Tutorial_ExpeditionBtn", false, true)
	wait_button_click("Tutorial_ExpeditionBtn")

	-- 一旦矢印を非表示にする
	set_active_arrow(false)
	active_unmask(1,false)
	set_mask_color("#00000000")

	while not system.ProcessingChangeScene() do
		coroutine.yield()
	end
	while system.ProcessingChangeScene() do
		coroutine.yield()
	end

	wait_get_accesser("ExpeditionTopScene")
	wait_play_ui_animation("ExpeditionTopScene")
	wait_ui_animation("ExpeditionTopScene")

	if TUTORIAL_SEQUENCE_PROGRESS == 1300 then
		-- 編成済みか
		if system.ChangeExpeditionParty() then
			system.SetTutorialNextSequence()
			SetTrackingId(AD_EVENT_HOME_TUTORIAL_3)
		else
			active_tutorial_mask()
			-- チュートリアル
			wait_proccess(LoadTutorialPopup())
			wait_proccess(CreateTutorialPopup(6, true))
			wait_proccess(OpenTutorialPopup())


			-- 通常の遠征の設定をさせる
			PlayExpeditionSetting()
			continueStart = false;
		end
	end
	if TUTORIAL_SEQUENCE_PROGRESS == 1310 then
		-- 2時間時短チケットを持っているか
		if not system.HasTwoHourExpeditionRapidTicket() then
			system.SetTutorialNextSequence()
			SetTrackingId(AD_EVENT_HOME_TUTORIAL_4)
		else
			-- チケット使わせる
			PlayExpeditionUseTicket()
			continueStart = false;
		end
	end
	if TUTORIAL_SEQUENCE_PROGRESS == 1320 then
		-- 回収させる
		PlayExpeditionCollecting(continueStart)
		continueStart = false;
	end
	if TUTORIAL_SEQUENCE_PROGRESS == 1330 then
		-- ボスお任せ編成
		PlayExpeditionBossSetting()
		continueStart = false;
	end
	if TUTORIAL_SEQUENCE_PROGRESS == 1340 then
		-- ボスと戦う
		if system.GetExpeditionBossLevel(1) > 1 then
			system.SetTutorialNextSequence()
			SetTrackingId(AD_EVENT_HOME_TUTORIAL_7)
		else
			PlayExpeditionBossBattle(continueStart)
			continueStart = false;
		end
	end

	-- 戻るボタンを押させる
	set_active_arrow(true)
	active_unmask(1,true)
	active_tutorial_mask()
	set_mask_color("#0000007F")
	set_rotation_arrow(0)
	set_position_target_arrow("Tutorial_BackBtn", 0, 40)
	set_unmask_fittarget(1, "Tutorial_BackBtn", false, true, 10, 10, -20, -20)
	wait_button_click("Tutorial_BackBtn")

	-- 矢印を一旦非表示に
	set_mask_color("#00000000")
	set_active_arrow(false)
	active_unmask(1,false)

	set_active_arrow(false)
	deactive_tutorial_mask()
	close_textbox_base()
	TextBox.SetActive(false)

	while not system.ProcessingChangeScene() do
		coroutine.yield()
	end
	while system.ProcessingChangeScene() do
		coroutine.yield()
	end
	
	-- バックキーの無効化を解除
	system.SetEnableBackKeyTutorial(true)
end

function PushButtonWait(name, arrowX, arrowY, arrowRotate, offsetSizeX, offsetSizeY)
	set_active_arrow(true)
	active_unmask(1, true)
	set_rotation_arrow(arrowRotate)
	set_position_target_arrow(name, arrowX, arrowY)
	set_unmask_fittarget(1, name, false, true, offsetSizeX / 2 * -1, offsetSizeY / 2 * -1, offsetSizeX, offsetSizeY)
	wait_button_click(name)
	set_active_arrow(false)
	active_unmask(1, false)
end

function PushButtonWait_SetPosition(name, arrowX, arrowY, arrowRotate, offsetX, offsetY, offsetSizeX, offsetSizeY)
	set_active_arrow(true)
	active_unmask(1, true)
	set_rotation_arrow(arrowRotate)
	set_position_target_arrow(name, arrowX, arrowY)
	set_unmask_fittarget(1, name, false, true, offsetX, offsetY, offsetSizeX, offsetSizeY)
	wait_button_click(name)
	set_active_arrow(false)
	active_unmask(1, false)
end

function WaitAnimation(name)
	wait_get_accesser(name)
	wait_play_ui_animation(name)
	wait_ui_animation(name)
end

function PushUnitWait(scrollName, styleId)
	set_active_arrow(true)
	active_unmask(1, true)
	system.SetDisableScroll(scrollName)
	TutorialArrow.SetPositionStyleThumb("Arrow", scrollName, styleId, 0, 150)
	TurorialMask.SetTutorialUnmaskStyleThumb(scrollName, styleId, false, -85, -145, 170, 290)
	local signal = system.AddTutorialButtonEventStyleThumb(scrollName, styleId)
    while signal.IsProccessing() do
        coroutine.yield()
    end
    system.RemoveTutorialButtonEvent()
	set_active_arrow(false)
	active_unmask(1, false)
end

function PlayExpeditionSetting()
	set_mask_color("#0000007F")
	-- テキストの表示
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_61_01001") -- 編成から遠征に派遣するスタイルを設定しましょう。
	close_tutorial_popup()

	PushButtonWait("ExpenditionFomation", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	WaitAnimation("ExpeditionOrganization")

	set_mask_color("#0000007F")
	
	system.SetDisableScroll("ExpenditionPartyScroll")
	system.SetDisableCommonGesture("ExpenditionPartyCommonGesture")
	PushButtonWait("ExpenditionUnitSelect001", 0, 40, 0, 60, 60)

	WaitAnimation("PopupBottomEditStyle")

	PushUnitWait("ExpenditionUnitSelectView", 101011001)


	PushButtonWait("ExpenditionSelectDeiced", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	WaitAnimation("PopupBottomEditStyle")

	set_mask_color("#0000007F")
	PushButtonWait("ExpenditionUnitSelect002", 0, 40, 0, 60, 60)
	active_unmask(1, false)

	WaitAnimation("PopupBottomEditStyle")


	PushUnitWait("ExpenditionUnitSelectView", 101010001)

	set_active_arrow(true)
	PushButtonWait("ExpenditionSelectDeiced", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	WaitAnimation("PopupBottomEditStyle")

	set_mask_color("#0000007F")
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_61_01002") -- 遠征先により獲得報酬が異なります。今回は炎属性の<br>スタイル強化素材が得られる場所を選択しましょう。
	close_tutorial_popup()

	PushButtonWait("ExpenditionChangeStage", 0, -40, 180, 0, 0)
	set_mask_color("#00000000")

	WaitAnimation("PopupStageSelectionDialog")

	set_mask_color("#0000007F")
	set_active_arrow(true)
	active_unmask(1, true)
	set_rotation_arrow(0)
	system.SetDisableScroll("ExpenditionStageSelectView")
	TutorialArrow.SetPositionExpeditionFieldBanner("Arrow", "ExpenditionStageSelectView", 1, 0, 40)
	TurorialMask.SetTutorialUnmaskExpeditionFieldBanner("ExpenditionStageSelectView", 1, false, 0, 0, 0, 0)
	local signal = system.AddTutorialButtonEventExpeditionFieldBanner("ExpenditionStageSelectView", 1)
    while signal.IsProccessing() do
        coroutine.yield()
    end
    system.RemoveTutorialButtonEvent()
	set_active_arrow(false)
	active_unmask(1, false)

	PushButtonWait("ExpenditionStageDecide", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	WaitAnimation("PopupStageSelectionDialog")

	set_mask_color("#0000007F")
	PushButtonWait("ExpenditionFomationDecide", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	-- API発行完了待ち
	deactive_tutorial_mask()
	while not system.GetTutorialEvent("ExpeditionConnectAPIPartyEditSuccess") do
		coroutine.yield()
	end
	active_tutorial_mask()

	-- 成功時に次に進める
	system.SetTutorialNextSequence()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_3)

	-- 経験値獲得が出た場合
	if system.GetTutorialEvent("ExpeditionCheckStyleLevelUp") then
		WaitAnimation("StyleEXPAcquisitionPopup")
		deactive_tutorial_mask()
		wait_button_click("StyleEXPAcquisitionPopupClose")
		active_tutorial_mask()
	end
end

function PlayExpeditionUseTicket()
	-- テキストの表示
	set_mask_color("#0000007F")

	active_unmask(1, true)
	set_unmask_fittarget(1, "ExpeditionBox", false, false, -40, -50, 80, 40)
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_61_01003") -- 遠征中は一定時間ごとにスタイルに経験値が入る他、<br>獲得した報酬を遠征ボックスから回収できます。
		set_message_tutorial_popup("TU_61_01004") -- また高速遠征を利用することで指定時間分の経験値や<br>報酬が即、入手できます。早速、試してみましょう。
	close_tutorial_popup()

	PushButtonWait("HighSpeedExpeditionBtn", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	WaitAnimation("HighSpeedExpeditionDialog")

	set_mask_color("#0000007F")
	PushButtonWait("HighSpeedExpeditionTicketSelect", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	if system.GetTutorialEvent("HighSpeedExpeditionWarningDialog") then
		set_mask_color("#00000000")
		WaitAnimation("SystemPopupSText")
		set_mask_color("#0000007F")

		PushButtonWait("SystemPopupSTextDecide", 0, 40, 0, 0, 0)

		set_mask_color("#00000000")
		WaitAnimation("SystemPopupSText")
		set_mask_color("#0000007F")
	end

	WaitAnimation("HighSpeedExpeditionConfirmationDialog")

	set_mask_color("#0000007F")
	PushButtonWait("HighSpeedExpeditionConfirmationDecide", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	-- API発行完了待ち
	deactive_tutorial_mask()
	while not system.GetTutorialEvent("HighSpeedExpeditionAPISuccess") do
		coroutine.yield()
	end
	active_tutorial_mask()
	set_mask_color("#00000000")
	system.SetTutorialNextSequence()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_4)
end

function PlayExpeditionCollecting(continueStart)
	
	if continueStart then
		set_mask_color("#0000007F")
		open_tutorial_popup(nil, 0, 0)
			set_message_tutorial_popup("TU_65_01002") -- 遠征の報酬を受け取ることができます。<br>遠征ボックスをタップしましょう。
		close_tutorial_popup()
		-- 回収ダイアログが開いていないので開かせる
		PushButtonWait_SetPosition("ExpeditionBox", 0, 40, 0, -40, -50, 80, 40)
		set_mask_color("#00000000")
	else
		-- トースターのアニメーション待ち
		set_mask_color("#00000000")
--		WaitAnimation("ToasterUI_A") -- 本番環境でこのイベントが来なくて永久ループに入るのでコメントをして秒数で先に進むようにする
		wait_time(3.5)
		-- チュートリアル文言表示
		set_mask_color("#0000007F")
		open_tutorial_popup(nil, 0, 0)
			set_message_tutorial_popup("TU_65_01002") -- 遠征の報酬を受け取ることができます。<br>遠征ボックスをタップしましょう。
		close_tutorial_popup()
		-- 回収ダイアログが開いていないので開かせる
		PushButtonWait_SetPosition("ExpeditionBox", 0, 40, 0, -40, -50, 80, 40)
		set_mask_color("#00000000")
	end
	WaitAnimation("ExpeditionBoxDialog")

	set_mask_color("#0000007F")
	PushButtonWait("ExpeditionBoxDialogCollect", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	-- API発行完了待ち
	deactive_tutorial_mask()
	while not system.GetTutorialEvent("ApiExpeditionBoxOpenSuccess") do
		coroutine.yield()
	end
	active_tutorial_mask()
	system.SetTutorialNextSequence()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_5)

	WaitAnimation("ItemCollectPopup")
	deactive_tutorial_mask()
	wait_button_click("ItemCollectPopupClose")
	active_tutorial_mask()
	WaitAnimation("ItemCollectPopup")

	if system.GetTutorialEvent("ExpeditionCheckStyleLevelUp") then
		WaitAnimation("StyleEXPAcquisitionPopup")
		deactive_tutorial_mask()
		wait_button_click("StyleEXPAcquisitionPopupClose")
		active_tutorial_mask()
		WaitAnimation("StyleEXPAcquisitionPopup")
	end
end

function PlayExpeditionBossSetting()
	set_mask_color("#0000007F")
	
	-- テキストの表示
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_61_01005") -- ボスに挑戦しましょう。勝てばステージLvが上昇し、<br>より多くの経験値やレア報酬が獲得可能になります。
	close_tutorial_popup()

	PushButtonWait("ExpeditionBoss", 0, 40, 0, 0, 0)

	WaitAnimation("ExpeditionBossListPopup")

	-- 遠征ボスチュートリアルのダイアログ表示
	active_tutorial_mask()
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(21, true))
	wait_proccess(OpenTutorialPopup())

	
	set_mask_color("#0000007F")
	system.SetDisableScroll("ExpeditionBossList");
	set_active_arrow(true)
	active_unmask(1, true)
	set_rotation_arrow(180)
	TutorialArrow.SetPositionExpeditionBossList("Arrow", "ExpeditionBossList", 1, "Obj_Btn_Base/Img_Challenge_Base/Btn_Challenge", 0, -40)
	TurorialMask.SetTutorialUnmaskExpeditionBossList("ExpeditionBossList", 1, "Obj_Btn_Base/Img_Challenge_Base/Btn_Challenge", false, 0, 0, 0, 0)
	local signal = system.AddTutorialButtonEventExpeditionBossList("ExpeditionBossList", 1, "Obj_Btn_Base/Img_Challenge_Base/Btn_Challenge")
    while signal.IsProccessing() do
        coroutine.yield()
    end
    system.RemoveTutorialButtonEvent()
	set_active_arrow(false)
	active_unmask(1, false)
	set_mask_color("#00000000")

	WaitAnimation("ExpeditionBossScene")
	
	set_mask_color("#0000007F")

	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_61_01006") -- ボスに挑戦するスタイルを編成しましょう。
	close_tutorial_popup()

	PushButtonWait("ExpeditionBossFormation", 0, 40, 0, 0, 0)

	set_mask_color("#00000000")
	WaitAnimation("ExpeditionOrganization")
	set_mask_color("#0000007F")
	
	PushButtonWait("ExpenditionFomationOmakase", 0, 40, 0, 0, 0)


	set_mask_color("#00000000")
	WaitAnimation("SystemPopupSText")
	set_mask_color("#0000007F")

	PushButtonWait("SystemPopupSTextDecide", 0, 40, 0, 0, 0)

	set_mask_color("#00000000")
	WaitAnimation("SystemPopupSText")
	set_mask_color("#0000007F")

	PushButtonWait("ExpenditionFomationDecide", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	-- API発行完了待ち
	deactive_tutorial_mask()
	while not system.GetTutorialEvent("ExpeditionConnectAPIBossPartyEditSuccess") do
		coroutine.yield()
	end
	active_tutorial_mask()

	system.SetTutorialNextSequence()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_6)
end

function PlayExpeditionBossBattle(continueStart)
	if continueStart then
		set_mask_color("#0000007F")
		open_tutorial_popup(nil, 0, 0)
			set_message_tutorial_popup("TU_66_01002") -- ボスに挑戦しましょう。勝てばステージLvが上昇し、<br>より多くの経験値やレア報酬が獲得可能になります。
		close_tutorial_popup()

		PushButtonWait("ExpeditionBoss", 0, 40, 0, 0, 0)

		WaitAnimation("ExpeditionBossListPopup")
	
		set_mask_color("#0000007F")
		system.SetDisableScroll("ExpeditionBossList")
		set_active_arrow(true)
		active_unmask(1, true)
		set_rotation_arrow(180)
		TutorialArrow.SetPositionExpeditionBossList("Arrow", "ExpeditionBossList", 1, "Obj_Btn_Base/Img_Challenge_Base/Btn_Challenge", 0, -40)
		TurorialMask.SetTutorialUnmaskExpeditionBossList("ExpeditionBossList", 1, "Obj_Btn_Base/Img_Challenge_Base/Btn_Challenge", false, 0, 0, 0, 0)
		local signal = system.AddTutorialButtonEventExpeditionBossList("ExpeditionBossList", 1, "Obj_Btn_Base/Img_Challenge_Base/Btn_Challenge")
		while signal.IsProccessing() do
			coroutine.yield()
		end
		system.RemoveTutorialButtonEvent()
		set_active_arrow(false)
		active_unmask(1, false)
		set_mask_color("#00000000")

		WaitAnimation("ExpeditionBossScene")
	end

	set_mask_color("#0000007F")
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_61_01007") -- STARTボタンで戦闘が開始されます。オート進行の<br>バトルで一定ターン以内に撃破できれば勝利です。
	close_tutorial_popup()

	PushButtonWait("ExpeditionBossStart", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	-- API発行完了待ち
	deactive_tutorial_mask()
	while not system.GetTutorialEvent("ExpeditionConnectAPIBossResult") do
		coroutine.yield()
	end
	active_tutorial_mask()

	system.SetTutorialNextSequence()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_7)

	WaitAnimation("BossBattleResultStageClearPopup")
	deactive_tutorial_mask()
	wait_button_click("BossBattleResultStageClearPopupClose")
	active_tutorial_mask()

	WaitAnimation("ExpeditionBossListPopup")
	set_mask_color("#0000007F")
	PushButtonWait("ExpeditionBossListClose", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")
end

function PlayOutGameMenu()
	set_active_arrow(false)
	close_textbox_base()
	TextBox.SetActive(false)

	-- マスクの表示
	active_tutorial_mask()
	set_mask_color("#00000000")
	WaitAnimation("ContainerHomeScene")

	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_62_01001") -- 遠征で獲得したアイテムを使用して<br>スタイルを強化できます。
	close_tutorial_popup()

	set_mask_color("#0000007F")
	PushButtonWait("ArmouryButton", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	while not system.ProcessingChangeScene() do
		coroutine.yield()
	end
	while system.ProcessingChangeScene() do
		coroutine.yield()
	end

--	WaitAnimation("OutGameMenuRoot") -- 本番環境でこのイベントが終了せずに進行不能になるのでコメントアウトを試す

	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_63_01001") -- 遠征で獲得したフラグメントを消費することで<br>各スタイルのレベルを上げることができます。
	close_tutorial_popup()

	active_tutorial_mask()	
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(74, true))
	wait_proccess(OpenTutorialPopup())

	system.SetTutorialNextSequence()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_8)

	set_mask_color("#0000007F")
	open_tutorial_popup(nil, 0, 0)
		set_message_tutorial_popup("TU_63_01002") -- その他にも限界突破や転生など様々な強化方法が存在<br>します。素材を集め強力なスタイルを育てましょう。
	close_tutorial_popup()

	

	-- バックボタン押させる
	PushButtonWait("Tutorial_BackBtn", 0, 40, 0, 0, 0)
	set_mask_color("#00000000")

	-- 矢印を非表示に
	set_active_arrow(false)
	active_unmask(1,false)

	set_active_arrow(false)
	deactive_tutorial_mask()
	close_textbox_base()
	TextBox.SetActive(false)

	while not system.ProcessingChangeScene() do
		coroutine.yield()
	end
	while system.ProcessingChangeScene() do
		coroutine.yield()
	end
end

function PlayHomeEnd()
	active_tutorial_mask()
	set_mask_color("#00000000")
	WaitAnimation("ContainerHomeScene")

	system.SetInteractableButton("StoryBtn", true)

	open_tutorial_popup(nil, 0, 0)
	set_message_tutorial_popup("TU_01_04001")	--準備ができたら、ここから物語を再開しましょう。
	close_tutorial_popup()
	SetTrackingId(AD_EVENT_HOME_TUTORIAL_9)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	character2DFull_Preload(Aruhan, "Aruhan", 101059001)
end
