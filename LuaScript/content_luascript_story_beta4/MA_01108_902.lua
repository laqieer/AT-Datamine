-- このluaスクリプトは、MA_01108_902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",85.891,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookoj_noir = create_object("kara_noir")
set_pos_object(lookoj_noir,-0.36,1.1,0.27)
lookat_delay_weight(Actor001,{1.0,0.03,1.0,0.2},1.0)
keep_ik_lookat_object(Actor001,nil,"kara_noir")
change_face(Actor001,"Sad")
CUT_1 = set_camera({0,1.738,1.637,6.395,151.897,0,22})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-2.35,0,0.75})
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera003
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101120011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
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
slidemove(Actor002,CharaPosDuelCommonFormation01_006[1],CharaPosDuelCommonFormation01_006[2],CharaPosDuelCommonFormation01_006[3],1.7)
-- ▲直接出力
-- ▼直接出力
wait_time(1.7)
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
wait_time(1.8)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ブライアンはああ見えて<br>器が大きくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:見た目どおりだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_9020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:…確かに<br>見た目どおりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:頼まれたこと、断らないんだ<br>口ではなんだかんだ言うんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020005")


	--★★ノワール★★:でも傭兵としては、間違ってると思った作戦には<br>参加しないポリシーもあって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:で、さ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020007")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力

	--★★ノワール★★:かっこ、いいな、って…思ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_9020009")


	--★★ランスロット★★:…師匠が
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_9020010")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.1)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…父さんが、なに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020011")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:「彼の強さは千金にも換えがたい」と言っていた<br>「家族のために命を張れる漢だ」とも
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_9020012")


	--★★ノワール★★:…そっか<br>うん。そうなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺は<br>お前をそう感じた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_9020014")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…え
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020015")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ランスロット★★:よく似ている<br>お前とブライアンは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_9020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:お前のなかで彼は生きている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_9020017")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor001,"Sad")
setup_small_camera_start(CUT_1)
wait_time(0.8)
keep_delay_ik_lookat_object(Actor001,nil,"kara_noir",0.18)
wait_time(1.3)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9020018")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera003
	InitializeLoad_Preload()
	load_duel_scene_preload(101120011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
