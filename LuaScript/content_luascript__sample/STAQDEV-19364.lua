-- このluaスクリプトは、STAQDEV-18766.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor005")
	template1()
end

function Play()
	StartPlay()


	--★★ノワール★★:
	TalkTest(Actor001,"","speech","L","両方ある人")

	OpenFirstAppearance(Actor001)

	--★★ガウェイン★★:
	TalkTest(Actor002,"","speech","L","両方ある人")

	OpenFirstAppearance(Actor002)

	--★★ランスロット★★:
	TalkTest(Actor003,"","speech","L","Aだけある人")

	OpenFirstAppearance(Actor003)

	--★★ギネヴィア★★:
	TalkTest(Actor004,"","speech","L","Bだけある人")

	OpenFirstAppearance(Actor004)

	--★★ティルフィング★★:
	TalkTest(Actor005,"","speech","L","両方ない人")
	OpenFirstAppearance(Actor005)


	TalkTest(Actor001,"","speech","L","終わります")

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
