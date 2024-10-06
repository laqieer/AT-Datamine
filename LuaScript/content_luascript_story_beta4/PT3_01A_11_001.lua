-- このluaスクリプトは、PT3_01A_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:おはよう、ノワール<br>学園祭、無事に終わってよかったわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:学園祭をやってよかったな<br>学園だけでなく街のみんなが楽しんでくれたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0010005")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:まあ…大変なこともあったけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0010006")

-- ▼直接出力
PlayPartVoice("ギネヴィア","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:木の役のこと？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力

	--★★ノワール★★:…思い出させるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0010008")

	PlayAction(Actor002,"to  Std_Appl")
-- ▼直接出力
PlayPartVoice("ギネヴィア","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あははっ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ねえ、ノワール<br>授業で教わったじゃない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010010")


	--★★ギネヴィア★★:「記憶がキラーズの武器になる<br>学園生活で良い思い出をたくさん作れ」って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:この数ヵ月<br>辛いことや悲しいこともあったけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010013")

-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたし<br>それ以上に良い思い出を作れてる気がするんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:うん、そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0010015")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア","照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:これからも<br>もっともっと作っていこうね！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_11_0010016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
