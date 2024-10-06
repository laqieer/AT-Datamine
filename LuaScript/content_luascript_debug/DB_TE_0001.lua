--MA_01104_14

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "PsBattleAdv")		
Include("content_luascript_common","DemoCommonPack")	


function Load()
	Load_common(true)
		
	
	init_psbattleadv("201020000", "201020000")
	
	dotnoi = dot_reserve_ally(101009001,22, 22,0)
	dot_set_weapon(dotnoi, 101040001)

	dot1t = dot_reserve_ally(101071001,24, 22,0)
	dot_set_weapon(dot1t, 101040002)

	dot2k = dot_reserve_ally(101072001,26, 22,0)
	dot_set_weapon(dot2k, 101040003)
	
	dot3g = dot_reserve_ally(101073001,28, 22,0)
	dot_set_weapon(dot3g, 101040004)

	dot4s = dot_reserve_ally(101075001,23, 24,0)
	dot_set_weapon(dot4s, 101040005)

	dot5m = dot_reserve_ally(101076001,25, 24,0)
	dot_set_weapon(dot5m, 101040006)

	dot6n = dot_reserve_ally(101074001,27, 24,0)
	dot_set_weapon(dot6n, 103020001)

	-- ここからは敵配置予約
	-- 以下の3つは敵側の配置予約になります。
	-- 4つの数値は↑の味方側と同じ役割です。
	
	
	-- 実際にユニットを配置する。これ以降ユニットを操作する事ができるようになる。
	-- 予約したユニット情報に基づいて、ユニット配置やパーティクル読み込みが行われる。
	setup_complete_unit()

	-- 指定ユニットの向き変更（以下はdotguine、dotgwenhに対して2番（左側）の方向へ向けています）
	-- 番号ではなく「DotDir_Left」のように指定することも可能です。
	--DotDir_Up = 0（上側）
	--DotDir_Down = 1（下側）
	--DotDir_Left = 2（左側）
	--DotDir_Right = 3（右側）

	--指定ユニットの武器表示変更（以下はdotnoir、dotguine、dotgwenhの3人の武器をfalse（非表示）指定）
	--trueだと表示になります。


	--ユニットの表示/非表示（以下はbarbaroiをfalse（非表示）指定）
	--非表示にした後、以降のどこかでtrueに変えたコマンドを入れると表示されるようになります。
	
	-- カメラテスト
	-- カメラの距離を変更（ズームイン、ズームアウト）します。
	-- 1つ目の数値が距離、2つ目の数値が何秒かけてその距離に行くかになります。0の場合は一瞬でその距離になります。
	change_camera_distance(8.0, 0.0)

	-- カメラの角度を変更します。
	-- 1つ目の数値が角度、2つ目の数値が何秒かけてその角度になるかです。0の場合は一瞬で移動します。
	change_camera_angle(25.0, 0.0)

	-- カメラを移動します。
	-- 1つ目の数値がX座標、2つ目がY座標、3つ目の数値が何秒かけてその座標に移動するかです。0の場合は一瞬で移動します。
	move_camera(25, 23, 0.0)

	--パーティクル予約
end



-- シーケンスの実行
-- ここから
function Play()
	fadein(0)
	Play_start(true)
	

	--テキスト
	open_narration_window()
	message_direct("刀チェック")
	close_narration_window()
	
	
	

	Play_end(true)
end
