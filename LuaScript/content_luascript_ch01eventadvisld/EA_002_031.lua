-- このluaスクリプトは、EA_002_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",72.1,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera006 = SetTemplate("Actor006",95,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera007 = SetTemplate("Actor007",115,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
set_pos(Actor001,{-2.53,0,0.669})
turn_lookat_position(Actor001,CharaPosDuelCommonFormation01_001[1],CharaPosDuelCommonFormation01_001[2],CharaPosDuelCommonFormation01_001[3],0)
-- ▲直接出力
-- ▼直接出力
Ef_0004 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, false)
set_pos(Ef_0004,CharaPosDuelCommonFormation01_002)
set_pos(Actor002,{-3.54,0,0.08})
turn_lookat_position(Actor002,CharaPosDuelCommonFormation01_006[1],CharaPosDuelCommonFormation01_006[2],CharaPosDuelCommonFormation01_006[3],0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-3.522,0,-0.961})
turn_lookat_position(Actor003,CharaPosDuelCommonFormation01_003[1],CharaPosDuelCommonFormation01_003[2],CharaPosDuelCommonFormation01_003[3],0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_animationbattlecontroller(Actor004,8,true)
bow = set_object("content_weapon_105010010", "weapon_model_105010010", true)
bow_offset  = {0,0,0,0,180,-180}
off_active(bow)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, false)
set_pos(Ef_0001,{-4.83, 0, -0.74,   65.99609})
set_rot(Ef_0001,{0,-80,0})
Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, false)
set_pos(Ef_0002,{-5.33,0,0.87})
set_rot(Ef_0002,{0,75,0})
Ef_0003 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, false)
set_pos(Ef_0003,{-4.51, 0, 2.26,   121.3796})
set_rot(Ef_0003,{0,-80,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-5.33, 0, -0.74,65.99609})
turn_chara(Actor005,66,0)
set_pos(Actor006,{-6.13,0,0.87})
set_pos(Actor007,{-5.01, 0, 2.26})
turn_chara(Actor007,121.3796,0)
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,-0.52, 0.55, -0.29)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Running_FI")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Painful2")
-- ▲直接出力
-- ▼直接出力
load_image("102050020", "content_still_10205002_image", "102050020_StillImage")
show_image("102050020", 0.0, 0.0, 0,false,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","002","101019002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(MAP_TIME_ACTIVE)
hide_image(MAP_TIME_END)
wait_time(MAP_TIME_END)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,CharaPosDuelCommonFormation01_001[1],CharaPosDuelCommonFormation01_001[2],CharaPosDuelCommonFormation01_001[3],2.5)
wait_time(0.3)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,CharaPosDuelCommonFormation01_003[1],CharaPosDuelCommonFormation01_003[2],CharaPosDuelCommonFormation01_003[3],2.5)
wait_time(0.2)
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,CharaPosDuelCommonFormation01_006[1],CharaPosDuelCommonFormation01_006[2],CharaPosDuelCommonFormation01_006[3],1.5)
wait_time(1.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
turn_chara(Actor001,CharaPosDuelCommonFormation01_001[4],0.4)
wait_time(0.3)
turn_chara(Actor003,-18.3,0.4)
wait_time(0.1)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat(Actor003,false)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.2)
lookat_delay_weight(Actor002, 0.6, 0.5, 0.6, 0.2,1.0)
wait_time(0.2)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0025")
-- ▲直接出力

	--★★イゾルデ★★:生きることって博打の連続でしょうけど<br>負けが込んだその賭けの先にあるのは確実な死
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力

	--★★イゾルデ★★:結果が明白なギャンブルなどつまらないわ<br><ruby=フォールドする>すぐに降りる</ruby>べきよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031003")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:にしてはいつも明白な勝利を得るべく<br>堅実なイカサマを仕掛けているように見えるが？
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031004")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
set_common_look_at(Actor002,クレア,0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力

	--★★イゾルデ★★:まだ根に持っているの？<br>お前が私に格安で譲ってくれた弓のこと
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031005")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0019")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:…あれは譲ったのではない<br>騙し取られたのだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101009_sp_0022_1")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんの話だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031007")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力

	--★★ヴォールス★★:聞くな<br>情けない話だ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:お買い得だったわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031009")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力

	--★★ヴォールス★★:お前の賭けに合意のうえではあった。それはイイ<br>カモにされたことも情けないが…それもまあイイ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:だが<dot>今度の相手</dot>は俺と違って<br>そう容易に渡してもらえるヤツではないぞ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:リアムから聞き出したわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031013")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:ロンディニウムにいる偏屈な商人が<br>致死薬を売ってると
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031014")

-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:俺も知らない顔ではないがイイ噂を聞かない<br>珍妙な商品を取り揃えつつ簡単には売らず…
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031015")


	--★★ヴォールス★★:相手の財布を空っぽにし<br>衣服や靴までむしり取るという
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031016")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:商人というより賊の類だ…<br>どうやってそんなことを？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_common_look_at(Actor002,Actor003)
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:──ねえ<br>どうしてヴォールスがついてくるわけ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力

	--★★ヴォールス★★:間もなく始まるカレドニアとの戦に備えてな<br>ロンディニウムで仕入れをするついでだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031020")


	--★★イゾルデ★★:<ruby=クレア>名探偵</ruby>は店番？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031021")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ヴォールス★★:涼しい顔をしていたが<br>賭けに負けたことがまあまあ悔しかったらしい
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031022")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:お気の毒ね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031023")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:こうして自分を護衛につけたのは<br>クレアなりの賛辞と受け取ってもらいたい
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_031024")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:私を止めにきたわけじゃないのね<br>ノワールみたいに
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031025")

-- ▼直接出力
lookat_delay_weight(Actor001, 0.6, 0.5, 0.6, 0.2,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_002_031027","EA_002_031028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…考え直さないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031030")

-- ▼直接出力
PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:賭けの片棒を担いでおいて言うことかしら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031031")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:探していたものが<br>致死薬と知っていれば…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031032")

-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:師を救おうという私の動機に<br>共感してくれたわけではなかったの？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気持ちは、わからないわけじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031035")

	change_face(Actor001,"Sad")

	--★★ノワール★★:母さんが苦しむ姿を目の前で見ていた<br>何度も…救ってあげられないか考えたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:………つらかったわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031037")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:いまもどうしたら良かったかわからない<br>だから止めるべきか行かせるべきかも──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031038")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:あの人は薬に堪能であるがゆえ<br>自身の病は薬で治るものでないとわかっているわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031040")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:気休めなんか…口が裂けても言えなかった<br>薬は嘘をつかないから
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031041")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
lookat_delay_weight_reset(Actor002,0.35)
wait_time(0.7)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:あの人が望んでいる。私はそれに応える<br>それが救いでなくてなんなの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031042")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.4)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…きっと、本人にしかわからない痛みがある<br>だけど…その長く続く苦しみによって──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031043")


	--★★ノワール★★:本来なら望まないことが<br>頭をいっぱいにしてしまうこともある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:わかっているわ<br>ずっと考えてきたことよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031046")

	change_face(Actor002,"Sad")

	--★★イゾルデ★★:死にたくないのに死にたいと<br>そう思ってしまうことなんてままあるわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031047")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0021")
-- ▲直接出力

	--★★イゾルデ★★:だけど──…だったら、どうしろというの<br>放ってはおけない、終わらせるのもダメ？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031048")


	--★★イゾルデ★★:私が大切な人にしてあげられることって、なに？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031049")

	change_face(Actor001,"Sad")

	--★★ノワール★★:だけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031050")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.6)
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★イゾルデ★★:もう、いいわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031051")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:<ruby=キミ>親しい人</ruby>から死を勧められるのは<br>死ぬよりつらいじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_031052")

-- ▼直接出力
CloseTalkWindow()
CameraEX = set_camera({-0.7, 1.37, 0.81,   7, 273.6, 0.5,   32})
setup_small_camera_start(CameraEX)
set_pos(Actor002,CharaPosDuelCommonFormation01_002)
turn_chara(Actor002,CharaPosDuelCommonFormation01_002[4],0)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor003)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_0001)
on_active(Ef_0002)
on_active(Ef_0003)
wait_time(0.6)
Appear(Actor005)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,-4.63, 0, -0.44,0.6)
wait_time(0.2)
Appear(Actor006)
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,-5.43,0,0.87,0.6)
wait_time(0.2)
Appear(Actor007)
PlayActionDirect(Actor007,"to Wlk")
slidemove(Actor007,-4.3, 0, 2.06,0.6)
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor007,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{-0.7,0,1.53})
set_rot(Actor001,{0,-73.1,0})
set_pos(Actor003,{-1.02,0,-0.12})
set_rot(Actor001,{0,-58.5,0})
set_rot(Actor003,{0,-56.38,0})
set_rot(Actor004,{0,-63.3,0})
set_enable_auto_lookat_all(false)
lookat_delay_weight_reset(Actor001,0.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
set_animationbattlecontroller(Actor001,1,false)
wait_time(0.3)
set_animationbattlecontroller(Actor003,1,false)
wait_time(0.5)
change_face(Actor001,"Normal")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
off_active(Ef_0001)
off_active(Ef_0002)
off_active(Ef_0003)
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Running_FI")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力
	open_cutin(3,2)
	on_cutin(1,Actor003,"Anger")

	--★★ヴォールス★★:…下がっていろ<br>散漫なまま戦うのも酷だろう
	Talk(Actor003,"CHRNAME_BORS","speech","N","EA_002_031054")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0040")
-- ▲直接出力
	on_cutin(2,Actor002,"Anger")

	--★★イゾルデ★★:いいえ。やるわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_031101")

-- ▼直接出力
voice_play("VO_101009_sp_0013_1")
-- ▲直接出力
	on_cutin(3,Actor001,"Normal")

	--★★ノワール★★:イゾルデ
	Talk(Actor001,"CHRNAME_NOIR","speech","N","EA_002_031055")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(RndCamera010)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
on_active(Ef_0004)
wait_time(0.9)
-- ▲直接出力

	--★★イゾルデ★★:バルバロイに苛まれる地において薬は無力だけど<br>私たちこそが今の世界における特効薬だと──
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_031056")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + 0.3)
Hide(Actor002)
Appear(Actor004)
 --on_active(bow)
on_parent(bow,Actor004, "Loc_weapon_constrint_L", bow_offset)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"ToIdle")
off_active(Ef_0004)
 --フェードイン
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+0.9)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★イゾルデ2★★:あの人はキラーズになった私を<br>喜んでくれたわ
	Talk(Actor004,"CHRNAME_ISOLDE2","speech","L","EA_002_031058")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★イゾルデ2★★:してあげられることは、これぐらいだもの
	Talk(Actor004,"CHRNAME_ISOLDE2","speech","L","EA_002_031059")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, false)
set_object_preload("content_weapon_105010010", "weapon_model_105010010", true)
bow_offset  = {0,0,0,0,180,-180}
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, false)
preload_sound("BGM_Battle_Running_FI")
preload_sound("BGM_ADV_Painful2")
load_image_preload("102050020", "content_still_10205002_image", "102050020_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","002","101019002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
