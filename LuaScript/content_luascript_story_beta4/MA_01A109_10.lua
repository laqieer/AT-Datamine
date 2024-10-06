-- このluaスクリプトは、MA_01A109_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,true)
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
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor010")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ケイ★★:ブリテン島西部南端<br>ローマ領ロンディニウム
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100002")


	--★★ケイ★★:ローマは自国の領土であるその都で<br>民衆の大量虐殺を敢行
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:その罪を、我々ログレスに擦りつけた<br>ローマの意図は不明だが…
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:ローマ軍は大義名分を得た<br>「ログレスという悪からブリテンを守る」と
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100005")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ローマを放っておくわけにはいかない<br>しかし、バルバロイ殲滅のためにも…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100006")

	PlayAction(Actor002,"to Sit01_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:円卓の騎士本来の目的である<br>聖杯探索の手を休めるわけにもいかない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100008")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Normal")

	--★★マーリン★★:なによりまず聖杯を<br>ローマやバルバロイに渡してはなりません
	Talk(Actor003,"CHRNAME_MERLIN","speech","N","MA_01A109_100009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:あれは万人の願望──大望を叶えるべく<br>万象の力が宿る器と言われています
	Talk(Actor003,"CHRNAME_MERLIN","speech","N","MA_01A109_100010")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:継承者が聖杯の奇跡を得られれば<br>バルバロイの根絶が可能となると言われています
	Talk(Actor003,"CHRNAME_MERLIN","speech","N","MA_01A109_100012")


	--★★マーリン★★:伝承に頼るのみ…綱渡りではありますが<br>戦いの終わりのために聖杯発見は急務です
	Talk(Actor003,"CHRNAME_MERLIN","speech","N","MA_01A109_100013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	close_cutin()
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:これより我ら円卓が成すべき任務はふたつ
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100014")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:ひとつ。ルーシャスをぶっ飛ばし<br>大帝国ローマの尖兵をブリテンから叩き出すこと
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A109_100015")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力

	--★★パーシヴァル★★:ふたつ。聖杯を探し出し、継承者に奇跡を与え<br>世界からバルバロイの脅威を排除すること
	Talk(Actor008,"CHRNAME_PERCIVAL","speech","L","MA_01A109_100016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "納得")
-- ▲直接出力

	--★★ケイ★★:これより先、円卓の騎士は<br>聖杯探索班とローマ対策班に分かれる
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100017")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:まずローマ対策班はケイ卿をブレーンとして<br>ノワール、ギネヴィア、ガウェイン
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100018")


	--★★アーサー★★:聖杯探索班はブリテン島中を飛び回ってもらう<br>ランスロット、ヴォールス、そしてパーシヴァル
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100020")

	open_select_window_tag(Actor007,"Normal","MA_01A109_100022","MA_01A109_100023","MA_01A109_100024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ヴォールス★★:敵地で杯ひとつを見つけ出すのか<br>クレアの力を借りる必要がありそうだな
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01A109_100026")

	PlayAction(Actor008,"to Sit01_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★パーシヴァル★★:聖なる杯、高貴なボクにこそ相応しいよ<br>大船に乗ったつもりでいたまえ諸君？
	Talk(Actor008,"CHRNAME_PERCIVAL","speech","L","MA_01A109_100027")

	change_face(Actor010,"Normal")

	--★★トリスタン★★:泥船じゃないの？
	Talk(Actor010,"CHRNAME_TRISTAN","speech","L","MA_01A109_100028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:大丈夫だ、優秀な船長をつける
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100029")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ランスロット★★:任された
	Talk(Actor009,"CHRNAME_LANCELOT","speech","L","MA_01A109_100030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ケイ★★:王妃殿下を前線に出すのは<br>いささか抵抗もあるが
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100032")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:殿下が士気を引き上げて、俺が斬り込む<br>ローマにゃ俺も殿下も因縁あんだ、やったるよ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A109_100033")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ギネヴィア★★:売られた喧嘩は<br>ログレスをあげて買ったげるわ
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01A109_100034")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ノワール★★:頼もしいよ
	Talk(Actor007,"CHRNAME_NOIR","speech","L","MA_01A109_100035")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ギネヴィア★★:にっしっし♪
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01A109_100036")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ノワール★★:ローマやバルバロイの物量を考えると<br>心もとない戦力だな
	Talk(Actor007,"CHRNAME_NOIR","speech","L","MA_01A109_100038")

	change_face(Actor007,"Normal")

	--★★ノワール★★:そういえば<br>ガレスとモルドレッドは？
	Talk(Actor007,"CHRNAME_NOIR","speech","L","MA_01A109_100039")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:ガレスには食で学園の士気を維持しつつ<br>学園自体の守護も任務に兼ねてもらうつもりだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100040")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ケイ★★:モルドレッドは…<br>ここのところ姿が見えん
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100041")

	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor010,"Normal")

	--★★トリスタン★★:興味ないことにはとことん無関心だもんね<br>ま、学園の治安はボクも見張っておくよ
	Talk(Actor010,"CHRNAME_TRISTAN","speech","L","MA_01A109_100042")

	goto Block1end

::Block1end::
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★ギネヴィア★★:ローマ大帝国、デカい的よ<br>ブチ抜いてやるわ
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01A109_100044")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:継承者の劔<br>その力、存分に発揮してくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100045")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ノワール★★:あんたの力あってのＧＳだった<br>期待に応えてみせるよ、必ず
	Talk(Actor007,"CHRNAME_NOIR","speech","L","MA_01A109_100047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:任せたぞ、ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ケイ★★:ローマ対策班はひとまず軍備を整えねばなるまい<br>先の戦いからの疲弊もあるだろうが──
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100050")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ケイ★★:…最も懸念すべきは学園内の士気であろうな
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100051")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:ラグネルが気づいたっぽいんだけどさ<br>ログレスの服着たローマ兵の仕業じゃねーかって
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A109_100052")

	change_face(Actor005,"Normal")

	--★★ヴォールス★★:…ルーシャスがキャメロット在学中に<br>不自然なほどログレスの服を調達していたという
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01A109_100053")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:その痕跡も見つけ出した<br>クレアの手柄だ
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01A109_100054")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ケイ★★:…ローマはそれが明らかにされることぐらい<br>想定済み、とみて良さそうだな
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_100055")


	--★★ノワール★★:ほかに狙いがあるということか？
	Talk(Actor007,"CHRNAME_NOIR","speech","L","MA_01A109_100056")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…大陸に救援は望めない、大帝国の物量の脅威<br>濡れ衣を晴らしたところで状況は変わらんな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ちょっと…お時間を<br>いただいてもいいかしら陛下
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01A109_100059")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:すぐにロンディニウムへ向かいたいところだが<br>学内の足並みを揃えねば始まらない…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100060")


	--★★アーサー★★:ギネヴィア、お前は存分に休んで──
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_100061")

	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "否定")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ギネヴィア★★:いーえ休んでるヒマなんてないわ<br>ちょっとばかりお色直しのお時間をくださる？
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01A109_100062")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★ギネヴィア★★:派手にいきましょ<br>どうせなら
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","MA_01A109_100064")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
