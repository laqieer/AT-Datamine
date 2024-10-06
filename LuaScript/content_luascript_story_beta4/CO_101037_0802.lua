-- このluaスクリプトは、CO_101037_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
Hide(Actor009)
Hide(Actor003)
set_pos(Actor003, {0, 0, -5})
PlayActionDirect(Actor002,"to  Std_Talk")
PlayActionDirect(Actor008,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Painful2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor005,"to  Std_Talk")
wait_time(2.0)
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(1.0)
PlayActionDirect(Actor006,"to  Std_Worry")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
setup_small_camera_start()
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
PlayActionDirect(Actor002,"to Std_Loop")
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
character_in_move_run(Actor003,CharaPos005,1.6,0)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
turn_lookat(Actor001,Actor003,0)
turn_lookat(Actor002,Actor003,0)
set_common_look_at(Actor003,Actor001)
set_common_look_at(Actor002,Actor003)
set_common_look_at(Actor001,Actor003)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor001, false)
SkipOffsetCamera(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フレン★★:いたいた！ラシアにノワール！<br>さがしたんだからーっ！
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020002")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:フレン？どうしたんだ、突然
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020003")

-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フレン★★:カレドニア城の近くまで行ったって<br>聞いたよ！
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020004")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")

	--★★フレン★★:私、我慢してたのに！<br>私だってローラのところに飛んでいきたいのに！
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★フレン★★:どうして私にも声をかけてくれなかったの！？
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、俺が悪いんだ<br>俺がラシアを誘ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020008")

-- ▼直接出力
set_common_look_at(Actor003,Actor002)
-- ▲直接出力

	--★★フレン★★:ローラのこともそうだけど<br>ふたりのことも心配したんだから！
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020009")

-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:フレン…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:よく我慢してるよな、フレン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定")
-- ▲直接出力

	--★★フレン★★:待ってるって約束したからね<br>ローラが帰ってくる場所を守っておかないと
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020013")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:ローラが帰ってくる場所？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020014")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:そう！学園でもローマでもなくって<br>私がいるところがローラの家！
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020015")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:フレン、そろそろ行くよー
	Talk(Actor009,"NPCNAME_0261","speech","N","CO_101037_08020017")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フレン★★:…あれ？もうそんな時間か
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020018")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")

	--★★フレン★★:ふたりともごめん！<br>またあとでね！
	Talk(Actor003,"CHRNAME_FREN","speech","L","CO_101037_08020019")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
set_enable_auto_lookat_all(true)
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
Camera002 = setup_small_camera_resetting(Actor002,{CharaPos005[1],CharaPos005[2],CharaPos005[3],41.3},CameraPos005)
setup_small_camera_start(RndCamera005)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:フレンは相変わらず元気だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020021")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:…カラ元気だと思います<br>ローラと離れ離れで、気が気じゃないはず
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラシア★★:わかるんです<br>昔からの友達だから
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:たしかに…ちょっと寂しそうだったかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020024")

-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:でも、羨ましいな<br>フレンとローラの絆
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…というと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:ふたりは血の繋がった双子で<br>お互いがお互いを支え合っています
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020027")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:ラシアとヴェルナルス先生だって<br>同じだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "否定")
-- ▲直接出力

	--★★ラシア★★:ヴェルナルス様は強いお方だし<br>ローマの大将軍という立場もあります
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020029")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ラシア★★:フレンやローラの関係とは<br>やっぱり違いますよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020030")

-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101037_08020032","CO_101037_08020033","CO_101037_08020034")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園でキミを見かけたときに見せた優しい表情<br>敵地にいながらも手紙を送ってくれた想い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:先生が強くいられたのは<br>ラシアの支えがあってこそだと俺は思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020037")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だから、ラシア。<br>キミはもっと自分の価値に自信をもっていい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020039")

	change_face(Actor002,"Normal")

	--★★ラシア★★:…自信を、もつ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そう<br>先生が戻ってきたときに叱ってやるくらいね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう、先生が言ったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020043")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ラシアは先生のことになると<br>一歩も二歩も身を引いちゃうだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020044")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺にはそれが<br>先生を遠ざけて、距離を取ってるように思える
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020045")

-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:遠ざける…？距離…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020046")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だから先生もキミとどう触れ合えばいいのか<br>迷ってるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020047")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:キミと先生とは家族みたいなものなんだから<br>なにも遠慮することはないんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020048")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ラシアに<br>こんな寂しい想いをさせるなんて！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020050")

	change_face(Actor001,"Anger")

	--★★ノワール★★:ヴェルナルス先生はたしかに強いかもしれない<br>でも、これは許せないな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020051")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:ノワール…<br>ヴェルナルス様を悪く言わないでください…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020052")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ずっと思っていたんだけどさ<br>キミはなにをそんなに遠慮してるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020054")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:前にヴェルナルス様に助けられたって<br>言いましたよね？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020055")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あぁ、確か家が経営難になって<br>お金と引き換えに売られそうになったって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:両親が借金の返済に追われて<br>寝る暇もないほど忙しくしていたとき
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020058")


	--★★ラシア★★:ひとりの男がやってきて<br>こう言いました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020059")


	--★★ラシア★★:「ワタシのもとで働きなさい<br>借金なんかすぐに返させてあげるよ」
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:人買いか…ひどい奴がいるもんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力

	--★★ラシア★★:そうですね。しかも、あとから聞いた話では<br>商品の扱いが悪いことで有名な組織だったそうで
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020062")


	--★★ラシア★★:同業者にすら<br>敬遠されていたみたいです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:とんでもない奴らじゃないか<br>それで、そのあとどうなったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020065")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:父と母は断ってくれました<br>愛する子供を売るなんて、絶対にごめんだって
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020067")

	PlayAction(Actor002,"to  Std_No")

	--★★ラシア★★:でも、それからも経営は苦しくなる一方でした<br>ついには食べるものにも困るようになって…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020068")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★ラシア★★:だから、次に人買いの男が現れたとき<br>私は自分から彼について行ったんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020069")


	--★★ノワール★★:両親には黙って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020070")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:はい…人買いの馬車に揺られながら<br>私は両親とこれまでの自分に別れを告げました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020071")


	--★★ラシア★★:ポケットに入っていた髪留め、<br>大事にしてた綺麗な石、よく食べていた飴…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020072")


	--★★ラシア★★:最後は履いてた靴も投げて…<br>なにもかもを捨て去りました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020073")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…靴まで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020075")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:はい、靴まで
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020076")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:連れて行かれた先には<br>私と同じように買われた子供たちがいました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020078")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ラシア★★:その子たちは周りにいた大人たちに<br>ひどい暴力を振るわれていて…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020079")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラシア★★:私は絶望のあまり泣き出しそうになるのを<br>ただ必死にこらえていました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020080")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そこに駆け付けたのが<br>ヴェルナルス先生だったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020081")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:その通りです。たったひとりで、<br>身の危険も顧みず助けに来てくれました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020082")


	--★★ラシア★★:なんでも両親の苦境を知ったヴェルナルス様が<br>私の家の様子を見に来られて
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020083")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラシア★★:そこで事情を聞いたそうです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020084")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いくら親戚とはいえ、ずいぶん無茶したなぁ<br>先生らしい気もするけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020085")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:本当にそう思います<br>ほんの数回しか会ったことがなかったのに
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020086")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ラシア★★:そんな私のために、命がけで…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020087")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.8)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのあと、家には帰らなかったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020089")


	--★★ラシア★★:子供の私が帰ってもお金がかかるだけで<br>なにも力になれない…そう思ったので
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020090")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:それでヴェルナルス先生に<br>ついて行くことにしたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020091")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はい。両親に事情を説明したうえで<br>しばらくは自分が預かると言ってくださいました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020092")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:聞けば聞くほどすごい男気だな…<br>誰にでもできることじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020093")

-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:私はヴェルナルス様に、一生をかけて<br>返さなければならない恩があるんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020094")

	PlayAction(Actor002,"to  Std_No")

	--★★ラシア★★:そんな私が自分から歩み寄るだとか<br>家族だと思うだなんて、おこがましい…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_08020095")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…それなら聞いてみよう<br>なんてったって先生なんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020096")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:わからないことは教えてくれるはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_08020098")

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
preload_sound("BGM_ADV_Painful2")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
