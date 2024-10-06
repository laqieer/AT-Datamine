-- このluaスクリプトは、DB_MO_0001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ティルフィング★★:会話
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ティルフィング★★:驚き
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ティルフィング★★:困る
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ティルフィング★★:悲しみ1
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ティルフィング★★:悲しみ2
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ティルフィング★★:怒る
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★ティルフィング★★:喜び
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★ティルフィング★★:拍手
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★レーヴァテイン★★:会話
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★レーヴァテイン★★:驚き
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★レーヴァテイン★★:困る
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★レーヴァテイン★★:悲しみ1
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★レーヴァテイン★★:悲しみ2
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★レーヴァテイン★★:怒る
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★レーヴァテイン★★:喜び
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★レーヴァテイン★★:拍手
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ノワール★★:会話
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ノワール★★:驚き
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ノワール★★:困る
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ノワール★★:悲しみ1
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ノワール★★:悲しみ2
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ノワール★★:怒る
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ノワール★★:喜び
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★ノワール★★:拍手
	Talk(Actor003,"CHRNAME_NOIR","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ランスロット★★:会話
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ランスロット★★:驚き
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ランスロット★★:困る
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ランスロット★★:悲しみ1
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ランスロット★★:悲しみ2
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ランスロット★★:怒る
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ランスロット★★:喜び
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ランスロット★★:拍手
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","DB_MO_0000_0008")

	EndPlay()
end


