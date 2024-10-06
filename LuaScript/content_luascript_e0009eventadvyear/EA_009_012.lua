-- このluaスクリプトは、EA_009_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_006)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
turn_chara(Actor002,344,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115159)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ギネヴィア――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0120005")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad01")
SkipDefaultMotion(Actor002)
PlayPartVoiceDirect("ギネヴィア","0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………ううっ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_009_0120007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:なんで…なんでよぉ…<br>なんで、こんなことになるの…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_009_0120010")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad02")
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:こんなふうになるなら、私――
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_009_0120011")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0021")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0120013")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.4)
PlayActionDirect(Actor001,"to  Std_Sad02")
wait_time(2.0)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,209,0.4)
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,{-3.22, 0, -6.5},1.6,0.1)
wait_time(0.02)
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
	load_area_scene_preload(115159)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
