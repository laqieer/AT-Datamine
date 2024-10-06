-- このluaスクリプトは、PT4_01A_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ラヴェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:おはようございます、ノワール君
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:今日はエレインは一緒じゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0020004")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:エレインなら<br>今は自室でゆっくりしていると思いますよ
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020005")


	--★★ラヴェイン★★:呼んできましょうか？
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ああ、いや<br>そんなつもりで言ったわけじゃないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0020007")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定3")
-- ▲直接出力

	--★★ラヴェイン★★:そうですか？
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:…エレインを気にかけていただいて<br>ありがとうございます
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020009")

	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:エレインは<br>もともとは明るい子だったのですが
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020010")


	--★★ラヴェイン★★:少々面倒なことに<br>巻き込まれてしまったうえに
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラヴェイン★★:ロンディニウムでの一件を<br>間近で見てしまったことが重なり
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "落胆")
-- ▲直接出力

	--★★ラヴェイン★★:今はちょっと塞ぎがちになってしまっています
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:もしよろしければ、ときどき<br>彼女の話し相手になってもらえませんか？
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020014")


	--★★ラヴェイン★★:兄の私には言えないこともあるでしょうから
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:わかった。そのくらいお安い御用だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラヴェイン★★:ありがとうございます<br>今後もよろしくお願いしますね、ノワール君
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_09_0020017")

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
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
