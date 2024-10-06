Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110131", "Area110131") -- 講堂
	
	Camera01 = set_camera(0.61, 1.531, -6.0, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.8, 1.01, -4.3)
	
	Lancelot	= set_chara("content_chr_1010002_101000201_model", "Chr_1010002_101000201_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  -2.0, 0.0, -3.5,   90.0, "Col_Std_loop_m", "Normal")
	Noir		= set_chara("content_chr_1010001_101000102_model", "Chr_1010001_101000102_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  -0.24, 0.0, -4.71, 0, "Col_Std_loop_m", "Normal")

	character2D(Lancelot,	"Lancelot",		"content_unit_101000201", "101000201_UnitFace", "101000201_UnitCutin", "101000201_UnitThumb", "101000201_UnitImage_Full", "101000201_UnitImage_HiRes")
	character2D(Noir,		"Noir",			"content_unit_101000102", "101000102_UnitFace", "101000102_UnitCutin", "101000102_UnitThumb", "101000102_UnitImage_Full", "101000102_UnitImage_HiRes")

end

-- ランスロットをひたすら歩かせるコルーチン
function moveLancelot()
	local signal
	motion(Lancelot, "Sri_Wlk_loop_m", 0.4, 1.0, true)
	while true do
		signal = slidemove(Lancelot, 3.0, 0.0, -3.5, 3.5)
		while signal.IsProccessing() do
			coroutine.yield()
		end
		signal = turn(Lancelot, 0, 180, 0, 1.0)
		while signal.IsProccessing() do
			coroutine.yield()
		end

		signal = slidemove(Lancelot, 3.0, 0.0, -8.5, 3.5)
		while signal.IsProccessing() do
			coroutine.yield()
		end
		signal = turn(Lancelot, 0, -90, 0, 1.0)
		while signal.IsProccessing() do
			coroutine.yield()
		end
		
		signal = slidemove(Lancelot, -2.0, 0.0, -8.5, 3.5)
		while signal.IsProccessing() do
			coroutine.yield()
		end
		
		signal = turn(Lancelot, 0, 0, 0, 1.0)
		while signal.IsProccessing() do
			coroutine.yield()
		end
		
		signal = slidemove(Lancelot, -2.0, 0.0, -3.5, 3.5)
		while signal.IsProccessing() do
			coroutine.yield()
		end
		
		signal = turn(Lancelot, 0, 90, 0, 1.0)
		while signal.IsProccessing() do
			coroutine.yield()
		end
		
	end
	
end


-- 最初に首を動かす時に、ゆっくり動かすための線形補間コルーチンサンプル
function ik_lerp_start(coe)
	local totaltime = 0
	while true do
		local deltatime = system.GetDeltaTime()
		
		-- なんとなく値を足していってそれっぽぃ数値を作る
		totaltime = totaltime + deltatime * coe
		
		-- 補間値が1.0を超えたら完了
		if 1.0 <= totaltime then
			lookat_weight(Noir, 1.0, 0.0, 1.0, 0.5)
			return
		end
		
		-- 現在の時間の weight値を入れて、首を動かす
		lookat_weight(Noir, totaltime, 0.0, totaltime, 0.5)
		
		-- 次のフレームに行くため、処理を移す
		coroutine.yield()
	end
end


-- 首を元の位置にゆっくり戻すための線形補間コルーチンサンプル
function ik_lerp_return(coe)
	local totaltime = 1.0
	while true do
		local deltatime = system.GetDeltaTime()
		
		-- なんとなく値を引いていってそれっぽぃ数値を作る
		totaltime = totaltime - deltatime * coe
		
		-- 補間値が0.0以下になったら完了
		if totaltime <= 0.0 then
			lookat_weight(Noir, 0.0, 0.0, 0.0, 0.5)
			return
		end
		
		-- 現在の時間の weight値を入れて、首を動かす
		lookat_weight(Noir, totaltime, 0.0, totaltime, 0.5)
		
		-- 次のフレームに行くため、処理を移す
		coroutine.yield()
	end
end


-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	-- ランスロットを歩かせるコルーチン生成
	local op = create_coroutine(moveLancelot)
	coroutine.resume(op)
	
	local signal
	while true do
		open_select_window_direct(Noir, "Normal", "回転追尾オン", "回転追尾オフ", "首追尾オン", "首追尾オフ", "終了")
		if is_select(1) then
			-- ランスロットの方に向き続ける。
			--補間値は、0.1以下くらいがちょうど良いが、あまり小さい値だと補間が追いつかくて相手を追尾できなくなる
			keep_turn_lookat(Noir, Lancelot, 0.05)
		elseif is_select(2) then
			-- 回転追尾offにする時はnilを入れる
			keep_turn_lookat(Noir, nil)
		elseif is_select(3) then
			-- 注視対象とパーツを入力。人物の場合は J_Head = 頭 を想定
			keep_ik_lookat(Noir, Lancelot, "J_Head")

			-- 首と胴のIK反映係数を入力。。Unity標準のSetLookAtWeightにそのまま入る。clampWeightは0.5=180度くらいがちょうどいいかも
			lookat_weight(Noir, 0.0, 0.0, 0.0, 0.5)
			
			-- コルーチンで徐々に首を曲げていく
			startfunc = create_coroutine(ik_lerp_start)
			coroutine.resume(startfunc, 0.4)
		elseif is_select(4) then
			-- IK追尾オフにするには、IK反映係数を0にする。IK反映係数を戻さなければ、その場所を見続ける。
			-- lookat_weight(Noir, 0.0, 0.0, 0.0, 0.0)
			
			-- 追尾ターゲットを消す
			keep_ik_lookat(Noir, nil, true)
			
			-- コルーチンで徐々に首を戻していく。実行しなければ、首の位置はそのまま
			returnfunc = create_coroutine(ik_lerp_return)
			coroutine.resume(returnfunc, 0.4)
		else
			break
		end
	end

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110131", "Area110131")
	set_chara_preload("content_chr_1010002_101000201_model", "Chr_1010002_101000201_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  -2.0, 0.0, -3.5,   90.0, "Col_Std_loop_m", "Normal")
	set_chara_preload("content_chr_1010001_101000102_model", "Chr_1010001_101000102_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  -0.24, 0.0, -4.71, 0, "Col_Std_loop_m", "Normal")
end
