-- このluaスクリプトは、MA_01C109_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_007)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115144)
	Actor001 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★マルディサント★★:モルガンせんせ！！
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C109_170003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.1)
se_play("SE_ADV_MA_01104_20_DoorOpen")
wait_time(2.2)
setup_small_camera_start()
hide_image(BLACK_WHITE_TIME)
wait_time(2.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★マルディサント★★:…逃げてるよな。とっくに
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C109_170005")

-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115144)
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
