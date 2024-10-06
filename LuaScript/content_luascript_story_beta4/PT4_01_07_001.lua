-- このluaスクリプトは、PT4_01_07_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
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
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:あっ、ノワール待ってたわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア？俺になにか用か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:ちょっと聞きたいことがあってね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010004")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あのブライアンって人のことなんだけど…大丈夫なの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ブライアンは頑丈さが取り柄だしディナタンが手当てもしてくれたしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:もう話ができるくらいにまで回復してるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010007")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:あー、えっと、傷のことじゃなくて…傷のことじゃなくて、ってのも失礼かしら…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ええい、ストレートに言っちゃうけどカレドニアの人なんでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010009")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:スパイとかだったりしない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010010")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ブライアンがスパイ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ないないウソをつくの、すごく苦手な人だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010012")


	--★★ノワール★★:それにカレドニアの国内の状況を俺たちに教えてくれたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:カレドニアの国内の状況…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010014")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…バルバロイの数が日に日に増え続けてるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010015")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…どうするの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT4_01_07_0010016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:放っておいたら手の付けられない戦力差になってしまうかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:それに国民の安全も心配だよ手遅れになる前になんとかしないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_07_0010018")

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
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
