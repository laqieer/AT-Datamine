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
	
	pbadv_setup_101010_Lancelot(0,true, 4, 22,0)  --ランスロット
	pbadv_setup_101011_Guinevere(0,true, 5, 22,0)  --ギネヴィア
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()
	
	--親密度アップ用セットアップ
	FriendshipUp = set_friendship_up(false)		-- ★親密度対応
	
	-- カメラテスト
	change_camera_distance(10.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(4, 21, 0.0)
end


-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	local trustParam = set_communication("ギネヴィア_コミュランク", "ギネヴィア_親密度")
	
	open_narration_window()
	message_direct("疑似バトルADV親密度アイコンテスト")
	close_narration_window()
	
	local cameramove = false
	
	-- アイコン表示位置の調整値。標準だと頭のロケータ位置＋Y座標0.4の位置に表示される
	--local g_offsetpos = {0.3, 0.0, 0}
	--local l_offsetpos = {0.3, 0.0, 0}
	local g_offsetpos = {0.0, 0.0, 0.0}
	local l_offsetpos = {0.0, 0.0, 0.0}
	
	while true do
		open_select_window_direct(nil, "Normal", "ギネヴィア親密度UP小", "ギネヴィア親密度UP中", "ギネヴィア親密度UP大",
		"ランスロット親密度UP小", "ランスロット親密度UP中", "ランスロット親密度UP大", "カメラ移動", "終了")
		if is_select(1) then
			-- AddPointしか見てないのでデバッグ用に直接入れる。本来は選択肢の後、trustParam.Update系の関数でパラメータを適用させる
			trustParam.AddPoint = 1
			dot_friendship_up(dotGuinevere, FriendshipUp, trustParam)
			wait_time(1.0)
		elseif is_select(2) then
			trustParam.AddPoint = 5
			dot_friendship_up(dotGuinevere, FriendshipUp, trustParam)
			wait_time(1.0)
		elseif is_select(3) then
			trustParam.AddPoint = 10
			dot_friendship_up(dotGuinevere, FriendshipUp, trustParam, g_offsetpos)
			wait_time(1.0)
		elseif is_select(4) then
			trustParam.AddPoint = 1
			dot_friendship_up(dotLancelot, FriendshipUp, trustParam)
			wait_time(1.0)
		elseif is_select(5) then
			trustParam.AddPoint = 5
			dot_friendship_up(dotLancelot, FriendshipUp, trustParam, l_offsetpos)
			wait_time(1.0)
		elseif is_select(6) then
			trustParam.AddPoint = 10
			dot_friendship_up(dotLancelot, FriendshipUp, trustParam, l_offsetpos)
			wait_time(1.0)
		elseif is_select(7) then
			if cameramove == false then
				cameramove = true
				move_camera(9, 23, 1.0)
			else
				cameramove = false
				move_camera(4, 21, 1.0)
			end
		else
			break
		end
	end
	
	open_narration_window()
	message_direct("終了します")
	close_narration_window()
	
	Play_end(true)
end
