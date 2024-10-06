--[[
	主にADV小の３D関連に対応した関数を記入する
]]

function cat_template_camera(animName,actor)
	
	local camera = create_camera()
	
	if actor ~= nil then
		load_exclusive_camera(camera, CameraAssetBundleName, animName, actor)
		manager.RegisterExclusiveCamera(camera, actor)
		
	else
		load_camera_anim(camera, CameraAssetBundleName, animName)
		
	end
	
	return camera
	
end

function set_chara_pos_resetting(_actor,_pos)
	set_pos(_actor,_pos)
	set_rot(_actor,{0,_pos[4],0}) --アクターの向きを調整
end

--カメラ切り替えようの関数
function setup_small_camera_resetting(_actor,_pos,_camera)
	set_pos(_actor,_pos)
	set_rot(_actor,{0,_pos[4],0}) --アクターの向きを調整
	return InitializeCharaCamera(CameraAssetBundleName, _camera, _actor) --アクターのカメラを再設定
end

function SetOffset(_obj,xoffset,yoffset,zoffset)

	local Objpos = get_pos(_obj)
	
	set_pos(_obj,{Objpos[1] + xoffset ,Objpos[2] + yoffset ,Objpos[3] + zoffset })
end

-- キャラを特定のアクターに振り向かせる関数(キャラ間限定)
function set_common_look_at(char1,char2,speed)
	
	local emax = 1.5
	local emin = 0.1
	
	if speed == nil then
		speed = 0.5
	
	elseif type(speed)~="number" then
		debug_print("speedの値が正常ではありません。") 
		return
		
	else
		--クランプ指定(最大値と最小値)
		speed = math.min(math.max(speed, emin), emax)
	end
	
	-- 注視位置へのweight設定を変えることで振り向きます
	lookat_weight_default(char1)
	
	-- weight設定前は注視位置の指定をしたあと
	keep_delay_ik_lookat(char1, char2, "J_Head", speed)
	
end

--プロップを呼び出す関数
function setup_prop_object(_obj)

	local prop_path = "content_prop_" .. _obj
	local prop_number = _obj .. "_PropModel"
	local label
	
	label = set_object(prop_path , prop_number, true)
	
	return(label)
end

--俯瞰カメラを呼び出す関数
function setup_small_camera_start(_camera)
	--空欄ならカメラを俯瞰カメラを設定する
	if _camera == nil then
		_camera = RndCamera090
	end
	
	--同じカメラなら切り替えない
	local checkcamera = is_active(_camera)
	
	--ランダムカメラの状態を取得して分岐
	if IsRndCameraActive() == false then
		--ランダムカメラを無効にする
		DontChangeRandomCamera(true)
	end
	
	if checkcamera == false then
		on_camera(_camera) --固定カメラ
	end

	
end

--俯瞰カメラを終了する関数
function setup_small_camera_end(_camera)
	
	RestartRandomCamera()

	--指定がある場合はカメラを設定する
	if _camera ~= nil then
		--ランダムカメラを無効にする
		on_camera(_camera)
	
	end
	
end

-- オフセットつきの俯瞰カメラを指定する
-- 内容はキャラカメラなので引数はカメラではなくキャラを指定するので注意
function setup_small_offset_camera_start(actor)
	RestartRandomCamera()
	manager.CloseupUpExclusiveCamera(actor)
	DontChangeRandomCamera(true)
end


-- オフセットつきの俯瞰カメラを指定したのを終了する
function setup_small_offset_camera_end(_camera)
	RestartRandomCamera()
	--指定がある場合はカメラを設定する
	if _camera ~= nil then
		on_camera(_camera)
	end
end


function EntryWalk_2P(actor, exCamera, eeTable, assetBundleName, assetName, actor2,GoalPos2P,Startpos2P)
    local eeCamera = eeTable[1]
    local startPos = eeTable[2] 
    local goalPos = eeTable[3]  
    local CameraTime1 = eeTable[4]
    local CameraTime2 = eeTable[5]
    local MoveTime = eeTable[6]
    local TurnTime = eeTable[7]        

	load_exclusive_camera(eeCamera ,assetBundleName, assetName, actor)
	eeCamera.CopyOffset(exCamera)

    --キャラを移動させる
    on_active(actor)
    on_active(actor2)
    set_pos(actor,startPos)
    set_pos(actor2,Startpos2P)
    
    turn_lookat_position(actor,goalPos[1],goalPos[2],goalPos[3],0) --向きを行先に合わせる
    turn_lookat_position(actor2,GoalPos2P[1],GoalPos2P[2],GoalPos2P[3],0) --向きを行先に合わせる
    
    PlayActionDirect(actor,"to Wlk")
    PlayActionDirect(actor2,"to Wlk")
    
    slidemove(actor, goalPos[1],goalPos[2],goalPos[3] ,MoveTime)
    slidemove(actor2, GoalPos2P[1],GoalPos2P[2],GoalPos2P[3] ,MoveTime +TurnTime)
    -- 俯瞰
    on_camera(RndCamera090)

    wait_time(CameraTime1)

    on_camera(eeCamera)

	while eeCamera.IsPositionAnimationPlayng() do
		coroutine.yield()
	end

	exCamera.SetSkipOffset()

    if manager ~= nil then
        DontChangeRandomCamera(false)
        manager.CloseupUpExclusiveCamera(actor) -- キャラカメラに変更
    end

    PlayActionDirect(actor,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(actor, goalPos[4],TurnTime)          --　回転させる
    wait_time(TurnTime)
    
     PlayActionDirect(actor2,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(actor2, GoalPos2P[4],0.5)          --　回転させる
  
end

function SET_MOVEOUT_CAMERA(Camera,Actor)

	if is_active(RndCamera090) == false then 		-- ランダムカメラ？

		--キャラカメラが自分じゃないなら自分に設定する
		if is_active(Camera) == false then
			DontChangeRandomCamera(false)				 -- キャラカメラを呼び出す際は一度falseにする必要があるらしい
			manager.CloseupUpExclusiveCamera(Actor)	 -- キャラカメラに変更
		end

		-- ランダムカメラを固定する
		DontChangeRandomCamera(true)
		
	end

end

function SET_MOVEOUT(Actor)

	-- ▼直接出力
	 --フェードアウト
	CloseTalkWindow()
	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
	Hide(Actor)
	setup_small_camera_start()
	--フェードイン
	fadein(CHARA_IN_OUT)
	wait_time(CHARA_IN_OUT)

end

function INIT_CHRPOS(Actor,ActorPos,Show)
	
	Actor.SetPos(ActorPos[1],ActorPos[2],ActorPos[3])
	Actor.SetActive(Show)
end

function dump(o)
   if type(o) == 'table' then
      local s = '{ '
      for k,v in pairs(o) do
         if type(k) ~= 'number' then k = '"'..k..'"' end
         s = s .. '['..k..'] = ' .. dump(v) .. ','
      end
      return s .. '} '
   else
      return tostring(o)
   end
end

function IN_WALK(Actor,ActorPos)
    local CameraTime1 = 1.5                   
    local CameraTime2 = 0.5                   
    local MoveTime = CameraTime1 + CameraTime2 
    local TurnTime = 0.3                     

    --キャラを移動させる
    on_active(Actor)
    PlayActionDirect(Actor,"to Wlk")
    turn_lookat_position(Actor,ActorPos[1],ActorPos[2],ActorPos[3],0) --向きを行先に合わせる
    slidemove(Actor, ActorPos[1],ActorPos[2],ActorPos[3] ,MoveTime)

    -- カメラ処理
    -- 前半の1.5秒は俯瞰
    setup_small_camera_start()
    wait_time(CameraTime1)
    -- 途中からActorに対応したカメラに変わる
    if manager ~= nil then
        DontChangeRandomCamera(false)           -- ランダムカメラを止めてから
        manager.CloseupUpExclusiveCamera(Actor) -- キャラカメラに変更
        DontChangeRandomCamera(true)            -- ランダムカメラに戻す
    end
    
    wait_time(CameraTime2)

    PlayActionDirect(Actor,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(Actor, ActorPos[4],TurnTime)          --　回転させる
    wait_time(TurnTime)
end

function IN_WALK_2P(Actor,ActorPos,Actor2,ActorPos2)
    local CameraTime1 = 1.5                   
    local CameraTime2 = 0.5                   
    local MoveTime = CameraTime1 + CameraTime2 
    local TurnTime = 0.3                     

    --キャラを移動させる
    on_active(Actor)
    PlayActionDirect(Actor,"to Wlk")
    turn_lookat_position(Actor,ActorPos[1],ActorPos[2],ActorPos[3],0) --向きを行先に合わせる
    slidemove(Actor, ActorPos[1],ActorPos[2],ActorPos[3] ,MoveTime)
    on_active(Actor2)
    PlayActionDirect(Actor2,"to Wlk")
    turn_lookat_position(Actor2,ActorPos2[1],ActorPos2[2],ActorPos2[3],0) --向きを行先に合わせる
    slidemove(Actor2, ActorPos2[1],ActorPos2[2],ActorPos2[3] ,MoveTime + 0.3)

    -- カメラ処理
    -- 前半の1.5秒は俯瞰
    setup_small_camera_start()
    wait_time(CameraTime1)
    -- 途中からActorに対応したカメラに変わる
    if manager ~= nil then
        DontChangeRandomCamera(false)           -- ランダムカメラを止めてから
        manager.CloseupUpExclusiveCamera(Actor) -- キャラカメラに変更
        DontChangeRandomCamera(true)            -- ランダムカメラに戻す
    end
    
    wait_time(CameraTime2)

    PlayActionDirect(Actor,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(Actor, ActorPos[4],TurnTime)          --　回転させる
    wait_time(TurnTime)
    
    PlayActionDirect(Actor2,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(Actor2, ActorPos2[4],TurnTime)          --　回転させる
    
end

function IN_RUN(Actor,ActorPos)
    local CameraTime1 = 0.75                   
    local CameraTime2 = 0.25                   
    local MoveTime = CameraTime1 + CameraTime2 
    local TurnTime = 0.2                     

    --キャラを移動させる
    on_active(Actor)
    PlayActionDirect(Actor,"to Run")
    turn_lookat_position(Actor,ActorPos[1],ActorPos[2],ActorPos[3],0) --向きを行先に合わせる
    slidemove(Actor, ActorPos[1],ActorPos[2],ActorPos[3] ,MoveTime)

    -- カメラ処理
    -- 前半の1.5秒は俯瞰
    setup_small_camera_start()
    wait_time(CameraTime1)
    -- 途中からActorに対応したカメラに変わる
    if manager ~= nil then
        DontChangeRandomCamera(false)           -- ランダムカメラを止めてから
        manager.CloseupUpExclusiveCamera(Actor) -- キャラカメラに変更
        DontChangeRandomCamera(true)            -- ランダムカメラに戻す
    end
    
    wait_time(CameraTime2)

    PlayActionDirect(Actor,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(Actor, ActorPos[4],TurnTime)          --　回転させる
    wait_time(TurnTime)
end

function IN_RUN_2P(Actor,ActorPos,Actor2,ActorPos2)
    local CameraTime1 = 0.75                   
    local CameraTime2 = 0.25                   
    local MoveTime = CameraTime1 + CameraTime2 
    local TurnTime = 0.2                     

    --キャラを移動させる
    on_active(Actor)
    PlayActionDirect(Actor,"to Run")
    turn_lookat_position(Actor,ActorPos[1],ActorPos[2],ActorPos[3],0) --向きを行先に合わせる
    slidemove(Actor, ActorPos[1],ActorPos[2],ActorPos[3] ,MoveTime)
    on_active(Actor2)
    PlayActionDirect(Actor2,"to Run")
    turn_lookat_position(Actor2,ActorPos2[1],ActorPos2[2],ActorPos2[3],0) --向きを行先に合わせる
    slidemove(Actor2, ActorPos2[1],ActorPos2[2],ActorPos2[3] ,MoveTime + 0.1)

    -- カメラ処理
    -- 前半の1.5秒は俯瞰
    setup_small_camera_start()
    wait_time(CameraTime1)
    -- 途中からActorに対応したカメラに変わる
    if manager ~= nil then
        DontChangeRandomCamera(false)           -- ランダムカメラを止めてから
        manager.CloseupUpExclusiveCamera(Actor) -- キャラカメラに変更
        DontChangeRandomCamera(true)            -- ランダムカメラに戻す
    end
    
    wait_time(CameraTime2)

    PlayActionDirect(Actor,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(Actor, ActorPos[4],TurnTime)          --　回転させる
    wait_time(TurnTime)
    
    PlayActionDirect(Actor2,"to Std_Loop")       --　モーションを基本立ちに設定して
    turn_chara(Actor2, ActorPos2[4],TurnTime)          --　回転させる
    
end

--入場用命令/歩き
function character_in_move_walk(_Actor,_Pos,_time,_timerot)
	
	Appear(_Actor) --キャラを表示
	
	turn_lookat_position(_Actor,_Pos[1],_Pos[2],_Pos[3],0) --向きを行先に合わせる
	PlayActionDirect(_Actor,"to Wlk")
	slidemove(_Actor,_Pos[1],_Pos[2],_Pos[3],_time ) --ポジションに移動
	wait_time(_time)
	
	PlayActionDirect(_Actor,"to Std_Loop")--待機に戻す
	
	if _timerot == nil then
		_timerot = 0.3
	end
	turn(_Actor,0, _Pos[4], 0,_timerot)
	
end

--入場用命令/走り
function character_in_move_run(_Actor,_Pos,_time,_timerot)
	
	Appear(_Actor) --キャラを表示
	
	turn_lookat_position(_Actor,_Pos[1],_Pos[2],_Pos[3],0) --向きを行先に合わせる
	PlayActionDirect(_Actor,"to Run")
	slidemove(_Actor,_Pos[1],_Pos[2],_Pos[3],_time ) --ポジションに移動
	wait_time(_time)
	
	PlayActionDirect(_Actor,"to Std_Loop")--待機に戻す
	
	if _timerot == nil then
		_timerot = 0.2
	end
	turn(_Actor,0, _Pos[4], 0,_timerot)
	
end

--入場用命令/歩き  offset.Ver
function character_in_move_walk_offset(_Actor,_Pos,offsetX,offsetY,offsetZ,_time,_timerot)
	
	local tbloffset = {_Pos[1] + offsetX ,_Pos[2] + offsetY ,_Pos[3] + offsetZ}
	
	set_pos(_Actor,tbloffset ) --初期位置設定
	turn_lookat_position(_Actor,_Pos[1],_Pos[2],_Pos[3],0) --向きを行先に合わせる
	
	Appear(_Actor) --キャラを表示
	
	PlayActionDirect(_Actor,"to Wlk")
	slidemove(_Actor,_Pos[1],_Pos[2],_Pos[3],_time ) --ポジションに移動
	wait_time(_time - 0.5)
	manager.CloseupUpExclusiveCamera(_Actor)
	wait_time(0.5)
	PlayActionDirect(_Actor,"to Std_Loop")--待機に戻す
	
	if _timerot == nil then
		_timerot = 0.3
	end
	turn(_Actor,0, _Pos[4], 0,_timerot)
	
end

--入場用命令/走り  offset.Ver
function character_in_move_run_offset(_Actor,_Pos,offsetX,offsetY,offsetZ,_time,_timerot)
	
	local tbloffset = {_Pos[1] + offsetX ,_Pos[2] + offsetY ,_Pos[3] + offsetZ}
	
	set_pos(_Actor,tbloffset ) --初期位置設定
	turn_lookat_position(_Actor,_Pos[1],_Pos[2],_Pos[3],0) --向きを行先に合わせる
	
	Appear(_Actor) --キャラを表示
	
	PlayActionDirect(_Actor,"to Run")
	slidemove(_Actor,_Pos[1],_Pos[2],_Pos[3],_time ) --ポジションに移動
	wait_time(_time)
	
	PlayActionDirect(_Actor,"to Std_Loop")--待機に戻す
	
	if _timerot == nil then
		_timerot = 0.2
	end
	turn(_Actor,0, _Pos[4], 0,_timerot)
	
end

-- バトルコントローラーを読み込んで差し替える
-- actor 対象オブジェクト
-- animationControllerName コントローラー名
-- defaultmotion デフォルトモーション
function set_battlecontroller(actor, _path , animationControllerName, defaultmotion)
	local actlabel = "content_duel_classes_" .. _path
	set_animationcontroller_path(actor, actlabel, animationControllerName, defaultmotion)
end
-- テンプレート座標調整用の共通関数

--円卓の間モルドレッドの椅子を動かす共通関数
function setup_template_moveobj_110051_02()

	Chair_10 = get_object("geo_chair_10") --モルドレッドの椅子
	set_pos(Chair_10, {-4.236, 0.123, 2.368})
	set_rot(Chair_10, {15, -83.1, 0})
	
end

function set_animationbattlecontroller(actor, _type,_female)
	local assetb = "content_duel_classes_"
	 --長剣・片手剣（ソード）・刀
	if _type == 1 then
	_assetf = "content_duel_classes_fig_swd"
	_controller = "AC_TL_Fig_Swd_Idle_Run"
	--短剣・ダガー・ショートソード
	elseif _type == 2 then
	_assetf = "content_duel_classes_fig_swt"
	_controller = "AC_TL_Fig_Swt_Idle_Run"
	--大剣・両手剣
	elseif _type == 3 then
	_assetf = "content_duel_classes_fig_swh"
	_controller = "AC_TL_Fig_Swh_Idle_Run"
	--片手斧・片手ハンマー
	elseif _type == 4 then
	_assetf = "content_duel_classes_fig_axe"
	_controller = "AC_TL_Fig_Axe_Idle_Run"
	--大斧
	elseif _type == 5 then
	_assetf = "content_duel_classes_fig_axh"
	_controller = "AC_TL_Fig_Axh_Idle_Run"
	--両手ハンマー
	elseif _type == 6 then
	_assetf = "content_duel_classes_fig_hah"
	_controller = "AC_TL_Fig_Hah_Idle_Run"
	--槍
	elseif _type == 7 then
	_assetf = "content_duel_classes_fig_spr"
	_controller = "AC_TL_Fig_Spr_Idle_Run"
	--弓
	elseif _type == 8 then
	_assetf = "content_duel_classes_fig_bow"
	_controller = "AC_TL_Fig_Bow_Idle_Run"
	--ボウガン・ショットガン
	elseif _type == 9 then
	_assetf = "content_duel_classes_fig_bog"
	_controller = "AC_TL_Fig_Bog_Idle_Run"
	--ライフル
	elseif _type == 10 then
	_assetf = "content_duel_classes_fig_grf"
	_controller = "AC_TL_Fig_Grf_Idle_Run"
	--ハンドガン
	elseif _type == 11 then
	_assetf = "content_duel_classes_fig_gun"
	_controller = "AC_TL_Fig_Gun_Idle_Run"
	--魔導書
	elseif _type == 12 then
	_assetf = "content_duel_classes_fig_mbo"
	_controller = "AC_TL_Fig_Mbo_Idle_Run"
	--ロッド
	elseif _type == 13 then
	_assetf = "content_duel_classes_fig_rod"
	_controller = "AC_TL_Fig_Rod_Idle_Run"
	--ランス
	elseif _type == 14 then
	_assetf = "content_duel_classes_fig_spl"
	_controller = "AC_TL_Fig_Spl_Idle_Run"
	end

	--女性だった場合コントローラー名にFをつける
	if _female  == true then
	_controller =  _controller.."_F"
	end

	--コントローラー設定
	set_animationcontroller_path(actor, _assetf, _controller , "ToIdle")
end

function ShowImageItem(StillId)

	CloseTalkWindow()
	wait_time(0.3)
	show_image(StillId,ITEM_STILL_POS_X, ITEM_STILL_POS_Y, ITEM_IN_TIME,false,false)
	wait_time(ITEM_WAIT_TIME)

end

function HideImageItem()

	hide_image(ITEM_OUT_TIME)
	wait_time(ITEM_WAIT_TIME)

end

function setup_prop_object_preload(_obj)
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	local prop_path = "content_prop_" .. _obj
	local prop_number = _obj .. "_PropModel"
	local label
	set_object_preload(prop_path , prop_number, true)
end

