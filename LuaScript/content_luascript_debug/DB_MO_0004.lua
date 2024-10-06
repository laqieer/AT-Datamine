-- このluaスクリプトは、DB_MO_0004.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラグネル★★:会話
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ラグネル★★:驚き
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ラグネル★★:困る
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ラグネル★★:悲しみ1
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ラグネル★★:悲しみ2
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ラグネル★★:怒る
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★ラグネル★★:喜び
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★ラグネル★★:拍手
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★イゾルデ★★:会話
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★イゾルデ★★:驚き
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★イゾルデ★★:困る
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★イゾルデ★★:悲しみ1
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★イゾルデ★★:悲しみ2
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★イゾルデ★★:怒る
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★イゾルデ★★:喜び
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★イゾルデ★★:拍手
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マーリン★★:会話
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★マーリン★★:驚き
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★マーリン★★:困る
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★マーリン★★:悲しみ1
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★マーリン★★:悲しみ2
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★マーリン★★:怒る
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★マーリン★★:喜び
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★マーリン★★:拍手
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ブルーノ★★:会話
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ブルーノ★★:驚き
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ブルーノ★★:困る
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ブルーノ★★:悲しみ1
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ブルーノ★★:悲しみ2
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ブルーノ★★:怒る
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ブルーノ★★:喜び
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ブルーノ★★:拍手
	Talk(Actor004,"CHRNAME_BRUNO","speech","L","DB_MO_0000_0008")

	EndPlay()
end


