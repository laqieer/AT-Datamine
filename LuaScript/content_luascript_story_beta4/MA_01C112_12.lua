-- このluaスクリプトは、MA_01C112_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_02","110011_02_h")
Include("content_adv_advsmall_110011_02","Template110011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_006)
	InitializeTemplateRandomCamera110011_02()
	InitializeTemplate110011_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Sad")

	--★★フレン★★:あのっ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:ありがとう。ローラを、ルーシャスくんを…<br>…みんなを、助けてくれて！
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:ありがとうございます…！
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C112_120006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:あぁ…いいよ、そんなの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120007")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:よくないよ！　
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120008")

-- ▼直接出力
 --PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ルーシャスくん、どうせ<br>ちゃんとお礼を言ってないでしょ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C112_120010","MA_01C112_120011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そういえば、確かに言われてないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★フレン★★:やっぱり！
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("フレン", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:そういうの、ほんとよくないの！<br>あとで言っておくから
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ルーシャスにそんなこと言えるの<br>フレンくらいだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、別に気にしてないよ<br>そんなこというヤツじゃないってわかってるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120018")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:もーっ、そうだと思った…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:なんかローマの人たちって<br>ちょっとエラそうなところあるけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★フレン★★:この国で暮らすんだったら<br>この国の流儀を覚えてもらわないとだよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120021")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:郷に入ればゴーイングマイウェイっていうでしょ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120022")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ローラ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ローラ★★:言わないよ<br>ローマでも、この国でも…
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120023")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それより、ローラのほうこそ<br>体の調子はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ローラ★★:だいぶよくなりました<br>みなさんのおかげです
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120026")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ローラ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ローラ★★:けど、ヴェルナルス先生が…
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120027")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ヴェルナルス先生…<br>あのあと倒れたってきいたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120028")


	--★★ノワール★★:まだ意識は戻らないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:ええ…<br>ヴェルナルス様、あんなに深手を負っていたなんて
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C112_120031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ローラ★★:…私がカレドニア城を抜け出して<br>しばらくしてから魔女は追手を放ったみたいで
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120032")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★ローラ★★:私はなんとか隠れるように進んでいたんだけど<br>やっぱり見つかってしまったの
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120033")


	--★★ローラ★★:そのときヴェルナルス様が駆け付けて<br>追手を相手してくれた
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ローラ★★:「自分が道を作るから逃げろ」<br>「ルーシャス様の危機を伝えてくれ」って…
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120035")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ローラ", "落胆")
-- ▲直接出力

	--★★ローラ★★:あの傷はきっと、そのときに…
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01C112_120036")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力

	--★★ラシア★★:ヴェルナルス様…
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C112_120037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:…わかってるよ。魔女と組もうとした<br>ルーシャスくんがよくなかったんだって
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120039")

	PlayAction(Actor002,"to  Std_No")

	--★★フレン★★:でも、だけど…やっぱ悔しいよ<br>なんで魔女は、いきなり…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120040")

-- ▼直接出力
 --PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:…私も、許せない<br>魔女もバルバロイも…アーサーも
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120041")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラシア★★:このままじゃ終わらせません<br>ヴェルナルス様が受けた傷の報いを受けさせます
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C112_120042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:フレン…ラシア…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_120043")

	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:ノワールくん<br>これからは私たちも君と一緒に戦うよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:何度負けても絶対に諦めない<br>意地でも勝ってみせるから
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フレン★★:よろしくね<br>ルーシャスくんともども<br>?
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C112_120046")

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
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
