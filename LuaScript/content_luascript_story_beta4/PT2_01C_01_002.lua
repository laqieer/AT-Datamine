-- このluaスクリプトは、PT2_01C_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:オイ<br>てめえ、覚悟はできてんだろうな？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020005")


	--★★ノワール★★:モルドレッド…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド","肯定2")
-- ▲直接出力

	--★★モルドレッド★★:ギネヴィアはてめえの妹をさらった
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★モルドレッド★★:つまりはランスロットと同じく<br>アーサーの考えに賛同したってことだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0020009")


	--★★モルドレッド★★:「まだそうと決まったわけじゃない」<br>ってか？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド","肯定3")
-- ▲直接出力

	--★★モルドレッド★★:残念だがな<br>もうそうと決まってんだよ、誰の目から見ても
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:甘っちょろい考えで行った日にゃ<br>次におっ死ぬのはてめえだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:わかってんのか？てめえは騎士筆頭だ<br>今、死ぬなんてことは許されねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド","肯定2")
-- ▲直接出力

	--★★モルドレッド★★:明日は覚悟を決めて行ってこい<br>これは王命だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020014")


	--★★モルドレッド★★:無事帰って来れたら<br>…そうだな、盛大なパーティを開いてやるからよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT2_01C_01_0020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:モルドレッド…<br>ありがとう、行ってくるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0020016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
