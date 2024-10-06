--[[
	コミュの処理
]]

-- 現在のコミュの種類を指定して、現在のパラメータを取得する（獲得）
--  comuRankName = adv_variables.xlsmで設定した変数名（コミュランク）
--  comuPointName = adv_variables.xlsmで設定した変数名（親密度）
function set_communication_acquired(comuRankName, comuPointName)
	comuparam = system.Param.SetCommunicationInAcquired(comuRankName, comuPointName)
	-- コミュ獲得イベントのパラメータとして更新
	comuparam.UpdateAcquired()
	return comuparam
end

-- 現在のコミュの種類を指定して、現在のパラメータを取得する（導入）
--  comuRankName = adv_variables.xlsmで設定した変数名（コミュランク）
--  comuPointName = adv_variables.xlsmで設定した変数名（親密度）
function set_communication_intro(comuRankName, comuPointName)
	return system.Param.SetCommunicationInIntro(comuRankName, comuPointName)
end

-- 現在のコミュの種類を指定して、現在のパラメータを取得する（本体）
--  comuRankName = adv_variables.xlsmで設定した変数名（コミュランク）
--  comuPointName = adv_variables.xlsmで設定した変数名（親密度）
function set_communication(comuRankName, comuPointName)
	return system.Param.SetCommunicationInNormal(comuRankName, comuPointName)
end

-- 現在のコミュの種類を指定して、現在のパラメータを取得する（ランクアップ）
--  comuRankName = adv_variables.xlsmで設定した変数名（コミュランク）
--  comuPointName = adv_variables.xlsmで設定した変数名（親密度）
function set_communication_rankup(comuRankName, comuPointName)
	return system.Param.SetCommunicationInRankup(comuRankName, comuPointName)
end

-- ノーマルコミュ効率化アイテムの選択ウインドウ表示処理
-- commuparam = 対応するコミュのインスタンス
function normal_commu_item_menu(commuparam)
	
	-- 所持している章関連アイテムのリソースロード
	local load = system.LoadHavingChapterItemResource()
	while load.IsProccessing() do
		coroutine.yield()
	end
	
	local menu = {}
	menu[1] = { TextValue="", IntValue=0 }	-- 「使用しない」項目の追加
	
	local items = commuparam.GetNormalCommuItems()
	for i=1, #items do
		local ele = { TextValue=items[i].Name, IntValue=items[i].Num, ItemId = items[i].ItemId }
		table.insert(menu, ele)
	end
	
   	local index = open_item_window_general(menu)
   	local itemid = 0
   	if index > 1 then -- indexは始まり
   		itemid = items[index - 1].ItemId
   	end
   	commuparam.SetSelectedNormalCommuItem( itemid )
    
end

-- npcコミュに関する情報取得オブジェクト
-- Object [ ConditionItem ]
-- ConditionItem [ string ItenName, int ItemNum ]
function get_npc_communication()
    return system.GetNpcCommunicationObject()
end