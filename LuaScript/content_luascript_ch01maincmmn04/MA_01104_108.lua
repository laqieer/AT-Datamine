-- このluaスクリプトは、MA_01104_108.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-17.42,CharaPos112041_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_007)
	Camera002 = SetTemplate("Actor002",-107.8,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera003 = SetTemplate("Actor003",86.19,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
 load_image("101010140_1", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{1.18,0,0.91})
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
 load_image("insert_001", "content_still_10301034_image", "103010340_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("insert_001", 0.0, 0.0, 0 ,true,false) 
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B109_10_Ambient_Loop")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116044)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("401036","001","401036001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(4.2)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(1.2)

se_play("SE_ADV_Loop_Stop")
hide_image(0)
setup_small_camera_start(RndCamera008)

wait_time(2.0)
fadein(FADE_TIME)
 wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(1.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力


-- ▲直接出力

	--★★ウレリー★★:そんなこと言ったっけ？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:結局なにも買ってないよな？<br>いいのか？生徒会のオシゴトなんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080003")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:そんなこと言ったっけ？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.8, 0.1, 0.4, 0.2,0.5)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:あ、そうだ。ばらさないでよ？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080008")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight(Actor001, 0.8, 0.1, 0.4, 0.2,0.5)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力

	--★★ノワール★★:なんだ。突然どうした
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ウレリー★★:一晩考えてなんか恥ずかしくなってきた<br>昨日…ノワールくんに話したこと
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ウレリー★★:ワタシの泣き言。ばらさないでね
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080011")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
wait_time(0.62)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ウレリー★★:イヤなんだよ<br>自分のことが根も葉もない噂になるの
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080013")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★ウレリー★★:悪い噂にも…良い噂にもなりたくない<br>そんなの本当のワタシじゃないから
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:言わないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080015")

	change_face(Actor002,"Serious")

	--★★ウレリー★★:忘れないでね。約束
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:わかった。忘れない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080018")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Worry")
wait_time(1.1)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:………いまいち信じられないなあ<br>口約束だけじゃあなあ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ど、どうすればいいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080021")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
wait_time(0.32)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ウレリー★★:ノワールくんの泣き言も聞かせて！<br>それでおあいこにしようよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080024")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:いきなり出ないって、泣き言なんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080025")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:いいから
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080026")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………うーん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080028")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…！？<br>だから、彼を追って…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080029")


	--★★ノワール★★:「ランスロットに殺された」と<br>風の噂で聞いたんだ。傭兵団にいるとき
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:…！？<br>だから、彼を追って…？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Pain")

	--★★ノワール★★:<dot>本当</dot>は何があったのか<br><dot>現実</dot>を知るのが…すこし怖い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:その噂、信じてる？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080035")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…今は<br>よくわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080036")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:今は、って？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080037")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:根も葉もない噂かもしれないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080039")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ウレリー★★:…きっとそうだよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080041")

-- ▼直接出力
bgm_play("BGM_ADV_Serious2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.42)
se_play("SE_ADV_MA_Urery_Earthquake_Loop")
wait_time(0.62)
shake_camera(Camera002, 0.22,0.62)
wait_time(0.62)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Surp")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
shake_camera(RndCamera007, 0.22,300)
-- ▲直接出力
-- ▼直接出力
lookat_weight_reset(Actor001)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-122.8,0.32)
wait_time(0.32)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080043")

	change_face(Actor002,"Surprise")

	--★★ウレリー★★:門のほうから…<br>なんの…音？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080045")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
shake_camera(Camera001, 0.42,300)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:近づいてくる…<br>これは──…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1080047")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140_1", 0.0, 0.0, 1.0,false,false)
set_scale_image(20,20)
wait_time(1.9)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor004,"Normal")

	--★★ログレス兵A★★:
	Talk(Actor004,"NPCNAME_0363","speech","N","MA_01104_1080049")

-- ▼直接出力
 se_play("SE_ADV_MA_01A112_18_Door")
-- ▲直接出力
	close_cutin()
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(2.3)
-- ▲直接出力
-- ▼直接出力
 hide_image(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
shake_camera(Camera002, 0.42,300)
-- ▲直接出力

	--★★ウレリー★★:て、き…！？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MA_01104_1080051")

-- ▼直接出力
CloseTalkWindow()
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
 load_image_preload("insert_001", "content_still_10301034_image", "103010340_StillImage")
preload_sound("BGM_ADV_Serious2")
	InitializeLoad_Preload()
	load_area_scene_preload(116044)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("401036","001","401036001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
