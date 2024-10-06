-- このluaスクリプトは、EA_007_052.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",65,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",-55,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
lookat_weight(Actor001,0.65,0.08,0.8,0.6)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.65,0.08,0.8,0.6)
-- ▲直接出力
-- ▼直接出力
lookobj_g01 = create_object("kara")
set_pos(lookobj_g01,{2.3, 1.65, -0.872})
lookobj_g02 = create_object("kara2")
set_pos(lookobj_g02,{0.756,1.65,1.434})
-- ▲直接出力
-- ▼直接出力
lookobj_r01 = create_object("kara4")
set_pos(lookobj_r01,{0.526,1.56,1.917})
lookobj_r02 = create_object("kara5")
set_pos(lookobj_r02,{-1.319,1.56,-0.502})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat_object(Actor001,nil,"kara")
keep_ik_lookat_object(Actor002,nil,"kara4")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara2",0.5)
wait_time(0.1)
on_camera(RndCamera001)
hide_image(BLACK_WHITE_TIME)
wait_time(0.5)
keep_delay_ik_lookat_object(Actor002,nil,"kara5",0.5)
wait_time(1.0)
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.4)
wait_time(0.5)
keep_delay_ik_lookat_object(Actor002,nil,"kara4",0.5)
wait_time(1.8)
lookat_delay_weight_reset(Actor001,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-50,0.3)
wait_time(0.15)
lookat_delay_weight_reset(Actor002,0.25)
wait_time(0.15)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,102,0.35)
wait_time(0.35)
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0020")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:なんでそんなヤツに<br>カイルを渡しちまうかなアッ！？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_007_0520003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0007")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:カイルくんの叔父サンに<br>ようやく連絡がついて──
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0520004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラグネル★★:事情を知らない使用人さんがその叔父サンに<br>カイルくんを託しちゃったんだって！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0520005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:カイルくんも叔父サンに<br>喜んでついていっちゃったから…！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0520006")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0016")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ガウェイン★★:ああっ、クソッ！<br>カイルー！！カイルー！！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_007_0520007")

-- ▼直接出力
wait_time(0.3)
CloseTalkWindow()
wait_time(0.2)
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor001,"to Run")
turn_lookat_position(Actor001,{1.082,0,6.99},0.2)
wait_time(0.1)
slidemove(Actor001,{1.082,0,6.99},2.0)
wait_time(0.35)
PlayActionDirect(Actor002,"to Run")
turn_lookat_position(Actor002,{0.218,0,6.44},0.2)
wait_time(0.15)
slidemove(Actor002,{0.218,0,6.44},2.0)
wait_time(0.3)
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
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
