-- このluaスクリプトは、CO_101063_0103.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Daitoshoin")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
bgm_play("BGM_Area_Daitoshoin")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:はい、これ<br>次はキチンと返すように釘も刺しといたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01030002")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ま～、ありがと！ノワールちゃんは顔だけじゃなくて性格までいい子ね～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:はは、どうも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01030004")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:本の状態は、と…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:うん、問題ないわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101063_01030009","CO_101063_01030010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ずいぶん大切に本を扱うんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01030012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:本ってね。１冊１冊に書いた人の想いが込められているの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030013")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:紡がれた言葉の裏側に隠された小さな小さな心の叫びが
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030014")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ときには大勢の人間の心を揺さぶり奇跡を起こすことだってある
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030015")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:そんな『想いの結晶』を変わらぬかたちでほかの誰かに届ける…それが司書という仕事よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:もしもの話だけどその本の状態が悪かったら、彼をどうしてた？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01030019")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:んー、そうねえ…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030020")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:２度と本を読むことができないくらい×××を△△△しちゃうかしら♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030021")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:×××を…△△△！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01030022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ジョーダンよ、ジョーダン
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030023")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ノワールちゃん。騎士として剣術の訓練は怠ってはならないものだろうけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:それと同じくらい本から知識や教養を得ることも重要よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:時間があるときは気軽に大図書院に遊びにきてね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01030027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、また来るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01030028")

-- ▼直接出力
local trustParam = set_communication_acquired("クリスティーナ_コミュランク", "クリスティーナ_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Area_Daitoshoin")
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
