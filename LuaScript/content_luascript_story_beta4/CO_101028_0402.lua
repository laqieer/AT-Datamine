-- このluaスクリプトは、CO_101028_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
SwitchMob(false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
load_sound("BGM_ADV_Comical")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:姉上。ガラハッドは<br>料理などしたことがないのですが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020002")

-- ▼直接出力
PlayPartVoice("フィエナ", "否定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:ガラハッド、いい？<br>料理は技術じゃない、ハートで勝負なの！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:だから<br>ハートフルプリンセス・プロジェクトなのよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020083")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えーっと、プロジェクト名が…まあいいか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020084")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ということで<br>ノワールの喜ぶお菓子を作ろう！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020004")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は食べる役なのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020005")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:安心してくれ<br>毒を盛ったりはしないつもりだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（毒を盛られたほうが幸せだった<br>なんてことにならないといいけどな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_04020007")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.1)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:ガラハッド！包丁を剣みたいに持たないで！<br>そもそもクッキー作るのに包丁いらないから！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020009")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:そ、そうなんですか<br>料理といえばこれかと
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020010")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
se_play("SE_ADV_CO_101028_0402_Tableware_Break_01")
PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:キャー！お皿が割れちゃった！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:わああ！すみません、姉上！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ちょっと触っただけで割れるなんて<br>お皿がこんなにもろいものだとは…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020014")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0402_Tableware_Break_02")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:わーっ！<br>オーブンの中に生地を投げ入れないで！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020016")

-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:で、でも！高熱のハコのなかへ入れるには<br>こうする以外ないのでは！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_04020019","CO_101028_04020020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッド！<br>落ち着いてやれば大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:わ、わかった！一騎打ちのときの集中を思い出してみる
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020023")

	change_face(Actor002,"Anger")

	--★★ガラハッド★★:すぅぅぅ…はああああっっ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020024")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0402_Tableware_Break_03")
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:だめだめだめーっ！そんなに細かく刻んじゃ食べた気がしないよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:今のうちに逃げ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020028")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0402_Tableware_Panic")
wait_time(1.5)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:すまない、ノワール！包丁がすっぽ抜けてしまった！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020030")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…のはやめておこう、念のため
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020031")

	goto Block1end

::Block1end::
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
template2()
SwitchMob(true)
setup_small_camera_start()
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,true)
setup_template_moveobj_110122_01(4,true)
setup_template_moveobj_110122_01(5,true)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor003,"to Sit01_RH01")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:というわけでなにごともなくかんせーい！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020033")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あっただろう、なにごとも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020034")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:申し訳ないこんなボロボロなクッキーで…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020036")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★フィエナ★★:だ、大丈夫だよ！見た目や味はともかく、大事なのはハート！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:どうだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020038")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えっと、それじゃ…いただきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:（ぐ。これは…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_04020041")

-- ▼直接出力
bgm_play("BGM_ADV_Comical")
-- ▲直接出力

	--★★ガラハッド★★:どうだ…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020043")

	open_select_window_tag(Actor001,"Normal","CO_101028_04020045","CO_101028_04020046","CO_101028_04020047")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:お、おいしいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020049")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:本当か？<br>無理して言ってるんじゃないか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:本当だって！パクパクいけるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020051")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…そう言っている割に手が止まっているように見えるが？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020052")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ハラが減っているときならパクパクいけるという意味だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020053")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:さすがにその嘘を見抜けないほどガラハッドの目は節穴じゃない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020054")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:…でも、気を使ってくれたことには感謝するありがとう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020055")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…うん。ハートを感じたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020057")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…味について言及がないのはつまり、そういうことなんだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020058")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ま、まあいい。味や見た目はともかく今回はハートを伝えることが目的なんだから
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020060")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（そうだっけ？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_04020061")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:そうそう！上出来、上出来、よくできました！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020062")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:変に誤魔化すのも良くないと思うしハッキリ言うけど、まず…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020064")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ああ、やっぱりガラハッドには料理なんて…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020065")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ノ・ワ・ー・ル・く・ん？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:まっ！まずまずじゃないかな！初めて作ったにしてはさ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020068")

-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そ、そうか！<br>それならよかった…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020069")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:それにしても僕はなんて不甲斐ない…！<br>料理ひとつできず、なにが銀卓騎士か！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020071")

-- ▼直接出力
PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:あ～！ガラハッドちょっと手を開いて！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020073")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:え？…あっ、フォークが…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020074")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:うわあー…グンニャリ曲がっちゃってるね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020076")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:すみません…！思わず力んでしまって
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_04020077")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:テーブルマナーの補講も必要かもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020078")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:まあ、手料理はできたってことで！今日のレッスンはここまで～！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020079")

	change_face(Actor001,"Sad")

	--★★ノワール★★:お、俺、ちょっとトイレに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020080")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:クッキーまだたくさんあるからね<br>トイレから戻ったらどうぞ♪
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_04020081")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:フィエナ、マジ悪魔…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_04020082")

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
preload_sound("BGM_ADV_Comical")
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
