-- このluaスクリプトは、EX_01_02_0003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_06","110011_06_h")
Include("content_adv_advsmall_110011_06","Template110011_06_h")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_06_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit02_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_06_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_06_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_003)
	InitializeTemplateRandomCamera110011_06()
	InitializeTemplate110011_06()
-- ▼直接出力
set_enable_auto_lookat_all(false)
DontChangeRandomCamera(true)

CameraEX_1 = set_camera({-1.634227,1.329779,-3.02459,-2.021,-216.063,0,21.40307})

RndCamera001= CameraEX_1
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit02_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
CameraEX_2 = set_camera({-1.648,1.33899999,2.51099992,3.98900247,143.291306,0.2663894,21.40307})
RndCamera001= CameraEX_2
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(CameraEX_1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力

	--★★ランスロット★★:これから試験の答案を返却する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EX_01_02_00030003")


	--★★ランスロット★★:名前を呼ばれた者から順に取りに来い<br>イーサン――…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EX_01_02_00030005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
template2()
Appear(Actor003)
setup_small_camera_start(CameraEX_2)
RndCamera001= CameraEX_2
wait_time(1)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ねえねえ、ノワール<br>試験の結果どうだった？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EX_01_02_00030008")

-- ▼直接出力
lookat_delay_weight_default(Actor001,1)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:全然ダメだったみたいだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EX_01_02_00030010")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:えっ？そうなの？<br>残念ね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EX_01_02_00030012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアはどうだったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EX_01_02_00030014")

	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:わたし？わたしもノワールと一緒でダメダメよ<br>だから次、頑張りましょ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EX_01_02_00030016")


	--★★ノワール★★:（なんで嬉しそうなんだ…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_02_00030018")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力

	--★★ギネヴィア★★:じゃ、これあげる<br>残念賞！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EX_01_02_00030020")


	--★★ノワール★★:残念賞って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EX_01_02_00030022")


	--★★ギネヴィア★★:成績がイマイチでも頑張りを評価してあげる<br>わたしってば理想の雇い主だと思わない？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EX_01_02_00030024")

-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はいはい<br>いつも感謝してますよ、ご主人様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EX_01_02_00030026")

-- ▼直接出力
play_studyRewards()
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110011_06)
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
