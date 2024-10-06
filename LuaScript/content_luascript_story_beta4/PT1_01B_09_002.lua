-- このluaスクリプトは、PT1_01B_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110191_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_002)
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
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★真面目な男子生徒★★:君が手に持っているそれ…なんだい？
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_09_0020005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★武骨な男子生徒★★:かつての友人の遺品だ<br>…おそらくは
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_09_0020006")

	PlayAction(Actor003,"to  Std_Worry")

	--★★真面目な男子生徒★★:おそらく？
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_09_0020007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "悲しみ")
-- ▲直接出力

	--★★武骨な男子生徒★★:記憶が定かではないのだ
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_09_0020008")


	--★★武骨な男子生徒★★:先日の<br>コルベニック城の戦いで命を落としたのだろう
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_09_0020009")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★真面目な男子生徒★★:そうなんだ<br>何度経験しても…やるせないね
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_09_0020010")


	--★★武骨な男子生徒★★:近々、国を挙げて<br>先の戦いの戦死者を弔うらしい
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_09_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★武骨な男子生徒★★:そこでこれを手向けの品にしようと思ってな
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01B_09_0020012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★真面目な男子生徒★★:すごく、喜んでくれると思うよ
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01B_09_0020013")

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
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
