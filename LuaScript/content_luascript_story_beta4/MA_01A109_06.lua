-- このluaスクリプトは、MA_01A109_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera012 = SetTemplate("Actor012",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102030020_StillImage", "content_still_10203002_image", "102030020_StillImage")
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{-0.71, 0.03672, -12.03})
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
Hide(Actor008)
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
-- ▼直接出力
DontCameraOffset(Actor012)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_2DOnly("101011","001","101011001")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor011,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	PlayAction(Actor001,"to Bow")
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力

	--★★ラヴェイン★★:お初にお目にかかる方も多いかと存じます<br>ラヴェインと申します、お見知りおきを
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_060002")

-- ▼直接出力
OpenFirstAppearance(Actor001)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:早速で申し訳ないが<br>報告を願えるか
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01A109_060003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラヴェイン★★:ローマの都ロンディニウムにて<br>市民の大量虐殺が起きました
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_060004")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor009,"Surprise")

	--★★パーシヴァル★★:ぎゃ、虐殺ってさ<br>あのロンディニウムで？
	Talk(Actor009,"CHRNAME_PERCIVAL","speech","L","MA_01A109_060006")


	--★★パーシヴァル★★:例えば賊程度の奴らに<br>襲える規模じゃないよね！？
	Talk(Actor009,"CHRNAME_PERCIVAL","speech","L","MA_01A109_060007")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:バルバロイ、あるいはカレドニアの残党か…<br>いずれにせよ何のメリットがある…？
	Talk(Actor010,"CHRNAME_BORS","speech","L","MA_01A109_060008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラヴェイン★★:………ログレス兵が<br>ローマ市民を虐殺していました
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_060009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:な、なにかの見間違いじゃねーのか！？<br>誰がやんだよ、ンなこと！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A109_060011")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラヴェイン★★:『ログレス軍』と名乗る者たちが都を占領<br>虐殺を免れ、運よく逃げ延びた人たちも──
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_060012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラヴェイン★★:ログレスが<br>ロンディニウムの住人を虐殺したことを
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_060013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:ほうぼうで口にしています
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_060014")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルドレッド★★:<ruby=ルーシャス>ローマ皇太子</ruby>がバルバロイ側にイっちまったから<br>報復のためにやったんじゃねえか！とかァ？
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01A109_060016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor011, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "怒り")
-- ▲直接出力
	change_face(Actor011,"Anger")

	--★★ガレス★★:<ruby=ログレス>私たち</ruby>がそんな向こう見ずなことしないっ！<br>なんのトクもないし！意味もないし！
	Talk(Actor011,"CHRNAME_GARETH","speech","L","MA_01A109_060018")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:真実は重要ではない…ローマ軍は手にしたんだ<br>「悪であるログレスを討つ」という大義名分を
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_060020")


	--★★ノワール★★:それが、ルーシャスの狙いか…？
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060021")

-- ▼直接出力
CloseTalkWindow()
show_image("102030020_StillImage", 0.0, 0.0, 0.3,false,false)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:惨状を………整理しようか
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01A109_060022")


	--★★ケイ★★:…ブリテン島東部を治めていたカレドニア王<br>ライエンスは我らログレスが討ち取った
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01A109_060023")


	--★★ケイ★★:だが、ライエンスと通じていた魔女とローマが<br>混乱に乗じてカレドニア城を占拠
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01A109_060024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★モルドレッド★★:オレらがここ半年で勝ち取った地域も<br>ローマの物量にヤられちまったって話じゃねえか
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01A109_060025")


	--★★ケイ★★:カレドニアの領土を手中に収めたことで<br>島の南側から東側までがローマのものとなった
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01A109_060027")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor012,"Sad")

	--★★トリスタン★★:南側を抑えられているのは厳しいね<br>海の向こうから援軍を呼べない
	Talk(Actor012,"CHRNAME_TRISTAN","speech","L","MA_01A109_060028")

-- ▼直接出力
setup_small_camera_end()
CloseTalkWindow()
hide_image(0.3)
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ルーシャスは魔女と組んでいた<br>ローマの支配地区はバルバロイのそれと同義だ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_060029")

	open_select_window_tag(Actor006,"Normal","MA_01A109_060031","MA_01A109_060032")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor006,"Normal")

	--★★ノワール★★:ルーシャスが<br>魔女やバルバロイと組む利点は？
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060034")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★パーシヴァル★★:バルバロイの糧…人間が沢山いる<br>ローマは格好の餌場になるんじゃない？
	Talk(Actor009,"CHRNAME_PERCIVAL","speech","L","MA_01A109_060035")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor010,"Normal")

	--★★ヴォールス★★:餌場になったうえでバルバロイが増殖すれば<br>ローマの兵力として扱える、のだろうか…？
	Talk(Actor010,"CHRNAME_BORS","speech","L","MA_01A109_060036")

	change_face(Actor012,"Normal")

	--★★トリスタン★★:ルーシャスに魔女やバルバロイを御せるのかな<br>食いモノにされて終わりな気もするけどね
	Talk(Actor012,"CHRNAME_TRISTAN","speech","L","MA_01A109_060037")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ノワール★★:どことどこが結託しようと関係ない<br>まとめて叩き潰すまでだ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060039")

	play_head_motion(Actor011, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor011,"Smile")

	--★★ガレス★★:長い戦争になりそうでも安心していいぞ～♪<br>ガレスちゃんがゴハン作ったげるからな
	Talk(Actor011,"CHRNAME_GARETH","speech","L","MA_01A109_060040")

	change_face(Actor003,"Sad")

	--★★ガウェイン★★:兵糧はバッチシ！だけどよォ…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A109_060041")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:つまり敵は、大陸とも繋がり物量でも勝るローマ<br>そしてその数を増やし続けるバルバロイと魔女…
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01A109_060043")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★モルドレッド★★:まともにぶつかりゃ消耗戦だ<br>いずれこっちにガタが来る
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01A109_060044")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01104_20_DoorOpen")
wait_time(2.0)
EntryWalk(Actor008,Camera008,EntryData110051_02_17,CameraAssetBundleName110051_02,CameraPos110051_02_117)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:当たって砕けるだけよ
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor001,Actor008,"J_Head",0.5)
set_enable_auto_lookat(Actor008,true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラヴェイン★★:…貴方は
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_060047")


	--★★ギネヴィア★★:継承者の劔、世界救済の要<br>ログレスに求められし可憐な一振り
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060048")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア★★:キラーズ・アロンダイトと申します<br>以後お見知りおきをどうぞよろしく
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060050")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力

	--★★モルドレッド★★:可憐か知らねえが王妃サマに手を付けるたぁ<br>兄上の胸中たるやいかほど…ってな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01A109_060051")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ギネヴィア★★:わたしが選んだ道よ<br>苦情はわたしが受け付けます
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:野次ぐらい飛ばさせてくれや
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01A109_060054")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
lookat_delay_weight_reset(Actor001,0.6)
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア★★:黙らせて差し上げるわ<br>文句垂れる奴は誰であろうとね
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060055")

	open_select_window_tag(Actor006,"Normal","MA_01A109_060057","MA_01A109_060058","MA_01A109_060059")
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
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ノワール★★:同じ気持ちだよ、ギネヴィア
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060061")

	change_face(Actor008,"Normal")

	--★★ギネヴィア★★:だから、わたしだったんでしょ？ノワール
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060062")

	change_face(Actor006,"Normal")

	--★★ノワール★★:君の勝ち気さに救われるんだ。いつも
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060063")

	PlayAction(Actor008,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア★★:やる気だけは誰にも負けませんっ
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060064")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ノワール★★:慎重に行こう。問題は山積みだ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060066")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ロンディニウム解放のほかにもやることはある<br>我々は聖杯を探すことも忘れてはならない
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01A109_060067")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:聖杯がバルバロイやローマに渡ることだけは<br>絶対に阻止する必要があるからな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_060068")

	PlayAction(Actor008,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ギネヴィア★★:わーかってるわよ、そんなコト！<br>鼓舞してんの！折れない気持ちが大事なの！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060069")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ノワール★★:とはいえ…どうすればいいんだ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060071")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:弱気になってんじゃねーよ<br>殿下がせっかく元気付けてくれてんのに
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A109_060072")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor012,"Normal")

	--★★トリスタン★★:どうするかなんていうのは<br>円卓で考えればいいんじゃない？
	Talk(Actor012,"CHRNAME_TRISTAN","speech","L","MA_01A109_060073")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:ローマに数で劣ろうと<br>ＧＳを果たした覚悟の騎士がこちらにはいる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_060075")


	--★★アーサー★★:逆に考えれば奴らの小細工は<br>こちらの戦力を警戒しているとも取れる
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01A109_060077")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:さしものローマも急激に勢力圏を拡げたおかげで<br>カレドニア軍残党の処理に追われていると聞く
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01A109_060078")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to Sit01_Talk")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:善は急ごう<br>すぐに策を考える
	Talk(Actor007,"CHRNAME_ARTHUR","speech","L","MA_01A109_060079")

	change_face(Actor003,"Serious")

	--★★ガウェイン★★:あいつらが聖杯を手にする前に…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A109_060080")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ノワール★★:バルバロイと魔女の包囲網を突破して<br>ブリテンと聖杯を取り返す…！
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01A109_060081")

-- ▼直接出力
setup_small_camera_start(Camera008)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ギネヴィア★★:平和な話は、それからね
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01A109_060082")

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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor012")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor011,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
