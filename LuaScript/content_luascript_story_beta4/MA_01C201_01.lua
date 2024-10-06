-- このluaスクリプトは、MA_01C201_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110241_21","110241_21_h")
Include("content_adv_advsmall_110241_21","Template110241_21_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110241_21_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110241_21_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110241_21_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110241_21_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110241_21_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110241_21_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110241_21_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_007)
	InitializeTemplateRandomCamera110241_21()
	InitializeTemplate110241_21()
-- ▼直接出力
load_image("MA01C2010101", "content_still_10104007_image", "101040070_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("MA01C2010101", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110241)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor007")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

-- ▼直接出力
 --[[
show_image("MA01C2010101", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
 --]]
-- ▲直接出力

	--★★ケイ★★:皆も知っての通り<br>先のスノードンの戦いにおいて
	Talk(Actor003,"CHRNAME_KAY","speech","N","MA_01C201_010002")


	--★★ケイ★★:ランスロット卿が還らぬ人となった
	Talk(Actor003,"CHRNAME_KAY","speech","N","MA_01C201_010003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01107_06_Crowds")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力

	--★★ケイ★★:アーサー王も学園を離れ…
	Talk(Actor003,"CHRNAME_KAY","speech","N","MA_01C201_010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:…失敬。アーサー王の行方も知れず<br>不安ななかとは思うが、生徒諸君は…
	Talk(Actor003,"CHRNAME_KAY","speech","N","MA_01C201_010007")

-- ▼直接出力
 --[[
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
 --]]
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01C2010101", "content_still_10104007_image", "101040070_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110241)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor007")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110241_21)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
