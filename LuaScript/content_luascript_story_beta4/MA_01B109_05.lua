-- このluaスクリプトは、MA_01B109_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102030020_StillImage", "content_still_10203002_image", "102030020_StillImage")
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
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
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:現状を、整理しようか
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050002")

-- ▼直接出力
show_image("102030020_StillImage", 0.0, 0.0, 0.3,false,false)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:貴公らがコルベニック城に行く前と後では<br>ブリテンの状況は大きく変わった
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01B109_050003")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:ブリテン島東部を治めていたカレドニア王<br>ライエンスは我らログレスが討ち取った
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01B109_050004")

	change_face(Actor007,"Sad")

	--★★ケイ★★:だが、ライエンスと通じていた魔女とローマが<br>混乱に乗じてカレドニア城を占拠
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01B109_050005")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:オレらがここ半年で勝ち取った地域も<br>ローマの物量にヤられちまったって話じゃねえか
	Talk(Actor008,"CHRNAME_MORDRED","speech","L","MA_01B109_050006")


	--★★ケイ★★:カレドニアの領土を手中に収めたことで<br>島の南側から東側までがローマのものとなった
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01B109_050008")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "納得")
-- ▲直接出力

	--★★トリスタン★★:南側を抑えられているのは厳しいね<br>海の向こうから援軍を呼べない
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_050009")

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
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ルーシャスは魔女と組んでいた<br>ローマの支配地区はバルバロイのそれと同義だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050010")

	open_select_window_tag(Actor001,"Normal","MA_01B109_050011","MA_01B109_050012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ルーシャスが<br>魔女やバルバロイと組む利点は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050014")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★パーシヴァル★★:バルバロイの糧…人間が沢山いる<br>ローマは格好の餌場になるんじゃない？
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B109_050015")

	change_face(Actor005,"Normal")

	--★★ヴォールス★★:餌場になったうえでバルバロイが増殖すれば<br>ローマの兵力として扱える、のだろうか…？
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B109_050016")

	change_face(Actor004,"Normal")

	--★★トリスタン★★:ルーシャスに魔女やバルバロイを御せるのかな<br>食いモノにされて終わりな気もするけどね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_050017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:どことどこが結託しようと関係ない<br>まとめて叩き潰すまでだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050019")

-- ▼直接出力
 --PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ガレス★★:長い戦争になりそうでも安心していいぞわたしがゴハン作るからな♪
	Talk(Actor009,"CHRNAME_GARETH","speech","L","MA_01B109_050020")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor010,"Normal")

	--★★ガウェイン★★:兵糧はバッチシ！だけどよォ…
	Talk(Actor010,"CHRNAME_GAWAIN","speech","L","MA_01B109_050021")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:つまり敵は、大陸とも繋がり物量でも勝るローマ<br>そしてその数を増やし続けるバルバロイと魔女…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ヴォールス★★:…まともにぶつかれば消耗戦だ<br>いずれこちらにガタが来る
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B109_050024")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★モルドレッド★★:そろそろ諦めどきかねェ王様？
	Talk(Actor008,"CHRNAME_MORDRED","speech","L","MA_01B109_050026")

	change_face(Actor003,"Smile")

	--★★アーサー★★:伝承より円卓の騎士へと<br>義務付けられた目的を忘れたか？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…「世界平和の願いを叶える聖杯を探し求め<br>その聖杯へ導く妖精を守る騎士」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050029")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:そうだ。では<br>なぜ俺たちは聖杯を探さねばならないのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050030")

	open_select_window_tag(Actor001,"Normal","MA_01B109_050031","MA_01B109_050032")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:決まってる<br>この地からバルバロイを根絶するためだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050034")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうだ。聖杯を探し、妖精を護る<br>それが円卓の騎士に課せられた使命
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050035")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:伝承が語る──<br>ＧＳを果たした、力を持つ者の責務だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050036")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:奇跡の器だからだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050038")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それも正しい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050040")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:あまねく願いを叶えると言われる聖杯…<br>それを邪な望みを持つ者に渡しては世の破滅だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050041")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:聖杯は混迷を極めた世界に現れる<br>ゆえに聖杯に願うべきはその収束…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050042")

	change_face(Actor001,"Normal")

	--★★ノワール★★:つまり、バルバロイの根絶か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050043")

	goto Block2end

::Block2end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:そして古代、バルバロイの封だった最初の武器が<br>継承者をＧＳへと導き、それを果たさせた
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050045")


	--★★アーサー★★:彼女は多くを語らなかったし<br>伝承に語られた事柄も多くはなかったが──
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:つまり継承者のＧＳと聖杯が<br>バルバロイ根絶の鍵となる…というわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050048")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:世界の破滅直前に現れる聖杯<br>バルバロイの封に導き出された継承者のキラーズ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050049")


	--★★ランスロット★★:そのふたつを手にする継承者こそが<br>世界救済の唯一の武器
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:平和の在り処は、その手の中だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050052")

-- ▼直接出力
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:…すでに妖精は世界から姿を消したとされ<br>聖杯探索は困難を極めることだろう
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050054")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:さらに探索範囲は魔女とローマの制圧下…
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B109_050055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★アーサー★★:だが、俺たちはやり遂げねばならない<br>受け継がれたもののために
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050056")


	--★★アーサー★★:善は急ごう<br>すぐに策を考える
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_050057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★パーシヴァル★★:…ブリテンを覆うローマとバルバロイを叩いて<br>どこにあるかわからない聖杯を見つける…
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B109_050058")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力

	--★★ヴォールス★★:出来ればそれこそ奇跡だが…
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B109_050059")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:聖杯を見つけ出し、ブリテンを取り返す<br>バルバロイと魔女の包囲網を突破して
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_050060")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:平和な話は、それからだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_050061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102030020_StillImage", "content_still_10203002_image", "102030020_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
