-- このluaスクリプトは、MA_01B112_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_02","111016_02_h")
Include("content_adv_advsmall_111016_02","Template111016_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-93.3,CharaPos111016_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_001)
	Camera002 = SetTemplate("Actor002",-74.9,CharaPos111016_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_002)
	Camera003 = SetTemplate("Actor003",-44.3,CharaPos111016_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_003)
	Camera004 = SetTemplate("Actor004",-46.3,CharaPos111016_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_004)
	Camera005 = SetTemplate("Actor005",25.5,CharaPos111016_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111016_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111016_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_006)
	Camera008 = SetTemplate("Actor008",-43.7,CharaPos111016_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_007)
	InitializeTemplateRandomCamera111016_02()
	InitializeTemplate111016_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","002","101010002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101027","002","101027002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101036","002","101036002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:…静かだな
	Talk(Actor002,"CHRNAME_LANCELOT2","speech","L","MA_01B112_270002")

	open_select_window_tag(Actor001,"Normal","MA_01B112_270003","MA_01B112_270004")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:招き入れようとしているのか<br>ペレス王が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_270006")

	change_face(Actor006,"Normal")

	--★★ガラハッド★★:お爺様は<br>ノワールとランスロットを呼んでいた
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_270007")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ガラハッド★★:玉座でふたりが来るのを<br>待っているはずだ
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_270008")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにかワナがあるかもしれない<br>気を付けて進もう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_270010")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ガラハッド★★:ワナはないと思う
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_270011")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_270012")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ガラハッド★★:お爺様は<br>ノワールとランスロットを待っているから
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_270013")

	goto Block1end

::Block1end::
	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ガラハッド★★:きっと僕らは<br>歓迎されていない
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_270015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:孫の顔を見たくないわけがないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_270016")


	--★★ガラハッド★★:…そういうもの、だろうか
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_270017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★フィエナ★★:そうだよ、絶対
	Talk(Actor007,"CHRNAME_VIENA2","speech","L","MA_01B112_270018")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:それが本当なら………いいな
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_270020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","002","101010002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101027","002","101027002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101036","002","101036002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
