PersonalUp = system.LoadPersonalUp("content_effect_adv_ui_effect_adv_personal_up", "effect_adv_personal_up", 200)
UiLoadList[#UiLoadList + 1] = PersonalUp
PersonalUpLocator = nil

-- 人間パラメータの獲得演出を再生する
--  character = 表示する座標の基準となるキャラクターのコントローラID
--  boneName = 出現させる場所のボーンの名前
--  offsetX = 表示位置の調整値X
--  offsetY = 表示位置の調整値Y
--  offsetZ = 表示位置の調整値Z
--  humanParam = set_human_parameter()で取得したパラメータ
function effect_personal_up(character, boneName, offsetX, offsetY, offsetZ, humanParam)
	-- オブジェクトを生成していなければ作る
	if PersonalUpLocator == nil then
		PersonalUpLocator = set_empty_object(true)
		PersonalUp.SetFollowObject(PersonalUpLocator, false)
	end
	
	-- 同フレーム内でカメラ切り替えが発生した場合を考慮しモデルのカリングによる座標更新を待つ
	coroutine.yield()
	
	-- 演出設定
	local pos = get_bone_position(character, boneName)
	slidemove(PersonalUpLocator, pos[1] + offsetX, pos[2] + offsetY, pos[3] + offsetZ, 0.0, false)
	PersonalUp.Play(humanParam.LastUpdateIncrease);
end

