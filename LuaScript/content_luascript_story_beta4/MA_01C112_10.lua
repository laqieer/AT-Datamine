-- このluaスクリプトは、MA_01C112_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115024)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:…ねぇ、兄さん！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100002")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:ん？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:きょ、今日ってすっごく天気がいいよね！<br>風が気持ちよくて、お日さまがぽかぽかで
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100004")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:だから、えっと、その…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100005")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:最近ゆっくり話ができてなかったし<br>こないだガレスに叱られちゃったし
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:…少し散歩しない？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100007")

	open_select_window_tag(Actor002,"Normal","MA_01C112_100008","MA_01C112_100009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:そうだな<br>それもいいかもな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:うん、絶対にそれがいいよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:あーっ！<br>お弁当、作ってくればよかった
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100013")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:大丈夫だよ<br>ハラ、そんなに減ってないから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100014")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:そう？それならいいけど…ごめんね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:謝るのは俺のほうだ<br>ディナタンに心配ばっかりかけて…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100017")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:え？<br>なあに、兄さん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:いや、なんでもない<br>出かけようか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:ごめん<br>今はそんな気分じゃなくて…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100021")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:ほら、その顔！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100022")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:学園に来るまでの兄さんの顔に戻ってる<br>いつもなにかを抱え込んで
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100024")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:いつも寂しそうにしてる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:そ、そんなことは…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100026")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:そんなことあるよ<br>兄さんとずっと一緒にいたからわかる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:こういうときこそ気分転換が大事なんだから<br>さっ、出かけよう、兄さん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_100028")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:お、おい、ディナタン…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C112_100029")

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
	load_area_scene_preload(115024)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
