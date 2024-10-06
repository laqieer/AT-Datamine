-- このluaスクリプトは、MA_01104_310.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",160,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera003 = SetTemplate("Actor003",348,CharaPos110151_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1003_01_Controller","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_007)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
Hide(Actor001)
set_pos(Actor001,{-0.65,0,5.38})
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("402002","001","402002001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
Appear(Actor001)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,-0.646,0,3.816,1.0)
wait_time(1.0)
turn_chara(Actor001,135,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3100001")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101063_0202_Cat_Barks")
-- ▲直接出力

	--★★ネコ★★:
	Talk(Actor003,"NPCNAME_0378","speech","N","MA_01104_3100002")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3100003")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3100005")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
change_face(Actor002,"Surprise")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_3100008","MA_01104_3100009","MA_01104_3100010")
	if is_select(1) then
		goto BlockMA_01104_310_1_1
	elseif is_select(2) then
		goto BlockMA_01104_310_1_2
	elseif is_select(3) then
		goto BlockMA_01104_310_1_3
	end

::BlockMA_01104_310_1_1::
	CloseTalkWindow()
	goto BlockMA_01104_310_1end

::BlockMA_01104_310_1_2::
	CloseTalkWindow()
	goto BlockMA_01104_310_1end

::BlockMA_01104_310_1_3::
	CloseTalkWindow()
	goto BlockMA_01104_310_1end

::BlockMA_01104_310_1end::
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Anger")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3100012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3100013")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Angry")
-- ▲直接出力

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3100014")


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3100015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3100017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3100018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("402002","001","402002001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
