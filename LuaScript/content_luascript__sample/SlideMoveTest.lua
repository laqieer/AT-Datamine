Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
    demo_setup()
    load_scene("content_areascene_110011", "Area110011") -- ノワール教室：昼晴

    setup_Noir(CHARA3_AREA110011)
    setup_Lancelot(CHARA1_AREA110011)

    MAIN_CAMERA = set_camera(CAMERA_AREA110011)
end

-- シーケンスの実行
function Play()

    on_camera(MAIN_CAMERA)
    demo_start()

    select_top_menu()

    message_lancelot("終わります")

    reset_camera_lookat(MAIN_CAMERA)

    demo_end()
end

-- ランスロットの発言
function message_lancelot(message)
    open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)
    message_direct(message)
    close_speech_window()
end

-- カメラ位置の設定
function reset_camera_pos(camera, posX, posY, posZ, angX, angY, angZ, fieldOfView)
    -- ラベル定義対応
    if type(posX) == "table" then
        camera.InitializeTransform(posX[1], posX[2], posX[3], posX[4], posX[5], posX[6], 1.0, 1.0, 1.0)
        camera.FieldOfView(posX[7])
    else
        camera.InitializeTransform(posX, posY, posZ, angX, angY, angZ, 1.0, 1.0, 1.0)
        camera.FieldOfView(fieldOfView)
    end
end

-- 選択トップ
function select_top_menu()
    while true do
        open_select_window_direct(Noir, "Normal", "追加された関数", "SlideMove2のy軸移動", "引数テスト","曲線の終了位置", "終わる")
        if is_select(1) then
            select_functions()
        elseif is_select(2) then
            select_slidemove_y()
        elseif is_select(3) then
            select_argument_test()
        elseif is_select(4) then
            select_curve_goaltest()
        else
            break
        end
    end
end

-- 今回追加された関数の選択
function select_functions()
    while true do
        open_select_window_direct(Noir, "Normal", "横移動", "曲線移動", "円移動", "追尾周回", "終わる")
        if is_select(1) then
            select_slidemove()
        elseif is_select(2) then
            select_curvemove()
        elseif is_select(3) then
            select_circlemove()
        elseif is_select(4) then
            select_aroundmove()
        else
            break
        end
    end
end



-- 直線移動選択
function select_slidemove()
    while true do
        open_select_window_direct(Noir, "Normal", "Linear", "EaseIn", "EaseOut", "EaseInOut", "終わる")
        if is_select(1) then
            message_lancelot("Liner")
            test_slidemove(0)
        elseif is_select(2) then
            message_lancelot("EaseIn")
            test_slidemove(1)
        elseif is_select(3) then
            message_lancelot("EaseOut")
            test_slidemove(2)
        elseif is_select(4) then
            message_lancelot("EaseIOut")
            test_slidemove(3)
        else
            break
        end
    end
end

-- 直線移動テスト
function test_slidemove(ease)
    local signal

    reset_camera_pos(MAIN_CAMERA,{0.255,1.573,1.432, 3,-145.5,0, 21})

    cameraPos = get_pos(MAIN_CAMERA)

    signal = slidemove2(MAIN_CAMERA, cameraPos[1] +2 , cameraPos[2], cameraPos[3], 3, ease)
    while signal.IsProccessing() do
        coroutine.yield()
    end
end

-- 曲線移動選択
function select_curvemove()
    while true do
        open_select_window_direct(Noir, "Normal", "Linear", "EaseIn", "EaseOut", "EaseInOut", "終わる")
        if is_select(1) then
            message_lancelot("curve Liner")
            test_curvemove(0)
        elseif is_select(2) then
            message_lancelot("curve EaseIn")
            test_curvemove(1)
        elseif is_select(3) then
            message_lancelot("curve EaseOut")
            test_curvemove(2)
        elseif is_select(4) then
            message_lancelot("curve EaseInOut")
            test_curvemove(3)
        else
            break
        end
    end
end

-- 曲線移動テスト
function test_curvemove(speedtype)
    local signal

    reset_camera_pos(MAIN_CAMERA,{1.255,1.573,1.432, 3,-145.5,0, 21})

    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = curvemove(MAIN_CAMERA, 2.255, 1.573, 1.0, 1.0, 1.573, -2.5, 4, speedtype)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat(MAIN_CAMERA)
end

-- 円周移動
function select_circlemove()
    while true do
        open_select_window_direct(Noir, "Normal", "Linear", "EaseIn", "EaseOut","EaseInOut", "終わる")
        reset_camera_pos(MAIN_CAMERA,{1.255,1.573,1.432, 3,-145.5,0, 21})
        if is_select(1) then
            message_lancelot("circle Liner 180度")
            test_circlemove(180,0)
        elseif is_select(2) then
            message_lancelot("circle EaseIn 180度")
            test_circlemove(180,1)
        elseif is_select(3) then
            message_lancelot("cirvle EaseOut 180度")
            test_circlemove(180,2)
        elseif is_select(4) then
            message_lancelot("circle EaseInOut 720度")
            test_circlemove(720,3)
        else
            break
        end
    end
end

-- 円周移動
function test_circlemove(angle,speedType)
    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    local signal
    signal = circlemove(MAIN_CAMERA,-0.16, 1.32, -0.85, angle, 4, speedType)
    while signal.IsProccessing() do
        coroutine.yield()
    end
    reset_camera_lookat(MAIN_CAMERA)
end

--　追尾周回選択
function select_aroundmove()
    while true do
        open_select_window_direct(Noir, "Normal", "Linear", "EaseIn", "EaseOut", "EaseInOut", "終わる")
        if is_select(1) then
            test_aroundmove(280, 8, 0)
        elseif is_select(2) then
            test_aroundmove(280, 8, 1)
        elseif is_select(3) then
            test_aroundmove(280, 8, 2)
        elseif is_select(4) then
            test_aroundmove(280, 8, 3)
        else
            break
        end
    end
end

-- 追尾周回テスト
function test_aroundmove(angle, duration, speedType)

    local signal

    set_pos(MAIN_CAMERA, {3.8, 1.573, 7})
    set_pos(Noir, {1.8,0, 5})
    set_camera_lookat_object(MAIN_CAMERA, Noir)

    aroundmove(MAIN_CAMERA, Noir, angle, duration, speedType)

    signal = slidemove(Noir , 1.8,0,-5, duration)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat_object(MAIN_CAMERA)
    set_pos(Noir, CHARA3_AREA110011)
    reset_camera_pos(MAIN_CAMERA, CAMERA_AREA110011)    
end

--y軸テスト
function select_slidemove_y()
    while true do
        open_select_window_direct(Noir, "Normal", "Linear", "EaseIn", "EaseOut", "EaseInOut", "終わる")
        if is_select(1) then
            test_slidemove2_y(0)
        elseif is_select(2) then
            test_slidemove2_y(1)
        elseif is_select(3) then
            test_slidemove2_y(2)
        elseif is_select(4) then
            test_slidemove2_y(3)
        else
            break
        end
    end
end

-- y軸移動するテスト
function test_slidemove2_y(ease)
    local signal
    reset_camera_pos(MAIN_CAMERA,{5.12, 6.5, 14.57, 3,-145.5,0, 21})

    cameraPos = get_pos(MAIN_CAMERA)

    signal = slidemove2(MAIN_CAMERA, 5.12, 2.28, 14.57, 3, ease)
    while signal.IsProccessing() do
        coroutine.yield()
    end
end

-- 引数テストの選択
function select_argument_test()
    while true do
        open_select_window_direct(Noir, "Normal", "直線", "曲線", "円", "周回", "終わる")
        if is_select(1) then
            argument_test_slidemove(1)
        elseif is_select(2) then
            argument_test_curve(1)
        elseif is_select(3) then
            argument_test_circle(1)
        elseif is_select(4) then
            argument_test_around(1)
        else
            break
        end
    end
end

-- slidemove
function argument_test_slidemove(ease)
    local signal
    local signal2

    message_lancelot("直線 引数1")

    reset_camera_pos(MAIN_CAMERA,{0.255,1.573,1.432, 3,-145.5,0, 21})

    cameraPos = { 2.255,1.573,1.432 }

    signal = slidemove2(MAIN_CAMERA, cameraPos, 3, ease)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_pos(MAIN_CAMERA,{0.255,1.573,1.432, 3,-145.5,0, 21})
    message_lancelot("直線 引数2")

    cameraPos2 = { 2.255,1.573,1.432, 3, 0}

    signal2 = slidemove2(MAIN_CAMERA, cameraPos2)
    while signal2.IsProccessing() do
        coroutine.yield()
    end
end

-- curvemove
function argument_test_curve(speedtype)

    centerPos = { 2.255, 1.573, 1.0}
    goalPos = {1.0, 1.573, -2.5}
    poss = { 2.255, 1.573, 1.0, 1.0, 1.573, -2.5}
    allarg = { 2.255, 1.573, 1.0, 1.0, 1.573, -2.5, 4, 0}

    message_lancelot("曲線 引数1")

    local signal

    reset_camera_pos(MAIN_CAMERA,{1.255,1.573,1.432, 3,-145.5,0, 21})

    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = curvemove(MAIN_CAMERA, 2.255, 1.573, 1.0, 1.0, 1.573, -2.5, 4, speedtype)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat(MAIN_CAMERA)

    message_lancelot("曲線 引数2")

    reset_camera_pos(MAIN_CAMERA,{1.255,1.573,1.432, 3,-145.5,0, 21})

    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = curvemove(MAIN_CAMERA, centerPos, 1.0, 1.573, -2.5, 4, speedtype)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat(MAIN_CAMERA)

    message_lancelot("曲線 引数3")

    reset_camera_pos(MAIN_CAMERA,{1.255,1.573,1.432, 3,-145.5,0, 21})

    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = curvemove(MAIN_CAMERA, centerPos, goalPos, 4, speedtype)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat(MAIN_CAMERA)

    message_lancelot("曲線 引数4")

    reset_camera_pos(MAIN_CAMERA,{1.255,1.573,1.432, 3,-145.5,0, 21})

    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = curvemove(MAIN_CAMERA, poss, 4, speedtype)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat(MAIN_CAMERA)

    message_lancelot("曲線 引数5")

    reset_camera_pos(MAIN_CAMERA,{1.255,1.573,1.432, 3,-145.5,0, 21})

    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = curvemove(MAIN_CAMERA, allarg)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat(MAIN_CAMERA)

end

-- circlemove
function argument_test_circle(speedType)
    angle = 180
    message_lancelot("円移動　引数1")
 
    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    local signal
    signal = circlemove(MAIN_CAMERA,-0.16, 1.32, -0.85, angle, 4, speedType)
    while signal.IsProccessing() do
        coroutine.yield()
    end
    reset_camera_lookat(MAIN_CAMERA)

    message_lancelot("円移動　引数2")

    centerPos = {-0.16, 1.32, -0.85 }
    allarg = { -0.16, 1.32, -0.85, angle, 4, speedType}
    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = circlemove(MAIN_CAMERA,centerPos, angle, 4, speedType)
    while signal.IsProccessing() do
        coroutine.yield()
    end
    reset_camera_lookat(MAIN_CAMERA)

    message_lancelot("円移動　引数3")
    set_camera_lookat(MAIN_CAMERA,-0.16, 1.32, -0.85)

    signal = circlemove(MAIN_CAMERA,allarg)
    while signal.IsProccessing() do
        coroutine.yield()
    end
    reset_camera_lookat(MAIN_CAMERA)

end

-- aroundmove
function argument_test_around(speedType)

    angle = 720
    duration = 6
    message_lancelot("円追尾　引数1")
    local signal

    set_pos(MAIN_CAMERA, {3.8, 1.573, 7})
    set_pos(Noir, {1.8,0, 5})
    set_camera_lookat_object(MAIN_CAMERA, Noir)

    aroundmove(MAIN_CAMERA, Noir, angle, duration, speedType)

    signal = slidemove(Noir , 1.8,0,-5, duration)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat_object(MAIN_CAMERA)
    set_pos(Noir, CHARA3_AREA110011)
    reset_camera_pos(MAIN_CAMERA, CAMERA_AREA110011)    

    message_lancelot("円追尾　引数2")

    allarg = { angle, duration, speedType}
    set_pos(MAIN_CAMERA, {3.8, 1.573, 7})
    set_pos(Noir, {1.8,0, 5})
    set_camera_lookat_object(MAIN_CAMERA, Noir)

    aroundmove(MAIN_CAMERA, Noir, allarg)

    signal = slidemove(Noir , 1.8,0,-5, duration)
    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat_object(MAIN_CAMERA)
    set_pos(Noir, CHARA3_AREA110011)
    reset_camera_pos(MAIN_CAMERA, CAMERA_AREA110011)    

end

-- 曲線の終了位置の検証
function select_curve_goaltest()
    while true do
        open_select_window_direct(Noir, "Normal", "曲線の終了位置", "終わる")
        if is_select(1) then
            test_curve_goal()
        else
            break
        end
    end
end


function test_curve_goal()
    Camera_01_0410_1_2 = {4.32, 1.31, 9.15,   359.005, 228.06, 359.025,   27}
    Camera_01_0410_1_2_look = {2.65,1.023,7.66}
    Camera_01_0410_1_2_goal = {5.46, 2.29, 14.45}
    Camera_01_0410_1_2_pos1 = {0.27, 2.28, 16.23}

    local signal

    reset_camera_pos(MAIN_CAMERA,Camera_01_0410_1_2)

    set_camera_lookat(MAIN_CAMERA,2.65,1.023,7.66)

    signal = curvemove(MAIN_CAMERA,Camera_01_0410_1_2_pos1, Camera_01_0410_1_2_goal, 6, 1)

    while signal.IsProccessing() do
        coroutine.yield()
    end

    reset_camera_lookat(MAIN_CAMERA)

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
    load_scene_preload("content_areascene_110011", "Area110011")
    setup_Noir_preload(CHARA3_AREA110011)
    setup_Lancelot_preload(CHARA1_AREA110011)
end
