-- このluaスクリプトは、AV_01_101034.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112031_01","112031_01_h")
Include("content_adv_advsmall_112031_01","Template112031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName112031_01,CameraPos112031_01_004)
	InitializeTemplateRandomCamera112031_01()
	InitializeTemplate112031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★エクセリア★★:ノワール…？<br>ここでなにをしているの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:やあ、エクセリア<br>武器や防具の修理の手伝いだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:キミのほうこそどうしてここへ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:コルベニック城で使われている武器や設備は<br>古めのものが多いから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0004")


	--★★エクセリア★★:最新のものを見ておきたいと思って
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0005")


	--★★ノワール★★:軍師としては<br>そういった知識を得ておくことも大事そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0006")


	--★★エクセリア★★:あなたは武器について詳しいのかしら？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ここで働かせてもらってるしな<br>それなりに知識はあるほうだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0008")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:じゃあ、コルベニック城の防備に使うなら<br>どんな武器が適しているかしら？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0009")

	open_select_window_tag(Actor001,"Normal","AV_01_101034_0010","AV_01_101034_0011","AV_01_101034_0012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありきたりかもしれないけれど<br>片手剣はどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0014")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのあたりは森が多いし<br>城内戦も考えると長柄の武器は使いにくい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ちょうどこの前、おかみさんが<br>取り回しのいい片手剣の製造方法を考案してた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:なるほど、いいわね<br>その剣についてもう少し教えてもらえる？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:うっ、ごめん…<br>俺もおかみさんから話を聞いただけなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0018")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そう、わかったわ<br>また日を改めて来てみることにする
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★エクセリア★★:ノワール<br>今日は貴重な情報をどうもありがとう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:汎用性でいったら<br>やっぱり直槍じゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0022")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:斬る、突く、払う、いろんな使いかたができる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:コルベニック城の周りは森が多いの<br>長柄の武器は使いにくいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ、たしかに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:でも、ありがとう<br>あなたの戦士としての意見は参考になったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:今、ここにはないんだけどさ<br>大砲なんてどうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:コルベニック城の少ない兵力で<br>大軍を相手にするなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:圧倒的な火力で吹き飛ばすのが<br>手っ取り早い気がするんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0030")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:…ふふっ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0031")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれっ？<br>俺、変なこと言ったかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0032")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:いいえ<br>とても理に適っていると思うわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★エクセリア★★:すべてにおいて<br>完璧に事が運ぶとは限らないけれどね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0034")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:たしかに…<br>生兵法は大怪我のもと、ってやつだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101034_0035")

	change_face(Actor002,"Smile")

	--★★エクセリア★★:いいえ。大胆でとても素敵なアイデアだと思う<br>参考にさせてもらうわね、ありがとう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AV_01_101034_0036")

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
	load_sequence_area_scene_preload(112031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
