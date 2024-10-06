-- 定数定義
DotDir_Up = 0
DotDir_Down = 1
DotDir_Left = 2
DotDir_Right = 3

DotAnim_Idle = 0
DotAnim_Squat = 1
DotAnim_Move = 2
DotAnim_Attack = 3
DotAnim_Magic = 4
DotAnim_Buff = 5
DotAnim_Damage = 6
DotAnim_Down = 7
DotAnim_Win = 8
DotAnim_AttackTui = 9
DotAnim_SkillDf = 10
DotAnim_SkillFf = 11
DotAnim_AdvP01 = 12
DotAnim_AdvP02 = 13


DotEffect_Head = 0
DotEffect_Body = 1
DotEffect_Bottom = 2
DotEffect_Weapon = 3

BattleTime_Day = 1
BattleTime_Sunset = 2
BattleTime_Night = 3
BattleTime_Eclipse = 4

BattleWeather_Shiny = 1
BattleWeather_Rainy = 2
BattleWeather_Snowy = 3
BattleWeather_Eclipse = 4
BattleWeather_Snowstorm = 5
BattleWeather_Cloudy = 7

-- 疑似バトルADVメイン処理
LuaPsBattleAdv = nil

-- 疑似バトルADV初期化＆マップ読み込み処理
-- mapname = 読み込むマップモデル名。
-- mapdata = 読み込むマップデータ名。YAML名
function init_psbattleadv(mapname, mapdata)
	-- バトルで使う各種Directorが入ったprefabを読み込む
	local signal = system.LoadPsBattleAdvObj("adv_psbattleadv", "PsBattleAdv")
	while signal.IsProccessing() do
		coroutine.yield()
	end
	-- マップ読み込み時にLuaPsBattleAdvクラスが返ってくる
	LuaPsBattleAdv = system.LoadBattleMap(mapname, mapdata)
	while LuaPsBattleAdv.IsProccessing() do
		coroutine.yield()
	end

	initialize_globalmenu_button()
end

-- マップの時間帯と天候を変更する
-- timeslot = 時間帯 BattleTime_Dayなど
-- weather = 天候 BattleWeather_Shinyなど
function change_time_and_weather(timeslot, weather)
	LuaPsBattleAdv.ChangeTimeAndWeather(timeslot, weather)
end

-- 敵キャラ配置予約
-- unitId = npc_unit.xlsmのID
-- x, y = グリッド位置
-- layer = レイヤー
-- return = 管理ID
function dot_reserve_enemy(unitId, x, y, layer)
	if layer == nil then
		layer = 0
	end
	
	return LuaPsBattleAdv.ReserveEnemy(unitId, x, y, layer)
	
end

-- 施設（オブジェクト）配置予約
-- facilityId = battle_facility.xlsmのID
-- x, y = グリッド位置
-- dir = 向き
-- groupId = グループID
-- defaultSwitch = 初期スイッチ状態
function dot_reserve_facility(facilityId, x, y, dir, groupId, defaultSwitch)
	return LuaPsBattleAdv.ReserveFacility(facilityId, x, y, dir, groupId, defaultSwitch)
end

-- プレイヤーキャラ配置予約
-- styleId = style.xlsmのID
-- x, y = グリッド位置
-- layer = レイヤー
-- return = 管理ID
function dot_reserve_ally(styleId, x, y, layer)
	if layer == nil then
		layer = 0
	end
	
	return LuaPsBattleAdv.ReserveAlly(styleId, x, y, layer)
end

-- プレイヤーキャラの武器セット
-- id = ドットキャラ生成時に返ってきたID
-- weaponId = weapon.xlsm のID
function dot_set_weapon(id, weaponId)
	LuaPsBattleAdv.SetWeapon(id, weaponId)
end

-- パーティクル読み込み予約。読み込めるのはcommonエフェクトだけです(content_effect3d_common_common)
-- fileName = パーティクルファイル名
function reserve_particle(fileName)
	LuaPsBattleAdv.ReserveParticle(fileName)
end

-- ロード予約したユニットを実際に配置する
-- この関数を呼ばないとユニット操作はできない
function setup_complete_unit()
	LuaPsBattleAdv.SetUpCompleteUnit()
	while LuaPsBattleAdv.IsProccessing() do
		coroutine.yield()
	end
end

-- ドットキャラのシルエットを表示するか
-- disp = trueなら表示。デフォルトはfalse
function dot_disp_silhouette(disp)
	LuaPsBattleAdv.DispSilhouette(disp)
end

-- カメラの注視点までの距離を変える
-- dist = 距離 5～50
-- duration = 時間
function change_camera_distance(dist, duration)
	if duration == nil then
		duration = 0.0
	end
	
	LuaPsBattleAdv.ChangeCameraDistance(dist, duration)
end


-- カメラの角度を変える
-- angle = 角度
-- duration = 時間
function change_camera_angle(angle, duration)
	if duration == nil then
		duration = 0.0
	end
	
	LuaPsBattleAdv.ChangeCameraAngle(angle, duration)
end

-- カメラの移動
-- x,y = グリッド位置
-- duration = 時間
function move_camera(x, y, duration)
	if duration == nil then
		duration = 0.0
	end
	
	LuaPsBattleAdv.MoveCamera(x, y, duration)
end

-- strength 幅 0.2くらい　大きすぎると動きません
-- count　回数
-- time 時間
function psbattle_shake_camera(strength,count,time)
	return LuaPsBattleAdv.ShakeCamera(strength,count,time)
end

function psbattle_wait_shake_camera(strength,count,time)
	local signal = LuaPsBattleAdv.ShakeCamera(strength,count,time)
    while signal.IsProccessing() do
        coroutine.yield()
    end
end

-- カメラが動作中か判定
-- -- return = trueなら動作中
function is_busy_camera()
	return LuaPsBattleAdv.isCameraBusy();
end

-- カメラ動作終了待ち
function wait_camera()
	while is_busy_camera() do
		coroutine.yield()
	end
end

-- ユニットの向き変更
-- id = 管理ID
-- dir = 向き
function dot_unit_dir(id, dir)
	LuaPsBattleAdv.ChangeUnitDir(id, dir)
end

-- 武器の表示
-- id = 管理ID
-- active = trueだと表示
function dot_disp_weapon(id, active)
	LuaPsBattleAdv.DispWeapon(id, active)
end

-- ユニットの表示
-- id = 管理ID
-- active = trueだと表示
-- duration = フェード時間
function dot_disp_unit(id, active, duration)
	if duration == nil then
		duration = 0.0
	end
	LuaPsBattleAdv.DispUnit(id, active, duration)
end

-- 施設（オブジェクト）の表示
-- id = 管理ID
-- active = trueだと表示
function dot_disp_facility(id, active)
	LuaPsBattleAdv.DispFacility(id, active)
end

-- ユニットをダブル状態にする
-- id = リーダーの管理ID
-- backId = 後衛の管理ID
function dot_double_unit(id, backId)
	LuaPsBattleAdv.DoubleUnit(id, backId)
end

-- ユニットのアニメーション変更
-- id = 管理ID
-- anim = アニメーション番号:DotAnim_Idle等
function dot_change_anim(id, anim)
	LuaPsBattleAdv.ChangeAnim(id, anim)
end

-- ユニットのアニメーション速度変更
-- id 管理ID
-- speed = アニメーション速度倍率。1.0が標準速度
function dot_change_animspeed(id, speed)
	LuaPsBattleAdv.ChangeAnimSpeed(id, speed)
end

-- ユニットのレイヤー順変更
-- id = 管理ID
-- layer = レイヤー順
function dot_change_layer(id, layer)
	LuaPsBattleAdv.ChangeLayer(id, layer)
end

-- ユニットの移動シーケンス
-- id = 管理ID
-- x,y = グリッド位置
-- speed = 速度倍率
function dot_move_unit_seq(id, x, y, speed)
	if speed == nil then
		speed = 1.0
	end
	LuaPsBattleAdv.MoveUnitSeq(id, x, y, speed)
end

-- ユニット死亡処理シーケンス
-- id = 管理ID
function dot_dying_unit_seq(id)
	LuaPsBattleAdv.DyingUnitSeq(id)
end

-- ユニット回避処理シーケンス
-- id = 管理ID
function dot_dodge_seq(id)
	LuaPsBattleAdv.DodgeUnitSeq(id)
end

-- 演出が実行中か判定
function is_playing_staging()
	return LuaPsBattleAdv.isPlayingStaging()
end

-- ユニットの移動シーケンス予約。パラレルシーケンス用
-- id = 管理ID
-- x,y = グリッド位置
-- speed = 速度倍率
function dot_reserve_move_unit_seq(id, x, y, speed)
	if speed == nil then
		speed = 1.0
	end
	LuaPsBattleAdv.ReserveMoveUnit(id, x, y, speed)
end

-- ユニットシーケンス同時実行。パラレルシーケンス移動実行
function exec_parallel_seq()
	LuaPsBattleAdv.ExecParallelSeq()
end

-- 指定グリッドにユニット配置。
-- id = 管理ID
-- x,y = グリッド位置
function dot_place_unit(id, x, y)
	LuaPsBattleAdv.PlaceUnit(id, x, y)
end

-- 指定ユニットをボード上から削除する
-- id = 管理ID
function dot_remove_unit(id)
	LuaPsBattleAdv.RemoveUnit(id)
end

-- ユニットの変更。ダブル状態のユニットを変更する場合は、変更後のユニットもダブルにしておいてください。
-- id = 変更対象のユニット
-- changeId = 変更後のユニット
-- duration = クロスフェードの時間
function dot_change_unit(id, changeId, duration)
	if duration == nil then
		duration = 0.0
	end
	
	LuaPsBattleAdv.ChangeUnit(id, changeId, duration)
end

-- 指定グリッドの3次元座標を取得する
-- x,y = グリッド位置
-- return = グリッドtransform座標
function get_grid_position(x, y)
	return LuaPsBattleAdv.GetGridPosition(x, y)
end

-- 指定グリッドでパーティクルを再生する
-- name = パーティクル名
-- x,y = グリッド位置
-- return = パーティクルのHashCode
function dot_play_particle_grid(name, x, y)
	return LuaPsBattleAdv.PlayParticleGrid(name, x, y)
end

-- 指定ユニット上でパーティクルを再生する
-- id = 管理ID
-- name = パーティクル名
-- locator = ユニットのパーティクル再生位置。DotEffect_Head等
-- dir = ユニットの向きをパーティクルに反映するか？trueなら反映する
-- return = パーティクルのHashCode
function dot_play_particle_unit(id, name, locator, dir)
	if dir == nil then
		dir = false
	end
	return LuaPsBattleAdv.PlayParticleUnit(id, name, locator, dir)
end

-- 指定ユニットのロケータ座標を取得する
-- id = 管理ID
-- locator = 取得するユニットのロケータ。DotEffect_Head等
-- return = ロケータの座標
function dot_get_unit_locator(id, locator)
	return LuaPsBattleAdv.GetUnitLocator(id, locator)
end

-- パーティクルを停止する
-- hashcode = パーティクル再生時に返ってきたHashCode
function dot_stop_particle(hashcode)
	LuaPsBattleAdv.StopParticle(hashcode)
end

-- パーティクルが再生中か判定
-- hashcode = パーティクル再生時に返ってきたHashCode
-- return = trueなら再生中
function is_playing_particle(hashcode)
	return LuaPsBattleAdv.isPlayingParticle(hashcode)
end

-- パーティクル再生終了を待つ
-- hashcode = パーティクル再生時に返ってきたHashCode
function wait_particle(hashcode)
	while is_playing_particle(hashcode) do
		coroutine.yield()
	end
end

-- ユニットの武器を変更する
-- id = 管理ID
-- index = 武器スロット番号。0から始まる
function dot_change_weapon(id, index)
	LuaPsBattleAdv.ChangeWeapon(id, index)
end

-- ユニットのアニメが再生中か判定
-- id = 管理ID
-- return = trueなら再生中。元々ループ設定のアニメはnormalizedTimeが1以下の時のみtrueとなる
function dot_is_playing_anim(id)
	return LuaPsBattleAdv.isPlayingAnim(id)
end

-- 現在装備中の武器で通常攻撃を行うシーケンス
-- id = 管理ID
-- targetid = 攻撃対象の管理ID
function dot_attack_seq(id, targetId)
	LuaPsBattleAdv.NormalAttackUnitSeq(id, targetId)
end

-- ユニットのダメージシーケンス
-- id = 管理ID
-- attackerId = 攻撃してきたユニットの管理ID。攻撃属性やエレメント参照用
-- critical = クリティカル時にはtrue
function dot_damage_seq(id, attackerId, critical)
	if attackerId == nil then
		attackerId = 0
	end
	if critical == nil then
		critical = false
	end
	LuaPsBattleAdv.DamageUnitSeq(id, attackerId, critical)
end

-- ユニットの回復シーケンス
-- id = 管理ID
function dot_healing_seq(id)
	LuaPsBattleAdv.HealingUnitSeq(id)
end

-- 施設（オブジェクト）の稼働シーケンス
-- groupId = 施設（オブジェクト）配置時に設定したグループID
function dot_facility_interact_seq(groupId)
	LuaPsBattleAdv.InteractFacility(groupId)
end

-- ユニットの高さ移動
-- id = 管理ID
-- height = 目標高さ
-- duration = 到着までの秒数。0を入れると瞬間移動となる
-- speedtype = esing 0:Linear 1:EaseIn 2:EaseOut 3:EaseInOut
-- return 通知シグナル
function dot_move_height(id, height, duration, speedtype)
	if speedtype == nil then
		speedtype = 0
	end
	return LuaPsBattleAdv.MoveUnitHeight(id, height, duration, speedtype)
end

-- 本来ユニットが居るべきグリッド高さを返す
-- id = 管理ID
-- x,y = グリッド位置
-- return ユニットが本来居るべき高さ
function dot_get_gridheight(id, x, y)
	if x == nil then
		x = -1
	end
	if y == nil then
		y = -1
	end
	return LuaPsBattleAdv.GetGridHeight(id, x, y)
end

-- ユニットのノックバック移動
-- id = 管理ID
-- x, y = グリッド位置
-- duration = 到着までの秒数
-- speedtype = esing 0:Linear 1:EaseIn 2:EaseOut 3:EaseInOut
-- return 通知シグナル
function dot_move_knockback(id, x, y, duration, speedtype)
	if speedtype == nil then
		speedtype = 0
	end
	return LuaPsBattleAdv.MoveUnitKnockBack(id, x, y, duration, speedtype)
end

-- ユニットの飛行移動
-- id = 管理ID
-- x, y = グリッド位置
-- height = 目標高さ
-- duration = 到着までの秒数
-- speedtype = esing 0:Linear 1:EaseIn 2:EaseOut 3:EaseInOut
-- return 通知シグナル
function dot_move_fly(id, x, y, height, duration, speedtype)
	if speedtype == nil then
		speedtype = 0
	end
	return LuaPsBattleAdv.MoveUnitFly(id, x, y, height, duration, speedtype)
end

-- ユニットの移動。コルーチンバージョン
-- id = 管理ID
-- x,y = グリッド位置
-- speed = 速度倍率
-- return 通知シグナル
function dot_move_unit(id, x, y, speed)
	if speed == nil then
		speed = 1.0
	end
	return LuaPsBattleAdv.MoveUnit(id, x, y, speed)
end

-- ユニットのダメージ処理。コルーチンバージョン
-- id = 管理ID
-- attackerId = 攻撃してきたユニットの管理ID。攻撃属性やエレメント参照用
-- critical = クリティカル時にはtrue
-- return 通知シグナル
function dot_damage(id, attackerId, critical)
	if attackerId == nil then
		attackerId = 0
	end
	if critical == nil then
		critical = false
	end
	return LuaPsBattleAdv.DamageUnit(id, attackerId, critical)
end

-- ユニット回避処理。コルーチンバージョン
-- id = 管理ID
-- return 通知シグナル
function dot_dodge(id)
	return LuaPsBattleAdv.DodgeUnit(id)
end

-- ユニット死亡処理。コルーチンバージョン
-- id = 管理ID
-- return 通知シグナル
function dot_dying_unit(id)
	return LuaPsBattleAdv.DyingUnit(id)
end

-- ユニットの回復処理。コルーチンバージョン
-- id = 管理ID
-- return 通知シグナル
function dot_healing(id)
	return LuaPsBattleAdv.HealingUnit(id)
end

-- 現在装備中の武器で通常攻撃を行う。コルーチンバージョン
-- id = 管理ID
-- targetid = 攻撃対象の管理ID
-- return 通知シグナル
function dot_attack(id, targetId)
	return LuaPsBattleAdv.NormalAttackUnit(id, targetId)
end

-- 現在装備中の武器で通常攻撃を行う。主に近接武器用。ターゲットのダメージアニメも含むコルーチンバージョン
-- id = 管理ID
-- targetid = 攻撃対象の管理ID
-- critical = クリティカル判定
-- delay = 攻撃アクションから何秒後にダメージアニメを再生するか
function dot_target_attack(id, targetId, critical, delay)
	if critical == nil then
		critical = false
	end
	if delay == nil then
		delay = 0.16
	end
	
	-- 攻撃シーケンス開始時にアニメーション再生待ちがあるので、タイミング合わせのためにここで待っておく
	coroutine.yield()
	while true == dot_is_playing_anim(id) do
		coroutine.yield()
	end
	
	
	local sig1
	local sig2
	sig1 = LuaPsBattleAdv.NormalAttackUnit(id, targetId)
	wait_time(delay)
	sig2 = LuaPsBattleAdv.DamageUnit(targetId, id, critical)
	wait_proccess(sig1)
	wait_proccess(sig2)
end

-- 演出（シーケンス）動作終了待ち
function wait_seq()
	while is_playing_staging() do
		coroutine.yield()
	end
end

