-- このluaスクリプトは、MotionTest.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110151_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_006)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:い、いいコトだと思う…よ、俺は
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","まずしゃべる場合")


	PlayAction(Actor006,"to Greet_one")

	TalkTest(Actor006,"CHRNAME_NOIR","speech","L","そのあと他の人がしゃべる")


	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:い、いいコトだと思う…よ、俺は
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","だれかのあとしゃべる場合")








	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","てすとです")

	PlayAction(Actor001,"to Greet_one")

	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","挨拶です")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","肯定です")

	PlayAction(Actor001,"to Greet_one")

	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","もいちど挨拶")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:
	TalkTest(Actor005,"CHRNAME_NOIR","speech","L","肯定です")

	PlayAction(Actor005,"to Greet_one")

	--★★ディナタン★★:
	TalkTest(Actor005,"CHRNAME_NOIR","speech","L","挨拶です")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:
	TalkTest(Actor005,"CHRNAME_NOIR","speech","L","肯定です")



	PlayAction(Actor006,"to Greet_one")

	TalkTest(Actor006,"CHRNAME_NOIR","speech","L","こっちむいてー")






	PlayAction(Actor001,"to Greet_one")

	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","もういっかい")




	PlayAction(Actor004,"to  Std_Talk")

	--★★アーサー★★:
	TalkTest(Actor004,"CHRNAME_NOIR","speech","L","おわりです")

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
