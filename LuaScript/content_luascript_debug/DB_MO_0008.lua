-- このluaスクリプトは、DB_MO_0008.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★リオネス★★:会話
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0001")

	PlayAction(Actor001,"to  Std_Surp")

	--★★リオネス★★:驚き
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★リオネス★★:困る
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0003")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★リオネス★★:悲しみ1
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0004")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★リオネス★★:悲しみ2
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0005")

	PlayAction(Actor001,"to  Std_Angry")

	--★★リオネス★★:怒る
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★リオネス★★:喜び
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0007")

	PlayAction(Actor001,"to  Std_Appl")

	--★★リオネス★★:拍手
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","DB_MO_0000_0008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エクセリア★★:会話
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0001")

	PlayAction(Actor002,"to  Std_Surp")

	--★★エクセリア★★:驚き
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★エクセリア★★:困る
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0003")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エクセリア★★:悲しみ1
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0004")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★エクセリア★★:悲しみ2
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0005")

	PlayAction(Actor002,"to  Std_Angry")

	--★★エクセリア★★:怒る
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0006")

	PlayAction(Actor002,"to  Std_Joy")

	--★★エクセリア★★:喜び
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0007")

	PlayAction(Actor002,"to  Std_Appl")

	--★★エクセリア★★:拍手
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DB_MO_0000_0008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★リリアーナ★★:会話
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0001")

	PlayAction(Actor003,"to  Std_Surp")

	--★★リリアーナ★★:驚き
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★リリアーナ★★:困る
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★リリアーナ★★:悲しみ1
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★リリアーナ★★:悲しみ2
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★リリアーナ★★:怒る
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0006")

	PlayAction(Actor003,"to  Std_Joy")

	--★★リリアーナ★★:喜び
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0007")

	PlayAction(Actor003,"to  Std_Appl")

	--★★リリアーナ★★:拍手
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","DB_MO_0000_0008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★フィエナ★★:会話
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0001")

	PlayAction(Actor004,"to  Std_Surp")

	--★★フィエナ★★:驚き
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0002")

	PlayAction(Actor004,"to  Std_Worry")

	--★★フィエナ★★:困る
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★フィエナ★★:悲しみ1
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0004")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★フィエナ★★:悲しみ2
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0005")

	PlayAction(Actor004,"to  Std_Angry")

	--★★フィエナ★★:怒る
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0006")

	PlayAction(Actor004,"to  Std_Joy")

	--★★フィエナ★★:喜び
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0007")

	PlayAction(Actor004,"to  Std_Appl")

	--★★フィエナ★★:拍手
	Talk(Actor004,"CHRNAME_VIENA","speech","L","DB_MO_0000_0008")

	EndPlay()
end


