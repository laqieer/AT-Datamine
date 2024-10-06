-- このluaスクリプトは、EA_053_034.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
turn_lookat(Actor003, Actor005, 0)
turn_lookat(Actor004, Actor005, 0)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor004,"to Run")
turn_chara(Actor004,-80,0.3)
wait_time(0.3)
slidemove(Actor004,-5, 0, 3.88, 1.0)
wait_time(1.35)
PlayActionDirect(Actor004,"to Std_Loop")
Hide(Actor004)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★山賊★★:
	Talk(Actor003,"NPCNAME_0283","speech","N","EA_053_0340002")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Run")
turn_chara(Actor003,-60,0.3)
wait_time(0.3)
slidemove(Actor003,-5, 0, 3.88, 1.0)
wait_time(1.35)
setup_small_camera_start(Camera005)
wait_time(0.8)
Hide(Actor003)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0013")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ガウェイン2★★:街の平和を脅かすつもりなら<br>何度だって相手してやるよ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_053_0340004")

	PlayAction(Actor005,"to  Std_Angry")

	--★★ガウェイン2★★:
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_053_0340005")

-- ▼直接出力


--黒背景に移行
CloseTalkWindow() --疑似バトルならclose_speech_window(
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

Appear(Actor001)
Hide(Actor005)
set_pos(Actor002,CharaPosDuelCommonFormation01_001)
wait_time(0.5)
turn_lookat(Actor001, Actor002, 0)
turn_lookat(Actor002, Actor001, 0)
setup_small_camera_start()

CloseTalkWindow() 

hide_image(BLACK_WHITE_TIME)
lookat_delay_weight_default(Actor001, 1)
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_delay_weight_default(Actor002, 1)
keep_ik_lookat(Actor002, Actor001, "J_Head")
bgm_play("BGM_Area_Acoustic")
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★商人★★:ああ…あんたがいなけりゃどうなってたか<br>おかげで助かったよ！なにかお礼を――
	Talk(Actor002,"NPCNAME_0303","speech","N","EA_053_0340006")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:気にすんなって<br>俺は当たり前のことをしただけなんだから
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0340007")


	--★★ガウェイン★★:それより、今のうちに早く街に戻りな<br>この辺りはもう安全だからさ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0340008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★商人★★:ありがとう…本当にありがとう！
	Talk(Actor002,"NPCNAME_0303","speech","N","EA_053_0340009")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,90,0.35)
wait_time(0.35)
slidemove(Actor002,4.23, 0, 0.53,   2.0)
wait_time(2.00)

PlayActionDirect(Actor002,"to Std_Loop")
CloseTalkWindow()
Hide(Actor002)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:………か～っ！いいねぇ！<br>久しぶりにヒーローらしい仕事が出来たぜ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0340011")


	--★★ガウェイン★★:皆の頼みごとを聞いたり手伝ったりするのも<br>大切なことだってのは分かるけど
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0340012")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0012")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0340013")

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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
