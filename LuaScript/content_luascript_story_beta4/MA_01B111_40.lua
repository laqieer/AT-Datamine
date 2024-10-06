-- このluaスクリプトは、MA_01B111_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor009)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:しかし、そこにペレス王と<ruby=シルバタブラナイツ>銀卓騎士団</ruby>が襲来し<br>一転して窮地に陥る
	Talk(Actor010,"telop","narration","N","MA_01B111_401001")


	--★★テロップ★★:フィエナの説得でペレス王は退くが、ギネヴィア<br>とマーリンは連れ去られてしまうのだった
	Talk(Actor010,"telop","narration","N","MA_01B111_401002")


	--★★テロップ★★:
	Talk(Actor010,"telop","narration","N","MA_01B111_401003")


	--★★テロップ★★:
	Talk(Actor010,"telop","narration","N","MA_01B111_401004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:最悪だな
	Talk(Actor010,"telop","narration","N","MA_01B111_401006")

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
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:最悪だな
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400002")


	--★★モルドレッド★★:４ヵ所の聖杯の封をだらだら開けてる間に<br>銀卓騎士は魔女と同化して力を得やがった
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400003")

	change_face(Actor001,"Smile")

	--★★モルドレッド★★:『最強騎士』と同等の力を持つらしき<br>『最凶騎士』が３人だってェ？お手上げだね
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:スノードンじゃあローマにかまけてるうちに<br>漁夫の利を得られちまったってワケだろ？
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400006")


	--★★モルドレッド★★:王すら守れねえで<br>騎士の称号が泣くぜ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400007")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:…戦いに不参加の貴公に<br>言えた義理があるかね
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_400008")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★モルドレッド★★:留守を守った甲斐がなかったなあ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400009")

-- ▼直接出力
 --PlayPartVoice("ガレス", "悩む")
-- ▲直接出力

	--★★ガレス★★:でもさ、ローマ大帝国は追い返したんだよね？<br>祝勝パーティものだよね、本来
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01B111_400010")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:…カレドニア南にあるサンダーンの港町から<br>大きな船に乗って島を出て行ったって話だ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01B111_400011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor005,"Normal","MA_01B111_400012","MA_01B111_400013","MA_01B111_400014")
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
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:ルーシャスは聖杯を諦めたのか？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400016")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★パーシヴァル★★:真意はつかみかねるけど<br>そういうことなんだろうね
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B111_400017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガレス★★:しばらくはローマからの<br>横槍が入ることもないってことだね、たぶん！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01B111_400018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:ローマ対策班の仕事も一段落か<br>お疲れ様、ガウェイン
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400020")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:まだ残党兵の掃討が残ってるけどな
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01B111_400021")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ランスロット★★:だがこれで厄介事のひとつが片付いた<br>それだけでも充分ありがたいさ
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","MA_01B111_400022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:ローマについていった人も？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400024")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:ヴェルナルス大将軍も行っちまったよ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01B111_400025")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★トリスタン★★:ラシアにフレン、ローラも<br>着いて行っちゃったみたいだね
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_400026")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ヴォールス★★:彼女たちがローマについた理由も<br>わからずじまいになってしまったな
	Talk(Actor009,"CHRNAME_BORS","speech","L","MA_01B111_400027")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:…継承者様がいやがるんだ<br>そのぐらいはしてもらわねえと
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400029")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★トリスタン★★:聖杯も勝ち取ったわけだよね？
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_400030")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★パーシヴァル★★:ああ<br>ノワールがやってくれたよ
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B111_400031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:聖杯の奇跡とやらはいつになったら<br>どうやったら起きるのかねえ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400033")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:それについては後日<br>フィエナ嬢より話があるそうだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_400034")


	--★★ケイ★★:今は…ガラハッドが落ち着くまで<br>傍にいたいと言っていたが
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_400035")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★モルドレッド★★:おじいちゃんに見放されて<br>落ち込んじゃいました、か？悠長なこって
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400036")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ランスロット★★:アーサーの傷は
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","MA_01B111_400037")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガウェイン★★:致命傷は避けられたって…<br>モルガン先生が診てくれてる
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01B111_400038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:ギリギリだな…どこもかしこも
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_400039")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:だが希望はある<br>そうだろう、ノワール？
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","MA_01B111_400040")

	open_select_window_tag(Actor005,"Normal","MA_01B111_400041","MA_01B111_400042","MA_01B111_400043")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:戦うべき敵は決まっている
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400045")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★パーシヴァル★★:ペレス王、銀卓騎士…だね
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B111_400046")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ヴォールス★★:奴らの真意はフィエナを問い詰めてでも<br>明らかにする必要があるがな
	Talk(Actor009,"CHRNAME_BORS","speech","L","MA_01B111_400047")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:守るべきものはまだ残っている
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400049")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:学園や城下町は平穏無事！<br>アーサー様はピンピンとまではいかねえが…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01B111_400050")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★トリスタン★★:ローマを退けられたんだ<br>着実に、進んでいるじゃないか
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_400051")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:円卓の騎士で成し遂げよう<br>…いや、円卓の騎士だけじゃない
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400053")

	change_face(Actor005,"Normal")

	--★★ノワール★★:今、この国には銀卓騎士もいる<br>円卓と銀卓とで協力し、魔女を討とう
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400054")

-- ▼直接出力
 --PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:だったら、ふたつの卓いっぱいになるくらい<br>ご馳走を用意しないと！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01B111_400056")

	goto Block2end

::Block2end::
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:王妃殿下と宮廷魔導士殿が消息不明で<br>よくもめでてえこと言えるもんだ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400058")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:兵たちが総出で探索を続けている<br>ペレス王の行方も含めてな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_400060")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "否定")
-- ▲直接出力

	--★★モルドレッド★★:やめさせろソレ<br>ムダだから
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール★★:諦めろって言うのか…！？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400062")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:目星はついてるっつってんだ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400063")

	change_face(Actor001,"Smile")

	--★★モルドレッド★★:帰ってったんだよ<br>銀卓騎士とぺレスのヤローは己の巣穴に
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400064")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ヴォールス★★:モルドレッド…<br>なぜそんなことを知っている
	Talk(Actor009,"CHRNAME_BORS","speech","L","MA_01B111_400066")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:帰りが遅ぇからスノードンをチラ見しに行ったら<br>奴らが去ってくとこ見たンだよ、そんだけ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400068")

-- ▼直接出力
 --PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガレス★★:うーわー<br>心配で見に行ってたんだぁぁ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01B111_400069")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★モルドレッド★★:アーサーのヤロウがどんなツラでやられんのか<br>笑いに行っただけだよ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400070")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★トリスタン★★:追いかけなかったわけ？<br>ペレス王のこと
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_400071")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:山から下りて来るログレスの負傷兵ほっといて？<br>よくもまあそんな無慈悲なこと言えるなァ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400073")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ★★:…懸命な判断だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B111_400074")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:それに奴らが帰る場所──<br>向かう先はひとつしかねえだろ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400075")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:………コルベニック城
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01B111_400076")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★モルドレッド★★:敵の根城でテメエの故郷<br>な？最悪だろ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01B111_400077")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
