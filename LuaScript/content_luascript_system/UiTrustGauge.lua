
TrustGauge = system.LoadTrustResultUI("ui_page_areaui", "Container_TrustGauge", 900)
UiLoadList[#UiLoadList + 1] = TrustGauge

-- 親密度ゲージを開く
--  targetCharacter_* = リンクするキャラクターのコントローラID　※character2DでthumbImagePath指定必須
--  trustParam_* = set_communication系関数で取得したパラメータ
function open_trust_gauge(targetCharacter_1, trustParam_1, targetCharacter_2, trustParam_2, targetCharacter_3, trustParam_3)
	system.SetDefaultPlaySpeed(true)
	-- timeline構築
	local initSignal = TrustGauge.InitializeTimelineController("TrustGauge")
	while initSignal.IsProccessing() do
		coroutine.yield()
	end

	-- UI準備
	TrustGauge.SetActive(true)
	TrustGauge.SetGauge( targetCharacter_1, trustParam_1)

	-- in
	local playSignal = TrustGauge.PlayUITimelineControllerInAnimation("TrustGauge", "TrustGauge_In")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end
	
	-- 演出
	TrustGauge.Play()
	while TrustGauge.IsProccessing() do
		coroutine.yield()
	end
	
	-- out
	playSignal = TrustGauge.PlayUITimelineControllerOutAnimation("TrustGauge", true, "TrustGauge_Out")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end

	system.SetDefaultPlaySpeed(false)
end
