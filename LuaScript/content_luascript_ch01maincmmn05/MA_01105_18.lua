-- このluaスクリプトは、MA_01105_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight(Actor001, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺はついてきてよかったのか？<br>そういえば
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180002")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:つっ、なっ、ンンッ？<br>なんの話？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180004")


	--★★ギネマウア★★:ケイ先生へ直談判する前の話でしょう<br>ノワール様へ「ついてこないで」と仰せでした
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_180005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…反省したのよ。ちゃんと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:「ノワールの良心につけこんでる」なぁんて<br>皇太子殿下に言われたら、そりゃあ…さあ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01105_180009","MA_01105_180010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:だけど結局引っ張りまわされているよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:だから「ついてこないで」って言ったの！<br>だけど心細いの！わかってよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180013")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Sad")

	--★★ギネマウア★★:無茶です殿下<br>そんな心情まで察してもらおうとは
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_180014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わーかってるわよ、ごめんなさいね！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺がついていきたかったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180017")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:メーワクでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180018")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:迷惑なわけないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180019")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…ほんとに？<br>わたし、このままだと大層喜ぶよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180021")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:まーまーご両人！<br>こっからはさ、お互いハラ見せ合ってこーぜ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_180023")

	change_face(Actor003,"Smile")

	--★★ガウェイン★★:ハラ見せなきゃ<br>背中預けらんねーだろ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_180024")

	change_face(Actor006,"Laugh")

	--★★ラグネル★★:わあ～、真理だねー
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_180025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ガウェイン★★:家族のためにしんどい仕事やろうってヤツ<br>みんないいヤツ！ノワールもいいヤツ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_180026")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★ラグネル★★:それは<br>それぞれの家庭の状況にもよると思うなあ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_180027")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:ハナシ聞いてる感じさ、殿下のパパさんも<br>家族のためにしんどい仕事やってくれてたんだろ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_180028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01105_180030","MA_01105_180031")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いい国だったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180033")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だった、なんてヤメテ<br>今も昔もいい国よ、これからもねっ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180034")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★ギネマウア★★:はい<br>キャメリアードはいい国です
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_180035")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いい父さんなんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180037")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうなのそーなのっ、いいパパなの！<br>子煩悩、昼行燈、甲斐性なし！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180038")

	change_face(Actor007,"Sad")

	--★★ギネマウア★★:ほぼ悪口では
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_180039")

	goto Block2end

::Block2end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor002, 0, 0, 0, 0,1.0)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:キャメリアードはね。近くの鉱山から取れる<br>鉱石や宝石の輸出で栄えてたけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180041")


	--★★ギネヴィア★★:わたしが小さい頃に鉱山でトラブルがあって<br>なかに入れなくなっちゃったそうなの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180042")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:おかげでビンボーになっちゃって<br>国民のみんなは離れていっちゃって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:残ってくれた人もたっくさんいたんだけど…<br>貧相で退屈な日々を強いてた、ずっとね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180044")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だからわたし、いつか旅に出て！<br>外のことをいっぱい知って、持って帰りたいのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180045")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:それを、いつか故郷のみんなと話したい<br>帰って来て「やっぱり家が一番」って笑って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180046")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:こんなことがあったのよ！<br>今度はみんなで一緒に行こうねって！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180047")

-- ▼直接出力
set_common_look_at(Actor007,Actor002)
change_face(Actor007,"Sad")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力

	--★★ギネヴィア★★:その土産話に箔をつける飾りが<br>今はノワール──あなたというわけねっ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180049")

	open_select_window_tag(Actor001,"Normal","MA_01105_180051","MA_01105_180052")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ついてきてよかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180054")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にっしっし…♪<br>キャメリアード国民みんなに紹介したげる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180055")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:学園にいるどの生徒とも違う<br>スペシャルな力を持ったヤツだってね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180056")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:「飾り気なくてスミマセン」と<br>お詫びしなきゃな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180058")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そーよ。オシャレなさい！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180059")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:ま。落ち着いたら<br>オシャレのイロハを教えたげるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180060")

	goto Block3end

::Block3end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:旅費もね、今なんとかやりくりしようとしてるの<br>パパが言ってたもん「限られた――」…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180062")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor002, 0, 0, 0, 0,1.0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あれっ、よく、パパが言ってたのよ、確かね？<br>限られた、ナントカは、ナントカに使おうって…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180064")

	open_select_window_tag(Actor001,"Normal","MA_01105_180066","MA_01105_180067")
	if is_select(1) then
		goto Block4_1
	elseif is_select(2) then
		goto Block4_2
	end

::Block4_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:「限られた資源は有効に使おう」？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180069")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あ、そうそう！<br>よく知ってるわねノワール
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180070")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:聞き飽きるぐらい聞いてたのに…<br>わたし、なんで？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180071")

	goto Block4end

::Block4_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:まさか…<br>覚えてないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180073")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:聞き飽きるくらい聞いてたもの<br>今日はたまたま曖昧なの、たまたまよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180074")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:たまたま曖昧ってことが<br>あるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_180076")

	goto Block4end

::Block4end::
	change_face(Actor004,"Sad")

	--★★ティルフィング★★:…
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_180078")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.9)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor007, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor007,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor007,"J_Head")
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ギネマウア★★:ド忘れでしょう、殿下
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_180079")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そうよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180080")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★ギネマウア★★:忘れても、聞き直せばいいんです<br>そのための里帰りですからね
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_180082")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうよねえ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_180084")

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
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
