-- このluaスクリプトは、MA_01B110_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",-50,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:旅のお供に現実的な話でもしよっか<br>継承者クン？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100002")


	--★★パーシヴァル★★:もう妖精なんていないかもって話
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100003")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:パーシヴァル様<br>よしましょう
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★パーシヴァル★★:ボクらが今、どこへ向かっているか<br>わかってるかい？『聖杯城の巫女』サン
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100005")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:ええ？どこってフィエナちゃんが探知した場所<br>…でしょ？『果てなき森』だっけ…？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100006")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ノワール★★:そこになにか…あるのか？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:あるんだ<br>あったのさ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:『果てなき森』<br>あそこは妖精の隠れ里があった場所だ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100010")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力

	--★★フィエナ★★:え…っ！？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor001,false)
set_common_look_at(Actor002,Actor003)
 --PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:導きを得ぬ人間が森へ足を踏み入れた場合は<br>果てなく迷い、里に辿りつくこともない…
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_100013")


	--★★ディンドラン★★:いまだに妖精の力が残留しているため<br>…と噂されています
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_100014")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:隠れる場所も多い<br>伏兵にはもってこいだね
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100016")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	open_select_window_tag(Actor004,"Normal","MA_01B110_100017","MA_01B110_100018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ノワール★★:過去に妖精が住んでいた所…？<br>そんな話、誰も教えてくれなかったけど…
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100020")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "納得")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:わたしも名前くらいは聞いていたけど<br>妖精の森だなんて知らなかった…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100021")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:『聖杯城の巫女』ですら知らないんだね<br>まあ…知っていても言わないだろうけど
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ノワール★★:果てなく迷う…だって？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100024")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ノワール★★:そんな場所に足を踏み入れるなんて<br>無謀でしかない
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100026")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:だったら引き返すかい？<br>ボクは止めないけど
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:ここからが現実的な話
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100029")


	--★★パーシヴァル★★:継承者が聖杯の奇跡を受けなきゃ<br>バルバロイに勝てない
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100030")


	--★★パーシヴァル★★:で、聖杯を見つけるには妖精が必要
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:だけど妖精の隠れ里は<br>既にバルバロイに滅ぼされて跡形もない
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100032")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:ちょ、ちょっとまって…！？<br>よ、妖精さんは、そこに住んでた妖精さんは…？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100033")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:根こそぎ喰われたんだよ<br>そりゃそうだ、バルバロイにとっては脅威だもん
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100034")

	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:そうして逃げ延びた最後の妖精は<br>聖杯城でだいじに匿われていたっていうのに──
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:『妖精殺し』が…殺した
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100037")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★フィエナ★★:…そんな
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100038")

-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:現実だよ。とっくに救いは失われてるんだ<br>知ってるのはボクら姉弟と…アーサー王ぐらい？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100039")

	open_select_window_tag(Actor004,"Normal","MA_01B110_100040","MA_01B110_100041","MA_01B110_100042")
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
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:妖精の生き残りはいないのか？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100044")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:だいじに匿われていたぐらいだからね<br>絶滅危惧種みたいなもので
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100045")

	change_face(Actor001,"Anger")

	--★★パーシヴァル★★:万が一にいたとして名乗り出てくると思う？<br>バルバロイに喰われるか、聖杯を探させられるか
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100046")

	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:そんな選択肢しかないのにさ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100047")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:まだフィエナがいるじゃないか<br>聖杯を探すのも、まだ──
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100049")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:『妖精』と『巫女』じゃ全然違うだろ？<br>巫女はあくまで疑似的な妖精の力をもってるだけ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100050")

	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:その証拠にこうしてボクらが<br>右往左往しなきゃいけないハメになってる
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100051")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:フィエナ様がいなければ<br>我々は探すアテすらなかったわけですが？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_100052")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:ん、まあ、そーだけど…！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100053")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:妖精はどうして隠れて過ごしてたんだ？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100055")

-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:その歴史は深く、詳細はわかりかねます<br>ただ神的な…稀有な力をもつため利用価値は高い
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_100056")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:となれば人がそれを追い求めるは道理<br>…望まぬ行いを強いられた妖精もいたでしょう
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_100058")

-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:そのうえバルバロイにまで狙われるとなれば<br>隠れもするよね…、そうだよね…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100059")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
set_common_look_at(Actor004,Actor001)
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:そもそもパーシヴァルが<br>それを知ってるのはどうしてだ？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100061")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:ここから先はプライベート<br>庶民には聞かせてあげられないね
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100062")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor003,false)
set_enable_auto_lookat(Actor004,false)
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:さんざん匂わせといてそれはないよっ！！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100063")


	--★★パーシヴァル★★:とにかくね<br>なにが言いたいかっていうとさ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★パーシヴァル★★:聖杯を発見出来たら<br>ボクが見つけたってことにしてよ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100065")

-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力

	--★★フィエナ★★:………なにそれっ！！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B110_100066")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:…パーシヴァル様
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_100067")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:ボクは世界が救われるなんて<br>さらさら信じられないんだ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100068")


	--★★パーシヴァル★★:『妖精殺し』が世界から奇跡を奪って<br>どうせこの世の終焉は避けられない
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100069")


	--★★パーシヴァル★★:ボクは世界の終わりまで<br>讃えられて気持ち良く過ごしたいんだよ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100070")

	change_face(Actor004,"Sad")

	--★★ノワール★★:…
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_100071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★パーシヴァル★★:悪い話じゃないだろ？<br>現実的でさ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100072")


	--★★パーシヴァル★★:ボクがすこし、<dot>おこぼれ</dot>に預かるだけさ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_100073")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
