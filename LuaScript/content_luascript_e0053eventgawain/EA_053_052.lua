-- このluaスクリプトは、EA_053_052.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",185,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera002 = SetTemplate("Actor002",160,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
set_pos(Actor001,{5.2,0,-4.23})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{5.791,0,-3.5})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{5.795,0,-8})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera004)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001, 5.2,0,-7.4, 0.8)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002, 5.791,0,-6.6, 1.1)
wait_time(0.6)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-25,0.3)
turn_chara(Actor001,140,0.25)
wait_time(0.25)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor002,150,0.2)
wait_time(0.1)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:コック長…！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0520003")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0021")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★コック長★★:ガウェイン、ノワール…悪い、油断した…
	Talk(Actor003,"NPCNAME_0260","speech","L","EA_053_0520004")


	--★★コック長★★:
	Talk(Actor003,"NPCNAME_0260","speech","L","EA_053_0520005")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:いったい、なにがあったんだ！？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0520006")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★コック長★★:わからねぇ。いきなり食堂に押しかけられて…止めようとしたんだが、奴らものすごい力で…
	Talk(Actor003,"NPCNAME_0260","speech","L","EA_053_0520007")


	--★★コック長★★:
	Talk(Actor003,"NPCNAME_0260","speech","L","EA_053_0520008")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0021")
-- ▲直接出力

	--★★コック長★★:けど、様子がどこか変だった…話もろくに通じやしねェし…
	Talk(Actor003,"NPCNAME_0260","speech","L","EA_053_0520009")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
lookat_delay_weight(Actor002,0.45,0.1,0.85,0.2,1.02)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:盗賊って、ガウェインが戦ったっていう――
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0520010")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0520011")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad02")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0520012")

-- ▼直接出力
voice_play("VO_101009_sp_0005_3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:ガウェイン…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0520013")

-- ▼直接出力
setup_small_camera_start(Camera001)
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.7)
lookat_delay_weight(Actor001,0.45,0.3,0.85,0.2,0.8)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,25,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Angry")
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ガウェイン_004","0035")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0520014")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ノワール★★:ああ。そうだな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0520015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
