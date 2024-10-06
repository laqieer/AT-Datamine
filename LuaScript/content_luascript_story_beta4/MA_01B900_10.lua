-- このluaスクリプトは、MA_01B900_10.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114091_01","114091_01_h")
Include("content_adv_advsmall_114091_01","Template114091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_002)
	InitializeTemplateRandomCamera114091_01()
	InitializeTemplate114091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114091)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()


	--★★アーサー★★:誰が言い出したんだ？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B900_100002")


	--★★ランスロット★★:ん？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_100003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:『最強騎士』だなんて
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B900_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ランスロット★★:忘れたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_100006")

	change_face(Actor004,"Smile")

	--★★アーサー★★:不格好な二つ名だな、まったく
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B900_100008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ペンドラゴンが言うな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_100009")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114091)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
