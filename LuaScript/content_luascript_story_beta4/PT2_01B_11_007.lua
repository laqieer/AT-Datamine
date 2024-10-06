-- このluaスクリプトは、PT2_01B_11_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:あらたな問題は発生してしまったけど<br>ひとまず聖杯は手に入れられたわね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","PT2_01B_11_0070002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:そうだな。ここに至るまで<br>随分と時間がかかってしまった
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_11_0070003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ふたりは俺が学園に来る前から<br>聖杯を探してたんだよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0070004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力

	--★★ヴォールス★★:バルバロイ討伐任務の合間を縫って<br>少しずつではあったがな
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_11_0070005")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:円卓の騎士の目的とはいえ<br>聖杯は伝説のなかの不確かな存在にすぎなかった
	Talk(Actor003,"CHRNAME_CLARE","speech","L","PT2_01B_11_0070006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★クレア★★:あるかどうかもわからない希望より<br>目の前の危険への対処を優先するのは当然ね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","PT2_01B_11_0070007")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:だが、お前が現れたことで<br>すべてが変わった
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_11_0070008")


	--★★ヴォールス★★:バルバロイ殲滅という夢物語が<br>現実のものになるかもしれん
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_11_0070009")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やれ継承者だ、やれ聖杯を扱える選ばれし者だ<br>…なんて言われても、正直実感が沸かない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0070010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど、みんなの努力を無駄にしないためにも<br>期待には応えたいと思ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0070011")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:応えられるか、応えられないかは<br>二の次でいいの
	Talk(Actor003,"CHRNAME_CLARE","speech","L","PT2_01B_11_0070012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ヴォールス★★:期待に応えようという姿勢を見せてくれること<br>自分たちはそれが嬉しいのだ
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_11_0070013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ありがとう、ヴォールス、クレア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0070014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "喜び")
-- ▲直接出力

	--★★クレア★★:焦らず、一歩一歩進んでいきましょう<br>まずは目の前の問題を解決しないと
	Talk(Actor003,"CHRNAME_CLARE","speech","L","PT2_01B_11_0070015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
