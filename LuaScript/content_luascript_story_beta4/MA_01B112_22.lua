-- このluaスクリプトは、MA_01B112_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera007 = SetTemplate("Actor007",10.9,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera008 = SetTemplate("Actor008",25.41,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:正面突破と行こうか諸君
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220002")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:ローマ対策班は依然<br>きゃつら残党の対応に追われている
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220003")


	--★★ランスロット★★:動けるのは俺たちだけか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_220004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:少数精鋭で聖杯城へ向かい<br>ペレス王並びに銀卓騎士団との決着をつける
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220005")

	change_face(Actor005,"Sad")

	--★★ケイ★★:ギネヴィア殿下とマーリンの救出は<br>どうしたところでその後となるだろう
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220007")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:ハドリアヌス・ウォールがある以上<br>こっそり侵入して救出…ってのは無理だもんね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B112_220008")


	--★★ボールス★★:…嫌なことを尋ねるが<br>既に殺されている可能性は？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B112_220009")

-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:ギネヴィア殿下のキラーズであるギネマウアに<br>目立った変調が見られないことから…
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220010")


	--★★ケイ★★:希望的観測ではあるが<br>無事と考えて良いだろう
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:…マーリン様はわかんないよね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B112_220012")


	--★★ガラハッド★★:ふたりとも、きっと無事だ
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B112_220013")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定3")
-- ▲直接出力

	--★★ボールス★★:その根拠は？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B112_220014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ガラハッド★★:エクセリアやリリアーナと話してわかった<br>お爺様もアステラも迷いのなかにある
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B112_220015")


	--★★ガラハッド★★:なにが最良の選択か決めかねているように思う<br>まるで決断をこちらに委ねてくれているような
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B112_220016")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:なんの選択を委ねるというのだ…？
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_220018","MA_01B112_220019","MA_01B112_220020")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちが生にすがるか…<br>死を受け入れるか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_220022")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:生きようとするなら決着をつけなければならない<br>死をただ待つならばこのままでいればいいと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_220023")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:生きたいに決まってるじゃないか
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B112_220024")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:ガラハッドやフィエナが<br>家族と訣別しなければならないとしても？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B112_220025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:試されているのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_220027")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★フィエナ★★:スノードンで終わらせることも<br>出来たはずだもんね
	Talk(Actor008,"CHRNAME_VIENA","speech","L","MA_01B112_220028")

	change_face(Actor006,"Sad")

	--★★アーサー★★:待っているのか<br>ノワールとランスロットの帰還と…
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220029")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ガラハッドとフィエナの決断を
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_220030")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ペレス王に残った良心が<br>そうさせているのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_220032")

-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:それこそ希望的観測というやつだな
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220033")

	change_face(Actor007,"Normal")

	--★★ガラハッド★★:…だが、僕は希望を信じる<br>ノワール
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B112_220034")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★ケイ★★:奴らは明らかにアーサーを狙っていたとも聞く<br>王自らの出陣は遠慮願いたい
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220036")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:なおさらだ<br>囮にでもなんでもなろう
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220037")

	change_face(Actor005,"Sad")

	--★★ケイ★★:アーサー…王として無謀な振る舞いは<br>どうか自重してくれないか
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:ギネヴィアとマーリンの命がかかっている<br>残り少ない俺の命で救えるのなら──
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220039")

-- ▼直接出力
 --PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ケイ★★:ならばこそ限られた生を<br>己のために使いたいとは思わないのか…！？
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220040")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:ケイ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_220041")

-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ケイ★★:バルバロイとの戦いもGSも<br>騎士たちの自己犠牲に頼る面が多すぎる
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220042")


	--★★ケイ★★:ゆえに貴公は自らの犠牲を顧みない<br>被害を己に集め、生徒の歩みを妨げさせない
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220044")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:王の血筋を継いだというだけで<br>弱き者を守るべく矢面に立ち続けた
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220045")


	--★★ケイ★★:多くの死を無駄にせぬよう<br>走り続けることを余儀なくされている
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "激怒")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ケイ★★:だがそれで貴公になにが残る<br>なにが返ってくる、アーサー…！
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220047")


	--★★アーサー★★:見返りを求めた命ではない
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220049")

-- ▼直接出力
 --PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★アーサー★★:友が笑って過ごせる日々が<br>叶うのならばそれで良い
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220050")

	change_face(Actor006,"Normal")

	--★★アーサー★★:王として生きるのだ<br>尊重すべきは俺ではない
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ケイ★★:英雄の座は継承者に譲り…<br>最強の名はランスロットに輝き、それで貴公は…
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01B112_220052")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★アーサー★★:俺が走った血路の先に<br>誰かの平和があればいい
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220053")

	change_face(Actor006,"Normal")

	--★★アーサー★★:本当の俺など、捨て置けるよ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01B112_220054")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
