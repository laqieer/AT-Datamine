-- このluaスクリプトは、EA_069_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネマウア★★:…なんとか追い返せたわね
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0320001")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:お、お姉ちゃん…怪我は、大丈夫！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0320002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0008")
-- ▲直接出力

	--★★ギネマウア★★:平気よ、これくらい<br>それより…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0320003")


	--★★ギネマウア★★:あのイノシシたち、様子が変だったわ<br>恐慌状態というか…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0320004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0008")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…うん。最初にここで見たときとは全然違う<br>まるでなにかに怯えているみたいな――
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0320005")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…わたし、ちょっと調べてくる！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0320006")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:調べるってなにを――
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0320007")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
local gopos = {0.58, 0, 6.38}
CloseTalkWindow()
PlayActionDirect(Actor002,"to Run")
turn_lookat_position(Actor002, gopos, 0.2)
wait_time(0.2)
slidemove(Actor002, gopos, 0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
lookat_delay_weight_reset(Actor001,1.0)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0014")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:あ、こら！待ちなさい、ギネヴィア！<br>――もう。言い出したら聞かないんだから…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0320009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
