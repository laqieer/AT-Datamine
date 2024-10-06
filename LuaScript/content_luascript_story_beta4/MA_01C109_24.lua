-- このluaスクリプトは、MA_01C109_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_02","110101_02_h")
Include("content_adv_advsmall_110101_02","Template110101_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_02,CameraPos110101_02_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110101_02,CameraPos110101_02_002)
	InitializeTemplateRandomCamera110101_02()
	InitializeTemplate110101_02()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor002,"Close")
reserve_eyesync(Actor002,"Close")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
RndCamera001Sub = RndCamera001
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera007
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
 --setup_small_camera_start(RndCamera003)
Appear(Actor001)
-- ▲直接出力
-- ▼直接出力
wait_time(1.7)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス","挨拶")
-- ▲直接出力

	--★★クラリス★★:懺悔は済みそうですか？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C109_240002")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
reserve_eyesync(Actor002,"Auto")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:クラリス、すまないな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01C109_240003")

-- ▼直接出力
 --DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス","悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★クラリス★★:なにを謝るんです～？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C109_240004")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:すっかり常連となってしまった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01C109_240005")

-- ▼直接出力
 --PlayPartVoice("クラリス","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★クラリス★★:王ともなれば悩みも多いでしょうから
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C109_240006")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★クラリス★★:気の済むまで、どうぞ
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C109_240007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:…いや
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01C109_240008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★クラリス★★:はい？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C109_240009")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
turn_chara(Actor001, 67, 0)
set_animationcontroller(Actor002, "Chr_005_01_StdController", "to Std_Loop")
Camera002 = setup_small_camera_resetting(Actor002,CharaPos007,CameraPos007)
turn_chara(Actor002, 249, 0)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:もう済んだよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01C109_240011")


	--★★クラリス★★:………それは
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C109_240013")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_start(RndCamera001Sub)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★クラリス★★:寂しくなりますね～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","MA_01C109_240015")

-- ▼直接出力
OpenFirstAppearance(Actor001)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001Sub = RndCamera001
RndCamera001 = RndCamera007
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
