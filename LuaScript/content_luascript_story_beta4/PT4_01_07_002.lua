-- このluaスクリプトは、PT4_01_07_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
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
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力

	--★★ラシア★★:あ、ノワールおはようございます
	Talk(Actor002,"CHRNAME_RASIA","speech","L","PT4_01_07_0020002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ラシア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:そういえばラシアってローマの生まれだったよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0020004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はいそうですけど…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","PT4_01_07_0020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ちょっと前にロンディニウムに行ったときローマの人の姿が多くて驚いたんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ラシアみたいにローマからこの島に来る人って多いのかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0020007")


	--★★ラシア★★:この島にというか、他の国に旅行したり移住したりする人の話はよく聞きます
	Talk(Actor002,"CHRNAME_RASIA","speech","L","PT4_01_07_0020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:国風なんでしょうか他の国の文化に興味を抱く方が多いです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","PT4_01_07_0020009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:他の国の文化を持ち帰ったり逆に他の国にローマの文化を伝えたりだとか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","PT4_01_07_0020010")

	change_face(Actor002,"Normal")

	--★★ラシア★★:私は学園に入学するためにこの島に来たんですけどね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","PT4_01_07_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほど、納得だ皇太子自ら留学に来るくらいだもんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0020012")

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
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
