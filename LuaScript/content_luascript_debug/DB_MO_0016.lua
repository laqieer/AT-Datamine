-- このluaスクリプトは、DB_MO_0016.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★市民（男）★★:会話
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★市民（男）★★:驚き
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★市民（男）★★:困る
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★市民（男）★★:悲しみ1
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★市民（男）★★:悲しみ2
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★市民（男）★★:怒る
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★市民（男）★★:喜び
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★市民（男）★★:拍手
	Talk(Actor001,"NPCNAME_0091","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★市民（女）★★:会話
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★市民（女）★★:驚き
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★市民（女）★★:困る
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★市民（女）★★:悲しみ1
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★市民（女）★★:悲しみ2
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★市民（女）★★:怒る
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★市民（女）★★:喜び
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★市民（女）★★:拍手
	Talk(Actor002,"NPCNAME_0182","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★子供（男）★★:会話
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★子供（男）★★:驚き
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★子供（男）★★:困る
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★子供（男）★★:悲しみ1
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★子供（男）★★:悲しみ2
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★子供（男）★★:怒る
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★子供（男）★★:喜び
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★子供（男）★★:拍手
	Talk(Actor003,"NPCNAME_0140","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★子供（女）★★:会話
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★子供（女）★★:驚き
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★子供（女）★★:困る
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★子供（女）★★:悲しみ1
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★子供（女）★★:悲しみ2
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★子供（女）★★:怒る
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★子供（女）★★:喜び
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★子供（女）★★:拍手
	Talk(Actor004,"NPCNAME_0141","speech","L","DB_MO_0000_0008")

	EndPlay()
end


