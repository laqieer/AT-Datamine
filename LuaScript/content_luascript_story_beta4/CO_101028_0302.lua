-- このluaスクリプトは、CO_101028_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_005)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
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
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("フィエナ", "気合い")
-- ▲直接出力

	--★★フィエナ★★:女の子らしい話しかたのレッスン！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020002")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力

	--★★フィエナ★★:えーと<br>どんな設定にしようかな…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:時刻は早朝<br>キャメ学に通う女学生ガラハッドちゃんは
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020074")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フィエナ★★:生け花部の朝練のため<br>みんなよりも早く登校しました
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020075")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なあ<br>生け花部の朝練ってなにするんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020076")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★フィエナ★★:するとそこに<br>剣術部のノワールくんが登校してきました
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020077")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:はい、ガラハッド！<br>ノワールくんに女の子らしく挨拶！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020078")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:えっ！？<br>あ、挨拶…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020079")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ノワール、朝から鍛錬か？<br>その姿勢は同じ騎士として称賛に値するな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020080")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドでよければ付き合おう<br>どうだろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020081")

	open_select_window_tag(Actor001,"Normal","CO_101028_03020082","CO_101028_03020083","CO_101028_03020084")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんというか<br>女の子らしくないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020086")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:うぐっ…<br>突然女の子らしくなどと言われてもだな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020087")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:鍛錬の話題を振ったのが<br>よくなかったのだろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020088")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（そういう問題じゃないけどな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_03020089")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大丈夫だ<br>ランスロットに付き合ってもらうつもりだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020091")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ランッ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020092")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そうか<br>お前には最強騎士がついているのだったな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020093")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ガラハッドごときでは力不足だったな<br>すまない…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020094")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:ちょっと、ノワール！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020096")

	change_face(Actor003,"Anger")

	--★★フィエナ★★:（デリカシーとかないの！？<br>ガラハッドが落ち込んじゃったじゃない！）
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020098")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（ご、ごめん、つい…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020099")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ぜひお願いしたい<br>ガラハッドが相手してくれるなら鍛錬も捗るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020101")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そう言ってもらえると<br>誇らしいかぎりだ！ 
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020102")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:同じ道を進む者同士<br>ふだんから切磋琢磨していかねばな！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020103")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:ガラハッドのその勇ましい話しかたは<br>嫌いじゃないけど
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020105")

	PlayAction(Actor003,"to  Std_Talk")

	--★★フィエナ★★:鎧を着てないときは<br>もう少し自然に話してもいいんじゃない？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020106")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに…鎧姿のときは気にならなかったけど制服だとちょっと違和感があるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:う…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020022")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ガラハッドは<br>昔からそんな話しかたなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020107")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…幼少の頃に出会った騎士のひとりが<br>いつも堂々とした振る舞いをしていてな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:彼のようになりたいと思っているうちに<br>気付いたらこんな話しかたになっていた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020024")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020026")

-- ▼直接出力
setup_small_camera_start(Camera003)
PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:ガラハッド…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020027")

-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★フィエナ★★:振る舞いっていえば！<br>話しかただけじゃなく、歩きかたもダメ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020108")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力

	--★★フィエナ★★:スカートを履いてるのに<br>男の子みたいに大股で歩くなんてありえないよ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020109")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:確かに<br>ス―スーするなとは感じていました
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:この格好にふさわしい<br>話しかたと歩きかたを教えてください
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020029")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:うむ、よかろ～！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020031")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力

	--★★フィエナ★★:こういうのは実践あるのみ！ということで…ノワール、お手本を見せてあげて♪
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020032")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんで俺が女の子のお手本を見せるんだ！？<br>フィエナがやればいいだろ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020033")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:第三者の視点が大事なの<br>誰かがカントクしてあげなきゃ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020034")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういうもんか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020035")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:うふふ<br>のわーるさんってば、おじょうずですこと
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020110")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:腿は内向きに歩幅は小さく<br>一緒に歩く人を抜かさない速度で！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020112")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0302_Foot_Elegant")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:こ、こうだろうか…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020113")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0302_Foot_Strong")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:腕の振りが大きすぎるよ！<br>胸も張りすぎ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020114")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:こ、これなら、どうですか…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020115")

-- ▼直接出力
se_play("SE_ADV_CO_101028_0302_Foot_Nomal")
wait_time(1.2)
 --白黒終了フェードアウト
change_face(Actor002,"Sad")
change_face(Actor003,"Normal")
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:あ、歩きにくい…<br>女性というのは歩くだけでこんなに疲れるのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020118")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だいぶ良くなってきたんじゃないか？<br>女の子っぽい。可憐だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020119")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:か、かれんっ…！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020121")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:ガ、ガラハッドは、その、騎士だぞ！<br>騎士に向かって、その、可憐とは、なんだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020122")

	open_select_window_tag(Actor001,"Normal","CO_101028_03020123","CO_101028_03020124","CO_101028_03020125")
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
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッド、女の子らしい話しかたをしないと<br>フィエナが見てるぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020127")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:じーっ…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020128")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ううっ…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020129")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:わ、わたしは、その、騎士でございますから<br>騎士に向かって、その、可憐はないと思いますの
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020130")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:よろしい
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020131")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（よろしいのか？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_03020132")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん<br>でも、ガラハッドを見てそう思ったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020134")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:そ！<br>それは、その、ありがとう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020135")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:ならば、だな…<br>歩きかたを突然変えるのは難しい、から…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020136")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:えっと、その…<br>慣れるまで、付き合ってくれるか…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020137")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:喜んで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020138")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:冗談だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020140")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:冗談だとはわかっていたが<br>面と向かって言われるとショックなものだな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020141")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.8)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:ノワール！<br>デリカシー！デリカシーッ！！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020142")

	goto Block2end

::Block2end::
-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
PlayActionDirect(Actor003,"to Std_Loop")
setup_small_camera_start(Camera003)
change_face(Actor001,"Normal")
change_face(Actor002,"Sad")
change_face(Actor003,"Normal")
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
wait_time(1.0)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Appl")
	change_face(Actor003,"Normal")

	--★★フィエナ★★:というわけで今日のレッスンはここまで！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020068")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ハァ、ハァ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020070")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お疲れさま、ガラハッド<br>最初から比べたら見違えるようだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03020071")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ちゃーんと復習しておいてね！<br>そしたら、また次のレッスンをお楽しみに！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03020072")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:バ、バルバロイとの戦闘よりこれは何倍も大変だ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03020073")

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
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
