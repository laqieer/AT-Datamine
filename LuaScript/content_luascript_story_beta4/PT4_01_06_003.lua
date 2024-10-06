-- このluaスクリプトは、PT4_01_06_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_004)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
SetOffset(Actor003,0,-0.08,0.04)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:トリスタン…朝から俺の監視か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:そんなところかなキミが休日に問題を起こさないとも限らないしね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…ちょうどいい機会だちょっと教えてほしいことがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:一応、聞いてあげるよ答えるとは限らないけどね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030005")


	--★★ノワール★★:魔女って、一体なんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0030006")

-- ▼直接出力
PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力

	--★★イゾルデ★★:授業で習ったでしょう？バルバロイを生み出し、使役する存在よ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","PT4_01_06_0030007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなことを聞いてるんじゃない魔女の目的はなんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:言ったよね？「答えるとは限らないけどね」って
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:正直言うとね、答えられない魔女についてはボクたちも知らないことだらけだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030010")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:ただ…特別にボクの推測を聞かせてあげると
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:魔女は誰かを標的としているそしてその標的はキミ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030012")

-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:…かもしれない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0030014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:せいぜい気を付けてねボクの仕事は監視であって、護衛じゃないから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT4_01_06_0030015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
