-- このluaスクリプトは、EA_053_047.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",37,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",-80,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",80,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
PlayActionDirect(Actor003,"to witch_hover_Loop")
SkipDefaultMotion(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
set_pos(Actor001,{ 0.38, 0, -1.2})
set_pos(Actor002,{ 1.4, 0, -1.25})
set_pos(Actor003,{ -0.7, -0.02, -0.8})
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
set_pos(Ef_0001,{ -1.2, 0.1, -0.05})
set_scale(Ef_0001,{1.2,1.2,1.2})
--※ヴェルナルス配置は、ティーロノエーを浮遊させている分、
--顔の位置が上がってしまうためにカメラを上げる必要があり、
--背の高いキャラを入れてます。
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101047","001","101047001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("山賊","0032")
-- ▲直接出力

	--★★盗賊★★:クソッ、円卓の騎士め<br>邪魔ばっかりしやがって。次こそは――
	Talk(Actor001,"NPCNAME_0283","speech","N","EA_053_0470003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
on_active(Ef_0001)
wait_time(0.7)
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Surp")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-87,0.38)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor001,0.45,0.4,0.85,0.2,0.5)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ティーロノエー","0010")
-- ▲直接出力

	--★★？？？★★:おー、血気盛んでいいじゃ～ん！
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","EA_053_0470005")

-- ▼直接出力
PlayPartVoiceDirect("ティーロノエー","0002")
-- ▲直接出力

	--★★？？？★★:ねぇ、力貸してあげよっか～
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","EA_053_0470006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("山賊","0015")
-- ▲直接出力

	--★★盗賊★★:あ？なんだテメエは――
	Talk(Actor001,"NPCNAME_0283","speech","N","EA_053_0470007")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ティーロノエー","0048")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★？？？★★:その代わり――アタシにも美味しい想い、させてよね
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","EA_053_0470008")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101047","001","101047001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
