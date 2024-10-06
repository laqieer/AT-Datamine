-- このluaスクリプトは、DB_MO_0017.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401028","001","401028001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor005")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★市民（中年男）★★:会話
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★市民（中年男）★★:驚き
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★市民（中年男）★★:困る
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★市民（中年男）★★:悲しみ1
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★市民（中年男）★★:悲しみ2
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★市民（中年男）★★:怒る
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★市民（中年男）★★:喜び
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★市民（中年男）★★:拍手
	Talk(Actor001,"NPCNAME_0092","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★市民（中年女）★★:会話
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★市民（中年女）★★:驚き
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★市民（中年女）★★:困る
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★市民（中年女）★★:悲しみ1
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★市民（中年女）★★:悲しみ2
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★市民（中年女）★★:怒る
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★市民（中年女）★★:喜び
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★市民（中年女）★★:拍手
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★酒場店主★★:会話
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★酒場店主★★:驚き
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★酒場店主★★:困る
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★酒場店主★★:悲しみ1
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★酒場店主★★:悲しみ2
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★酒場店主★★:怒る
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★酒場店主★★:喜び
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★酒場店主★★:拍手
	Talk(Actor003,"NPCNAME_0085","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★工房親方★★:会話
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★工房親方★★:驚き
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★工房親方★★:困る
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★工房親方★★:悲しみ1
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★工房親方★★:悲しみ2
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★工房親方★★:怒る
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★工房親方★★:喜び
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★工房親方★★:拍手
	Talk(Actor004,"NPCNAME_0046","speech","L","DB_MO_0000_0008")

	PlayAction(Actor005,"to  Std_Talk")

	--★★料理人★★:会話
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0001")

	PlayAction(Actor005,"to  Std_Surp")

	--★★料理人★★:驚き
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0002")

	PlayAction(Actor005,"to  Std_Worry")

	--★★料理人★★:困る
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0003")

	PlayAction(Actor005,"to  Std_Sad01")

	--★★料理人★★:悲しみ1
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0004")

	PlayAction(Actor005,"to  Std_Sad02")

	--★★料理人★★:悲しみ2
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0005")

	PlayAction(Actor005,"to  Std_Angry")

	--★★料理人★★:怒る
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0006")

	PlayAction(Actor005,"to  Std_Joy")

	--★★料理人★★:喜び
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0007")

	PlayAction(Actor005,"to  Std_Appl")

	--★★料理人★★:拍手
	Talk(Actor005,"NPCNAME_0088","speech","L","DB_MO_0000_0008")

	EndPlay()
end


