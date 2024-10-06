-- このluaスクリプトは、MA_01C110_42.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110261_43","110261_43_h")
Include("content_adv_advsmall_110261_43","Template110261_43_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110261_43_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110261_43_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110261_43_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110261_43_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110261_43_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_006)
	InitializeTemplateRandomCamera110261_43()
	InitializeTemplate110261_43()
-- ▼直接出力
change_face(Actor002,"Surprise")
change_face(Actor003,"Surprisep")
change_face(Actor004,"Surprise")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110261)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Pain")

	--★★ディナタン★★:うっ…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_420002")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01C110_42_Crowd")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(110261)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	system.PreLoadRequest(CameraAssetBundleName110261_43)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
