
PopupPage = system.LoadUI("ui_page_adv", "Adv_TextBox_005", 1600)
UiLoadList[#UiLoadList + 1] = PopupPage

-- ページ付き汎用ポップアップを開く
--  titleTag = タイトルのテキストのタグ
--  subTitleTags = サブタイトルのテキストのタグの配列（ページの数分）
--  pageList = ページ情報の配列
--   pageList[ページ番号][1] = サブタイトルのタグ
--   pageList[ページ番号][2] = メッセージのタグ
function open_page_popup(titleTag, pageList)
	system.SetDefaultPlaySpeed(true)
	PopupPage.SetTextTag("Title", titleTag)
	PopupPage.Play("In", true)
	while PopupPage.IsProccessing() do
		coroutine.yield()
	end
	local pageTextBase = "/" .. tostring(#pageList) .. "page"

	for index, page in pairs(pageList) do
		PopupPage.SetTextTag("SubTitle", page[1])
		PopupPage.SetTextTag("Message", page[2])
		PopupPage.SetText("PageNum", tostring(index) .. pageTextBase)
		PopupPage.Input("All")
		while PopupPage.IsProccessing() do
			coroutine.yield()
		end
		system.PlaySE("SE_00002")
	end

	PopupPage.Play("Out", false)
	while PopupPage.IsProccessing() do
		coroutine.yield()
	end
	system.SetDefaultPlaySpeed(false)
end

