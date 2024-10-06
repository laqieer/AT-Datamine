-- このluaスクリプトは、MA_01B110_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera006 = SetTemplate("Actor006",170,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("102020020_StillImage", "content_still_10202002_image", "102020020_StillImage")
DontCameraOffset(Actor001)
set_enable_auto_lookat(Actor007,false)
set_enable_auto_lookat(Actor006,false)
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B110_071001")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B110_071002")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B110_071004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B110_071005")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:ふたつ………でたの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★パーシヴァル★★:聖杯の在処の反応が<br>一気に、ふたつぅ…？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070003")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:…念のため聞くが<br>聖杯がふたつもみっつもあるわけではないな？
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_070004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★アーサー★★:あれば乾杯できるな
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070005")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:アーサー、空気を読め
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_070007")

-- ▼直接出力
change_face(Actor007,"Normal")
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:問題はガラハッドが独断で<br>飛び出してったってことでしょ、ありえないね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070008")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定3")
-- ▲直接出力

	--★★マーリン★★:それ、パーシヴァル様が仰せになると<br>味わい深いものがありますね
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_070009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力

	--★★フィエナ★★:ごめんね…ガラハッドに聞かれて、教えちゃって…<br>気づいたらガラハッド…いなくなってて
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070011")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
lookat_delay_weight(Actor001,0.6,0.03,0.7,0,0.5)
-- ▲直接出力

	--★★フィエナ★★:もう…パニック、パニックだよ…！<br>なんでなんでこんなことになるの…！？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B110_070013","MA_01B110_070014","MA_01B110_070015")
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
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:全部はじめてのことだ、しょうがないよ<br>聖杯を探すのも、巫女としての務めも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070017")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:「しょうがない」じゃ済まされないよ…！<br>巫女としても姉としてもなにもできないで…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070018")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:はじめてにも関わらず<br>物怖じせず挑もうとしているんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_070019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺たちがついている<br>気を楽に持て。フィエナ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_070020")

-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor007,false)
set_enable_auto_lookat(Actor006,false)
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:あ、あ、ありがとうう…<br>ノワール、ランスロット…！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:こんなときにガラハッドは<br>なにを考えているんだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:が、ガラハッドを責めないで…<br>ガラハッドは一生懸命なだけなんだよ…！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070024")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★フィエナ★★:一生懸命ならなにしてもいいわけじゃないけど<br>なんか、あの子、焦ってて、ずっと………！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドの懸命な気持ちはわかるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070027")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★アーサー★★:元気でいいな！
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070028")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:ノンキにしてる場合かなあ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070029")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ヴォールス★★:学び始めの若人をフォローアップするのも<br>高い地位の者の務めだろう？
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_070030")

	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:それは、そうかもだけどさあ…！
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070031")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.5)
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:２箇所のうち、どちらかに向かったのだろうが<br>さがすとなれば戦力を分散せざるを得ない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_070033")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★アーサー★★:カーライル城と同じかそれ以上の<br>待ち伏せがあることは予想がつく
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070034")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:…単騎の暴れ馬を<br>放っておくわけにはいかないね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070035")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:ごめんなさい、ごめんなさい…！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★アーサー★★:まあ！気にするな、というのも難しいだろうが<br>なんとかなるなる！なんとかしようじゃないか！
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070038")

	change_face(Actor007,"Normal")

	--★★アーサー★★:ローマとの戦いも今は膠着状態に陥っている<br>俺たちとしては出来るだけ早く聖杯を見つけたい
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:聖杯の在処の候補地が一気にふたつも潰せる<br>そう考えれば悪いことばかりじゃないさ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_070041")


	--★★フィエナ★★:…あり、がと<br>でも──
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070042")

	change_face(Actor001,"Normal")

	--★★ノワール★★:フィエナ<br>聖杯の反応があった場所は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070043")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
show_image("102020020_StillImage", 0.0, 0.0, 0.3,false,false)
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:地図で言うと<br>ココと、ココの２箇所…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070045")

-- ▼直接出力
 --PlayPartVoice("マーリン", "納得")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★マーリン★★:『果てなき森』と呼ばれ<br>誰も寄りつかぬ密林地帯と──
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_070046")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:『滅びた都』を対岸にのぞむ<br>ブリテン島の最東部か
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070047")

-- ▼直接出力
hide_image(0.3)
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:『果てなき森』なら土地勘あるよ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070048")

	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:…好んで足を踏み入れたい場所じゃないケドね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070049")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ヴォールス★★:『滅びた都』のあたりは<br>海賊どものねぐらになっているとも聞く
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_070050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:であれば<br>ヴォールスの出番か
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_070051")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:…どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070052")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ヴォールス★★:海は<br>嫌いではないということだ
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_070053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ガラハッドが心配だ<br>手分けして２箇所を同時に調査しよう
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070055")


	--★★アーサー★★:ノワールには、どちらかに同行してもらいたい<br>矢継ぎ早でスマンが、選択は任せよう
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070056")

-- ▼直接出力
lookat_delay_weight(Actor001,0.6,0.03,0.7,0,0.5)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:フィエナちゃんは…<br>ノワールについてってもいいかな…？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070057")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ。もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070058")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:へ、へへ。ありがと
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070059")

	open_select_window_tag(Actor001,"Normal","MA_01B110_070060","MA_01B110_070061")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
change_face(Actor003,"Normal")
lookat_delay_weight_reset(Actor001,0.5)
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:『果てなき森』の調査に行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070063")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★パーシヴァル★★:げっ！？<br>ボクたちだけでじゅうぶんなのに！
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070064")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★マーリン★★:ならばノワール様が加われば十二分ですね<br>心強いですね。よかったですね
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_070065")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
change_face(Actor003,"Normal")
lookat_delay_weight_reset(Actor001,0.5)
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:『滅びた都前』の調査に行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070067")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ヴォールス★★:クレアの高説の聞き役が増えて<br>ありがたい
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_070068")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:お、お手柔らかに…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070069")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★アーサー★★:俺も同行したいところだが…
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070071")

	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "怒り")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★マーリン★★:ダメです。モルガン様が心を砕きますから<br>ローマの動向も睨んで頂かないと
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_070072")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight(Actor001,0.6,0.03,0.7,0,0.5)
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:りゅ、留学生ばっかり問題起こしてる…<br>ごめんなさい、本当にごめんなさい…！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070073")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B110_070074","MA_01B110_070075")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ルーシャスといっしょにしないでくれ<br>フィエナやガラハッドとは違うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070077")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ヴォールス★★:…ガラハッドも<br>なにか考えがあっての行動だろう
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_070078")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺たちが責任をもって連れ戻そう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_070079")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ありがとう<br>ノワール、ランスロット…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070080")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ガラハッドを連れ戻さないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070082")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:若気の至りは先達が指導しなければね<br>これも高貴なる者の務めさ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_070083")

	change_face(Actor003,"Surprise")

	--★★フィエナ★★:えと、多分パーシヴァルもガラハッドも<br>そんなに年齢変わらないけど、ありがとう…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070084")

	open_cutin(1,1)
	on_cutin(1,Actor004,"Anger")
	change_face(Actor004,"Anger")

	--★★パーシヴァル★★:ニュアンスのハナシをしてるんだよボクぁ！！
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","N","MA_01B110_070085")

	close_cutin()
	goto Block3end

::Block3end::
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ちゃんとお姉さんに叱ってもらおう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_070087")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor007,false)
set_enable_auto_lookat(Actor006,false)
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:…！<br>うんっ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070088")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.5)
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★アーサー★★:探索班の戦力が分散されるのが心配だ<br>ローマ対策班が島中のバルバロイへ陽動をかける
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070089")


	--★★アーサー★★:急ぎたいところだが<br>出発はX日後、そこまでは堪えてくれ
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01B110_070090")

	open_cutin(1,1)
	on_cutin(1,Actor006,"Normal")

	--★★マーリン★★:スタンド・バイ・ユアラウンド
	Talk(Actor006,"CHRNAME_MERLIN","speech","N","MA_01B110_070091")

	close_cutin()
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力

	--★★一同★★:フォー・ラウンド！
	Talk(Actor008,"NPCNAME_0126","speech","N","MA_01B110_070092")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:…足並みを揃えなきゃダメだよね<br>走ってばかりじゃいけないよ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070093")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力

	--★★フィエナ★★:ガラハッド──<br>今から叱りに行くからね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_070094")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102020020_StillImage", "content_still_10202002_image", "102020020_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
