-- このluaスクリプトは、EA_010_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_02","100021_02_h")
Include("content_adv_advsmall_100021_02","Template100021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_02,CameraPos100021_02_005)
	InitializeTemplateRandomCamera100021_02()
	InitializeTemplate100021_02()
-- ▼直接出力
CUT_12 =  cat_template_camera("P12_Cam")
CUT_50 =  cat_template_camera("P50_Cam")
CUT_51 =  cat_template_camera("P51_Cam")
set_enable_auto_lookat_all(false)
DontChangeRandomCamera(false)
RndCamera001=CUT_12
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(3.0)
setup_small_camera_start(CUT_50)
wait_time(0.4)
-- ▲直接出力

	--★★アルハン★★:『イミテーション』
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0320003")


	--★★アルハン★★:最後の継承者とともに<br>その封は解き放たれつつある
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0320004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.7)
setup_small_camera_start(CUT_51)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0034")
-- ▲直接出力

	--★★アルハン★★:…<ruby=イミテーション>模造品</ruby>は、<ruby=オリジナル>本物</ruby>でなければ──
	Talk(Actor001,"NPCNAME_0313","speech","L","EA_010_0320005")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
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
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName100021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
