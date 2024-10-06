-- このluaスクリプトは、DB_MO_0003.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★トリスタン★★:会話
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★トリスタン★★:驚き
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★トリスタン★★:困る
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★トリスタン★★:悲しみ1
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★トリスタン★★:悲しみ2
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★トリスタン★★:怒る
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★トリスタン★★:喜び
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★トリスタン★★:拍手
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:会話
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★アーサー★★:驚き
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★アーサー★★:困る
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★アーサー★★:悲しみ1
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★アーサー★★:悲しみ2
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★アーサー★★:怒る
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★アーサー★★:喜び
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★アーサー★★:拍手
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:会話
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ギネマウア★★:驚き
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ギネマウア★★:困る
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ギネマウア★★:悲しみ1
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ギネマウア★★:悲しみ2
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ギネマウア★★:怒る
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ギネマウア★★:喜び
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★ギネマウア★★:拍手
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★マルディサント★★:会話
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★マルディサント★★:驚き
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★マルディサント★★:困る
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★マルディサント★★:悲しみ1
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★マルディサント★★:悲しみ2
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★マルディサント★★:怒る
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★マルディサント★★:喜び
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★マルディサント★★:拍手
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","DB_MO_0000_0008")

	EndPlay()
end


