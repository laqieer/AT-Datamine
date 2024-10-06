
Popup = system.LoadUI("ui_page_adv", "Adv_TextBox_003", 1400)
UiLoadList[#UiLoadList + 1] = Popup

function open_popup_base()
	system.SetDefaultPlaySpeed(true)
	Popup.Play("In", true)
	while Popup.IsProccessing() do
		coroutine.yield()
	end
	Popup.Input("All")
	while Popup.IsProccessing() do
		coroutine.yield()
	end
	system.PlaySE("SE_00009")
	Popup.Play("Out", false)
	while Popup.IsProccessing() do
		coroutine.yield()
	end
	system.SetDefaultPlaySpeed(false)
end

-- 汎用ポップアップを開く
--  titleText = タイトルのテキスト
--  messageText = メッセージ
function open_popup_direct(titleText, messageText)
	if titleText != nil then
		Popup.SetText("Title", titleText)
	else
		Popup.SetText("Title", "")
	end
	if messageText != nil then
		Popup.SetText("Message", messageText)
	else
		Popup.SetText("Message", "")
	end
	open_popup_base()
end

-- 汎用ポップアップを開く
--  titleTag = タイトルのテキストのタグ
--  messageTag = メッセージのタグ
function open_popup(titleTag, messageTag)
	if titleTag != nil then
		Popup.SetTextTag("Title", titleTag)
	else
		Popup.SetText("Title", "")
	end
	if messageTag != nil then
		Popup.SetTextTag("Message", messageTag)
	else
		Popup.SetText("Message", "")
	end
	open_popup_base()
end

