-- このluaスクリプトは、MS_002_061.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",-107.8,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera002 = SetTemplate("Actor003",-17.42,CharaPos112041_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_007)
	Camera003 = SetTemplate("Actor005",86.19,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
load_image("101010140_1", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{1.18,0,0.91})
-- ▲直接出力
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(sakabin ,Actor005, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
se_play("SE_ADV_MA_01B109_10_Ambient_Loop")
-- ▲直接出力
-- ▼直接出力
load_image("201010800", "content_still_20101080_image", "201010800_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("201010800", 0.0, 0.0,0 ,true,false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116044)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("401036","001","401036001")
	Actor005 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.2)
se_play("SE_ADV_Loop_Stop")
-- ▲直接出力

	--★★テロップ★★:ブリテン島　六世紀
	Talk(Actor001,"telop","simple","L","MS_002_0610005")


	--★★テロップ★★:4/21/2024
	Talk(Actor001,"telop","simple","L","MS_002_0610009")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
wait_time(0.6)
setup_small_camera_start(RndCamera008)
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(2.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ウレリー★★:今日はありがと。付き合ってくれて<br>ご馳走するよ、昨日と変わり映えしないけど
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610010")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MS_002_0610011")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0015")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:そんなこと言ったっけ？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610012")

	change_face(Actor003,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MS_002_0610013")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.8, 0.1, 0.4, 0.2,0.5)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:あ、そうだ。ばらさないでよ？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610014")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight(Actor001, 0.8, 0.1, 0.4, 0.2,0.5)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MS_002_0610015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ウレリー★★:ワタシの泣き言。ばらさないでね
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610017")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
wait_time(0.62)
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:イヤなんだよ<br>自分のことが根も葉もない噂になるの
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610018")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0078")
-- ▲直接出力

	--★★ウレリー★★:悪い噂にも…良い噂にもなりたくない<br>そんなの本当のワタシじゃないから
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610019")

	change_face(Actor003,"Normal")

	--★★ノワール★★:
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MS_002_0610020")

	change_face(Actor002,"Serious")

	--★★ウレリー★★:忘れないでね。約束
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610021")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
CloseTalkWindow()
wait_time(1.1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:わかった。忘れない
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MS_002_0610022")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_MidFade")
wait_time(0.5)
se_play("SE_ADV_MA_Urery_Earthquake_Loop")
wait_time(0.23)
shake_camera(Camera002, 0.22,0.62)
wait_time(0.62)
wait_time(0.3)
setup_small_camera_start(RndCamera007)
shake_camera(RndCamera007, 0.22,300)
wait_time(1.5)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
PlayActionDirect(Actor005,"to  Std_Surp")
lookat_weight_reset(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-122.8,0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to  Std_Surp")
wait_time(0.2)
bgm_play("BGM_ADV_Serious2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:………なんだ？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MS_002_0610025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.42)
se_play("SE_ADV_MA_Urery_Earthquake_Loop")
wait_time(0.62)
shake_camera(Camera002, 0.22,0.62)
wait_time(0.62)
setup_small_camera_start(RndCamera007)
shake_camera(RndCamera007, 0.22,300)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:門のほうから…<br>なんの…音？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610027")

-- ▼直接出力
setup_small_camera_start(Camera002)
shake_camera(Camera002, 0.42,300)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0029")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ノワール★★:近づいてくる…<br>これは──…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MS_002_0610029")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140_1", 0.0, 0.0, 1.0,false,false)
set_scale_image(20,20)
wait_time(1.9)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor004,"Normal")
	change_face(Actor004,"Normal")

	--★★キャメロット軍兵士_下位★★:敵襲―――ッッ！！！！
	Talk(Actor004,"NPCNAME_0363","speech","N","MS_002_0610031")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01A112_18_Door")
wait_time(2.3)
hide_image(1.0)
setup_small_camera_start(Camera001)
shake_camera(Camera001,0.42,300)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0086")
-- ▲直接出力

	--★★ウレリー★★:て、き…！？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0610033")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_MidFade")
wait_time(1.1)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140_1", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
load_image_preload("201010800", "content_still_20101080_image", "201010800_StillImage")
preload_sound("BGM_ADV_Serious2")
	InitializeLoad_Preload()
	load_area_scene_preload(116044)
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("401036","001","401036001")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
