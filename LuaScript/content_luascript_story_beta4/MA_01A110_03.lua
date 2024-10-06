-- このluaスクリプトは、MA_01A110_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
DontChangeRandomCamera(true)
tegami = setup_prop_object(10106003)
tegami_offset = {0,-0.08,0,358.654,30.0615,275.411}
-- ▲直接出力
-- ▼直接出力
 --lookat_weight(Actor002,1.0,0.5,1.0,0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
 --lookat_weight(Actor001,1.0,0.5,1.0,0.2)
lookat_delay_weight(Actor001, 1.0,0,0.5,0.2,1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
load_image("101030480", "content_still_10103048_image", "101030480_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115024)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力

	--★★エレイン★★:先輩…こんにちは
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_030002")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:誰かを待っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_030003")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,2.0)
PlayActionDirect(Actor002,"to LookFor")
se_play("SE_ADV_MA_01B112_49_Cloth")
wait_time(1.5)
PlayActionDirect(Actor002,"to Show")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
show_image("101030480", 0.0, 0.0, 0,true,false)
fadein(1.5)
setup_small_camera_start(Camera001)
wait_time(2.5)
hide_image(0)
PlayActionDirect(Actor001,"to ReadLetter")
se_play("SE_ADV_MA_01105_28_Paper")
on_active(tegami)
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", {0,0,0,0,0,0})
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:「先輩に　あえたらなと」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_030005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Shy")
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:………一緒に、かえりませんか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_030007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
tegami_offset = {0,-0.08,0,358.654,30.0615,275.411}
load_image_preload("101030480", "content_still_10103048_image", "101030480_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115024)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
