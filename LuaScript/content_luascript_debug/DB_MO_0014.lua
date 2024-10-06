-- このluaスクリプトは、DB_MO_0014.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101067","001","101067001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★リアム★★:会話
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★リアム★★:驚き
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★リアム★★:困る
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★リアム★★:悲しみ1
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★リアム★★:悲しみ2
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★リアム★★:怒る
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★リアム★★:喜び
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★リアム★★:拍手
	Talk(Actor001,"CHRNAME_LIAM","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★キッス★★:会話
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★キッス★★:驚き
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★キッス★★:困る
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★キッス★★:悲しみ1
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★キッス★★:悲しみ2
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★キッス★★:怒る
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★キッス★★:喜び
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★キッス★★:拍手
	Talk(Actor002,"CHRNAME_KISS","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ブレイズ★★:会話
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ブレイズ★★:驚き
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ブレイズ★★:困る
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ブレイズ★★:悲しみ1
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ブレイズ★★:悲しみ2
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ブレイズ★★:怒る
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ブレイズ★★:喜び
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★ブレイズ★★:拍手
	Talk(Actor003,"CHRNAME_BLAZE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ニニアン★★:会話
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ニニアン★★:驚き
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ニニアン★★:困る
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ニニアン★★:悲しみ1
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ニニアン★★:悲しみ2
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ニニアン★★:怒る
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ニニアン★★:喜び
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ニニアン★★:拍手
	Talk(Actor004,"CHRNAME_NINIAN","speech","L","DB_MO_0000_0008")

	EndPlay()
end


