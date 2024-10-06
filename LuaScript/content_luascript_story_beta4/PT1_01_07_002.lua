-- このluaスクリプトは、PT1_01_07_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110191_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_006)
	InitializeTemplateRandomCamera110191_02()
	InitializeTemplate110191_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★詩的な男子生徒★★:常々思っていたんだけどさ<br>キミのファッションセンスは壊滅的だね
	Talk(Actor003,"NPCNAME_0172","speech","L","PT1_01_07_0020004")

-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★武骨な男子生徒★★:制服に<br>ファッションセンスもなにもないと思うが？
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01_07_0020005")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★詩的な男子生徒★★:チッチッチッ！<br>その考えかたが田舎者丸出しなんだよなァ
	Talk(Actor003,"NPCNAME_0172","speech","L","PT1_01_07_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★詩的な男子生徒★★:ロンディニウムに足を運ぶのをオススメする<br>あそこはローマ大帝国の文化が集まる街だ
	Talk(Actor003,"NPCNAME_0172","speech","L","PT1_01_07_0020007")


	--★★詩的な男子生徒★★:ローマは世界でも１、２を争う強大な国家<br>つまり、ローマの流行は世界の流行といえる
	Talk(Actor003,"NPCNAME_0172","speech","L","PT1_01_07_0020008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★詩的な男子生徒★★:ボクは毎月ロンディニウムに出かけ<br>最新のトレンドに触れるようにしているよ
	Talk(Actor003,"NPCNAME_0172","speech","L","PT1_01_07_0020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "肯定2")
-- ▲直接出力

	--★★武骨な男子生徒★★:なるほど<br>参考にしておく
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01_07_0020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★武骨な男子生徒★★:俺はローマの都心の生まれなものでな<br>ロンディニウムがそこまで特別と知らなかった
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01_07_0020011")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★詩的な男子生徒★★:えっ？<br>あ、そうなの…
	Talk(Actor003,"NPCNAME_0172","speech","L","PT1_01_07_0020012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
