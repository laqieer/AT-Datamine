-- このluaスクリプトは、MA_01107_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_01","113021_01_h")
Include("content_adv_advsmall_113021_01","Template113021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_002)
	InitializeTemplateRandomCamera113021_01()
	InitializeTemplate113021_01()
-- ▼直接出力
Ef_Aura_Enemy1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
local EfPos = get_pos(Actor001)
set_pos(Ef_Aura_Enemy1 , EfPos)
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
PlayActionDirect(Actor001,"to LookFor")
DontChangeRandomCamera(true)
ringo = setup_prop_object(10104003)
set_pos(ringo,{-0.8,0.02,4.99})
set_rot(ringo,{-9,-157,136})
set_scale(ringo,2,2,2)
off_active(ringo)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Pain")

	--★★ブライアン将軍★★:あ、グッ、ゲホッ、ゲホゲホッ…！！
	Talk(Actor001,"CHRNAME_BRIAN","speech","L","MA_01107_390002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ブライアン将軍★★:なんだよ…っ<br>いきなり苦しく──…！
	Talk(Actor001,"CHRNAME_BRIAN","speech","L","MA_01107_390003")

-- ▼直接出力
CloseTalkWindow()
on_active(Ef_Aura_Enemy1) 
play_particle(Ef_Aura_Enemy1)
se_play("SE_ADV_MA_01107_39_DarkEffect")
wait_time(1)
show_image("101010150", 0.0, 0.0,0.3,false,false)
set_scale_image(20,20)
wait_time(0.3)
PlayActionDirect(Actor001,"to Show")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_Aura_Enemy1)
stop_particle(Ef_Aura_Enemy1)
on_active(ringo)
setup_small_camera_start()
-- ▲直接出力

	--★★ブライアン将軍★★:ハァッ、アアアァッ、うああぁ…！？
	Talk(Actor001,"CHRNAME_BRIAN","speech","L","MA_01107_390005")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01107_39_Wheelchair")
wait_time(7.0)
se_play("SE_ADV_MA_01107_39_AppleDrop")
wait_time(3.0)
hide_image(2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
turn_lookat(Actor001,ringo,1)
-- ▲直接出力

	--★★ブライアン将軍★★:…ぜぇ、ぜぇ…なんだ、こりゃあ…
	Talk(Actor001,"CHRNAME_BRIAN","speech","L","MA_01107_390007")

-- ▼直接出力
CloseTalkWindow()
ringo_camera = set_camera({-0.336,0.844,5.358,51.5,-126,0,42})
setup_small_camera_start(ringo_camera)
slidemove(ringo_camera,{-0.387,0.764,5.321},5.0)
wait_time(1)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ブライアン将軍★★:…リンゴ…？
	Talk(Actor001,"CHRNAME_BRIAN","speech","L","MA_01107_390009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
setup_prop_object_preload(10104003)
	InitializeLoad_Preload()
	load_area_scene_preload(113021)
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
