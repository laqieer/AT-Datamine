-- このluaスクリプトは、MA_01107_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
-- ▲直接出力
-- ▼直接出力
load_image("10301014", "content_still_10301014_image", "103010140_StillImage")
-- ▲直接出力
-- ▼直接出力
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
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor011)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor011,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ランスロット★★:魔女は８人<br>一方、我ら円卓の騎士は現在、１０席と少し
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_050002")


	--★★モルドレッド★★:ひとりのノルマが魔女１匹足らずか<br>余裕じゃねえの
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01107_050003")

	change_face(Actor006,"Sad")

	--★★アーサー★★:だがなモルドレッド、剣を交えてわかったが<br>魔女の強さは円卓の騎士１人と同等かそれ以上
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01107_050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:俺らにはキラーズがいるじゃないっすか<br>２人で当たれば余裕ってことっすね！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01107_050005")

	change_face(Actor009,"Sad")

	--★★パーシヴァル★★:キラーズは『武器』でしょ？それを携えて戦って<br>ようやく魔女に対抗できるってことじゃないの
	Talk(Actor009,"CHRNAME_PERCIVAL","speech","L","MA_01107_050006")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★トリスタン★★:…キラーズをそうやって言うのはキライだけど<br>戦った感じ、余裕はなかったね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01107_050007")

	change_face(Actor011,"Sad")

	--★★ガレス★★:しかもバルバロイを操るんだろ～？<br>そのバルバロイも日ごとに数を増やしてるし…
	Talk(Actor011,"CHRNAME_GARETH","speech","L","MA_01107_050008")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★モルドレッド★★:このままじゃ騎士は魔女と相打ち<br>残ったバルバロイは学園になだれ込み、全滅！
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01107_050010")


	--★★モルドレッド★★:頼みの継承者サマは信用ならねえしなァ？
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01107_050011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★モルドレッド★★:妹に先を越されてんじゃねえよドンクセェ<br>早くGSを済ませてお救いくださいよ
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01107_050013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…継承者<br>それがなにかすら教えてもらえてない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050015")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:あー、それでわたしが呼ばれたワケ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_050016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:殿下。もう一度キャメリアードの伝承を<br>お聞かせ願えませんか
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01107_050018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:…『原初の劔を継ぐ者待てば<br>いずれカリバーンは抜き放たれん』
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_050020")


	--★★ギネヴィア★★:『最初の武器を携えて<br>終わりの続きを往く』…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_050021")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★アーサー★★:継承者を示す伝承だ<br>カリバーンを抜いた者だけがその力を持つという
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01107_050022")


	--★★アーサー★★:バルバロイによって終わる世界を救い<br>続いていかせる者と言われている
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01107_050023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！<br>それが『継承者』…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050025")

	change_face(Actor001,"Anger")

	--★★ノワール★★:どうして今まで<br>なにも言ってくれなかった…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050026")

-- ▼直接出力
CloseTalkWindow()
 --フェードアウト
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301014", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ケイ★★:継承者の存在は我ら円卓のみが知らされていた<br>貴公が狙われては一巻の終わりだからだ
	Talk(Actor008,"CHRNAME_KAY","simple","N","MA_01107_050028")


	--★★ヴォールス★★:我らの遠征も継承者を探すためのものだ<br>優秀なキラーズ因子を見つけるという名目でな
	Talk(Actor010,"CHRNAME_BORS","simple","N","MA_01107_050029")


	--★★モルドレッド★★:バルバロイが増え始めたから泡食って遠征して<br>そのうちにカレドニアはガンガン攻めて来て
	Talk(Actor007,"CHRNAME_MORDRED","simple","N","MA_01107_050030")


	--★★モルドレッド★★:ようやく見つけたと思ったらどうだ？<br>敵傭兵団の団長様とは恐れ入ったね
	Talk(Actor007,"CHRNAME_MORDRED","simple","N","MA_01107_050031")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ケイ★★:そのうえ…
	Talk(Actor008,"CHRNAME_KAY","simple","N","MA_01107_050032")

-- ▼直接出力
CloseTalkWindow()
 --フェードアウト
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 --エフェクト終了
hide_image()
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:（…『妖精殺し』の息子…？）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01107_050034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor008, "No", 0.3, 1.0, false)

	--★★ケイ★★:…いやともかく、貴公が相応しい者か否か<br>見極める必要があったというわけだ
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01107_050035")

	change_face(Actor005,"Smile")

	--★★トリスタン★★:ボクとしては<br>今もまだ見極め継続中だから、よろしく
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01107_050036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01107_050038","MA_01107_050039")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:その、継承者がすべきことは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
	change_face(Actor009,"Normal")

	--★★パーシヴァル★★:詳しくはわからないね。伝承にも載ってない<br>学園の大図書院にすら資料はわずか
	Talk(Actor009,"CHRNAME_PERCIVAL","speech","L","MA_01107_050042")

	play_head_motion(Actor011, "Nod", 0.3, 1.0, false)
	change_face(Actor011,"Smile")

	--★★ガレス★★:継承者にスーパーパワーみたいなのが<br>あるんじゃないかなっ！
	Talk(Actor011,"CHRNAME_GARETH","speech","L","MA_01107_050043")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうして、俺が継承者なんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor010,"Normal")

	--★★ヴォールス★★:その素養があったか<br>あるいは…
	Talk(Actor010,"CHRNAME_BORS","speech","L","MA_01107_050046")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★モルドレッド★★:神様に選ばれたんじゃねえの<br>だとすれば相当見る目がねえヤツだが
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01107_050047")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★アーサー★★:我ら円卓の騎士は追わねばならなかった<br>伝承、妖精、聖杯…現実離れしたものばかりを
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01107_050049")

	change_face(Actor006,"Normal")

	--★★アーサー★★:それにすがるしか生き残る道がなかったからだ<br>だが…ようやくお前が現れた
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01107_050050")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:…そして『<ruby=ティルフィング>最初の武器</ruby>』が多くを語らずとも<br>ノワールをＧＳへ導こうとしている…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_050052")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★モルドレッド★★:つまり、おまえがＧＳしなきゃ<br>何も始まらねえってコトだろうな
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01107_050054")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺がGSをしなければ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★モルドレッド★★:今はないものねだりしてもしょうがねェか！<br>だが、ありもので凌げる状況でもねえよなあ？
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01107_050056")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:…魔女やバルバロイに対抗することも大事だが<br>カレドニア本隊の進軍も見逃せん
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01107_050057")

	change_face(Actor010,"Sad")

	--★★ヴォールス★★:いくらこちらの騎士の練度が高くとも<br>物量差だけは覆せん…いずれ圧し潰されるぞ
	Talk(Actor010,"CHRNAME_BORS","speech","L","MA_01107_050058")

	change_face(Actor009,"Sad")

	--★★パーシヴァル★★:だからこそ戦況を変えてもらうことを信じて<br>継承者を探していたんだものね。不本意だけどさ
	Talk(Actor009,"CHRNAME_PERCIVAL","speech","L","MA_01107_050060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガウェイン★★:なあ…ローマを頼るってのはダメか？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01107_050062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor011,"Surprise")

	--★★ガレス★★:ルーシャス皇太子に？そりゃローマが<br>助けてくれたら心強いだろうけど～
	Talk(Actor011,"CHRNAME_GARETH","speech","L","MA_01107_050063")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)

	--★★ケイ★★:動機すらわからぬゲストだ<br>底知れぬゆえ、あまり触れたくはなかったが──
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01107_050064")


	--★★パーシヴァル★★:…確かにボクらに残ってるカードはそれぐらいか<br>大帝国ならお金も物量も底知れないし
	Talk(Actor009,"CHRNAME_PERCIVAL","speech","L","MA_01107_050065")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★トリスタン★★:あの気分屋が素直に首を縦に振るとは思えないね<br>…留学だって道楽なのかなんなのか不透明だし
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01107_050066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01107_050068","MA_01107_050069")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が頼みに行ってみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050071")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:…ノワール？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01107_050072")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…今やれることをしたいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050073")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:断られそうだな…<br>あの感じだと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050075")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★トリスタン★★:同感<br>キミとは珍しく意見が合ったね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01107_050076")

	change_face(Actor005,"Smile")

	--★★トリスタン★★:だからキミが断られて見せてよ
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01107_050078")

	goto Block2end

::Block2end::
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:俺も付き合うぜ、ノワール
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01107_050080")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェイン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_050081")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:なーに驚いたカオしてんだ<br>俺はお前の味方だよ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01107_050082")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Laugh")

	--★★ガウェイン★★:お前が継承者だろーが、そうでなかろーが<br>ＧＳできよーが、そうでなかろーが
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01107_050083")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★トリスタン★★:出会って３～４か月<br>薄い友情だね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01107_050084")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:友情に厚さは関係ねーよ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01107_050085")

	change_face(Actor004,"Laugh")

	--★★ガウェイン★★:ヒーロー的な熱さが要るか？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01107_050087")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ま。合うかどーかよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_050089")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10301014", "content_still_10301014_image", "103010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor011,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
