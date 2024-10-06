-- このluaスクリプトは、MA_01A112_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★フレン★★:お揃いが良いとねだられたの、よく
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280002")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★フレン★★:私は違うものがいいと言ったら<br>あの子は泣いた
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280003")


	--★★フレン★★:だから結構仕方なく…合わせてたところあったの<br>この子は私がいなきゃだめなんだと思ってた
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:なのに、「はじめまして」…だあって
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280006")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
lookat_delay_weight_reset(Actor001,0.3)
-- ▲直接出力

	--★★ルーシャス★★:…母上もそうだったよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280008")

-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:？<br>ルーシャスくんの、お母様？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280009")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ルーシャス★★:幼きころ、ローマの所有物であったブリテンで<br>我が家族はバルバロイに貪られた
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280010")


	--★★ルーシャス★★:ユーサーが仕向けたバルバロイだ<br>ブリテンにいたローマ人は一族郎党喰われたよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280011")


	--★★ルーシャス★★:余は母上と大陸に逃げ延びてね<br>命からがらだ、肝を冷やしたよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:だが日に日に<br>母上はおかしくなっていった
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280014")

	change_face(Actor001,"Sad")

	--★★ルーシャス★★:徐々に、だが確実に<br>余のことを忘れていくんだ…まいったよ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280015")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★フレン★★:…お母様のこと<br>好きだったんだ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:いいや？むしろ憎らしかったよ<br>幼き余のことを放り眠りにつく女…母親失格だ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:好きだったんだよ。きっと
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001,0.5,0.03,0.7,0,1)
-- ▲直接出力

	--★★ルーシャス★★:しまいには<br>息子を喰らおうとする母親をか？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280019")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:…お母様は、どうなったの
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280020")

-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.5)
-- ▲直接出力

	--★★ルーシャス★★:今も息災だよ<br>ローマ本国の監獄奥深くでな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:斬っても打っても殺せぬ<ruby=バルバロイ>化け物</ruby>になり果てたのだ<br>当時のローマでは打つ手なしだったのでな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280024")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:いくらローマの兵が優秀とはいえ手を焼いていた<br>我が母ながら申し訳ない限りだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280026")

	change_face(Actor002,"Surprise")

	--★★フレン★★:そんな…ルーシャスくん、君はもしかして──
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:バルバロイに侵された者が至る先は様々だ<br>記憶をすべて失い、獣になり果てる者のほか…
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280029")


	--★★ルーシャス★★:稀に自我を保ち<br>バルバロイと共生できる者もいる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280030")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ルーシャス★★:ライエンスが確かそうであったか…
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280031")


	--★★ルーシャス★★:バルバロイの悪意と同調できたものは自我を保ち<br>その力を行使できるのかもしれんな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280032")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★フレン★★:勉強家だね、ルーシャスくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280033")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:そなたの妹も侵蝕が進み過ぎた<br>傷を縫う代わりにバルバロイは記憶を喰らい…
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:私はただ、一緒にいる
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280036")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:妹の抜け殻を愛でるか<br>つくづく理解に苦しむな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280037")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:ヴェルナルスにも聞いてみたかったものだ<br>奴が愚直に信じ続けた愛国心、興味深くはあった
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280038")


	--★★ルーシャス★★:愛も絆も所詮は言葉。妄想の産物であろう？<br>不完全で、脆く、移ろいやすく、信じるに足らぬ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280039")


	--★★ルーシャス★★:ならばあまねく存在を繋げてひとつする…<br>そんな神たる所業が必要だとは思わんか？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280041")

	change_face(Actor002,"Sad")

	--★★フレン★★:…それを成し遂げたあと<br>神様はひとりぼっち？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:退屈にはなるだろうな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★フレン★★:一緒にいてあげようか、ルーシャスくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280044")

-- ▼直接出力
lookat_delay_weight(Actor001,0.5,0.03,0.7,0,1)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:理解できんな、なぜそうなる？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280045")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:わかりたいと思ったから<br>君のこと
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_280046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.3)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:…神を理解しようとは奇特なことだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_280048")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
