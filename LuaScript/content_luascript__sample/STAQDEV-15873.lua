-- このluaスクリプトは、kubitest.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")

CharaPosT001 = {0, 0, 0 ,0.0}

CharaPosT010 = { 1, 0, 0.3, 0, 0}
CharaPosT011 = {-1, 0, 0.3, 0, 0}
CharaPosT012 = { 1, 0, -1, 0, 0}
CharaPosT013 = { 0, 0, -1, 0, 0}
CharaPosT014 = {-1, 0, -1, 0, 0}




function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosT001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosT010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosT011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosT012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPosT013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPosT014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	template1()

	camera = set_camera(0, 1.5, 2, 0, 180, 0, 45)

end

function Play()
	StartPlay()
	DontChangeRandomCamera(true)

	on_camera(camera)

::Block1_1::

	--★★ノワール★★:
	TalkTest(Actor001,"","speech","L","てすとです")

	TalkTest(Actor002,"","speech","L","ディナタンのほうを向きます")

	TalkTest(Actor003,"","speech","L","ガウェインのほうをむきます")

	TalkTest(Actor004,"","speech","L","だれだっけこれ向けません")

	TalkTest(Actor004,"","speech","L","向けないときはだいたいそっちのほうを向きます")


	TalkTest(Actor005,"","speech","L","ランスはうしろなので向けません")

	TalkTest(Actor006,"","speech","L","ティるふぃんもうしろにいるのでむけません")




	open_select_window_direct(Actor001,"Normal","もういちど","おわる")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end


::Block1_2::

	TalkTest(Actor001,"","speech","L","終わりです")

	EndPlay()
end


function TalkTest(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end

	if manager ~= nil then
		-- カメラワークのための通知
		manager.CloseupUpExclusiveCamera(controllerId)
	end

	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
    else
        -- ウインドウを開いたまま名前を変更する
        if lastTalkControllerId == controllerId and lastNameTag ~= talkerNameTag then 
            local onSimple = lastTalkFrameType == "simple"
            local validTalker = (talkerNameTag ~= nil)
            set_name_tag(talkerNameTag, onSimple, validTalker)     
	    end
	end

	lastTalkControllerId = controllerId
    lastNameTag = talkerNameTag

    PlayReservedPlayAction()

    PlayBranchPoint(textId)
    
	-- テスト用
	message_direct(textId)
	-- 本番用
    --message(textId)

	EndBranchPoint()

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end
