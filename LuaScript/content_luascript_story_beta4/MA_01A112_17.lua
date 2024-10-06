-- このluaスクリプトは、MA_01A112_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",-50,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight(Actor001,0.6,0.03,0.7,0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101150013)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:あのときみたいね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170002")

	open_select_window_tag(Actor001,"Normal","MA_01A112_170004","MA_01A112_170005","MA_01A112_170006")
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
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あのとき？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170008")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わかんないなら、いい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170009")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
Appear(Actor004)
Appear(Actor008)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィア…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアを誘拐したとき？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:うん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170013")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
Appear(Actor004)
Appear(Actor008)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:いっぱい辛かったけどね<br>すっごく頼もしかったんだよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170014")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレインとロンディニウムを攻めたとき？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170016")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あいにくエレインは<br>まだ病室から出て来られないみたいね…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170017")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
Appear(Actor004)
Appear(Actor008)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…お話、したいね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170018")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor005)
Appear(Actor006)
set_rot(Actor001,{0,-15,0})
set_rot(Actor002,{0,-20,0})
lookat_weight_reset(Actor001)
PlayActionDirect(Actor002,"to Std_Loop")
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:あのときみたいだな、ノワール！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_170020")

-- ▼直接出力
DontChangeRandomCamera(false)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:懐かしいねなつかしいね、ギネヴィア！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_170021")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あのときみたいだよね、やっぱり<br>よかった、ラグネルたちもそうよね、よかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
lookat_weight(Actor001,0.5,0.03,0.7,0)
lookat_weight(Actor002,0.6,0.03,0.7,0)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:…ギネヴィア
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_170023")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:まあ、あのときと違うところもあるね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A112_170024")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:お前が見送りしてくれることか？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_170025")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★トリスタン★★:戦わなきゃならないのは<br>ガウェインたちに因縁がある相手だってこと
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A112_170026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:ガウェイン、勝てる？
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A112_170028")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
lookat_weight(Actor005,0.6,0.03,0.7,0)
keep_ik_lookat(Actor005,Actor003,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:…勝てるかハッキリした喧嘩なんざねえよてねーよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_170029")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor006)
set_rot(Actor001,{0,25,0})
set_rot(Actor002,{0,15,0})
 --PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:勝算ありきで挑むのが戦の基本よ
	Talk(Actor006,"CHRNAME_ISOLDE","speech","L","MA_01A112_170030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor006,"J_Head",0.5)
-- ▲直接出力

	--★★イゾルデ★★:敵数は前のキャメリアード戦とは比較にならない<br>カレドニアを?み込んだバルバロイの大兵力
	Talk(Actor006,"CHRNAME_ISOLDE","speech","L","MA_01A112_170031")


	--★★イゾルデ★★:今回はそこにヴェルナルスもいるのでしょう？<br>さらに…底知れぬキラーズ・アスカロンの力
	Talk(Actor006,"CHRNAME_ISOLDE","speech","L","MA_01A112_170032")

	PlayAction(Actor008,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★マーリン★★:天性の素養がおありだったのでしょうか<br>抑え込まれた巨人の力とは…
	Talk(Actor008,"CHRNAME_MERLIN","speech","L","MA_01A112_170033")

-- ▼直接出力
lookat_delay_weight_reset(Actor005,0.5)
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:それに一度負けてるしね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A112_170034")

	PlayAction(Actor005,"to  Std_Worry")

	--★★トリスタン★★:今度負ければローマは勢いづき<br>そのままログレスへとなだれ込む…だからお願いだ
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A112_170036")

-- ▼直接出力
setup_small_camera_end()
manager.CloseupUpExclusiveCamera(Actor005)
set_rot(Actor001,{0,50,0})
set_rot(Actor002,{0,20,0})
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力

	--★★トリスタン★★:勝ってよね。あのときみたいに
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A112_170037")

	open_select_window_tag(Actor001,"Normal","MA_01A112_170039","MA_01A112_170040","MA_01A112_170041")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺もギネヴィアも強くなった<br>それもあのときとは違う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ええ…ずっと気遣われてたあのときとは違うわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170044")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:今のローマ唯一の弱点は<br>意志なき化け物を束ねるヤツが僅かってことよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:将を討てれば勝機はある<br>果てしない物量のローマに対してでも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170047")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしはアロンダイト<br>もう…負けらんない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170048")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェインとラグネルにかかってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170050")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ローマ唯一の弱点は<br>意志なき化け物を束ねる者が喰らわれ過ぎたこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170051")

	change_face(Actor001,"Normal")

	--★★ノワール★★:将を討てれば勝機はある<br>果てしない物量のローマに対してでも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170053")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:それが一番いちばん難しい問題だがけど<br>それっきゃねーえよな…！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_170054")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:負けられないな、学園のためにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170056")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★マーリン★★:敵が学園にまで至れば<br>カレドニア攻略どころではありません
	Talk(Actor008,"CHRNAME_MERLIN","speech","L","MA_01A112_170057")

	change_face(Actor008,"Sad")

	--★★マーリン★★:どうか…ご無事で
	Talk(Actor008,"CHRNAME_MERLIN","speech","L","MA_01A112_170058")

	goto Block2end

::Block2end::
-- ▼直接出力
EntryWalk(Actor007,Camera007,EntryDataDuelCommonFormation01_04,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_104)
-- ▲直接出力
	PlayAction(Actor007,"to Greet_one")
-- ▼直接出力
set_rot(Actor005,{0,-155,0})
set_rot(Actor006,{0,-135,0})
lookat_weight(Actor003,0.6,0.03,0.7,0)
keep_delay_ik_lookat(Actor003,Actor007,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor007,"J_Head",1)
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:あのときのように<br>ギネヴィアのエスコートを頼もうか！
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01A112_170060")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★マーリン★★:キャメリアード城本丸まで<br>転移でお送りします
	Talk(Actor008,"CHRNAME_MERLIN","speech","L","MA_01A112_170061")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:出来る限りキャメリアード城の外側に<br>注意を逸らしたうえで突入する必要があるわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_170062")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:ボクらの陽動開始とともに<br>主戦力は転移により中枢へ侵入、一気に制圧を
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01A112_170063")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ガウェイン、ラグネルのリベンジと<br>ギネヴィアの里帰りを支えてくれ、ノワール
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01A112_170065")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_170066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラグネル★★:…ねえ、ガウェイン？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_170067")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:なんだあ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_170068")


	--★★ラグネル★★:咀嚼できた？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_170069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor003,1)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:飲み込めねーえな、まだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_170070")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101150013)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
