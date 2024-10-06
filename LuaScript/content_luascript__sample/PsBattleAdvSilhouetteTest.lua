Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		-- 疑似バトルADVの時はIncludeする

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	-- 初期化とマップ読み込みを行う
	init_psbattleadv("201010000", "201010000")
	
	-- 時間帯と天候の設定
	change_time_and_weather(BattleTime_Day, BattleWeather_Shiny)
	
	
	-- プレイヤーキャラ予約
	dotnoir = dot_reserve_ally(101009001, 10, 23, 0)
	
	-- プレイヤーキャラの武器データは必ずセットしなければならない
	dot_set_weapon(dotnoir, 101010001)		-- ロングソード
	dot_set_weapon(dotnoir, 105010001)		-- ウッドボウ
	
	-- ティルフィング
	dottyr = dot_reserve_ally(101001001, 13, 26, 0)
	dot_set_weapon(dottyr, 107010001)		-- 魔導書【初級】
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()
	
	-- カメラテスト
	change_camera_distance(10.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(12, 25, 0.0)
	
end

-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	
	open_narration_window()
	message_direct("疑似バトルADVシルエット表示テスト")
	close_narration_window()
	
	while true do
		open_select_window_direct(nil, "Normal", "シルエット表示ON", "シルエット表示OFF",  "終了")
		if is_select(1) then
			dot_disp_silhouette(true)
			wait_time(1.0)
		elseif is_select(2) then
			dot_disp_silhouette(false)
			wait_time(1.0)
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
