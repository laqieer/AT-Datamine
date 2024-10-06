-- このluaスクリプトは、CO_101014_0905.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
-- ▲直接出力
-- ▼直接出力
on_parent(Ef_0002, Camera003, "", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_0002)
-- ▲直接出力
-- ▼直接出力
set_battlecontroller(Actor001,"fig_axe","AC_TL_Fig_Axe_Idle_Run","ToAbnormal")
-- ▲直接出力
-- ▼直接出力
set_battlecontroller(Actor002,"fig_swd","AC_TL_Fig_Swd_Idle_Run","ToAbnormal")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101014","001","101014001")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("山賊", "苦しみ")
-- ▲直接出力

	--★★山賊★★:いててて…旦那よぉ～話が違うじゃねえか
	Talk(Actor001,"NPCNAME_0198","speech","N","CO_101014_09050002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "悲しみ")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:町に火をつけてドラゴンのウワサを流しゃ大金が転がり込んでくる約束だったろ
	Talk(Actor002,"NPCNAME_0199","speech","N","CO_101014_09050003")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("貴族_男1", "苦しみ")
-- ▲直接出力

	--★★貴族（男）②★★:くそ！あの円卓の騎士のガキどものせいだ
	Talk(Actor003,"NPCNAME_0281","speech","N","CO_101014_09050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101014_0905_Foot_Dragon")
shake_camera(RndCamera090, 0.42, 0.5)
PlayActionDirect(Actor003,"to  Std_Surp")
wait_time(1.0)
shake_camera(RndCamera090, 0.42, 0.5)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,115,0.5)
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")

	--★★山賊★★:あん？なんだこの音？
	Talk(Actor001,"NPCNAME_0198","speech","N","CO_101014_09050006")

-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-120,0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:なんかデケぇ動物が歩いてくるような…
	Talk(Actor002,"NPCNAME_0199","speech","N","CO_101014_09050007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101014_0905_Foot_Dragon")
shake_camera(RndCamera090, 0.42, 0.5)
wait_time(1.0)
shake_camera(RndCamera090, 0.42, 0.5)
setup_small_camera_start()
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
set_animationcontroller(Actor003, "Npc_023_02_StdController", "to Std_Loop")
setup_small_camera_start(Camera003)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-85,0.2)
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
on_active(Ef_0002)
PlayPartVoice("貴族_男1", "驚き")
PlayActionDirect(Actor003,"to  Std_Surp")
SkipDefaultMotion(Actor003)
-- ▲直接出力

	--★★貴族（男）②★★:ドッ…ドラ…！？
	Talk(Actor003,"NPCNAME_0281","speech","N","CO_101014_09050008")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)

se_play("SE_ADV_CO_101014_0905_Stomp_Dragon")
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
PlayPartVoiceDirect("貴族_男1","0044")
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
PlayPartVoiceDirect("山賊","0031")
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor004, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor004, trustParam)
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
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101014","001","101014001")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
