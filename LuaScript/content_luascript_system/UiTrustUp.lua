
TrustUI = system.LoadTrustUp("ui_page_kizunarunkup_prefab", "Container_KizunaRankUP")
UiLoadList[#UiLoadList + 1] = TrustUI

-- ランクアップ演出の終了用Timeline
TrustUI_Timeline = system.LoadStackObject("rankup_out", "ui_page_kizunarunkup_timeline", "KizunaRankUP_Out")
UiAssetLoadList[#UiAssetLoadList + 1] = TrustUI_Timeline


-- コミュパラメーターアップ画面を開く（ランクアップ無し）
function open_trust_up()
	system.SetDefaultPlaySpeed(true)
	system.PlaySE("SE_00601")
	TrustUI.Play("Trust_In", true)
	while TrustUI.IsProccessing() do
		coroutine.yield()
	end
	TrustUI.Play("Trust_Out", false)
	while TrustUI.IsProccessing() do
		coroutine.yield()
	end
	system.SetDefaultPlaySpeed(false)
end

-- コミュパラメーターアップ画面を開く（ランクアップ有り）
--  targetCharacter =  リンクするキャラクターのコントローラID　※character2DでfullImagePath指定必須
--  trustParam = set_communication系関数で取得したパラメータ
function open_trust_rank_up(targetCharacter, trustParam)

	-- 初期化
	system.SetDefaultPlaySpeed(true)
	close_footer_ui()

	wait_proccess(TrustUI.Init(targetCharacter, trustParam))
	-- Timeline初期化
	TrustUI.SetActive("Root", true)
	TrustUI.SetActive("TrustTop", true)
	wait_proccess(TrustUI.InitializeTimelineController("TrustTop"))

	-- 開始演出
	system.PlaySE("SE_00602")
	TrustUI.PlayUITimelineControllerInAnimation("TrustTop","rankup_in")

	-- チュートリアル有無check
	local isOpenedTutorial = true
	if trustParam.GetOpenTutorialNum() !=0 then
		isOpenedTutorial = false
	end

	-- 報酬表示
	local isFirstIn = true
	for index = 0, (trustParam.GetRewardCount-1) do
		TrustUI.SetActiveRewardPanel(index, true)
		TrustUI.SetRewardPanel(index)
		TrustUI.PlayRewardIn(index, isFirstIn)
		while TrustUI.IsProccessing() do
			coroutine.yield()
		end

		--チュートリアル表示
		if isOpenedTutorial == false then
			for i = 0, trustParam.GetOpenTutorialNum() - 1 do
				wait_proccess(LoadTutorialPopup())
				wait_proccess(CreateTutorialPopup(trustParam.GetTutorialID(i)))
				wait_proccess(OpenTutorialPopup())
			end
			isOpenedTutorial = true
		end

		-- キー入力待ち
		TrustUI.Input("Button")
		while TrustUI.IsProccessing() do
			coroutine.yield()
		end
		system.PlaySE("SE_00009")
		TrustUI.PlayRewardOut(index)
		while TrustUI.IsProccessing() do
			coroutine.yield()
		end
		isFirstIn = false
		TrustUI.SetActiveRewardPanel(index, false)
	end

	-- 終了演出
	system.PlaySE("SE_00601")
	wait_proccess( TrustUI.PlayUITimelineControllerOutAnimation("TrustTop",true,"rankup_out") )

	TrustUI.SetActive("TrustTop", false)
	open_footer_ui(false)
	
	system.SetDefaultPlaySpeed(false)
end

