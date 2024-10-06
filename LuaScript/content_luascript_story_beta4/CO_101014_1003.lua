-- このluaスクリプトは、CO_101014_1003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-80,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("103050150", "content_still_10305015_image", "103050150_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.8,0,1})
keep_ik_lookat(Actor001,Actor002, "J_Head")
keep_ik_lookat(Actor002,Actor003, "J_Head")
keep_ik_lookat(Actor003,Actor002, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0002")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:お前もだいぶ素直になれたようね、トリスタン
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10030002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:なれたんじゃないキミたちにさせられちゃったんだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10030003")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0010")
-- ▲直接出力

	--★★イゾルデ★★:ふふっノワールが諦め悪くあがいたせいかしら
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10030005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:イゾルデが<br>俺をけしかけたからだと思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10030006")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:なにか言ったかしら
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10030008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:イイエ、ナンデモアリマセン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10030009")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★トリスタン★★:なに？ふたりして…ボクにもわかるように話してくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10030011")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0.2} , 1)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:別になんでもないわただ、そうね、敢えて言うなら…
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10030012")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:自分のやりたいようにやっただけよここにいる全員、ね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_10030013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:ふふっ、そうだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10030015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:とくにノワールはね。好き勝手付きまとってボクにあーだこーだ言ってさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10030016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それは、まあ…でもほら、俺は背中を押したかっただけだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10030017")

-- ▼直接出力
change_face(Actor001,"Normal")
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:うん
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10030019")

-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:キミが背中を押してくれたからボクは一歩踏み出せたんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10030020")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0036")
-- ▲直接出力

	--★★トリスタン★★:――ありがとう、ノワール
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10030021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…じゃあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10030022")

-- ▼直接出力
CloseTalkWindow()
show_image("103050150", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) --基本的にtrue,falsle wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER
setup_small_camera_end()
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力

	--★★トリスタン★★:思ってたほど悪くないね誰かの手を握るってのもさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","N","CO_101014_10030024")

-- ▼直接出力
CloseTalkWindow()
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
load_image_preload("103050150", "content_still_10305015_image", "103050150_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
