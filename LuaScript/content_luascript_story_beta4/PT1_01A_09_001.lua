-- このluaスクリプトは、PT1_01A_09_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110191_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_001)
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
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","挨拶")
-- ▲直接出力

	--★★気取った男子生徒★★:ロンディニウム、大変なことになっちまったな
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01A_09_0010004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2","落胆")
-- ▲直接出力

	--★★内気な女子生徒★★:うん…
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_09_0010005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★内気な女子生徒★★:生徒会長があいだをとりもつかたちで<br>学園からの復興支援を始めたそうよ
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_09_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1","否定")
-- ▲直接出力

	--★★気取った男子生徒★★:生徒会長って<br>ローマ留学から戻ってきたばっかりだろ？
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01A_09_0010007")

	PlayAction(Actor003,"to  Std_Worry")

	--★★気取った男子生徒★★:いきなり大変な仕事を任されてるなあ
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01A_09_0010008")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("女子2","肯定2")
-- ▲直接出力

	--★★内気な女子生徒★★:ロンディニウムの住人のなかには
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_09_0010009")


	--★★内気な女子生徒★★:あの事件は<br>ログレスが起こしたと思っている人が多いから
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_09_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★内気な女子生徒★★:この大役は両方の国の事情に詳しい<br>生徒会長にしかできないことなんじゃないかな
	Talk(Actor002,"NPCNAME_0176","speech","L","PT1_01A_09_0010011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","肯定")
-- ▲直接出力

	--★★気取った男子生徒★★:そっか…<br>頑張ってほしいな
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01A_09_0010012")

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
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
