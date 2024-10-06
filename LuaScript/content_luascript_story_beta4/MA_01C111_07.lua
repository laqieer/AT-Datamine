-- このluaスクリプトは、MA_01C111_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",-85,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115080)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:ランスロットは<br>ハロウィンには参加しないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","悩む")
-- ▲直接出力

	--★★ランスロット★★:そうしたい気持ちはやまやまだがな<br>俺には俺のやるべきことがある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ランスロット★★:出発する前に魔女パレードくらいは<br>見ていけるかもしれないが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070004")

-- ▼直接出力
 --PlayPartVoice("ランスロット","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:まぁ、俺のぶんまで楽しんでおいてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:俺とディナタンが留守のあいだ<br>街や学園の復興に並行して
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070006")


	--★★ノワール★★:聖杯探索も進めていたって聞いてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…聖杯、見つかりそうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ。探索隊から出現場所を特定できそうだと<br>連絡があった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:準備が終わりしだい、すぐに発つ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070010")


	--★★ランスロット★★:必ず聖杯を持ち帰ってみせる<br>…アーサーよりも早く
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070011")


	--★★ランスロット★★:そしてお前に聖杯を託す<br>それが師匠の目的でもあり、望みだった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:…わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:聞かないのか？<br>師匠とのこと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070014")

	open_select_window_tag(Actor001,"Normal","MA_01C111_070015","MA_01C111_070016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:帰ったら聞く<br>だから無事に帰ってこいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:ふっ…あぁ、もちろん
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070019")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…お前にはまだ<br>話してないことがたくさんある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:聞いたら教えてくれるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…時期が来たらな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうだろうと思ってた<br>帰ってきたら聞かせてくれよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_070024")

-- ▼直接出力
 --PlayPartVoice("ランスロット","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…すまない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:落ち着いたらゆっくり話そう?
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C111_070027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115080)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
