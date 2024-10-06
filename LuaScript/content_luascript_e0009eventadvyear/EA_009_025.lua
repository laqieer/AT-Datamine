-- このluaスクリプトは、EA_009_025.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-30,CharaPos110061_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_002)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
-- ▼直接出力
change_face(Actor001,"Sad")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage") --手紙スチル
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
binsen = setup_prop_object(10106003)
binsen_offset  = {-0.138,-0.03,0.017,1.931,-18.337,9.362}
off_active(binsen)
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera004
RndCamera004 = RndCamera001
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.3)
lookat_delay_weight(Actor001, {0.9, 0.03, 0.5, 0.5} , 0.8)
keep_ik_lookat(Actor001, Actor003, "J_Head")
turn_lookat( Actor003,Actor001, 0.3)
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…目ぼしい情報はなさそうだな<br>ん？どうした、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0250002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor003,"to  Std_Talk")
lookat_delay_weight_reset(Actor001 , 0.3)
turn_lookat( Actor001,Actor003, 0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
on_parent(binsen,Actor001, "J_Hand_L", binsen_offset)
on_active(binsen)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
turn_lookat( Actor002,Actor001, 0)
-- ▲直接出力

	--★★ノワール★★:「本に載ってるような治療法をイゾルデさんが<br>知らないってことはないんじゃないかなぁ？」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0250004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0019")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:せ、正論
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0250005")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0250007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▲直接出力

	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0250008")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
change_face(Actor002,"Normal")
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:文字にされると痛いんだな、正論って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0250009")

-- ▼直接出力
off_active(binsen)
off_parent(binsen)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:他の場所にも行ってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0250010")

-- ▼直接出力
reserve_next_script("シナリオイベクエ/新年24/2話_ADV_4_5")
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
load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
setup_prop_object_preload(10106003)
binsen_offset  = {-0.138,-0.03,0.017,1.931,-18.337,9.362}
RndCamera001 = RndCamera004
RndCamera004 = RndCamera001
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
