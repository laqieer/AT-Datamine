-- このluaスクリプトは、EA_053_054.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003, {2.03, 0, 4.8})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101047","001","101047001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:まさか、アイツらがバルバロイだったなんて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0540001")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0540002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0540003")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうだった<br>皆、心待ちにしてる――急ごう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0540004")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
bgm_play("BGM_ADV_Serious2")
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,-13.99, 0, 1.7, 4)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,-15.22, 0, -8.5, 4)
wait_time(3)
Hide(Actor001)
Hide(Actor002)
Appear(Actor003)
wait_time(0.1)
setup_small_camera_end()
-- ▲直接出力

	--★★ティーロノエー★★:
	Talk(Actor003,"CHRNAME_NAMELES","speech","R","EA_053_0540008")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(Camera003)
turn_chara(Actor003, 180,0.5)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{1.56, 0, -3.28},3)
wait_time(3)
turn_chara(Actor003, 260,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力

	--★★ティーロノエー★★:
	Talk(Actor003,"CHRNAME_NAMELES","speech","R","EA_053_0540009")

	change_face(Actor003,"Smile")

	--★★ティーロノエー★★:
	Talk(Actor003,"CHRNAME_NAMELES","speech","R","EA_053_0540010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Serious2")
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101047","001","101047001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
