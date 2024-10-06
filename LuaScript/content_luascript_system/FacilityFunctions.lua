--[[
	施設専用の処理
]]


-- 現在の施設情報を元に、パラメータを取得する
-- 引数はテスト時のみ有効になるので、正式動作時は省略しても問題ない
--  dummyAttachID = story_facility_attach.xlsmで設定した施設設定ID
--  dummyRewardSetLabelID = story_facility_rewardsetlabel.xlsmで設定した通常時の報酬セットID
--  dummyBonusSetLabelID = story_facility_rewardsetlabel.xlsmで設定したボーナス時の報酬セットID
--  isBonusWeather = ボーナスが天候ボーナスか、falseなら曜日ボーナス
function set_facility(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)
	if dummyRewardSetLabelID == nil then
		dummyRewardSetLabelID = 0
	end
	if dummyBonusSetLabelID == nil then
		dummyBonusSetLabelID = 0
	end
	if isBonusWeather == nil then
		isBonusWeather = false
	end
	return system.Param.SetFacility(dummyAttachID, dummyRewardSetLabelID, dummyBonusSetLabelID, isBonusWeather)
end

-- 所持しているアイテムのリソースロード
-- 現状、章関連のみ
function load_item_ui_resource()
	local load = system.LoadHavingChapterItemResource()
	while load.IsProccessing() do
		coroutine.yield()
	end
end

-- 施設情報オブジェクトを取得
-- ID = 識別ID
-- TextValue = 施設名
-- IntValue = 個数
-- Read = 読了済→true、未読了→false
function get_facility()
    return system.GetFacilityObject()
end

-- 効率化アイテム処理
function facility_buffitem_menu(buffItems)
    
    load_item_ui_resource()
    
    local menu = {}
    table.insert(menu, 1, { TextValue="", IntValue=0,  FlavorValue=""}) -- 1番目に「使用しない」を追加
	
	for i=1, #buffItems do
		local ele = { TextValue=buffItems[i].TextValue, IntValue=buffItems[i].IntValue, ItemId = buffItems[i].ItemId, FlavorValue = buffItems[i].TextFlavor }
		table.insert(menu, ele)
	end
	
	-- UI表示
	-- 1始まりなので0始まりに補正
	local menuIndex = open_item_window_general(menu)
    
    if menuIndex > 1 then -- 1番目以外なら
        -- 2番目以降を選んでいる。1番目は要らないのでずらす
        menuIndex = menuIndex - 1
        -- menuIndexは1始まり
        system.SelectMenuItem(menuIndex - 1) -- 0始まりを渡す
        return buffItems[menuIndex]
    end
    return nil
end

-- 人間パラメータを取得する(旧処理)
--  variableNames = adv_variables.xlsmで設定した変数名（人間パラメータ）の配列
function set_human_parameter(variableNames)
	return system.Param.SetHumanParameter(variableNames)
end

-- リザルト演出
-- humanParam = facilityやmenuItemの持つGetHumanParam()の結果
function play_facility_result(humanParam, character)
	-- リザルト演出
	if humanParam != nil then
	    open_parameter_up(humanParam, character)
	else
	    open_narration_window()
    	message_direct("人間パラメータ演出中(報酬が未設定)")
    	close_narration_window()
	end
end

-- バイト報酬演出
function play_facility_workReward(facility)
	system.SetDefaultPlaySpeed(true)
	popup = system.OpenPopupReward()
	signal = popup.Play(facility)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	-- チュートリアル
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(25))
	wait_proccess(OpenTutorialPopup())

	system.SetDefaultPlaySpeed(false)
end

function play_rewards(items)
    if items == nil then
        debug_print("アイテム獲得演出：報酬無し")
        return
    end
	system.SetDefaultPlaySpeed(true)
	popup = system.OpenPopupReward()
	signal = popup.PlayItems(items)
	while signal.IsProccessing() do
		coroutine.yield()
	end
	system.SetDefaultPlaySpeed(false)
end

-- 読書演出
-- readAction(book) 読了演出functionを入れる
-- notreadAction(book) 未読了演出functionを入れる
-- book { ID, TextValue = 名前, IntValue, Read = 読了済みか, Description = 本効果テキスト }
function play_reading(readAction, notreadAction)
    -- 施設情報取得
    local facility = get_facility()
	if facility.ShowMenu == true then
	    -- 本一覧を表示
	    local menuItems = facility.GetUserBooks()
    	local item = open_menu_window(menuItems, "読んだ回数")
    	-- 選んだ本を保存
    	system.SelectMenuItem(item.ID)
    	
    	--本効果テキスト
    	open_narration_window()
    	message(item.Description)
    	close_narration_window()
    	
    	if item.Read == true then
    	    -- 読了
    	    readAction(item)
    	else
    	    notreadAction(item)
    	    -- 未読了
    	end
	end
end

-- 挑戦演出
-- success() 成功演出functionを入れる
-- fail(string Message) 失敗演出functionを入れる
function play_challenge(success, fail)
    -- 施設情報取得
    local facility = get_facility()
	if facility.Challenge.Result == true then
	    -- 成功
	    success(facility.Challenge.GetHumanParam())
	else
	    -- 失敗
	    fail(facility.Challenge.Message)
	end
end
