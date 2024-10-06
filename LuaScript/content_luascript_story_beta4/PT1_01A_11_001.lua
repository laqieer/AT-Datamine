-- このluaスクリプトは、PT1_01A_11_001.csvから自動生成されました --
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
	load_area_scene(115080)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子1","挨拶")
-- ▲直接出力

	--★★明るい女子生徒★★:学園祭の前くらいからかな？
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_11_0010004")


	--★★明るい女子生徒★★:ギネヴィア様とエレインちゃんが<br>一緒にいるところを見ることが増えた気がする
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_11_0010005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","肯定")
-- ▲直接出力

	--★★無骨な男子生徒★★:ああ。ギネヴィア様の影響か<br>エレインはすごく明るくなったな
	Talk(Actor002,"NPCNAME_0358","speech","L","PT1_01A_11_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★無骨な男子生徒★★:前は<br>いつも自信なさそうにオドオドしていた
	Talk(Actor002,"NPCNAME_0358","speech","L","PT1_01A_11_0010007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1","肯定2")
-- ▲直接出力

	--★★明るい女子生徒★★:そうね<br>でもさ、最近のエレインちゃん見てると
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_11_0010008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★明るい女子生徒★★:あの子って昔は<br>明るい子だったんじゃないかなって思うんだ
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_11_0010009")

-- ▼直接出力
PlayPartVoice("男子1","否定")
-- ▲直接出力

	--★★無骨な男子生徒★★:どうしてそう思うんだ？
	Talk(Actor002,"NPCNAME_0358","speech","L","PT1_01A_11_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("女子1","肯定")
-- ▲直接出力

	--★★明るい女子生徒★★:笑顔が自然なの
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_11_0010011")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1","悩む")
-- ▲直接出力

	--★★無骨な男子生徒★★:笑顔が自然？
	Talk(Actor002,"NPCNAME_0358","speech","L","PT1_01A_11_0010012")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子1","悩む")
-- ▲直接出力

	--★★明るい女子生徒★★:えーと<br>どう説明したらいいかな～
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_11_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★明るい女子生徒★★:ぎこちなくないっていうか…<br>笑い慣れてるっていうか…
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_11_0010014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","笑い")
-- ▲直接出力

	--★★無骨な男子生徒★★:ふっ<br>お前のように笑えるってことでいいか？
	Talk(Actor002,"NPCNAME_0358","speech","L","PT1_01A_11_0010015")

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
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
