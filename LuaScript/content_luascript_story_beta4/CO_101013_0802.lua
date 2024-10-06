-- このluaスクリプトは、CO_101013_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",290,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.4, 0.08, 0.7, 0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4, 0.08, 0.7, 0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ダメだ、いねえ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020002")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:このあいだも<br>見つけるまでにかなり時間がかかったしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:諦めずに探してみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:…ああ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…どうした？<br>トムのために頑張るんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020006")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そうなんだけどよ<br>なんかさ…ダメだな、俺
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020007")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺みてーに<br>大したことできねーヤツが
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:アーサー様とかヴェルナルス先生みてーな<br>ヒーローになんのはムリなのかな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020009")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:俺がなんでもできると思ってるのか？
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101013_08020010")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor003)
Appear(Actor004)
--アーサー,CHRNAME_ARTHUR @名前変更
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:えっ？アーサー様？<br>なんで？なんでこんなとこにいるんすか！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力

	--★★アーサー★★:ハラごなしに少し散歩しようと思ってな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:少しって距離じゃないでしょう、ここは
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:細かいことは気にするな！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020015")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★アーサー★★:それでさっきの話の続きだが<br>俺が本当になんでもできると思っているのか？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_08020018","CO_101013_08020019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたはリーダーシップもカリスマ性もあって<br>さらに剣術も相当な腕前ときてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020021")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたをヒーローと思ってる人間は<br>ガウェインだけじゃないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ノワール、よくわかってるじゃねーか…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020024")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:おいおい！<br>おだてても今はなにも出せないぞ？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020025")

	change_face(Actor004,"Smile")

	--★★アーサー★★:帰ったらマーケットの屋台でおごってやるが<br>…それでいいか？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうやって<br>ときどき調子に乗りすぎることを除けばな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:お、おいおいノワール！<br>わかっててもそんなこと言うんじゃねーよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020029")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★アーサー★★:ガ、ガウェインもそう思ってるわけだな…<br>ちょっぴりショック…
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:思っていない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020032")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ちょっ！？<br>お前、バカ…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020033")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★アーサー★★:自分から言ったことではあるんだが<br>面と向かって言われるとさすがにヘコむな…
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020034")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★アーサー★★:俺はお前たちが思っているような<br>できた人間じゃないぞ？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020036")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:人並みに悩むし<br>お前たちの支えがないとなにもできない
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020037")


	--★★アーサー★★:そばにいるだけで周りの人間を元気にできる<br>お前を羨ましいと思うことだってある
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:アーサー様が俺を？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020039")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ああ、そうさ<br>だからこそお前を円卓に入れた
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020040")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:こ、光栄です！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020041")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:俺はヒーローなんかじゃない<br>もっと相応しい人間がたくさんいるさ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020043")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヒーローってさ<br>本当になんでもできないとなれないのかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020045")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:お前、なにが言いてーんだ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:思い描くヒーロー像って人によって違うし<br>どんな人に憧れるかも人それぞれだと思うんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020047")


	--★★ノワール★★:ガウェインは<br>なんでもできるヒーローに憧れてたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020048")


	--★★ノワール★★:俺は<br>ヒーローめざしてガムシャラに走って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ときどき失敗もするけど、みんなに好かれる<br>そんなガウェインがカッコイイと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020050")

	change_face(Actor001,"Normal")

	--★★ノワール★★:お前のなかの<br>ヒーローらしさとは少しズレてるかもだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020051")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:だからといって<br>お前らしさを否定することはないんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020052")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ヒーロー像はひとつじゃない…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020053")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:そうだよ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_08020054")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:みんななにかしら憧れをもってるけどさ<br>追いつこうとするだけじゃ真似でしかないよね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_08020055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラグネル★★:追いつこうとしてもがいて<br>新しい自分を見つけたときに
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_08020056")


	--★★ラグネル★★:憧れの存在を超えて<br>今度は誰かに憧れてもらえるようになる
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_08020057")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:あたしはいいと思うな<br>前しか見てないヒーローがいたってさ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_08020058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:それにさ<br>家族を大事にしたいって言ってる兄貴は
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_08020060")

-- ▼直接出力
PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:妹にとっては<br>十分すぎるほどにヒーローだと思うよ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_08020062")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:まったく、どいつもこいつも<br>お節介で困るぜ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020064")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お節介でいったら<br>お前にかなうヤツはなかなかいないと思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020065")

	change_face(Actor004,"Smile")

	--★★アーサー★★:………
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020067")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:ああ、そうだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020068")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★アーサー★★:せっかくだから<br>お前たちにひとつ相談したいと思っていたんだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020069")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:相談？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08020070")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:もちろん、俺たちでよければ喜んで！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08020071")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:詳しくは円卓の間で話したい<br>一度学園に戻ろう
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08020072")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ8_3")
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
