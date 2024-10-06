Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		-- 疑似バトルADVの時はIncludeする

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	-- 初期化とマップ読み込みを行う
	init_psbattleadv("201030000", "201030000")
	
	-- 時間帯と天候の設定
	change_time_and_weather(BattleTime_Day, BattleWeather_Shiny)
	
	-- プレイヤーキャラ予約
	dotnoir = dot_reserve_ally(101009001, 14, 5, 0)
	
	-- プレイヤーキャラの武器データは必ずセットしなければならない
	dot_set_weapon(dotnoir, 101010001)		-- ロングソード
	dot_set_weapon(dotnoir, 105010001)		-- ウッドボウ
	
	-- ティルフィング
	dottyr = dot_reserve_ally(101001002, 14, 6, 0)
	--dot_set_weapon(dottyr, 101010005)		-- キラーブレイド
	dot_set_weapon(dottyr, 101010001)		-- ロングソード
	--dot_set_weapon(dottyr, 107010004)		-- 「禁書」金獅子
	
	
	-- 敵配置予約
	barbaroi = dot_reserve_enemy(3, 14, 8, 0)
	
	griffin = dot_reserve_enemy(100033, 14, 10, 0)
	
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()
	
	dot_unit_dir(griffin, DotDir_Right)
	dot_unit_dir(barbaroi, DotDir_Right)
	dot_disp_weapon(dotnoir, true)
	dot_disp_weapon(dottyr, false)
	dot_disp_weapon(barbaroi, false)
	
	-- カメラテスト
	change_camera_distance(10.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(18, 8, 0.0)
end


-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	open_narration_window()
	message_direct("疑似バトルADV同時ユニット移動テスト")
	close_narration_window()
	
	while true do
		open_select_window_direct(nil, "Normal", "シーケンス移動(アニメ速度変更あり)", "コルーチン移動(アニメ速度変更あり)", "シーケンス移動(アニメ速度変更無し)", "コルーチン移動(アニメ速度変更無し)", "終了")
		
		if is_select(1) then
			-- 移動コマンドを予約
			dot_reserve_move_unit_seq(dotnoir, 23, 5, 1.5)
			dot_reserve_move_unit_seq(dottyr, 23, 6, 1.2)
			dot_reserve_move_unit_seq(barbaroi, 23, 8, 0.8)
			dot_reserve_move_unit_seq(griffin, 23, 9, 0.5)
			
			-- 移動速度に合わせてアニメーション速度変更
			dot_change_animspeed(dotnoir, 1.5)
			dot_change_animspeed(dottyr, 1.2)
			dot_change_animspeed(barbaroi, 0.8)
			dot_change_animspeed(griffin, 0.5)
			
			-- 一斉に移動開始
			exec_parallel_seq()
			
			-- シーケンス終了を待つ
			wait_seq()
			
		elseif is_select(2) then
			-- 移動速度に合わせてアニメーション速度変更
			dot_change_animspeed(dotnoir, 1.5)
			local signal1 = dot_move_unit(dotnoir, 23, 5, 1.5)
			dot_change_animspeed(dottyr, 1.2)
			local signal2 = dot_move_unit(dottyr, 23, 6, 1.2)
			dot_change_animspeed(barbaroi, 0.8)
			local signal3 = dot_move_unit(barbaroi, 23, 8, 0.8)
			dot_change_animspeed(griffin, 0.5)
			local signal4 = dot_move_unit(griffin, 23, 9, 0.5)
			
			wait_proccess(signal1)
			wait_proccess(signal2)
			wait_proccess(signal3)
			wait_proccess(signal4)
		elseif is_select(3) then
			-- 移動コマンドを予約
			dot_reserve_move_unit_seq(dotnoir, 23, 5, 1.5)
			dot_reserve_move_unit_seq(dottyr, 23, 6, 1.2)
			dot_reserve_move_unit_seq(barbaroi, 23, 8, 0.8)
			dot_reserve_move_unit_seq(griffin, 23, 9, 0.5)
			
			-- 一斉に移動開始
			exec_parallel_seq()
			
			-- シーケンス終了を待つ
			wait_seq()
			
		elseif is_select(4) then
			-- 移動コマンド指定
			local signal1 = dot_move_unit(dotnoir, 23, 5, 1.5)
			local signal2 = dot_move_unit(dottyr, 23, 6, 1.2)
			local signal3 = dot_move_unit(barbaroi, 23, 8, 0.8)
			local signal4 = dot_move_unit(griffin, 23, 9, 0.5)
			
			-- 各ユニットの移動終了を待つ
			wait_proccess(signal1)
			wait_proccess(signal2)
			wait_proccess(signal3)
			wait_proccess(signal4)
			
		else
			break
		end
		
		wait_time(1.0)
		
		-- 移動コマンドを予約
		dot_reserve_move_unit_seq(dotnoir, 14, 5)
		dot_reserve_move_unit_seq(dottyr, 14, 6)
		dot_reserve_move_unit_seq(barbaroi, 14, 8)
		dot_reserve_move_unit_seq(griffin, 14, 9)
		
		-- 一斉に移動開始
		exec_parallel_seq()
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
end
