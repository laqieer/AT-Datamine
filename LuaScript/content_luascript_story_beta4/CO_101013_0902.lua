-- このluaスクリプトは、CO_101013_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	Camera003 = SetTemplate("Actor003",236,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_common_look_at(Actor001,Actor003)
lookat_delay_weight(Actor001,0.4, 0.08, 0.7, 0.7,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor003)
lookat_delay_weight(Actor002,0.4, 0.08, 0.7, 0.7,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
 -- lookat_delay_weight(Actor004,0.4, 0.08, 0.7, 0.7,0.6)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101018","001","101018001")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:キッスさんちょっと相談があるんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09020002")

-- ▼直接出力
 --ラグネル登場のため、カメラを指定
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★キッス★★:あ、ラビットちゃんにガウェインくんふたり宛に届け物がね…
	Talk(Actor004,"CHRNAME_KISS","speech","L","CO_101013_09020003")

-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ラグネル2★★:ふたりとも！ここにいたんだ
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","CO_101013_09020005")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --ノワールとガウェインの首を調整
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.4)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.4)
wait_time(0.1)
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ラグネル？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_09020006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうした？なにかあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09020007")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:遠征に行ったバルバロイ討伐隊が苦戦してるってことで
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_09020008")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ラグネル★★:あたしたちに応援要請が来たの！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_09020009")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:なんだって！？モタモタしてらんねーな、すぐに出るぞ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_09020011")

-- ▼直接出力
 --ノワールとガウェインの首を調整
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
wait_time(0.3)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.8)
wait_time(0.1)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさん、ごめん話の途中だったけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★キッス★★:う、うん、行ってらっしゃい用事が終わったらまた顔を出してね
	Talk(Actor004,"CHRNAME_KISS","speech","L","CO_101013_09020013")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ9_3")
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
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101018","001","101018001")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
