-- このluaスクリプトは、MA_01B109_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
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
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	demo_loadend_area2adv()
end

function Play()
	StartPlay()


	--★★テロップ★★:コルベニック城の状況を気にしつつも<br>円卓の騎士たちは行動を開始するのだった
	Talk(Actor011,"telop","narration","N","MA_01B109_161101")


	--★★テロップ★★:
	Talk(Actor011,"telop","narration","N","MA_01B109_161102")


	--★★テロップ★★:
	Talk(Actor011,"telop","narration","N","MA_01B109_161103")


	--★★テロップ★★:
	Talk(Actor011,"telop","narration","N","MA_01B109_161104")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:ブリテン島西部南端<br>ローマ領ロンディニウム
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160002")


	--★★ケイ★★:ローマは自国の領土であるその都で<br>民衆の大量虐殺を敢行
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160003")


	--★★ケイ★★:その罪を、我々ログレスに擦りつけた<br>ローマの意図は不明だが…
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ケイ★★:ローマ軍は大義名分を得た<br>「ログレスという悪からブリテンを守る」と
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160005")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ローマを放っておくわけにはいかない<br>しかし、バルバロイ殲滅のためにも…
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160006")


	--★★アーサー★★:円卓の騎士本来の目的である<br>聖杯探索の手を休めるわけにもいかない
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160008")


	--★★アーサー★★:なによりまず、奇跡の器と言われる聖杯を<br>ローマやバルバロイに渡してはならない
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160009")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★マーリン★★:あれは万人の願望──大望を叶えるべく<br>万象の力が宿る器と言われています
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B109_160011")

	PlayAction(Actor006,"to  Std_Talk")

	--★★マーリン★★:継承者が聖杯の奇跡を得られれば<br>バルバロイの根絶が可能になると言われています
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B109_160012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:伝承に頼るのみ…綱渡りではありますが<br>戦いの終わりのために聖杯発見は急務です
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B109_160013")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:これより我ら円卓が成すべき任務はふたつ
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160014")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:ひとつ。ルーシャスをぶっ飛ばし<br>大帝国ローマの尖兵をブリテンから叩き出すこと
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","MA_01B109_160015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力

	--★★パーシヴァル★★:ふたつ。聖杯を探し出し、奇跡とやらを得て<br>世界からバルバロイの脅威を排除すること
	Talk(Actor007,"CHRNAME_PERCIVAL","speech","L","MA_01B109_160016")


	--★★ケイ★★:これより先、円卓の騎士は<br>聖杯探索班とローマ対策班に分かれる
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160017")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	open_cutin(3,1)
	on_cutin(1,Actor001,"Normal")
	on_cutin(2,Actor010,"Normal")
	on_cutin(3,Actor007,"Normal")

	--★★アーサー★★:まずは聖杯探索班、ランスロットを筆頭に<br>ノワール、ヴォールス、そしてパーシヴァル
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160018")

	close_cutin()
	open_cutin(3,1)
	on_cutin(1,Actor005,"Normal")
	on_cutin(2,Actor002,"Normal")
	on_cutin(3,Actor008,"Normal")

	--★★アーサー★★:ローマ対策班は義兄さんをブレーンとして<br>ギネヴィアとガウェインがログレス本隊を率いる
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_160021","MA_01B109_160022","MA_01B109_160023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	close_cutin()
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor010,"Normal")

	--★★ヴォールス★★:敵地で杯ひとつを見つけ出すのか<br>クレアの力を借りる必要がありそうだな
	Talk(Actor010,"CHRNAME_BORS","speech","L","MA_01B109_160025")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★パーシヴァル★★:聖なる杯、高貴なボクにこそ相応しい宝物だ<br>大船に乗ったつもりでいたまえ諸君？
	Talk(Actor007,"CHRNAME_PERCIVAL","speech","L","MA_01B109_160026")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★トリスタン★★:泥船じゃないの？
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","MA_01B109_160027")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:大丈夫だ、優秀な船長をつける<br>こちらの班の指揮を、ランスロットに任せる
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160028")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:任された
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B109_160029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	close_cutin()
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:王妃殿下を前線に出すのはいささか抵抗もあるが<br>心強い戦力ではある、当人の覚悟も無視出来ぬ
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160031")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ガウェイン★★:殿下が士気を引き上げて、俺が斬り込む<br>ローマには俺も殿下も因縁があるんだ
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","MA_01B109_160032")

	change_face(Actor008,"Smile")

	--★★ガウェイン★★:やってやるよ
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","MA_01B109_161001")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:売られた喧嘩は<br>ログレスをあげて買ったげるわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_160033")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:頼もしいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_160034")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にっしっし♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_160035")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	close_cutin()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ローマやバルバロイの物量を考えると<br>心もとない戦力だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_160037")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえば<br>ガレスとモルドレッドは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_160038")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:ガレスには食で学園の士気を維持してもらいつつ<br>学園自体の守護も任務に兼ねる
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160039")

-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ケイ★★:モルドレッドは…<br>ここのところ姿が見えん
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160040")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★トリスタン★★:興味ないことにはとことん無関心だもんね<br>ま、学園の治安は僕も見張っておくよ
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","MA_01B109_160041")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ケイ", "納得")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:ローマ対策班は早急にロンディニウム奪還へ…<br>聖杯探索班の出発はX日後、としたいが
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B109_160043")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:聖杯探索は困難を極める可能性が高い<br>ノワールたちにはもう一組、留学生を預けたい
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160044")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:留学生？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B109_160045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:後日引き合わせるよ<br>知らない顔ではないはずだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160046")


	--★★アーサー★★:ランス、お前と<br>初めて会ったときのことを思い出したよ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160047")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "怒り")
-- ▲直接出力

	--★★ランスロット★★:…アーサー？なんだって？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B109_160048")

	change_face(Actor004,"Normal")

	--★★アーサー★★:流浪の末に辿り着いた学園…<br>彼女らもなりふり構ってはいられなさそうだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160049")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:あのときのお前と<br>よく似た顔をしていたよ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B109_160050")

	EndPlay()
	demo_playend_area2adv()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
