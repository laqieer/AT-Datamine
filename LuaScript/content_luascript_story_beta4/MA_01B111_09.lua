-- このluaスクリプトは、MA_01B111_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_018,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_018)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101067","001","101067001")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B111_091001")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B111_091002")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:アーサー様は療養中、ケイ卿は政務で多忙のため<br>今回は私が近況を説明させていただきます
	Talk(Actor009,"telop","narration","N","MA_01B111_091003")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マーリン★★:アーサー様は療養中、ケイ卿は政務で多忙のため<br>今回は私が近況を説明させていただきます
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090002")


	--★★マーリン★★:ロンディニウム復興作業は順調に推移
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090003")


	--★★マーリン★★:先の虐殺嫌疑により<br>学園から若干の離反者がローマについたものの…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:ルーシャス率いるバルバロイの軍勢は<br>ローマ対策班が奮戦し島東部へと追いやりました
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090005")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:彼らもなかなかやるじゃないの<br>ボク抜きにもかかわらず
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090006")


	--★★マーリン★★:ローマ軍に魔女の加勢がさほど見られないことも<br>戦況が優勢に進んでいる要因と聞きますが…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090007")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:最強騎士と継承者が聖杯探索についているのだ<br>魔女の目もこちらに移って当然だろう
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090008")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:ガラハッドを追って<br>派手に動いた甲斐もあったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_090010")

	PlayAction(Actor007,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ガラハッド★★:そ、それについては<br>いくら詫びても詫び足りん…！
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ガラハッド★★:だ、だがガラハッドはちょっと怒ってるぞ！<br>姉上を放って勝手に聖杯封印を解いたことを！
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090012")

	open_select_window_tag(Actor001,"Normal","MA_01B111_090013","MA_01B111_090014")
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

	--★★ノワール★★:墓参りのついでに行ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_090016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうだ。たまたま偶然奇跡的に<br>魔女が出て来たから倒しただけさ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_090017")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ガラハッド★★:たまたま偶然奇跡的に魔女が出て来たなら<br>しょうがないか！しょうがないな！！
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090018")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ガラハッド★★:イヤごまかすなッ！<br>しょうがなくないぞッ！！
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドやフィエナには<br>伝えるべきだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_090021")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ガラハッド★★:み、見くびるなよ
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090022")

	change_face(Actor007,"Anger")

	--★★ガラハッド★★:味方をも欺き、魔女へ奇襲を成功させたことには<br>最大限の敬意を表するぞガラハッドは！
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090023")

	PlayAction(Actor007,"to  Std_Sad01")
	change_face(Actor007,"Sad")

	--★★ガラハッド★★:ただ、その雄姿ぐらい<br>この目で見たかったのだ、ガラハッドは…っ
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090025")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:したがって、聖杯の顕現は間もなくです
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090027")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:そもそも継承者の覚醒とともに現れた聖杯を<br>魔女姉妹たちが抑えていた…ということだったな
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090028")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:その封印が解かれた今<br>再びどこかに聖杯が現れるのを待つって感じ？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力

	--★★フィエナ★★:多少、封印されていた反動が生じている…<br>だから若干の猶予の後で再出現…するはずだよ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B111_090030")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:…抑えつけられたものがもとへ戻るには<br>時間がかかるのでしょうね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090031")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:出現位置の予想は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_090033")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:魔女が潜んでいた４ヵ所の配置から考えるに<br>スノードン山あたりではないかと踏んでいる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_090035")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力

	--★★パーシヴァル★★:封印の中心部ってことだね<br>場所が推測できたんなら急いだほうがよくない？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090036")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定3")
-- ▲直接出力

	--★★ヴォールス★★:カレドニア──もといローマ領でもある<br>当てもなく山々を見張るのは困難だ
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090037")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:…スタートダッシュからして<br>バルバロイやローマに出遅れる感じか
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ガラハッド★★:魔女が再び封印を企てる可能性も<br>あるのでは？
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01B111_090039")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:同じ轍を踏むとは考えづらいが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_090040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:…クレア曰く
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090042")

-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力

	--★★マーリン★★:………順調すぎると思われますか、やはり
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090043")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:聖杯の抑え込みも各地で順番に行うのであれば<br>魔女姉妹が分散するメリットはない
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090044")


	--★★ヴォールス★★:それに、銀卓騎士団のキラーズの<br>潔すぎる投降…
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090045")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力

	--★★パーシヴァル★★:あっちの油断・慢心、それだけだよ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090046")


	--★★パーシヴァル★★:ただでさえ最強の騎士がGSを経て<br>更なる力を得たわけだろう？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:向かうところ敵なしとはまさにこのこと<br>ラクさせてもらって悪いね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090049")

	open_select_window_tag(Actor001,"Normal","MA_01B111_090050","MA_01B111_090051")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:敵の企みがなんであれ<br>やることは変わらないさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_090053")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ヴォールス★★:それしかないのも事実だな<br>大帝国に比べ寡兵である我らとしては
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090055")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★ヴォールス★★:実に心強い言葉だ<br>ランスロットに似てきたな。ノワール
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B111_090056")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:パーシヴァルにも助けられているよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_090058")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:高貴なる立場のボクが<br>蛮族あがりのキミに施すのは当然さ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090059")

	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:まあ今後とも<br>引き続き褒めてくれていいけどね？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B111_090060")

	goto Block2end

::Block2end::
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マーリン★★:聖杯顕現が起これば恐らく<br>フィエナ嬢が反応をキャッチすることでしょう
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090062")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:ローマが目立った攻撃を仕掛けて来ないのも<br>我らの動きを見て聖杯を奪取するためかと
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090063")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マーリン★★:いつでも動けるよう<br>皆様、心づもりを
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B111_090064")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力

	--★★ニニアン★★:「奇跡とは呼べない」
	Talk(Actor008,"CHRNAME_NINIAN","speech","N","MA_01B111_090066")


	--★★ニニアン★★:「聖杯は、あまねく願いを叶えるものにあらず<br>それは人間の都合の良い解釈に過ぎない」
	Talk(Actor008,"CHRNAME_NINIAN","speech","N","MA_01B111_090067")

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
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101067","001","101067001")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
