-- このluaスクリプトは、LaughTest.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()


	--★★ガウェイン★★:
	TalkTest(Actor001,"","speech","L","テストです")

	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:
	TalkTest(Actor001,"","speech","L","微笑です")

	change_face(Actor001,"Anger")

	--★★ガウェイン★★:
	TalkTest(Actor001,"","speech","L","怒りです")

	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:
	TalkTest(Actor001,"","speech","L","微笑です")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Laugh")

	--★★ガウェイン★★:
	TalkTest(Actor001,"","speech","L","カットインで")

	change_face(Actor001,"Normal")

	--★★ガウェイン★★:
	TalkTest(Actor001,"","speech","L","おわりです")

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
