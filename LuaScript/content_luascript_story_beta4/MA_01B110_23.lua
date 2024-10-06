-- このluaスクリプトは、MA_01B110_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-60,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera002 = SetTemplate("Actor002",-70,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",55,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera002 = SetTemplate("Actor002",80,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:血の繋がりが縁の結び目として<br>それほど強い意味を持つとは思えないのだけど
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230002")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フィエナ★★:え…？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230003")


	--★★クレア★★:質問してもいい？フィエナ<br>あなたにとってガラハッドはなに？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230004")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力

	--★★フィエナ★★:ふ、深い質問だね…<br>…家族、かなあ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230005")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★クレア★★:じゃあ、そうね──<br>家族に言えないような秘密を孕むあなたはなに？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230006")

	change_face(Actor002,"Normal")

	--★★フィエナ★★:………なんのこと？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230008")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★クレア★★:あなたは<br>『擬似的な妖精の力』を宿している
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230009")


	--★★クレア★★:妖精もどきがすべきこと──<br>それが聖杯への案内だけ？ほんとうに？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230010")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★フィエナ★★:………、ほんとうだよ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:質問を変えましょう
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230013")

	open_select_window_tag(Actor001,"Normal","MA_01B110_230014","MA_01B110_230015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:尋問のつもりか？クレア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_230017")

-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:秘密を語り合うものでしょう？<br>学生同士の旅行というのは。違う？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230018")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Normal")

	--★★クレア★★:パズルのピースが足らないの<br>個人的感傷で隠しごとをされては困るのよ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴォールス、止めてくれ<br>探偵ごっこを続けさせる気か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_230021")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ボールス★★:ごっこ遊びをしているつもりはない<br>円卓の騎士として務めを果たそうとしているんだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_230022")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★ボールス★★:聖杯を探し、妖精を守る我らの責務<br>『聖杯城の巫女』は守る価値があるが否か
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_230023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Surp")
 --PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor004,"Surprise")

	--★★クレア★★:…！<br>あれは…
	Talk(Actor004,"CHRNAME_CLARE","speech","N","MA_01B110_230025")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
set_rot(Actor001,{0,70,0})
set_pos(Actor003,{-0.8,0,-0.9})
set_pos(Actor004,{1.15,0,0.4})
set_rot(Actor004,{0,115,0})
PlayActionDirect(Actor004,"to  Std_Sad01")
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor003)
lookat_weight_reset(Actor004)
setup_small_camera_start(RndCamera008)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
 --PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★クレア★★:間違いない<br>ガラハッドの足跡だわ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230027")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
set_pos(Actor004,{1.15,0,0.67})
set_rot(Actor004,{0,150,0})
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ボールス★★:どうやらガラハッドは<br>『滅びた都』側の聖杯の封を目指しているようだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_230028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Talk")
turn_chara(Actor004,-116,0.5)
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:私も本で読んだくらいで<br>詳しくは知らないのだけど
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230029")


	--★★クレア★★:かの『滅びた都』は聖杯を安置し<br>その力を授かることのできる聖なる都
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230030")


	--★★クレア★★:けれどユーサー王の治世の頃よりも遥か昔から<br>その都は不可視の障壁で人を寄せ付けないという
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B110_230032","MA_01B110_230033")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:不可視の障壁？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_230035")

-- ▼直接出力
 --PlayPartVoice("クレア", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:何処かに似ているとは思わない？<br>突破困難な壁、人を拒む場所といえば──
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230036")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………ハドリアヌス・ウォール<br>聖杯城の前の城壁の…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_230037")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:人を寄せ付けない都がどうして滅びたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_230039")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ボールス★★:順序が逆なのかもしれん<br>都が滅びた後に障壁が張られた…とも
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_230040")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★クレア★★:なぜそんなことをする必要があったのか<br>謎は深まるばかりね。ただ──
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230042")

	change_face(Actor004,"Normal")

	--★★クレア★★:その「人を拒む壁」は別の場所にも存在する<br>聖杯城を守るハドリアヌス・ウォール…
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230043")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:この人智を超えた仕掛けはどちらも<br>文字通り人を超えた者の所業だと予想するわ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230045")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力

	--★★フィエナ★★:「妖精の仕業じゃないか」って言いたいんだ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230047")


	--★★クレア★★:聖杯を導く者、聖杯城で守られていた者<br>滅びた都が守っているもの、そのすべては──
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230048")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ボールス★★:──妖精に帰結する、ように思えるな
	Talk(Actor003,"CHRNAME_BORS","speech","L","MA_01B110_230049")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Anger")

	--★★クレア★★:とすれば『滅びた都』の先に何が眠っているのか<br>先の質問はコレ。答えを持ってはいない？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001,0.4,0.03,0.7,0.6,1)
lookat_delay_weight(Actor003,0.4,0.03,0.7,0.6,1)
lookat_delay_weight(Actor004,0.4,0.03,0.7,0.6,1)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:フィエナ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_230051")

	PlayAction(Actor004,"to Finger")
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:質問に答えてくれれば賞品<br>『滅びた都の絵画』をプレゼント
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230052")


	--★★クレア★★:ヴォールスが海賊仲間から貰った──<br>もとい私が欲しいとねだった逸品よ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★フィエナ★★:………例えば自分の子供にね？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230055")


	--★★フィエナ★★:「貴方を育てるのに幾らかかったよ」とか<br>「大人になったら人生苦労しかない」とか
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230056")


	--★★フィエナ★★:あんま言いたくないよね？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230057")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★クレア★★:話の流れが見えないわ
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★フィエナ★★:今は…言えない。言いたくないことがあるの<br>どう伝えればいいのかわからないことが…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230059")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:わかるよ<br>…そんなことばっかりだった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_230060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
turn_chara(Actor002,150,0.5)
 --PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力

	--★★フィエナ★★:ごめんね…、フィエナちゃんってば<br>ノワールにフォローされてばっかりだ…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230061")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:ぐらぐらと揺れる天秤…おもりは手のなか<br>フィエナは今、自らを秤にかけているわけね？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230062")

-- ▼直接出力
change_face(Actor001,"Normal")
set_enable_auto_lookat(Actor001,false)
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,80,1)
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フィエナ★★:…？<br>話が見えないよ？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230063")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★クレア★★:言葉だけが答えではないわ、フィエナ<br>振る舞い…瞳の動きとその輝きが十分に語ってる
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:「騙る気はない。偽りたいわけでもない<br>ただ時は、真実を明るみにするに至っていない」
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230065")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フィエナ★★:…うん。そう、だね
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B110_230067")


	--★★クレア★★:いいわ。誰もが謎を謎のまま守ろうとしている<br>でもそれが利己的な願望でないことは解ったから
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230068")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
 --PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クレア★★:奇跡を待つのは<br>性に合わないけれどね
	Talk(Actor004,"CHRNAME_CLARE","speech","L","MA_01B110_230069")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101020011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
