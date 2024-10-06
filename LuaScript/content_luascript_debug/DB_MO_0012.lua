-- このluaスクリプトは、DB_MO_0012.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_018_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_022_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_024_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101055","001","101055001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101056","001","101056001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101057","001","101057001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101058","001","101058001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★オーウェン★★:会話
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★オーウェン★★:驚き
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★オーウェン★★:困る
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★オーウェン★★:悲しみ1
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★オーウェン★★:悲しみ2
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★オーウェン★★:怒る
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★オーウェン★★:喜び
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★オーウェン★★:拍手
	Talk(Actor001,"CHRNAME_OWEN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ペレス★★:会話
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ペレス★★:驚き
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ペレス★★:困る
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ペレス★★:悲しみ1
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ペレス★★:悲しみ2
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ペレス★★:怒る
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ペレス★★:喜び
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★ペレス★★:拍手
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★レオデグランス王★★:会話
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★レオデグランス王★★:驚き
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★レオデグランス王★★:困る
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★レオデグランス王★★:悲しみ1
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★レオデグランス王★★:悲しみ2
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★レオデグランス王★★:怒る
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★レオデグランス王★★:喜び
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★レオデグランス王★★:拍手
	Talk(Actor003,"CHRNAME_LEODEGRAINS","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ライエンス王★★:会話
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ライエンス王★★:驚き
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ライエンス王★★:困る
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ライエンス王★★:悲しみ1
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ライエンス王★★:悲しみ2
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ライエンス王★★:怒る
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ライエンス王★★:喜び
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ライエンス王★★:拍手
	Talk(Actor004,"CHRNAME_LAIENS2","speech","L","DB_MO_0000_0008")

	EndPlay()
end


