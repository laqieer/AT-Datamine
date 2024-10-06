-- このluaスクリプトは、PT4_01A_11_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
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
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれ、マルイルじゃないか<br>珍しいところで会うな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0020002")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:おはようございます、ノワールさん
	Talk(Actor002,"CHRNAME_MARIL","speech","L","PT4_01A_11_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルイル★★:ここの寮生さんから<br>荷物の配達を頼まれまして
	Talk(Actor002,"CHRNAME_MARIL","speech","L","PT4_01A_11_0020004")


	--★★ノワール★★:荷物？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0020005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:はい。先日の学園祭以来<br>生徒さんからの注文が増えてるんですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","PT4_01A_11_0020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:これは新しい商売に繋がるかもしれません…！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","PT4_01A_11_0020007")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さすが<br>商魂たくましいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:学園祭といえば<br>資材の仕入れだったり、屋台の手配だったり
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0020009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:他にアテがなくてまとめて頼んじゃったけど<br>迷惑じゃなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0020010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:迷惑だなんてとんでもない<br>大口の注文は歓迎ですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","PT4_01A_11_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:もし来年も開催されるようでしたら<br>もっと品質のいいものを仕入れてみせます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","PT4_01A_11_0020012")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("マルイル", "喜び")
-- ▲直接出力

	--★★マルイル★★:ぜひともご贔屓に！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","PT4_01A_11_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ<br>こちらこそお願いするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0020014")

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
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
