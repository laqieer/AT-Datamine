-- このluaスクリプトは、MA_01A900_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_02","111061_02_h")
Include("content_adv_advsmall_111061_02","Template111061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",160,CharaPos111061_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111061_02,CameraPos111061_02_005)
	Camera002 = SetTemplate("Actor002",215,CharaPos111061_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111061_02,CameraPos111061_02_003)
	InitializeTemplateRandomCamera111061_02()
	InitializeTemplate111061_02()
-- ▼直接出力
lookat_weight(Actor001,0.6,0.08,0.8,0.6)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.6,0.08,0.8,0.6)
-- ▲直接出力
-- ▼直接出力
 --白背景読込
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- 白背景の表示
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
lookobj_n01 = create_object("kara")
set_pos(lookobj_n01,{2.4,1.63,-17.8})
lookobj_n02 = create_object("kara2")
set_pos(lookobj_n02,{1.2,1.72,-17.8})
lookobj_n03 = create_object("kara3")
set_pos(lookobj_n03,{3.65,1.72,-17.7})
-- ▲直接出力
-- ▼直接出力
lookobj_g01 = create_object("kara4")
set_pos(lookobj_g01,{0.932,1.5,-17.6})
lookobj_g02 = create_object("kara5")
set_pos(lookobj_g02,{2.05,1.6,-17.7})
lookobj_g03 = create_object("kara6")
set_pos(lookobj_g03,{0.19,1.6,-16.7})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat_object(Actor001,nil,"kara")
keep_ik_lookat_object(Actor002,nil,"kara4")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
se_play("SE_ADV_MA_01A900_25_Teleport")
wait_time(2.5)
setup_small_camera_start(RndCamera001)
keep_delay_ik_lookat_object(Actor002,nil,"kara5",0.3)
wait_time(0.2)
hide_image(BLACK_WHITE_TIME)
wait_time(0.2)
keep_delay_ik_lookat_object(Actor001,nil,"kara2",0.35)
wait_time(1.5)
keep_delay_ik_lookat_object(Actor002,nil,"kara6",0.4)
wait_time(0.9)
keep_delay_ik_lookat_object(Actor001,nil,"kara3",0.55)
wait_time(1.5)
lookat_delay_weight_reset(Actor002,0.3)
wait_time(0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.5)
wait_time(0.1)
lookat_delay_weight_reset(Actor001,0.5)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…いま、のは…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_250002")

	open_select_window_tag(Actor001,"Normal","MA_01A900_250004","MA_01A900_250005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Serious")

	--★★ノワール★★:ギネヴィア…！<br>身体は大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_250007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:なんともない、と思うけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_250008")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ありがと、ノワール<br>心配してくれて…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_250009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:サラスから…はじき出された？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_250011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:アーサーたちはいないな<br>あれからどのくらい時間が経ったんだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_250012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:わかんない…けど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_250013")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:サラスでなにを聞いたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_250015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to HoldHead")
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:なんか、たくさんワケが分からないことを<br>いっぱい突っ込まれた感じで…でも──<br>　
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_250016")

-- ▼直接出力
setup_small_camera_end(Camera001)
set_animationbattlecontroller(Actor002,1,true)
PlayActionDirect(Actor002,"ToAbnormal")
SkipDefaultMotion(Actor002)
SkipOffsetCamera(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_250018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★テロップ★★:「あと２度…いえ１度、戦いに赴けば<br>因子はすり減り、ギネヴィアは…」
	Talk(Actor003,"telop","narration","L","MA_01A900_250019")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat_all(false)
shake_camera(RndCamera090,1.0,0)
se_play("SE_ADV_MA_01A900_25_Earthquake_loop")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:なんだ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_250021")

-- ▼直接出力
setup_small_camera_start(Camera002)
shake_camera(Camera002,1.0,0)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:帰ろ、学園に…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_250023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
