-- このluaスクリプトは、MA_01107_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-75,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",-55,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera003 = SetTemplate("Actor003",-42,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",-110,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("10301019", "content_still_10301019_image", "103010190_StillImage")
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
change_face(Actor001,"Surprise")
change_face(Actor005,"Surprise")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000023)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_2DOnly("101050","001","101050001")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor005,"Surprise")

	--★★ディナタン★★:本当に…お父さん、なの
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Surprise","MA_01107_400004","MA_01107_400005","MA_01107_400006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:父さん！<br>生きて…生きてたんだね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400008")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor006)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ブルーノ★★:ランスロットのおかげでな
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400009")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Smile")

	--★★ノワール★★:良かった…<br>本当に良かった…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:さがしてたんだよ、父さん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:父さんが死んだなんて信じられなくて<br>俺もディナタンも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400013")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★ブルーノ★★:…心配かけたな
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400014")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:その仮面…<br>本当に父さんなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400016")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★ブルーノ★★:今さら父親ヅラするのは<br>赦してもらえないかもしれないが
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400017")

	change_face(Actor006,"Normal")

	--★★ブルーノ★★:信じてくれ、ノワール
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400018")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
-- ▲直接出力

	--★★ディナタン★★:母さんのお墓の花…<br>いつも、本当に…ずっと近くに…
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400020")

	PlayAction(Actor006,"to  Std_Sad02")
	change_face(Actor006,"Sad")

	--★★ブルーノ★★:…私は、咎人だ<br>公衆の面前に姿をさらすことは赦されていない
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400021")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:…円卓の騎士ブルーノは<br>なんらかの咎で粛清されたと伺ったけど？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_400023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ランスロット★★:…俺が、<ruby=ゲシュタルト・シフト>ＧＳ</ruby>をしたんだ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400024")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
	open_cutin(3,1)
	on_cutin(1,Actor005,"Surprise")
	on_cutin(2,Actor001,"Surprise")
	on_cutin(3,Actor003,"Surprise")
-- ▼直接出力
change_face(Actor001,"Surprise")
change_face(Actor003,"Surprise")
change_face(Actor005,"Surprise")
wait_time(1.5)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad01")
	change_face(Actor006,"Normal")

	--★★ブルーノ★★:…逃亡のさなか<br>それでもカレドニアを止めたかった
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400026")


	--★★ブルーノ★★:家族がブライアンの下で守られ、育つまでは
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400027")


	--★★ディナタン★★:…私たちがブライアンさんのところにいることも<br>全部知ってて…
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400028")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:…咎人の家族として<br>巻き込みたくはなかった…？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_400029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ランスロット★★:師匠は…ライエンス率いるカレドニアの軍勢を<br>単身で幾度も食い止め──
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400031")

	change_face(Actor004,"Sad")

	--★★ランスロット★★:俺が見つけた頃にはもう<br>ボロボロに、衰えて…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400032")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ブルーノ★★:GSを行い、戦い続けること<br>俗世に姿を現さないことを禊とした
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ディナタン★★:公には、粛清という形で…？
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400034")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:アーサーとケイが<br>なんらかの咎人として便宜を図ってくれたと
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_400035")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:今までも、これからもずっと<br>隠れて戦い続けるつもりで
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_400036")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ランスロット★★:…ああ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400037")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:まあ…表に出せない咎なんて幾らでもあるしね<br>私闘、不貞、背教、略奪…とかとか
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_400038")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★ギネヴィア★★:（…円卓の騎士ブルーノが<br>妖精の守護者だったこと自体世間は知らない）
	Talk(Actor003,"CHRNAME_GUINEVERE","mind","L","MA_01107_400039")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力

	--★★ギネヴィア★★:（だからそのブルーノが咎人とされても<br>妖精とは結び付かない…）
	Talk(Actor003,"CHRNAME_GUINEVERE","mind","L","MA_01107_400040")


	--★★ギネヴィア★★:（…妖精殺し＝円卓の騎士ブルーノというコトは<br>アーサーとケイしか知らない大罪…）
	Talk(Actor003,"CHRNAME_GUINEVERE","mind","L","MA_01107_400041")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:（なぜ殺したか、その真実は頑なに語らない…<br>ずっと…ランスロットも。どうして──…？）
	Talk(Actor003,"CHRNAME_GUINEVERE","mind","L","MA_01107_400042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad02")
	change_face(Actor006,"Sad")

	--★★ブルーノ★★:…死んだはずの者が姿を見せるわけにはいかない<br>咎に巻き込むわけにもいかなかった
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400044")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:キャメロットで平和にお祭りができてたのも<br>ノワールが学園で勉強を続けられたのも…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_400045")

	change_face(Actor005,"Surprise")

	--★★ディナタン★★:…お父さんが、カレドニアを<br>押し留めてくれていたから…？
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400046")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★ランスロット★★:だが、どうしても一目会わせたかった<br>それこそが責任だと思った
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:だからお前たちに知って欲しかったんだ<br>円卓の騎士がなすべきことを
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400048")


	--★★ランスロット★★:そしてギネヴィア殿下と知った<br>バルバロイによって失われる思い出があることを
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400049")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:ディナタンとともに知った<br>GSへ至る道のり、そしてその力と覚悟を
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400050")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ディナタン★★:…うん、ＧＳのことがわからなかったら<br>わけがわからなかった…きっと
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400051")

	open_select_window_tag(Actor001,"Normal","MA_01107_400053","MA_01107_400054","MA_01107_400055")
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
	change_face(Actor001,"Smile")

	--★★ノワール★★:あんたが守ってくれたんだ<br>父さんを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400057")

	change_face(Actor004,"Surprise")

	--★★ランスロット★★:ノワール…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400058")

	change_face(Actor004,"Smile")

	--★★ランスロット★★:ありがとう
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400059")

-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
change_face(Actor004,"Normal")
-- ▲直接出力
	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor003,true)
set_enable_auto_lookat(Actor005,true)
reserve_eyesync(Actor001,"Close")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:赦さない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400061")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ディナタン★★:兄さん…
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400062")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
force_eyesync(Actor001,"Auto")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:絶対に赦さないからな<br>真実を伝えずに抱え込むなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400063")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ふたりにはこれからずっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400064")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺とディナタンの<br>そばにいてもらう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400066")

-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
lookat_delay_weight_reset(Actor002,1)
lookat_delay_weight_reset(Actor003,1)
lookat_delay_weight_reset(Actor005,1)
-- ▲直接出力
	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:一緒に暮らすことはできないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400068")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ブルーノ★★:誰の目に触れることもできない
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400069")

	change_face(Actor006,"Normal")

	--★★ブルーノ★★:王との約束であるとともに<br>己の禊でもある
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400070")

-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
-- ▲直接出力
	goto Block2end

::Block2end::
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★ディナタン★★:…もう、会えないの？父さん
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01107_400072")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ブルーノ★★:こうして会うために<br>この姿を選んだ
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400073")


	--★★ブルーノ★★:必ず助ける<br>ずっと見守っている
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400074")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…正直言って<br>今はまだ気持ちの整理がついていない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400075")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ブルーノ★★:…ああ
	Talk(Actor006,"CHRNAME_BRUNO2","speech","L","MA_01107_400076")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400077")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301019", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ノワール★★:母さんはこのコートを縫いながら言ってた
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01107_400079")


	--★★ノワール★★:「父さんは誉れ高き円卓の騎士なの<br>いつでも私たちを見守ってくれている」
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01107_400080")


	--★★ノワール★★:それ、俺が証明してみせるよ
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01107_400081")


	--★★ブライアン将軍★★:…お前が目立てば<br>親父さんのほうから来てくれるってか
	Talk(Actor007,"CHRNAME_BRIAN","simple","N","MA_01107_400082")


	--★★ノワール★★:もしくは円卓の騎士が迎えに来てくれるかもね
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01107_400083")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力

	--★★ノワール★★:だけど父さんに会えた<br>ランスロットが逢わせてくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400085")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ランスロット★★:ああ…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01107_400086")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:信じて、いいんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_400087")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10301019", "content_still_10301019_image", "103010190_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000023)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101021","001","101021001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_2DOnly_Preload("101050","001","101050001")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
