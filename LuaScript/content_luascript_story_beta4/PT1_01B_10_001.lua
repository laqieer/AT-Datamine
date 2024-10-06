-- このluaスクリプトは、PT1_01B_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_006)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115080)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★明るい女子生徒★★:いよいよヴォールスさんとパーシヴァルくんが<br>聖杯探索に加わるんだってね
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01B_10_0010005")


	--★★明るい女子生徒★★:ヴォールスさんは<br>過去にランスロット先生との模擬戦で
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01B_10_0010006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★明るい女子生徒★★:何度も引き分けたこともある腕前らしいし
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01B_10_0010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1", "喜び")
-- ▲直接出力

	--★★明るい女子生徒★★:そこにパーシヴァルくんが加われば<br>もう聖杯なんて見つけたも同然よね！
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01B_10_0010008")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★内気な女子生徒★★:…ね、ねえ？<br>なんかパーシヴァルさんだけ扱いが違わない？
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01B_10_0010009")


	--★★内気な女子生徒★★:ひとりだけ「くん」付けだし
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01B_10_0010010")

	PlayAction(Actor003,"to  Std_Worry")

	--★★明るい女子生徒★★:んー、そう？<br>でも、彼からそう呼んでいいって言われてるしね
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01B_10_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★明るい女子生徒★★:パーシヴァルくんっては誤解されがちだけど<br>すごく優しくて、みんなの人気者なんだよ？
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01B_10_0010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "肯定3")
-- ▲直接出力

	--★★内気な女子生徒★★:そうなんだ<br>あんまり話したことなかったから…
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01B_10_0010013")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1", "肯定")
-- ▲直接出力

	--★★明るい女子生徒★★:じゃあ、今度紹介してあげる<br>すぐ仲良くなれると思うよ
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01B_10_0010014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115080)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
