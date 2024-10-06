-- このluaスクリプトは、MA_01A900_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_02","113011_02_h")
Include("content_adv_advsmall_113011_02","Template113011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_004)
	InitializeTemplateRandomCamera113011_02()
	InitializeTemplate113011_02()
-- ▼直接出力
load_image("101030530", "content_still_10103053_image", "101030530_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ギネマウア★★:…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_100002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat_position(Actor001,{-2.56,0,-2.05},0.1)
slidemove(Actor001,{-2.56,0,-2.05},1.3)
wait_time(1.3)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
fadeout(255,255,255,1.0,0.5)
wait_time(0.5)
show_image("101030530",0.0,0.0,0,true,false)
wait_time(0.3)
fadein(0.5)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ギネマウア★★:…なにをしてあげられるの？<br>あなたに
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","simple","N","MA_01A900_100004")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030530", "content_still_10103053_image", "101030530_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName113011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
