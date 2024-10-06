-- このluaスクリプトは、PT1_01A_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_006)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")

	--★★武骨な男子生徒★★:まったく…<br>今は学園祭などと浮かれている状況なのか？
	Talk(Actor003,"NPCNAME_0173","speech","L","PT1_01A_10_0010003")

-- ▼直接出力
PlayPartVoice("男子2","挨拶")
-- ▲直接出力

	--★★詩的な男子生徒★★:どうしたんだい？
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01A_10_0010004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★詩的な男子生徒★★:いつも冷静な君が<br>珍しく虫の居所が悪いみたいじゃないか
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01A_10_0010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1","肯定")
-- ▲直接出力

	--★★武骨な男子生徒★★:先のアントニヌス・ウォールの戦いで
	Talk(Actor003,"NPCNAME_0173","speech","L","PT1_01A_10_0010006")


	--★★武骨な男子生徒★★:我が軍はローマ軍に<br>あわやというところまで追いつめられたと聞く
	Talk(Actor003,"NPCNAME_0173","speech","L","PT1_01A_10_0010007")

	PlayAction(Actor003,"to  Std_Angry")

	--★★武骨な男子生徒★★:であれば、これまで以上に<br>訓練に力を入れるべきではないのか？
	Talk(Actor003,"NPCNAME_0173","speech","L","PT1_01A_10_0010008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2","笑い")
-- ▲直接出力

	--★★詩的な男子生徒★★:やれやれ<br>君はいつもお堅いね
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01A_10_0010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★詩的な男子生徒★★:力みすぎてもいい結果は出せない<br>適度に息を抜くことをオススメするよ
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01A_10_0010010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★詩的な男子生徒★★:学園祭にでも参加してさ
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01A_10_0010011")

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
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
