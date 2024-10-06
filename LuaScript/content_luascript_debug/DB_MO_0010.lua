-- このluaスクリプトは、DB_MO_0010.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101041","002","101041002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","001","101041001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★モルガン★★:会話
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★モルガン★★:驚き
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★モルガン★★:困る
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★モルガン★★:悲しみ1
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★モルガン★★:悲しみ2
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★モルガン★★:怒る
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★モルガン★★:喜び
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★モルガン★★:拍手
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★モルガン2★★:会話
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★モルガン2★★:驚き
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★モルガン2★★:困る
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★モルガン2★★:悲しみ1
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★モルガン2★★:悲しみ2
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★モルガン2★★:怒る
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★モルガン2★★:喜び
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★モルガン2★★:拍手
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★モルガン(立)★★:会話
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★モルガン(立)★★:驚き
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★モルガン(立)★★:困る
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★モルガン(立)★★:悲しみ1
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★モルガン(立)★★:悲しみ2
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★モルガン(立)★★:怒る
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★モルガン(立)★★:喜び
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★モルガン(立)★★:拍手
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ブライアン★★:会話
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ブライアン★★:驚き
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★ブライアン★★:困る
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ブライアン★★:悲しみ1
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ブライアン★★:悲しみ2
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ブライアン★★:怒る
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ブライアン★★:喜び
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★ブライアン★★:拍手
	Talk(Actor004,"CHRNAME_BRIAN","speech","L","DB_MO_0000_0008")

	EndPlay()
end


