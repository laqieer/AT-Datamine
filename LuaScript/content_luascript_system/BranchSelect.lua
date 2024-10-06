
-- アロンダイト選択画面のロード処理
-- selectable_style_ids = 選択可能キャラの配列を渡す。指定がない場合はロック状態を確認して自動的に生成されるので通常使用時は指定なしで問題はない
function load_branch_select(selectable_style_ids)
    load_scene("scenes_branch_selection", "Branch_Selection")
	if selectable_style_ids == nil then
		system.SetLockState()
		selectable_style_ids = {}
		if system.GetActiveOptionState(0) >= 0 then
			selectable_style_ids[#selectable_style_ids + 1] = 101010001
		end
		if system.GetActiveOptionState(1) >= 0 then
			selectable_style_ids[#selectable_style_ids + 1] = 101011001
		end
		if system.GetActiveOptionState(2) >= 0 then
			selectable_style_ids[#selectable_style_ids + 1] = 101012001
		end
	end
    local signal = system.InitializeBranchSelect(selectable_style_ids)
	while signal.IsProccessing() do
		coroutine.yield()
	end
end

function pre_play_branch_select()
    local signal = system.PrePlayBranchSelect()
	while signal.IsProccessing() do
		coroutine.yield()
	end
end

-- アロンダイト選択画面の実行
function play_branch_select()
    change_scene("Branch_Selection")
	-- カレンダー表示を消す
	disp_calendar(false)
	system.Adv2SystemDeactive()
    local signal = system.PlayBranchSelect()
	while signal.IsProccessing() do
		coroutine.yield()
	end
	system.Adv2SystemActive()
	disp_calendar(true)
end

-- アロンダイト選択画面で選択されたスタイルIDを取得
function get_selected_style_id()
	return system.GetSelectedStyleId()
end

-- アロンダイト選択画面で選択されたスタイルIDを元に選択肢選択フラグを設定する
function set_selected_option()
	local style_id = get_selected_style_id()
	if style_id == 101010001 then
		system.SetActiveOptionOne(0)
	elseif style_id == 101011001 then
		system.SetActiveOptionOne(1)
	elseif style_id == 101012001 then
		system.SetActiveOptionOne(2)
	end
end
