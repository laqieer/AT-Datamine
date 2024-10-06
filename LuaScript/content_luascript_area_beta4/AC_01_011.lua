----------------------------------------------------------------------------------------------------
-- β4版　施設利用：本のレンタル
-- ステージ：大図書院（昼・夕方・夜）
-- 登場キャラ：ノワール　クリスティーナ
-- スクリプト作成者：中嶋(悠)　古川
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup_nofade()

	Noir = area_setup_101009_Noir("Player", "Com_Std01_Loop_m")
	Christina = area_setup_101063_Christina("Christina", "An_Hom_101063001_Std02_Loop")
	
	BookList = book_list_with_tab()
	RentalBookPopup = load_book_popup()
	ReturnBookPopup = load_book_return_popup()
end

-- シーケンスの実行
function Play()
	demo_start_nofade_nofooter()

	local facility = get_facility()

	if facility.Book != nil then
		AC_01_011_Return_start()
		ReturnBook(facility)
	else
	    AC_01_011_Lending_start()

		Lending(facility)
	end

	demo_end_nofade()

end

function Lending(facility)

	-- 借りる本の選択
	if facility.ShowMenu == true then

		system.SetDefaultPlaySpeed(true)

		-- 本一覧を表示
		local books = facility.GetBooks()
		BookList.Open(books)

		local book = nil
		while book == nil do -- 確定するまでループ
			-- 選択待ち
			while BookList.Selected() == nil do
				if BookList.Canceled() then
					-- キャンセル時
					AC_01_011_Lending_cancel()
					system.CancelFacility()
					return
				end

				coroutine.yield()
			end

			local selected = BookList.Selected()

			-- 選択した本情報を設定
			RentalBookPopup.Set(selected)
			RentalBookPopup.SetPositiveButton("Popup_Btn_Story_BorrowBook")	--「本を借りる」ボタン
			-- ポップアップを表示
			RentalBookPopup.Open()
			-- アクション待ち
			while RentalBookPopup.Result == 0 do
				coroutine.yield()
			end
			-- なんらかのアクションがあったのでポップアップを閉じる
			RentalBookPopup.Close()

			if RentalBookPopup.Result == 1 then -- 肯定的リアクション
				book = selected
				BookList.Decide(selected)
			elseif RentalBookPopup.Result == -1 then
				BookList.Reset()
			end

		end

		BookList.Close()

		system.SetDefaultPlaySpeed(false)
	
		-- 本を借りる
		AC_01_011_Lending_book(book.Title)
	else
		-- 何も借りない
		AC_01_011_Lending_cancel()
		system.CancelFacility()
	end
end

function ReturnBook(facility)

--[[
	-- 読書の進捗に合わせてアナウンス変更
	if facility.Book.Read == true then
		AC_01_011_Return_finish()
	else
		AC_01_011_Return_unfinish()
	end
]]
	
	-- 返却確認
	ReturnBookPopup.Set(facility.Book)
	-- ポップアップを表示
	ReturnBookPopup.Open()
	-- アクション待ち
	while ReturnBookPopup.Result == 0 do
		coroutine.yield()
	end
	-- ポップアップを閉じる
	ReturnBookPopup.Close()

	if ReturnBookPopup.Result == 1 then -- 肯定的リアクション
		--返却する
		AC_01_011_Return_ok()
	elseif ReturnBookPopup.Result == -1 then
		--返却しない
		AC_01_011_Return_cancel()
		system.Cancel()
	end
end

----------------------------------------------------------------------------------------------------

function AC_01_011_First_start()



end

function AC_01_011_Lending_start()

	change_face(Christina, "Normal")
	open_speech_window("CHRNAME_CHRISTINA", Christina, nil)
		message("AC_01_0110002")
	close_speech_window()

end

function AC_01_011_Lending_book(bookTitle)

	change_face(Christina, "Normal")
	open_speech_window("CHRNAME_CHRISTINA", Christina, nil)
		message("AC_01_0110004")
	close_speech_window()

	-- 貸出本の表示
	open_narration_window()

		message_replace("AC_01_0110017", bookTitle)

	close_narration_window()
end

function AC_01_011_Lending_cancel()



end

----------------------------------------------------------------------------------------------------

function AC_01_011_Return_start()

	change_face(Christina, "Normal")
	open_speech_window("CHRNAME_CHRISTINA", Christina, nil)
		message("AC_01_0110006")
	close_speech_window()

end

function AC_01_011_Return_finish()



end

function AC_01_011_Return_unfinish()



end

function AC_01_011_Return_ok()

	change_face(Christina, "Normal")
	open_speech_window("CHRNAME_CHRISTINA", Christina, nil)
		message("AC_01_0110008")
	close_speech_window()

end

function AC_01_011_Return_cancel()



end

----------------------------------------------------------------------------------------------------

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	area_setup_101009_Noir_preload("Player", "Com_Std01_Loop_m")
	area_setup_101063_Christina_preload("Christina", "An_Hom_101063001_Std02_Loop")
end
