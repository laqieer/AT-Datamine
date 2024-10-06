-- このluaスクリプトは、CO_101035_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110181_01","110181_01_h")
Include("content_adv_advsmall_110181_01","Template110181_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",130,CharaPos110181_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_005)
	Camera002 = SetTemplate("Actor002",145.7,CharaPos110181_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_003)
	InitializeTemplateRandomCamera110181_01()
	InitializeTemplate110181_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110181)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:何度来ても素敵な音楽室ですねさすがはキャメロット騎士学術院！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010008")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ハープにタンブランに、リュート…<br>コルベニック城にはない楽器ばかりです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010009")

-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:こんなところで演奏できたら<br>きっと気持ちいいんだろうなあ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:リリアーナは音楽が好きなんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010011")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,2,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あっ！い、いいえ！<br>詳しいだなんて、そんな！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:ただ、あの…私、草笛を吹くのが好きなんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リリアーナ★★:だから、その、機会があったらいろんな楽器に触ってみたいなって思ってました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010015")

	open_select_window_tag(Actor001,"Normal","CO_101035_00010016","CO_101035_00010017","CO_101035_00010018")
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
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:草笛かすごく素敵な特技じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:上手に吹けるって羨ましいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010021")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺、前に何度か挑戦してみたんだけどぜんぜんダメでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010022")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:良かったら今度コツを教えてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010023")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:わ、私で良ければ今すぐにでも…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010024")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あ、でも、さすがにここには吹けるような草は生えてないですよね…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:じゃあ今度は近くの草原にでも遊びに行こうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はい！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010027")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よろしくリリアーナ先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010028")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:き、緊張してきちゃいました私、上手に教えられるでしょうか…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:実は俺も音楽に興味があってさ楽器なんて全然できないんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010032")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:そうなんですか？ノワールさん、器用になんでもできそうなのに…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺なんて苦手なことばっかりだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010034")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:そんなことよりさ<br>今度、ふたりでなにか楽器の練習してみないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:頼めばここの楽器を貸してもらえると思うし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010036")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:いいですね、ぜひぜひ！私、管楽器がやってみたいです！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010037")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はなにに挑戦しようかな？悩むな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:次に来るときまでに考えておくことにするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はい！楽しみにしておきますね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010040")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ちょっと意外だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010043")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナは人前に出るのが苦手そうだから音楽とかやらないものかと思ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010044")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:やっぱり私なんかには似合わないですよね…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、ごめん！そんなつもりで言ったわけじゃないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:でもリリアーナはかわいいし楽器を演奏している姿、見てみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_00010047")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:かっ、かわっ！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:ノワールさんがそういうなら今度、挑戦してみようかな…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_00010049")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"リリアーナ")
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
	load_area_scene_preload(110181)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110181_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
