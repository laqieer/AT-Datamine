-- このluaスクリプトは、MA_01104_115.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_weight(Actor001,1.0,0.03,0.6,0.2)
CameraEX_1 = set_camera({3.26917,1.083,-0.82035,0,298.3912,0,22})
CameraEX_2 = set_camera({2.34352,1.09079,-0.34097,0,297.188,0,22})
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX_1 = 2.7
gaussian_end_CameraEX_1 = 3.5
gaussian_max_radius_CameraEX_1 = 1.5
gaussian_start_CameraEX_2 = 1.4
gaussian_end_CameraEX_2 = 3
gaussian_max_radius_CameraEX_2 = 1.5
lookoj = create_object("kara")
set_pos_object(lookoj,1.936,0,-1.44)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003, Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor004, Actor002, "J_Head")
lookat_weight(Actor004,1.0,0.03,0.7,0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005, Actor002, "J_Head")
lookat_weight(Actor005,1.0,0.03,0.7,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ランスロット★★:昨日の襲撃を収めるため<br>ガウェインとラグネルは公欠だが──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_1150001")


	--★★ランスロット★★:皆には変わらぬ<ruby=それ>日常</ruby>を過ごして欲しい<br>円卓は日常を守るためにある、来月には──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_1150002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット、まだだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1150004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ノワール？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_1150005")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.6)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.6)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.6)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.6)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:まだウレリーが来てないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1150006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:ノワール、まって
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_1150007")


	--★★テロップ★★:「ワタシも<br>いつかこうなるのかな」
	Talk(Actor006,"","narration","N","MA_01104_1150009")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ノワール★★:どうして誰も<br>ウレリーのことを話さないんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1150010")

-- ▼直接出力
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor004,1.0,0.03,0.7,0.2)
-- ▲直接出力

	--★★テロップ★★:「誰にも<br>見向きされなくなっちゃうのかなって」
	Talk(Actor006,"","narration","N","MA_01104_1150011")

-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.2)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
 -- reserve_eyesync(Actor001,"Close")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:ウレリーは<br>俺の妹を助けて死んだんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1150012")


	--★★ランスロット★★:ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01104_1150013")


	--★★テロップ★★:「怖いんだ。そういう無関心が」
	Talk(Actor006,"","narration","N","MA_01104_1150014")

-- ▼直接出力
 -- reserve_eyesync(Actor001,"Auto")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.2)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:こんなのってないだろ！？！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1150015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEX_1)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEX_1)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEX_1)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEX_1)
-- ▲直接出力
-- ▼直接出力
on_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ティルフィング★★:ノワール卿
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01104_1150017")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.5)
-- ▲直接出力

	--★★ティルフィング★★:みな、同じ気持ちです
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01104_1150020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういう…ことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1150021")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEX_2)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEX_2)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEX_2)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEX_2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ティルフィング★★:のちほど、お話のつづきを
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01104_1150023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
