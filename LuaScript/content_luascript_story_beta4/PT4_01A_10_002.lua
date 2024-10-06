-- このluaスクリプトは、PT4_01A_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
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
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力

	--★★ラヴェイン★★:ここにいたんですか、ノワール君<br>さがしていたんです
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:やあ、ラヴェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラヴェイン★★:先日、エレインと子供たちを<br>ロンディニウムに連れて行ってくれたそうですね
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラヴェイン★★:みんな喜んでくれていました<br>ありがとうございます
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、そのことか<br>俺は大したことはしてないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:お膳立てしてくれたのはガウェインだからさ<br>お礼ならガウェインに言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0020007")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:そうでしたか<br>では、このあと彼にも伝えてきます
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あのさ。ラヴェインは<br>ロンディニウムに頻繁に行ってるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0020009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:どうなんだ？<br>復興活動は進んでるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0020010")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラヴェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:少しずつ、といったところでしょうか
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラヴェイン★★:ロンディニウムの人々の<br>心の傷が完治するにはまだ時間がかかるでしょう
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020012")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:ですが、ひとり、またひとりと
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:もとの生活を取り戻すために<br>立ち上がってくれています
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020014")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラヴェイン★★:私たちの想いを受け止め<br>目を見て話してくださる人も増えてきました
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そうか<br>さすがだな、ラヴェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺も時間があれば手伝うよ<br>今度行くときは声をかけて欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0020017")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラヴェイン★★:ええ<br>ありがとうございます
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","PT4_01A_10_0020018")

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
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
