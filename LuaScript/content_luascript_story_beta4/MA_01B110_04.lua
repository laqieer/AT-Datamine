-- このluaスクリプトは、MA_01B110_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
se_play("SE_ADV_MA_01C109_01_Bell")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（………夢、じゃない…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B110_040002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（なにかを思い出したような…<br>だけど、俺の記憶とは思えない…、これは…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B110_040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…「聖杯は願いを叶えるものにあらず」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_040004")


	--★★ノワール★★:「ときが来たる前に聖杯の力を<br>ただひとりへと注ぐ」？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_040005")


	--★★ノワール★★:「その者は」「継承者となる」…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_040006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………「奇跡など、ありえない」？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_040007")

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
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
