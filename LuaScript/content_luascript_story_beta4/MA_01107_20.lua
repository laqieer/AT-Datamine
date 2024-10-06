-- このluaスクリプトは、MA_01107_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-90,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	Camera002 = SetTemplate("Actor002",-70,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera003 = SetTemplate("Actor003",-45,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110101_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_008)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_camera_nearclip(Camera002,1)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Bow")
-- ▼直接出力
reserve_eyesync(Actor002,"Close")
-- ▲直接出力

	--★★ギネヴィア★★:お納めください
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_200002")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:これはこれは。己の国の宝を差し出すとは<br>プロポーズと言っても過言ではないな？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200003")

-- ▼直接出力
reserve_eyesync(Actor002,"Auto")
-- ▲直接出力

	--★★ギネヴィア★★:過言です
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_200004")

	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:もはや結納
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:そんなセクハラするための大聖堂なわけ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_200006")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:クッククク…まさか<br>そなたとの婚姻であれば本国へ招いて行うさ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:さて継承者、3つ目のゲーム前に質問だ<br>戦に勝利するために必要なものはなんだと思う？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200010")

	open_select_window_tag(Actor001,"Normal","MA_01107_200012","MA_01107_200013","MA_01107_200014")
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
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…準備と、戦略か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_200016")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:頭を使うのは当然だな<br>前準備ほど大切なものもない
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200017")

	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:それも相手や己の状況によって変わる<br>必勝の策を見極めるのは至難の業だ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:武力、かな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_200021")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:最強騎士が座する円卓らしい考えだ<br>嫌いではないよ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200022")

	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:比類なき力によって戦の主導権を握れば<br>知力など捻りつぶせるやもしれぬ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200023")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:戦わないに越したことはない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_200025")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:戦わずして勝つ。素晴らしい考えだ<br>勝機がなければ戦わない、というのも必要な策だ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200026")

	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:単なる平和主義でその発言をしたわけではない<br>そうだろう、もと傭兵団長？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(true)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ランスロット★★:明確な正解などないだろうな<br>はっきりとした間違いもないだろうが
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200029")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:聡明だ、最強騎士<br>だが余は余なりに未熟な頭脳で考えたよ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200030")

	PlayAction(Actor004,"to  Std_Talk")

	--★★皇帝ルーシャス★★:１．金　２．強さ　３．弱さ<br>戦に必要なのはこの３つだとな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:弱さ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_200032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★ランスロット★★:ある種の真理だな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200033")


	--★★ランスロット★★:強みだけでなく己の弱点をも<br>把握すれば攻めかたも守りかたもわかる
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200034")


	--★★皇帝ルーシャス★★:「宝石の献上」で金目のモノをいただいた<br>「貴様らとの戦い」で騎士どもの強さを見た
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力

	--★★皇帝ルーシャス★★:ならばゲーム３<br>「貴様らの<ruby=よわみ>泣きどころ</ruby>を見せよ」
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200037")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:もうゲームですらないわね<br>泣きどころって…なによ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_200039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力

	--★★皇帝ルーシャス★★:最強騎士、次は貴様に問う
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200040")


	--★★皇帝ルーシャス★★:貴様が継承者の父君を亡き者にしたのは<br>本当かな？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★ランスロット★★:…真実です。皇太子殿下
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200043")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_200044")

	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Sad")

	--★★ランスロット★★:我が剣の師でもあり<br>ノワールの父でもあった男を、俺が
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200045")

-- ▼直接出力
set_enable_auto_lookat_all(true)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力

	--★★皇帝ルーシャス★★:なんらかの赦されざる罪を犯したと言われる咎人<br>元円卓の騎士ブルーノ──
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200046")


	--★★皇帝ルーシャス★★:彼を粛清し、後釜に納まった者こそ<br>最強騎士ランスロットと聞く
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200047")


	--★★皇帝ルーシャス★★:そしてその最強騎士を追い学園に導かれた者<br>それが継承者…ノワール
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:（………忙しくって考える暇さえなかったけど<br>ようやく整理できた…）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01107_200050")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力

	--★★皇帝ルーシャス★★:ゆえに、ノワールの父君こそ<br>咎人ブルーノということになるな？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200051")


	--★★ギネヴィア★★:（ケイはノワールのお父様が<br>『妖精殺し』だとこぼし、口をつぐんだ）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01107_200052")


	--★★皇帝ルーシャス★★:その咎とはなんだ？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200053")


	--★★ギネヴィア★★:（ノワールのお父様こそ妖精守護の円卓の騎士<br>その粛清理由こそ『妖精を殺した』咎──）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01107_200054")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:…言えません
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200055")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:（ケイもアーサーも隠すわけだ…）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01107_200056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★皇帝ルーシャス★★:咎の中身によっては貴様らの信用を落としかねん<br>だから知りたい。隣人の弱みを握っていたいのだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200057")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ランスロット★★:ノワールを…守るためです
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200059")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Anger")

	--★★皇帝ルーシャス★★:言えぬというならゲーム３は未クリア<br>兵も足らず、バルバロイに呑まれるがいい
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200061")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★皇帝ルーシャス★★:…まあ言わずとも<br>どうにか口を割ってもらうがな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200063")


	--★★皇帝ルーシャス★★:ログレスとの交渉のカードは多いほうが良い<br>どのような手段を使ってでも──
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Joy")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Anger")

	--★★ランスロット★★:ならばここで<br>我が喉を裂きましょう
	Talk(Actor003,"CHRNAME_LANCELOT","speech","N","MA_01107_200066")

	close_cutin()
-- ▼直接出力
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:その行為に…なんの意味がある
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","MA_01107_200068")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:それほどの真実であると<br>お心得を
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200069")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★ランスロット★★:咎の中身だけではない<br>守るべき『本当』はまだほかにある
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200070")


	--★★ランスロット★★:貴方たちと手を組むために<br>弟弟子の父を辱めるぐらいであれば
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:俺はひとりであっても<br>ログレスとノワールを守ります
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_200072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★皇帝ルーシャス★★:………話を戻せば
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200074")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★皇帝ルーシャス★★:先のような状況で父を失ったノワールは<br>放浪の末、カレドニアの<ruby=いずこ>何処</ruby>かに住み着いた…
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200075")


	--★★皇帝ルーシャス★★:そのノワールの住まいが見たいな<br>これでゲーム３としてやらんこともない
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200077")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(false)
change_face(Actor003,"Normal")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:な…なんかいきなり投げやりじゃない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_200078")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…なにが狙いだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_200079")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:それに敵の本拠地まで食い込もうっての？<br>カレドニアはバルバロイの巣窟よ…！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_200080")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★皇帝ルーシャス★★:だから貴様らに護衛を頼むのだよ<br>出発はＸ日後としよう
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200081")


	--★★皇帝ルーシャス★★:カレドニアの内情視察は言うまでもないが…
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200082")

	PlayAction(Actor004,"to  Std_Talk")

	--★★皇帝ルーシャス★★:一番は<br>世界の救済者の泣きどころが見たいという興味
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200083")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:そういうことにしておこう<br>最強騎士の弱みに免じて
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_200085")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
