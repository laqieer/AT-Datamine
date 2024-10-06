-- このluaスクリプトは、MA_01A109_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_03_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_009)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-3.3094, 1.231, -8.76098,   2.72138, 62.47017, 358.6835,   20.79664})
-- ▲直接出力
-- ▼直接出力
mob1   = setup_prop_object(10130033)
set_pos(mob1,{1,0,-6})
set_rot(mob1,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob2   = setup_prop_object(10130033)
set_pos(mob2,{3,0,-6})
set_rot(mob2,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob3   = setup_prop_object(10130033)
set_pos(mob3,{-1,0,-6})
set_rot(mob3,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob4   = setup_prop_object(10130033)
set_pos(mob4,{-3,0,-6})
set_rot(mob4,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob5   = setup_prop_object(10130032)
set_pos(mob5,{1,0,-4})
set_rot(mob5,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob6   = setup_prop_object(10130032)
set_pos(mob6,{3,0,-4})
set_rot(mob6,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob7   = setup_prop_object(10130032)
set_pos(mob7,{-1,0,-4})
set_rot(mob7,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob8   = setup_prop_object(10130032)
set_pos(mob8,{-3,0,-4})
set_rot(mob8,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob9   = setup_prop_object(10130032)
set_pos(mob9,{1,0,-2})
set_rot(mob9,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob10 = setup_prop_object(10130032)
set_pos(mob10,{3,0,-2})
set_rot(mob10,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob11 = setup_prop_object(10130032)
set_pos(mob11,{-1,0,-2})
set_rot(mob11,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob12 = setup_prop_object(10130032)
set_pos(mob12,{-3,0,-2})
set_rot(mob12,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob13 = setup_prop_object(10130032)
set_pos(mob13,{1,0,0})
set_rot(mob13,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob14 = setup_prop_object(10130032)
set_pos(mob14,{3,0,0})
set_rot(mob14,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob15 = setup_prop_object(10130032)
set_pos(mob15,{-1,0,0})
set_rot(mob15,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob16 = setup_prop_object(10130032)
set_pos(mob16,{-3,0,0})
set_rot(mob16,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob17 = setup_prop_object(10130032)
set_pos(mob17,{1,0,2})
set_rot(mob17,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob18 = setup_prop_object(10130032)
set_pos(mob18,{3,0,2})
set_rot(mob18,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob19 = setup_prop_object(10130032)
set_pos(mob19,{-1,0,2})
set_rot(mob19,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob20 = setup_prop_object(10130032)
set_pos(mob20,{-3,0,2})
set_rot(mob20,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob21   = setup_prop_object(10130033)
set_pos(mob21,{-5,0,-6})
set_rot(mob21,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob22   = setup_prop_object(10130032)
set_pos(mob22,{-5,0,-4})
set_rot(mob22,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob23   = setup_prop_object(10130032)
set_pos(mob23,{-5,0,-2})
set_rot(mob23,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob24   = setup_prop_object(10130032)
set_pos(mob24,{-5,0,0})
set_rot(mob24,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob25   = setup_prop_object(10130032)
set_pos(mob25,{-5,0,2})
set_rot(mob25,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob26   = setup_prop_object(10130033)
set_pos(mob26,{5,0,-6})
set_rot(mob26,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob27   = setup_prop_object(10130032)
set_pos(mob27,{5,0,-4})
set_rot(mob27,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob28   = setup_prop_object(10130032)
set_pos(mob28,{5,0,-2})
set_rot(mob28,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob29   = setup_prop_object(10130032)
set_pos(mob29,{5,0,0})
set_rot(mob29,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob30   = setup_prop_object(10130032)
set_pos(mob30,{5,0,2})
set_rot(mob30,{0,180,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:思い起こせ、顧みろ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:余は唯一の生き証人として語り続ける<br>平和を夢見、悪夢と共に消え去った者たちを
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240003")


	--★★ルーシャス★★:何故ログレスがＧＳの知識とノウハウを<br>独占し続けていられるのか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240004")

	change_face(Actor001,"Sad")

	--★★ルーシャス★★:何故ブリテンのなかでローマ人は<br>ロンディニウムに追いやられていたのか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240006")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,-5.3,1.231,-8.45,25)
-- ▲直接出力

	--★★ルーシャス★★:我らローマはログレスにとって<br>ゲストと思われているが、そうではない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240007")


	--★★ルーシャス★★:古代ローマ時代より今の今まで<br>ブリテンの支配権はローマにあったというのに
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240008")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:その歴史は忘れ去られている<br>ログレスこそがブリテンの守護者とされている
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240010")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:余が問おう。それは何故だ？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_240011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130033)
setup_prop_object_preload(10130033)
setup_prop_object_preload(10130033)
setup_prop_object_preload(10130033)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130033)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130033)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
setup_prop_object_preload(10130032)
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
