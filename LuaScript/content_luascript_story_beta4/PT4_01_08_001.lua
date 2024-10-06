-- このluaスクリプトは、PT4_01_08_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ティルフィング聞きたいことがあるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0010002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:なんでしょうか、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_08_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:キミは聖杯について知っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0010004")


	--★★ティルフィング★★:………
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_08_0010005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:たとえば過去に聖杯がどこに現れただとか前回はどんな願いを叶えてくれたのかだとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0010006")

-- ▼直接出力
PlayPartVoice("ティルフィング", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:申し訳ありません、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_08_0010007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ティルフィング★★:今、聖杯について私からお伝えできることありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_08_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:ただひとつ言えるとすれば聖杯は継承者が手にすべきものだということです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_08_0010009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:もし、手にできなかったら？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0010010")

	change_face(Actor002,"Anger")

	--★★ティルフィング★★:…この地はバルバロイたちに飲み込まれることでしょう
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_08_0010011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…そうかそれならなんとしても手に入れないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:はい、マスター微力ながら私もお力添え致します
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_08_0010013")

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
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
