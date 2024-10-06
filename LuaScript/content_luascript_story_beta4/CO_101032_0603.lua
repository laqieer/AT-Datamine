-- このluaスクリプトは、CO_101032_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_002)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:よーし、目的地に着いたたくさん釣るぞ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06030002")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_start(Camera002)
change_face(Actor002,"Sad")
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:…釣れなかった……かかる気配すらなかった…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06030004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定3")
-- ▲直接出力

	--★★リオネス★★:近くにいた釣り師のオッサンに聞いてみたけど
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_06030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リオネス★★:ナイトカジキの旬ってもうちょっと先らしいぞ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_06030006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_06030008","CO_101032_06030009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:旬じゃないんじゃ釣るのは難しい諦めよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06030011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:他の食材にしないか？ガウェインの好物なら俺も少しはわかるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06030012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:ダメだ！一番食べたいものじゃないと意味がないんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06030013")

	change_face(Actor002,"Anger")

	--★★ガレス★★:釣れるまで何度だって挑戦する！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06030014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そこまで珍しい魚とは知らなかった無策で来すぎたかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06030016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:日をあらためないか？もう少しナイトカジキについて調べたほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06030017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガレス★★:…うん、それがよさそう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06030018")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ナイトカジキの詳しい釣りかたについて大図書院で調べてみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06030020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:うん。お願いだ、ノワール
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06030021")

	change_face(Actor002,"Sad")

	--★★ガレス★★:今日のところは帰ろう、ふたりとも…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06030023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス", "悲しみ")
-- ▲直接出力

	--★★リオネス★★:ガレス…
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_06030024")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ6_4")
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
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
