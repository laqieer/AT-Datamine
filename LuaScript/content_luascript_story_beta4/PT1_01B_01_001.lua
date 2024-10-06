-- このluaスクリプトは、PT1_01B_01_001.csvから自動生成されました --
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
	load_area_scene(115080)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★武骨な男子生徒★★:最近、アーサー様のお姿を見たか？
	Talk(Actor003,"NPCNAME_0173","speech","L","PT1_01B_01_0010004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★気取った男子生徒★★:いや…<br>ずいぶんと見ていない気がするな
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01B_01_0010005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★気取った男子生徒★★:本来なら「年明けに騒がないでいつ騒ぐんだ！」<br>なんて言って誰よりもハシャぎそうなのに
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01B_01_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子2", "落胆")
-- ▲直接出力

	--★★武骨な男子生徒★★:こんな重々しい雰囲気で<br>新年を迎えるとは思っていなかったな
	Talk(Actor003,"NPCNAME_0173","speech","L","PT1_01B_01_0010007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★武骨な男子生徒★★:気晴らしに<br>ログレス市街の見回りにでも行ってくる
	Talk(Actor003,"NPCNAME_0173","speech","L","PT1_01B_01_0010008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★気取った男子生徒★★:オレも付き合うよ<br>ひとりでいると気持ちが沈んじまいそうだ
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01B_01_0010009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115080)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
