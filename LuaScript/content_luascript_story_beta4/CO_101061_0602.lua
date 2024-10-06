-- このluaスクリプトは、CO_101061_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_006)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001, 0.8, 0.05, 0.5, 0.2,0.5)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ふわぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "挨拶")
-- ▲直接出力

	--★★ラロゥ★★:眠そうだね<br>そんなのでちゃんと話聞けるの？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大丈夫だよ<br>ただ、このところちょっと忙しくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:ふーん…一応、聞いておくけど<br>聖杯がらみじゃないよね？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:違うよ。なんでも少し離れた地域で<br>このところ雨が降ってないみたいでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020006")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:そのせいで<br>干ばつの被害が出てる村があるみたいなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020007")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なにか支援ができないか<br>いろいろ検討してるところでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020008")

-- ▼直接出力
PlayPartVoice("ラロゥ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:へぇ…円卓の騎士ってそんなことまで<br>しないといけないんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:戦うことだけが国を守る方法じゃないからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020010")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_end()
Appear(Actor003)
turn(Actor001,0,35,0,0.1)
turn(Actor002,0,321,0,0.1)
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:やっと来たね<br>聖杯の情報、集めてくれた？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020012")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男1", "笑い")
-- ▲直接出力

	--★★市民（男）②★★:へへっ、井戸端会議に場末の酒場<br>いろんな場所で情報集めてきたぜ
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020013")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だいぶ狭い範囲だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そもそも街のなかに<br>聖杯伝説に詳しい人間なんているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020015")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男1", "肯定2")
-- ▲直接出力

	--★★市民（男）②★★:おとぎ話ってのは少しずつかたちを変えて<br>市井に広まっていくもんさ
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020016")


	--★★市民（男）②★★:それを集めて、重なる部分だけを見れば<br>真実につながる
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★市民（男）②★★:…かもしれねえよ
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020018")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:マユツバだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020019")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力

	--★★市民（男）②★★:ま。お陰で俺まで聖杯に詳しくなった<br>古代のお宝ですげーパワーがあるんだって？
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:らしいね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020021")


	--★★市民（男）②★★:夢みたいな話が次々出てきた<br>まさにおとぎ話だな
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力

	--★★ラロゥ★★:アンタの与太話はどうでもいいよ<br>早く聖杯がどこにあるかの情報を教えて
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力

	--★★市民（男）②★★:アホみたいに高い山のてっぺんとか<br>森深くの神殿とかってハナシが出てたな
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020024")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:つまりは<br>行くのが大変な場所ってところかな
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それか行こうとも思わない場所
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020026")

-- ▼直接出力
PlayPartVoice("市民_男1", "照れ")
-- ▲直接出力

	--★★市民（男）②★★:さて<br>そんじゃ、情報料をもらおうか
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "否定")
-- ▲直接出力

	--★★ラロゥ★★:「かもしれない」話に払うお金なんてない<br>本当に見つけられたときに考えてあげるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020028")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("市民_男1", "怒り")
-- ▲直接出力

	--★★市民（男）②★★:このガキ…！
	Talk(Actor003,"NPCNAME_0080","speech","N","CO_101061_06020029")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera001)
end
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ホント、したたかというか<br>口が達者なヤツ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020030")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor003)
turn(Actor001,0,87,0,0.1)
turn(Actor002,0,303,0,0.1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:結局、実のある情報はなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020032")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力

	--★★ラロゥ★★:みんな、聖杯がどんな力をもってるか<br>夢を語っておしまいって感じだろうね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ラロゥは聖杯にどんな力があると思う？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020034")

-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力

	--★★ラロゥ★★:さぁ。わかんないよ<br>噂ならいろいろ聞いたことあるけどね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020035")


	--★★ラロゥ★★:どんな願いでも叶えられる、とかさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020036")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:どんな願いでも…か<br>ラロゥにはなにか叶えたい願いがあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:まぁね<br>誰でもひとつやふたつはあるでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:どんな願いなのか気になるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020039")


	--★★ラロゥ★★:じゃあ、当ててみたら？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020040")

	open_select_window_tag(Actor001,"Normal","CO_101061_06020042","CO_101061_06020043")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大金持ちになりたい、とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020045")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それも悪くないけど<br>ありきたりすぎてつまらないね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020046")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:せっかくなら<br>もっとスケールのでかいやつがいいよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020047")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:意外と世界平和…とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020049")

-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:なんでそう思うわけ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020050")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありきたりな願いなんてつまらないって<br>言うんじゃないかと思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ふうん…ま、そこだけは合ってるね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020052")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで、正解はなんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020054")

-- ▼直接出力
PlayPartVoice("ラロゥ", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:教えない
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020055")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラロゥ★★:オレは当ててみたらって言っただけで<br>正解を教えるなんて言ってないよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020057")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:お前なぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020059")


	--★★ラロゥ★★:情報屋は外れだったけど、ショックはないね<br>最初からそうだろうと思ってたし
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020060")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:むしろ、そんな簡単に在処を突き止められたら<br>こっちとしても面白くないよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:今度は自分の足で情報を追ってみる
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020062")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ<br>こっちも動きがあったら伝えるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラロゥ★★:あ、それと、この前借りた本のことなんだけどさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020064")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:もう読み終わったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020065")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:いや、まだだけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020066")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラロゥ★★:読んでるうちにいくつか疑問に思ったことが<br>あったから、別の本も借りてきてくれない？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020067")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:また！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020068")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:わからないことをそのままにしとくの<br>気持ち悪いんだよね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020069")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:知りたいことはここに書いといたからさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020070")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>クリスティーナさんに聞いてみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020072")


	--★★ノワール★★:あと、前に借りた本はなるべく早く返せよ<br>貸出期限を過ぎたら大変なことになるからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06020073")

-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力

	--★★ラロゥ★★:はいはい
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06020074")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 1
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
