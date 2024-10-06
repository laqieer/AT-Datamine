-- このluaスクリプトは、CO_101035_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",5,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_common_look_at(Actor003,Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:いったん休憩にしましょう
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:畑で採れたトマトです<br>おひとつどうぞ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020004")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
se_play("SE_ADV_CO_101035_0902_Eat_Tomato")
wait_time(0.4)
PlayActionDirect(Actor004,"to  Std_Joy")
PlayPartVoice("市民_男2", "喜び")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:…美味しい！このトマト、なんて瑞々しいんだ！
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020006")

-- ▼直接出力
setup_small_camera_start(Camera003)
PlayActionDirect(Actor003,"to  Std_Joy")
wait_time(0.5)
se_play("SE_ADV_CO_101035_0902_Eat_Tomato")
wait_time(0.4)
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:本当ね<br>フルーツみたいに甘いわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020008")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,-5,1)
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:…食べないの？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ああ…食べるよ。うん、食べる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020011")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
set_rot(Actor003,{0,-15,0})
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020012")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それはそうとさ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020014")


	--★★ノワール★★:畑ももとどおりにしたし万が一に備えて柵も作ったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020015")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力

	--★★ノワール★★:リリアーナが羊を飼える日も近いな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020016")

-- ▼直接出力
PlayPartVoice("クレア", "驚き")
-- ▲直接出力

	--★★クレア★★:羊って？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020017")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、実はさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020018")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_rot(Actor003,{0,-40,0})
setup_small_camera_start(Camera003)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "納得")
-- ▲直接出力

	--★★クレア★★:そうそんな計画があったのね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("市民_男2", "落胆")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:すみません。私が畑を踏み荒らしたことが計画の邪魔になってしまいました
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020022")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("リリアーナ", "否定")
-- ▲直接出力

	--★★リリアーナ★★:畑は、また耕し直せばいいだけです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020024")


	--★★リリアーナ★★:それに、命って強いんですよ？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★リリアーナ★★:一度や二度踏まれてしまったくらいじゃ野菜はへこたれません
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020027")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リリアーナ★★:すぐにまた芽を出してすくすく育って実りをもたらします
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:踏まれる前より<br>元気になる子だっているくらいです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020031")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,20,0.5)
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:ねぇ、リリアーナわたし、野菜の種をまいてみたい
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020032")


	--★★クレア★★:命の強さに興味が湧いてきたの
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:はい、イチからお教えします！さっそくやってみましょう！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020034")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
set_pos(Actor003,{1.075,0,-1.302})
set_rot(Actor003,{0,-65,0})
Hide(Actor002)
Hide(Actor003)
set_enable_auto_lookat(Actor001, true)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男2", "落胆")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:命は強い、か
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020036")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:私はバルバロイへの恐怖から連れだった仲間を見捨ててひとりで逃げ出した
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020038")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★東方諸国連合軍兵_下位★★:そんな自分が恥ずかしく、情けなかった
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020039")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
turn_chara(Actor004,40,1)
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:このまま死んでもいいと思っていたのにあなたやリリアーナさんが助けてくれた
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020040")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はなにもしてないよ全部リリアーナが頑張ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020041")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
 setup_small_camera_start(Camera004)
Appear(Actor002)
Appear(Actor003)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{0.35,0,-0.96},1.0)
wait_time(1.0)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:彼女はとても優しく…<br>そしてとても強い女性だ
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020042")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:…そうね、リリアーナは強い
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020044")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
change_face(Actor002,"Normal")
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:あんなに腰を入れてクワを使えるキラーズはそうそういないわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020045")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:きっ、聞こえてますよっ！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はははっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020047")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:私、カレドニアに…故郷に帰ろうと思います
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020049")


	--★★東方諸国連合軍兵_下位★★:足が完全には復調しませんでしたから兵士として働くのは無理でしょう
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020050")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★東方諸国連合軍兵_下位★★:…そもそも一度逃げ出した私を軍は受け入れてくれないはずだ
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020051")

	PlayAction(Actor004,"to  Std_Talk")

	--★★東方諸国連合軍兵_下位★★:だから剣の代わりにクワを持って命の強さを周囲の人間に伝えていくつもりです
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020052")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:リリアーナに教わるといいわ、クワの扱いかた
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020053")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
PlayPartVoice("リリアーナ", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:もう、クレアったら！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020054")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "納得")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:そうですね、ぜひ教えていただきたい
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020055")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★リリアーナ★★:東方諸国連合軍兵_下位さんまで…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","N","CO_101035_09020056")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_09020058","CO_101035_09020059","CO_101035_09020060")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:兵士がだめでも…なんて甘い考えじゃ畑仕事だって成功しない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020062")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:東方諸国連合軍兵_下位さんはそんな気持ちで決めたんじゃないはずです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020063")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★東方諸国連合軍兵_下位★★:きっと戻ってすぐは故郷のみんなから同じことを言われるでしょうね
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020064")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★東方諸国連合軍兵_下位★★:でも、私はバルバロイとの戦いやあなたたちとの出会いで
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020065")

	change_face(Actor004,"Normal")

	--★★東方諸国連合軍兵_下位★★:命の強さと生きることの意味を知りました…それを伝えていきたい
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あんたなら大丈夫そうだな試すみたいなことを言って、ごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020067")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_rot(Actor003,{0,-40,0})
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もクワ扱いはまだまだ半人前だからなリリアーナに教えてもらいたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020069")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
PlayPartVoice("リリアーナ", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:そんなことはないと思いますよノワールさんはもう私以上に…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020070")

-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:ノワールはこれからもあなたと一緒にいたいと言っているのよ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020071")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Joy")
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:えっ！？そ、それって、どういうこと、ですか…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020072")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★クレア★★:どういうことかしらね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_09020073")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:えっとですね、クワを上手に扱うにはまず柄の部分をこうやって握って…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020075")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Normal")

	--★★東方諸国連合軍兵_下位★★:ふむふむ、なるほど力が籠めやすそうですね
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_09020076")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:振りかぶるときはだいたい足の広さを…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020077")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:（乗って来たな、リリアーナ）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101035_09020078")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
lookat_delay_weight_reset(Actor001,1)
lookat_delay_weight_reset(Actor002,1)
lookat_delay_weight_reset(Actor003,1)
set_enable_auto_lookat_all(false)
set_rot(Actor002,{0,-40,0})
set_rot(Actor003,{0,-20,0})
set_rot(Actor004,{0,5,0})
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:休憩はこのくらいにして、作業再開といこうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020080")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はい！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020081")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,90,0.5)
slidemove(Actor003,{4.34,0,-0.96},2.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,90,0.5)
slidemove(Actor004,{3.41,0,-0.75},2.5)
wait_time(2.5)
Hide(Actor003)
Hide(Actor004)
wait_time(1)
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:エクセリアが近々ここに<br>来たいって言ってるんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020083")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エクセリアが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020084")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力

	--★★リリアーナ★★:畑を広くしようと思っているって話したら設計図を用意してくれるって
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020085")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,-40,0.5)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:あと、家畜を飼うことも叶いそうなんですアーサー様が許可をくださいました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020086")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor002,{0,-90,0})
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:忙しくなってきたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_09020087")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:はい！でも…みんなと一緒にいられて毎日楽しいです！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_09020088")

-- ▼直接出力
local trustParam = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")
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
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
