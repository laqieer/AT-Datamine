-- このluaスクリプトは、PT1_01C_10_001.csvから自動生成されました --
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
	Actor002 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★内気な女子生徒★★:ノワールさんとディナタンさんが<br>戻って来てくれて本当に良かった
	Talk(Actor003,"NPCNAME_0176","speech","L","PT1_01C_10_0010004")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★内気な女子生徒★★:あんなことが起きて<br>たくさんの人がいなくなって
	Talk(Actor003,"NPCNAME_0176","speech","L","PT1_01C_10_0010005")


	--★★内気な女子生徒★★:この先、学園はどうなっちゃうんだろうって<br>ずっと思ってたから
	Talk(Actor003,"NPCNAME_0176","speech","L","PT1_01C_10_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★詩的な男子生徒★★:大丈夫<br>悲しいことのあとには、嬉しいことが絶対に来る
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01C_10_0010007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★詩的な男子生徒★★:ランスロット様やギネヴィア様は<br>それをボクたちに伝えるために
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01C_10_0010008")


	--★★詩的な男子生徒★★:ずっと頑張ってくれているんだからさ
	Talk(Actor002,"NPCNAME_0172","speech","L","PT1_01C_10_0010009")

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
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
