-- このluaスクリプトは、MA_01104_313.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_04_009,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_009)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor004,Actor006,0)
turn_lookat(Actor006,Actor004,0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005, {-0.24, 0, -3.766})
set_pos(Actor007, {-1.26, 0, -3.3})
turn_lookat(Actor005,Actor007,0)
turn_lookat(Actor007,Actor005,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor005,false)
set_enable_auto_lookat(Actor006,false)
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-1.757,0,-0.491})
turn_chara(Actor002,86,0)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
Appear(Actor002)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{1.657, 0, -1.175}, 2.0)
wait_time(2.0)
turn_chara(Actor002,20,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3130001")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3130002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0050")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ウレリー★★:実はね、この学園有数のオススメスポット<br>屋上は景色がいいんだよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3130003")

	change_face(Actor002,"Normal")

	--★★ウレリー★★:そこで食べるお弁当は格別なんだから
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3130004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いいな。行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3130005")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_LongFade")
wait_time(0.4)
PlayActionDirect(Actor004,"to Run")
se_play("SE_ADV_MA_01107_06_Crowds")
turn_chara(Actor004,55,0.2)
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,354,0.2)
wait_time(0.2)
slidemove(Actor005,{0.152, 0, -2.024}, 0.6)
wait_time(0.6)
turn_chara(Actor005,65,0.2)
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor007,"to Run")
turn_chara(Actor007,27,0.2)
wait_time(0.2)
slidemove(Actor007,{-0.116, 0, -0.979}, 0.6)
wait_time(0.6)
turn_chara(Actor007,82,0.2)
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,55,0.4)
wait_time(0.2)
PlayActionDirect(Actor007,"to Std_Loop")
wait_time(0.4)
PlayActionDirect(Actor007,"to  Std_Talk")
wait_time(0.2)
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor004,"to  Std_Sad02")
wait_time(0.8)
PlayActionDirect(Actor007,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(1.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,202,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.4)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,257,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,20,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.4)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:騒がしいね。どうしたんだろ？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3130007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,82,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0016")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ウレリー★★:あっ！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3130009")

-- ▼直接出力
setup_small_camera_end()
bgm_play("BGM_ADV_Invasion2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3130010")

	change_face(Actor002,"Sad")

	--★★ウレリー★★:バルバロイが出たみたい！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3130011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:なんだって！？<br>すぐに行こう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3130012")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(1.0)
Hide(Actor001)
Appear(Actor003)
turn_lookat(Actor002,Actor003,0)
wait_time(0.6)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.4)
PlayActionDirect(Actor003,"to  Std_Talk")
wait_time(0.8)
PlayActionDirect(Actor002,"to  Std_Yes")
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(1.0)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3130014")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Invasion2")
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
