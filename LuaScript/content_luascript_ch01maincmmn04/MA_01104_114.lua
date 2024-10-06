-- このluaスクリプトは、MA_01104_114.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_02","110011_02_h")
Include("content_adv_advsmall_110011_02","Template110011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",166.9724,CharaPos110011_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_007)
	Camera002 = SetTemplate("Actor002",113.358,CharaPos110011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_002)
	Camera003 = SetTemplate("Actor003",93.92962,CharaPos110011_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_009)
	Camera004 = SetTemplate("Actor004",252.7573,CharaPos110011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_004)
	Camera005 = SetTemplate("Actor005",69.23524,CharaPos110011_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_006)
	Camera006 = SetTemplate("Actor006",288.819,CharaPos110011_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_008)
	InitializeTemplateRandomCamera110011_02()
	InitializeTemplate110011_02()
-- ▼直接出力
RndCamera001 =  RndCamera002
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-0.56,0,5.73})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-3.599,0,-3.789})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{3.208,0,1.185})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Unrest")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★男子生徒A★★:
	Talk(Actor004,"NPCNAME_0151","speech","N","MA_01104_1140003")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★男子生徒B★★:
	Talk(Actor005,"NPCNAME_0153","speech","N","MA_01104_1140004")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★女子生徒A★★:ずいぶん持ちこたえてたらしいよ<br>見たことない巨大なバルバロイも倒したって
	Talk(Actor006,"NPCNAME_0146","speech","N","MA_01104_1140005")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")

	--★★男子生徒A★★:
	Talk(Actor004,"NPCNAME_0151","speech","N","MA_01104_1140007")


	--★★女子生徒A★★:
	Talk(Actor006,"NPCNAME_0146","speech","N","MA_01104_1140008")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★女子生徒B★★:
	Talk(Actor007,"NPCNAME_0147","speech","N","MA_01104_1140009")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
Appear(Actor001)
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,{1.0,0.03,0.7,0.2},1.0)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.6)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★女子生徒A★★:
	Talk(Actor006,"NPCNAME_0146","speech","N","MA_01104_1140011")

	PlayAction(Actor005,"to  Std_Talk")

	--★★男子生徒B★★:
	Talk(Actor005,"NPCNAME_0153","speech","N","MA_01104_1140012")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor002,1.559,0,4.849,2.4)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001,{1.0,0.03,0.45,0.2},1.0)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1140015")


	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1140016")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,246.9044,0,0.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:学園中がちょっとは思い知ったはずよ<br>あなたの力、あなたの覚悟
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1140018")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:あなたたちがバルバロイを食い止めてくれた<br>おかげで民の被害は抑えられた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1140019")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1140020")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1140021")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:「被害は抑えられた」………？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01104_1140023")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,319.7531,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,38.58867,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor006,0,341.9949,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor007,0,13.97764,0,0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1140025")

-- ▼直接出力
bgm_play("BGM_ADV_Unrest")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	open_cutin(1,1)
	on_cutin(1,Actor001,"Serious")

	--★★ノワール★★:そんなはずない、そんなはずないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01104_1140027")

	close_cutin()
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1140029")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1140033")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C111_20_Bell")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003,-0.951,0,-3.198,2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,11,0,0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★ランスロット★★:
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_1140035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 =  RndCamera002
preload_sound("BGM_ADV_Unrest")
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
