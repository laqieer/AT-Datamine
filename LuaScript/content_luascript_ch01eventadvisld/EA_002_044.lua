-- このluaスクリプトは、EA_002_044.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",288,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera002 = SetTemplate("Actor002",-130,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera003 = SetTemplate("Actor003",225,CharaPos114011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_008)
	Camera004 = SetTemplate("Actor004",85,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor004, 1, false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"ToAbnormal")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0007")
-- ▲直接出力

	--★★イゾルデ★★:──結果の見えるギャンブルなんて<br>乗る価値ないし、つまらないわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_043008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0008")
-- ▲直接出力

	--★★イゾルデ★★:『裏表どっちでもいい』──同感よ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_043009")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "苦しみ")
-- ▲直接出力

	--★★山賊★★:げ、げ、解毒薬を飲ませてくれ…！！<br>賭けはもう降りるから！自分の負けでいいから！
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_043010")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ", "0013")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:勝手に飲みなさい<br>コインはどうしたの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_043011")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "驚き")
-- ▲直接出力

	--★★山賊★★:え、ああ、お、落としてしまった…！
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_043012")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:ふぅん？<br>──あ、コレがそうね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_043013")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,167.2,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight(Actor002, 0.5, 0.5, 0.5, 0.2,0.3)
keep_delay_ik_lookat(Actor002,Actor002,"J_Leg_R",0.8)
wait_time(0.5)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…イゾルデ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_043015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:ノワール<br>こっちの賭けは愉しかったわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_043016")

-- ▼直接出力
 --lookat_weight_reset(Actor002)
 --set_enable_auto_lookat(Actor002, true)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_043017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:コインの出目、当たっているわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_043019")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
