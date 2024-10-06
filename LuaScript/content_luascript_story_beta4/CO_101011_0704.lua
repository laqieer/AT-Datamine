-- このluaスクリプトは、CO_101011_0704.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110131_01","110131_01_h")
Include("content_adv_advsmall_110131_01","Template110131_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110131_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110131_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_002)
	InitializeTemplateRandomCamera110131_01()
	InitializeTemplate110131_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110131)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ここにもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07040002")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:小さいガラス玉だもん落としたら見つけにくいよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なあ他にどんな場所に行ったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07040004")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ7_5")
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
	load_area_scene_preload(110131)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110131_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
