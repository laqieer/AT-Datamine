--[[
	試験ADV処理用
]]

-- 試験結果報酬ポップアップ処理(現在のシーケンスIDを元に処理）
function play_studyRewards()

	local items = system.GetStudyRewardItems()
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

