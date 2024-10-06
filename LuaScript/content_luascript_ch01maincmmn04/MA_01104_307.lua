-- このluaスクリプトは、MA_01104_307.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",0,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
set_pos(Actor002,{-1.757,0,-0.491})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.15,0,-2.32})
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
IN_WALK(Actor002,CharaPos110011_04_005)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3070001")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_3070002")

-- ▼直接出力
 --ギネヴィア登場のためカメラを固定
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3070003")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,0.275,0,-1.016,1.0)
wait_time(0.3)
setup_small_camera_start()
wait_time(0.7)
turn_chara(Actor003,65,0.2)
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:ギネヴィア殿下は<br>バカみたいに絵になりますから、いいんです
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_3070005")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,295,0.4)
wait_time(0.4)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor002,0.45,0.1,0.85,0.2,1.0)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:（うまく流されたな）
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3070006")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_3070007")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_3070008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01104_3070009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
