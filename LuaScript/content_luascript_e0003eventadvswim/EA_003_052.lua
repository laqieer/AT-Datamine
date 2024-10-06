-- このluaスクリプトは、EA_003_052.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",335,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera008 = SetTemplate("Actor008",275,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera009 = SetTemplate("Actor009",150,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{0.085,0,-2.16})
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
keep_ik_lookat(Actor007,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor009, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:よし…これで片付いたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0520002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ルーシャス★★:ああ、つまらんこの程度では気晴らしにもならんな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0520003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:せめて余の目を楽しませる<br>お飾りでもあればよいものを
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0520004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力

	--★★ノワール★★:そういう言い方はやめろよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0520005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("ルーシャス","笑い")
-- ▲直接出力

	--★★ルーシャス★★:これは失礼お友達想いの継承者殿
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0520006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0520007")


	--★★ノワール★★:（…ギネヴィア、大丈夫かな後から来るって言ってたけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_003_0520008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
