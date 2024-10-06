-- このluaスクリプトは、PT2_01C_09_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:おはよう、ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01C_09_0010002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:おはよう、アーサー<br>また仕事を抜け出してきたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:まあ、そんなところだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01C_09_0010004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:またケイやマーリンさんにどやされるぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0010005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "落胆")
-- ▲直接出力

	--★★アーサー★★:そんなことはどうでもいい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01C_09_0010006")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0010007")

-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:なあ、ノワール<br>お前は学園生活を謳歌できているか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01C_09_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:ディナタンとＧＳできたことを<br>心から喜べているか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01C_09_0010009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あ、ああ…うん<br>学園生活は楽しめてるし、ＧＳの達成感もある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:そうか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01C_09_0010011")


	--★★アーサー★★:ならば<br>残りの学園生活も悔いのないように過ごしてくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01C_09_0010012")


	--★★ノワール★★:…アーサー？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0010013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
