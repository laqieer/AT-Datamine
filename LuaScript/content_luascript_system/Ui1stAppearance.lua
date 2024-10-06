
FirstAppear = system.Load1StAppeaerance("ui_page_1stappearance_prefab", "Container_1stAppearance", 1200)
UiLoadList[#UiLoadList + 1] = FirstAppear

-- 初登場演出
function open_1st_appeaerance(character)
	system.SetDefaultPlaySpeed(true)
	close_footer_ui()
	FirstAppear.SetActive(true)
	FirstAppear.Set1stAppearanceDatas(character.FullImageTag, character.StyleId)

	playSignal = FirstAppear.PlayUITimelineControllerInAnimation("TrustTop","1stAppearance_In")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end

	FirstAppear.Input("Button")
	while FirstAppear.IsProccessing() do
		coroutine.yield()
	end

	system.PlaySE("SE_00009")

	playSignal = FirstAppear.PlayUITimelineControllerOutAnimation("TrustTop",true,"1stAppearance_Out")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end
	FirstAppear.SetActive(false)

	open_footer_ui(false)
	
	system.SetDefaultPlaySpeed(false)
end

--初登場演出用共通関数
function OpenFirstAppearance(actor)
	
	open_1st_appeaerance(actor)
	
end
