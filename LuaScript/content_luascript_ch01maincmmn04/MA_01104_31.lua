-- このluaスクリプトは、MA_01104_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_018,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_018)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_004)
	Camera008 = SetTemplate("Actor014",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("401005","001","401005001")
	Actor009 = InitializeCharacter_2DOnly("401006","001","401006001")
	Actor010 = InitializeCharacter_2DOnly("401007","001","401007001")
	Actor011 = InitializeCharacter_2DOnly("401009","001","401009001")
	Actor012 = InitializeCharacter_2DOnly("401008","001","401008001")
	Actor013 = InitializeCharacter_TextOnly()
	Actor014 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor014")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_MA_01C110_42_Crowd")
wait_time(2.0)
-- ▲直接出力

	--★★ランスロット★★:些細な喧嘩だ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310002")


	--★★キャメロット騎士学術院（女）★★:本当なの？<br>転校生とランスロット先生が－－…？
	Talk(Actor009,"NPCNAME_0146","speech","N","MA_01104_310003")


	--★★ランスロット★★:ノワールとは昔馴染みでな<br>ふたりとも血気盛んな時期で－－
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:円卓の騎士に剣を向けた奴が<br>円卓の騎士になったって？
	Talk(Actor008,"NPCNAME_0151","speech","N","MA_01104_310005")


	--★★ランスロット★★:日銭を稼ぐのも一苦労…<br>バルバロイも闊歩する地では仕様がない
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310006")


	--★★キャメロット騎士学術院（女）②★★:カレドニアに雇われた傭兵だったんでしょ…？
	Talk(Actor012,"NPCNAME_0147","speech","N","MA_01104_310007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ランスロット★★:ノワールやその妹も<br>仕事を選んでいる場合ではなかったらしい
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310008")


	--★★キャメロット騎士学術院（男）②★★:傭兵団『<ruby=ラ・コート・マルタイユ>不格好なコート</ruby>』だったって<br>ま、ちょっとカッコイイかもな…
	Talk(Actor010,"NPCNAME_0153","speech","N","MA_01104_310009")


	--★★ランスロット★★:色々とすれ違いもあったが－－
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310011")


	--★★キャメロット騎士学術院（男）③★★:キラーズなしじゃ<br>どうせ役立たずだろ
	Talk(Actor011,"NPCNAME_0154","speech","N","MA_01104_310012")

	open_cutin(1,2)
	on_cutin(1,Actor004,"Anger")

	--★★ガウェイン★★:うるッせぇなァッッ！！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","N","MA_01104_310013")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:ガウェイン、私語は慎め
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310015")

	PlayAction(Actor004,"to Sit02_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
lookat_weight(Actor005,1.0,0.5,0.3,0.5)
keep_ik_lookat(Actor005,Actor004,"J_Head")
-- ▲直接出力

	--★★ガウェイン★★:ランスロットが困ってるじゃねえか！<br>授業中にくっちゃべってよォッ！！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_310016")

	change_face(Actor005,"Sad")

	--★★ラグネル★★:ガウェインあんただよ<br>今の原因はあんた
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01104_310017")


	--★★ガウェイン★★:ええい止めるなラグネル
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_310018")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ラグネル★★:…まあいっか<br>ガウェインの好きにしなよ！
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01104_310019")

	change_face(Actor004,"Normal")

	--★★ガウェイン★★:転校生はアーサー様の期待に応えやがった<br>だから目をかけられた、そんだけだろ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_310020")

	change_face(Actor004,"Anger")

	--★★ガウェイン★★:そしてよく見やがれ！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_310021")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(Camera006)
-- ▲直接出力

	--★★ガウェイン★★:そいつが転校生のキラーズだ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_310023")

-- ▼直接出力
se_play("SE_ADV_MA_01C110_42_Crowd")
set_enable_auto_lookat(Actor005,true)
lookat_delay_weight_reset(Actor005,0.6)
-- ▲直接出力

	--★★ティルフィング★★:本日付けでこのクラスに配属となります<br>ノワール卿の最初の武器－－
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","MA_01104_310025")


	--★★ティルフィング★★:ティルフィング<br>そう呼ばれて、いました
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","MA_01104_310027")


	--★★キャメロット騎士学術院（女）★★:（…かわいい）
	Talk(Actor009,"NPCNAME_0146","mind","N","MA_01104_310028")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:よろしくお願いします
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","MA_01104_310029")


	--★★キャメロット騎士学術院（男）★★:（…うらやましい）
	Talk(Actor008,"NPCNAME_0151","mind","N","MA_01104_310031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★生徒全員★★:（…でもかわいい）
	Talk(Actor013,"NPCNAME_0150","mind","N","MA_01104_310032")


	--★★ランスロット★★:無事、<ruby=ゲシュタルト・シフト>ＧＳ</ruby>を済ませてキラーズを得た<br>入試当日、異例のスピード出世だな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:（…ま。嘘も方便ね<br>「ＧＳを済ませた」ワケではないし）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01104_310035")

	open_select_window_tag(Actor001,"Normal","MA_01104_310036","MA_01104_310037","MA_01104_310038")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ランスロット卿の<br>手引きのおかげ、だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_310040")

	change_face(Actor009,"Normal")

	--★★キャメロット騎士学術院（女）★★:あたりまえよね<br>さすがはランスロット先生
	Talk(Actor009,"NPCNAME_0146","speech","N","MA_01104_310041")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ランスロット★★:ノワールが斬り拓いた道だ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ギネヴィア殿下のおかげだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_310044")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:あらためてお礼を言わせてくれ<br>ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_310045")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:………！<br>…ど、どーも、わたしのおかげです
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_310046")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の力でなんとかやり遂げたんだ<br>努力を続けた甲斐があったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_310048")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:…確かに<br>ノワール自身の力が大きかったな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310049")

	change_face(Actor008,"Normal")

	--★★キャメロット騎士学術院（男）★★:なんか感じ悪くね、あいつ？
	Talk(Actor008,"NPCNAME_0151","speech","N","MA_01104_310050")

	goto Block1end

::Block1end::
	change_face(Actor003,"Normal")

	--★★ランスロット★★:そして我らログレスの拠点<br>剣の祭壇を取り返してくれた
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310052")


	--★★ランスロット★★:カレドニアとバルバロイの支配圏にもかかわらず<br>殿下をお守りしたうえでだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310053")

	PlayAction(Actor004,"to Sit02_Talk")
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:俺も助けに行ったぜ！<br>ヒーローらしく！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_310054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ラグネル★★:１回黙ろ？
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01104_310055")


	--★★ランスロット★★:以上の功績により<br>陛下は改めて王命を出した
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310056")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ランスロット★★:ノワールを<br>円卓の騎士として認めると
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_310057")

-- ▼直接出力
se_play("SE_ADV_MA_01C110_42_Crowd")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:（…「原初の劔を継ぐ者待てば<br>いずれカリバーンは抜き放たれん」）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01104_310059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:（「最初の武器を携えて<br>終わりの続きを往く」－－…）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01104_310060")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ギネヴィア★★:（学園はノワールが<br>祭壇の剣を抜いたこと、隠してる）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01104_310062")


	--★★ギネヴィア★★:（ティルフィングのことも<br>彼女が言ってた『継承者』ってコトバ自体も）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01104_310064")

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
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("401005","001","401005001")
	InitializeCharacter_2DOnly_Preload("401006","001","401006001")
	InitializeCharacter_2DOnly_Preload("401007","001","401007001")
	InitializeCharacter_2DOnly_Preload("401009","001","401009001")
	InitializeCharacter_2DOnly_Preload("401008","001","401008001")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor014")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
