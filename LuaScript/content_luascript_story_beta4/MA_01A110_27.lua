-- このluaスクリプトは、MA_01A110_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:建付けの悪い壁だったわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:それを守ってたのが学園からの離反者…<br>手放しで喜べたもんでもねーが
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270003")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:長城周囲のバルバロイ掃討は順調なようです<br>中心部以外の敵数は僅かと見えます
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_270004")

	open_select_window_tag(Actor001,"Normal","MA_01A110_270005","MA_01A110_270006","MA_01A110_270007")
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
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ローマにはまだなにか企みがあるんだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270009")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:…あれはやっぱヴェルナルス大将軍の策でも<br>ルーシャスの考えでもないっすね
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270010")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ローマに行っちゃった子も<br>どうなるかわかったもんじゃないわね…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270011")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★エレイン★★:………戻る気はないんだと思います<br>きっと3人とも、誰かのために歩んでる
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルスは強敵だった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270014")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:あの人…強ぇだけじゃねえんだ<br>擁護する気は全然ねーけど、なんていうかさ──
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270015")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:優しいんだよ、あの人
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270016")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:近くにいる人間がすげー力を発揮しちまう<br>だから…ちょっとヤな予感もするんだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これで聖杯探索範囲も東部へ広げられる<br>ランスロットたちの助けになればいいが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270019")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★アーサー★★:ただ、ローマ対策班の疲弊も相当なものだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270020")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:焦りは禁物だ<br>万全の態勢でカレドニアへと進みたい
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01A110_270021")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:聖杯探索班の結果を待ちつつ英気を養おう<br>ローマは大量のバルバロイを消費しただろうしな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270023")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:ロンディニウム民たちのケアも続けねばなるまい<br>貴公らの働きはすべて良い方向に働いているが…
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01A110_270024")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:都を奪還し、壁を破壊し、敵の侵略を留めた<br>避難民もログレスで手厚く保護している
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力

	--★★ケイ★★:世論は落ち着きを見せているようにも思えるが<br>やはり奥底にはまだ怯えと不信が根付いている…
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01A110_270026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…仮に虐殺がログレスのせいじゃないと<br>信じてもらえても、やり場のない怒りは残る…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270027")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★エレイン★★:………あの、バルバロイは<br>思い出を喰らう…んですよね
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270029")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:いきなりなんだね…まあそうだが<br>喰らわれた者の存在や記憶を喰らう
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01A110_270031")

-- ▼直接出力
 --PlayPartVoice("エレイン", "納得")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エレイン★★:私たちＧＳを果たした騎士たちは<br>思い出の数だけ強くなれる…んですよね
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270032")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:ええ、そうですよ<br>結ばれた者同士の絆の深さが強さに直結します
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_270034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力

	--★★エレイン★★:でしたら、そうでしたら<br>提案…させてください
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270035")

	PlayAction(Actor006,"to  Std_Talk")

	--★★エレイン★★:お祭りを、しませんか
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270037")

-- ▼直接出力
 --PlayPartVoice("ケイ", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ケイ★★:………お祭り？
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01A110_270038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:ログレスがローマを押し返した労いのため<br>これからの戦いに向け、この学園で
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270039")

	PlayAction(Actor006,"to  Std_No")
	change_face(Actor006,"Sad")

	--★★エレイン★★:…ロンディニウムの虐殺の嫌疑は、もしかしたら<br>払拭し切れるものではないかもしれません
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270040")


	--★★エレイン★★:でも、ロンディニウムから生還した人や…<br>孤児たちのためにも
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270041")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:彼らは家を壊されて、もうどこにもいけない<br>…自分の家族のことさえ忘れてしまっています
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270042")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:…サイアクね、それ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270043")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力

	--★★エレイン★★:もう誰もかえってこないと泣いています<br>さびしさもかなしさも、わからなくなっています
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:戦い続ける学園の皆さんもそうです<br>何が楽しみで、何が望みで戦うのか、わからない
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270045")

	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "否定")
-- ▲直接出力

	--★★エレイン★★:なくし続ける戦いなんて哀しすぎます<br>そんなのしょうがないと諦めるのは寂しすぎます
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270046")


	--★★エレイン★★:ＧＳへの憎らしさも戦いへのやるせなさも<br>私、どうしようもありません、でもそれを私──
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★エレイン★★:笑顔に変えたい<br>思い出を残したい
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_270050","MA_01A110_270051")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エレインに賛成だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270053")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺も、大賛成
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270054")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ラヴェイン★★:とても素晴らしい考えだと思いますよ<br>エレイン
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_270055")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーの意見を聞かなきゃな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270057")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:もおノワール…<br>乙女の必死な演説を無下にするんじゃないの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270058")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ケイ★★:この沈黙が我らの答えではないかな？陛下
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01A110_270059")

	goto Block2end

::Block2end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "納得")
-- ▲直接出力

	--★★アーサー★★:…もともと予定されていた学園祭は<br>中止の予定であった
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270061")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:だからまあ、やるだけの予算も資材も<br>あるっちゃあるわけだ！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270062")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:ロンディニウムでできなかったぶん盛り上げてさ<br>キツイ気持ち…少しでも晴らしてやれたらな…！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, true)
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:ただ！条件が３つある！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270065")


	--★★アーサー★★:ひとつ、戦いが発生した場合はそちらが優先だ<br>ことと次第によっては中止もありえる
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270066")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ふたつ、出店や催し物の準備は従来通り<br>生徒たち実行委員でやること
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270067")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★エレイン★★:実行委員…？
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270068")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ラヴェイン★★:発案者がやるべきでしょうね<br>妹の望みは兄であり生徒会長である私が──
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_270069")

	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★エレイン★★:私が！<br>やります！！
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_270073","MA_01A110_270074")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺もやるよ、実行委員なんて初めてだけど<br>みんなと一緒に祭りを楽しんでみたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270076")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あ！わたしもやりたい！<br>わたしもやりたーい！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270077")

-- ▼直接出力
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★エレイン★★:先輩もギネヴィア様も…<br>お休みされていたほうが…！
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270078")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:動かないでいることだけが<br>休むことじゃないさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270079")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラヴェインに任せたほうが<br>いいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270081")

	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "否定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エレイン★★:発案者は私ですから。それに…<br>学園を離れていたぶん、取り戻したいんです
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_270082")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定3")
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ラヴェイン★★:…わかりましたよ、エレイン<br>ですがサポートくらいはさせてください
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_270083")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ノワール、わたしたちもやるわよ<br>わたしがやりたいだけだけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270084")

-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_delay_weight(Actor001, {0.8, 0.02, 0.5, 0} ,0.9)
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_270085")

	goto Block3end

::Block3end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:祭りの開催については俺も各所に説得をかける<br>綿密な準備の末、X日を開催日としよう
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270087")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:アーサー様、3つ目の条件は？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_270088")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:思い切り楽しむこと！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_270089")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:憧れの、学園祭ってやつ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_270090")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
