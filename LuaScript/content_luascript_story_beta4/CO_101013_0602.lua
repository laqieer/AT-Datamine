-- このluaスクリプトは、CO_101013_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",220,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",-35,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",72,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.7,0.5,0.7,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.7,0.5,0.7,0.2)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:どうした？<br>元気ないみたいだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020002")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:いや、あー…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020003")


	--★★ガウェイン★★:ノワールにはわかっちまうか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ラグネルにもわかるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020006")

-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力

	--★★ガウェイン★★:…ま、わかるだろうな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020007")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガウェイン★★:…ヴェルナルス先生、行っちまっただろ<br>なんか寂しいなって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020009")


	--★★ガウェイン★★:ちょっと前にあった依頼の件も<br>もっとお詫びしとくべきだったと思うしさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_06020012","CO_101013_06020013","CO_101013_06020014")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん。ヴェルナルス先生には<br>もっと色々教わりたかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020016")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:叱られてばっかりだったけどさ<br>先生からは勉強以外のこともたくさん学んだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020017")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:うまく言えねえけど<br>男の生き様みたいなもんをさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悲しいけど<br>ローマは俺たちの敵になったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルス先生とも<br>剣を交える覚悟をしなくちゃ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020021")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:わかってるよ<br>わかってっけどよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020022")

	change_face(Actor002,"Pain")

	--★★ガウェイン★★:わかりたくねーことだってあんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020023")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの件なら叱られてないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020025")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:むしろ<br>「よくやった」って言ってくれてたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020026")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:あの人、優しいからよ<br>気を使ってくれたんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020027")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:…お前も励ましてくれてサンキューな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020028")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ヴェルナルス先生はなんでもできる人だった<br>俺の憧れの存在のひとりだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020030")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:もっともっと教えてほしいこと<br>いっぱいあったのによ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020031")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのさ、ガウェイン<br>ずっと聞きたかったんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020032")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:お前とヴェルナルス先生って<br>昔からの知り合いなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020033")

-- ▼直接出力
 --市民登場のため、カメラを指定
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:それなんだけどさ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020034")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民_男2", "喜び")
-- ▲直接出力

	--★★市民（男）★★:いたいた、兄さんたち！
	Talk(Actor003,"NPCNAME_0187","speech","N","CO_101013_06020036")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あんたは…こないだの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★市民（男）★★:お礼を渡したかったんですが<br>あのとき、みなさんはすぐに行ってしまったから
	Talk(Actor003,"NPCNAME_0187","speech","N","CO_101013_06020039")


	--★★市民（男）★★:本当はなるべく早くここに来るべきところ<br>村の修繕やらでだいぶ遅くなってしまいました
	Talk(Actor003,"NPCNAME_0187","speech","N","CO_101013_06020040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")

	--★★市民（男）★★:申し訳ないです
	Talk(Actor003,"NPCNAME_0187","speech","N","CO_101013_06020042")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:いいっていいって<br>気にすんなよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020043")


	--★★ガウェイン★★:こないだも言ったろ？<br>バルバロイを倒すのは俺たちの仕事なんだから
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "否定")
-- ▲直接出力

	--★★市民（男）★★:そうはいきませんよ<br>私だけでなく皆の命を救っていただいたんです
	Talk(Actor003,"NPCNAME_0187","speech","N","CO_101013_06020045")


	--★★市民（男）★★:これ、大した額ではありませんが謝礼金です<br>私たちの気持ちと思って受け取ってください
	Talk(Actor003,"NPCNAME_0187","speech","N","CO_101013_06020046")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:みんなの金！？<br>ダメだって！修繕やらでこれからも必要だろ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_06020049","CO_101013_06020050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:申し出はありがたいけど<br>ガウェインの言うとおり
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020052")

	change_face(Actor001,"Normal")

	--★★ノワール★★:これはあなたたちで使ってください
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そうさ<br>俺たち金が欲しくてやってるわけじゃねーし
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020054")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★市民（男）★★:いえ、これは村の総意です！<br>もらっていただけるまで、私はここを動きません
	Talk(Actor003,"NPCNAME_0187","speech","N","CO_101013_06020056")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:参ったなあ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020057")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここまで言ってくれてるんだったら<br>断るのはかえって失礼になるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020059")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:もらっておいてもいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020060")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:うーん…<br>ノワールがそこまで言うなら、まあ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020061")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.5)
PlayActionDirect(Actor003,"to  Std_Talk")
wait_time(1.0)
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(1.2)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor003,"to Greet_one")
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
setup_small_camera_start()
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:結局もらっちまったな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020063")


	--★★ガウェイン★★:なあ、ノワール<br>このカネで例の琥珀を買ってもいいか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020065")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、俺もそれを考えてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06020066")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:サンキュ<br>ヴェルナルス先生も許してくれるよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020067")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:じゃ、さっそく宝石屋に行こうぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06020069")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ6_3")
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
