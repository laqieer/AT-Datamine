-- このluaスクリプトは、MA_01B110_42.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-170,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",0,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力

	--★★ガラハッド★★:いま、帰りか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_420003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★ガラハッド★★:オカッパに言いたいことがあるんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420004")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:オカッパ………？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_420005")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:だが、教室が、わ、わからない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420006")


	--★★ガラハッド★★:い…いや、自分で探せばいいじゃんと言われれば<br>それまでなんだが、生徒も多くてだな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B110_420008","MA_01B110_420009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:案内するよ<br>トリスタンの教室だよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_420011")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:そ、そうだ！トリスタンだ！<br>名前も教室もわからないままだった…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420012")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:ガラハッド個人の問題といえば<br>それまでなのだが、まあ、なんというか…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:いっしょに来てくれるのか<br>…ありがとう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420014")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ノワール、お前は良いやつだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:説明するよ<br>オカッパの教室だよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_420017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:た、大変言いにくいのだが…<br>名前も教えてくれ、呼びようがない…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420018")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:トリスタンのことだよな…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_420019")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:そ、そうだ！トリスタンだ！<br>名前も教室もわからないままだった…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420020")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:それと、できることなら<br>連れて行ってくれないか…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_420021")

	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
