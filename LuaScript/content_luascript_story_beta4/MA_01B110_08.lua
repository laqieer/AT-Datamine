-- このluaスクリプトは、MA_01B110_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
load_image("10303002", "content_still_10303002_image", "103030020_StillImage")
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115030)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:オトコと見込んで任せていいか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080002")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:俺たちも二手に分かれよう<br>『果てなき森』と『滅びた都』へそれぞれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B110_080005","MA_01B110_080006","MA_01B110_080007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:戦力的にはそれが妥当か<br>俺たちが片方に集中するよりは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080009")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:弟弟子が無茶しないかは心配だがな<br>フィエナまで守ってもらわなければならない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:兄弟子の社交性が心配だよ、俺は<br>彼らと仲良くやれるかどうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:たしかに<br>それは俺自身も心配だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:少し不安だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:きっと大丈夫さ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:根拠は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080018")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:実績と信頼
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺がいなくて大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080021")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:そんな言葉が出てくるとは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080022")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:き、キラーズとマスターとしてだよ<br>互いの距離が離れて問題は生じないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:一時的に離れたところで問題はないだろうな<br>長期に渡った場合は──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:わからない？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:どちらかが<br>死んでいるときだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080026")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:銀卓騎士のキラーズと刃を交えて<br>わかったことがある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080028")


	--★★ランスロット★★:彼女らの剣は<br>俺たちによく似ている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080030")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺たち…？<br>俺や、ランスロットの剣技にか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080032")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
setup_small_camera_start(Camera001)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10303002", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:剣筋が重なり、決定打が通らない<br>あれはまるで──
	Talk(Actor002,"CHRNAME_LANCELOT","simple","N","MA_01B110_080033")

	open_select_window_tag(Actor001,"Normal","MA_01B110_080034","MA_01B110_080035")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロット<br>銀卓騎士団の連中と面識はあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:いや<br>先日コルベニック城に訪れたときが初対面だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080039")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それなのによく似た剣技を使う？<br>どういうことなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080040")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたの剣技なんて<br>そうカンタンに模倣できるものじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080042")

-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:お前は昔から<br>うまく真似てくれていたがな？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080043")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いい手本が目の前にあったからだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080044")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:模倣できるとすればそれは…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080045")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:…まさか、な
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080047")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:杞憂であればそれに越したことはない<br>だが、気をつけろ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080049")


	--★★ランスロット★★:未熟な兵では相手にすらならないだろう<br>奴らには少数精鋭という言葉すら勿体ない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:つまり銀卓騎士の数だけ<br>『最強騎士』を相手にしているようなものか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_080051")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:更にバルバロイの侵蝕も進んでいると見える<br>止められるのは俺たちだけだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:まるで鏡映しの剣を
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_080054")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10303002", "content_still_10303002_image", "103030020_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115030)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
