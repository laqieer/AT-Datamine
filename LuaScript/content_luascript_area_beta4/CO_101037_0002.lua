-- このluaスクリプトは、CO_101037_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",135,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera002 = SetTemplate("Actor002",230,CharaPos114031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_004)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:私、実はこの村に来てみたかったんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ノワール★★:アストラット卿になにかキミの興味があるものが？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラシア★★:この村は酪農が有名なんですよ
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へえラシアは牛乳が好きなのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010011")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ラシア★★:牛乳が好きというか…
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:私、ヨーグルト作りが趣味なんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010013")

	change_face(Actor001,"Laugh")

	--★★ラシア★★:だから、いい牛乳があるならそれを材料にヨーグルトを作ってみたいなって
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:ラシアはヨーグルトが作れるのか！すごいな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ラシア★★:そんなことありません簡単に作れますよ
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:そうなのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はい
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","CO_101037_00010019","CO_101037_00010020","CO_101037_00010021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ノワール★★:ヨーグルト以外にも普段から料理をしているのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ラシア★★:得意というわけではないですが…いろいろ作りますよ
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010024")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:ときどきお弁当を作って持ってきたりもしていますし
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:そうなのか今度、ラシアの手料理を食べてみたいなあ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010026")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★ラシア★★:今度、機会があれば…
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★ラシア★★:あっ、でも、期待はしないでくださいね！？趣味でやっているだけですから！
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:搾りたての牛乳って美味いんだよなここの牛乳も飲んでみたいな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ラシア★★:言われてみたら私も飲みたくなってきました…
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010032")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ノワール★★:搾りたてを飲ましてくれる場所探してみようか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:賛成です行ってみましょう
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010034")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:ラシアが作ったヨーグルトかぁ食べてみたいな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:いつでもご馳走しますよ
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010038")

	change_face(Actor001,"Laugh")

	--★★ラシア★★:ノワールにはいつもお世話になっていますし
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010039")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラシア", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:私も機会があったらいつか食べて欲しいなって思ってたんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:楽しみにしちゃっていいか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","CO_101037_00010041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:ええいろんなトッピングも用意しておきますね
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_00010042")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor001,"ラシア")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
