-- このluaスクリプトは、MA_01A112_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_001)
	Camera002 = SetTemplate("Actor002",210,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	Camera003 = SetTemplate("Actor003",-235,CharaPos110031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_007)
	Camera004 = SetTemplate("Actor004",120,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	Camera005 = SetTemplate("Actor005",-60,CharaPos110031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_005)
	Camera006 = SetTemplate("Actor006",10,CharaPos110031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_006)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
set_pos(Actor001,{6.23, 0, -26.36,  83})
Hide(Actor001)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{11.902, 0, -23.769})
set_common_look_at(Actor002,Actor003,1.5)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{11.097, 0, -23.959})
set_common_look_at(Actor003,Actor002,1.5)
load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{14.662, 0, -28.691})
set_common_look_at(Actor004,Actor005,1.5)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{16.16, 0, -28.92})
set_common_look_at(Actor005,Actor004,1.5)

-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{15.31, 0, -29.37})
set_common_look_at(Actor006,Actor005,1.5)
load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
CameraEx1=set_camera({15.345, 1.975, -25.615,   13.393, 166, 355.172,28})
-- ▲直接出力
-- ▼直接出力
CameraEx2=set_camera({14.428, 1.975, -26.736,   13.39299, 325.491, 355.172,28})
-- ▲直接出力
-- ▼直接出力
CameraEx3=RndCamera001
RndCamera001=RndCamera009
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor006")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(CameraEx1)
slidemove(CameraEx1,14.72, 1.975, -25.497,9.0,3)
play_head_motion(Actor006, "Nod", 0.3, 1.5, true)
wait_time(1.0)
stop_head_motion(Actor006)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
play_head_motion(Actor003, "No", 0.3, 1.0, false)
setup_small_camera_start(CameraEx2)
slidemove(CameraEx2,13.651, 1.975, -26.736,9.0,3)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
Appear(Actor001)
PlayActionDirect(Actor001,"to Wlk")
wait_time(0.3)
setup_small_camera_start(RndCamera008)
slidemove(Actor001,{26.73, 0, -25.7}, 10.0)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
lookat_weight(Actor002,0.6,0.1,0.8,0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.2)
lookat_weight(Actor003,0.6,0.1,0.8,0.2)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.2)
wait_time(0.3)
open_speech_window("NPCNAME_0152",Actor002,nil)
message_nowait("MA_01A112_330001")
wait_time(1.45)
close_speech_window()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
lookat_weight(Actor004,0.6,0.1,0.8,0.2)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.2)
lookat_weight(Actor005,0.6,0.1,0.8,0.2)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.2)
lookat_weight(Actor006,0.6,0.1,0.8,1.2)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",0.9)
wait_time(0.3)
open_speech_window("NPCNAME_0273",Actor004,nil)
message_nowait("MA_01A112_330002")
-- ▲直接出力
-- ▼直接出力
wait_time(1.3)
close_speech_window()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
CameraEx3=RndCamera001
RndCamera001=RndCamera009
	InitializeLoad_Preload()
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
