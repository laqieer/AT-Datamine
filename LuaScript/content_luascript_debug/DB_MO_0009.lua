-- このluaスクリプトは、DB_MO_0009.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラシア★★:会話
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ラシア★★:驚き
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ラシア★★:困る
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ラシア★★:悲しみ1
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ラシア★★:悲しみ2
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ラシア★★:怒る
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★ラシア★★:喜び
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★ラシア★★:拍手
	Talk(Actor001,"CHRNAME_RASIA","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ローラ★★:会話
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ローラ★★:驚き
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ローラ★★:困る
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ローラ★★:悲しみ1
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ローラ★★:悲しみ2
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ローラ★★:怒る
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ローラ★★:喜び
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★ローラ★★:拍手
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★フレン★★:会話
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★フレン★★:驚き
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★フレン★★:困る
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★フレン★★:悲しみ1
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★フレン★★:悲しみ2
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★フレン★★:怒る
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★フレン★★:喜び
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★フレン★★:拍手
	Talk(Actor003,"CHRNAME_FREN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ケイ★★:会話
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ケイ★★:驚き
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ケイ★★:困る
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ケイ★★:悲しみ1
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ケイ★★:悲しみ2
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ケイ★★:怒る
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ケイ★★:喜び
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ケイ★★:拍手
	Talk(Actor004,"CHRNAME_KAY","speech","L","DB_MO_0000_0008")

	EndPlay()
end


