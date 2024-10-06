-- このluaスクリプトは、CO_101034_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_03","110071_03_h")
Include("content_adv_advsmall_110071_03","Template110071_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_003)
	InitializeTemplateRandomCamera110071_03()
	InitializeTemplate110071_03()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor002,{3.7,0.13,18.5})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:図鑑を見るなら大図書院のほうが落ち着けるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力

	--★★エクセリア★★:実物と見比べたくて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、なるほどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030004")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
lookat_weight(Actor001,0.6,0.03,0.7,0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,160,0.5)
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:少し前に木こりの男性を村まで送ったことがあったでしょう？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030006")


	--★★エクセリア★★:あのとき通った道の近くにたくさんの花が咲いていたのよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030007")


	--★★エクセリア★★:私が花を見つめていたら木こりの方が色々教えてくれてね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:森で暮らしてるとそういう知識が増えていくんだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:きっとそう。あの人のおかげで初歩的なミスを犯さずに済んだわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030010")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:…と言うと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★エクセリア★★:花の品種によって植えるのに適した季節があるんですって
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030012")


	--★★エクセリア★★:それから、植えかたにもコツがあって
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030013")


	--★★エクセリア★★:ただ土に穴を掘って埋めるのではなく先に水で湿らせておくといいらしいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030014")


	--★★エクセリア★★:この花壇の花も最適な環境を整えられているのね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_04030017","CO_101034_04030018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ、感心するなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そうね素晴らしい知識よね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030021")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:それだけじゃなくて、覚えたことをすぐに実践してみるエクセリアの姿勢にもさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030022")

	change_face(Actor002,"Surprise")

	--★★エクセリア★★:そうかしら？いつも普通にやっていることよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030023")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それがすごいんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030024")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:ふふ、ありがとう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:種によっては光に当てないと芽が出ないのもあるらしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030027")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だから蒔いたあとすぐに土をかけないほうがいい種もあるんだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030028")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:それは初耳だわ！忘れないようにしないと…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030029")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:ああっ！？メモ帳を教室に置き忘れてきてしまったわ…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あたらしく知ったことは全部メモ帳に書き記しているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:ええいつでも見返せるようにね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030033")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:花は育てる以外にも面白いことがあるのよノワールは『花言葉』って聞いたことある？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030035")


	--★★エクセリア★★:花の種類に意味を持たせているんですって
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030036")


	--★★エクセリア★★:大図書院で花言葉の本も借りてきたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030038")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ずいぶんとのめり込んできているじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:ひょっとして…これがリフレッシュしている、ということかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そうかもしれないな発見おめでとう、エクセリア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_04030043")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:ありがとう、ノワール
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_04030044")

-- ▼直接出力
local trustParam = set_communication_rankup("エクセリア_コミュランク", "エクセリア_親密度")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
