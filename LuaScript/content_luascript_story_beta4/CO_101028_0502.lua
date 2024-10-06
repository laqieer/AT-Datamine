-- このluaスクリプトは、CO_101028_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",270,CharaPos114011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera003 = SetTemplate("Actor004",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor004,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_image("104000080", "content_still_10400008_image", "104000080_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101028","001","101028001")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101036","001","101036001")
	Actor006 = InitializeCharacter_2DOnly("401019","001","401019001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:俺はここで待っているからふたりだけで服を見てくるといいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020002")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:じゃー、行ってくるね！
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020003")

-- ▼直接出力
 --暗転してガラハッドとフィエナを非表示に
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor004)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "喜び")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★フィエナ2★★:きゃ～、このワンピかわいい！あ、この新作もいいかも！
	Talk(Actor005,"CHRNAME_VIENA","speech","L","CO_101028_05020005")

	change_face(Actor005,"Normal")

	--★★フィエナ2★★:ほらほら、ガラハッドも<br>自分の着たい服を選んでみて
	Talk(Actor005,"CHRNAME_VIENA","speech","L","CO_101028_05020006")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド2★★:えっと、じゃあ、これとか…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","CO_101028_05020007")

-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力

	--★★フィエナ2★★:うーん、悪くないと思うけどこういうののほうが似合いそうな気が…あ！
	Talk(Actor005,"CHRNAME_VIENA","speech","L","CO_101028_05020008")

-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★フィエナ2★★:ねえねえ、こういうフリフリたくさんのキュートなドレスはどう！？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","CO_101028_05020009")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガラハッド2★★:そ、そういうのこそガラハッドには似合わないので！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","CO_101028_05020010")

	change_face(Actor005,"Sad")

	--★★フィエナ2★★:あ…そ、そっかこういうの好きじゃないんだったっけ
	Talk(Actor005,"CHRNAME_VIENA","speech","L","CO_101028_05020011")

-- ▼直接出力
PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力

	--★★フィエナ2★★:前にもこんなことあったのに、ごめんね<br>つい浮かれちゃって
	Talk(Actor005,"CHRNAME_VIENA","speech","L","CO_101028_05020012")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド2★★:あ、姉上、これは違うんだ…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","CO_101028_05020013")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:（前になにかあったようだな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_05020014")

-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★フィエナ2★★:大丈夫、次はちゃんとガラハッドの<br>好きそうな服を選ぶから。ね、楽しもう？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","CO_101028_05020016")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド2★★:はい…すみません
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","CO_101028_05020018")


	--★★ノワール★★:（もうしばらくかかりそうだな…少し散歩でもしてくるか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_05020020")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_start(Camera001)
turn_chara(Actor001,210,0.0)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ノワール★★:フィエナ、張り切ってるというか…心から楽しんでいる感じだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020022")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:やっぱり家族にはオシャレな格好でいてほしいものなのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020024")


	--★★ノワール★★:そういえば俺も…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020025")

-- ▼直接出力
PlayPartVoice("市民中年_男1", "挨拶")
-- ▲直接出力

	--★★市民（中年男）★★:さぁさぁ寄ってらっしゃい見てらっしゃい！<br>今日だけのスペシャル価格だよ！
	Talk(Actor006,"NPCNAME_0293","speech","N","CO_101028_05020026")


	--★★ノワール★★:ん？なにか売っているようだなちょっと見に行ってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020027")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
turn_chara(Actor001,270,0.0)
Appear(Actor002)
Appear(Actor004)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★フィエナ★★:もーっ、どこ行ってたの？待ってるって言ってたのにいないんだもん
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020029")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ごめんごめん<br>時間かかりそうだったから散歩に行ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020030")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれ？結局なにも買わなかったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020031")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:あ、ああ。なんというか…まだガラハッドにこの店の服は早い気がして
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020032")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★フィエナ★★:早いとか遅いとかないよ、って言ったんだけどね
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ガラハッドは<br>姉上と一緒に買い物に来られただけで満足です
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★フィエナ★★:ガラハッド…
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020035")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:もう、かわいんだから、この子は！！
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020036")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのさ。ファッションの入門用にこんなアクセサリー、どうだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020038")

-- ▼直接出力
setup_small_camera_start()
ShowImageItem("104000080")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:露天商が売ってたから買ってきたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020039")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:えっ…このアクセサリーを僕に？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020041")

-- ▼直接出力
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_05020043","CO_101028_05020044","CO_101028_05020045")
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
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:似合うと思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020047")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:かわいらしいな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020048")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:でも、これはかわいらしすぎて僕には似合わないんじゃないか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020049")

	change_face(Actor001,"Smile")

	--★★ノワール★★:そんなことないさでなきゃ贈ろうなんて思わない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:そう、か…うん、そうだなありがとう、大切にする
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020052")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:ノワール！ノワールぅ！色男に育っちゃって！このこの～！
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020053")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだよ突然
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020055")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:こういうのが好きかなと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020057")

-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:素朴なデザインで…うん、とても好みだありがとう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020058")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ただ、その…すまないノワールにも気を遣わせたようだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020059")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、気にしないでいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020060")

-- ▼直接出力
PlayPartVoice("フィエナ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★フィエナ★★:へ～、ノワールも成長したんだねえ
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020061")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…どういう意味だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020062")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:落ち込んでるみたいだったからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020064")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:気を遣わせてしまったか…申し訳ない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020065")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★フィエナ★★:ううん、それは私が悪いの！ありがとね、ノワール
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020066")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:素敵なプレゼント、もらえたね
	Talk(Actor004,"CHRNAME_VIENA","speech","L","CO_101028_05020068")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ただ、姉上のレッスンを達成できなかった正直言って自分が情けないです
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020069")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気にしなくていいと思うよ少しずつ慣れていけばいいさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_05020070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:…そうだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_05020072")

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
load_image_preload("104000080", "content_still_10400008_image", "104000080_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101028","001","101028001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101036","001","101036001")
	InitializeCharacter_2DOnly_Preload("401019","001","401019001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
