
function load_subquest_window()
    QuestWindow = system.SubQuestPopup(system.Param.GetActiveSubQuestTaskID())
    QuestWindow.Load()
	while QuestWindow.IsProccessing() do
		coroutine.yield()
	end
end

-- クエスト情報ウィンドウを開く
function open_quest_window()
	-- 初期化
	system.SetDefaultPlaySpeed(true)
	
	load_subquest_window()
	
	-- 開始演出
	system.PlaySE("SE_00600")
	QuestWindow.In()
	
	-- 入力待ち
	QuestWindow.InputWait()
	while QuestWindow.IsProccessing() do
		coroutine.yield()
	end
	-- 終了演出
	system.PlaySE("SE_00009")
	QuestWindow.Out()

	system.SetDefaultPlaySpeed(false)
end

-- エリアイベントクエストの受注ダイアログ呼び出し
function open_areaeventquest_window_receipt()
    -- 不要になった
    -- quest = get_areaeventquest()
    -- open_quest_window(quest.QuestName, quest.Description, "受注", nil, quest.Rewards)
end

-- エリアイベントクエストの進行ダイアログ呼び出し
function open_areaeventquest_window_progress()
    -- 不要になった
    -- quest = get_areaeventquest()
    -- open_quest_window(quest.QuestName, quest.Description, "進行", quest.Progresses, quest.Rewards)
end

-- エリアイベントクエストの完了ダイアログ呼び出し
function open_areaeventquest_window_complete()
    -- 不要になった
    -- quest = get_areaeventquest()
    -- open_quest_window(quest.QuestName, quest.Description, "クリア", nil, quest.Rewards)
end

-- エリアイベントクエストの完了ダイアログ呼び出し
function open_subquest_window_complete()
    open_quest_window()
end
