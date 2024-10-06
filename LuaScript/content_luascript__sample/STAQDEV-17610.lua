Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		-- 疑似バトルADVの時はIncludeする

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	-- 初期化とマップ読み込みを行う
	init_psbattleadv("201010000", "201010000")
	
	-- 時間帯と天候の設定
	change_time_and_weather(BattleTime_Day, BattleWeather_Shiny)

	-- 武器構えテスト用ノワール
	dotnoir2 = dot_reserve_ally(101009001, 9, 20, 0)
	dot_set_weapon(dotnoir2, 101010001)		-- ロングソード
	dotguine = dot_reserve_ally(101011001, 11, 21, 0)
	dot_set_weapon(dotguine, 104010001)	-- スピア


	setup_complete_unit()
	
	-- ノワール武器構え変更テスト
	dot_change_anim(dotnoir2, DotAnim_AdvP01)


	change_camera_distance(10.0, 0.0)
	change_camera_angle(25.0, 0.0)
	move_camera(13, 21, 0.0)
	
end

function Play()
	fadein(0)
	Play_start(true)

	while true do
		open_select_window_direct(nil, "Normal", "Idle", "Attack", "AdvP01", "AdvP02", "終了")
		if is_select(1) then
			dot_change_anim(dotnoir2, DotAnim_Idle)
			dot_change_anim(dotguine, DotAnim_Idle)
			wait_time(2)
		elseif is_select(2) then
			dot_change_anim(dotnoir2, DotAnim_Attack)
			dot_change_anim(dotguine, DotAnim_Attack)
			wait_time(2)
		elseif is_select(3) then
			dot_change_anim(dotnoir2, DotAnim_AdvP01)
			dot_change_anim(dotguine, DotAnim_AdvP01)
			wait_time(2)
		elseif is_select(4) then
			dot_change_anim(dotnoir2, DotAnim_AdvP02)
			dot_change_anim(dotguine, DotAnim_AdvP02)
			wait_time(2)
		else
			break
		end
	end



	open_narration_window()
	message_direct("終了します")
	close_narration_window()
	
	Play_end(true)
end
