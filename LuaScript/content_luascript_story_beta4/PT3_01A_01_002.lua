-- このluaスクリプトは、PT3_01A_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("エレイン","挨拶")
-- ▲直接出力

	--★★エレイン★★:先輩！<br>ディナタンから忘れ物を預かってきました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT3_01A_01_0020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？ああ、今日の授業で使うやつか<br>すっかり忘れてた、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、エレインとディナタンって<br>なかなか珍しい組み合わせだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0020005")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:先輩、知らないんですか？<br>私とディナタン、クラスメイトなんですよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT3_01A_01_0020006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ！？<br>あ、そ、そうだっけ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:今日は療養院まで薬をもらいに行ったときに<br>話したんですけどね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT3_01A_01_0020008")

-- ▼直接出力
PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、なるほどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0020009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:そのときに<br>今さらながらですけど思いました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT3_01A_01_0020010")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★エレイン★★:モルガン先生のいない療養院って<br>すごく寂しい場所と感じてしまいますね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT3_01A_01_0020011")

-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:私、モルガン先生のことが大好きでした<br>いつも元気をくれて、すごく優しくて…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT3_01A_01_0020013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:最期まで優しい…<br>いや、優しすぎる人だった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0020014")

	change_face(Actor001,"Serious")

	--★★ノワール★★:そんな先生が遺してくれたもの、想い…<br>裏切るわけにはいかないよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン","挨拶")
-- ▲直接出力

	--★★エレイン★★:はい<br>勝ちましょう。ローマにも、バルバロイにも
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","PT3_01A_01_0020016")

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
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
