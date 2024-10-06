Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		-- 疑似バトルADVの時はIncludeする

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	-- 初期化とマップ読み込みを行う
	init_psbattleadv("201010000", "201010000")
	
	-- 時間帯と天候の設定
	change_time_and_weather(BattleTime_Day, BattleWeather_Shiny)
	
	-- 現在の時間帯と天候を保存しておく
	currentTimeSlot = BattleTime_Day
	currentWeather = BattleWeather_Shiny
	
	-- プレイヤーキャラ予約
	dotnoir = dot_reserve_ally(101009001, 10, 21, 0)
	
	-- プレイヤーキャラの武器データは必ずセットしなければならない
	dot_set_weapon(dotnoir, 101010001)		-- ロングソード
	dot_set_weapon(dotnoir, 105010001)		-- ウッドボウ
	
	-- 武器構えテスト用ノワール
	dotnoir2 = dot_reserve_ally(101009001, 9, 20, 0)
	dot_set_weapon(dotnoir2, 101010001)		-- ロングソード
	
	-- ティルフィング
	dottyr = dot_reserve_ally(101001001, 16, 21, 0)
	dot_set_weapon(dottyr, 107010001)		-- 魔導書【初級】
	
	-- ラグネル
	dotrag = dot_reserve_ally(101018001, 13, 24, 0)
	dot_set_weapon(dotrag, 106010001)	-- ハンドガン
	
	-- ギネヴィア
	dotguine = dot_reserve_ally(101011001, 11, 24, 0)
	dot_set_weapon(dotguine, 104010001)	-- スピア
	
	-- ディナタン
	dotdina = dot_reserve_ally(101012001, 20, 5, 0)
	dot_set_weapon(dotdina, 108010001)	-- 木の杖
	
	-- ギネマウア
	dotmau = dot_reserve_ally(101016001, 12, 19, 0)
	dot_set_weapon(dotmau, 108010001)	-- 木の杖
	
	-- ギネヴィア・キラーズ。ユニット差し替え用
	dotguine_k = dot_reserve_ally(101011002, 0, 0, 0)
	dot_set_weapon(dotguine_k, 104010001)	-- スピア
	
	-- ディナタン・キラーズ。ユニット差し替え用
	dotdina_k = dot_reserve_ally(101012002, 0, 1, 0)
	dot_set_weapon(dotdina_k, 108010001)	-- 木の杖
	
	-- 置き換え用適当ユニット
	changeunit = dot_reserve_enemy(1, 14, 25, 0)
	soldier = dot_reserve_ally(401038001, 0, 2, 0)
	dot_set_weapon(soldier, 101010001)		-- ロングソード
	
	-- 敵配置予約
	barbaroi = dot_reserve_enemy(506, 13, 21, 15)
	--barbaroi = dot_reserve_enemy(56, 13, 21, 15)
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()
	
	-- ノワール武器構え変更テスト
	dot_change_anim(dotnoir2, DotAnim_AdvP01)
	
	-- ギネヴィアとディナタンでダブルを組む
	dot_double_unit(dotguine, dotdina)
	dot_unit_dir(dotguine, DotDir_Left)
	
	-- 置き換え用ギネヴィアとディナタンもダブルを組んでおく
	dot_double_unit(dotguine_k, dotdina_k)
	
	-- 置き換え用ユニットは非表示にしておく
	dot_disp_unit(dotguine_k, false)
	dot_disp_unit(dotdina_k, false)
	
	dot_unit_dir(dotnoir, DotDir_Left)
	
	-- 置き換え用バルバロイアニメ変更
	dot_change_anim(changeunit, DotAnim_Squat)
	
	-- 置き換え用ユニットは非表示にしておく
	dot_disp_unit(soldier, false)
	
	-- カメラテスト
	change_camera_distance(10.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(13, 21, 0.0)
	
	-- ADV用パーティクルテスト
	-- Ef_Smoke = load_particle("content_effect3d_common_adv", "Ef_NM_Smoke01", true, true)
end

-- 時間帯変更
function TimeChangeTest()
	open_select_window_direct(nil, "Normal", "昼", "夕方", "夜", "淘汰")
	if is_select(1) then
		change_time_and_weather(BattleTime_Day, currentWeather)
		currentTimeSlot = BattleTime_Day
	elseif is_select(2) then
		change_time_and_weather(BattleTime_Sunset, currentWeather)
		currentTimeSlot = BattleTime_Sunset
	elseif is_select(3) then
		change_time_and_weather(BattleTime_Night, currentWeather)
		currentTimeSlot = BattleTime_Night
	elseif is_select(4) then
		change_time_and_weather(BattleTime_Eclipse, BattleWeather_Eclipse)
	end
end

-- 天候変更
function WeatherChangeTest()
	open_select_window_direct(nil, "Normal", "晴", "雨", "雪", "淘汰", "吹雪")
	if is_select(1) then
		change_time_and_weather(currentTimeSlot, BattleWeather_Shiny)
		currentWeather = BattleWeather_Shiny
	elseif is_select(2) then
		change_time_and_weather(currentTimeSlot, BattleWeather_Rainy)
		currentWeather = BattleWeather_Rainy
	elseif is_select(3) then
		change_time_and_weather(currentTimeSlot, BattleWeather_Snowy)
		currentWeather = BattleWeather_Snowy
	elseif is_select(4) then
		change_time_and_weather(BattleTime_Eclipse, BattleWeather_Eclipse)
	elseif is_select(5) then
		change_time_and_weather(currentTimeSlot, BattleWeather_Snowstorm)
		currentWeather = BattleWeather_Snowstorm
	end
end

-- 時間帯と天候変更テスト
-- どんな時間帯と天候設定が用意されているかは、BGSceneEffectSettingsAsset を参照してください。
function TimeAndWeatherTest()
	while true do
		open_select_window_direct(nil, "Normal", "時間帯変更", "天候変更", "戻る")
		if is_select(1) then
			TimeChangeTest()
		elseif is_select(2) then
			WeatherChangeTest()
		elseif is_select(3) then
			break
		else
			break
		end
	end
end

-- 攻撃シーケンステスト
function AttackSeqTest()
	--[[ ADV用パーティクルテスト
	local gridpos = get_grid_position(10, 21)
	set_pos(Ef_Smoke, gridpos)
	play_particle(Ef_Smoke)
	]]
	
	-- local hash = dot_play_particle_grid("Ef_C_Cmn_Aura_SS01", 10, 21)
	
	dot_change_weapon(dotnoir, 1)				-- ノワールの武器をウッドボウに変更
	dot_attack_seq(dotnoir, barbaroi)			-- ウッドボウで攻撃
	dot_damage_seq(barbaroi, dotnoir, false)	-- ダメージ演出
	wait_seq()									-- 演出が終わるのを待つ
	dot_change_weapon(dotnoir, 0)				-- ノワールの武器をロングソードに変更
	dot_move_unit_seq(dotnoir, 12, 21)			-- バルバロイに接近移動
	dot_attack_seq(dotnoir, barbaroi)			-- ロングソードで攻撃
	dot_damage_seq(barbaroi, dotnoir, false)	-- ダメージ演出
	--dot_attack_seq(dottyr, barbaroi)			-- 魔導書による攻撃
	--dot_damage_seq(barbaroi, dottyr, false)
	dot_attack_seq(dotrag, barbaroi)			-- 銃による攻撃
	--dot_dodge_seq(barbaroi)
	dot_damage_seq(barbaroi, dotrag, false)
	wait_seq()									-- シーケンス終了を待つ
	
	dot_change_anim(dotnoir, DotAnim_Idle)		-- 攻撃が一通り終わったので、各ユニットをアイドル状態に戻す
	dot_change_anim(dottyr, DotAnim_Idle)
	dot_change_anim(dotrag, DotAnim_Idle)
	
	dot_reserve_move_unit_seq(dotnoir, 10, 21)
	
	-- ダブルユニットの移動テスト
	if changeunitflag == false then		-- ユニットが変更されてるかチェック
		dot_reserve_move_unit_seq(dotguine, 12, 21)
		exec_parallel_seq()
		dot_attack_seq(dotguine, barbaroi)	-- ダブル状態だと前衛ユニットしか攻撃できません
		dot_damage_seq(barbaroi, dotguine, false)
		wait_seq()
		dot_change_anim(dotguine, DotAnim_Idle)	-- 攻撃が終わったらアイドル状態に戻す
		dot_move_unit_seq(dotguine, 11, 24)
	else
		dot_reserve_move_unit_seq(dotguine_k, 12, 21)
		exec_parallel_seq()
		dot_attack_seq(dotguine_k, barbaroi)
		dot_damage_seq(barbaroi, dotguine_k, false)
		wait_seq()
		dot_change_anim(dotguine_k, DotAnim_Idle)	-- 攻撃が終わったらアイドル状態に戻す
		dot_move_unit_seq(dotguine_k, 11, 24)
	end
	
	--dot_attack_seq(dotmau, dotnoir)				-- 杖は攻撃シーケンスが回復になってます
	--dot_healing_seq(dotnoir)					-- 回復シーケンス
	--wait_seq()
	dot_change_anim(dotmau, DotAnim_Idle)

end

-- 攻撃シーケンステスト2。シーケンスを使わずコルーチンで処理する
function AttackSeqTest2()
	--[[ ADV用パーティクルテスト
	local gridpos = get_grid_position(10, 21)
	set_pos(Ef_Smoke, gridpos)
	play_particle(Ef_Smoke)
	]]
	
	local barsig
	local noirsig
	local tyrsig
	local guinesig
	local ragsig
	local mausig
	
	-- local hash = dot_play_particle_grid("Ef_C_Cmn_Aura_SS01", 10, 21)
	
	dot_change_weapon(dotnoir, 1)				-- ノワールの武器をウッドボウに変更
	noirsig = dot_attack(dotnoir, barbaroi)			-- ウッドボウで攻撃
	wait_proccess(noirsig)
	barsig = dot_damage(barbaroi, dotnoir, false)	-- ダメージ演出
	wait_proccess(noirsig)
	dot_change_weapon(dotnoir, 0)				-- ノワールの武器をロングソードに変更
	noirsig = dot_move_unit(dotnoir, 12, 21)			-- バルバロイに接近移動
	wait_proccess(noirsig)
	dot_target_attack(dotnoir, barbaroi)			-- ロングソードで攻撃
	--tyrsig = dot_attack(dottyr, barbaroi)			-- 魔導書による攻撃
	--wait_proccess(tyrsig)
	--barsig = dot_damage(barbaroi, dottyr, false)
	--wait_proccess(barsig)
	ragsig = dot_attack(dotrag, barbaroi)			-- 銃による攻撃
	wait_proccess(ragsig)
	--barsig = dot_dodge(barbaroi)
	barsig = dot_damage(barbaroi, dotrag, false)
	wait_proccess(barsig)
	
	dot_change_anim(dotnoir, DotAnim_Idle)		-- 攻撃が一通り終わったので、各ユニットをアイドル状態に戻す
	dot_change_anim(dottyr, DotAnim_Idle)
	dot_change_anim(dotrag, DotAnim_Idle)
	
	noirsig = dot_move_unit(dotnoir, 10, 21)
	
	-- ダブルユニットの移動テスト
	if changeunitflag == false then		-- ユニットが変更されてるかチェック
		guinesig = dot_move_unit(dotguine, 12, 21)
		wait_proccess(guinesig)
		dot_target_attack(dotguine, barbaroi)	-- ダブル状態だと前衛ユニットしか攻撃できません
		dot_change_anim(dotguine, DotAnim_Idle)	-- 攻撃が終わったらアイドル状態に戻す
		guinesig = dot_move_unit(dotguine, 11, 24)
	else
		guinesig = dot_move_unit(dotguine_k, 12, 21)
		wait_proccess(guinesig)
		dot_target_attack(dotguine_k, barbaroi)
		wait_proccess(barsig)
		
		dot_change_anim(dotguine_k, DotAnim_Idle)	-- 攻撃が終わったらアイドル状態に戻す
		guinesig = dot_move_unit(dotguine_k, 11, 24)
	end
	
	--mausig = dot_attack(dotmau, dotnoir)				-- 杖は攻撃シーケンスが回復になってます
	--wait_proccess(noirsig)
	--wait_proccess(mausig)
	--noirsig = dot_healing(dotnoir)					-- 回復シーケンス
	--wait_proccess(noirsig)
	dot_change_anim(dotmau, DotAnim_Idle)

end



-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	changeunitflag = false		-- ユニット変更フラグ
	
	open_narration_window()
	message_direct("疑似バトルADVテスト")
	close_narration_window()
	
	while true do
		open_select_window_direct(nil, "Normal", "時間帯天候変更テスト", "ユニット変更テスト", "攻撃シーケンステスト", "攻撃シーケンステスト2", "終了")
		if is_select(1) then
			TimeAndWeatherTest()
		elseif is_select(2) then
			if changeunitflag == false then
				dot_change_unit(dotguine, dotguine_k, 0.0)	-- ギネヴィア置き換え。ダブル状態なのでディナタンも置き換わる
				dot_change_unit(changeunit, soldier, 0.0)	-- バルバロイ置き換え。アニメーション引き継ぎチェック用
				changeunitflag = true
			else
				dot_change_unit(dotguine_k, dotguine, 0.0)	-- ギネヴィア置き換え。ダブル状態なのでディナタンも置き換わる
				dot_change_unit(soldier, changeunit, 0.0)	-- バルバロイ置き換え。アニメーション引き継ぎチェック用
				changeunitflag = false
			end
		elseif is_select(3) then
			AttackSeqTest()
		elseif is_select(4) then
			AttackSeqTest2()
		else
			break
		end
	end
	
	open_narration_window()
	message_direct("終了します")
	close_narration_window()
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	currentTimeSlot = BattleTime_Day
	currentWeather = BattleWeather_Shiny
end
