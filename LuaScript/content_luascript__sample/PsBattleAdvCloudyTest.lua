Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		-- 疑似バトルADVの時はIncludeする

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	-- 初期化とマップ読み込みを行う
	init_psbattleadv("201000000", "201000000")
	
	-- プレイヤーキャラ予約
	dotnoir = dot_reserve_ally(101009001, 16, 16, 0)
	
	-- プレイヤーキャラの武器データは必ずセットしなければならない
	dot_set_weapon(dotnoir, 101010001)		-- ロングソード
	dot_set_weapon(dotnoir, 105010001)		-- ウッドボウ
	
	-- ティルフィング
	dottyr = dot_reserve_ally(101001002, 16, 17, 0)
	dot_set_weapon(dottyr, 101010005)		-- キラーブレイド
	--dot_set_weapon(dottyr, 107010004)		-- 「禁書」金獅子
	
	
	-- 敵配置予約
	barbaroi = dot_reserve_enemy(3, 18, 17, 0)
	
	griffin = dot_reserve_enemy(100033, 18, 18, 0)
	
	enemy3 = dot_reserve_enemy(27, 14, 15, 0)
	
	--enemy4 = dot_reserve_enemy(57, 15, 16, 0)
	
	--[[
	for i = 1, 5 do
		for j = 1 , 5 do
			dot_reserve_enemy(1, i+15, j+15, 0)
		end
	end
	]]
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()
	
	dot_unit_dir(barbaroi, DotDir_Left)
	dot_change_anim(barbaroi, DotAnim_Squat)
	
	--dot_disp_weapon(barbaroi, false)
	
	--dot_disp_unit(enemy3, false)
	
	-- カメラテスト
	change_camera_distance(10.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(16, 15, 0.0)
end



-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	open_narration_window()
	message_direct("疑似バトルADVテスト")
	close_narration_window()
	
	dot_dying_unit_seq(enemy3)
	
	while true do
		open_select_window_direct(nil, "Normal", "曇り", "雨", "終了")
		if is_select(1) then
			change_time_and_weather(BattleTime_Day, BattleWeather_Cloudy)
			wait_time(5.0)
		elseif is_select(2) then
			change_time_and_weather(BattleTime_Day, BattleWeather_Rainy)
			wait_time(5.0)
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
end
