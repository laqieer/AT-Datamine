-- このluaスクリプトは、MA_01B110_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_005)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116034)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:わたしの推論が正しいか否か<br>そこに意味はないのだけれど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★クレア★★:継承者のキラーズについて仮説を立てたの<br>聞いてもらえると嬉しいのだけれど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020003")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ランスロット★★:まさか推理を披露するために呼んだのか？<br>ヴォールス卿
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_020005")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ボールス★★:まさか<br>お前の身を案じてだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_020007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:伝承は「聖杯がバルバロイを殲滅する」と語る<br>では継承者のキラーズの意義とは？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ボールス★★:武器の整備が終わるまでだ<br>付き合ってやってくれ
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_020010")


	--★★クレア★★:最初の武器が身を挺してまで<br>継承者をGSへと導いたことにはどんな意味が？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020011")

	change_face(Actor002,"Normal")

	--★★クレア★★:わたしの仮説は、こう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:世界の終焉を避けるには<br>聖杯と継承者のキラーズの双方が必要
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020014")


	--★★クレア★★:ふたつが揃って初めて<br>奇跡とやらがもたらされる。どうかしら？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ランスロット★★:その答えを<br>俺が持っていると？
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_020016")

	PlayAction(Actor002,"to  Std_Worry")

	--★★クレア★★:聖杯城で育ち、学園で最強騎士の誉れを得ながら<br>敵軍勢の中から幼馴染を引き揚げ、優遇、厚遇
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020018")


	--★★クレア★★:一歩間違えば非難の的だったはずよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020020")


	--★★クレア★★:だけど、彼は継承者だった<br>なんという幸運、なんという奇跡的邂逅
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:あなたにはまだ…吐き出していない真実がある<br>ノワールにすら語らない話が。それはなに？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020023")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "否定")
-- ▲直接出力

	--★★ランスロット★★:大それた話じゃないさ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_020024")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ボールス★★:…「自分は平気な話」という顔だ<br>最強騎士だからこそ打たれ強くはあるのだろうが
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ボールス★★:向き合うと<br>決めたのではなかったか？
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_020027")

-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:あなたの手を取った継承者と<br>あなたが秘めた真実に
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B110_020028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ああ。そうだよ<br>向き合うために戦う
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_020029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:あとは、立ち向かうだけだ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_020031")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116034)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
