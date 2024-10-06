--[[
	親密度獲得演出
]]

-- 親密度獲得演出UIの生成
-- 同時に表示される場合を考慮し必要な分だけ生成してもらう
function set_friendship_up(isActive)
	local friendshipUp = system.LoadFriendshipUp("content_effect_adv_ui_effect_adv_friendship_up", "effect_adv_friendship_up", 300)
	UiLoadList[#UiLoadList + 1] = friendshipUp
	local locator = set_empty_object(true)
	friendshipUp.SetFollowObject(locator, false)
	while friendshipUp.IsProccessing() do
		coroutine.yield()
	end
	friendshipUp.SetActive(isActive)
	return friendshipUp
end

-- キャラクターのボーン位置を基準に親密度獲得演出を再生する
--  character = 表示する座標の基準となるキャラクターのコントローラID
--  boneName = 出現させる場所のボーンの名前
--  ui = set_friendship_up()で生成した親密度獲得演出オブジェクト
--  offsetX = 表示位置の調整値X
--  offsetY = 表示位置の調整値Y
--  offsetZ = 表示位置の調整値Z
--  comuParam = set_communication*()で取得したパラメータ
function effect_friendship_up_at_character(character, boneName, ui, offsetX, offsetY, offsetZ, comuParam)
	-- 同フレーム内でカメラ切り替えが発生した場合を考慮しモデルのカリングによる座標更新を待つ
	coroutine.yield()

	-- 演出設定
	local pos = get_bone_position(character, boneName)
	ui.MoveFollowObject(pos[1] + offsetX, pos[2] + offsetY, pos[3] + offsetZ, 0.0)
	ui.Play(comuParam.AddPoint)
end

-- 座標を直接指定して親密度獲得演出を再生する
--  ui = set_friendship_up()で生成した親密度獲得演出オブジェクト
--  posX = 表示位置の調整値X
--  posY = 表示位置の調整値Y
--  posZ = 表示位置の調整値Z
--  comuParam = set_communication*()で取得したパラメータ
function effect_friendship_up_directly(ui, posX, posY, posZ, comuParam)
	-- 座標更新を待つ必要はないが上記とタイミングがずれるのも不自然になりそうなので同様に待ちを入れておく
	coroutine.yield()

	-- 演出設定
	ui.MoveFollowObject(posX, posY, posZ, 0.0)
	ui.Play(comuParam.AddPoint)
end

-- 擬似バトルADV用の親密度獲得演出再生
-- id = 管理ID
-- ui = set_friendship_up()で生成した親密度獲得演出オブジェクト
--  comuParam = set_communication*()で取得したパラメータ
-- offset = 表示位置の調整置の配列
function dot_friendship_up(id, ui, comuParam, offset)
	local pos = dot_get_unit_locator(id, DotEffect_Head)
	if offset != nil then
		pos[1] = pos[1] + offset[1]
		pos[2] = pos[2] + offset[2] + 0.4
		pos[3] = pos[3] + offset[3]
	else
		pos[2] = pos[2] + 0.4
	end
	
	ui.MoveFollowObject(pos[1], pos[2], pos[3], 0.0)
	ui.play(comuParam.AddPoint)
end
