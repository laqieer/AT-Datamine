-- このluaスクリプトは、DB_MO_0015.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_009_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_509_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_009_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_509_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("401001","001","401001001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401002","001","401002001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401003","001","401003001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401004","001","401004001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★現代編NPC　現代編学生（男）★★:会話
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★現代編NPC　現代編学生（男）★★:驚き
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★現代編NPC　現代編学生（男）★★:困る
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★現代編NPC　現代編学生（男）★★:悲しみ1
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★現代編NPC　現代編学生（男）★★:悲しみ2
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★現代編NPC　現代編学生（男）★★:怒る
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★現代編NPC　現代編学生（男）★★:喜び
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★現代編NPC　現代編学生（男）★★:拍手
	Talk(Actor001,"NPCNAME_0151","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★現代編NPC　現代編学生（女）★★:会話
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★現代編NPC　現代編学生（女）★★:驚き
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★現代編NPC　現代編学生（女）★★:困る
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★現代編NPC　現代編学生（女）★★:悲しみ1
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★現代編NPC　現代編学生（女）★★:悲しみ2
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★現代編NPC　現代編学生（女）★★:怒る
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★現代編NPC　現代編学生（女）★★:喜び
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★現代編NPC　現代編学生（女）★★:拍手
	Talk(Actor002,"NPCNAME_0146","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★現代編NPC　現代編学生（男）②★★:会話
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★現代編NPC　現代編学生（男）②★★:驚き
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★現代編NPC　現代編学生（男）②★★:困る
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★現代編NPC　現代編学生（男）②★★:悲しみ1
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★現代編NPC　現代編学生（男）②★★:悲しみ2
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★現代編NPC　現代編学生（男）②★★:怒る
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★現代編NPC　現代編学生（男）②★★:喜び
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★現代編NPC　現代編学生（男）②★★:拍手
	Talk(Actor003,"NPCNAME_0153","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★現代編NPC　現代編学生（女）②★★:会話
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★現代編NPC　現代編学生（女）②★★:驚き
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★現代編NPC　現代編学生（女）②★★:困る
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★現代編NPC　現代編学生（女）②★★:悲しみ1
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★現代編NPC　現代編学生（女）②★★:悲しみ2
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★現代編NPC　現代編学生（女）②★★:怒る
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★現代編NPC　現代編学生（女）②★★:喜び
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★現代編NPC　現代編学生（女）②★★:拍手
	Talk(Actor004,"NPCNAME_0147","speech","L","DB_MO_0000_0008")

	PlayAction(Actor005,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）★★:会話
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0001")

	PlayAction(Actor005,"to  Std_Surp")

	--★★キャメロット騎士学術院（男）★★:驚き
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0002")

	PlayAction(Actor005,"to  Std_Worry")

	--★★キャメロット騎士学術院（男）★★:困る
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0003")

	PlayAction(Actor005,"to  Std_Sad01")

	--★★キャメロット騎士学術院（男）★★:悲しみ1
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0004")

	PlayAction(Actor005,"to  Std_Sad02")

	--★★キャメロット騎士学術院（男）★★:悲しみ2
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0005")

	PlayAction(Actor005,"to  Std_Angry")

	--★★キャメロット騎士学術院（男）★★:怒る
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0006")

	PlayAction(Actor005,"to  Std_Joy")

	--★★キャメロット騎士学術院（男）★★:喜び
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0007")

	PlayAction(Actor005,"to  Std_Appl")

	--★★キャメロット騎士学術院（男）★★:拍手
	Talk(Actor005,"NPCNAME_0154","speech","L","DB_MO_0000_0008")

	EndPlay()
end


