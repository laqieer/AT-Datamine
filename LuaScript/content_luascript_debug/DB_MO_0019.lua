-- このluaスクリプトは、DB_MO_0019.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("401030","001","401030001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★汎用王様★★:会話
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★汎用王様★★:驚き
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★汎用王様★★:困る
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★汎用王様★★:悲しみ1
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★汎用王様★★:悲しみ2
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★汎用王様★★:怒る
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★汎用王様★★:喜び
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★汎用王様★★:拍手
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★キャメロット軍兵士_上位★★:会話
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★キャメロット軍兵士_上位★★:驚き
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★キャメロット軍兵士_上位★★:困る
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★キャメロット軍兵士_上位★★:悲しみ1
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★キャメロット軍兵士_上位★★:悲しみ2
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★キャメロット軍兵士_上位★★:怒る
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★キャメロット軍兵士_上位★★:喜び
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★キャメロット軍兵士_上位★★:拍手
	Talk(Actor002,"NPCNAME_0082","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★東方諸国連合軍兵_下位★★:会話
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★東方諸国連合軍兵_下位★★:驚き
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★東方諸国連合軍兵_下位★★:困る
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★東方諸国連合軍兵_下位★★:悲しみ1
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★東方諸国連合軍兵_下位★★:悲しみ2
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★東方諸国連合軍兵_下位★★:怒る
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★東方諸国連合軍兵_下位★★:喜び
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★東方諸国連合軍兵_下位★★:拍手
	Talk(Actor003,"NPCNAME_0095","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★山賊★★:会話
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★山賊★★:驚き
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★山賊★★:困る
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★山賊★★:悲しみ1
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★山賊★★:悲しみ2
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★山賊★★:怒る
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★山賊★★:喜び
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★山賊★★:拍手
	Talk(Actor004,"NPCNAME_0283","speech","L","DB_MO_0000_0008")

	EndPlay()
end


