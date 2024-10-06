-- このluaスクリプトは、CO_101010_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_01","111091_01_h")
Include("content_adv_advsmall_111091_01","Template111091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_005)
	InitializeTemplateRandomCamera111091_01()
	InitializeTemplate111091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:今回はロジーの里か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020002")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:でも、ここは俺と母さんとディナタンが<br>暮らしていた場所で…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020003")


	--★★ノワール★★:父さんとは関係ないんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:『妖精殺し』の罪で追われる身となってからも<br>師匠は常にお前たち家族を見守っていた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020006")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:お前たちに危害を加えようとする<br>賊や魔物は現れないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020007")


	--★★ランスロット★★:ライエンスの手の者が<br>この里の存在を掴みはしないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:常に目を光らせていたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020009")

	open_select_window_tag(Actor001,"Normal","CO_101010_08020011","CO_101010_08020012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:母さんはそのことを<br>知っていたんだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020014")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:師匠は伝えていなかった<br>しかし、ひょっとすると…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020015")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
wait_time(2)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロット、どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:父さん…<br>言ってくれればよかったのに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020019")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:言いたかったはずだ<br>お前たちのそばにいてやりたかったはずだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが、姿を現すことは許されない<br>お前たちを大事に思っていたからこそ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020021")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…わかってるよ<br>どうしようもなかったんだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020022")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:ノワール…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020023")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…実はな<br>俺もこの里の近くを訪れたことがあるんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020025")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ああ。まだＧＳして間もない頃、<br>訓練がてら師匠に連れられてな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020027")


	--★★ランスロット★★:あの頃は俺もどうにもうまく動けなくて<br>師匠に迷惑をかけた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:このあいだのお前よりも<br>ひどい動きをしていたと思う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_08020033","CO_101010_08020034")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうなのか？<br>ランスロットが！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ<br>お前は俺を買いかぶりすぎだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020037")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺だって<br>そんなになんでも、うまくできるわけではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020038")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっと想像つかないな…<br>あ、いや
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>あんたも魚釣りが苦手だったりするもんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:前にも言っただろう<br>わざわざ釣らなくても、剣で突けばいいと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はいはい、わかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020042")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ちょっと見てみたかったな<br>その光景
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020044")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:お前な…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ランスロットが失敗してる姿なんて<br>めったに見られないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020047")

-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:見せないようにしてるんだよ<br>皆の前ではな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020048")

	goto Block2end

::Block2end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:あの頃の俺は、焦っていたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020050")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:師匠とＧＳを果たしたのだから<br>自分たちの関係を変えないといけない気がしてな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020051")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★ランスロット★★:師匠を引っ張っていけるよう<br>俺がマスターとしてしっかりしなければと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020052")

-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:今思えば滑稽だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020054")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…ランスロットでも<br>そんなふうに考えるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:お前と同じだよ<br>俺も…必死だったんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020056")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:師匠はそんな俺に<br>「焦らなくていい」と言ってくれた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:「ゆっくり、自分のペースで進めばいい」
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020059")


	--★★ランスロット★★:「たとえつまずいても、待っている<br>転んでしまっても、必ず手を差し伸べる」と
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:…それが、父の務めだからと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020061")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺も…父さんからよく言われた<br>「急がなくていい」って――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020062")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力

	--★★ランスロット★★:ゆっくり自分のペースで進んでいけばいいさ<br>俺だって初めはうまくやれなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020064")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:同じこと、言ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020066")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:ん？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08020068")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020070")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:あんたも<br>しっかり継いでるんだなって思っただけさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08020072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
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
	load_area_scene_preload(111091)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
