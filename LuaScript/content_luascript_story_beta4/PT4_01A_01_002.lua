-- このluaスクリプトは、PT4_01A_01_002.csvから自動生成されました --
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

	change_face(Actor001,"Surprise")

	--★★ノワール★★:アーサー？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0020002")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力

	--★★アーサー★★:よう。生徒たちの様子を見に来たんだ<br>たまには学長らしいことをしないとな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうか…でも、少しは<br>休んだほうがいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0020004")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:いろいろ整理する時間も必要だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0020005")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:マーリンにも同じことを言われたよ<br>その気遣いはありがたいが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:今はじっと休んでいるよりも<br>少し忙しいくらいのほうがいい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:どうした？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:いや、アーサーの言葉とは思えなくてさ<br>ケイが聞いたら泣いて喜びそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0020010")

-- ▼直接出力
PlayPartVoice("アーサー", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:いや。「またなにか悪いものでも食べたのか」<br>と小言を言ってくるだろう、義兄さんなら
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:確かに。目に浮かぶな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_01_0020012")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:俺はこれまで迷惑をかけっぱなしだった<br>義兄さん、マーリン…そして義姉さん
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★アーサー★★:もう悠長なことを言っていられる時間はない<br>覚悟を決めねばな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:キャメロット騎士学術院の学長として<br>この国の王として
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT4_01A_01_0020015")

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
