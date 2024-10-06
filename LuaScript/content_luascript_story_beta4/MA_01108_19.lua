-- このluaスクリプトは、MA_01108_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060012)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ブライアン将軍★★:昔だけどよ、聞いたことがあんだ<br>「なんでそんな目立つ格好して戦う？」って
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190002")


	--★★ブライアン将軍★★:守護を任とするから「敵の注目を集めるため」<br>とか言うと思ってたが…まあそれもあるだろうが
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:…父さん、なんて？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_190004")

	change_face(Actor002,"Smile")

	--★★ブライアン将軍★★:「子供が喜ぶ」んだとよ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…え？<br>父さん、俺の前ではそんなこと言ってなかった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_190007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブライアン将軍★★:金なんてえ色は、キズついたら目立つ<br>そしたら怪我がバレて家族が心配する
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190008")


	--★★ブライアン将軍★★:それでも金コートを羽織るってのは<br>「必ず無事に帰る」って誓いの証だ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブライアン将軍★★:母ちゃんの心中は穏やかじゃねえだろうが<br>信じてたんだろうな、その覚悟と力を
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190011")


	--★★ブライアン将軍★★:…あのヤロウ、あんな顔して<br>ガキのゴキゲン取りに必死たあ笑えるぜ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190012")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃあ…、まだ信じていてもいいのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_190014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブライアン将軍★★:そういうことだろうよ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190015")

	change_face(Actor002,"Smile")

	--★★ブライアン将軍★★:おめえらの世話を<br>あと何十年も続けるなんざごめんだ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01108_190017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060012)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
