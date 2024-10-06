-- このluaスクリプトは、MA_01A109_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_013,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_013)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
movie_load("MA_01A109_01")
-- ▲直接出力
-- ▼直接出力
	movie_set_active(true)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
disableTextBox = true
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
movie_play()
hide_image(0)
movie_wait_playing()
movie_stop()
setup_small_camera_start(RndCamera004)
    --ムービー後待機
    wait_time(MOVIE_AFTER)
disableTextBox = false
open_textbox_base()
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………夢？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_020002")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
movie_load_preload("MA_01A109_01")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
disableTextBox = true
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
