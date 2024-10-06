-- このluaスクリプトは、DB_MO_0006.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★パーシヴァル★★:会話
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★パーシヴァル★★:驚き
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★パーシヴァル★★:困る
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★パーシヴァル★★:悲しみ1
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★パーシヴァル★★:悲しみ2
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★パーシヴァル★★:怒る
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★パーシヴァル★★:喜び
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★パーシヴァル★★:拍手
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディンドラン★★:会話
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ディンドラン★★:驚き
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ディンドラン★★:困る
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディンドラン★★:悲しみ1
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ディンドラン★★:悲しみ2
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ディンドラン★★:怒る
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ディンドラン★★:喜び
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★ディンドラン★★:拍手
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガラハッド★★:会話
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ガラハッド★★:驚き
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ガラハッド★★:困る
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ガラハッド★★:悲しみ1
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ガラハッド★★:悲しみ2
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ガラハッド★★:怒る
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ガラハッド★★:喜び
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★ガラハッド★★:拍手
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★アステラ★★:会話
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★アステラ★★:驚き
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★アステラ★★:困る
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★アステラ★★:悲しみ1
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★アステラ★★:悲しみ2
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★アステラ★★:怒る
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★アステラ★★:喜び
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★アステラ★★:拍手
	Talk(Actor004,"CHRNAME_ASTERA","speech","L","DB_MO_0000_0008")

	EndPlay()
end


