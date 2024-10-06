-- このluaスクリプトは、CO_101012_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:…やっぱり止めよう、行くの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020004")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:妖精の森に行ってくるって言ったら<br>マァルも嫌そうな顔してたし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020005")


	--★★ディナタン★★:「また迷子になったりすんなよ」って<br>送り出してはくれたけどね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_05020008","CO_101012_05020009","CO_101012_05020010")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:マルディサントは<br>ディナタンを心配してるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん。わかってる<br>マァルは私のこと、すごく思ってくれてる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020013")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:その気持ちは、ちゃんと伝わってるから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:マスターだから？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…ううん。友達だから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あれは迷子だったのか？<br>確かに、ずっと森から出られなかったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…ううん。多分、違う気がする<br>上手くは、言えないけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020019")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:でも、私たちが森にいた時間はきっと<br>意味のある時間だった…って思う
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今思えば、いいところだったのかもな<br>穏やかで、つらいこともなにもなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020022")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:あそこにいた時間も悪くはなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020023")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020024")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…悪い<br>こんなこと、言うべきじゃなかったよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020025")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…いいんじゃないかな。私しか聞いてないし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020026")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それに…実は、私もちょっとだけ<br>同じこと思ってたから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020027")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…あの森で私たち<br>ふたりだけで暮らしてたんだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:こうして近くにいても、まだ感じる<br>微弱だけど…あったかいなにか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020031")


	--★★ディナタン★★:なんで私たちがあそこに飛ばされたのか<br>そして外に出られなかったかはわからないけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020032")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:でもやっぱり…森は<br>私たちを守ってくれてたような気がする
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…そうだな<br>俺もそんな気がしてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020034")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…私ね。ちょっとだけ思うんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:あのまま、森にいれば…<br>守られていればよかったんじゃないかって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020037")


	--★★ディナタン★★:あのまま森を出なければ、<br>なにも知らずにいられたのかなって…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:学園で出来た友達、先生<br>たくさんの人が傷ついて、亡くなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020039")


	--★★ディナタン★★:仲間だった人と、戦うことになって――…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020040")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:…なんでこんなことになっちゃったのかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020041")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020042")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ディナタン★★:…ごめん。駄目だよね、こんなこと思っちゃ<br>みんな、がんばって立ち向かってるのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:あの森に行ってみようと思ったのは<br>気持ちを整理したかったからなの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020044")


	--★★ディナタン★★:受け入れられないこと、たくさんあるけど<br>…でも、前に進まなきゃって思うから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:だから、後ろ向きな気持ちは<br>この森に置いていこうって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_05020048","CO_101012_05020049")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…無理に頑張らなくていい<br>急にいろんなことがありすぎたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020051")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ううん。駄目だよ<br>ここで頑張らなきゃ、いつ頑張るの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020052")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:だって私は継承者のキラーズなんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…言い出したら聞かないのは相変わらずか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020054")

	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃあ、せめて無理だけはするなよ<br>弱音ならいくらでも聞くからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020055")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:えへへ…ありがとう<br>頼っちゃうから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020056")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ<br>一緒に頑張っていこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020058")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:任せて。兄さんの力になれるよう<br>私、精いっぱい頑張るよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020059")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:だって私は兄さんの武器なんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020060")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さんと話してたらなんとかなる気がしてきたよ<br>やっぱり兄さんは頼りになるね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020062")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:当たり前だろ、兄貴なんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05020063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん…そうだね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020064")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:そうだよね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05020065")

-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
