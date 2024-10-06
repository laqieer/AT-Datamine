-- このluaスクリプトは、MA_01B900_45.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",245.187,CharaPos116101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName116101_01,CameraPos116101_01_001)
	Camera002 = SetTemplate("Actor002",52.137,CharaPos116101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName116101_01,CameraPos116101_01_003)
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
seihai = setup_prop_object(10201022)
set_pos(seihai,{-0.115, 1.358, 0.351})
Ef_Holy_Grail01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", true, true)
Ef_Holy_Grail02 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", true, true)
set_pos(Ef_Holy_Grail01, {-0.115, 1.358, 0.351})
set_pos(Ef_Holy_Grail02, {-0.115, 1.358, 0.351})
set_enable_auto_lookat_all(false)
-- ▲直接出力

end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:聖杯が………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_450002")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:…誰かが、語り掛けてくる…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_450004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ランスロット…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_450005")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:「方舟が着く岸辺」<br>…「自我と、彼岸の忘却」…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_450006")


	--★★ランスロット★★:「太古の神」、「終末戦役」<br>…「二千年後決戦輪廻」
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_450007")


	--★★ランスロット★★:守るべきノアの『つがい』
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_450009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ランスロット★★:俺の宿命は…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_450011")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:「淘汰」<br>「白き竜」…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_450012")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
setup_prop_object_preload(10201022)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", true, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", true, true)
	system.PreLoadRequest(CameraAssetBundleName116101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
