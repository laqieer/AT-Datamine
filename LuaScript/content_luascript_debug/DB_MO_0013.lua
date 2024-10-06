-- このluaスクリプトは、DB_MO_0013.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101060","001","101060001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★セレスティ★★:会話
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★セレスティ★★:驚き
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★セレスティ★★:困る
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★セレスティ★★:悲しみ1
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★セレスティ★★:悲しみ2
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★セレスティ★★:怒る
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★セレスティ★★:喜び
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★セレスティ★★:拍手
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:会話
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ラロゥ★★:驚き
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ラロゥ★★:困る
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ラロゥ★★:悲しみ1
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ラロゥ★★:悲しみ2
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ラロゥ★★:怒る
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ラロゥ★★:喜び
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★ラロゥ★★:拍手
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マルイル★★:会話
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★マルイル★★:驚き
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★マルイル★★:困る
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★マルイル★★:悲しみ1
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★マルイル★★:悲しみ2
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★マルイル★★:怒る
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★マルイル★★:喜び
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★マルイル★★:拍手
	Talk(Actor003,"CHRNAME_MARIL","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★クリスティーナ★★:会話
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★クリスティーナ★★:驚き
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★クリスティーナ★★:困る
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★クリスティーナ★★:悲しみ1
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★クリスティーナ★★:悲しみ2
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★クリスティーナ★★:怒る
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★クリスティーナ★★:喜び
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★クリスティーナ★★:拍手
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","DB_MO_0000_0008")

	EndPlay()
end


