-- このluaスクリプトは、MA_01B110_37.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_07","110011_07_h")
Include("content_adv_advsmall_110011_07","Template110011_07_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_07_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_07_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_07_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_07_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_002)
	InitializeTemplateRandomCamera110011_07()
	InitializeTemplate110011_07()
-- ▼直接出力
DontChangeRandomCamera(true)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")

	--★★アーサー★★:ノワール、いる？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_370002")

-- ▼直接出力
DontChangeRandomCamera(false)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor003,false)
set_enable_auto_lookat(Actor004,false)
PlayActionDirect(Actor003,"to  Std_Joy")
turn_chara(Actor003,-50,0.3)
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:アーサー様！？
	Talk(Actor003,"NPCNAME_0146","speech","N","MA_01B110_370004")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★アーサー★★:やあ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_370005")

-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Surp")
turn_chara(Actor004,-45,0.3)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:なんでアーサー様！？
	Talk(Actor004,"NPCNAME_0151","speech","N","MA_01B110_370006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:よ、用事なら呼び出してくれれば…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_370007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:王命は断りづらいかな？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_370008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName110011_07)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
