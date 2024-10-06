-- このluaスクリプトは、MA_01104_40.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_02","110011_02_h")
Include("content_adv_advsmall_110011_02","Template110011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_007)
	InitializeTemplateRandomCamera110011_02()
	InitializeTemplate110011_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor007")
	template1()
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
kokuban = setup_prop_object(10102002)
set_pos(kokuban ,{0,0,0})
set_pos(Actor001 ,{2.13, 0, -3.05})
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
on_camera(RndCamera002)
wait_time(1.8)
turn(Actor001,0, 252.5833, 0,0.3)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001, -1.512, 0, -3.466 ,3.5)
wait_time(2.5)
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor007")
setup_prop_object_preload(10102002)
	system.PreLoadRequest(CameraAssetBundleName110011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
