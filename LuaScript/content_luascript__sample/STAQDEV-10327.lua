-- このluaスクリプトは、MA_01104_01.xlsm の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_018,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_018)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_014,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_014)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110011_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_003)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor008")
	template1()

end


function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")

		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")
		--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")

	--★★ランスロット★★:では、自己紹介を－－
	Talk_Direct(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01104_010003")


	--★★ノワール★★:…
	Talk_Direct(Actor002,"CHRNAME_NOIR","speech","L","MA_01104_010004")

	EndPlay()
end


