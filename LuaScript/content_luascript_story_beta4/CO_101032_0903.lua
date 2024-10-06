-- このluaスクリプトは、CO_101032_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor003,"J_Head")
lookat_weight(Actor005,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Painful2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","002","101013002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101032","001","101032001")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ここがオークニー諸島かガレスの生まれ育った城があるんだよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:うん。でも、父さんたちが亡くなってからみんな散り散りになってしまった
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030003")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ご、ごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ガレス★★:いや、いいんだ大丈夫だよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030006")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力

	--★★ガレス★★:城の近くにアーキペラゴ牛を飼育している農家さんがあったはずだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030007")


	--★★ガレス★★:肉と牛乳を分けてもらえないかちょっと話をしてくるよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030008")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:ノワールはここで待っていてくれ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030010")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★リオネス★★:あっ、待ってくれガレスあたしも行くぞ
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","CO_101032_09030011")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
Hide(Actor005)
Appear(Actor002)
change_face(Actor001,"Normal")
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
keep_ik_lookat(Actor001,Actor002,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力

	--★★ガウェイン★★:まさかこんなところで会うとはな
	Talk(Actor002,"CHRNAME_NAMELES","speech","N","CO_101032_09030013")

-- ▼直接出力
wait_time(0.2)
setup_small_camera_start()
--ガウェイン,CHRNAME_GAWAIN @名前変更
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_09030015","CO_101032_09030016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェイン！<br>会いたかった、話を…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030018")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ガウェイン★★:死にたくねーなら近寄るな慣れ合うつもりはない
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030019")

	change_face(Actor002,"Pain")

	--★★ガウェイン★★:…今日はお前を殺るつもりもねーけどな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにしに来た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030022")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:随分といい目つきになったじゃねーかあいつらを殺した甲斐があったよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030023")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:今さら友情だのなんだの甘っちょろいこと抜かすつもりはなさそうだな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030024")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:たまには里帰りでもと思ったんだがよそんな気分じゃなくなっちまったな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030026")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレスも来てるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:知ってるよ離れたところから見てた
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:会って行かないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030030")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:なんで俺があいつに会う必要があるよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030031")


	--★★ノワール★★:ナイトカジキを手に入れたんだほら、お前が食べたがってた魚
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ガレス、張り切ってるぞお前のために腕によりをかけるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030033")


	--★★ノワール★★:それからメインディッシュに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030034")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:うるせえなァッ！！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030035")

-- ▼直接出力
 --ガレス＆リオネス登場のため、カメラ固定
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ガウェイン★★:状況分かって言ってんのか？俺が食うわけねーだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030036")

	change_face(Actor002,"Pain")

	--★★ガウェイン★★:食えるわけねーだろッ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "激怒")
-- ▲直接出力

	--★★ガウェイン★★:馴れ馴れしく話かけてくんじゃねー！もっと敵対心剥きだしで来いよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030038")


	--★★ガウェイン★★:じゃねーと俺…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030039")


	--★★ガレス2★★:そうやってすぐ<br>余計な一言を言いかけちゃうんだから
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101032_09030040")

-- ▼直接出力
 --ガレス＆リオネス登場
CloseTalkWindow()
Appear(Actor003)
Appear(Actor005)
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:昔話に花を咲かせすぎたか、俺としたことが
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030042")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガレス★★:俺としたことがじゃない兄さんだからこそだよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030043")


	--★★ガレス★★:兄さん、本当はわたしたちと戦いたくないんだろう？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030045")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:兄さんだけじゃないアーサーだって本当は戦いたくないはずだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Pain")

	--★★ガレス★★:わたしたちはわかってる！だから、戻って来てよ兄さん…！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030047")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:うるせえッ！今さらどのツラ下げて戻れるんだよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030048")


	--★★ガウェイン★★:お前らがあの人の気持ちをどこまでわかってるってんだ！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Pain")

	--★★ガウェイン★★:チッ！お前らといると調子狂うぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030051")

	change_face(Actor002,"Serious")

	--★★ガウェイン★★:あの人の迷惑になるようなことはしたくねー今日のところは消えるぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030052")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ガウェイン★★:…追いかけてくんなよ今の俺は手加減ができねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101032_09030053")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor002)
Camera003 = setup_small_camera_resetting(Actor003,CharaPosDuelCommonFormation01_006,CameraPosDuelCommonFormation01_006)
Camera005 = setup_small_camera_resetting(Actor005,CharaPosDuelCommonFormation01_005,CameraPosDuelCommonFormation01_005)
turn_lookat(Actor003,Actor001,0)
turn_lookat(Actor005,Actor001,0)
setup_small_camera_start()
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガレス★★:…兄さん、泣いてた
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_09030057","CO_101032_09030058")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんな口ぶりだったけどガウェインはガウェインだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030060")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悩んで、叫んで、泣いてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030061")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Normal")

	--★★ガレス★★:こんな言いかたは変かもしれないけど兄さん、全然変わってないよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030062")

-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガレス★★:変わったけど、変わってないよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うん、そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030064")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺たちは道を違えてしまったもう戦うしかないんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030066")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガレス★★:兄さんと戦いたくなんてないよ…
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030067")

	change_face(Actor003,"Sad")

	--★★ガレス★★:話してわかった兄さんは優しいままだもの
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030068")

	goto Block2end

::Block2end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレス、リオネス今日のところは帰ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030070")


	--★★ノワール★★:ここでガウェインに会ったことはみんなには黙っておいてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030071")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガレス★★:うん
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★リオネス★★:わかったぞ
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","CO_101032_09030073")


	--★★ノワール★★:そういえばアーキペラゴ牛はどうなったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030074")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:バッチシ！肉も牛乳もたくさんもらえたよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030075")

-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リオネス★★:農家のおばちゃんガレスの顔見たら泣いて喜んでた！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","CO_101032_09030076")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうか、それはよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_09030077")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガレス★★:母さんのミートパイの美味しさにほっぺた落ちちゃうはずだぞ♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030078")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力

	--★★ガレス★★:…みんな、な！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","CO_101032_09030079")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor003, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor003, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_ADV_Painful2")
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","002","101013002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101032","001","101032001")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
