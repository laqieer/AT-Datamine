-- このluaスクリプトは、EA_069_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",-116,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
prop1 = set_object("content_model_weapon_98_emy_wpn_emy_001_01_swd", "Wpn_01_Emy_001_01_swd", false)
on_parent(prop1 ,Actor003,"Loc_weapon_constrint_R",{0,0,0,0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★バルバロイ★★:アアアアッ！
	Talk(Actor003,"CHRNAME_BARBAROI","speech","N","EA_069_0510003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
show_image("101010140", 0.0, 0.0, 0.2,false,false)
set_scale_image(20,20)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01A111_14_sword_02")
fadeout(255,255,255,0.4, FADE_TIME)
fadein(0.4)
wait_time(0.8)
Hide(Actor004)
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(2)
fadeout(0,0,0,1.0, 0.2)
wait_time(0.2)
Hide(Actor003)
Appear(Actor001)
Appear(Actor002)
setup_small_camera_end()
setup_small_camera_start(Camera001)
wait_time(0.1)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0030")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0510006")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,20,0.6)
wait_time(0.6)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor001,0.5,0.1,0.8,0.2,1.0)
PlayPartVoiceDirect("ギネマウア","0043")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネマウア★★:…ギネヴィア<br>今のうちに戻りましょう
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0510007")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★ギネマウア★★:ここにいては危険よ<br>今の私たちではバルバロイに太刀打ちできない
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0510008")


	--★★ギネマウア★★:早くここを脱出して<br>アーサー様に事態を伝えないと
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0510009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:う、うん…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0510010")

-- ▼直接出力
local gopos = {6.02, 0, 6.62}
CloseTalkWindow()
PlayActionDirect(Actor001,"to Run")
lookat_delay_weight_reset(Actor001,1.0)
turn_lookat_position(Actor001, gopos, 0.2)
wait_time(0.2)
slidemove(Actor001, gopos, 1)
wait_time(0.2)
PlayActionDirect(Actor002,"to Run")
turn_lookat_position(Actor002, gopos, 0.2)
wait_time(0.2)
slidemove(Actor002, gopos, 1)
wait_time(0.6)
--PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.4)
--PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
set_object_preload("content_model_weapon_98_emy_wpn_emy_001_01_swd", "Wpn_01_Emy_001_01_swd", false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
