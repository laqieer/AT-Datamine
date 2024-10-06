--[[
	オブジェクトの処理
	（キャラクターやカメラも共通して使える）
]]


-- オブジェクトの移動
--  object = コントローラID
--  posrot = 到着位置と角度のテーブル
--  duration = 到着までの秒数
function timeline_object(object, posrot, duration)
	slidemove(object, posrot[1], posrot[2], posrot[3], duration)
	turn(object, posrot[4], posrot[5], posrot[6], duration)
end


-- オブジェクトの座標設定
-- object = コントローラID
-- pos 座標の配列
function set_pos(object, pos)
	object.SetPos(pos[1], pos[2], pos[3])
end


-- オブジェクトの座標設定
-- object = コントローラID
-- rot 角度の配列
function set_rot(object, rot)
	object.SetRot(rot[1], rot[2], rot[3])
end


-- オブジェクトのスケール設定
-- scale スケールの配列
function set_scale(object, scale)
	object.SetScale(scale[1], scale[2], scale[3])
end

-- オブジェクトの座標設定
-- object = コントローラID
-- posrot 座標と角度の配列
function set_posrot(object, posrot)
	object.SetPos(posrot[1], posrot[2], posrot[3])
	object.SetRot(posrot[4], posrot[5], posrot[6])
end


-- オブジェクトの表示・動作のON
--  object = コントローラID
function on_active(object)
	object.SetActive(true)
end

-- オブジェクトの表示・動作のOFF
--  object = コントローラID
function off_active(object)
	object.SetActive(false)
end

-- オブジェクトの表示・動作の状態を取得
function is_active(object)
	return object.IsActive()
end

-- オブジェクトの親オブジェクトを設定する
--  object = コントローラID
--  parent = 親のコントローラID
--  offsetX = ローカル位置X
--  offsetY = ローカル位置Y
--  offsetZ = ローカル位置Z
--  angleX = ローカル角度X
--  angleY = ローカル角度Y
--  angleZ = ローカル角度Z
function set_parent(object, parent, offsetX, offseY, offsetZ, angleX, angleY, angleZ)
	parent.SetBindObject(object)
	if type(offsetX) == "table" then
		object.SetOffsetPosition(offsetX[1], offsetX[2], offsetX[3])
		object.SetOffsetEulerAngles(offsetX[4], offsetX[5], offsetX[6])
	else
		object.SetOffsetPosition(offsetX, offseY, offsetZ)
		object.SetOffsetEulerAngles(angleX, angleY, angleZ)
	end
end

-- オブジェクトの破棄
--  object = コントローラID
function kill(object)
	object.RemoveInside()
	object = nil
end

-- オブジェクトの移動
--  object = コントローラID
--  posX = 到着位置X
--  posY = 到着位置Y
--  posZ = 到着位置Z
--  duration = 到着までの秒数
-- return 通知ID
function slidemove(object, posX, posY, posZ, duration)
	if type(posX) == "table" then
		if #posX == 3 then
			return object.Move( posX[1], posX[2], posX[3], posY, false)
		else
			return object.Move( posX[1], posX[2], posX[3], posX[4], false)
		end
	else
		return object.Move( posX, posY, posZ, duration, false)
	end
end

-- オブジェクトの移動
--  object = コントローラID
--  goalX = 到着位置X
--  goalY = 到着位置Y
--  goalZ = 到着位置Z
--  duration = 到着までの秒数
--  speedtype = esing 0:Linear 1:EaseIn 2:EaseOut 3:EaseInOut
-- return 通知ID
function slidemove2(object, goalX, goalY, goalZ, duration, speedtype)
	if type(goalX) == "table" then
		if #goalX == 3 then
			return object.SlideMove(goalX[1], goalX[2], goalX[3], goalY, goalZ)
		else
			return object.SlideMove(goalX[1], goalX[2], goalX[3], goalX[4], goalX[5])
		end
	else
		return object.SlideMove(goalX, goalY, goalZ, duration, speedtype)
	end
end


-- オブジェクトの曲線移動
--  object = コントローラID
--  posX1 = 通過位置X
--  posY1 = 通過位置Y
--  posZ1 = 通過位置Z
--  posX2 = 到着位置X
--  posY2 = 到着位置Y
--  posZ2 = 到着位置Z
--  duration = 到着までの秒数
--  speedtype = esing 0:Linear 1:EaseIn 2:EaseOut 3:EaseInOut
-- return 通知ID
function curvemove(object, posX1, posY1, posZ1, posX2, posY2, posZ2, duration, speedtype)

	if type(posX1) == "table" then
		if #posX1 == 3 then
			if type(posY1) == "table" then
				-- 別テーブル
				return object.CurveMove(posX1[1], posX1[2], posX1[3], posY1[1], posY1[2], posY1[3], posZ1, posX2)
			else
				-- 通過点のみテーブル
				return object.CurveMove(posX1[1], posX1[2], posX1[3], posY1, posZ1, posX2, posY2, posZ2)
			end
		else
			-- 全部テーブル
			if #posX1 == 6 then
				return object.CurveMove(posX1[1], posX1[2], posX1[3], posX1[4], posX1[5], posX1[6], posY1, posZ1)
			else
				return object.CurveMove(posX1[1], posX1[2], posX1[3], posX1[4], posX1[5], posX1[6], posX1[7], posX1[8])
			end
		end
	else

		if type(posX2) == "table" then
			-- 終点のみテーブル
			return object.CurveMove(posX1, posY1, posZ1, posX2[1], posX2[2], posX2[3], posY2, posZ2)
		else
			-- どちらもテーブルではない
			return object.CurveMove(posX1, posY1, posZ1, posX2, posY2, posZ2, duration, speedtype)
		end
	end
end

-- オブジェクトの円周移動
--  object = コントローラID
--  posX = 中心位置X
--  posY = 中心位置Y
--  posZ = 中心位置Z
--  angle = 移動角度
--  duration = 到着までの秒数
--  speedtype = esing 0:Linear 1:EaseIn 2:EaseOut 3:EaseInOut
-- return 通知ID
function circlemove(object, posX, posY, posZ, angle, duration, speedType)
	if type(posX) == "table" then
		if #posX == 3 then
			return object.CircleMove(posX[1], posX[2], posX[3], posY, posZ, angle)
		else
			return object.CircleMove(posX[1], posX[2], posX[3], posX[4], posX[5], posX[6])
		end
	else
		return object.CircleMove(posX, posY, posZ, angle, duration, speedType)
	end
end

-- オブジェクトの移動。Transformの値を変更
--  object = コントローラID
--  posX = 到着位置X
--  posY = 到着位置Y
--  posZ = 到着位置Z
--  duration = 到着までの秒数
-- return 通知ID
function localmove(object, posX, posY, posZ, duration)
	if type(posX) == "table" then
		if #posX == 3 then
			return object.TransMove( posX[1], posX[2], posX[3], posY)
		else
			return object.TransMove( posX[1], posX[2], posX[3], posX[4])
		end
	else
		return object.TransMove( posX, posY, posZ, duration)
	end
end

-- オブジェクトの移動（地面に沿う）
--  object = コントローラID
--  posX = 到着位置X
--  posY = 到着位置Y
--  posZ = 到着位置Z
--  duration = 到着までの秒数
--  navi = NaviMeshを使って地面の高さを取得する(仮)
-- return 通知ID
function groundmove(object, posX, posY, posZ, duration, navi)
	local function localfuncGroundMove(object, x, y, z, duration, navimesh)
		local usenavimesh
		if navimesh == nil then
			usenavimesh = false
		else
			usenavimesh = navimesh
		end
		return object.GroundMove( x, y, z, duration, usenavimesh)
	end
	
	if type(posX) == "table" then
		if #posX == 3 then
			return localfuncGroundMove(object, posX[1], posX[2], posX[3], posY, posZ)
		else
			return localfuncGroundMove(object, posX[1], posX[2], posX[3], posX[4], posY)
		end
	else
		return localfuncGroundMove(object, posX, posY, posZ, duration, navi)
	end
end

-- オブジェクトの位置を地面の高さに補正
-- object = コントローラID
function set_groundpos(object)
	object.SetGroundPos()
end

-- オブジェクトの回転
--  object = コントローラID
--  angX = 到着角度X
--  angY = 到着角度Y
--  angZ = 到着角度Z
--  duration = 到着までの秒数
-- return 通知ID
function turn(object, angX, angY, angZ, duration)
	if type(angX) == "table" then
		if #angX == 3 then
			return object.Rotate( angX[1], angX[2], angX[3], angY, false)
		else
			return object.Rotate( angX[1], angX[2], angX[3], angX[4], false)
		end
	else
		return object.Rotate( angX, angY, angZ, duration, false)
	end
end

-- オブジェクトの回転。Transformの値を変更
--  object = コントローラID
--  angX = 到着角度X
--  angY = 到着角度Y
--  angZ = 到着角度Z
--  duration = 到着までの秒数
-- return 通知ID
function localturn(object, angX, angY, angZ, duration)
	if type(angX) == "table" then
		if #angX == 3 then
			return object.TransRotate( angX[1], angX[2], angX[3], angY)
		else
			return object.TransRotate( angX[1], angX[2], angX[3], angX[4])
		end
	else
		return object.TransRotate( angX, angY, angZ, duration)
	end
end


-- オブジェクトの回転を指定方向に向くように
--  object = コントローラID
--  posX = 注視位置X
--  posY = 注視位置Y
--  posZ = 注視位置Z
--  duration = 到着までの秒数
-- return 通知ID
function turn_lookat_position(object, posX, posY, posZ, duration)
	if type(posX) == "table" then
		if #posX == 3 then
			return object.RotateLookAt( posX[1], posX[2], posX[3], posY, false)
		else
			return object.RotateLookAt( posX[1], posX[2], posX[3], posX[4], false)
		end

	else
		return object.RotateLookAt( posX, posY, posZ, duration, false)
	end
end

-- オブジェクトの回転を指定オブジェクトに向くように
--  object = コントローラID
--  target = 注視対象のコントローラID
--  duration = かかる秒数
-- return 通知ID
function turn_lookat(object, target, duration)
	return object.RotateLookAt( target, duration, false)
end

-- オブジェクトの親の指定
--  object = コントローラID
--  parent = 親のコントローラID
--  objectName = 親のアタッチ対象のオブジェクト名
function on_parent(object, parent, objectName, posX, posY, posZ, angX, angY, angZ)
	if type(posX) == "table" then
		object.SetParent(parent, { objectName }, posX[1], posX[2], posX[3], posX[4], posX[5], posX[6])
	else
		object.SetParent(parent, { objectName }, posX, posY, posZ, angX, angY, angZ)
	end
end

-- オブジェクトの親の解除
--  object = コントローラID
function off_parent(object)
	object.ResetParent()
end

-- オブジェクトのモーション再生
--  object = コントローラID
--  animationTag = 本体アニメーションのタグ
--  transitionDuration = 現在のアニメーションから遷移する秒数
--  playSpeed = 再生の速度倍率
--  isLoop = ループ再生するか
-- return 通知ID
function motion(object, animationTag, transitionDuration, playSpeed, isLoop)
	if type(transitionDuration) == "table" then
		return object.PlayAnimation(animationTag, transitionDuration[1], transitionDuration[2], playSpeed)
	else
		return object.PlayAnimation(animationTag, transitionDuration, playSpeed, isLoop)
	end
end

-- オブジェクトのモーション再生（In,Loop形式）
--  object = コントローラID
--  animationInTag = 本体Inアニメーションのタグ
--  animationLoopTag = 本体Loopアニメーションのタグ
--  transitionDuration = 現在のアニメーションから遷移する秒数
--  playSpeed = 再生の速度倍率
-- return 通知ID
function motion_inloop(object, animationInTag, animationLoopTag, transitionDuration, playSpeed)
	if type(transitionDuration) == "table" then
		return object.PlayAnimation(animationInTag, animationLoopTag, transitionDuration[1], 0.1, transitionDuration[2])
	else
	    return object.PlayAnimation(animationInTag, animationLoopTag, transitionDuration, 0.1, playSpeed)
	end
end

-- オブジェクトのモーション再生(AnimatorController
--  object = コントローラID
--  triggerName = 遷移したいステートへのトリガー名
function animator_motion(object, triggerName)
	if triggerName == "default" then
		object.SetDefaultTrigger()
		object.SetBeforeTriggerName(triggerName)
	else
		object.PlayAnimatorAnimation(triggerName)
	end
end

-- オブジェクトの回転（AnimationPackのIn,Loop形式）
--  object = コントローラID
--  animationInTag = 本体Inアニメーションのタグ
--  animationLoopTag = 本体Loopアニメーションのタグ
--  transitionDuration = 現在のアニメーションから遷移する秒数
--  playSpeed = 再生の速度倍率
-- return 通知ID
function animation_turn(object, animationInTag, animationLoopTag, transitionDuration, playSpeed, rotateAngle, duration)
	if type(transitionDuration) == "table" then
		return object.AnimationTurn(animationInTag, animationLoopTag, transitionDuration[1], 0.1, transitionDuration[2], playSpeed, rotateAngle)
	else
	    return object.AnimationTurn(animationInTag, animationLoopTag, transitionDuration, 0.1, playSpeed, rotateAngle, duration)
	end
end

-- オブジェクトの回転(AnimatorController
--  object = コントローラID
--  triggerName = 遷移したいステートへのトリガー名
--  rotateAngle = 回転角度
--  duration = 回転にかける時間
function animator_turn(object, triggerName, rotateAngle, duration)
	object.AnimatorTurn(triggerName, rotateAngle, duration)
end

--  AnimationPackとAnimatorControllerを呼び分けする、角度から右左、再生速度のデフォルト値を入力する
--  object = キャラクターID
--  animationLoopTag = アニメーションパック用の回転モーション後のループモーション（controllerの場合はnilで可
--  rotateAngle = 回転角度
function motion_turn(object, animationLoopTag, rotateAngle)
	-- trueならAnimation
	if object.IsPauseAnimation() then
		-- 右回り
		if rotateAngle > 0.0 then
			if rotateAngle > 90.0 then
				animation_turn(object, "Com_Std_180turn_right" , animationLoopTag, 0.3 , 1.0, rotateAngle, 1.3)
			else
				animation_turn(object, "Com_Std_90turn_right" , animationLoopTag, 0.3 , 1.0, rotateAngle, 0.6)
			end
		-- 左回り
		else
			if rotateAngle < -90.0 then
				animation_turn(object, "Com_Std_180turn_left" , animationLoopTag, 0.3 , 1.0, rotateAngle, 1.3)
			else
				animation_turn(object, "Com_Std_90turn_left" , animationLoopTag, 0.3 , 1.0, rotateAngle, 0.6)
			end
		end
	else
		-- 右回り
		if rotateAngle > 0.0 then
			if rotateAngle > 90.0 then
				animator_turn(object, "to 180Turn_Right", rotateAngle, 1.3)
			else
				animator_turn(object, "to 90Turn_Right",rotateAngle, 0.6)
			end
		-- 左回り
		else
			if rotateAngle < -90.0 then
				animator_turn(object, "to 180Turn_Left", rotateAngle, 1.3)
			else
				animator_turn(object, "to 90Turn_Left",rotateAngle, 0.6)
			end
		end
	end
end

-- デフォルトステートに遷移させるトリガーを立てる
--  object = コントローラID
function animator_default_motion(object)
	object.SetDefaultTrigger()
end

-- デフォルトステートに遷移させるトリガーを立てる
--  object = コントローラID
function animator_default_motion_if_need(object)
	if object.ExistsAnimator() and not object.IsPauseAnimation() then
		object.SetDefaultTrigger()
	end
end

-- 初期化時にセットしたデフォルトトリガーとは違うものに変えたいときに使用する
--  object = コントローラID
--  defaultTriggerName = セットしたいデフォルトトリガー名
function set_animator_default(object, defaultTriggerName)
	object.SetDefaultTriggerName(defaultTriggerName);
end

-- 頭部分だけのモーションを再生する
--  object = コントローラID
--  animationInTag = 本体Inアニメーションのタグ
--  animationLoopTag = 本体Loopアニメーションのタグ
--  transitionDuration = 現在のアニメーションから遷移する秒数
--  playSpeed = 再生の速度倍率
function play_head_motion(object, animationTag, transitionDuration, playSpeed, isLoop)
	object.PlayHeadMotion(animationTag, transitionDuration, playSpeed, isLoop)
end

-- 頭部分だけのモーションを停止する
--  object = コントローラID
function stop_head_motion(object)
	object.StopHeadMotion()
end

-- オブジェクトの特定部分の位置取得
--  object = コントローラID
--  partsObjectName = 子オブジェクトの名前
-- return 位置情報テーブル [1]:X座標, [2]:Y座標, [3]:Z座標
function get_parts_position(object, partsObjectName)
	return object.GetPartsPosition(partsObjectName)
end

-- オブジェクトの特定位置に表示するエフェクトを設定
--  object = コントローラID
--  partsObjectName = 出現させる場所の子オブジェクトの名前
--  effect = 表示させたいオブジェクト
--  offsetX = 表示位置の調整値X
--  offsetY = 表示位置の調整値Y
--  offsetZ = 表示位置の調整値Z
function effect_at_object(object, partsObjectName, effect, offsetX, offsetY, offsetZ)
	local emotion_position = get_parts_position(object, partsObjectName)
	if type(offsetX) == "table" then
		slidemove(effect, emotion_position[1] + offsetX[1], emotion_position[2] + offsetX[2], emotion_position[3] + offsetX[3], 0.0)
	else
		slidemove(effect, emotion_position[1] + offsetX, emotion_position[2] + offsetY, emotion_position[3] + offsetZ, 0.0)
	end
	effect.SetActive(true)
end

-- アニメーションイベント用のサウンド名を登録する
--  object = コントローラID
--  typeName = サウンドの種類（"Voice" , "SE" , 等）
--  tagName = アニメーションに埋め込んだイベントに書いてあるファイル名代わりのタグ名
--  soundName = wwiseで割り振ったサウンド名
function animation_event_sound(object, typeName, tagName, soundName)
	object.SetAnimationEventSound(typeName, tagName, soundName)
end

-- オブジェクトの回転をターゲットに向き続けるように指定
--  object = コントローラID
--  target = 向き続ける対象のコントローラID
--  inter = 補間値
function keep_turn_lookat(object, target, inter)
	if inter == nil then
		object.KeepTurnLookat(target, 0.1)
	else
		object.KeepTurnLookat(target, inter)
	end
end


-- オブジェクト現在の位置を取得
-- object = コントローラID
function get_pos(object)
	return object.GetPos()
end


-- オブジェクト現在の角度を取得
-- object = コントローラID
function get_rot(object)
	return object.GetRot()
end

-- 追尾周回
-- object = コントローラID
-- target = 追尾対象
-- angle = 周回する角度
-- durasion = 時間
-- speedType = 0:Linear 1:EaseIn 2:EaseOut 3:EaseInOut
function aroundmove(object, target, angle, duration, speedtype)
	if type(angle) == "table" then
		return object.AroundMove(target, angle[1], angle[2], angle[3])
	else
		return object.AroundMove(target, angle, duration, speedtype)
	end
end

--- オブジェクトについている名前を変更する
--- object コントローラID
--- name 名前
function set_object_name(object, name)
	object.SetBindObjectName(name)
end