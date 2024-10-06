-- このluaスクリプトは、PT1_01_08_001.csvから自動生成されました --
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
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子1", "落胆")
-- ▲直接出力

	--★★明るい女子生徒★★:ゲシュタルト・シフトかあ…<br>卒業までにできるかなあ…
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01_08_0010004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "挨拶")
-- ▲直接出力

	--★★真面目な男子生徒★★:どうしたの？<br>いつになく弱気だね
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_08_0010005")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★明るい女子生徒★★:だって…入学して結構経つのに<br>絆を結べそうな人が見つからないんだもん
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01_08_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★真面目な男子生徒★★:絆って、見つけようと思って<br>見つかるものじゃないんじゃないかな
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_08_0010007")

	PlayAction(Actor002,"to  Std_Joy")

	--★★真面目な男子生徒★★:いつの間にか見つかって、育まれてる<br>そういうものな気がする
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_08_0010008")

	PlayAction(Actor003,"to  Std_Worry")

	--★★明るい女子生徒★★:そうかな…
	Talk(Actor003,"NPCNAME_0175","speech","L","PT1_01_08_0010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★真面目な男子生徒★★:うん、きっとそうだよ<br>だから焦る必要はないと思う
	Talk(Actor002,"NPCNAME_0113","speech","L","PT1_01_08_0010010")

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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
