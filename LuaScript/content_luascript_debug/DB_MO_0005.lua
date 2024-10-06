-- このluaスクリプトは、DB_MO_0005.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★モルドレッド★★:会話
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★モルドレッド★★:驚き
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★モルドレッド★★:困る
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★モルドレッド★★:悲しみ1
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★モルドレッド★★:悲しみ2
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★モルドレッド★★:怒る
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★モルドレッド★★:喜び
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★モルドレッド★★:拍手
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クラリス★★:会話
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★クラリス★★:驚き
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★クラリス★★:困る
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★クラリス★★:悲しみ1
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★クラリス★★:悲しみ2
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★クラリス★★:怒る
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★クラリス★★:喜び
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★クラリス★★:拍手
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴォールス★★:会話
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ヴォールス★★:驚き
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ヴォールス★★:困る
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ヴォールス★★:悲しみ1
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ヴォールス★★:悲しみ2
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ヴォールス★★:怒る
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ヴォールス★★:喜び
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★ヴォールス★★:拍手
	Talk(Actor003,"CHRNAME_BORS","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★クレア★★:会話
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★クレア★★:驚き
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★クレア★★:困る
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★クレア★★:悲しみ1
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★クレア★★:悲しみ2
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★クレア★★:怒る
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★クレア★★:喜び
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★クレア★★:拍手
	Talk(Actor004,"CHRNAME_CLARE","speech","L","DB_MO_0000_0008")

	EndPlay()
end


