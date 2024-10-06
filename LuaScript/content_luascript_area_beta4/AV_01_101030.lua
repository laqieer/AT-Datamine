-- このluaスクリプトは、AV_01_101030.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	Camera002 = SetTemplate("Actor002",145,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:エレイン、今日はひとりか？<br>珍しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0001")


	--★★エレイン★★:ひとりでも出歩けるようにならなくちゃと思って<br>来てみたんですけど…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★エレイン★★:まさか先輩がいるだなんて<br>驚きました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0003")


	--★★エレイン★★:（でも…今はすごく安心もしてます）
	Talk(Actor002,"CHRNAME_ELAINE","mind","L","AV_01_101030_0004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0005")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:い、いえっ！<br>なんでもありません…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0006")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうか？さて、それじゃ…<br>お客様、ご注文はいかがなさいますか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0007")

-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:ふふっ<br>先輩、本当の店員さんみたいですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0008")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…あっ、そうだ！私もここで働いたら<br>人と話すのが怖くなくなるでしょうか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0009")

	open_select_window_tag(Actor001,"Normal","AV_01_101030_0010","AV_01_101030_0011","AV_01_101030_0012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いいんじゃないか？<br>オススメだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:この店のまかないは美味しいし<br>なにより量が多い！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0015")

	change_face(Actor002,"Surprise")

	--★★エレイン★★:あの…先輩？<br>なにか誤解されてませんか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★エレイン★★:私は人と話す練習がしたいわけで…<br>ご飯がたくさん食べたいわけでは…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:食べないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0018")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★エレイン★★:食べたいです！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0019")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:もう…<br>意地悪なんですから…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:人と上手に話せるようになりたいなら<br>たくさんの人と話してみるのがいちばんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:この店で働くのは<br>すごく良い案だと思うな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0024")

-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:先輩がそう言ってくれるなら<br>余計にできそうな気がしてきました！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0025")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:買い被りすぎだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0026")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Smile")

	--★★エレイン★★:そんなことありません…！<br>先輩の言葉はいつも私に勇気をくれます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よし。思い立ったが吉日っていうしな<br>マスターに話してくるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0028")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:ちょ、ちょちょ、ちょっと待ってください…<br>まだ勇気がじゅうぶんじゃないので、また今度…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん、そうか？<br>（俺の言葉…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0030")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やめたほうがいいんじゃないかな<br>エレインには難しそうな気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0033")

	change_face(Actor002,"Sad")

	--★★エレイン★★:…で、ですよね<br>私なんかじゃ、無理、ですよね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0034")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、いや！<br>そうじゃなくて…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0035")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いきなりこんな大きな店のフロアは大変だから<br>もう少し小さな店から始めるのはどうかなって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101030_0036")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:はい…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","AV_01_101030_0037")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（落ち込ませちゃったな…<br>もう少し言いかたを考えるべきだった）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101030_0038")

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
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
