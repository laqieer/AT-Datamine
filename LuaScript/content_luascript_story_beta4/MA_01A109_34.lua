-- このluaスクリプトは、MA_01A109_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",90,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor002,{6.51, 0, 0.82})
set_rot(Actor002,{0, 270,0})
-- ▲直接出力
-- ▼直接出力
 --mob1   = setup_prop_object(10130012)
-- ▲直接出力
-- ▼直接出力
 --mob2   = setup_prop_object(10130012)
-- ▲直接出力
-- ▼直接出力
 --mob3   = setup_prop_object(10130012)
-- ▲直接出力
-- ▼直接出力
 --mob4   = setup_prop_object(10130012)
-- ▲直接出力
-- ▼直接出力
mob5   = setup_prop_object(10130015)
-- ▲直接出力
-- ▼直接出力
mob6   = setup_prop_object(10130014)
-- ▲直接出力
-- ▼直接出力
mob7   = setup_prop_object(10130016)
-- ▲直接出力
-- ▼直接出力
mob8   = setup_prop_object(10130013)
-- ▲直接出力
-- ▼直接出力
mob9   = setup_prop_object(10130016)
-- ▲直接出力
-- ▼直接出力
mob10 = setup_prop_object(10130017)
-- ▲直接出力
-- ▼直接出力
mob11 = setup_prop_object(10130012)
-- ▲直接出力
-- ▼直接出力
mob12 = setup_prop_object(10130017)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{0.909,0,0.249})
turn_lookat(Actor003,Actor001,0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{0.913,0,-1.751})
turn_lookat(Actor004,Actor001,0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{0.911,0,-3.251})
turn_lookat(Actor005,Actor001,0)
PlayActionDirect(Actor005,"to  Std_Worry")
SkipDefaultMotion(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{0.911,0,1.749})
turn_lookat(Actor006,Actor001,0)
PlayActionDirect(Actor006,"to  Std_Sad02")
SkipDefaultMotion(Actor006)
-- ▲直接出力
-- ▼直接出力
set_pos(mob5,{1.911,0,0.249})
-- ▲直接出力
-- ▼直接出力
set_rot(mob5,{0,270,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob6,{1.911,0,-1.751})
-- ▲直接出力
-- ▼直接出力
set_rot(mob6,{0,270,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob7,{1.911,0,-3.251})
-- ▲直接出力
-- ▼直接出力
set_rot(mob7,{0,270,0})
turn_lookat(mob7,Actor001,0)
-- ▲直接出力
-- ▼直接出力
set_pos(mob8,{1.911,0,1.749})
-- ▲直接出力
-- ▼直接出力
turn_lookat(mob8,Actor001,0)
-- ▲直接出力
-- ▼直接出力
set_pos(mob9,{2.911,0,0.249})
-- ▲直接出力
-- ▼直接出力
set_rot(mob9,{0,270,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob10,{2.911,0,-1.751})
-- ▲直接出力
-- ▼直接出力
set_rot(mob10,{0,270,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob11,{2.911,0,-3.251})
-- ▲直接出力
-- ▼直接出力
set_rot(mob11,{0,270,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob12,{2.911,0,1.749})
-- ▲直接出力
-- ▼直接出力
set_rot(mob12,{0,270,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000013)
	Actor001 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リアム", "肯定2")
-- ▲直接出力

	--★★リアム★★:天が選びし　つがいの子らが<br>地に満ち　かつての誓いを果たす
	Talk(Actor001,"NPCNAME_0138","speech","L","MA_01A109_340002")


	--★★リアム★★:天命のみを全うすべく<br>その身を捧ぐ
	Talk(Actor001,"NPCNAME_0138","speech","L","MA_01A109_340003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★リアム★★:招き入れ給え　招き入れ給え<br>再び天に帰ること　どうか慈しみ深く
	Talk(Actor001,"NPCNAME_0138","speech","L","MA_01A109_340004")


	--★★リアム★★:愛し給え　愛し給え<br>我らが同胞　波に抗いし船出まで
	Talk(Actor001,"NPCNAME_0138","speech","L","MA_01A109_340005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★リアム★★:救済の祖　聖なる盟約　崇め尊び<br>穏やかなる魂の旅路をここに祈らん
	Talk(Actor001,"NPCNAME_0138","speech","L","MA_01A109_340006")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130017)
	InitializeLoad_Preload()
	load_duel_scene_preload(101000013)
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
