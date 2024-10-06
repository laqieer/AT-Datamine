-- このluaスクリプトは、LaughTest.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_007)

	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")

	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Laugh")

	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","初登場テスト")

	open_1st_appeaerance(Actor001)

	TalkTest(Actor002,"CHRNAME_NOIR","speech","L","初登場テスト")
	open_1st_appeaerance(Actor002)

	TalkTest(Actor003,"CHRNAME_NOIR","speech","L","初登場テスト")
	open_1st_appeaerance(Actor003)
	TalkTest(Actor004,"CHRNAME_NOIR","speech","L","初登場テスト")
	open_1st_appeaerance(Actor004)
	TalkTest(Actor005,"CHRNAME_NOIR","speech","L","初登場テスト")
	open_1st_appeaerance(Actor005)


	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","おわりです")
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
