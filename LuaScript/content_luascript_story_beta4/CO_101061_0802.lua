-- このluaスクリプトは、CO_101061_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
prop001 = setup_prop_object(10103005)
set_pos(prop001 , {3.363,0.814,10.385})
prop002 = setup_prop_object(10103005)
set_pos(prop002 , {2.959,0.814,10.385})
-- ▲直接出力
-- ▼直接出力
SetOffset(Actor002,0,-0.1,0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Anger")

	--★★ラロゥ★★:このページに書かれてる文字なんだけどさ<br>どの資料にも載ってないんだよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020002")

-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:ん？<br>あれっ？？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:これって、ひょっとして…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020004")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:古文書をひっくり返して<br>どうするつもりだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020005")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:資料と見比べてみてわかった<br>これ、全部が鏡文字になってるんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:はぁ、なんでこんな<br>メンドクサイことするのかね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020007")

	open_select_window_tag(Actor001,"Normal","CO_101061_08020009","CO_101061_08020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯の秘密を隠し<br>誰にもわからないようにするため？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:フツーに考えたらそうだよね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020013")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:でも、わざわざ秘密にしたがるってことは<br>この古文書の記述、信ぴょう性が高いのかもね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:よく気づいたな、こんな仕掛け
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020016")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ちょっと前にノワールに追加で借りてきてって<br>お願いした本があったでしょ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:あれにこういう仕掛けのことが<br>書いてあったんだよね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020018")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お前、本気で学園で勉強したら<br>考古学者にでもなれるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:オレがなれるくらいなら<br>学者ってのは大したことないんだね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020020")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで、なんて書いてあるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:なにか儀式の手順が書いてある<br>祝詞の中身とかどうでもいいことが多いけど…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラロゥ★★:途中で聖杯が登場する
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020024")


	--★★ラロゥ★★:これに神秘的な力を注ぎこむと<br>その年の豊作が約束される…って
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:聖杯の効果として<br>十分にあり得るな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020026")


	--★★ノワール★★:昔の部族が繁栄のために聖杯を活用して<br>なんらかの理由で失われた、とか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020027")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それで<br>その儀式はどこで行われていたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:それは書いてない<br>でも推測はできると思うよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020029")


	--★★ラロゥ★★:場所は森深くの祭壇<br>この儀式のお陰で毎年豊作が続いたってある
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ということは<br>穀倉地帯近くの森…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:もう儀式は続いてないだろうから<br>今は遺跡かなにかになってそうだね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020032")


	--★★ラロゥ★★:どう？<br>心当たりある？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020033")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…一応な<br>手つかずの遺跡の話を聞いたことがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ラロゥ★★:いいじゃん！<br>聖杯はきっとそこに保管されてるよ！！
	Talk(Actor002,"CHRNAME_LAROU","speech","N","CO_101061_08020036")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_end()
-- ▲直接出力
	close_cutin()

	--★★ラロゥ★★:すぐに行こう、ノワール！
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020037")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:いや、こういうときに焦りは禁物だ<br>準備のために日はあらためよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_08020038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力

	--★★ラロゥ★★:できるだけ早くね<br>あんまり遅くなるなら、オレひとりで行くから！
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_08020040")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
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
setup_prop_object_preload(10103005)
setup_prop_object_preload(10103005)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
