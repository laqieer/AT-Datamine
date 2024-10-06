-- このluaスクリプトは、MA_01B900_38.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_006)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115070)
	Actor001 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クレア★★:王殺しは失敗に終わったんでしょうね<br>明かされないのはなにか事情があってのこと
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B900_380002")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ボールス★★:空が真っ赤なのはなにかの前兆か？
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_380003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力

	--★★ディンドラン★★:学園周辺で<br>バルバロイの大量発生も確認されてます
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_380004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:………『淘汰』ってやつだ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★クレア★★:バルバロイの王が目覚めたのであれば<br>次に起こすアクションは明白
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B900_380006")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディンドラン★★:…魔王による進軍
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_380007")


	--★★クレア★★:空間すら穢す王の力には脱帽ね
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B900_380008")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力

	--★★ディンドラン★★:敵がアーサー王と知れれば<br>こちらの士気はガタ落ちでしょう
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_380010")

	change_face(Actor003,"Normal")

	--★★ディンドラン★★:その歩みを止められるのは──
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_380011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:継承者がやってくれるんだろう？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380012")


	--★★ボールス★★:勝ち目があると思うか？
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_380013")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:クレアのハナシだけどさ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★パーシヴァル★★:モルガンがサラスに籠ったのは<br>アーサー王に手出しされたくなかったからだろ？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380015")


	--★★パーシヴァル★★:それだけ継承者とその劔が<br>脅威だったんだよ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380016")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力

	--★★パーシヴァル★★:なんたって継承者は聖杯を見つけ出し<br>魔女姉妹をも退けたんだからね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380017")

-- ▼直接出力
turn(Actor004,0,129.9895,0,0.5)
-- ▲直接出力

	--★★パーシヴァル★★:逃げ道作ってるのは<br>どっちなのさ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380018")


	--★★ディンドラン★★:パーシヴァル様、どちらへ？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_380020")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:継承者は自らの責務を果たし続けている<br>見上げたノブリス・オブリージュだ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380021")

	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:ボクにも円卓の騎士の端くれとして<br>相応しい振る舞いがあるはずだ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380022")

	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:前線に出るぞ、ついてこい
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B900_380023")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:…誇らしいです。パーシヴァル様
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_380024")

-- ▼直接出力
 --フェードアウト
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --フェードイン
-- ▲直接出力
-- ▼直接出力
fadein(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★クレア★★:安楽椅子探偵も嫌いじゃないけれど
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B900_380026")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ボールス★★:事件が起きたら見過ごせんな
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_380027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★クレア★★:解決編は、ここからよ
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B900_380028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115070)
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
