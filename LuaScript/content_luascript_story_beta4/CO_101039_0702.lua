-- このluaスクリプトは、CO_101039_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_007)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それにしても<br>ここまでいがみ合いが長引くとは思わなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020002")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:聞くところによるとね<br>このあいだの一件をきっかけとして
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020003")


	--★★フレン★★:他の陸上部員たちの仲も<br>どんどん険悪になってるんだって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フレン★★:どうにかして<br>またみんなで仲良くする方法はないかなあ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それこそ競技大会がいいんじゃないか？<br>みんなで一致団結するきっかけになる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:それがジーン部長の話だと<br>学園から許可が下りなかったみたい
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020008")


	--★★ノワール★★:たしかに、こんな時期だし<br>競技大会どころじゃないという意見はあるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020009")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:ルーシャスくんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_07020013","CO_101039_07020014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はルーシャスを気にしている場合じゃない<br>陸上部をなんとかする方法を考えないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020016")

	change_face(Actor002,"Surprise")

	--★★フレン★★:あっ！<br>ルーシャスくんならなんとかできないかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020017")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ルーシャスが？<br>うーん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園が許してくれないなら<br>ルーシャスに頼んでみるってのはどうだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020020")

	change_face(Actor002,"Surprise")

	--★★フレン★★:ルーシャスくんに？<br>でも、私たちの頼みなんて聞いてくれるかな
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そこは<br>フレンの頑張りにかかってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020022")

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:私の頑張りに？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020023")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:「ローマの皇太子にできないことはない」って<br>あいつはいつも言ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020025")


	--★★ノワール★★:学園側は無理でも<br>ローマの力で競技大会を開催できるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020026")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:うーん。いいアイデアかもしれないけど<br>みんなが喜んでくれるかなあ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020027")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★フレン★★:ルーシャスくんって、ログレスのみんなから<br>そんなに好感を抱かれてないっていうか
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020028")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★フレン★★:ログレスのみんなだけじゃなくて<br>ローマのみんなからも、その…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020029")

-- ▼直接出力
 --ルーシャス登場
CloseTalkWindow()
EntryWalk(Actor003,Camera003,EntryData110071_05_07,CameraAssetBundleName110071_05,CameraPos110071_05_107)
turn_lookat(Actor001,Actor003,0)
turn_lookat(Actor002,Actor003,0)
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:こちらを見ながらコソコソコソコソ<br>余になにか言いたいことがあるのか
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020031")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えっと、だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020032")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:今、学園中でローマとログレスの人たちが<br>ちょっとぎくしゃくしてるんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:だから、競技大会みたいにみんなで盛り上がれる<br>催し物ができないかなって話してたの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020034")


	--★★ルーシャス★★:すればよいではないか
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020035")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:陸上部の部長が学園に許可を貰いにいったけど<br>無理だったらしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020036")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:ならば諦めろ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:お前なあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020038")


	--★★フレン★★:ねえ、ルーシャスくんの力で<br>競技大会を開催することはできないかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020039")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力

	--★★ルーシャス★★:なぜ余がなんの縁もゆかりもない生徒のために<br>そんな面倒をせねばならぬ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020040")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お前だって今はこの学園の生徒だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020041")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:余はローマの未来のために<br>仕方なくここに滞在してやっているだけだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020042")

-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力

	--★★フレン★★:私、間違ってたね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:ルーシャスくんの力で<br>競技大会を開催できないかな、じゃない
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020045")

	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:ルーシャスくんが競技大会を<br>開催しなきゃならないんだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020046")

-- ▼直接出力
PlayPartVoice("ルーシャス", "怒り")
-- ▲直接出力

	--★★ルーシャス★★:余が開催しなければならぬ、だと？<br>なにを言うかと思えば。まったくバカバカしい
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:余は忙しいのだ。このあいだ説明したとおり<br>ローマに置いてきたものの手配をせねばならん
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020048")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:私にはわかんないけど<br>その置いてきたものは
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020049")


	--★★フレン★★:ルーシャスくんに<br>とってすごく大事なものなんだろうね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:でも、置いてきたものだけじゃなくて<br>これから進む先にあるものも見なきゃダメだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020051")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:飛ぶ気力も失いかけた小鳥の分際で<br>余に説教を垂れるか
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020052")

	change_face(Actor003,"Normal")

	--★★ルーシャス★★:だが、少し興味が湧いた
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:えっ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020055")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:ローマの戦車競技はすばらしい<br>あれはローマが世界に誇る娯楽のひとつだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020056")


	--★★ルーシャス★★:辛気臭いこの学園の生徒どもも<br>あれを見れば活力を取り戻すかもしれぬな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、そこまで大がかりなものを<br>やりたいわけじゃなくてだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020058")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:短距離走とか槍投げとか<br>生徒たちができる競技でいいんだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020059")

-- ▼直接出力
PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:そんなものが盛り上がるのか？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020060")

	change_face(Actor003,"Sad")

	--★★ルーシャス★★:まあ、こんなちっぽけな島国の<br>片田舎に建てられた学園では仕方がないか
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020061")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いちいち<br>ひとこと多いヤツだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020062")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:そうだ。余を楽しませたものには<br>特別に褒美を出そう。ならば皆の士気も高まろう
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:褒美目当てでっていうのは好きじゃないけど<br>たしかに目的のひとつにはなるね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020064")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:競技大会、協力してくれるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020065")

	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:そこの小鳥が言っていたからな<br>余にしかできぬことだと
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020066")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:ただし、条件がある
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_07020069","CO_101039_07020070")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まさかお前…またゲームに挑戦しろとか<br>言うんじゃないだろうな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020072")

	change_face(Actor001,"Sad")

	--★★ノワール★★:今はそんな悠長なことを<br>やっていられる状況じゃないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020073")

-- ▼直接出力
PlayPartVoice("ルーシャス", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:粗忽者め<br>人の話は最後まで聞け
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020074")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>俺はなにをすればいい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020076")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:ノワールくんだけじゃないよ<br>私も協力するから！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020077")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:当然<br>そなたらふたりへの条件だ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020078")

	goto Block2end

::Block2end::
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:陸上部で起きている<br>ローマとログレスの諍いを収めてみせろ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020080")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、それを収めたいから<br>競技大会をだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020081")


	--★★ルーシャス★★:無理というなら<br>この話はなかったことでいいな？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020082")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:うう…人の弱みに付け込んでえ…！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020083")

	PlayAction(Actor002,"to  Std_Angry")

	--★★フレン★★:わかった！<br>やればいいんでしょ、やれば！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020084")

-- ▼直接出力
PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力

	--★★ルーシャス★★:そう<br>やればいいのだよ、やれば
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020085")


	--★★ルーシャス★★:楽しみにしておいてはやるが<br>あまり余を待たせるなよ？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020087")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力

	--★★ルーシャス★★:余は「時の浪費」が嫌いなのでな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_07020088")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
--turn_chara(Actor002,150,0)
setup_small_camera_start()
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:条件付きだけど<br>ルーシャスが競技大会を開催してくれそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07020090")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:部長にも教えてあげないとね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07020091")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ7_3")
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
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
