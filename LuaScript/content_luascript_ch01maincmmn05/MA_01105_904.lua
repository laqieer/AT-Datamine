-- このluaスクリプトは、MA_01105_904.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera007 = SetTemplate("Actor007",0.554,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera008 = SetTemplate("Actor008",9.11,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor007,{0.755,0,-12.545})
set_pos(Actor008,{-1.026,0,-10.836})
Hide(Actor007)
Hide(Actor008)
local barubaroi_EfPos = get_pos(Actor007)
local barubaroi2_EfPos = get_pos(Actor008)
Ef_Portal_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_Portal_Enemy_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
set_pos(Ef_Portal_Enemy,{0.76,0,-12.02})
set_pos(Ef_Portal_Enemy_2,{-0.94,0,-10.3})
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Sad01")
	change_face(Actor004,"Sad")

	--★★ガウェイン★★:…あちゃー、降ってきやがった<br>今日は一日中晴れって聞いてたのによ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01105_9040002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★ギネマウア★★:殿下のお召し物が汚れてしまいます<br>どこか雨宿りできる場所はないでしょうか…？
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01105_9040003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Portal_Enemy) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_Portal_Enemy)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Portal_Enemy_2) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_Portal_Enemy_2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor006,0, -153.13, 0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0, -174.945, 0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.04)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0, 169.261, 0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.06)
-- ▲直接出力
-- ▼直接出力
Appear(Actor007)
-- ▲直接出力
-- ▼直接出力
Appear(Actor008)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor008,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor007,0.76,0,-12.02,0.5)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor008,-0.94,0,-10.3,0.5)
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0, -154.644, 0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.04)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0, -168.835, 0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.06)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0, 180.894, 0,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.04)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.06)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor008,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.04)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.06)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラグネル★★:残念だけど<br>のんびりしてる余裕はないみたい！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01105_9040004")

-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:もう！<br>わたしは家の様子を見に行きたいだけなのに！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9040005")


	--★★ギネヴィア★★:パパは移住者は拒まないって言ってたけど<br>さすがにバケモノはお断り！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9040006")


	--★★ギネヴィア★★:わたしが追い出してやるわ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9040007")

	change_face(Actor005,"Anger")

	--★★ギネマウア★★:殿下はあちらでお休みを<br>バルバロイは私が処理してまいります
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01105_9040008")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:心配はいらないわ<br>パパに語ってあげる武勇伝を増やしたいし！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9040009")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ギネマウア★★:しかし、この雨です<br>お召し物が…
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01105_9040010")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:服が汚れちゃったら洗えばいいでしょ！<br>そのくらいの傭兵代は払ってるし！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9040011")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（お、俺が洗うのか…？<br>というか、それは傭兵の仕事か…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01105_9040012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
preload_sound("BGM_ADV_Antagonism")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
