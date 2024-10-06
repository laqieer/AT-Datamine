-- このluaスクリプトは、MA_01B109_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:さあ、のっぴきならなくなったな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070002")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:なにか俺に言うことがあるんじゃないのか<br>アーサー
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:そういう持って回った言い回しがムカつく♪
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ランスロット★★:…「なぜ継承者の手を取ったのか」とか<br>「王の世話はどうするのか」とか、あるだろう
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070007")

	change_face(Actor002,"Normal")

	--★★アーサー★★:差し伸べられた手を払えたか？<br>ランス
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ランスロット★★:………いいや
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070010")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:最強騎士も忙しいな<br>弟弟子の劒でありながら王の尻ぬぐいとは
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:俺は俺が死ぬまでノワールに連れ添う<br>その道を選んだ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070012")

	change_face(Actor001,"Sad")

	--★★ランスロット★★:だが…
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ランスロット★★:だからこそアーサー<br>お前との誓いを果たさねばならない
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:なにがあろうと、必ず
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070015")

-- ▼直接出力
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:…つんのめるように生きようとする<br>お前の気持ちはわかるよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070016")

	PlayAction(Actor002,"to  Std_No")

	--★★アーサー★★:どれだけ誇り高く戦い続けようと<br>奪ったものは還らない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070017")


	--★★アーサー★★:これから彼に背負わせるものも<br>戦果や剣では軽くし得ない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:だから死地を探す
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070019")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ランスロット★★:…アーサー<br>俺はそこまで感傷的に見えるか
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:おセンチ野郎
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070022")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ランスロット★★:これは喧嘩だな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:不敬であるぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B109_070026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:8年前から<br>…死ぬまでずっとな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_070028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
