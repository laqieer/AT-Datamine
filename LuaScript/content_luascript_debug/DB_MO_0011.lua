-- このluaスクリプトは、DB_MO_0011.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101053","001","101053001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101054","001","101054001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ルーシャス★★:会話
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ルーシャス★★:驚き
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ルーシャス★★:困る
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ルーシャス★★:悲しみ1
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ルーシャス★★:悲しみ2
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ルーシャス★★:怒る
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★ルーシャス★★:喜び
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★ルーシャス★★:拍手
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ヴェルナルス★★:会話
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ヴェルナルス★★:驚き
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ヴェルナルス★★:困る
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ヴェルナルス★★:悲しみ1
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ヴェルナルス★★:悲しみ2
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ヴェルナルス★★:怒る
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ヴェルナルス★★:喜び
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★ヴェルナルス★★:拍手
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マターヤ★★:会話
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★マターヤ★★:驚き
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★マターヤ★★:困る
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★マターヤ★★:悲しみ1
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★マターヤ★★:悲しみ2
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★マターヤ★★:怒る
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★マターヤ★★:喜び
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★アダン★★:拍手
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★アダン★★:会話
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★アダン★★:驚き
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★アダン★★:困る
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★アダン★★:悲しみ1
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★アダン★★:悲しみ2
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★アダン★★:怒る
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★アダン★★:喜び
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★アダン★★:拍手
	Talk(Actor004,"CHRNAME_ADAM","speech","L","DB_MO_0000_0008")

	EndPlay()
end


