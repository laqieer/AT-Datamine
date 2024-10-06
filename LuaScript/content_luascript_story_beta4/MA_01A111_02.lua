-- このluaスクリプトは、MA_01A111_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_008)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_pos(Actor002, {1.35, 0, -1.44})
turn(Actor002,0, -65, 0,0)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115024)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A111_021001")


	--★★テロップ★★:<ruby=キミ>庶民</ruby>の実家──<br>見るのが楽しみだよ、継承者
	Talk(Actor007,"telop","narration","N","MA_01A111_021002")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A111_021003")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:庶民の実家──<br>見るのが楽しみだよ、継承者
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01A111_020002")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力

	--★★ディンドラン★★:故郷の地、お邪魔いたします
	Talk(Actor004,"CHRNAME_DINDRANE","speech","L","MA_01A111_020004")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020005")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ボールス★★:聖杯の探索が進み<br>行き先の目途が付いた
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01A111_020006")

-- ▼直接出力
 --PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:推理するほどでもなかったわね
	Talk(Actor006,"CHRNAME_CLARE","speech","L","MA_01A111_020007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:お前の母親が眠る地…<br>ロジーの里へ行く
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_020008")

-- ▼直接出力
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:あそこに聖杯があるのか…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020009")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力

	--★★パーシヴァル★★:ないよ継承者<br>だけど行かなきゃいけないの
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01A111_020010")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:ええっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020011")

-- ▼直接出力
lookat_delay_weight_reset(Actor001,1)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:バルバロイは湖から産まれ出る<br>つまりはそこが魔女に有利な力場…ゆえに──
	Talk(Actor006,"CHRNAME_CLARE","speech","L","MA_01A111_020012")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:んん…？？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020013")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:詳しく知る必要はないわ<br>貴方は座して待てばいいの
	Talk(Actor006,"CHRNAME_CLARE","speech","L","MA_01A111_020014")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:例のごとくガラハッドが先行してしまった<br>フィエナが引き留めるべくついて行ったが──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_020015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:またまたガラハッドだ<br>手のかかる子だよね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01A111_020016")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディンドラン★★:ふふふ。そうですね、パー坊
	Talk(Actor004,"CHRNAME_DINDRANE","speech","L","MA_01A111_020017")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:あっ！やめろ！！<br>パー坊って言うな！！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01A111_020018")

-- ▼直接出力
 --PlayPartVoice("クレア", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★クレア★★:血気盛んなのね<br>なつかしい？ヴォールス？
	Talk(Actor006,"CHRNAME_CLARE","speech","L","MA_01A111_020019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力

	--★★ボールス★★:大人が制してやらねばなるまいな
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01A111_020020")

	open_select_window_tag(Actor001,"Normal","MA_01A111_020022","MA_01A111_020023","MA_01A111_020024")
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
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ぜひ、ついていきたいけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020026")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★クレア★★:そんなに聖杯探索班は信用ないかしら？
	Talk(Actor006,"CHRNAME_CLARE","speech","L","MA_01A111_020027")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディンドラン★★:帰郷を望まれているのでしょう<br>彼は
	Talk(Actor004,"CHRNAME_DINDRANE","speech","L","MA_01A111_020028")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前はそばにいてやるべき相手がいる<br>一緒に行くのは今度にしよう、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_020029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうやって探索場所を見つけているんだ？<br>というか、どう探索範囲を絞っているのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020031")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:基本はフィエナ頼りだよ<br>詳しい事情は時間がないからパスで
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01A111_020032")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:パスするなよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020033")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ボールス★★:妖精にまつわる場所、もしくは魔女に有利な力場<br>俺たちはそこを潰してまわってきたのだ
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01A111_020034")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドが心配だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ<br>誰かがストッパーになれればいいのだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_020037")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディンドラン★★:フィエナ様はガラハッド卿に甘いですからね<br>優しく良き姉ではあるのですが
	Talk(Actor004,"CHRNAME_DINDRANE","speech","L","MA_01A111_020038")

-- ▼直接出力
 --PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★クレア★★:…ガラハッドのあの意欲が<br>空回りしなければいいけれどね
	Talk(Actor006,"CHRNAME_CLARE","speech","L","MA_01A111_020039")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:今はローマや魔女も聖杯奪取に向けて<br>戦力を整えているところだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_020041")

	change_face(Actor002,"Laugh")

	--★★ランスロット★★:限られた時間ではあるが<br>級友や学園の仲間と休んでいてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:良い報せを持ち帰ろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_020043")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115024)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
