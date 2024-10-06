-- このluaスクリプトは、PT1_01A_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110191_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_006)
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
	Actor002 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1","挨拶")
-- ▲直接出力

	--★★明るい女子生徒★★:この一年、あっという間だったわね～<br>思い返してみてどう？なにかいいことあった？
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_12_0010004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2","肯定2")
-- ▲直接出力

	--★★内気な女子生徒★★:自分には衛生兵が向いてることがわかったわ<br>それで、医療の勉強を始めたの
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_12_0010005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1","肯定2")
-- ▲直接出力

	--★★明るい女子生徒★★:ああ、そういえば<br>最近よく療養院に顔を出してたわね
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_12_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2","笑い")
-- ▲直接出力

	--★★内気な女子生徒★★:それで<br>ディナタンちゃんと仲良くなったの
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_12_0010007")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1","驚き")
-- ▲直接出力

	--★★明るい女子生徒★★:えっ、そうなんだ！？
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_12_0010008")

-- ▼直接出力
PlayPartVoice("女子2","挨拶")
-- ▲直接出力

	--★★内気な女子生徒★★:あのね。降誕祭に行くとき<br>ディナタンちゃんも誘っていいかな？
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_12_0010009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1","肯定3")
-- ▲直接出力

	--★★明るい女子生徒★★:もちろん！
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_12_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子2","悩む")
-- ▲直接出力

	--★★内気な女子生徒★★:…マルディサントちゃんもいい？
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_12_0010011")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1","肯定")
-- ▲直接出力

	--★★明るい女子生徒★★:もちろんもちろん！<br>みんなで騒ごうよ！
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_12_0010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2","笑い")
-- ▲直接出力

	--★★内気な女子生徒★★:よかった<br>今度ふたりに話してみるね
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_12_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1","肯定2")
-- ▲直接出力

	--★★明るい女子生徒★★:…アナタも変われたんだね、この一年で
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_12_0010014")

-- ▼直接出力
PlayPartVoice("女子2","驚き")
-- ▲直接出力

	--★★内気な女子生徒★★:え？<br>なあに？
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_12_0010015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1","笑い")
-- ▲直接出力

	--★★明るい女子生徒★★:降誕祭、楽しみだなーって言ったの♪
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01A_12_0010016")

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
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
