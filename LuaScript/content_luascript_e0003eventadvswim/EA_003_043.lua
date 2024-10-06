-- このluaスクリプトは、EA_003_043.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_04","112021_04_h")
Include("content_adv_advsmall_112021_04","Template112021_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_002)
	InitializeTemplateRandomCamera112021_04()
	InitializeTemplate112021_04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor004,Actor001,0)
RndCamera001 = RndCamera006
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-9.362, 1.61, -0.312,   31, 231.8088, 0,   28})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({-9.26, 1.893, -0.57,   14.713, 237.7, 0,   28})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","005","101011005","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0430002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男2","肯定")
-- ▲直接出力

	--★★屋台の店主★★:はい、ありがとうございます！おかげで助かりました…
	Talk(Actor004,"NPCNAME_0372","speech","N","EA_003_0430003")


	--★★屋台の店主★★:強盗たちは私のほうで兵士に引き渡しておきますね
	Talk(Actor004,"NPCNAME_0372","speech","N","EA_003_0430004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:よろしくね！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor004)
set_enable_auto_lookat_all(true)
Camera002 = setup_small_camera_resetting(Actor002,CharaPos112021_04_002,CameraPos112021_04_002)
set_pos(Actor002,{-11.107,0,-1.652})
set_rot(Actor002,{0,100,0})
turn_lookat(Actor003,Actor002,0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:よかったわね。強盗たちも無事捕まえられたし水着もバッチリ発注できたし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430006")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,-9.362,1.79,-0.312,3.0)
turn(CameraEx_01,14,231.8,0,3.0)
wait_time(0.2)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Joy")
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力

	--★★ギネヴィア★★:この水着、カワイイだけじゃなくて動きやすくてイイ感じ！さすがオーダーメイドね♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネマウア","落胆")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネマウア★★:まったくもう…そんな布地の少ない格好で動き回るなんてはしたない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0430009")

-- ▼直接出力
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-9.418,1.844,-0.67,8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:カワイイからいーの、いーのっ！ね、ノワール？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺に聞くなよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0430011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんにせよ、お気に入りが決まったなら水着選びは終了ってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0430012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:んー…と言いたいところだけど、肝心のティルフィングの水着がまだ決まらないのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ノワールのセンスは全然ぴんと来ないし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430014")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:おい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0430015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:でもまぁ、意見の参考にはなったわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430017")


	--★★ギネヴィア★★:散々付き合ってもらって悪いけど、やっぱりもう少し悩むことにするわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430019")

-- ▼直接出力
CameraEx_02 = set_camera({-9.26, 1.893, -0.57,   14.713, 237.7, 0,   28})
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-9.418,1.844,-0.67,8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:せっかくだし、ティルフィングにも最高にカワイイ水着を着てもらいたいしね！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0430020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera006
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","005","101011005","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
