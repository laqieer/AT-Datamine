-- このluaスクリプトは、CO_101037_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
off_active(tegami2)
tegami_offset2 = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
on_parent(tegami2,Actor002, "Loc_weapon_constrint_L", tegami_offset2)
on_active(tegami2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.9,0.05,0.5,0.2)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:もうこんな時間だ<br>遅くなる前に学園に戻ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:それは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:ヴェルナルス様からの手紙です
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030005")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ラシア★★:「ラシアへ。変わりはないか」
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030007")


	--★★ラシア★★:「帰ったらラシアが作ったヨーグルトを食べたい<br>良く冷やしておいてくれ。では」
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030008")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…それだけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:前に言ったとおりでしょう？<br>苦労して送るほどの内容じゃないですよね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101037_07030012","CO_101037_07030013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
off_parent(tegami2)
off_active(tegami2)
PlayActionDirect(Actor002,"to Std_Loop")
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(0.3)
SkipOffsetCamera(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聞いていたとおり<br>すごく短い手紙だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030015")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:でも、だからこそヴェルナルス先生が<br>ラシアを想う気持ちを感じる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030016")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:私を想う気持ち？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:先生は戦場から戻ってきたときに<br>いつもラシアのヨーグルトを食べてたんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:わざわざヨーグルトに言及したってことは<br>必ず帰るっていう決意の表れじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:きっとこの手紙を通して<br>ラシアを安心させたかったんだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:…そうですね<br>言われてみれば、すごくヴェルナルス様らしい
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.3)
off_parent(tegami2)
off_active(tegami2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
SkipOffsetCamera(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:無口な先生らしい手紙だけど<br>近況とかにも触れて欲しいよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030023")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうしたらラシアも<br>少しは安心できるかもしれないのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030024")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:いいんです、ノワール<br>きっと向こうは大変な状況でしょうし
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030025")

	change_face(Actor002,"Normal")

	--★★ラシア★★:少なくとも<br>ヴェルナルス様が無事だとわかりましたから
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そっか。そうだな<br>確かにそれが一番大事なことだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030027")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:…ローマ陣営の惨状を聞くたびに<br>じっとしていられなくて
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030029")


	--★★ラシア★★:私も故郷のためになにかしたい<br>ヴェルナルス様のお役に立ちたい
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ラシア★★:気持ちは焦るばかりです<br>今からでもヴェルナルス様のもとへ…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいや、学園に戻るべきだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030032")

	change_face(Actor002,"Sad")

	--★★ラシア★★:でも私が学園にいたって…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:きっとヴェルナルス先生は<br>学園に帰ってくる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030034")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのとき学園にラシアがいなかったら<br>先生は悲しむんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それに、キミが故郷のためにできることはある<br>キミだからできることがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030037")


	--★★ラシア★★:私だからできること？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今、ログレスにはローマからの難民が増えてる<br>彼らの力になってあげるのはどうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030039")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:ログレスにいるローマの人たちの<br>力になる…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030040")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ヴェルナルス先生は<br>愛する故郷に暮らす人々を守ろうとしている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ローマの人々がログレスに身を寄せているなら<br>きっと戻ってきてくれるはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:私…待ってみます<br>ローマの人たちと一緒に、ヴェルナルス様を
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…帰ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_07030044")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はい！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_07030045")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
