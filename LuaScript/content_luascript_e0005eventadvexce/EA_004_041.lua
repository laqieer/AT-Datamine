-- このluaスクリプトは、EA_004_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_02","110011_02_h")
Include("content_adv_advsmall_110011_02","Template110011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_009)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_003)
	InitializeTemplateRandomCamera110011_02()
	InitializeTemplate110011_02()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
change_face(Actor001,"Sad")
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ノワール★★:（参ったな…学園祭の出し物が全然決まらない<br>さすがにそろそろ決めないと）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_004_0410004")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat_position(Actor001,CharaPos110011_02_006[1],CharaPos110011_02_006[2],CharaPos110011_02_006[3],0.2)
wait_time(0.3)
slidemove(Actor001,CharaPos110011_02_006[1],CharaPos110011_02_006[2],CharaPos110011_02_006[3],3.4)
wait_time(0.5)
setup_small_camera_start()
wait_time(2.9)
turn_chara(Actor001,CharaPos110011_02_006[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
Camera001 = InitializeCharaCamera(CameraAssetBundleName110011_02,CameraPos110011_02_006, Actor001) --アクターのカメラを再設定
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なぁ、ちょっといいか？<br>学園祭なんだけど――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0410006")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.3)
wait_time(0.2)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.3)
wait_time(0.1)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("女子1","0037")
-- ▲直接出力

	--★★女子生徒A★★:ごめん。これから自主練なの
	Talk(Actor002,"NPCNAME_0146","speech","N","EA_004_0410007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え！？キミたちもか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0410008")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("女子2","落胆")
-- ▲直接出力

	--★★女子生徒B★★:私たち、学科試験の結果がよくなくて<br>ここで挽回しないといけないの
	Talk(Actor003,"NPCNAME_0147","speech","N","EA_004_0410009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1","肯定")
-- ▲直接出力

	--★★女子生徒A★★:学園祭のことはノワールに任せるから<br>イイ感じの出し物、決めといてね
	Talk(Actor002,"NPCNAME_0146","speech","N","EA_004_0410010")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力

	--★★ノワール★★:ええっ？…そう言われても、<br>全然いいアイデアが浮かばないんだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0410011")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("女子2","肯定2")
-- ▲直接出力

	--★★女子生徒B★★:大図書院で本でも読めばなんか思いつくって！<br>よろしくね
	Talk(Actor003,"NPCNAME_0147","speech","N","EA_004_0410012")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.3)
PlayActionDirect(Actor003,"to Wlk")
wait_time(1.7)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
Hide(Actor002)
Hide(Actor003)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:マジか…他に相談できそうな人もいないし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0410014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:…とりあえず、大図書院に行ってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0410015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
