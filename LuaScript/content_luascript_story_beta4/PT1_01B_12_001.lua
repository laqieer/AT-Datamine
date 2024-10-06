-- このluaスクリプトは、PT1_01B_12_001.csvから自動生成されました --
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
	Actor002 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子2", "落胆")
-- ▲直接出力

	--★★気取った男子生徒★★:今月末は降誕祭が行われるって話だけど…<br>なんか、そんな気分じゃないな
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★詩的な男子生徒★★:そうだねェ<br>銀卓騎士団との戦いは終わってないし
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01B_12_0010005")


	--★★気取った男子生徒★★:ギネヴィア様とマーリン様の<br>行方が知れないっていうし
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★気取った男子生徒★★:なあ<br>銀卓騎士団って本当に敵なのかな？
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010007")


	--★★気取った男子生徒★★:ちょっと前までは<br>一緒に戦ってた仲間だろ
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010008")


	--★★気取った男子生徒★★:ローマをあざむくために<br>敵のフリしてるとかってことはないかな？
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★詩的な男子生徒★★:そのローマの人たちは<br>もう本国に帰っちゃったじゃないか
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01B_12_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★気取った男子生徒★★:そっか…<br>でも、信じてみたいんだよな
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010011")


	--★★気取った男子生徒★★:自分でも理由はよくわからないんだけど
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★詩的な男子生徒★★:キミって意外にいいヤツなんだな
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01B_12_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★気取った男子生徒★★:意外ってどういうことだよ！？
	Talk(Actor003,"NPCNAME_0174","speech","L","PT1_01B_12_0010014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★詩的な男子生徒★★:でも…ボクは悪くないと思うね<br>そういう考えかたの人がいても
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01B_12_0010015")

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
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
