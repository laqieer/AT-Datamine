--[[

	人間パラメータリザルト

]]

ParameterUpResult = system.LoadParameterUpResult("ui_page_adv", "Container_ParameterUp", "ui_page_adv", "Com_Popup_ParameterUP")
UiLoadList[#UiLoadList + 1] = ParameterUpResult

-- 人間パラメーターアップ画面を開く
--  humanParam = set_human_parameter()で取得したパラメータ
function open_parameter_up(humanParam, character)
	system.SetDefaultPlaySpeed(true)
	ParameterUpResult.Prepare(humanParam, character)
	ParameterUpResult.Play()
	while ParameterUpResult.IsProccessing() do
		coroutine.yield()
	end
	humanParam.ClearUpdateHistory() -- リザルト表示した分の履歴を削除する
	system.SetDefaultPlaySpeed(false)
end

