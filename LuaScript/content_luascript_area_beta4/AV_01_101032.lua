-- このluaスクリプトは、AV_01_101032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	Camera002 = SetTemplate("Actor002",145,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Laugh")

	--★★ガレス★★:あれれ～？ノワールじゃないか<br>こんなところでなにしてるんだ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0001")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:やあ、ガレス<br>手伝いでフロアの仕事をしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0002")


	--★★ノワール★★:ガレスはよくこの店に来るのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:ときどきな～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0004")


	--★★ガレス★★:マスターはいろんな国の料理に詳しいから<br>教えてもらったりしてるんだ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0005")


	--★★ノワール★★:確かにここのメニューには<br>他の店にはない食べ物もたくさんあるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0006")


	--★★ノワール★★:まかないついでに<br>いろいろご馳走になったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0007")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定3")
-- ▲直接出力

	--★★ガレス★★:へえ～<br>気に入ったものはあるのか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0008")

	open_select_window_tag(Actor001,"Normal","AV_01_101032_0009","AV_01_101032_0010","AV_01_101032_0011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:カヌレかな<br>あんなお菓子は初めて食べたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0013")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:外側はカリっとしてるんだけど<br>中はしっとり柔らかくて美味しかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0014")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:わかるわかる♪<br>一度食べたらやみつきになるんだよな～
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0015")

	change_face(Actor002,"Smile")

	--★★ガレス★★:見た目も小さくてかわいいしな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0016")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★ガレス★★:あーっ、話してたら食べたくなってきた！<br>帰ったらさっそく作ろうかな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガレス、作れるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:おう、作れるぞ～♪<br>あとでノワールの分も作ってやろうか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ほんとか？ありがとう<br>楽しみにしてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:カエルの姿焼きかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0022")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:えっ、カエルの姿焼き！？<br>カエルを食べるのか！？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0023")

	change_face(Actor002,"Laugh")

	--★★ガレス★★:しかも姿焼きってことは<br>そのままジュ～ジュ～やるんだよな！？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ。最初はその見た目に最初は驚いたけど<br>想像以上の美味しさだった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0025")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:へえ～♪<br>どんな味なんだ？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0026")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:鶏肉に近いんだけど、それよりもアッサリしてて<br>いくらでも食べられそうな感じがしたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガレス★★:鶏肉に近いのか。レシピが浮かびそうだ♪<br>ちょっとマスターにも聞いてくる！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ゆで卵…かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0030")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:へっ？ゆで卵…？<br>ゆで卵が気になる料理なのか…？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0031")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:ゆで卵なら学園の食堂でも<br>何度も出してるけど…食べたことなかったか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0032")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:もちろんあるけど、マスターが作ってくれたのは<br>中の卵がトロトロのヤツでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101032_0033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガレス★★:ああ、半熟卵か～<br>食堂じゃ固ゆででしか出してないもんな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0034")

	change_face(Actor002,"Normal")

	--★★ガレス★★:…ふーむ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:よし、今度から食堂でも<br>半熟と固ゆで、２種類のゆで卵を出そう！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0036")

	change_face(Actor002,"Laugh")

	--★★ガレス★★:ノワール<br>新メニューのアイデア、ありがとうな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AV_01_101032_0037")

	goto Block1end

::Block1end::
-- ▼直接出力
local commu = system.GetCommu() -- 実行中コミュ
local commuChara = commu.GetCharacter()
kizuna_gaugeup_encount(Actor002,commuChara.CharaName)
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
	load_sequence_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
