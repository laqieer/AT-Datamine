-- このluaスクリプトは、CO_101032_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	Camera003 = SetTemplate("Actor003",150,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:兄さんのための<br>スペシャルメニューのことだけど
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020002")


	--★★ガレス★★:オードブルとスープ<br>それに魚料理までは決まった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:いよいよメインディッシュを<br>考えなきゃと思っているんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020004")

	open_select_window_tag(Actor001,"Normal","CO_101032_08020006","CO_101032_08020007","CO_101032_08020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ナイトカジキのグリルが<br>メインディッシュじゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:それも大事なメニューなんだけど<br>もうひとつ兄さんに食べさせたいものがあるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020011")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェインに食べさせたいもの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:メインディッシュを決めるのか<br>いよいよ大詰めだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:うん<br>わたしもなんだか緊張してきた
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なににするかは<br>イメージはあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020016")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ずっと前から<br>兄さんに食べさせたいと思ってたものがあるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:デザートはどうするんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020019")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Surprise")

	--★★ガレス★★:デザー…ト…？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020020")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:メインディッシュのあとは<br>デザートが出てくるだろう、普通
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020021")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:あ、あはは
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020023")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガレス★★:メインディッシュを決めるのが先だぞノワール！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020024")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（考えてなかったのか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101032_08020025")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:前に話したと思うんだけど兄さんは生まれてすぐに家を出された
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020027")


	--★★ガレス★★:だから、母さんの料理を知らない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020028")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:そこで、母さんの得意料理だったミートパイを作ってあげようと思うんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:うおおー！ミートパイってことは肉料理だな！肉！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_08020030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:肉もバターもたーっぷりだ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020031")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:食べたことない兄さんにとってはピンと来ない味かもしれないけど
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020033")


	--★★ガレス★★:ミートパイを食べながら教えてあげたいんだ母さんのこと、他の家族のことを
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_08020036","CO_101032_08020037")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ガレスとガウェインのお母さんの得意料理かすごく良いと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020039")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ガウェインもきっと喜ぶよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020040")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:そうだろう！ノワールもそう思うだろう！？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020041")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ミートパイ？美味しいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020043")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:美味しいぞ！わたしも大好きだった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:ガレスが大好物だったのならきっとあたしの口にも合うに違いないぞ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_08020045")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★ガレス★★:レシピは控えてあるから材料さえあれば作れるはず
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020047")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:ただ、材料のひとつがちょっと手に入りにくいものなんだよ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020048")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんていう食材だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:わたしたちの故郷、オークニーでだけ<br>飼育されている『アーキペラゴ牛』の肉なんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020050")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:オークニーか、遠いな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:うん歩いていくには大変な距離だし
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020053")

-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:島の東側だから、転移で行くとしても敵の目を常に気を付けなきゃならない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレスとガウェインのためだ危険だとしても、行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020056")


	--★★ノワール★★:なにがあっても俺がガレスとリオネスを守ってみせる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")

	--★★ノワール★★:継承者の名に懸けて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020058")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:そう言ってくれると思ってたぞ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020059")


	--★★ガレス★★:でも、心配いらないぞわたしだって円卓の騎士・六ノ座なんだからな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_08020060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:そのキラーズもいるしな！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_08020061")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ただ、今日はもう時間が遅い出かけるのは次回にしよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020063")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:各自、準備を怠らないようにな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_08020064")

	open_cutin(2,1)
	on_cutin(1,Actor003,"Smile")
	on_cutin(2,Actor002,"Smile")

	--★★ガレス/リオネス★★:おーっ！
	Talk(Actor005,"CHRNAME_GARETH_LYONESS","speech","N","CO_101032_08020065")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
