-- このluaスクリプトは、PT3_01_04_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:おはよう、ノワール<br>学生生活にはもう慣れた？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いやあ…戸惑うことだらけだよ<br>学校なんて通ったことなかったしさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:まあ、そうよねえ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020005")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:なにかあったら<br>いつでもわたしを頼っていいわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020006")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:授業でわからないことがあったときなんかも<br>わたしが教えたげるわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、じゃあ<br>このあいだの史学の問題なんだけどさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0020008")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:えっ、本当にあるの！？<br>社交辞令のつもりだったんだけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0020010")


	--★★ギネヴィア★★:あーっ！<br>そういえば、用事があったんだったわ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020011")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:教えてあげたいのはヤマヤマなんだけど<br>わたしはこれで失礼させてもらうわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力

	--★★ギネヴィア★★:残念！ほんと残念！<br>用事なんてなければなー！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01_04_0020013")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…逃げたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0020014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
