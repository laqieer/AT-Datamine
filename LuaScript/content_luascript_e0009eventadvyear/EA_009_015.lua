-- このluaスクリプトは、EA_009_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_04","112021_04_h")
Include("content_adv_advsmall_112021_04","Template112021_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_04_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_009)
	Camera002 = SetTemplate("Actor002",103,CharaPos112021_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_001)
	Camera003 = SetTemplate("Actor003",310,CharaPos112021_04_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_010)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_04_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_03_EA009_015_Controller","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_009)
	InitializeTemplateRandomCamera112021_04()
	InitializeTemplate112021_04()
-- ▼直接出力
set_pos(Actor001,{-12.218,0,9.5})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
mob01 = get_object("m100")
mob02 = get_object("m101")
mob03 = get_object("m102")
set_pos(mob01,{0,-20,0})
set_pos(mob02,{0,-20,0})
set_pos(mob03,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = cat_template_camera("P80_Cam")
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({-3.44, 4.11, -0.3,   23, 265.1, 0,   20})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
turn_lookat_position(Actor001,CharaPos112021_04_009[1],CharaPos112021_04_009[2],CharaPos112021_04_009[3],0)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,CharaPos112021_04_009[1],CharaPos112021_04_009[2],CharaPos112021_04_009[3],1.7)
wait_time(0.2)
setup_small_camera_start(Camera001)
hide_image(1.0)
wait_time(1.5)
PlayActionDirect(Actor001,"to  Std_Worry")
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:ディナタンたち、こっちに来たはずだけど…<br>なんの用があるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0150002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
setup_small_camera_start(RndCamera002)
Hide(Actor001)
Appear(Actor005)
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to hide01")
wait_time(0.8)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール2★★:
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_009_0150003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力

	--★★アーサー★★:さて、いったいどういうつもりかな<br>俺をこんな人気のないところに呼び出すとは
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150007")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0008")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0150008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力

	--★★アーサー★★:わかったぞ！陳情だな！<br>学食に新メニューを増やしてほしいと！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150009")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エレイン★★:！？！？！？<br>違います！！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0150010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0039")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:いやあ、俺も日頃から学食のメニューには<br>もう少しパンチが欲しいと思っていたんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150011")

	PlayAction(Actor003,"to  Std_Surp")

	--★★エレイン★★:ですから、違います！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0150012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力

	--★★アーサー★★:ハハハ、冗談冗談<br>で、なんだ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150013")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0038")
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0150014")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002, false)
setup_small_camera_start(CameraEx_01)
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール2★★:…？よく聞こえないな<br>いったいなにを話してるんだろう
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_009_0150017")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start(Camera002)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0046")
-- ▲直接出力

	--★★アーサー★★:…なるほど！<br>それくらいならお安い御用だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150018")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0028")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ディナタン★★:本当ですか！？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0150019")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:よかったですね、ディナタンさん！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0150020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディナタン★★:
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0150021")

	change_face(Actor003,"Normal")

	--★★エレイン★★:私も手伝います！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0150022")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_lookat_position(Actor004,{-7.44,0,-0.248},0.4)
wait_time(0.4)
slidemove(Actor004,{-7.44,0,-0.248},2.0)
PlayActionDirect(Actor003,"to Wlk")
lookat_delay_weight_reset(Actor003,1.0)
turn_lookat_position(Actor003,{-7.46,0,-1.19},0.4)
wait_time(0.1)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
wait_time(0.3)
slidemove(Actor003,{-7.46,0,-1.19},2.0)
wait_time(2.0)
setup_small_camera_start(Camera002)
wait_time(1.6)
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
Hide(Actor004)
Hide(Actor003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力

	--★★アーサー★★:いやあ、いい生徒たちだな<br>学長の指導がいいんだろうか…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150026")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera005)
wait_time(0.2)
turn_chara(Actor002,64,0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
PlayActionDirect(Actor005,"to hide01_end")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★ノワール2★★:気づいてたのか
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_009_0150027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,{-3.58, 4.05, -0.31,},8)
Hide(Actor005)
Appear(Actor001)
set_pos(Actor001,{-9.9,0,3})
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{-10.241,0,-0.65},1.8)
wait_time(1.8)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
turn_chara(Actor001,-114,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150028")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150029")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(RndCamera002)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:他のことって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0150030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:すぐに分かるさ<br>本当に…良い生徒たちだよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_009_0150032")


	--★★ノワール★★:…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0150033")

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
	load_area_scene_preload(116031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
