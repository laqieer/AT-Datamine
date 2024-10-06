-- このluaスクリプトは、CO_101035_1002.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor008")
	template1()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor005,false)
set_enable_auto_lookat(Actor006,false)
prop001=setup_prop_object(10106003)
prop001_offset={-0.15,-0.03,0,0,-30,15}
set_pos(Actor004,{-2.3,0,-0.3})
set_rot(Actor004,{0,80,0})
set_pos(Actor005,{-1,0,1.4})
set_rot(Actor005,{0,115,0})
set_pos(Actor006,{-2.8,0,0.5})
set_rot(Actor006,{0,90,0})
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それで、いいことって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:手紙が届いたんです<br>誰からか、わかりますか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020004")

	open_select_window_tag(Actor001,"Normal","CO_101035_10020006","CO_101035_10020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:その嬉しそうな顔を見れば見当がつくよ<br>マルコさんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020009")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:正解です！<br>まさか手紙をくださるなんて…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020010")

	change_face(Actor001,"Smile")

	--★★ノワール★★:なんて書いてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020011")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:それじゃあ、読みますね？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひょっとして学園の男子から<br>ラブレターをもらった、とか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020014")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:ラッ、ラブッ！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020015")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:私みたいにチビでチンクシャで寸胴の田舎者が<br>そんなのもらえるわけないじゃないですか！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020016")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか？<br>俺はリリアーナのことかわいいと思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020017")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:かっ、かわっ！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020018")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★リリアーナ★★:もう、からかわないでください！<br>マルコさんからの手紙です、読みますよ！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020019")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
on_parent(prop001,Actor002, "J_Hand_L", prop001_offset)
on_active(prop001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:「皆さんお元気ですか」
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020021")


	--★★リリアーナ★★:「厳しい状況ではありましたが<br>私は無事カレドニアへ戻ることができました」
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020022")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★リリアーナ★★:「今は故郷に帰り/小さいですが畑を作りました」
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020023")


	--★★リリアーナ★★:「リリアーナさんの見よう見まねで/いくつか野菜を育て始めています」
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020024")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★リリアーナ★★:「わからないことだらけで失敗続きの毎日ですが/リリアーナさんの言葉を胸にへこたれることなく」
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020025")


	--★★リリアーナ★★:「元気に前向きに生きていこうと思っています/追伸」
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020026")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★リリアーナ★★:「リリアーナさんのトマト、本当に絶品でした/私もトマト栽培に挑戦してみます」
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:…ですって
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
off_parent(prop001)
off_active(prop001)
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:無事に帰れたみたいで良かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力

	--★★リリアーナ★★:えぇ、本当に
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルコさんは/リリアーナのおかげで立ち直れたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020031")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:私ですか？<br>私はなにもしてないですよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:してたよ、俺は知ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020033")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
change_face(Actor002,"Shy")
wait_time(2)
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_10020035","CO_101035_10020036")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どうした？/顔が真っ赤じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020038")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リリアーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:ノワールさんが変なこというからですよ！/…そんなに赤いですか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん、耳まで赤い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020040")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:うう…/いつもトマトをたくさん食べているせいかな…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020041")

	change_face(Actor001,"Smile")

	--★★ノワール★★:（トマトは苦手だけど/真っ赤なリリアーナはイヤじゃないな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101035_10020042")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナは/自分の優しさに気づいてないんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020044")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:優しい…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020045")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そこも無自覚なのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020046")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:誰かに優しくするとか、親切にするなんて/当たり前のことじゃないですか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020047")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…当たり前にできることじゃないよ/やっぱりすごいな、キミは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020048")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
set_rot(Actor002,{0,0,0})
Appear(Actor003)
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
setup_small_camera_start(RndCamera002)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:来る途中で出会ったの/畑仕事を手伝わせてほしいんですって
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_10020050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:本当ですか！？/みなさん、ありがとうございます！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020051")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:これだけ人数がいるなら/畑の拡張を考えてもいいかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020052")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:先に行って<br>畑の場所を教えてくるわね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_10020053")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,90,0.5)
slidemove(Actor003,{6.1,0,0.45},4.5)
wait_time(0.2)
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,90,0.5)
slidemove(Actor005,{6.2,0,1.4},4.5)
wait_time(0.1)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,90,0.5)
slidemove(Actor004,{6.2,0,-0.3},4.5)
wait_time(0.1)
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,90,0.5)
slidemove(Actor006,{4.4,0,0.5},4.5)
wait_time(2)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
Appear(Actor007)
Appear(Actor008)
Camera007=setup_small_camera_resetting(Actor007,CharaPos006,CameraPos006)
Camera008=setup_small_camera_resetting(Actor008,CharaPos007,CameraPos007)
setup_small_camera_start(Camera007)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor007,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ディナタン★★:やっほー、兄さん！リリアーナ！
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","CO_101035_10020055")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:こんにちは、ディナタン/それに、マルディサント、さん…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020056")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★マルディサント★★:アタシは別にいいって言ったのに/ディーナに無理矢理連れてこられてよ
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","CO_101035_10020057")

-- ▼直接出力
PlayActionDirect(Actor007,"to  Std_Talk")
turn_chara(Actor007,70,0.5)
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ディナタン★★:たまには外で日光を浴びるのも悪くないと思う<br>脚本のアイディアも浮かぶかもよ？
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","CO_101035_10020058")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)

	--★★マルディサント★★:…そんなもんかねえ
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","CO_101035_10020060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルディサントはその辺に座ってればいい/労働力として期待してないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020061")

	change_face(Actor008,"Normal")

	--★★マルディサント★★:働くつもりなんかねえっつーの
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","CO_101035_10020062")


	--★★ディナタン★★:マァル、あっちにベンチがあるから
	Talk(Actor007,"CHRNAME_DINATAN","speech","L","CO_101035_10020063")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
set_rot(Actor002,{0,25,0})
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:へいへい
	Talk(Actor008,"CHRNAME_MALADISANT","speech","L","CO_101035_10020064")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor007,"to Wlk")
turn_chara(Actor007,90,0.5)
slidemove(Actor007,{6.1,0,0.45},4.5)
wait_time(0.5)
PlayActionDirect(Actor008,"to Wlk")
turn_chara(Actor008,90,0.5)
slidemove(Actor008,{6.7,0,1.2},4.5)
wait_time(4)
setup_small_camera_start(RndCamera001)
Hide(Actor007)
Hide(Actor008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:この畑も<br>賑やかになってきたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020066")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,50,0.5)
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ノワールさんのおかげですよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020067")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺？/俺はなにもしてないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020068")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "否定")
-- ▲直接出力

	--★★リリアーナ★★:してました。私は知ってます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020069")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ふふっ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020071")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで？/俺がなにをしたって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020073")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:私に声をかけてくれました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020074")

	change_face(Actor002,"Smile")

	--★★リリアーナ★★:そして、畑を手伝いたいって言ってくれました/あのとき、本当はすごく嬉しかったんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020075")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:そうしたらクレアやディナタンも<br>来てくれるようになって…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020076")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:全部、ノワールさんのおかげですよね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020077")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:この場所を作ったのはリリアーナだろ？/俺なんかなにもやってないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020078")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それにリリアーナと一緒にいたいんだよ/俺も、みんなも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020079")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:そうなんですか…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020080")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020081")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナは周りの人間に元気をくれるんだ/野菜の生命力がキミを元気にしているようにさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_10020082")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:これからも頑張らなくっちゃ…/この畑で…この学園で
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_10020084")

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
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor008")
setup_prop_object_preload(10106003)
prop001_offset={-0.15,-0.03,0,0,-30,15}
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
