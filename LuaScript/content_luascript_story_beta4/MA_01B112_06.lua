-- このluaスクリプトは、MA_01B112_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_02","111016_02_h")
Include("content_adv_advsmall_111016_02","Template111016_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_004)
	InitializeTemplateRandomCamera111016_02()
	InitializeTemplate111016_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:父なる彼の、遺児…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_060002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アステラ★★:脱走計画は諦めたの？
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","MA_01B112_060003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:じたばたしてもしょーがないでしょ<br>わたしに危害を加えないこともわかったし
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_060004")


	--★★ギネヴィア★★:せめてあなたたちの狙いぐらい知りたいわ<br>なにも知らない囚われの姫も悪くないケド
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_060005")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ギネヴィア★★:…まず『父なる彼』って誰のコト？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_060007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アステラ★★:銀卓騎士団を産み…育てた人のことよ
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","MA_01B112_060008")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:だからそれは誰よ<br>ペレス王じゃあないわよね？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_060009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★アステラ★★:…誰かは、わからないのよ
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","MA_01B112_060010")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:はァ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_060011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
