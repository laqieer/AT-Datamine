
PopupButton = system.LoadUI("2dassets_ui_story_common", "Adv_Com_Popup_001", 1500)
UiLoadList[#UiLoadList + 1] = PopupButton

-- ボタン付き汎用ポップアップを開く
--  titleTag = タイトルのテキストのタグ
--  messageTag = メッセージのタグ
--  buttonText1 = １番目のボタンに表示するテキストのタグ
--  buttonText2 = ２番目のボタンに表示するテキストのタグ（nilだとボタンが無くなる）
function open_button_popup(titleTag, messageTag, buttonText1, buttonText2)
	-- 初期化
	system.SetDefaultPlaySpeed(true)
	PopupButton.SetTextTag("Title", titleTag)
	PopupButton.SetTextTag("Message", messageTag)
	PopupButton.SetTextTag("Button1", buttonText1)
	local bool validButton2 = (buttonText2 != nil) -- ボタンは１個と２個で切り替えられる
	PopupButton.SetActive("Button2", validButton2)
	if validButton2 then
		PopupButton.SetTextTag("Button2", buttonText2)
	end
	-- 表示開始
	PopupButton.Play("In", true)
	while PopupButton.IsProccessing() do
		coroutine.yield()
	end
	-- 入力待ち
	if validButton2 then
		PopupButton.Input("Button1", "Button2")
	else
		PopupButton.Input("Button1")
	end
	while PopupButton.IsProccessing() do
		coroutine.yield()
	end
	-- 終了
	system.PlaySE("SE_00002")
	PopupButton.Play("Out", false)
	while PopupButton.IsProccessing() do
		coroutine.yield()
	end
	system.SetDefaultPlaySpeed(false)
end

-- ボタン付き汎用ポップアップの直前の選択状態を取得する
--  index = 調べたい選択肢の番号（1～2）
--  return = true : 選んだ選択肢, false : 選んでない
function is_button_popup(index)
	local buttonName = "Button" .. tostring(index)
	return PopupButton.GetSelectedKey() == buttonName
end

