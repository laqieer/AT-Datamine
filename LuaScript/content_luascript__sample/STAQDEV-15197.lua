-- このluaスクリプトは、PlayerTest.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetPlayerTemplate("Actor001",nil,CharaPos110011_01_001,CameraAssetBundleName110011_01,CameraPos110011_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Bea_m_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Bea_f_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializePlayerCharacter("Actor001")
	Actor002 = InitializeCharacter_3D("101003","001","101003001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101004","001","101004001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

	--★★Player★★:
	Talktest(Actor001,"CHRNAME_NOIR","speech","L","右上のメニューに注目")


	Talktest(Actor001,"CHRNAME_NOIR","speech","L","ホームボタン非表示")
	ShowGlobalMenuButton(false)


	Talktest(Actor001,"CHRNAME_NOIR","speech","L","タップしてもいいよ1")
	Talktest(Actor001,"CHRNAME_NOIR","speech","L","タップしてもいいよ2")
	Talktest(Actor001,"CHRNAME_NOIR","speech","L","タップしてもいいよ3")


	Talktest(Actor001,"CHRNAME_NOIR","speech","L","ホームボタン表示")
	ShowGlobalMenuButton(true)


	Talktest(Actor001,"CHRNAME_NOIR","speech","L","おわりです")

	EndPlay()
end

function Talktest(controllerId, talkerNameTag, frameType, dir, textId)
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
	end

	lastTalkControllerId = controllerId

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

