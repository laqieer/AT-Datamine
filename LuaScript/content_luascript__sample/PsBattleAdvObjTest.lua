Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		-- 疑似バトルADVの時はIncludeする

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	-- 初期化とマップ読み込みを行う
	init_psbattleadv("201030000", "201030000")
	
	-- プレイヤーキャラ予約
	dotnoir = dot_reserve_ally(101009001, 14, 22, 0)
	
	-- プレイヤーキャラの武器データは必ずセットしなければならない
	dot_set_weapon(dotnoir, 101010001)		-- ロングソード
	dot_set_weapon(dotnoir, 105010001)		-- ウッドボウ
	
	chest = dot_reserve_facility(7, 14, 17, DotDir_Down, 1001, false)
	
	doorswitch = dot_reserve_facility(1, 18, 22, DotDir_Down, 1, false)
	doorobj1 = dot_reserve_facility(3, 14, 21, DotDir_Up, 1, false)
	doorobj2 = dot_reserve_facility(3, 10, 21, DotDir_Up, 1, false)
	
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()
	
	-- ドア非表示テスト
	-- dot_disp_facility(doorobj2, false)
	
	-- カメラテスト
	change_camera_distance(10.0, 0.0)
	change_camera_angle(45.0, 0.0)
	move_camera(14, 21, 0.0)
end

-- ドア開閉
function doorInteract()
	dot_move_unit_seq(dotnoir, 17, 22)
	dot_facility_interact_seq(1)
	wait_seq()
end

-- 宝箱を開く
function chestInteract()
	dot_move_unit_seq(dotnoir, 13, 17)
	dot_facility_interact_seq(1001)
	wait_seq()
end

-- シーケンスの実行
function Play()
	fadein(0)
	Play_start(true)
	
	
	local dooropen = false
	
	open_narration_window()
	message_direct("疑似バトル施設（オブジェ）ADVテスト")
	close_narration_window()
	
	while true do
		open_select_window_direct(nil, "Normal", "ドア開閉", "宝箱を開ける", "終了")
		if is_select(1) then
			doorInteract()
			if dooropen == false then
				dooropen = true
			else
				dooropen = false
			end
		elseif is_select(2) then
			if dooropen == true then
				chestInteract()
			else
				open_narration_window()
				message_direct("扉が開いていません")
				close_narration_window()
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


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
