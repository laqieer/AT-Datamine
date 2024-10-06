-- このluaスクリプトは、CO_101063_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera003 = SetTemplate("Actor003",140,CharaPos114031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_008)
	Camera004 = SetTemplate("Actor004",142,CharaPos114031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_004)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
SetOffset(Actor001,0.2,0,0)
SetOffset(Actor002,0.2,0,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:えーと本を譲ってくれるお屋敷は…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08030002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:たしかあっちね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08030003")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:う、うわっ！なんだこの本の量！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:この蔵いっぱいってこと？…ええっ！隣と隣の蔵にもあるの！？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08030006")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:とてもふたりで持ち切れる量じゃないわね…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08030008")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:また今度、日をあらためて<br>有志を募って引き取りに来ましょう
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08030009")

-- ▼直接出力
 --ノワールとクリスティーナ退場
 --モブ登場
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor001)
Hide(Actor002)
Appear(Actor003)
Appear(Actor004)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊", "笑い")
-- ▲直接出力

	--★★山賊★★:ここか？家主がおっ死んだ家ってのは
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","CO_101063_08030011")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("市民_男1","0048")
-- ▲直接出力

	--★★市民（男）★★:金目のモンがたんまり眠ってるにおいがすらぁ大勢集めてこねえとな。へっへっへ…
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","CO_101063_08030012")

-- ▼直接出力
local trustParam = set_communication_rankup("クリスティーナ_コミュランク", "クリスティーナ_親密度")
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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
