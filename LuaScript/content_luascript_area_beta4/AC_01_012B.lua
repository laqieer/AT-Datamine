----------------------------------------------------------------------------------------------------
-- β4版　施設利用：読書（談話室）
-- ステージ：談話室
-- 登場キャラ：ノワール
-- スクリプト作成者：中嶋(悠)　古川
----------------------------------------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup_nofade()
	Load_Inst_Scene()
	
	facility = get_facility()
	BookList = book_list()
	BookPopup = load_book_popup()
end

-- シーケンスの実行
function Play()
	demo_start_nofade()

	-- 導入会話
	AC_01_012B_Inst_start()

	-- 本の所持チェック
	if facility.HaveReadableBook == true then

        -- フッター閉じる
        close_footer_ui()

		-- 本を読む/読まない
		open_select_window_tag(FreeMapNoir, "Normal", "AC_01_0120011", "AC_01_0120012")

		if is_select(1) then
			-- 読む
			scene_change_ready()
			Load_Main_Scene()
			scene_change_end()
	
			system.SetDefaultPlaySpeed(true)

			Reading()

			system.SetDefaultPlaySpeed(false)
	
			FreeMapNoir.ReleaseBodyAnimation()

			demo_end()
		else
			-- 読まない
			AC_01_012B_Inst_cancel()
			system.CancelFacility()
			demo_end_nofade()
			return -- 終了
		end

	else
		AC_01_012B_Inst_nobook()
		system.Cancel()	-- 読める本を持っていないので終了
		demo_end_nofade()
		return -- 終了
	end
end

function Reading()
	
	-- 施設情報取得
	if facility.ShowMenu == false then
		return
	end

	close_footer_ui()	-- 本リストと右上UIが被るのでUI非表示

	-- 本一覧を表示
	local books = facility.GetUserBooks()
	BookList.Open(books)
	
	local book = nil
	while book == nil do -- 確定するまでループ
		-- 選択待ち
		while BookList.Selected() == nil do
			if BookList.Canceled() then
				AC_01_012B_Inst_cancel()
				system.CancelFacility()
				return
			end
			coroutine.yield()
		end
		
		local selected = BookList.Selected()
		-- 選択した本情報を設定
		BookPopup.Set(selected)
		--BookPopup.SetPositiveButton("本を読む")
		BookPopup.SetPositiveButton("Popup_Btn_Story_ReadBook")
		-- ポップアップを表示
		BookPopup.Open()
		-- アクション待ち
		while BookPopup.Result == 0 do
			coroutine.yield()
		end
		-- なんらかのアクションがあったのでポップアップを閉じる
		BookPopup.Close()
		
		if BookPopup.Result == 1 then -- 肯定的リアクション
			book = selected
			BookList.Decide(selected)
		elseif BookPopup.Result == -1 then -- 否定的リアクション
			BookList.Reset()
		end
	end
	
	BookList.Close()

	wait_time(1.0)
	open_footer_ui(false)	-- 非表示にした右上UIを戻す

	for i, reaction in ipairs(book.Progress.Reactions) do
		open_textbox_by_type("PLAYERNAME_NOIR", reaction.TextBoxType, Noir, nil)
		    message_direct(reaction.Text)
	    close_textbox()
	end
	
	if book.Read == true then
		--読了時の感想
		for i, reaction in ipairs(book.Complete.Reactions) do
    		open_textbox_by_type("PLAYERNAME_NOIR", reaction.TextBoxType, Noir, nil)
    		    message_direct(reaction.Text)
    		close_textbox()
		end

		-- 読了
		AC_01_012B_Main_finish()
		-- 人間パラメータリザルト演出
		local human_param = book.GetHumanParam()
		if human_param != nil then
			play_facility_result(human_param, Noir)
		end
		-- アビリティ獲得演出
		for index,ability in ipairs(book.GetRewardAbilities()) do
			open_popup_confirme_button(ability.Text, "SELECT_NEXT") -- SELECT_NEXTは仮
		end
		-- 読書効果獲得演出
		if book.Complete.AppendEffect != nil then
			open_popup_confirme_button(book.Complete.AppendEffect.Text, "SELECT_NEXT") -- SELECT_NEXTは仮
		end
		
		-- アイテム獲得演出
		play_rewards(book.GetItemRewards())
	else
		-- 未読了
		AC_01_012B_Main_unfinish()
	end

	-- 終了
	AC_01_012B_Main_end()
end

-- 導入
function Load_Inst_Scene()

	FreeMapNoir = area_setup_101009_Noir("Player", "Com_Std01_Loop_m")

end

function AC_01_012B_Inst_start()

	change_face(FreeMapNoir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", FreeMapNoir, nil)
		message("AC_01_0120002")
	close_mind_window()
end

function AC_01_012B_Inst_cancel()



end

function AC_01_012B_Inst_nobook()

	change_face(FreeMapNoir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", FreeMapNoir, nil)
		message("AC_01_0120013")
	close_mind_window()

end



-- 本編

function Load_Main_Scene()

--	load_area_scene(110901) -- 談話室
	load_sequence_area_scene(110901) -- 談話室　※時間帯対応

	setup_101009_Noir({-1.035, 0, -0.316,   90}, "Com_Sit_Reading_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

	Book = set_object("content_prop_10103005", "10103005_PropModel", true)
--	on_parent(Book, Noir, "Loc_weapon_constrint_L", 0,0,0, 0,0,180)
	on_parent(Book, Noir, "Loc_weapon_constrint_L", 0,0,0, 0,0,0)

	MAIN_CAMERA = set_camera(0.0341, 0.90375, 0.78682,   351.4246, 220.1408, 0,   26.99147)
			-- カメラ関連の明るさ、ビネット設定
			--シーン(背景明るさ,"背景カラー","キャラライト方向",キャラライト強度,ポスト背景グラーデーション強度)
			set_scene_light_effect_parameter(nil, "#000000", nil, nil, 0.05)
			set_scene_vignette_effect(0.5, 0.5, "#000000", 0.2, 0.3, true)



	on_camera(MAIN_CAMERA)

end

function AC_01_012B_Main_finish()



end

function AC_01_012B_Main_unfinish()

	change_face(FreeMapNoir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", FreeMapNoir, nil)
		message("AC_01_0120004")
	close_mind_window()

end

function AC_01_012B_Main_end()

	change_face(FreeMapNoir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", FreeMapNoir, nil)
		message("AC_01_0120009")
	close_mind_window()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
