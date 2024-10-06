-- このluaスクリプトは、PT6_01B_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…よく食べるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_10_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:姉上のためにも<br>ガラハッドは頑張らなくてはならない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:頑張るためには<br>エネルギーを蓄えておかなくてはならない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010009")


	--★★ノワール★★:そ、そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_10_0010010")


	--★★ガラハッド★★:ところで…ノワールもコルベニック城の近くで<br>暮らしていたんだったな？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ<br>もうずいぶん前のことだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_10_0010012")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:前に来たときから気になっていたのだが<br>この国の料理は味が濃くないか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010013")

	open_select_window_tag(Actor001,"Normal","PT6_01B_10_0010014","PT6_01B_10_0010015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:言われてみれば<br>あのあたりの料理に比べると味付けが濃いかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_10_0010017")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:マターヤなんかは<br>こういった味が好みなんだろうな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:でも、味が濃い食べ物のほうが<br>エネルギーになりやすいとも聞く
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…？<br>俺は特にそうは思わないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_10_0010021")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:薄味だから不味いわけではないし<br>コルベニックの料理と違う美味しさがあるのだが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010022")

-- ▼直接出力
PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ガラハッドがまだ慣れていないだけか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:とにかく<br>今はたくさん食べておかないと
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT6_01B_10_0010025")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:よくわからないけど…ほどほどにな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01B_10_0010026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
