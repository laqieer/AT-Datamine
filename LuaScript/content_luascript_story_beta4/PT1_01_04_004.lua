-- このluaスクリプトは、PT1_01_04_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",103,CharaPos110191_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
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
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "苦しみ")
-- ▲直接出力

	--★★気取った男子生徒★★:イテテ…
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01_04_0040004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "挨拶")
-- ▲直接出力

	--★★内気な女子生徒★★:どうしたの？
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01_04_0040005")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★気取った男子生徒★★:オレとしたことが<br>こないだの授業でケガしちゃってさ
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01_04_0040006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★気取った男子生徒★★:日課にしてた剣術の訓練もままならない<br>夜が退屈で仕方ねえよ
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01_04_0040007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★内気な女子生徒★★:そんなに退屈なら<br>大図書院で本を借りて読んでみたら？
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01_04_0040008")


	--★★内気な女子生徒★★:知性豊かな人はカッコイイし<br>本から優しさなんかも学べると思うわ
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01_04_0040009")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★気取った男子生徒★★:ふーん<br>でも、大図書院ってあんまり行ったことなくて
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01_04_0040010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "笑い")
-- ▲直接出力

	--★★内気な女子生徒★★:心配いらないわ。司書のクリスティーナさんが<br>優しく教えてくれるはずだから
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01_04_0040011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
