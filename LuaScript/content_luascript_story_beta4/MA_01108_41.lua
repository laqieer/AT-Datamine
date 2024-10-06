-- このluaスクリプトは、MA_01108_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111016_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
-- ▼直接出力
Hide(Actor008)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101056","001","101056001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101028","003","101028003","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★フィエナ★★:お別れくらい<br>言って欲しかったな
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01108_410002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:フィエナ…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_410003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
wait_time(0.2)
OpenFirstAppearance(Actor001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フィエナ★★:8年ぶりだね<br>さびしかったんだから
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01108_410005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フィエナ★★:突然いなくなって<br>いきなり帰って来るなんて礼儀知らず
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01108_410006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★フィエナ★★:また遊んでくれなきゃ、やだよ
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01108_410007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:遠路はるばるよくぞ参られた<br>赤き竜の国の王とその騎士たちよ
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410009")

-- ▼直接出力
PlayActionDirect(Actor002,"to Bow")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Bow")
-- ▲直接出力
	PlayAction(Actor004,"to Bow")

	--★★アーサー★★:ご無沙汰しております、ぺレス王<br>さっそくですがお願いがあります
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:我らは今、カレドニア軍…<br>いえ、バルバロイとの戦いを続けています
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410013")


	--★★アーサー★★:キャメロット騎士学術院を設立し<br>バイブスとキラーズを教育してはいるものの
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410014")

	change_face(Actor004,"Sad")

	--★★アーサー★★:バルバロイの勢力の増す速度は<br>我々の想像を上回っています
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:このブリテンに住む者<br>世界に生きるすべての人間たちのためにも
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410016")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:我ら円卓の騎士が本懐を<br>遂げる時が来ました
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410017")


	--★★アーサー★★:聖杯探索と<br>継承者によるバルバロイの根絶が必要です
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410018")


	--★★ペレス★★:そのために聖杯の手がかりが欲しい<br>…そう申すのであろう
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★アーサー★★:はい<br>８年前のあの事件以来
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410020")

	change_face(Actor004,"Sad")

	--★★アーサー★★:あなたが我が国を良く思って<br>いらっしゃらないことは存じています
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410021")

	change_face(Actor004,"Normal")

	--★★アーサー★★:それでも今は<br>我らに力をお貸しいただきたい
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_410022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:頼みます
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01108_410023")

	change_face(Actor006,"Surprise")

	--★★ルーシャス★★:…8年前の事件、とは？
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410025")


	--★★ペレス★★:…海の向こうの大帝国とは<br>なんら関係のない事情だ
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410027")

	PlayAction(Actor006,"to  Std_No")
	change_face(Actor006,"Normal")

	--★★ルーシャス★★:銀卓だ円卓だと<br>卓上の軋轢に興味はないが
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★ルーシャス★★:余は学園生活を愉しんでいる<br>それを妨げる障害は排除したい。関係は大アリだ
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410029")


	--★★ルーシャス★★:ぺレス王よ。ブリテンの住人のひとりとして<br>進言させてもらうが
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410030")

	change_face(Actor006,"Anger")

	--★★ルーシャス★★:今は８年も前の事件に<br>こだわっている状況ではないのではないか？
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:それにだ。病床の貴様のために薬を運び<br>ウォールの維持にも一役買ったのは誰だ？
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410032")

	change_face(Actor005,"Surprise")

	--★★ノワール★★:る、る、ルーシャス
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01108_410033")

	change_face(Actor006,"Normal")

	--★★ルーシャス★★:海の向こうの大帝国では<br>こんな僻地の城主の御機嫌など無関係でね
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410034")

	change_face(Actor007,"Anger")

	--★★ガラハッド★★:え、円卓の騎士たちが<br>ペレス王のお薬の採取を手伝ってくれました
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_410035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --Appear(Actor008)
-- ▲直接出力
-- ▼直接出力
 --Hide(Actor007)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:よくぞ申した！どうだ鉄面皮が屈したぞ！<br>屈辱か？エェ？屈辱か？ンン？
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410036")

-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
	change_face(Actor007,"Shy")

	--★★ガラハッド★★:～～っ！
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_410038")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
fadeout(0,0,0,1.0, STILL_SWITCH_TIME)
se_play("SE_ADV_MA_01108_41_Helmet")
wait_time(STILL_SWITCH_TIME + 0.3)
Hide(Actor007)
Appear(Actor008)
 --フェードイン
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+0.3)
-- ▲直接出力

	--★★ガラハッド／兜有り★★:………礼を、言う<br>円卓の騎士…っ
	Talk(Actor008,"CHRNAME_GALAHAD","speech","L","MA_01108_410039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ペレス★★:…このコルベニック城は<br>『聖杯城』とも呼ばれておる
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410041")


	--★★ペレス★★:湖の妖精が住み<br>聖杯を祀るという言い伝えによるものだが
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410042")

	change_face(Actor003,"Sad")

	--★★ペレス★★:…湖の妖精は去った
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410043")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★フィエナ★★:おじい様…
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01108_410045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ペレス★★:湖の妖精が消えし今<br>聖杯の行方を知ることはできぬのだ
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410047")

	change_face(Actor005,"Sad")

	--★★ノワール★★:そんな…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01108_410048")

	change_face(Actor003,"Normal")

	--★★ペレス★★:だが、手がかりくらいは残っておるやもしれぬ
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ペレス★★:ノワールよ<br>そなたたちが妖精ニニアンと過ごしていた湖
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410051")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:あの場所こそが<br>湖の妖精たちが集う場だった
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410053")


	--★★ペレス★★:行ってみるといい<br>儂が教えてやれるのはそこまでだ
	Talk(Actor003,"CHRNAME_PEREZ","speech","L","MA_01108_410054")

	change_face(Actor005,"Surprise")

	--★★ノワール★★:あ…ありがとうございます！
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01108_410055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:ペレス王。本日のディナーは<br>昨日よりはマシなものが出せるのであろうな？
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410056")

	change_face(Actor005,"Anger")

	--★★ノワール★★:ルーーーシャス…！
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01108_410057")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★ルーシャス★★:他人の帰郷話ほど退屈なものはない<br>しかも２度目だ、２度目だぞ？余は城に残る
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ルーシャス★★:まぁ護衛の兵士くらいは<br>何人かつけてやろう
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410059")

	change_face(Actor006,"Smile")

	--★★ルーシャス★★:では、ゆっくりしてくるといい
	Talk(Actor006,"CHRNAME_LUCIUS","speech","L","MA_01108_410061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101056","001","101056001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101028","003","101028003","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
