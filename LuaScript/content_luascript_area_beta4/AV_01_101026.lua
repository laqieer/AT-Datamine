-- このluaスクリプトは、AV_01_101026.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",320,CharaPos110151_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_007)
	Camera002 = SetTemplate("Actor002",100,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
	Actor003 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_002, "Dog_Care_loop", "Normal")
	Actor004 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_003, "Dog_Tailwag_loop", "Normal")
	Actor005 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_001, "Dog_Sleep_loop", "Normal")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor004,Actor002)
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:なにをやっているんだ、キミは？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0001")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★パーシヴァル★★:どきたまえ、通行の邪魔だよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:悪い<br>今、手伝いで犬の世話をしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0003")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:ああ…ここで飼っている犬か
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:それにしても動物の世話だなんて<br>物好きなものだね、キミも
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0005")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうか？<br>けっこう楽しいぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0006")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:へえ、それならぼくの愛馬の<br>世話もさせてあげようか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0007")

	open_select_window_tag(Actor001,"Normal","AV_01_101026_0008","AV_01_101026_0009","AV_01_101026_0010")
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
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:任せてくれ<br>お安い御用だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0012")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:へ…？<br>キミ、本気で言っているのかい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、馬の世話なら経験がある<br>それに動物は好きだからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0014")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ぼ、ぼくだって動物は好きだ！<br>いや、むしろ動物がぼくを好きだぞ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0015")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:貴族のたしなみのひとつとして<br>ぼくは動物の気持ちがわかる訓練を積んでいるし
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それはすごいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0017")

	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:キミってさ<br>………いや、なんでもない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:やっぱりぼくの愛馬の世話はいい<br>気持ちだけ受け取っておこう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0019")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうか？<br>世話役が必要になったら、いつでも言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0020")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:…キミの馬の世話の腕が確かだと<br>わかったらね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どうしようかな<br>今はこいつらの世話もあるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0023")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:やりたくないなら<br>ハッキリそう言えばいいだろう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0024")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:違うよ。馬は敏感な動物だ<br>やるならキチンと世話をしたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0025")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それにパーシヴァルが大切にしてる馬なんだろ？<br>なら中途半端な気持ちでやるわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:殊勝な心掛けじゃないか<br>それなら…ん、待てよ？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0027")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:ぼくの愛馬が名馬中の名馬だと知っているな？<br>庶民には手の届かない存在だから奪おうと！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0028")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:なんて卑劣な！ダメだダメだ！<br>キミにぼくの愛馬の世話なんてさせるものか！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0029")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:べ、別にいいけどさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0030")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:嫌だ<br>大変そうだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0032")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:な…！<br>ぼくの馬の世話が大変だって！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:当然だろう、ぼくの愛馬だぞ！？<br>そんな簡単に済まされてたまるものか！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だったら俺なんかより、ちゃんとした人に<br>世話してもらうほうがいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101026_0035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:…確かにそうだな<br>まっとうな意見を言うじゃないか、庶民なのに
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","AV_01_101026_0036")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（本当に疲れるな、パーシヴァルの相手は…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101026_0037")

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
	set_chara_preload("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_002, "Dog_Care_loop", "Normal")
	set_chara_preload("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_003, "Dog_Tailwag_loop", "Normal")
	set_chara_preload("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", CharaPos110151_01_001, "Dog_Sleep_loop", "Normal")
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
