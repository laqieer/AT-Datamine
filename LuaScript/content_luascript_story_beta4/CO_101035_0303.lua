-- このluaスクリプトは、CO_101035_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:ふぅ、到着～ひとやすみしてから始めようか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030002")


	--★★ノワール★★:ところで、今はどんな野菜を育てているんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:ローマでよく育てられているものが多いですね<br>アスパラとかソラマメとか…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030005")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ログレスでもソラマメはよく食べるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030006")


	--★★リリアーナ★★:あとは…トマト！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030007")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ト、トマト…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力

	--★★リリアーナ★★:まだ種を植えたばかりなんですけどこのあたりの土はトマト栽培に向いてるようです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:収穫できたら真っ先にご馳走しますね！<br>美味しいですよ、約束します！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030011")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:あ、ああ…楽しみに、してるよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030012")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ゆくゆくは作物だけじゃなくって<br>羊を飼えたらいいなって考えてるんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030014")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ！羊のミルク、楽しみだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:ローマには羊のミルクで作ったチーズもあるんですよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_03030018","CO_101035_03030019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:羊のミルクで作ったチーズかクセがありそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030021")

-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ちょっと硬めだけどコクがあっておいしいんですよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030022")

	change_face(Actor002,"Smile")

	--★★リリアーナ★★:私は削ったものをパンに乗せてそれを焼いて食べるのが好きです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030023")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ～ちょっと食べたくなったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どんな味なのか、一度食べてみたいなログレスでも手に入るのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:城下町のマーケットでは見かけませんでしたね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030027")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあリリアーナが羊を飼うまでおあずけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:なるべく早く羊を飼えるようにしますねっ！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030029")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナの意外な一面を知れた気がするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030031")


	--★★ノワール★★:畑や家畜のことで迷ったときはリリアーナに聞けば間違いなさそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030032")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:私より、きっともっと詳しい人がいますよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030034")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そうかなぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力

	--★★リリアーナ★★:そうですよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:さ、早く種をまきましょう。マターヤもプンタレッラの収穫を楽しみにしてましたから
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030038")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:プン…なんだって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:プンタレッラ、ですこれもローマでよく食べられている野菜です
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030040")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…野菜のことを話しているときのリリアーナすごく楽しそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030041")

-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:野菜にかぎった話じゃないですけど<br>植物の強い生命力は見る者に元気をくれます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030043")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★リリアーナ★★:太陽に向かってすくすくと背を伸ばす様子土から出て空気をいっぱい吸い込んだときの様子
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030044")


	--★★リリアーナ★★:畑で野菜を見ながら私も頑張らなきゃ、っていつも思ってるんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そっかじゃあ、俺にも教えてほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:野菜との楽しい関わりかたを、さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03030048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:…はいっ！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03030050")

-- ▼直接出力
local trustParam = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
