-- このluaスクリプトは、CO_101061_0502.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_002)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
 -- turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:アンタの相談<br>なんとなく想像はついてる
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:手を組んで<br>一緒に聖杯を探そうって言いたいんでしょ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:単刀直入に言えばそうなるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020004")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:聖杯は円卓の騎士が探し、護る秘宝だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020005")


	--★★ノワール★★:もしもお前が見つけ出せたとしても<br>自分のものにするのは難しいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020006")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:円卓の奴らに回収されるってこと？<br>その前に換金しちゃえばいいじゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020007")

	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:円卓の騎士を甘く見ないほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:えっ…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…というのは冗談で
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺と一緒なら<br>バルバロイが現れたときに守ってやれる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それは確かに心強いけど<br>オレだって駆け出しじゃない
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020016")


	--★★ラロゥ★★:何度も危険な目をくぐり抜けてきてる<br>バルバロイから逃げ切ったことだってある
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:「守ってやれる」くらいじゃ<br>話に乗ってやれないね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020018")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気になったんだけどさ。ラロゥが<br>聖杯を探し始めたきっかけってなんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:アンタには関係ないでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:関係なくはないだろ<br>友達なんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020022")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:…そんな恥ずかしいセリフ<br>よく本人の前で言えるね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:友達のことを心配するのはふつうだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "悲しみ")
-- ▲直接出力

	--★★ラロゥ★★:ああもう！<br>アンタと話してると調子狂うなあ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ともかく、そっちにも事情があるように<br>オレにだって事情があるんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:オレはひとりで聖杯を探す
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020028")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:うーん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020029")

-- ▼直接出力
wait_time(1.3)
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101061_05020031","CO_101061_05020032","CO_101061_05020033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯を手に入れたあとのことについては<br>いったん保留しないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:とりあえず手に入れないことには<br>なにも始まらない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それまではひとまず協力するってことで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:問題の先送りでしかない気がするけど<br>まあ、そこまでいうなら
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020038")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そこまで言うなら好きにすればいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020040")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ただ、バルバロイを甘く見るなよ？<br>これからも毎回逃げ切れる保証はない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020041")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:脅してもムダ…って言いたいけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020043")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:円卓の騎士のアンタが言うなら<br>ただの脅しじゃないんだろうね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020044")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それにきっと甘く見ちゃいけないのは<br>バルバロイよりも円卓の騎士のほうだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020089")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:…でしょ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020090")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020091")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、こういうのはどうだ？<br>もし聖杯を手に入れられたら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020046")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なるべくラロゥの希望を叶えられるように<br>俺が代わりに円卓の騎士と交渉する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:悪くない条件だね。けどいいの？<br>そんな安請け合いしちゃって
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020048")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレが聖杯を探してる理由を聞いてないのに
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020049")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:悪用するつもりじゃないだろ？<br>そこは信じてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020050")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:盗賊相手に言うこと？<br>ま、悪い気はしないけどさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020051")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:というか、ノワールってば<br>カッコつけてるけどさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020053")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:要は自分だけじゃ見つけられないから<br>オレの力を貸してくれってことでしょ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、それは、違…くはないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020055")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:アンタ、あんまり器用そうに見えないもんね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020056")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ラロゥ★★:やれやれ<br>円卓の騎士って言ってもピンキリなんだね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020057")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:お前なあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020059")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定3")
-- ▲直接出力

	--★★ラロゥ★★:とりあえず、見つけるまでは<br>力は貸すって約束するよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:でもさ。知ってると思うけど<br>盗賊って自分勝手で気まぐれだよ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020061")


	--★★ラロゥ★★:本当に聖杯を見つけたとき<br>オレが抜け駆けしたらどうするの？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:盗賊としての腕前だけじゃない<br>俺はラロゥという人間を買ってるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020063")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:このあいだ、盗んだ財布を持ち主に返したろ？<br>お前は正しい心を持っている、信用できる人間だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020064")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お前と一緒なら聖杯を見つけるのも夢じゃない<br>そう思ってるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020066")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラロゥ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:…毎度毎度、よく真顔でそんなこと言えるよね<br>こっちが恥ずかしくなってくる
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ま、いいや<br>はぐれ者同士、力を合わせて聖杯を探そっか
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020068")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:はぐ…？<br>お、俺ははぐれ者じゃない！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:そう？オレには円卓の騎士のなかで<br>浮いているように見えるけどね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020070")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まったく…可愛げのないヤツだな、お前は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020072")


	--★★ラロゥ★★:悪かったね<br>可愛げがなくて
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020074")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、いや、冗談だって<br>とにかく、これからよろしくな、ラロゥ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020075")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:よろしく。あ、そういえば<br>ちょっと頼みがあるんだけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020077")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020078")


	--★★ラロゥ★★:この前行った大図書院、だっけ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020079")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラロゥ★★:あそこにあった本で<br>読みたいやつが結構あってさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020080")


	--★★ラロゥ★★:オレひとりじゃ入りにくいし<br>ノワールが代わりに借りてきてよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020081")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:いいけど…どの本だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020082")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:ここにタイトル書いておいたから
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020083")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわ、こんなに！？<br>これ全部読むつもりか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020085")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:うん<br>必要な知識だから
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020086")


	--★★ラロゥ★★:とにかく、頼んだからね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_05020087")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、ああ。わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_05020088")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
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
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
