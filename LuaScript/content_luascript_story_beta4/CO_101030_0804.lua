-- このluaスクリプトは、CO_101030_0804.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
Hide(Actor002)
set_pos(Actor001,CharaPosDuelCommonFormation01_105)
set_pos(Actor002,{-2.97,0,0.103})
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Sit10")
wait_time(1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
IN_RUN_2P(Actor001,CharaPosDuelCommonFormation01_005,Actor002,CharaPosDuelCommonFormation01_002)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:トビー！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08040002")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）②★★:う、ううん…
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_08040003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(RndCamera001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Sit10")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:良かった…。あちこちケガをしていますが命に別状はなさそうです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:今日のところはアストラット郷に連れ帰ってあらためて話をしに来ましょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08040005")

-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
