-- このluaスクリプトは、DB_MO_0002.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_04_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","003","101011003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:会話
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ギネヴィア★★:驚き
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ギネヴィア★★:困る
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ギネヴィア★★:悲しみ1
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ギネヴィア★★:悲しみ2
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ギネヴィア★★:怒る
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★ギネヴィア★★:喜び
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★ギネヴィア★★:拍手
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア2★★:会話
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ギネヴィア2★★:驚き
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ギネヴィア2★★:困る
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ギネヴィア2★★:悲しみ1
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ギネヴィア2★★:悲しみ2
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ギネヴィア2★★:怒る
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ギネヴィア2★★:喜び
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★ギネヴィア2★★:拍手
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:会話
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ディナタン★★:驚き
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ディナタン★★:困る
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ディナタン★★:悲しみ1
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ディナタン★★:悲しみ2
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ディナタン★★:怒る
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ディナタン★★:喜び
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★ディナタン★★:拍手
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ガウェイン★★:会話
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ガウェイン★★:驚き
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ガウェイン★★:困る
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ガウェイン★★:悲しみ1
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ガウェイン★★:悲しみ2
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ガウェイン★★:怒る
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ガウェイン★★:喜び
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ガウェイン★★:拍手
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","DB_MO_0000_0008")

	EndPlay()
end


