-- このluaスクリプトは、AV_01_101012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",320,CharaPos110151_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_007)
	Camera002 = SetTemplate("Actor002",100,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
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
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor004,Actor002)
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さん？それって…<br>寮で飼ってる犬だよね？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0001")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ。手の空いているときに<br>世話してくれって言われてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0002")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:へえ～、そうなんだ<br>兄さんにすごく懐いてるね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:それに<br>兄さんもすごく楽しそう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0004")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そうか？まあ…<br>動物の世話は嫌いじゃないしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0005")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:小さい頃に家で何度か犬や猫を飼ったし<br>傭兵団にいたときは馬の世話もしてたもんね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0006")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Shy")

	--★★ディナタン★★:いいなあ<br>私もその子たちの世話係、やらせてもらおうかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0007")

	open_select_window_tag(Actor001,"Normal","AV_01_101012_0008","AV_01_101012_0009","AV_01_101012_0010")
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

	--★★ノワール★★:止めないけど…<br>そんなに簡単なもんじゃないぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0012")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:言うことを聞いてくれるとはかぎらないし<br>服を汚されることだってある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0013")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:もう、そんなのわかってるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Shy")

	--★★ディナタン★★:小さい頃に飼ってたときは<br>私だっていっしょに世話してたし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:そ、そうだったな<br>ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0016")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも、兄さんの仕事の邪魔はよくないよね<br>今回は諦めることにする
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0017")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それじゃ兄さん<br>仕事がんばってね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いいんじゃないか？<br>俺から話しておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0020")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:本当？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0021")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「ディナタンになら任せられる」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「昔、仔犬を飼いたいって言って拾ってきて<br>母さんにすぐ飽きると止められたけど」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0023")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:「飽きることなんてないって言い張って<br>３日３晩その仔犬から離れなかったくらいだ」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:…って推薦しておく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0025")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:ちょ、ちょっと！<br>余計なことまで言わなくていいからっ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0026")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ、冗談だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0027")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:他のお手伝いもあるから<br>定期的に来るのは難しいけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:たまには<br>この子たちの相手をしてあげようかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、そうしてやってくれ<br>こいつらも喜ぶと思うから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0030")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:せっかくだし<br>自分たちの犬を飼うか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0032")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ディナタンが世話してくれるなら安心だし<br>きっと聞き分けのいい子になる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0033")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:そ、そうかな…！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0034")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:小さい頃に飼った犬や猫も<br>俺よりディナタンに懐いてたろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0035")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:でも、飼うとなるといろいろ準備が必要だよね<br>小屋を建てる場所とか、エサ代とか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうだな<br>頃合いを見て誰かに相談してみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101012_0037")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:うん。焦っても仕方ないし<br>本当にできたらいいな、ってくらいにしておくね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…ありがと、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AV_01_101012_0039")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
