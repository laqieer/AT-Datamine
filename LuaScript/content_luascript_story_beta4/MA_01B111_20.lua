-- このluaスクリプトは、MA_01B111_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("102020040_StillImage", "content_still_10202004_image", "102020040_StillImage")
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
DontCameraOffset(Actor003)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
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
DontCameraOffset(Actor010)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_TextOnly()
	Actor012 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
end

function Play()
	StartPlay()


	--★★テロップ★★:ログレスに戻ったノワールがフィエナと語らう中<br>フィエナは聖杯の出現を感知したのだった
	Talk(Actor012,"telop","narration","N","MA_01B111_201001")


	--★★テロップ★★:
	Talk(Actor012,"telop","narration","N","MA_01B111_201002")


	--★★テロップ★★:
	Talk(Actor012,"telop","narration","N","MA_01B111_201003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:聖杯が顕現する兆しを感知したとのこと<br>間違いないな、フィエナ嬢
	Talk(Actor012,"telop","narration","N","MA_01B111_201004")

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
 --PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:聖杯が顕現する兆しを感知したとのこと<br>間違いないな、フィエナ嬢
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01B111_200002")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:うん…っ
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B111_200003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
show_image("102020040_StillImage", 0.0, 0.0, 0.3 ,false,false)
-- ▲直接出力
-- ▼直接出力
movie_load("MA_01B111_20")
movie_set_active(true)
movie_play()
movie_wait_playing()

movie_stop()
--ムービー後待機
wait_time(MOVIE_AFTER)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ローマや魔女らはその在処を既に把握している…<br>詳細な場所までわかっているかは不明だが──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_200007")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺たちは一手も二手も遅れているな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_200008")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:スノードンをずっと見張っていられれば<br>ラクだったんだけどね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_200009")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:しかし<ruby=スノードン>ローマ領のど真ん中</ruby>に我らが<br>長期に渡って陣を<ruby=し>布</ruby>くのは困難だっただろう
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B111_200010")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:後手に回るしかなかったというわけだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01B111_200012")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
hide_image(0.3)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:ま、仮にローマが先に聖杯を見つけたとしても<br>それをボクらが奪えばいいわけだよね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_200014")

	open_select_window_tag(Actor001,"Normal","MA_01B111_200015","MA_01B111_200016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:必ずこちらが先に見つけてみせるよ<br>フィエナもついてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_200018")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ガラハッド★★:広大な雪山で導きなしに杯ひとつを見つけるなど<br>いかにローマといえど出来はしないさ
	Talk(Actor009,"CHRNAME_GALAHAD","speech","L","MA_01B111_200019")

	change_face(Actor009,"Normal")

	--★★ガラハッド★★:姉上、ガラハッドらが守るよ
	Talk(Actor009,"CHRNAME_GALAHAD","speech","L","MA_01B111_200020")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★フィエナ★★:うん…お願いね
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B111_200021")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★トリスタン★★:「先に見つけさせて奪うほうがイイ」…<br>ローマ側はそう思ってるかもしれないけどね
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_200022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その選択肢も覚悟しておこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_200024")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor009,"Anger")

	--★★ガラハッド★★:正面衝突となれば姉上が危うい<br>理想は早期発見だ…！
	Talk(Actor009,"CHRNAME_GALAHAD","speech","L","MA_01B111_200025")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが不測の事態が起きる可能性もある<br>そうなれば俺たちでローマを迎え撃つぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_200026")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:やってやれないことはないさ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_200027")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★トリスタン★★:「先に見つけさせて奪うほうがイイ」<br>そう思ってるのはローマも同じかもしれないけど
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_200028")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:確かに<br>その聖杯に秘められた力は未知数…
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B111_200030")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:魔女は命を賭してその聖杯に迫った<br>そして4人の魔女姉妹のあっけない死…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_200031")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★フィエナ★★:銀卓騎士があんなすぐに退いたのも<br>…意味わかんないよね
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B111_200032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★ガラハッド★★:あねうえ…
	Talk(Actor009,"CHRNAME_GALAHAD","speech","L","MA_01B111_200034")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:万象の力が宿る器…なにが起きても不思議じゃない<br>先に見つけさせて様子見も策のひとつだよ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_200035")

	PlayAction(Actor009,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor009,"Anger")

	--★★ガラハッド★★:いいや！どちらにせよ得なければならない！<br>敵の手に渡してはならない！先に見つけるんだ！
	Talk(Actor009,"CHRNAME_GALAHAD","speech","L","MA_01B111_200036")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★トリスタン★★:けどあっちには圧倒的物量とともに魔女もいて<br>ログレスから離反した生徒もいる…
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_200037")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力

	--★★ヴォールス★★:最強騎士と拮抗した力を持つ銀卓騎士は３人<br>そして、キラーズ・カラドボルグが控えている
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B111_200038")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力

	--★★パーシヴァル★★:ボクらが聖杯を発見した途端<br>兵力で押しつぶされる可能性が高いってわけだ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_200039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:総力戦だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_200040")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:ローマ対策班・聖杯探索班はX日後<br>総員を束ね、スノードンへ出陣してくれ
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01B111_200041")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:ボクやケイ卿はログレスの守りを…<br>…捕虜で危なっかしいのもいるからね
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","MA_01B111_200043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:療養中の我らが王に<br>朗報を持ち帰ろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_200044")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:継承者が聖杯を得られれば<br>この戦いのすべてが終わる。だよね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_200045")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:わずかな伝承を信用するのならな<br>聖杯取得のあとのことは誰もわからん
	Talk(Actor006,"CHRNAME_BORS","speech","L","MA_01B111_200046")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ガウェイン★★:細かいこと考えたって仕方ねえ<br>結局は目の前の敵に今勝てるかどうかだぜ
	Talk(Actor007,"CHRNAME_GAWAIN","speech","L","MA_01B111_200047")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ブリテンからバルバロイを殲滅し<br>ローマを追い出す…
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01B111_200049")

	change_face(Actor009,"Sad")

	--★★ガラハッド★★:（そして銀卓騎士団の本当を…）
	Talk(Actor009,"CHRNAME_GALAHAD","mind","L","MA_01B111_200050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:聖杯探索最終戦だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_200052")


	--★★ランスロット★★:円卓の騎士は奇跡を継承者に<br>継承者は希望を円卓の騎士に
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_200053")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:最強騎士の劔とともに<br>終わりの続きを斬り拓く
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_200054")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")

	--★★ノワール★★:スタンド・バイ・ユアラウンド！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01B111_200056")

	close_cutin()

	--★★一同★★:フォー・ラウンド！
	Talk(Actor011,"NPCNAME_0126","speech","N","MA_01B111_200057")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102020040_StillImage", "content_still_10202004_image", "102020040_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
