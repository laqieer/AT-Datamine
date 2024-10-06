-- このluaスクリプトは、CO_101025_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	Camera003 = SetTemplate("Actor003",-60,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
DontChangeRandomCamera(true)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad02")
force_eyesync(Actor003,"Close")
reserve_eyesync(Actor003,"Close")
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "悲しみ")
-- ▲直接出力

	--★★市民（女）★★:いや！いやあああ！<br>ジョーイ！どこに行ったの、ジョーイ！
	Talk(Actor003,"NPCNAME_0156","speech","L","CO_101025_05020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだ？騒ぎになってるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_05020003")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ5_3")
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
