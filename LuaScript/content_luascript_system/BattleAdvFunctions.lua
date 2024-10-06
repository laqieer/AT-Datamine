--
-- バトルフィールドADV用関数群
--
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

-- バトルフィールドADV用管理クラス
LuaBattleAdv = system.CreateBattleAdv()


function battleAdvDebugPrint()
	LuaBattleAdv.debugPrint()
end

-- マップの時間帯と天候を変更する
-- timeslot = 時間帯 BattleTime_Dayなど
-- weather = 天候 BattleWeather_Shinyなど
function change_time_and_weather(timeslot, weather)
	LuaBattleAdv.ChangeTimeAndWeather(timeslot, weather)
end

-- カメラの注視点までの距離を変える
-- dist = 距離 5～50
-- duration = 時間
function change_camera_distance(dist, duration)
	if duration == nil then
		duration = 0.0
	end
	
	LuaBattleAdv.ChangeCameraDistance(dist, duration)
end


-- カメラの角度を変える
-- angle = 角度
-- duration = 時間
function change_camera_angle(angle, duration)
	if duration == nil then
		duration = 0.0
	end
	
	LuaBattleAdv.ChangeCameraAngle(angle, duration)
end

-- カメラの移動
-- x,y = グリッド位置
-- duration = 時間
function move_camera(x, y, duration)
	if duration == nil then
		duration = 0.0
	end
	
	LuaBattleAdv.MoveCamera(x, y, duration)
end

-- カメラが動作中か判定
-- -- return = trueなら動作中
function is_busy_camera()
	return LuaBattleAdv.isCameraBusy();
end

-- カメラ動作終了待ち
function wait_camera()
	while is_busy_camera() do
		coroutine.yield()
	end
end


-- ユニットの向き変更
-- id = 管理ID
-- direction = 向き
function dot_unit_dir(id, direction)
	LuaBattleAdv.ChangeUnitDir(id, direction)
end

-- 武器の表示
-- id = 管理ID
-- active = trueだと表示
function dot_disp_weapon(id, active)
	LuaBattleAdv.DispWeapon(id, active)
end

-- ユニットの表示
-- id = 管理ID
-- active = trueだと表示
function dot_disp_unit(id, active)
	LuaBattleAdv.DispUnit(id, active)
end


-- ユニットのアニメーション変更
-- id = 管理ID
-- animation = アニメーション番号:DotAnim_Idle等
function dot_change_anim(id, animation)
	LuaBattleAdv.ChangeAnim(id, animation)
end


-- ユニットの移動シーケンス
-- id = 管理ID
-- x,y = グリッド位置
function dot_move_unit_seq(id, x, y)
	LuaBattleAdv.MoveUnit(id, x, y)
end

-- ユニット死亡処理シーケンス
-- id = 管理ID
function dot_dying_unit_seq(id)
	LuaBattleAdv.DyingUnit(id)
end

-- ユニットをダブル状態にする
-- id = リーダーの管理ID
-- backId = 後衛の管理ID
function dot_double_unit(id, backId)
	LuaBattleAdv.DoubleUnit(id, backId)
end

-- ユニットのレイヤー順変更
-- id = 管理ID
-- layer = レイヤー順
function dot_change_layer(id, layer)
	LuaBattleAdv.ChangeLayer(id, layer)
end

-- ユニット回避処理シーケンス
-- id = 管理ID
function dot_dodge_seq(id)
	LuaBattleAdv.DodgeUnit(id)
end

-- 現在装備中の武器で通常攻撃を行うシーケンス
-- id = 管理ID
-- targetId = 攻撃対象の管理ID
function dot_attack_seq(id, targetId)
	LuaBattleAdv.NormalAttackUnit(id, targetId)
end

-- ユニットのダメージシーケンス
-- id = 管理ID
-- attackerId = 攻撃してきたユニットの管理ID。攻撃属性やエレメント参照用
-- damage = ダメージ量
-- critical = クリティカル時にはtrue
function dot_damage_seq(id, attackerId, damage, critical)
	if attackerId == nil then
		attackerId = 0
	end
	if critical == nil then
		critical = false
	end
	LuaBattleAdv.DamageUnit(id, attackerId, damage, critical)
end

-- ユニットの回復シーケンス
-- id = 管理ID
function dot_healing_seq(id, heal)
	LuaBattleAdv.HealingUnit(id, heal)
end

-- ユニットのアニメが再生中か判定
-- id = 管理ID
-- return = trueなら再生中。元々ループ設定のアニメはnormalizedTimeが1以下の時のみtrueとなる
function dot_is_playing_anim(id)
	return LuaBattleAdv.isPlayingAnim(id)
end

-- 演出が実行中か判定
function is_playing_staging()
	return LuaBattleAdv.isPlayingStaging()
end

-- ユニットの移動シーケンス予約。パラレルシーケンス用
-- id = 管理ID
-- x,y = グリッド位置
function dot_reserve_move_unit_seq(id, x, y)
	LuaBattleAdv.ReserveMoveUnit(id, x, y)
end

-- ユニットシーケンス同時実行。パラレルシーケンス移動実行
function exec_parallel_seq()
	LuaBattleAdv.ExecParallelSeq()
end

-- 演出（シーケンス）動作終了待ち
function wait_seq()
	while is_playing_staging() do
		coroutine.yield()
	end
end

-- パーティクル読み込み予約。読み込めるのはcommonエフェクトだけです(content_effect3d_common_common)
-- fileName = パーティクルファイル名
function reserve_particle(fileName)
	LuaBattleAdv.ReserveParticle(fileName)
end

-- パーティクル読み込み予約のロード処理
function battle_adv_load_particle()
	LuaBattleAdv.LoadParticle()
	while LuaBattleAdv.IsLoadingParticle() do
		coroutine.yield()
	end
end

-- 指定グリッドでパーティクルを再生する
-- name = パーティクル名
-- x,y = グリッド位置
-- return = パーティクルのHashCode
function dot_play_particle_grid(name, x, y)
	return LuaBattleAdv.PlayParticleGrid(name, x, y)
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
	return LuaBattleAdv.PlayParticleUnit(id, name, locator, dir)
end

-- パーティクルを停止する
-- hashcode = パーティクル再生時に返ってきたHashCode
function dot_stop_particle(hashcode)
	LuaBattleAdv.StopParticle(hashcode)
end

-- パーティクルが再生中か判定
-- hashcode = パーティクル再生時に返ってきたHashCode
-- return = trueなら再生中
function is_playing_particle(hashcode)
	return LuaBattleAdv.isPlayingParticle(hashcode)
end

-- パーティクル再生終了を待つ
-- hashcode = パーティクル再生時に返ってきたHashCode
function wait_particle(hashcode)
	while is_playing_particle(hashcode) do
		coroutine.yield()
	end
end

-- ユニットコマンド発行(待機)
-- id = ユニット管理ID
-- switch_double = スイッチダブルするか
function  unit_command_stay(id, switch_double)
	LuaBattleAdv.UnitCommandStay(id, switch_double)
end

-- ユニットコマンド発行(移動)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- switch_double = スイッチダブルするか
function  unit_command_move_only(id, move_to_x, move_to_y, switch_double)
	LuaBattleAdv.UnitCommandMoveOnly(id, move_to_x, move_to_y, switch_double)
end

-- ユニットコマンド発行(スキル)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- target_to_x, target_to_y = スキル使用先グリッド座標
-- skill_idx = 使用スキル番号(「0」で装備武器の通常攻撃)
-- switch_double = スイッチダブルするか
function  unit_command_skill(id, move_to_x, move_to_y, target_to_x, target_to_y, skill_idx, switch_double)
	LuaBattleAdv.UnitCommandSkill(id, move_to_x, move_to_y, target_to_x, target_to_y, skill_idx, switch_double)
end

-- ユニットコマンド発行(ダブル)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- target_to_x, target_to_y = 対象ユニットグリッド座標
function  unit_command_double(id, move_to_x, move_to_y, target_to_x, target_to_y)
	LuaBattleAdv.UnitCommandDouble(id, move_to_x, move_to_y, target_to_x, target_to_y)
end

-- ユニットコマンド発行(ダブル解除)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- target_to_x, target_to_y = 解除先グリッド座標
-- switch_double = スイッチダブルするか
function  unit_command_release_double(id, move_to_x, move_to_y, target_to_x, target_to_y, switch_double)
	LuaBattleAdv.UnitCommandReleaseDouble(id, move_to_x, move_to_y, target_to_x, target_to_y, switch_double)
end


-- 手動操作ユニットコマンド発行(スキル)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- target_to_x, target_to_y = スキル使用先グリッド座標
-- skill_idx = 使用スキル番号(「0」で装備武器の通常攻撃)
function  manual_command_skill(id, move_to_x, move_to_y, target_to_x, target_to_y, skill_idx)
	LuaBattleAdv.SettingManualCommandSkill(id, move_to_x, move_to_y, target_to_x, target_to_y, skill_idx)
end

-- 手動操作ユニットコマンド発行(移動)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- target_to_x, target_to_y = スキル使用先グリッド座標
-- skill_idx = 使用スキル番号(「0」で装備武器の通常攻撃)
function  manual_command_move(id, move_to_x, move_to_y)
	LuaBattleAdv.SettingManualCommandMoveOnly(id, move_to_x, move_to_y)
end

-- ユニットコマンド発行(ダブル)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- target_to_x, target_to_y = 対象ユニットグリッド座標
function  manual_command_double(id, move_to_x, move_to_y, target_to_x, target_to_y)
	LuaBattleAdv.SettingManualCommandDouble(id, move_to_x, move_to_y, target_to_x, target_to_y)
end

-- ユニットコマンド発行(ダブル解除)
-- id = ユニット管理ID
-- move_to_x, move_to_y = 移動先グリッド座標
-- target_to_x, target_to_y = 解除先グリッド座標
function  manual_command_release_double(id, move_to_x, move_to_y, target_to_x, target_to_y)
	LuaBattleAdv.SettingManualReleaseDouble(id, move_to_x, move_to_y, target_to_x, target_to_y)
end

-- 武器交換コマンド発行
-- id = ユニット管理ID
function  manual_command_swap_weapon(id, weaponIndex)
	LuaBattleAdv.SettingManualSwapWeapon(id, weaponIndex)
end


-- 増援の呼び出し
-- player_id = 増援を呼び出すプレイヤーのID
-- troop_id= 呼び出す増援の所属ID
-- 指定値はマスターデータなどの設定に依存するのでバトル側のマスター定義をご確認ください
function  sortie_troops(player_id, troop_id)
	LuaBattleAdv.SortieTroops(player_id, troop_id)
end

