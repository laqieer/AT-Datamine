-- このluaスクリプトは、OV_ST1_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",164,CharaPos112011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_005)
	Camera002 = SetTemplate("Actor002",245,CharaPos112011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_002)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
-- ▼直接出力
lookat_weight(Actor001,0.45,0.08,0.8,0.6)
-- ▲直接出力
-- ▼直接出力
gate = setup_prop_object(10130029)
set_pos(gate,{1.73,3.26,-13.36})
lookobj = create_object("kara")
set_pos(lookobj,{2.56,0.9,2.56})
lookat_weight(Actor002,0.45,0.08,0.8,0.6)
keep_ik_lookat(Actor002,gate,"root")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020001")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定3")
-- ▲直接出力

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
wait_time(0.05)
turn_chara(Actor001,95,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020004")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020005")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020007")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor001,gate,"root",0.3)
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020014")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020015")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020017")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020023")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020024")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat_object(Actor002,nil,"kara",0.4)
wait_time(2.0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.2)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020026")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020027")


	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020029")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020031")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020034")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020035")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","OV_ST1_020037")

-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","OV_ST1_020040")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
ShowTutorialPopup(64)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130029)
	InitializeLoad_Preload()
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
