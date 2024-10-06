-- このluaスクリプトは、CO_101028_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:以前やった女の子らしい歩きかたの自主練をしておきたいんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:続ける決心がついたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:途中で投げ出すのは騎士として恥ずべき行為だからな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020004")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ガラハッドらしいなよし、俺もとことんまで付き合うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020005")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ガラハッド★★:すぅ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020057")

-- ▼直接出力
PlayPartVoice("ガラハッド", "気合い")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:見ていてくれ、ノワール！<br>…いや、見ていてくださいませ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020058")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ああ<br>（話しかたも一応努力はしてるみたいだな）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020059")


	--★★ガラハッド★★:腿は内向きに歩幅は小さく！<br>一緒に歩く人を抜かさない速度で！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020060")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0302_Foot_Elegant")
wait_time(1.5)
-- ▲直接出力

	--★★ガラハッド★★:腕の振りは小さく！<br>胸も張らず！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020061")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0302_Foot_Elegant")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:お、おお…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020062")

-- ▼直接出力
wait_time(0.5)
 --白黒終了フェードアウト
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ふう…どうだ<br>女の子らしく、なっているか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_07020009","CO_101028_07020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だいぶよくなったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020012")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そうか！そう見えるか！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020013")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ただ、力んでいるのが自分でもわかるこれでは疲れてしまって長時間歩けないな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:回数を重ねていけばそのうち自然に歩けるようになるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、今の歩きかたを見ればフィエナもきっと喜ぶと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020017")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:本当か！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020018")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:姉上をがっかりさせてしまったぶんできるところから取り戻していきたいんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ノワールのお墨付きなら安心して披露できる
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020020")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:見たところひとりでかなり練習したんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:空いた時間に少しずつな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:こういった訓練の類は苦手ではないコルベニック城にいた頃、いつもやっていたから
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_07020026","CO_101028_07020027")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:努力家なんだな、ガラハッドは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020029")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ガラハッドが努力家？うーん、そうなのだろうか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020030")

-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:でも、姉上やお爺様の喜ぶ顔を想像するとどんな苦労にも耐えられる気はするな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020031")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:騎士の訓練とフィエナのレッスンどっちが大変に感じる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020033")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そう言われると返答に困るな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020034")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:騎士の訓練は身体が悲鳴をあげるこのレッスンは心が悲鳴をあげる
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020035")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:大変の度合いがまるで違う気がする
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020036")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:こうしてやってみて感じたんだが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドは女の子らしい振る舞いが<br>嫌いなわけではないようだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ただ、騎士として相応しいのかという思いが恥ずかしさにつながり
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020040")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:その結果、身体が思うように動いていなかったそんな気がする
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020041")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:騎士としての相応しさ、か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020042")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:変な意味ではないんだけどひとつ聞いていいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:構わないが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:憧れた騎士がいたってのは<br>このあいだ聞いたけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020063")


	--★★ノワール★★:ガラハッドが騎士を目指した理由ってなんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:姉上やお爺様をはじめとした<br>コルベニック城のみんなを守るためだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:僕に居場所をくれたみんなをな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020049")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:へ、変だろうか？分不相応だろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020051")


	--★★ノワール★★:誰かのためになにかをなし遂げたいその想いに相応、不相応なんてないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020052")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:胸を張っていい立派なガラハッドの騎士道だと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020053")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ありがとう、ノワール！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:俄然、やる気が出て来たぞ！もう少し訓練に付き合ってもらえないだろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07020055")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:言っただろ？とことんまで付き合うって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07020056")

-- ▼直接出力
local trustParam = set_communication_rankup("ガラハッド_コミュランク", "ガラハッド_親密度")
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
