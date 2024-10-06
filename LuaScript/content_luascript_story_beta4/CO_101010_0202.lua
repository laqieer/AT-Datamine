-- このluaスクリプトは、CO_101010_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Comical")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ブレイズ", "挨拶")
-- ▲直接出力

	--★★ブレイズ★★:ランスロット<br>少しいいかの？
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101010_02020002")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,-42,0)
-- ▲直接出力

	--★★ブレイズ★★:今ちょっとした実験をしておって<br>おぬしの力を借りたいんじゃ
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101010_02020003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_02020005","CO_101010_02020006")
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
	change_face(Actor001,"Smile")

	--★★ノワール★★:行って来いよ、ランスロット<br>俺のことは後回しでいいから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020008")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:しかし、先に約束していたのは<br>お前の補習のほうだからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（俺は補習してくれなんて頼んでない…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101010_02020010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:あ、じゃあ<br>今日の補習はなしってことだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ランスロット★★:そうはいかない、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020013")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:ブレイズ先生の依頼を片付けてから<br>しっかりと補習を行う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020014")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ブレイズ★★:ふぉっふぉ！<br>逃げられず残念じゃったのう、ノワール
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101010_02020015")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ブレイズ★★:そこまで大がかりな実験ではないから<br>すぐに解放できるじゃろうて
	Talk(Actor004,"CHRNAME_BLAZE","speech","L","CO_101010_02020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:承知した<br>案内してもらえるだろうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020018")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,20,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:ノワール、すぐに戻る<br>お前は先に準備していてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020020")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor004)
Appear(Actor003)
change_face(Actor001,"Normal")
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:無理に補習してくれなんて頼んでないのにさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020022")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:よう、ノワール！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020024")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ア、アーサー？<br>なにしてるんだ、こんなところで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020025")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:お前の学園生活が<br>順調か見に来たんだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020026")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:ランスロットに<br>ずいぶん絞られてるそうじゃないか！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020028")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★アーサー★★:どうだ？<br>くじけてないか？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020029")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:くじけそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:そうか！がんばれ！！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020032")

	change_face(Actor003,"Normal")

	--★★アーサー★★:それはそうとな。久々に会った<br>兄弟子の教師姿はどうだ？新鮮だろう？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020033")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:新鮮っていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020034")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんか、変な感じだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020035")

	change_face(Actor003,"Surprise")

	--★★アーサー★★:ほう？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020036")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:昔から真面目ではあったけど<br>あんな先生みたいな感じじゃなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020037")


	--★★ノワール★★:俺の知ってるランスロットとはちょっと違う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "納得")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:なるほどなるほど
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020039")

	change_face(Actor003,"Normal")

	--★★アーサー★★:かつての姿とのギャップがすごくて<br>落ち着かないんだな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あの…アーサー
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020041")


	--★★アーサー★★:うん？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020042")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:教師としてのランスロットは…<br>どんな感じなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020043")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:ふむ。教師としてのランスロットか…<br>そうだな…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020044")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:『最強騎士』の名に恥じない実力で<br>先生役もしっかりこなしてくれているな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020045")


	--★★アーサー★★:自分の担当はもちろんのこと
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020046")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:他の教師連中が忙しいときなんかは<br>代理で教壇に立ってもらったりもしている
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020047")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:代理で？<br>そんなことができるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020048")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:ああ！あいつは剣術はもちろん<br>語学、史学、軍事講話、キラーズ学もこなす
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:専門外であろう芸術の授業まで担当したと<br>聞いたときはさすがの俺も舌を巻いたな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020050")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:完璧超人かよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020051")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:さらに<br>いつでも冷静でカッコイイと評判だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020052")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:熱い視線を送る女子生徒もあとを絶たない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020053")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:べ、別にそういうのはいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、確かに…<br>ランスロットは昔からなんでもできたからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020056")

	change_face(Actor001,"Sad")

	--★★ノワール★★:知らないことでも<br>一度聞いたら理解してたし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020057")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:落ち着きがあって、物怖じもしなくて…<br>俺なんかよりはるかに全然大人だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020059")

-- ▼直接出力
bgm_play("BGM_ADV_Comical")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("アーサー", "納得")
-- ▲直接出力

	--★★アーサー★★:ほぉ～
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020061")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだよ、ニヤニヤして…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020062")

	change_face(Actor003,"Normal")

	--★★アーサー★★:いや、お前にはそう見えるのかと思ってな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020063")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:どういう意味だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020064")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:そうかそうか<br>アイツも弟弟子の前では格好つけてるんだなぁ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020066")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor002,Camera002,EntryData110011_04_05,CameraAssetBundleName110011_04,CameraPos110011_04_105)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:すまない、ノワール<br>待たせたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020068")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-80,0.5)
wait_time(0.5)
keep_ik_lookat(Actor002, Actor003, "J_Head")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:アーサー？<br>こんなところでなにを
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020070")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:おお、ランス<br>もう用事は済んだのか
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020071")


	--★★ランスロット★★:…？なんだ、そのニヤけた顔は
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020073")

-- ▼直接出力
PlayPartVoice("ランスロット", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ランスロット★★:ノワールになにか<br>余計なことを言ったんじゃないだろうな？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020075")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_02020077","CO_101010_02020078")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:別に<br>俺はなにも聞いてないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020080")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:ああ、言ってないぞ！<br>少ししかな！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020082")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:的中したようだな、嫌な予感は…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020084")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聞いたぞ<br>女子生徒にモテモテだそうじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020086")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺の授業は女生徒には少々難しいようでな<br>質問に来る者が多いんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020088")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:丁寧にわかりやすく、と心掛けているつもりだが<br>ついつい熱が入ってしまうことがあってな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020089")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:皆には申し訳なく思っている<br>反省するばかりだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020090")

	change_face(Actor003,"Surprise")

	--★★アーサー★★:（こ、こいつ…）
	Talk(Actor003,"CHRNAME_ARTHUR","mind","L","CO_101010_02020091")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（気づいてない…！）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101010_02020092")

	goto Block2end

::Block2end::
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:まぁまぁ、許せ許せ<br>悪いことは言ってないさ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020094")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:まったく…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020095")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そろそろ戻ったらどうだ、アーサー<br>こんなところで遊んでいる暇はないだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020097")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力

	--★★ランスロット★★:ケイにまた怒られても知らないぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020098")

-- ▼直接出力
PlayPartVoice("アーサー", "否定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★アーサー★★:おっと、そうだな<br>確かにこれ以上の長居はしないほうがよさそうだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020099")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:それでは、俺は退散するぞ<br>ふたりとも頑張れよ！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","CO_101010_02020100")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
lookat_delay_weight_reset(Actor002 , 0)
turn_chara(Actor002,20,0)
wait_time(0.5)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:なぁ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020102")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02020103")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:………いや、なんでもない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020104")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…待たせてしまったな<br>さっそく今日の補習を始めるぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02020106")


	--★★ノワール★★:（…もしかして、照れてるのか？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101010_02020107")

-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
