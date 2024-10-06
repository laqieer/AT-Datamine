-- このluaスクリプトは、MA_01B109_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",133.22,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera006 = SetTemplate("Actor006",184.4,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera007 = SetTemplate("Actor007",-85.2,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera008 = SetTemplate("Actor008",132.3,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:集まってくれて感謝する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120002")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:授業だから集まるでしょ<br>いつものことでしょ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…確かに
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★トリスタン★★:えっ、なんか沈んだ？<br>ごめんごめん、どうぞ進めて
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120005")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:集まってくれて感謝する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:みんなランスロット先生の授業が<br>楽しみで集まってきてくれたのねえ～
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_120008")


	--★★ランスロット★★:これより最後の授業を始める
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120009")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:最後の…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_120011")


	--★★ランスロット★★:とはいえ授業は<br>これ以降もやるわけだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★イゾルデ★★:どっちなの、しっかりなさい
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_120013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…確かに、紛らわしいな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120014")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★トリスタン★★:アー進まない、ごめんねごめんね<br>もう突っ込まない、もう突っ込まなーい
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:学園にいる生徒みなに俺のもつすべてを託せたら<br>どんなにいいだろうといつも思う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120016")


	--★★ランスロット★★:だがいつも伝えきれないでいる<br>きっとこの先も難しいことだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺が継承者のキラーズ<br>アロンダイトとなったからだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120018")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★トリスタン★★:ログレスが長年さがし続けて来た継承者<br>バルバロイという侵略者から歴史を救う者
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120020")


	--★★トリスタン★★:先の戦いでの継承者──ノワールの覚醒は<br>戦場にいた者全員が目の当たりにした光景…
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120021")

	PlayAction(Actor004,"to  Std_Talk")

	--★★トリスタン★★:すでに学園中の周知の事実だよね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:これより先は覚醒を果たした継承者を<br>学園全体で守りつつ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120023")


	--★★ランスロット★★:襲い来る侵略者を迎え撃つ<br>俺はその矢面に立ち続ける
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120024")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:あと何度<br>お前たちに剣を教えられるかわからない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("女子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:縁起でもないことを言わないでください<br>ランスロット先生…！
	Talk(Actor005,"NPCNAME_0151","speech","L","MA_01B109_120026")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:…話が見えないわ<br>具体的には？この授業でなにをしようというの？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_120028")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:今できることをしたい<br>いつ最後の授業となっても良いように
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120029")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("男子1", "怒り")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:…い、いつも力を尽くして<br>剣を教えてくださっているじゃないですか
	Talk(Actor005,"NPCNAME_0151","speech","L","MA_01B109_120030")

	PlayAction(Actor006,"to  Std_Surp")

	--★★キャメロット騎士学術院（女）★★:これ以上なにをされると…？
	Talk(Actor006,"NPCNAME_0146","speech","L","MA_01B109_120031")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
-- ▲直接出力
-- ▼直接出力
weapon_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(sword_01,Actor002, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B109_12_Sword")
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:──<ruby=みんな>全校生徒</ruby>まとめて<br>かかってこい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120033")

-- ▼直接出力
se_play("SE_ADV_MA_01B109_12_Crowd_Short")
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
change_face(Actor003,"Surprise")
change_face(Actor004,"Surprise")
change_face(Actor005,"Surprise")
change_face(Actor006,"Surprise")
change_face(Actor007,"Surprise")
change_face(Actor008,"Surprise")
PlayAction(Actor001,"to  Std_Surp")
PlayAction(Actor003,"to  Std_Surp")
SkipDefaultMotion(Actor004)
PlayAction(Actor004,"to  Std_Surp")
PlayAction(Actor005,"to  Std_Surp")
PlayAction(Actor006,"to  Std_Surp")
PlayAction(Actor007,"to  Std_Surp")
PlayAction(Actor008,"to  Std_Surp")
 --PlayPartVoice("トリスタン", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★トリスタン★★:ええ…！？
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺たちが相手をする
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120036")

-- ▼直接出力
SkipDefaultMotion(Actor001)
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………俺、たち？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_120037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:<ruby=ノワール>継承者</ruby>と<ruby=おれ>その劒</ruby>が<br>生徒全員の相手をする
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B109_12_Crowd_Long")
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
SkipDefaultMotion(Actor001)
PlayAction(Actor001,"to  Std_Surp")
PlayAction(Actor003,"to  Std_Surp")
PlayAction(Actor004,"to  Std_Surp")
PlayAction(Actor005,"to  Std_Surp")
PlayAction(Actor006,"to  Std_Surp")
PlayAction(Actor007,"to  Std_Surp")
PlayAction(Actor008,"to  Std_Surp")
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エエッッ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_120041")


	--★★ランスロット★★:不安の種も<br>数多くあるだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120043")


	--★★ランスロット★★:長年探し続けて来た継承者…<br>それがかつての敵対者であったこと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120044")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:大帝国ローマにブリテンを半分以上<br>押さえられた状況下での聖杯探索──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120045")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★トリスタン★★:…なんなの<br>不安を煽ってさ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが、必ずやり遂げよう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120048")


	--★★ランスロット★★:真なる敵は大帝国ではない<br>化け物ごとき、諸君らの敵ではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120049")


	--★★ランスロット★★:戦うべきは己
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:負けてはならない<br>揺らがされる心、武器を取らず足踏みする身体に
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120051")


	--★★ランスロット★★:道は我ら円卓の騎士が踏み固める<br>みなは恐れずに進んで欲しい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120052")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "納得")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★トリスタン★★:………なるほど
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120053")


	--★★トリスタン★★:全校生徒を相手取ってもキミらが勝てるようなら<br>安心して学園を任せられるね、まぁ確かに
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120054")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:そして負けた生徒は今後さらに奮起する<br>乱暴だけど最強騎士でないとできない授業ね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_120055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_120056","MA_01B109_120057")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:断る！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_120059")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:拒否権はないぞ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120060")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★トリスタン★★:やりなよ、意気地なし
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_120061")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…こんなことじゃないかと思ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_120063")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:乗った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_120065")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…いいのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_120066")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:自分で持ちかけておいて
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01B109_120067")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:こんなことじゃないかと思ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_120069")

	goto Block1end

::Block1end::
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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
