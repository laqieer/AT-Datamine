-- このluaスクリプトは、CO_101012_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_004)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
   prop_001    = load_particle("content_prop_10103001", "10103001_PropModel", false, false)
    set_pos(prop_001,{4.0527,0.814,10.581})
    set_rot(prop_001,{0,-89.8,0})
   prop_002    = load_particle("content_prop_10103002", "10103002_PropModel", false, false)
    set_pos(prop_002,{4.0604,0.8525,10.581})
    set_rot(prop_002,{0,-110.8,0})
   prop_003    = load_particle("content_prop_10103003", "10103003_PropModel", false, false)
    set_pos(prop_003,{4.063,0.8904,10.581})
    set_rot(prop_003,{0,-89.8,0})
   prop_004    = load_particle("content_prop_10103004", "10103004_PropModel", false, false)
    set_pos(prop_004,{3.729,0.813,10.611})
    set_rot(prop_004,{0,-207.7,0})
prop_005    = load_particle("content_prop_10106005", "10106005_PropModel", false, false)
    set_pos(prop_005,{3.342,0.813,10.351})
    set_rot(prop_005,{0,-1.6,0})
-- ▲直接出力
-- ▼直接出力
book_hand = setup_prop_object(10103005)
book_hand_offset = {-0.025, 0.014, -0.019,11.96,-2.45,-11.7}

book_hand2 = setup_prop_object(10103005)
book_hand_offset2 = {-0.025, 0.014, -0.019,11.96,-2.45,-11.7}

book_live ={1000,1000,1000}
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Reading")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Reading")
-- ▲直接出力
-- ▼直接出力
on_parent(book_hand,Actor001, "Loc_weapon_constrint_L", book_hand_offset)
on_parent(book_hand2,Actor002, "Loc_weapon_constrint_L", book_hand_offset2)
-- ▲直接出力
-- ▼直接出力
on_active(prop_001)
on_active(prop_002)
on_active(prop_003)
on_active(prop_004)
on_active(prop_005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うむむむむ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:駄目だぁ～<br>全然歌詞が思いつかないよ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:歌詞かぁ…<br>俺もこういうのはからきしだからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ところで、なんでこんなにたくさん本を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020005")

-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:うう…たくさん本を読めば<br>素敵な言い回しとか思いつくかなぁって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020006")


	--★★ディナタン★★:むしろ、いろいろ頭に入れ過ぎて<br>逆にこんがらがっちゃったかも…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020007")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あー…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020008")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:はぁ…<br>歌詞を書くのって難しいんだね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020009")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:おいおい、なにやってんだよおふたりさん<br>大図書院で騒ぐと怖～い司書サマに怒られるぜ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor001, {1.0, 1.0, 0.7, 0.6} , 1)
lookat_delay_weight(Actor002, {1.0, 1.0, 0.7, 0.6} , 1)
keep_ik_lookat(Actor001, マルディサント, "J_Head")
keep_ik_lookat(Actor002, マルディサント, "J_Head")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:マァル！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020013")

	open_select_window_tag(Actor001,"Normal","CO_101012_07020015","CO_101012_07020016","CO_101012_07020017")
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
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺はディナタンに付き合ってるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:はぁ、そうかよ<br>相変わらず仲良し兄妹なこって
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020020")

-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:もう、マァルってばからかわないで<br>兄さんはただ私の手伝いをしてくれてるだけで…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…あ、そうだ。マァルも手伝って！<br>マァルならきっと良い詞を考えてくれるよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020023")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:あ？なんの話だ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルディサントだって人のこと言えないだろ<br>ここで芝居の練習してたって聞いたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020026")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:アタシはいいんだよ！<br>ここはアタシのシマだからな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020027")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、違うだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020028")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:でもあながち間違ってないかも<br>マァルっていっつもここにいるもんね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020029")

-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:まぁな。本がたくさんある場所にいると<br>インスピレーションも沸いてくんだよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020030")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:インスピレーション…<br>実際に書いている人の意見って感じだ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…ねぇ、マァル<br>お願いがあるんだけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020033")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:マルディサント、会いたかった！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020035")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:はあ！？<br>いきなりなに言ってんだ、アンタ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:に、兄さん！？<br>どうしたの急に！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020038")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:マルディサントは文章を書くのが得意だろ？<br>だったら…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020039")

-- ▼直接出力
PlayPartVoice("ディナタン", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…！そっか！さすが兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020040")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★マルディサント★★:おい、なんの話だよ！<br>アタシ抜きで話を進めんなっての！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020041")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あのね…マァル！<br>お願いがあるんだけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020043")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:実はね。療養院のみんなを元気づけるために<br>コンサートを開くことになったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020045")


	--★★ディナタン★★:それでオリジナルの曲を作るつもりなんだけど<br>なかなかいい歌詞が浮かばなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:だからね<br>マァルに手伝ってもらえたら嬉しいんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:ラブレターの返事に続いて、今度は作詞かよ<br>アタシ、歌詞なんて書いたことないんだけど
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020048")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:大丈夫！マァルの書く台詞はどれも心に響くし<br>私たちより絶対作詞センスあるよ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020049")

-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:んなこと言われてもなぁ…<br>そりゃ、オニーサンよりはセンスあると思うけど
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020050")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんで俺限定？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020051")

	change_face(Actor002,"Shy")

	--★★ディナタン★★:お願いマァル！手伝って！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:みんなが元気になって…また頑張ろうって<br>そう思えるような、素敵な歌を作りたいの！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Shy")

	--★★マルディサント★★:…ま、ディーナにそう言われちゃ<br>手伝わねぇわけにもいかねぇか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020054")

-- ▼直接出力
PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力

	--★★マルディサント★★:わかったよ。アタシに任せな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…！ありがとう、マァル！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:歌詞ねぇ～…みんなが元気になって<br>また頑張ろうって思えるような…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020057")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:！キタ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020059")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020060")

	change_face(Actor003,"Laugh")

	--★★マルディサント★★:インスピレーションに決まってんだろ！<br>ディーナの話聞いてたらなんかビビッときた！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020061")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:おい、オニーサン！さっさとペンよこしな<br>アイデアが逃げちまうだろうが！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020062")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わ、わかった！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
set_animationcontroller(Actor003, "Com_f_SitController", "to Sit01_Loop")
SkipDefaultMotion(Actor003)

PlayActionDirect(Actor002,"to Sit01_Loop")
set_pos(book_hand,book_live)
set_pos(book_hand2,book_live)

Camera003 = setup_small_camera_resetting(Actor003,CharaPos110061_02_001,CameraPos110061_02_001)
set_animationcontroller(Actor001, "Chr_002_01_StdController", "to Std_Loop")
Camera001 = setup_small_camera_resetting(Actor001,CharaPos110061_02_004,CameraPos110061_02_004)
set_enable_auto_lookat(Actor001,true)
lookat_delay_weight_reset(Actor001,0.6)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)

-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:…おっしゃあ！！いい歌詞書けた！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020065")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:うん！これ、本当に素敵だよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020066")

-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:ああ、我ながら会心の出来だぜ<br>オニーサンも読んでみるか？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:…本当だ。すごく素敵な歌詞だな<br>歌詞を読んだだけで心が洗われるというか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020069")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力

	--★★ディナタン★★:でしょ！？すごく美しい歌詞だよね<br>マァルの繊細さが歌詞に表れてるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020070")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Shy")

	--★★マルディサント★★:…ディーナの心が綺麗だからじゃねえの？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020071")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:えへへ…<br>ねぇ、私ちょっと歌ってみるね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_07020072")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ノワール★★:おお…即興とはいえ<br>メロディーがのっかると更にグッとくる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020074")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:アタシとディーナが作ったんだから当然だろ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020075")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:この歌詞に見合うような<br>いい曲つけねぇと承知しねぇからな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_07020076")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、わかってるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_07020077")

-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
   load_particle_preload("content_prop_10103001", "10103001_PropModel", false, false)
   load_particle_preload("content_prop_10103002", "10103002_PropModel", false, false)
   load_particle_preload("content_prop_10103003", "10103003_PropModel", false, false)
   load_particle_preload("content_prop_10103004", "10103004_PropModel", false, false)
load_particle_preload("content_prop_10106005", "10106005_PropModel", false, false)
setup_prop_object_preload(10103005)
book_hand_offset = {-0.025, 0.014, -0.019,11.96,-2.45,-11.7}
setup_prop_object_preload(10103005)
book_hand_offset2 = {-0.025, 0.014, -0.019,11.96,-2.45,-11.7}
book_live ={1000,1000,1000}
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
