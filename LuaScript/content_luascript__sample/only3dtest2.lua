-- このluaスクリプトは、Eetest.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D_not2d("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Yes")
	change_face(Actor001,"Smile")


	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","ノワールが2D絵なしで口パクするのがミソっぽいです")


	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","一人目です")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:
	TalkTest(Actor002,"CHRNAME_NOIR","speech","L","二人目です")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	TalkTest(Actor003,"CHRNAME_NOIR","speech","L","三人目です")


	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","simple","L","一人目のシンプル")

	TalkTest(Actor001,"CHRNAME_NOIR","simple","L","口パクするんです")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:
	TalkTest(Actor002,"CHRNAME_NOIR","simple","L","二人目のシンプル")

	TalkTest(Actor002,"CHRNAME_NOIR","simple","L","口パクしないんです")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")



	TalkTest(Actor003,"CHRNAME_NOIR","simple","L","三人目のシンプル")

	TalkTest(Actor003,"CHRNAME_NOIR","simple","L","口パクしないんです")




	--★★ノワール★★:
	TalkTest(Actor002,"CHRNAME_NOIR","speech","L","どうでしたか！")


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

	if controllerId.FaceImageTag == "" then
		system.DebugLog("--- face? :"..controllerId.FaceImageTag.."  nilだ")
	else
		system.DebugLog("--- face? :"..controllerId.FaceImageTag.."  nilじゃない")
	end


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



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_not2d_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
