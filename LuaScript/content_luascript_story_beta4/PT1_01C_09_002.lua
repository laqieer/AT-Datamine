-- このluaスクリプトは、PT1_01C_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110191_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
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
	Actor002 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
	PlayPartVoice("女子1", "悩む")
-- ▲直接出力

	--★★内気な女子生徒★★:私…ランスロット先生に<br>剣術の稽古つけてもらってこようかな
	Talk(Actor003,"NPCNAME_0176","speech","L","PT1_01C_09_0020004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
	PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★武骨な男子生徒★★:どうしたんだ急に？これまでは<br>戦うのが怖いと言っていた気がするが
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01C_09_0020005")

-- ▼直接出力
	PlayPartVoice("女子1", "肯定")
-- ▲直接出力

	--★★内気な女子生徒★★:うん…。でもバルバロイだけじゃなくて<br>ローマと戦うことになったでしょ
	Talk(Actor003,"NPCNAME_0176","speech","L","PT1_01C_09_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★内気な女子生徒★★:私も<br>いつまでも逃げてちゃ駄目だなって思って
	Talk(Actor003,"NPCNAME_0176","speech","L","PT1_01C_09_0020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
	PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★武骨な男子生徒★★:そうか。なら、稽古に行くときは俺も呼べ<br>付き合ってやる
	Talk(Actor002,"NPCNAME_0173","speech","L","PT1_01C_09_0020008")

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
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
