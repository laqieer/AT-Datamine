-- このluaスクリプトは、MA_01105_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera002 = SetTemplate("Actor002",-110,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102009)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
load_image("101010260", "content_still_10101026_image", "101010260_StillImage")
show_image("101010260", 0.0, 0.0, 0,true,false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_DrumRoll")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Festival")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101027","001","101027001")
	Actor010 = InitializeCharacter_2DOnly("101026","001","101026001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor010,"Surprise")

	--★★MC★★:春の訪れ、夏の豊穣…<br>今年その祈りを聞き届けるのは誰なのか
	Talk(Actor010,"NPCNAME_0118","speech","L","MA_01105_090002")

-- ▼直接出力
CloseTalkWindow()
hide_image()
wait_time(0.2)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor010,"Smile")

	--★★MC★★:お待ちかね！<br>五月女王の投票結果が出たようだよ！
	Talk(Actor010,"NPCNAME_0118","speech","L","MA_01105_090003")


	--★★イゾルデ★★:投票券は五月祭の商品を買ったらついてくる…<br>うまい売りかたしてるわよね
	Talk(Actor008,"CHRNAME_ISOLDE","speech","L","MA_01105_090005")

	change_face(Actor006,"Surprise")

	--★★ラグネル★★:ひとりで複数票入れられるのってどうなの？<br>その仕組みは果たして公正かなぁ？ねえ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_090006")

	open_select_window_tag(Actor001,"Normal","MA_01105_090008","MA_01105_090009","MA_01105_090010")
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

	--★★ノワール★★:だから男子生徒の連中は<br>食べ物を大量に買ってたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_090012")

	change_face(Actor005,"Smile")

	--★★ガウェイン★★:みんなすげえハラ減ってんのかと思ったぜ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01105_090013")

	change_face(Actor007,"Normal")

	--★★トリスタン★★:ガウェインは<br>去年も参加したんじゃないの？
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01105_090014")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Normal")

	--★★ガウェイン★★:去年は五月女王に興味なくてさ<br>バカ騒ぎしてた記憶はあんだけどよ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01105_090015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:惜しみなく推せるのは悪くないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_090017")

	change_face(Actor004,"Anger")

	--★★ディナタン★★:兄さぁん…？<br>惜しみなく推してる人でもいるの？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01105_090018")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、いや！<br>みんなの気持ちを代弁しただけだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_090019")

	change_face(Actor004,"Sad")

	--★★ディナタン★★:ふぅん…？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01105_090020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:金で愛を贈るのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_090022")

	change_face(Actor007,"Normal")

	--★★トリスタン★★:愛のカタチはそれぞれだね
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01105_090023")

	change_face(Actor008,"Normal")

	--★★イゾルデ★★:稼ぐための労力、財布から出す決意<br>己の限界を見極めながら注げる愛の量を計る…
	Talk(Actor008,"CHRNAME_ISOLDE","speech","L","MA_01105_090024")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Laugh")

	--★★イゾルデ★★:情熱ね。悪くないわ
	Talk(Actor008,"CHRNAME_ISOLDE","speech","L","MA_01105_090025")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…誘拐、どんとこい………！！<br>ねえ、髪とか服…乱れてないかな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:ふふ。いつもどおり<br>キマっていらっしゃいますよ
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_090028")

-- ▼直接出力
CloseTalkWindow()
show_image("101010260", 0.0, 0.0, 0,true,false)
wait_time(0.2)
-- ▲直接出力

	--★★MC★★:発表は昨年の五月女王に輝いた<br>義姉さ…ディンドランさんにお願いします！
	Talk(Actor010,"NPCNAME_0118","speech","L","MA_01105_090029")


	--★★ディンドラン★★:発表します。<br>今年の五月女王は…
	Talk(Actor009,"CHRNAME_DINDRANE","speech","L","MA_01105_090031")


	--★★MC★★:ドラムロール！　カモン！
	Talk(Actor010,"NPCNAME_0118","speech","L","MA_01105_090032")

-- ▼直接出力
CloseTalkWindow()
hide_image()
wait_time(0.2)
bgm_play("BGM_ADV_DrumRoll")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor002, 0.6, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:の、の、のわーる、ねえノワール…！<br>結果出たら走るのよ、わたしを連れて！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01105_090036","MA_01105_090037")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:護衛しなきゃな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_090039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうよそうよ<br>そうなのよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090040")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:じゃなきゃ、もみくちゃにされちゃうんだから！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090041")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それって俺が誘拐したことにならないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_090043")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090045")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:ま、まァ<br>それならそれで、考える
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090047")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_To_End")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ディンドラン★★:五月女王は<br>ディナタンさんです！
	Talk(Actor009,"CHRNAME_DINDRANE","speech","L","MA_01105_090049")

-- ▼直接出力
bgm_play("BGM_Area_Festival")
se_play("SE_ADV_MA_01C110_41_Cheers_02")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight(Actor001, 0, 0, 0, 0,1.0)
lookat_delay_weight(Actor002, 0, 0, 0, 0,1.0)
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
-- ▲直接出力
	open_cutin(3,2)
	on_cutin(1,Actor004,"Surprise")
	on_cutin(2,Actor001,"Surprise")
	on_cutin(3,Actor002,"Surprise")

	--★★ディナタン★★:えっ？
	Talk(Actor004,"CHRNAME_DINATAN","speech","N","MA_01105_090051")


	--★★ノワール★★:えっ！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01105_090052")


	--★★ギネヴィア★★:………えっ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01105_090053")

	close_cutin()
	change_face(Actor009,"Normal")

	--★★ディンドラン★★:ご存じのように、彼女の入学経緯は複雑なものの<br>投票コメントを一部ご紹介いたしますと…
	Talk(Actor009,"CHRNAME_DINDRANE","speech","L","MA_01105_090055")

	change_face(Actor009,"Laugh")

	--★★ディンドラン★★:「もっと話を聞いてみたい」<br>「敵だったんだろうけど、戦場とは違うはず」
	Talk(Actor009,"CHRNAME_DINDRANE","speech","L","MA_01105_090056")


	--★★ディンドラン★★:「昨日の敵は今日の推し！<br>敵同士からのはじまりが逆に運命的に感じる」
	Talk(Actor009,"CHRNAME_DINDRANE","speech","L","MA_01105_090057")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Shy")

	--★★ディナタン★★:…！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01105_090058")


	--★★ディンドラン★★:「真面目」「毎日挨拶してくれる」「いい匂い」<br>「ザ・優等生」「可愛い」「すき」「見てるよ」
	Talk(Actor009,"CHRNAME_DINDRANE","speech","L","MA_01105_090059")


	--★★MC★★:さぁ、ディナタンさんステージ上へ！
	Talk(Actor010,"NPCNAME_0118","speech","L","MA_01105_090060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")

	--★★ディナタン★★:ほ、本当に私が…？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01105_090062")

-- ▼直接出力
PlayActionDirect(Actor005,"to LookFor")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガウェイン★★:…ぷっ！くくくっ…
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01105_090064")

-- ▼直接出力
lookat_delay_weight(Actor006, 0.7, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor006,Actor005,"J_Head")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ラグネル★★:ガウェイン！<br>笑っちゃダメだよ！
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_090066")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★トリスタン★★:えーっと、なんだっけ？<br>「誘拐、どんとこい？」クスクス…
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","MA_01105_090067")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor001, 0.6, 0.03, 0.7, 0.2,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えーっと…<br>護衛、いる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_090069")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………まもって、この恥ずかしさから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_090070")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102009)
load_image_preload("101010260", "content_still_10101026_image", "101010260_StillImage")
preload_sound("BGM_ADV_DrumRoll")
preload_sound("BGM_Area_Festival")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101027","001","101027001")
	InitializeCharacter_2DOnly_Preload("101026","001","101026001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
