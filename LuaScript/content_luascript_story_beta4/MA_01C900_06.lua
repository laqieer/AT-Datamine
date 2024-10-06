-- このluaスクリプトは、MA_01C900_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101170011)
	Actor001 = InitializeCharacter_3D("101013","002","101013002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガウェイン★★:円卓は壊滅状態っスけどね<br>パーシヴァルにヴォールス…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060002")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★アーサー★★:彼らの犠牲は無駄にはしない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060003")

	change_face(Actor003,"Anger")

	--★★アーサー★★:GSなど間違っている
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060004")

-- ▼直接出力
setup_small_camera_start()
change_face(Actor002,"Sad")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:…すまない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060006")


	--★★アーサー★★:すでにキラーズとなった者たちには<br>つらい思いをさせる
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:謝らないでくださいよ<br>アーサー様が悪いんじゃねえ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060008")

	change_face(Actor001,"Sad")

	--★★ガウェイン★★:悪いのはこんな世界と妖精だって
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:そう言ったアーサー様を信じて<br>俺たちはついてきたんだ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060010")

-- ▼直接出力
set_common_look_at(Actor001,Actor002,0.8)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001, -2.667,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:だろ？ラグネル
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060011")

-- ▼直接出力
wait_time(0.5)
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラグネル★★:…うん
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","MA_01C900_060012")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:継承者の武器になれなかった<br>ランスロットとギネヴィア
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060013")

-- ▼直接出力
 --setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ふたりなら俺の力になってくれると思った
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060014")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-83,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:だが彼らですら継承者を討ち果たすには<br>力が足りなかった
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060015")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★アーサー★★:新しい伝説を築くことは痛みを伴うものだと<br>分かってはいるが…辛いものだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060016")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Serious")

	--★★ガウェイン★★:ふたりとも継承者の武器にも<br>あんたの武器にもなれなかっただけだ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060017")


	--★★アーサー★★:生身の人間を武器と呼ぶのには<br>抵抗がある
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060018")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★アーサー★★:そんな世界はおかしいんだ<br>『本当』は
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060019")

	change_face(Actor001,"Normal")

	--★★ガウェイン★★:だから新しい伝説を作る…ですよね？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060020")

-- ▼直接出力
CloseTalkWindow()
play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:なら俺は戦うだけだ<br>あなたが作る新しい世界のために
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060022")

	change_face(Actor003,"Normal")

	--★★アーサー★★:ああ。この世界をすべてやりなおすためには<br>犠牲が必要だ。だが…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060023")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:…なあ、ガウエィン<br>俺は、間違っているか？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:間違っていません
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060025")

	change_face(Actor001,"Normal")

	--★★ガウェイン★★:俺もちゃんと犠牲になります<br>あなたのために
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060026")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ガウェイン★★:だからついてきたんです
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060027")


	--★★ガウェイン★★:楽しい仲間も学園もおいて<br>あなたに
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060028")

	PlayAction(Actor003,"to  Std_Worry")

	--★★アーサー★★:…ワガママな王ですまない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060029")

	change_face(Actor001,"Smile")

	--★★ガウェイン★★:今さらなに言ってるんですか
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060030")

-- ▼直接出力
setup_small_camera_end()
set_common_look_at(Actor001,Actor002,0.8)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001, -10.837,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ガウェイン★★:さあ行くぞ、ラグネル
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060031")


	--★★ガウェイン★★:アーサー様にたどり着く前に<br>俺たちで継承者を殺す
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01C900_060032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Serious")

	--★★アーサー★★:頼んだぞ、ラグネル、ガウェイン
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01C900_060033")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101170011)
	InitializeCharacter_3D_Preload("101013","002","101013002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
