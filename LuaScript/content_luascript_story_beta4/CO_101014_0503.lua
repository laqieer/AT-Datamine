-- このluaスクリプトは、CO_101014_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_002)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:単刀直入に聞くけれど…お前はトリスタンのことをどう思っているの？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030002")

	open_select_window_tag(Actor001,"Normal","CO_101014_05030004","CO_101014_05030005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:好きだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0045")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:ふぅん？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030009")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:口を開けばイヤミばっかりだしキツイこともしょっちゅう言ってくるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:面倒見はいいし、志願して支援活動なんてそうそうできることじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:あいつは優しくて、親切なヤツだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:そう
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:嫌いだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030015")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0045")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:トリスタンのキラーズである私を前に正直にそう口にする度胸だけは褒めてあげるわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030017")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じょ、冗談だよ。ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030018")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:最近妙に付き纏われて困っているらしいの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030020")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？誰が誰に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Finger")

	--★★イゾルデ★★:トリスタンが、お前に
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030022")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:俺？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030024")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:違うの？ことあるごとに話しかけてくるって言っていたけれど
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030025")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、まあ…話しかけてはいるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030026")


	--★★イゾルデ★★:なぜ？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:え？なぜって言われても…仲間だし、仲良くなりたいから。普通だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:そうね、普通ねいたって。紛れもなく
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:俺、なんか変なこと言ってるかな…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030031")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力

	--★★ノワール★★:最初はさ。トリスタンって他人と関わりたくない面倒なヤツかなって思ってたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030032")


	--★★ノワール★★:一緒にいるうちにそうじゃないなって気付いた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030033")


	--★★ノワール★★:なぜかはわからないけどあいつはわざと他人を遠ざけてるように思える
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:これは、思った以上ねお前の慧眼に敬意を表するわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030036")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ありがとう…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030038")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:お前の言うとおり――トリスタンは誰よりも優しい心の持ち主よ。ただ…
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ただ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030040")

-- ▼直接出力
PlayPartVoice("イゾルデ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:他者に頼ったり歩み寄ったりすることは彼にはとても難しいことなの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030041")

	PlayAction(Actor002,"to  Std_Talk")

	--★★イゾルデ★★:心の奥底ではそうしたいと望んでいるのに一歩を踏み出すことができないでいるのよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030043")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:過去になにかあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030044")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:さあ？でも…そうね諦めの悪いお前であれば
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:閉ざしてしまった彼の心の扉を開くことができるかもしれないわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030046")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:イゾルデ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_05030048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★イゾルデ★★:ほんの少しだけ期待しておくわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:…話はそれだけもう行っていいわよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","CO_101014_05030050")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ5_4")
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
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
