-- このluaスクリプトは、CO_101014_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",115,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0004")
-- ▲直接出力

	--★★トリスタン★★:お待たせ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07030002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:さっき町の人に話を聞いたんだけど復興はずいぶん進んできているらしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ただ、一方で巨大ドラゴンのウワサが広まっていて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07030004")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:「生贄を捧げるべきだ」と言い出している人も増えてきてるんだとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07030005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "納得")
-- ▲直接出力

	--★★トリスタン★★:なるほど計画どおりに進んじゃってるようだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07030006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:計画どおり？進んじゃってる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07030007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:キミは気にしなくていいよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:ボクの用事も今日のところはおしまい
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07030009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:あとはドラゴンの尻尾を捕まえたいところだけどどうしたものかな…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ドラゴンの尻尾？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07030012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:そうドラゴンの尻尾
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07030013")

-- ▼直接出力
setup_small_camera_start(Camera001)
Hide(Actor002)
-- ▲直接出力

	--★★ノワール★★:お、おい！詳しく聞かせろよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07030015")

-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
