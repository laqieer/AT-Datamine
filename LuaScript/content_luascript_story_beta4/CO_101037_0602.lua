-- このluaスクリプトは、CO_101037_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_04","112021_04_h")
Include("content_adv_advsmall_112021_04","Template112021_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_002)
	InitializeTemplateRandomCamera112021_04()
	InitializeTemplate112021_04()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,136,0)
turn_chara(Actor002,52.828,0)
-- ▲直接出力
-- ▼直接出力
 lookat_weight(Actor001,0.9,0.05,0.5,0.2)
 lookat_weight(Actor002,0.8,0.05,0.5,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ラシア★★:おいしい！<br>どうやって作ってるんでしょう、これ…？
	Talk(Actor002,"CHRNAME_RASIA","speech","N","CO_101037_06020002")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	close_cutin()
	change_face(Actor001,"Smile")

	--★★ノワール★★:よかった<br>ようやく笑顔になってくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:えっ？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020004")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ラシア★★:ああ…<br>気を使わせてしまって、ごめんなさい…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101037_06020007","CO_101037_06020008","CO_101037_06020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:コホン<br>騎士たるもの…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020011")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ふふっ<br>女性に優しくするのが務め、ですもんね？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:さ、先に言わないでくれよ…<br>恰好つかないじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ラシア★★:何度も聞かされたので<br>覚えちゃいました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:この店のウワサを小耳にはさんでさ<br>キミを誘おうと思ってたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ありがとう！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020018")

	change_face(Actor002,"Sad")

	--★★ラシア★★:使っている牛乳が違うのかな？<br>それとも発酵させる時間とか温度…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…これについては<br>単純に俺が食べたかっただけなんだ、けど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020021")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:あ、そう、ですか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020022")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020023")

	change_face(Actor002,"Sad")

	--★★ラシア★★:…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020024")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:それにしても本当においしいですね<br>作りかた、教えてもらえないでしょうか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さすがに企業秘密じゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ラシア★★:そうですよね。ヴェルナルス様に<br>作ってあげられたらと思ったんですけど
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:昔からヴェルナルス先生によく作ってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:子供の頃に、戦場から戻られたヴェルナルス様に<br>ヨーグルトを作ったことがあったんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020030")


	--★★ラシア★★:そのときにおいしいと褒められたことが<br>とても嬉しくて…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力

	--★★ラシア★★:それ以来、戦場から戻られるときは<br>必ず用意するようにしていました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へえ…そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020033")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:でも、毎回同じものじゃ飽きちゃいますよね<br>そろそろ変えたほうがいいでしょうか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:どうだろう<br>ヴェルナルス先生に聞いてみたことは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020035")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:実は一度だけ…<br>そのときは変えなくていいと言われました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:じゃあ、変えなくていいんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラシア★★:でも…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:実は俺も傭兵をやってた頃、戦場から戻ると<br>ディナタンがいつも同じスープを作ってくれてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020039")


	--★★ノワール★★:味が変わらないからこそ<br>ほっとするっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:いつもの日常に戻って来たって<br>実感できるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020041")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:もしかすると、ヴェルナルス先生も<br>似たような心境なのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020042")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:そうでしょうか…<br>もしそうなら嬉しいですけど
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020044")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:どうしても気になるならさ<br>それとなく聞いてみたらどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020045")

	change_face(Actor002,"Sad")

	--★★ラシア★★:それは…えっと<br>考えておきますね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020046")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020047")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:そ、そういえば、このあいだ出会った<br>ローマの兵士の方はどうなったんでしょうか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020049")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:受け入れの手続きは<br>ケイがうまくやってくれたようだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020050")


	--★★ノワール★★:力仕事に自信があるってことで<br>少し離れた村の工事を手伝いに行かせたって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:そうなんですね、良かった…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020052")

	change_face(Actor002,"Sad")

	--★★ラシア★★:聞いているかもしれませんが、あのあと<br>他にもローマ兵から投降の申し出があったとか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:兵士だけじゃなく、一般人もチラホラらしい<br>ケイは手続きやらなにやらに大忙しだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020054")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:ルーシャス様やヴェルナルス様は<br>無事なんでしょうか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ローマ軍に大きな動きがあったとは聞かないから<br>無事なんだとは思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020056")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:カレドニア城にいるんじゃないかな<br>…たぶん、ローラも一緒に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020057")


	--★★ラシア★★:無事であってくれるといいんですが…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020059")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:ウワサではルーシャス様たちが<br>カレドニア城を占拠して以来
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020060")


	--★★ラシア★★:バルバロイの数は増すばかり<br>目撃情報も広範囲になってきているそうです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラシア★★:カレドニアから逃げ出せた人は<br>運がいいのだとも言われています
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020062")


	--★★ラシア★★:ヴェルナルス様はとても強いかたですし<br>私の心配なんか不要かもしれない…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:だけど、やっぱり一緒にいたかった<br>ついていくべきだった、と考えてしまうんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020064")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:行こうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020065")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:…どこへ？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020066")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:決まってるだろ、カレドニアに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020067")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力

	--★★ラシア★★:え…ええっ！？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020068")


	--★★ノワール★★:ちょっと様子を見に行くくらいなら<br>大丈夫じゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020069")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ラシア★★:本当に大丈夫でしょうか…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020070")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101037_06020072","CO_101037_06020073","CO_101037_06020074")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:大丈夫<br>なにがあっても、俺がキミを守ってみせる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020076")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:ありがとう、とっても嬉しいです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020077")

	change_face(Actor002,"Smile")

	--★★ラシア★★:ノワールがそう言ってくれると<br>どんなに危険なことも怖くなくなりますね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020078")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルス先生やローラもそうだけど<br>カレドニアの様子が気になる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020080")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当に住人たちが苦しんでいるのなら<br>助けてやらないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020081")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラシア★★:そうですね<br>私たちはバルバロイと戦う力を持つのだから
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020082")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当に大丈夫か、って言われると<br>…ちょっと怖いけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020084")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:キミのために頑張ってみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020085")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:む、無理は<br>してくれなくていいですからね…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020086")

	goto Block2end

::Block2end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:念のため<br>国外へ行く許可をもらったほうがいいかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020088")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラシア★★:そうですね<br>無断で行くのはやめておきましょう
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_06020089")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:じゃあ、日をあらためよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_06020090")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
