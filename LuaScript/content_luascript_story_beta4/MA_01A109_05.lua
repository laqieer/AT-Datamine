-- このluaスクリプトは、MA_01A109_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_02","113011_02_h")
Include("content_adv_advsmall_113011_02","Template113011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_004)
	InitializeTemplateRandomCamera113011_02()
	InitializeTemplate113011_02()
-- ▼直接出力
load_image("10103033", "content_still_10103033_image", "101030330_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113012)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:学園祭は中止か、当然ね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_050002")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:変わってく
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_050003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10103033", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
 voiceSignalS = voice_play("VO_story01_G_0025")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
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
load_image_preload("10103033", "content_still_10103033_image", "101030330_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113012)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName113011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
