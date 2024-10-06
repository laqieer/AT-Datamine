-- このluaスクリプトは、PT1_01C_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_006)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★明るい女子生徒★★:街では降誕祭の準備が<br>進められてるって話だけど
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01C_12_0010004")


	--★★明るい女子生徒★★:降誕祭なんてやってる場合なのかな<br>ランスロット先生たちが行方不明なんでしょ？
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01C_12_0010005")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★詩的な男子生徒★★:ランスロット先生は『最強騎士』だろう？<br>万が一なんてことは起こらないさ
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01C_12_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★詩的な男子生徒★★:きっとなにか素晴らしい戦果を上げて<br>帰ってきてくれるよ
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01C_12_0010007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★詩的な男子生徒★★:そのとき盛大に歓迎してあげられるよう<br>僕たちも降誕祭の準備を手伝おうじゃないか
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01C_12_0010008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
