PopupButton = system.LoadUIToFront("ui_common_prefabs", "Com_Popup_Base_S_Text", 1500)
UiLoadList[#UiLoadList + 1] = PopupButton

--[[
	Com_Popup_Base_S_Text.prefabを使った確認window
	
	
]]
function open_popup_confirme_button(message, buttonTxtTag1, buttonTxtTag2)
	-- 初期化
	system.SetDefaultPlaySpeed(true)
	PopupButton.SetActive(true)

	-- 表示構築
	local listBtn = {}
	PopupButton.SetSimpleText("TxtMessage", message)
	local bool validButton2 = (buttonTxtTag2 != nil) -- ボタンは１個と２個で切り替えられる
	PopupButton.SetActive("Button2", validButton2)
	if validButton2 then
		--double button
		PopupButton.SetActive("Button1_1", true)			--x icon disp
		PopupButton.SetActive("Button1_3", false)			--o icon disp
		PopupButton.SetSimpleTextTag("TxtButton1_1", buttonTxtTag1)		

		PopupButton.SetActive("Button2_1", false)			--x icon disable
		PopupButton.SetActive("Button2_3", true)			--o icon disp
		PopupButton.SetSimpleTextTag("TxtButton2_3", buttonTxtTag2)
		
		listBtn[1] = "Button1_1"
		listBtn[2] = "Button2_3"
	else
		-- single button
		PopupButton.SetActive("Button1_1", false)			--x icon disable
		PopupButton.SetActive("Button1_3", true)			--o icon disp
		PopupButton.SetSimpleTextTag("TxtButton1_3", buttonTxtTag1)
		listBtn[1] = "Button1_3"
	end

	-- timeline構築
	local initSignal = PopupButton.InitializeTimelineController("Top")
	while initSignal.IsProccessing() do
		coroutine.yield()
	end

	-- 表示開始
	local playSignal = PopupButton.PlayUITimelineControllerInAnimation("Top", "Com_Popup_Base_Anim_in")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end

	-- 入力待ち
	if validButton2 then
		PopupButton.Input(listBtn, false )
	else
		PopupButton.Input(listBtn[1])
	end
	while PopupButton.IsProccessing() do
		coroutine.yield()
	end

	-- 終了
	system.PlaySE("SE_00002")
	playSignal = PopupButton.PlayUITimelineControllerOutAnimation("Top", false, "Com_Popup_Base_Anim_out")
	while playSignal.IsProccessing() do
		coroutine.yield()
	end

	system.SetDefaultPlaySpeed(false)
	-- answer check
	if validButton2 then
		-- select buton get
		local selButtton = PopupButton.GetSelectedKey()
		if selButtton == listBtn[2] then
			return true			-- yes
		else
			return false		-- no
		end
	else
		return true
	end
end




