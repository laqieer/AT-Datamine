-- このluaスクリプトは、EA_009_026.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera003 = SetTemplate("Actor003",-140,CharaPos112021_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
-- ▼直接出力
load_image("104000280", "content_still_10400028_image", "104000280_StillImage") 
-- ▲直接出力
-- ▼直接出力
binsen = setup_prop_object(10106003)
binsen_offset  = {-0.134,-0.031,0.011,-0.189,-15.541,0.082}
off_active(binsen)
CameraEX = set_camera({0.376,1.767,0.921,7.456,130.972,0.225,18.79701})
set_camera_nearclip(CameraEX,0.1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("マルイル","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:声が出ない、ですか…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_009_0260003")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoiceDirect("マルイル","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:うーん…<br>喉の炎症を抑える飴ならあるんですけど…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_009_0260004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:喉は腫れてないそうなんだ<br>身体に異常は見られないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0260005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★マルイル★★:なら、薬をオススメするのも違いますもんね<br>うーん…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_009_0260006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:…あ！これはどうです？このぬいぐるみ<br>ボタンを押すと喋るんです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_009_0260007")

-- ▼直接出力
ShowImageItem("104000280")
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
HideImageItem()
wait_time(0.3)
lookat_delay_weight(Actor001, {0.9, 0.03, 0.5, 0.5} , 0.8)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.8)
PlayActionDirect(Actor004,"to  Std_Surp")
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、声が出りゃいいってもんじゃなくて<br>…ん？どうしたディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0260009")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
PlayActionDirect(Actor004,"to Wlk")
PlayActionDirect(Actor001,"to Wlk")
lookat_delay_weight_reset(Actor001 , 0.3)
lookat_delay_weight_reset(Actor004 , 0.3)
turn_lookat( Actor004,Actor001, 0.3)
turn_lookat( Actor001,Actor004, 0.3)
wait_time(0.3)
PlayActionDirect(Actor004,"to  Std_Talk")
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.2)
PlayActionDirect(Actor004,"to Std_Loop")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
on_parent(binsen,Actor001, "J_Hand_L", binsen_offset)
on_active(binsen)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:「かわいい」――え！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0260011")

-- ▼直接出力
setup_small_camera_end()
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
off_active(binsen)
off_parent(binsen)
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:確かに、かわいいです！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0260012")

-- ▼直接出力
setup_small_camera_start(CameraEX)
slidemove2(CameraEX,0.426,1.766,0.961,5.0,0)
lookat_delay_weight(Actor004,1.0,0.5,1.0,0,0.8)
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力

	--★★ディナタン★★:（じーーーーっ）
	Talk(Actor004,"CHRNAME_DINATAN","mind","L","EA_009_0260014")

-- ▼直接出力
change_face(Actor003,"Normal")
PlayActionDirect(Actor003,"to Wlk")
turn_lookat( Actor003,Actor001, 0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★ディナタン／エレイン★★:（じーーーーっ）
	Talk(Actor005,"CHRNAME_DINATAN_ELAINE","mind","N","EA_009_0260015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………わかった。買うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0260016")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0036")
-- ▲直接出力

	--★★マルイル★★:ありがとうございます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_009_0260018")

	PlayAction(Actor004,"to  Std_Joy")
	change_face(Actor004,"Smile")

	--★★ディナタン★★:♪
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0260019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…他の場所にも行ってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0260020")

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
load_image_preload("104000280", "content_still_10400028_image", "104000280_StillImage")
setup_prop_object_preload(10106003)
binsen_offset  = {-0.134,-0.031,0.011,-0.189,-15.541,0.082}
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
