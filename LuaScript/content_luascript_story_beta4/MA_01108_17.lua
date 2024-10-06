-- このluaスクリプトは、MA_01108_17.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	template1()

end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor002,"to Greet_one")
wait_time(2.0)
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(2.0)
PlayActionDirect(Actor004,"to  Std_Talk")
wait_time(3.0)
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
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
