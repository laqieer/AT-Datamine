-- このluaスクリプトは、EA_069_023.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_019)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_cameraframe()
off_screencolor()
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0230006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101016_sp_0003_1")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネマウア★★:…ギネヴィア
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0230007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0025")
-- ▲直接出力

	--★★ギネヴィア★★:…わかってる
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0230008")

	PlayAction(Actor001,"to Bow")
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001, {0, 0.035, -5.327}, 1.0)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:――はじめまして、アーサー王
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0230010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:この度はキャメリアードの民の受け入れ<br>心より感謝いたします
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0230011")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:それから…えっと、その――…<br>わ、わたし――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0230012")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力

	--★★アーサー★★:安心してくれ<br>俺から貴方になにかを強いることはない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","EA_069_0230013")


	--★★ギネヴィア★★:え…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0230014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to Sit01_Talk")

	--★★アーサー★★:俺はアーサー・ペンドラゴン<br>レオデグランス王には大変世話になった
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","EA_069_0230015")


	--★★アーサー★★:あの方は優しく愛に溢れたよき王だ<br>俺は王としてあのかたを尊敬している
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","EA_069_0230016")


	--★★アーサー★★:そんな彼と俺は約束をした<br>ひとつはキャメリアードの民を守ること
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","EA_069_0230017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★アーサー★★:そしてもうひとつは…<br>――貴方がたの笑顔を取り戻すこと
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","EA_069_0230018")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0230019")

	PlayAction(Actor003,"to Sit01_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:学園へようこそ<br>ふたりとも
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","EA_069_0230021")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
