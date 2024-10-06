-- このluaスクリプトは、EA_003_063.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_02","111091_02_h")
Include("content_adv_advsmall_111091_02","Template111091_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-173,CharaPos111091_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_002)
	Camera002 = SetTemplate("Actor002",-166,CharaPos111091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111091_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111091_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111091_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111091_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_008)
	Camera007 = SetTemplate("Actor007",4.41,CharaPos111091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_001)
	Camera008 = SetTemplate("Actor008",8.6,CharaPos111091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_001)
	Camera009 = SetTemplate("Actor009",21.9,CharaPos111091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_001)
	InitializeTemplateRandomCamera111091_02()
	InitializeTemplate111091_02()
-- ▼直接出力
set_pos(Actor007,{-0.16, -1.05, -15.99})
set_pos(Actor008,{-1.08, -1.05, -15.46})
set_pos(Actor009,{-2.09, -1.05, -16.07})
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemy", false, true)

set_pos(Ef_0001,{-0.43, -0.1, -15.33})
set_rot(Ef_0001,{0,-28.2,0})

Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemy", false, true)

set_pos(Ef_0002,{-1.03, -0.1, -14.91})
set_rot(Ef_0002,{0,12.4,0})

Ef_0003 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemy", false, true)
set_pos(Ef_0003,{-2.59, -0.1, -16.07})
set_rot(Ef_0003,{0,-138.5,0})
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor007,0)
turn_lookat(Actor004,Actor007,0)
turn_lookat(Actor005,Actor007,0)
turn_lookat(Actor006,Actor007,0)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-0.859, 0.32, -12.972,   0.86, 185.3, -0.00399,   26.35839})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({-2.54, 0.87, -12.69,   4.22822, 76.3552, 0.00983,   26})
-- ▲直接出力
-- ▼直接出力
CameraEx_03 = set_camera({-1.73, 0.74, -12.4,   0.86, 71.60004, 0,   26})
-- ▲直接出力
-- ▼直接出力
Ef_0004 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_LightSword_Slash", false, true)
set_pos(Ef_0004,{-1.2, 0.27, -12.94})
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEx_01)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_3D("101001","004","101001004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","005","101011005","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
hide_image(1.0)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング","気合い")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ティルフィング★★:ハアアアッ！
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0630001")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
 wait_time(0.5)
on_active(Ef_0004)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_0001)
on_active(Ef_0002)
on_active(Ef_0003)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
Hide(Actor008)
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
change_face(Actor001,"Normal")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,CharaPos111091_02_002[4],0.5)
wait_time(0.3)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,240,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
turn_lookat(Actor003,Actor001,0)
turn_lookat(Actor006,Actor001,0)
turn_lookat(Actor004,Actor001,0)
turn_lookat(Actor005,Actor001,0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:…これで、悪しきものの気配は消えました
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0630003")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
set_enable_auto_lookat_all(false)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン","挨拶")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ディナタン★★:これで、もう大丈夫なの？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0630004")

-- ▼直接出力
PlayPartVoice("ティルフィング","肯定3")
-- ▲直接出力

	--★★ティルフィング★★:時が経てばまた、バルバロイの脅威は現れるかもしれませんが
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0630005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ティルフィング★★:ですが…しばらくの間はもう奪われる恐れはないでしょう
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0630006")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディナタン★★:…そっか、よかった
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0630007")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-2.44,0.86,-12.67,6)
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:………きれい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0630008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Surprise")

	--★★ノワール★★:ん？どうした、ギネヴィア
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0630009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:…ううん。なんでもない自分のセンスの良さを噛み締めてただけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0630010")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力

	--★★テロップ★★:限られた資源を――
	Talk(Actor010,"telop","narration","N","EA_003_0630011")

-- ▼直接出力
setup_small_camera_start(CameraEx_03)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…有効に使いすぎでしょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0630013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_LightSword_Slash", false, true)
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(111091)
	InitializeCharacter_3D_Preload("101001","004","101001004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","005","101011005","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111091_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
