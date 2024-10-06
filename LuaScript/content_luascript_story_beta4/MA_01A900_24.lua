-- このluaスクリプトは、MA_01A900_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos116101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName116101_01,CameraPos116101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos116101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName116101_01,CameraPos116101_01_002)
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
 --Ef_1 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false)
-- ▲直接出力
-- ▼直接出力
 --on_active(Ef_1)
-- ▲直接出力
-- ▼直接出力
 --effect_at_character(Actor001, "Chest", Ef_1, 0.0, 0.15, 0.0)
-- ▲直接出力
-- ▼直接出力
Ef_2 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Spirit_Aura",false,true)
-- ▲直接出力
-- ▼直接出力
set_pos(Ef_2,CharaPos116101_01_002)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010150", 0.0, 0.0,0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("101010150_2", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101030540", "content_still_10103054_image", "101030540_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:え…？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_240002")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(FADE_TIME)
show_image("101030540",0,0,0,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME + 0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:聖杯が…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_240003")


	--★★ギネヴィア★★:…わたし、が、依り代に？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_240006")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(FADE_TIME)
hide_image()
setup_small_camera_start(Camera002)
fadein(FADE_TIME)
wait_time(0.8)
set_enable_auto_lookat(Actor002,false)
on_active(Ef_2)
play_particle(Ef_2)
wait_time(3.2)
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ギネヴィア…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_240007")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:「方舟が着く岸辺」<br>…「自我と、彼岸の忘却」…？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_240009")


	--★★ギネヴィア★★:「太古の神」、「終末戦役」<br>…「二千年後決戦輪廻」
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_240010")


	--★★ギネヴィア★★:守るべき『ノアのつがい』
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_240012")

-- ▼直接出力
CloseTalkWindow()
show_image("101010150_2", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ギネヴィア★★:わたしの宿命は…
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_240014")


	--★★ギネヴィア★★:「淘汰」<br>「白き竜」…？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A900_240015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Spirit_Aura",false,true)
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010150_2", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101030540", "content_still_10103054_image", "101030540_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
