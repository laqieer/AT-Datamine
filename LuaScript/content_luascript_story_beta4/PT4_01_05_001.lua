-- このluaスクリプトは、PT4_01_05_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あら、栄えある五月女王のお兄様じゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_05_0010002")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:五月女王のこと、まだ気にしてたんだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:もしかしてそれを言うためにわざわざここに来たのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0010004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:違うわよちょっと遊びに来ただけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_05_0010005")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:まぁ、五月女王に選ばれなかったのはちょっとだけ…ほんのちょっとだけ残念だけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_05_0010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:（ちょっとじゃなさそうだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT4_01_05_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:街を挙げての大きなお祭りをみんなが楽しんでくれたみたいでよかったわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_05_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな。初めは戦時中にお祭りなんてって少し戸惑ったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0010009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:みんなでこの平和を守らなきゃって気持ちが強くなった気がするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0010010")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:意義のあるお祭りだったわよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_05_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そうよ平和を守らなきゃ…平和にしなきゃ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_05_0010012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ううん、ごめん。なんでもないの気にしないで
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_05_0010014")


	--★★ノワール★★:あ、ああ…わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0010015")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
