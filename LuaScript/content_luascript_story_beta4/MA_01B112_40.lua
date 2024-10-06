-- このluaスクリプトは、MA_01B112_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_01","113021_01_h")
Include("content_adv_advsmall_113021_01","Template113021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos113021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos113021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos113021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_008)
	Camera006 = SetTemplate("Actor006",332.9515,CharaPos113021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_001)
	InitializeTemplateRandomCamera113021_01()
	InitializeTemplate113021_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_pos(Actor006,{1.164, 0, 2.693})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★アステラ★★:あら。おそろいで
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400002")

-- ▼直接出力
 --PlayPartVoice("リリアーナ", "肯定")
-- ▲直接出力

	--★★リリアーナ★★:アステラさん、食事をお持ちしました
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B112_400003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アステラ", "肯定2")
-- ▲直接出力

	--★★アステラ★★:ありがと、リリアーナ
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★エクセリア★★:…体調は変わりなくて？
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01B112_400005")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アステラ", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アステラ★★:お風呂に入れる回数が少ないのが困るわ<br>聖杯城にいた頃は日に３度は水浴びしていたし
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400006")

	change_face(Actor001,"Normal")

	--★★アステラ★★:…あなたの求めた解答ではないわね？
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400008")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ガラハッド★★:オーウェン、マターヤ、アダンは<br>いまもコルベニック城をさまよっている
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エクセリア★★:司令塔の魔女やペレス王が消えたことで<br>もはや戦意のない…静かに歩む甲冑となったわ
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01B112_400011")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★リリアーナ★★:…コルベニック城の謁見の間でずっと<br>いなくなってしまった誰かの前に跪いている
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B112_400012")


	--★★ガラハッド★★:…アステラは、消えないよな…？
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★アステラ★★:なにも影響が出ていないといったら<br>ウソになってしまうけれど
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400014")

-- ▼直接出力
 --PlayPartVoice("アステラ", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アステラ★★:今のところはなんとかなっているわ<br>…それはあなたたちもでしょう？
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★アステラ★★:まだオーウェンの鼓動を感じる<br>今は、それで充分
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400017")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★フィエナ★★:ね…ノワール<br>アステラはどうなるの
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_400018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01B112_400019","MA_01B112_400020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:アステラの振る舞いしだいだろうな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B112_400022")

	change_face(Actor001,"Normal")

	--★★アステラ★★:閉じ込めておくのが普通よ<br>殺されたって文句は言えないわ
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エクセリア★★:そうね。甘すぎると思うわ<br>私たちのことも生徒として扱い続けている
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01B112_400024")

-- ▼直接出力
 --PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★リリアーナ★★:…アーサー王殺害を<br>企てたのにも関わらず
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B112_400025")

	change_face(Actor002,"Normal")

	--★★ノワール★★:だけど踏みとどまってくれたじゃないか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B112_400026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:ガラハッドや銀卓のみんなと過ごさせたい<br>できることなら少しでも長く、平和に
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B112_400028")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★フィエナ★★:うん…できるならいっしょに外に出たいよ<br>わがままかも、しれないけど
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_400029")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★アステラ★★:閉じ込めていたほうが平和よ
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ガラハッド★★:…アステラ<br>あなたの気持ちはどうなんだ
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400031")

	change_face(Actor001,"Sad")

	--★★アステラ★★:………わかってるでしょ？ガラハッド
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400032")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★リリアーナ★★:………あのまま<br>閉じ込めておいてくだされば
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B112_400034")

	change_face(Actor006,"Normal")

	--★★ガラハッド★★:リリアーナ…？
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400035")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エクセリア★★:…そうね、あのままでいさせてくれれば<br>解は限られていたはずなのに
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01B112_400036")

	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Sad")

	--★★フィエナ★★:エクセリア…どういう、こと…？
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B112_400037")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★エクセリア★★:ただ暗がりで敗北を受け入れ<br>静かに家族と運命をともにするときを待てたのに
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01B112_400038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力

	--★★リリアーナ★★:…外の世界を<br>私たちは知ってしまった
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B112_400039")


	--★★リリアーナ★★:なにも知らないまま、なにも学ばないまま<br>生きる道は銀卓の上だけと信じ続けられていれば
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B112_400040")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★リリアーナ★★:矜持に殉じる覚悟だけをもって<br>消え去ることも恐れなかったはずなんです…
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B112_400041")

-- ▼直接出力
 --PlayPartVoice("アステラ", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アステラ★★:………学びを得なければ<br>喪う恐怖も知らなくて済むものね
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★ガラハッド★★:…<br>なにを甘ったれてるんだ
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400044")

	change_face(Actor001,"Anger")

	--★★アステラ★★:………甘え、ですって？
	Talk(Actor001,"CHRNAME_ASTERA","speech","R","MA_01B112_400045")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:世界の広さと学び舎の楽しさを<br>知ることのなにがいけない
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400046")


	--★★ガラハッド★★:<ruby=うしな>喪</ruby>う恐怖を学べたならば──…
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400047")

	change_face(Actor006,"Normal")

	--★★ガラハッド★★:『喪いたくないという意志』を<br>手に入れられたのだろう
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★ガラハッド★★:だからお前たちはコルベニック城で<br>マターヤたちの剣を止めてくれたんじゃないのか
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400049")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★エクセリア★★:…ガラハッド、あなた…
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01B112_400050")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:それは、強く生きるための指針に<br>ほかならない
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01B112_400051")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113021)
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
