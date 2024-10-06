-- このluaスクリプトは、MA_01C900_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",70,CharaPos110041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_001)
	Camera002 = SetTemplate("Actor002",109,CharaPos110041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_002)
	Camera003 = SetTemplate("Actor003",60,CharaPos110041_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_004)
	Camera004 = SetTemplate("Actor004",-220,CharaPos110041_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_007)
	Camera005 = SetTemplate("Actor005",130,CharaPos110041_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_006)
	Camera006 = SetTemplate("Actor006",77,CharaPos110041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_003)
	Camera007 = SetTemplate("Actor007",92,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
CameraEx = set_camera({4.03, 1.87, -6.04,   3.72678, 277.4698, 0.54599,   40})
-- ▲直接出力
-- ▼直接出力
set_chara_pos_resetting(Actor002,{-1.15734, 0, -7.14052,   94.94025})
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
wait_time(3.0)
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
Appear(Actor002)
Appear(Actor003)
set_common_look_at(Actor001,Actor002)
turn_chara(Actor001,250,0.0)
setup_small_camera_start(RndCamera005)
fadein(0.5)
wait_time(0.5)
change_face(Actor002,"Smile")
change_face(Actor003,"Smile")
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(2.0)
PlayActionDirect(Actor003,"to  Std_Joy")
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
set_pos(Actor002,CharaPos110041_01_002)
Appear(Actor004)
Appear(Actor005)
setup_small_camera_start(RndCamera004)
fadein(0.5)
wait_time(0.5)
set_common_look_at(Actor001,Actor004)
change_face(Actor004,"Smile")
PlayActionDirect(Actor004,"to Greet_one")
wait_time(2.0)
change_face(Actor005,"Smile")
PlayActionDirect(Actor005,"to  Std_Talk")
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
Appear(Actor006)
Appear(Actor007)
setup_small_camera_start(RndCamera001)
fadein(0.5)
wait_time(0.5)
set_common_look_at(Actor001,Actor007)
PlayActionDirect(Actor007,"to  Std_Talk")
wait_time(2.0)
change_face(Actor006,"Smile")
PlayActionDirect(Actor006,"to Greet_one")
wait_time(3.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
wait_time(1.0)
change_face(Actor001,"Smile")
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
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
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
