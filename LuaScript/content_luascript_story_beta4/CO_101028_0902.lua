-- このluaスクリプトは、CO_101028_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:それで姉上最終試験はなにをすればいいのです？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_09020002")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:ふっふっふ…<br>それでは
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_09020004")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:プリンセス・ドント・クライ～激闘編～<br>試験の内容を発表する
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_09020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（ここまで来たら<br>突っ込んだほうが負けな気がする）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_09020007")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ずばり、ノワールと１日デートして<br>女の子らしくエスコートされる、じゃー！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_09020005")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガラハッド_ランクアップ9_3")
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
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
