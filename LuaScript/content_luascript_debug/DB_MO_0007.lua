-- このluaスクリプトは、DB_MO_0007.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","003","101030003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★エレイン★★:会話
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★エレイン★★:驚き
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★エレイン★★:困る
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★エレイン★★:悲しみ1
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★エレイン★★:悲しみ2
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★エレイン★★:怒る
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★エレイン★★:喜び
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★エレイン★★:拍手
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン2★★:会話
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★エレイン2★★:驚き
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★エレイン2★★:困る
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エレイン2★★:悲しみ1
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★エレイン2★★:悲しみ2
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★エレイン2★★:怒る
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★エレイン2★★:喜び
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★エレイン2★★:拍手
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラヴェイン★★:会話
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ラヴェイン★★:驚き
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ラヴェイン★★:困る
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ラヴェイン★★:悲しみ1
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ラヴェイン★★:悲しみ2
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ラヴェイン★★:怒る
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ラヴェイン★★:喜び
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★ラヴェイン★★:拍手
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ガレス★★:会話
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ガレス★★:驚き
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ガレス★★:困る
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ガレス★★:悲しみ1
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ガレス★★:悲しみ2
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ガレス★★:怒る
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ガレス★★:喜び
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ガレス★★:拍手
	Talk(Actor004,"CHRNAME_GARETH","speech","L","DB_MO_0000_0008")

	EndPlay()
end


