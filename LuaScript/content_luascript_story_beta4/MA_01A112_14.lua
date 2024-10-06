-- このluaスクリプトは、MA_01A112_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	gaussian_start = 10
	gaussian_end = 30
set_pos(Actor003,{0.1,0,-1.7})
set_rot(Actor003,{0,20,0})
set_pos(Actor004,{-4.2,0,0.05})
set_rot(Actor004,{0,95,0})
set_pos(Actor005,{7.5,0,1.5})
set_rot(Actor005,{0,-100,0})
change_face(Actor001,"Sad")
Hide(Actor004)
Hide(Actor005)
set_camera_nearclip(Camera001,1)
DontChangeRandomCamera(true)
change_weather_cloudy(true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
change_weather_cloudy(true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101090022)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101038","003","101038003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("フレン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フレン★★:行かないで
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_140002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★フレン★★:…って言ったら<br>行かないでいてくれる？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_140004")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "否定")
-- ▲直接出力

	--★★ラシア★★:それができたら<br>どれだけいいかと
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A112_140005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラシア★★:そう思いながら、行きます
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A112_140007")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力

	--★★フレン★★:ごめんね
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_140008")

-- ▼直接出力
Appear(Actor004)
change_face(Actor001,"Surprise")
-- ▲直接出力

	--★★ローラ★★:お姉様！
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","MA_01A112_140010")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
--ローラ,CHRNAME_LOLA2 @名前変更
CameraEX = set_camera({-1.9, 1.47, 0.06, 0, -90, 0, 15})
setup_small_camera_start(CameraEX)
on_active(FX_DoF)
 --PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ローラ★★:お姉様！
	Talk(Actor004,"CHRNAME_LOLA2","speech","L","MA_01A112_140012")

-- ▼直接出力
CameraEX = set_camera({-0.93,1.45,0.85,0,120,0,16})
setup_small_camera_start(CameraEX)
Appear(Actor005)
set_pos(Actor004,{0,0,-0.8})
set_rot(Actor004,{0,35,0})
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フレン★★:ローラ──
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_140014")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Run")
slidemove(Actor004,1,0,0.6,1)
wait_time(1)
set_pos(Actor004,{2,0,0.2})
set_rot(Actor004,{0,80,0})
DontChangeRandomCamera(true)
CameraEX = set_camera({0,1.15,0.15,0,90,0,42})
setup_small_camera_start(CameraEX)
off_active(FX_DoF)
slidemove(CameraEX,{0,1.15,0.25},5.0)
slidemove(Actor004,6.66,0,1,1.5)
wait_time(1.5)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
turn_lookat(Actor002,Actor005,0)
turn_lookat(Actor003,Actor005,0)
 --PlayPartVoice("ローラ", "喜び")
-- ▲直接出力

	--★★ローラ★★:お姉様っ！
	Talk(Actor004,"CHRNAME_LOLA2","speech","L","MA_01A112_140016")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "喜び")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★モーロノエー★★:おはよう、ローラ<br>よく眠れた？
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","L","MA_01A112_140018")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ローラ★★:はい。お姉様
	Talk(Actor004,"CHRNAME_LOLA2","speech","L","MA_01A112_140019")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(Camera002)
turn_chara(Actor001,-30,0)
 --PlayPartVoice("ラシア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラシア★★:…魔女、あなた………
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A112_140020")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フレン★★:ローラ──
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_140021")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
change_face(Actor004,"Surprise")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★モーロノエー★★:ローラ、ご挨拶なさい
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","L","MA_01A112_140023")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ローラ", "悩む")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ローラ★★:お姉様…この方は？
	Talk(Actor004,"CHRNAME_LOLA2","speech","L","MA_01A112_140024")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★モーロノエー★★:あなたの新しいお姉様よ
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","L","MA_01A112_140025")

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ローラ★★:はじめまして。お姉様
	Talk(Actor004,"CHRNAME_LOLA2","speech","L","MA_01A112_140027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:ローラ、フレンは──
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A112_140028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フレン★★:うん
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_140029")

	change_face(Actor004,"Surprise")

	--★★ローラ★★:お姉様…？
	Talk(Actor004,"CHRNAME_LOLA2","speech","L","MA_01A112_140031")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フレン★★:はじめまして。愛してる
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A112_140032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	gaussian_start = 10
	gaussian_end = 30
	InitializeLoad_Preload()
	load_duel_scene_preload(101090022)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101038","003","101038003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
