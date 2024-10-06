-- このluaスクリプトは、MA_01B112_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-106.9,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:魔女に愛想をつかされたな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "笑い")
-- ▲直接出力

	--★★ヴェルナルス★★:御謙遜を…<br>身を引いたのはルーシャス様でしょう
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01B112_040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:継承者の選択が運命を決定づけたのだ<br>余がローマへ帰らざるを得ないこともな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040004")


	--★★ルーシャス★★:バルバロイのはらわたを覗けなくなった時点で<br>余が夢見た平和への道は途絶えた
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040005")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ルーシャス★★:魔女が群れのためでなく<br>個のために働くとはそれも誤算であった
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040006")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ヴェルナルス★★:…？あれらはバルバロイという群体のために<br>動いているように見えましたが…
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01B112_040007")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力

	--★★ルーシャス★★:バルバロイ自体はそうであろうがな<br>魔女姉妹どもはそこまで殊勝ではない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ルーシャス★★:…魔女が余らの力を必要とせぬなら──
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040009")


	--★★ルーシャス★★:糧や贄がこれ以上なくとも<br>ブリテンを喰らい尽くせる算段があるということ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040011")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定3")
-- ▲直接出力

	--★★ルーシャス★★:ならばそれもいい
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040013")


	--★★ルーシャス★★:ログレスが過去の罪に呑まれて消えるまで<br>大陸から眺めるのも一興だ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040014")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ヴェルナルス★★:そうなればバルバロイが海を渡ってきましょう<br>…明日は我が身です
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01B112_040015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:それは愉しみだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040016")


	--★★ヴェルナルス★★:…ルーシャス様、貴方は──
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01B112_040017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:わかったことがある<br>前々から薄々感じてはいたが確信に変わったよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040018")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:やはり、愛は身を滅ぼすな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01B112_040020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
