-- このluaスクリプトは、MA_01B112_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111041_01","111041_01_h")
Include("content_adv_advsmall_111041_01","Template111041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111041_01,CameraPos111041_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111041_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName111041_01,CameraPos111041_01_006)
	InitializeTemplateRandomCamera111041_01()
	InitializeTemplate111041_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111041)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101029","002","101029002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★アステラ★★:逃げないの？
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:ほっとけないわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_330004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★アステラ★★:アーサーが聖杯城へ釣れた時点で<br>あなたたち『餌』の役割はオシマイよ
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330005")

	PlayAction(Actor001,"to  Std_No")

	--★★ギネヴィア★★:…あなた、わざと彼らを通したでしょう
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_330007")


	--★★アステラ★★:なんのために？
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330008")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:彼らの選択を見極めるために…<br>もしくは選択を彼らに委ねるために、かしら
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_330009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アステラ★★:キライじゃないわ<br>そういう勘繰り
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:コルベニック城中の部屋を見て回って<br>記録の書物を漁らせてもらったわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_330011")


	--★★ギネヴィア★★:あなたたち…<br>みんな『狂忘症』にかかってたのね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_330012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★アステラ★★:王妃殿下が卑しいマネして
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330013")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:『狂忘症』…大気中のバルバロイの因子に侵され<br>徐々にバルバロイ化し始める病…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_330014")

	change_face(Actor002,"Normal")

	--★★アステラ★★:ペレス様が自身の狂忘症に気づいたのは<br>城中で多くの者が罹患したあとだった
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330015")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:誰が病を持ち込んだの…？<br>外部の者との出入りは滅多になかったでしょう
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B112_330017")

	PlayAction(Actor002,"to  Std_Worry")

	--★★アステラ★★:受け入れられた誰か、かも知れないわね？
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★アステラ★★:家族内で犯人探しをするつもりはなかったわ<br>そんなことはもうどうでも良かったの
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330020")

	change_face(Actor002,"Sad")

	--★★アステラ★★:妖精の湖の加護によって<br>病の進行や病状は極めて緩やかだった代わりに…
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★アステラ★★:バルバロイの芽は深く深く<br>私たちの身体に根を張ったわ
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330022")


	--★★アステラ★★:妖精が去り、守護騎士が消えた聖杯城<br>いずれバルバロイ化する未来は決定的だった
	Talk(Actor002,"CHRNAME_ASTERA2","speech","R","MA_01B112_330023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111041)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101029","002","101029002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
