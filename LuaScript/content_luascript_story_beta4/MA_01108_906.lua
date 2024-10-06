-- このluaスクリプトは、MA_01108_906.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_02","111016_02_h")
Include("content_adv_advsmall_111016_02","Template111016_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111016_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111016_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111016_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_002)
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
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101053","001","101053001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★マターヤ★★:あらためまして<br>ようこそ、コルベニック城へ
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","MA_01108_9060002")

	change_face(Actor005,"Sad")

	--★★フィエナ★★:ノワール、大丈夫…？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01108_9060003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、フィエナにも心配かけたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:申し訳ないのだが、お爺様は少し前に<br>薬を飲んでお休みになられたところでな
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01108_9060005")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ガラハッド★★:お目覚めになるまで<br>しばらく待ってもらえるだろうか？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01108_9060006")


	--★★マターヤ★★:長旅で疲れてるだろうし<br>ちょうどいいんじゃないかなー？
	Talk(Actor003,"CHRNAME_MATHAJIM","speech","L","MA_01108_9060007")


	--★★アーサー★★:そうだな<br>お言葉に甘えさせてもらうとしよう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9060008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9060009")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
-- ▲直接出力

	--★★ノワール★★:アーサー、少し出てきていいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9060010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:ああ。この城に来たのは久々なんだろう？<br>懐かしい場所を見て回ってくるといい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01108_9060011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがとう<br>なるべく早く戻るから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9060012")

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
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101053","001","101053001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
