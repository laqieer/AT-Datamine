-- このluaスクリプトは、PT1_01_05_002.csvから自動生成されました --
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
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★気取った男子生徒★★:ヤバイ…。今月まだ始まって間もないのに<br>小遣いがほとんど残ってない…
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01_05_0020004")

-- ▼直接出力
PlayPartVoice("男子2", "落胆")
-- ▲直接出力

	--★★真面目な男子生徒★★:きみ、五月女王の投票券のために<br>いろいろ買ってたもんね
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_05_0020005")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★気取った男子生徒★★:推しの子のためなら全財産だって捧げる！<br>騎士ってそういうもんだろう！？
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01_05_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★真面目な男子生徒★★:必ずしも<br>そうとは限らないと思うけど
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_05_0020007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★真面目な男子生徒★★:そうだ<br>お金がないんだったら働いてみるのはどう？
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_05_0020008")


	--★★真面目な男子生徒★★:市街のいくつかの店で<br>働き手を募集してたと思うよ
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_05_0020009")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "落胆")
-- ▲直接出力

	--★★気取った男子生徒★★:はあ<br>やっぱそれしかないか…
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01_05_0020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
