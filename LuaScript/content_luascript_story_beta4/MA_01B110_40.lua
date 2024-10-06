-- このluaスクリプトは、MA_01B110_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110131_01","110131_01_h")
Include("content_adv_advsmall_110131_01","Template110131_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",20,CharaPos110131_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_002)
	Camera002 = SetTemplate("Actor002",-15,CharaPos110131_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_005)
	InitializeTemplateRandomCamera110131_01()
	InitializeTemplate110131_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_camera_nearclip(Camera001,1)
set_pos(Actor002,{0.65,0,11.7})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115134)
	Actor001 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:………お祭りをやっていたんだな
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01B110_400003","MA_01B110_400004","MA_01B110_400005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,-85,0.5)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:こんなときだからこそ<br>普通の学生らしくね
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400007")

	change_face(Actor001,"Normal")

	--★★ガラハッド★★:…お祭りは、楽しかっただろうか
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400008")

	change_face(Actor002,"Normal")

	--★★ノワール★★:楽しかったんじゃないか？きっと
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400009")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:………見てみたかったな
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,-85,0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:戦時なのに不謹慎だよな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:そう思ったよ。ガラハッドも
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400013")

	change_face(Actor001,"Normal")

	--★★ガラハッド★★:でも、仲間と気兼ねなく笑える時間というのは<br>希少なんじゃないかとも思った
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400014")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:今だからこそかぎられた時間で<br>楽しく過ごせる場所があるのは、うらやましい
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,-85,0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:祭りで大騒ぎ出来た人たちが羨ましいよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:ガラハッドは、騒がしいのは<br>あまり得意ではないが
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400018")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:仲間と過ごす時間がある人たちは<br>やっぱり…うらやましいな
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400019")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:ひとりで<br>なんでもできると思っていたんだ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400021")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力

	--★★ガラハッド★★:コルベニック城にいた頃<br>外の世界は汚くて取るに足らないと信じてた
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:必要以上に群れることなど汚らわしい<br>かぎられた仲間で高め合うことこそ素晴らしいと
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400023")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:…だけどこうして放り出されて<br>結局ひとりで出来ることは限られていて…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400024")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_No")
-- ▲直接出力

	--★★ガラハッド★★:守るべきものは傍にあったのに<br>ともに戦ってくれる者は近くにいたのに
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400025")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ガラハッド★★:こんなささやかなお祭りを守るために<br>学園の皆は懸命に戦っているのに
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400026")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
-- ▲直接出力

	--★★ガラハッド★★:結局ガラハッドが剣を握ったのは<br>じぶんのためでしかなかった
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:…汚いのは、僕だ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400028")

	change_face(Actor002,"Normal")

	--★★ノワール★★:………俺もランスロットを追って<br>学園に入ったんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor001,100,1)
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:え…？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400031")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ノワール★★:帰る場所をバルバロイに喰われて<br>世話になった人は敵になって
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400032")

	change_face(Actor002,"Normal")

	--★★ノワール★★:本当を知りたくて<br>汚名をかぶって剣を握った
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400033")


	--★★ガラハッド★★:………「二度と家族を喪わないために<br>家族を守り続けるために」
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400035")


	--★★ガラハッド★★:「同じ思いを誰にもさせないために」…？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:俺もガラハッドと同じだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400037")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:同じなものか
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:ノワール。お前は高潔だ<br>継承者としての強さ…ガラハッドは見ていた
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400040")


	--★★ガラハッド★★:お前がコルベニック城に至ったときの戦い<br>多くに支えられ、GSまで至った…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400041")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:目指す先を奪られたと…妬みすら感じた<br>こう思うこと自体、おこがましく…汚い話だ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01B110_400044","MA_01B110_400045")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ノワール★★:妬まれても困るよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400047")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:まったくだ<br>自分勝手で…いつも姉上を困らせる
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400048")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:学園に来てから<br>自分の至らなさに気づかされてばかりだ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400049")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:目指す先が同じなら<br>いっしょに進めばいい
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400051")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:…あ、足を引っ張るぞ<br>ガラハッドは、また…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ノワール★★:…ゆっくり、進もう
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400053")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:…！ノワール…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400054")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ノワール★★:ランスロットはまだ重いなにかを抱えてる<br>俺には明かさない本当を、まだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400056")


	--★★ノワール★★:重荷で歩みが遅いなら…まだ追いつける<br>その荷物だって分けてもらえるはずだから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400058")

	change_face(Actor001,"Normal")

	--★★ガラハッド★★:………綺麗な色だな
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B110_400060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:お前の騎士道の色だ<br>眩しくて、目を引かれる
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400061")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ガラハッド★★:纏う金色が、よく似合う
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_400063")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115134)
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110131_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
