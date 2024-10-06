-- このluaスクリプトは、CO_101028_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.85,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.85,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:おっ待たせ～よしよし、ノワールもいるね！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:さっきガラハッドに声をかけられてな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力

	--★★ガラハッド★★:姉上、それでひらめいたこととはいったいなんだろうか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:そのことについてなんだけどノワールの協力が絶対に必要なんだよねえ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_02020008","CO_101028_02020009","CO_101028_02020010")
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
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:フィエナの頼みならなんでも聞くつもりだ<br>遠慮せずに言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020012")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:たっのもし～い！さすがノワールだね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020013")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:お、おい！そんな安請け合いしていいのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:んー…内容にもよるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:だいじょーぶ、だいじょーぶノワールにとってもイイコトだからさ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020017")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:…きっと
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020018")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:（あまり大丈夫そうじゃないな…）
	Talk(Actor002,"CHRNAME_GALAHAD","mind","L","CO_101028_02020019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:（フィエナのあの笑顔…嫌な予感がする）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_02020021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ！き、今日はランスロットに呼ばれてたんだすぐ行ったほうがいいかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020022")

-- ▼直接出力
PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:そうなの？ランスロットなら、さっきそこですれ違ったよ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020023")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★フィエナ★★:アーサー王と会議って言ってたから急ぐ必要はないと思うな、うん
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020024")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ぐっ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020025")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ノワール、諦めろ…こうなった姉上からは逃げられない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020026")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Appl")
-- ▼直接出力
PlayPartVoice("フィエナ", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:それじゃー、フィエナちゃんの計画発表～はくしゅはくしゅ～
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020028")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力

	--★★フィエナ★★:題して「プリンセスデビュー・プロジェクト」！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020030")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:プリンセス…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:デビュー…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020032")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:ガラハッドがもっと女の子らしくなれるように『お姫様』である私がレッスンしてあげる！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020033")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ガラハッドは女の子らしくなろうとは考えていないのですが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020034")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:そんなこと言って、制服姿を褒められてまんざらでもなかったんじゃないの～？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020035")

-- ▼直接出力
PlayPartVoice("ガラハッド", "照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そ、それはまた別の話では
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ま、もうレッスンの内容は決めてあるから、ヨロシク！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ガラハッド★★:姉上ぇ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020039")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:フィエナが女の子らしさを教えるだって？『お姫様』であることは間違いないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020040")

-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:はいそこ、うるさ～い
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:でもそれって俺が手伝えるものなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020042")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:あ、ノワールは一緒にいるだけでオッケーだよ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020043")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それならいいか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020044")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:カンタンに受け入れすぎじゃないか！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020045")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.7)
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…姉上、それはガラハッドにとって本当に必要なことなのでしょうか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020047")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力

	--★★フィエナ★★:あれ？あんまり乗り気じゃない？？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フィエナ★★:せっかくの学園生活なんだしもっと女の子を楽しんでほしいなって
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020050")

	open_select_window_tag(Actor001,"Normal","CO_101028_02020052","CO_101028_02020053")
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
	change_face(Actor001,"Smile")

	--★★ノワール★★:やってみたらいいじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020055")

	change_face(Actor001,"Normal")

	--★★ノワール★★:フィエナだってガラハッドのことを思って考えてくれたんだろうしさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020056")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:う…ふたりがそこまで言うなら…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020057")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:や、やれるだけやってみよう、かな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020058")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺もガラハッドの女の子らしいところ<br>もっと見てみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020060")

	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろん、ガラハッドが嫌じゃないならだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020061")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:し、しかし…女の子らしいというのは
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020062")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そんなによいものなのか…？ガラハッドはもう恥ずかしくてたまらない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:少なくとも俺はいいと思うし新しい自分を発見できるかも知れないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020064")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:むう。そこまで言われて断っては騎士の名折れか覚悟を決めよう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020065")

	goto Block2end

::Block2end::
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:それじゃあ、さっそく次回からビューティープリンセス・プロジェクト開始ね！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_02020067")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:さっきとプロジェクト名が違わないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_02020068")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…ノワール、いちいち突っ込んでいたら体がもたないぞ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:…早くも気が重い…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_02020071")

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
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
