-- このluaスクリプトは、MA_01108_904.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
set_enable_auto_lookat_all(false)
lookoj_noir = create_object("kara_noir")
set_pos_object(lookoj_noir,-0.36,1.1,0.27)
lookat_weight(Actor001,{1.0,0.03,1.0,0.2})
keep_ik_lookat_object(Actor001,nil,"kara_noir")
change_face(Actor001,"Sad")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-2.67,0,0.45})
keep_ik_lookat(Actor002,Actor001,"J_Head")
change_face(Actor002,"Sad")
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera003
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101120012)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn_lookat_position(Actor002,CharaPosDuelCommonFormation01_006[1],CharaPosDuelCommonFormation01_006[2],CharaPosDuelCommonFormation01_006[3],0)
slidemove(Actor002,CharaPosDuelCommonFormation01_006[1],CharaPosDuelCommonFormation01_006[2],CharaPosDuelCommonFormation01_006[3],1.6)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0.1)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.15)
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara_noir",0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(2.4)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ブライアンさんは<br>あの家にいた頃から優しくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:わたしが泣きだすと<br>困った顔をしながらもいつも慰めてくれて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040004")


	--★★ノワール★★:…そうだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9040005")


	--★★ディナタン★★:…ブライアンさんはわたしの歌は<br>元気をくれるって言ってたけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:本当に元気をもらっていたのは<br>わたしのほう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:ブライアンさんの笑顔を見ると<br>どんな不安にも耐えられた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040008")


	--★★ノワール★★:…俺もだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9040009")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")

	--★★ディナタン★★:後悔してるの<br>言えなかったこと、後悔してるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040010")


	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9040011")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:「いつもありがとう、おとうさん」って<br>「おとうさん、だいすきだよ」って
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040012")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…言わなきゃ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040013")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.15)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9040014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…「いつもありがとう、にいさん」
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 2.0,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn_lookat_position(Actor002,0.1,0,0.11,0.1)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor002,0.1,0,0.11,1.5)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:だいすき
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_9040016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
RndCamera001 = RndCamera003
	InitializeLoad_Preload()
	load_duel_scene_preload(101120012)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
