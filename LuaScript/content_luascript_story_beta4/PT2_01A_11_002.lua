-- このluaスクリプトは、PT2_01A_11_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
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
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力

	--★★エレイン★★:おはようございます、先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020005")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、エレイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:いよいよ明日出発ですね<br>スノードン山への遠征
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:ローマ軍も全兵力を投入してくるはずです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020008")


	--★★エレイン★★:ヴェルナルス将軍たちとの<br>戦いも避けられないでしょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…怖いか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:…はい<br>臆病ですから、私
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:でも、決めたんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020012")


	--★★エレイン★★:勇気を振り絞って<br>先輩とギネヴィアさんのために…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★エレイン★★:いえ、学園やこの国のために戦います<br>ひとりのマスターとして
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:エレイン…ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0020015")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そういえば<br>手紙じゃなくても大丈夫になったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:はい<br>直接伝えなきゃと思ったので…この想いは
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:明日、頑張ろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_11_0020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★エレイン★★:はい！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT2_01A_11_0020019")

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
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
