-- このluaスクリプトは、PlayerTest.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetPlayerTemplate("Actor001",nil,CharaPos110021_01_001,CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Bea_m_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Bea_f_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Che_m_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Che_f_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Col_m_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Col_f_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializePlayerCharacter("Actor001")
	Actor002 = InitializeCharacter_3D("101003","001","101003001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101004","001","101004001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101005","001","101005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101006","001","101006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101007","001","101007001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101008","001","101008001","content_animationpack__common","FacialPack","Actor007")
	template1()
end

function Play()
	StartPlay()


	--★★Player★★:
	Talktest(Actor001,"CHRNAME_NOIR","speech","L","てすとです")

	Talktest(Actor002,"CHRNAME_NOIR","speech","L","男弱気")

	Talktest(Actor003,"CHRNAME_NOIR","speech","L","女弱気")

	Talktest(Actor004,"CHRNAME_NOIR","speech","L","男陽気")

	Talktest(Actor005,"CHRNAME_NOIR","speech","L","女陽気")

	Talktest(Actor006,"CHRNAME_NOIR","speech","L","男クール")

	Talktest(Actor007,"CHRNAME_NOIR","speech","L","女クール")

	Talktest(Actor001,"CHRNAME_NOIR","speech","L","プレイヤーが選んだのは私です")

	Talktest(Actor001,"CHRNAME_NOIR","speech","L","おしまい")
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

