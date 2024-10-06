Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		-- 疑似バトルADVの時はIncludeする
Include("content_luascript_common","DemoCommonPack")	-- 2D顔グラフィックを使用する際に置く

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	-- 初期化とマップ読み込みを行う
	init_psbattleadv("201000001", "201000001")

	-- 時間帯と天候の設定
	change_time_and_weather(BattleTime_Day, BattleWeather_Shiny)

	pbadv_setup_101021_Bruno(0,true, 8, 20, 0)  --ブルーノ
	pbadv_setup_101058_Laiens(0,true, 9, 20, 0)	-- ライエンス
	pbadv_setup_101042_Moronoe(true, 8, 23, 0)  --モーロノエー
	pbadv_setup_101018_Ragnar(1, true, 10, 19, 0)  --ラグネル
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()
	
	-- そのユニットが本来居るべき高さを取得。降下目標高さに使用
	land_y = dot_get_gridheight(dotMoronoe, 8, 23)
	
	dot_unit_dir(dotRagnar1, DotDir_Left)
	dot_unit_dir(dotLaiens,2)
	
	-- ユニットの初期高さを変える
	dot_move_height(dotLaiens, -0.14, 0)
	dot_move_height(dotMoronoe, 3.0, 0)
	dot_move_height(dotRagnar1, 5.0, 0)
	
	-- カメラ設定
	change_camera_distance(9.0, 0.0)
	change_camera_angle(40.0, 0.0)
	move_camera(8, 21, 0.0)
end


-- ユニットの高さ移動テスト
function moveHeightTest()
	while true do
		local signal
		open_select_window_direct(nil, "Normal", "Linear降下", "EaseIn降下", "EaseOut降下", "EaseInOut降下", "戻る")
		if is_select(1) then
			signal = dot_move_height(dotMoronoe, land_y, 2.0, 0)
			wait_proccess(signal)
		elseif is_select(2) then
			signal = dot_move_height(dotMoronoe, land_y, 2.0, 1)
			wait_proccess(signal)
		elseif is_select(3) then
			signal = dot_move_height(dotMoronoe, land_y, 2.0, 2)
			wait_proccess(signal)
		elseif is_select(4) then
			signal = dot_move_height(dotMoronoe, land_y, 2.0, 3)
			wait_proccess(signal)
		else
			return
		end
		
		dot_move_unit_seq(dotMoronoe, 7, 20)
		wait_seq()
		
		open_select_window_direct(nil, "Normal", "Linear上昇", "EaseIn上昇", "EaseOut上昇", "EaseInOut上昇", "戻る")
		
		-- 戻るを選んだら関数から抜ける
		if is_select(5) then
			return
		end
		
		dot_move_unit_seq(dotMoronoe, 8, 23)
		wait_seq()
		dot_unit_dir(dotMoronoe, 2)
		
		if is_select(1) then
			signal = dot_move_height(dotMoronoe, 3.0, 2.0, 0)
			wait_proccess(signal)
		elseif is_select(2) then
			signal = dot_move_height(dotMoronoe, 3.0, 2.0, 1)
			wait_proccess(signal)
		elseif is_select(3) then
			signal = dot_move_height(dotMoronoe, 3.0, 2.0, 2)
			wait_proccess(signal)
		elseif is_select(4) then
			signal = dot_move_height(dotMoronoe, 3.0, 2.0, 3)
			wait_proccess(signal)
		else
			return
		end
	end
	
end

-- ユニットのノックバック移動テスト
function moveKnockBackTest()
	while true do
		local signal
		open_select_window_direct(nil, "Normal", "LinearX6Y20移動", "EaseOutX6Y20移動", "LinearX6Y21移動", "EaseOutX6Y21移動", "戻る")
		
		-- 戻るを選んだら関数から抜ける
		if is_select(5) then
			return
		end
		
		dot_change_anim(dotLaiens, DotAnim_Attack)
		wait_time(0.15)
		dot_change_anim(dotBruno, DotAnim_Damage)
		
		if is_select(1) then
			signal = dot_move_knockback(dotBruno, 6, 20,  0.3, 0)
			wait_proccess(signal)
		elseif is_select(2) then
			signal = dot_move_knockback(dotBruno, 6, 20,  0.3, 2)
			wait_proccess(signal)
		elseif is_select(3) then
			signal = dot_move_knockback(dotBruno, 6, 21,  0.3, 0)
			wait_proccess(signal)
		elseif is_select(4) then
			signal = dot_move_knockback(dotBruno, 6, 21,  0.3, 2)
			wait_proccess(signal)
		else
			return
		end
		
		dot_change_anim(dotLaiens, DotAnim_Idle)
		dot_change_anim(dotBruno, DotAnim_Squat)
		wait_time(1.0)
		dot_move_unit_seq(dotBruno, 8, 20)
		wait_seq()
	end
end

-- 飛行移動テスト
function flyMoveTest()
	local signal
	open_select_window_direct(nil, "Normal", "LinearX5Y20に降下", "EaseOutX5Y20に降下", "LinearX6Y23に降下", "EaseOutX6Y23に降下", "戻る")
	
	dot_unit_dir(dotRagnar1, DotDir_Left)
	if is_select(1) then
		signal = dot_move_fly(dotRagnar1, 5, 20, 1.0,  2.0, 0)
		wait_proccess(signal)
	elseif is_select(2) then
		signal = dot_move_fly(dotRagnar1, 5, 20, 1.0,  2.0, 2)
		wait_proccess(signal)
	elseif is_select(3) then
		signal = dot_move_fly(dotRagnar1, 6, 23, 1.0,  2.0, 0)
		wait_proccess(signal)
	elseif is_select(4) then
		signal = dot_move_fly(dotRagnar1, 6, 23, 1.0,  2.0, 2)
		wait_proccess(signal)
	else
		return
	end
	dot_unit_dir(dotRagnar1, DotDir_Right)
	wait_time(1.0)
	
	signal = dot_move_fly(dotRagnar1, 10, 19, 5.0, 2.0, 1)
	
end

-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	open_narration_window()
	message_direct("疑似バトル特殊移動テスト")
	close_narration_window()
	
	while true do
		open_select_window_direct(nil, "Normal", "高さ移動テスト", "ノックバック移動テスト", "飛行移動テスト", "終了")
		if is_select(1) then
			moveHeightTest()
		elseif is_select(2) then
			moveKnockBackTest()
		elseif is_select(3) then
			flyMoveTest()
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
	pbadv_setup_101021_Bruno_preload(0,true, 8, 20, 0)
	pbadv_setup_101058_Laiens_preload(0,true, 9, 20, 0)
	pbadv_setup_101042_Moronoe_preload(true, 8, 23, 0)
	pbadv_setup_101018_Ragnar_preload(1, true, 10, 19, 0)
end
