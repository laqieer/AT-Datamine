-- このluaスクリプトは、MA_01A110_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110101_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
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
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:戦死者たちを弔う国葬が終わった後
	Talk(Actor009,"telop","narration","N","MA_01A110_011001")


	--★★テロップ★★:ノワールたちはアーサーのもとを訪れ<br>魔女が話していたルーシャスの言葉の真偽を問う
	Talk(Actor009,"telop","narration","N","MA_01A110_011002")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:密会中に失礼するわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_010002")

-- ▼直接出力
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力

	--★★アーサー★★:鍵はかけておいたはずだが
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:王妃サマに預けた学園の親鍵は<br>取り上げるべきだったわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "照れ")
-- ▲直接出力

	--★★アーサー★★:これ以上なにも取り上げようとは思わないよ<br>ギネヴィア
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010006")

-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★エレイン★★:先輩…
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","MA_01A110_010008")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "納得")
-- ▲直接出力

	--★★マーリン★★:待っていたのですね<br>私たちとラヴェイン卿らが話す機会を
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A110_010009")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:ローマとの直接対決の前に<br>はっきりさせておきたいですから
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_010010")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:弁解するすべはない
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010011")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "激怒")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★ガウェイン★★:真実だって言うんすか…！？<br>ルーシャスの語ってたことが！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★マーリン★★:…父君は多くの負債を遺していかれましたね<br>アーサー様
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A110_010013")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:まとめて、全部聞かせてくださいよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A110_010014")

	open_select_window_tag(Actor001,"Normal","MA_01A110_010016","MA_01A110_010017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★エレイン★★:…気に、かけていただき<br>恐縮…です
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","MA_01A110_010019")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ラヴェイン★★:最初に申し上げておきますが、私たち兄妹は<br>ログレスに不利益なことは一切行っていません
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010020")

	change_face(Actor008,"Normal")

	--★★ラヴェイン★★:エレインにおいては<br>巻き込まれただけに過ぎません
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:わ、わたしのことは<br>別にいーでしょっ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_010023")


	--★★テロップ★★:「バルバロイに故国を追われ<br>ログレスに救われたそなたは──」
	Talk(Actor009,"telop","narration","N","MA_01A110_010024")


	--★★テロップ★★:「バルバロイに安住の地を奪われ<br>ログレスに見捨てられた余から見れば…」
	Talk(Actor009,"telop","narration","N","MA_01A110_010025")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:似たような境遇だから<br>戯れにイジメてやろうってハラでしょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_010026")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:同族嫌悪してんのよアイツ…！<br>ただ、それだけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_010027")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アーサー★★:………ルーシャスが語ったという我が父の行い<br>その『真実』とやらは──
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010029")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★アーサー★★:──誰も知らないんだ<br>国王である俺ですら
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010031")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:知らんぷりしてる<br>ってワケじゃないでしょうね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_010032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ここで嘘を言っても意味はないさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_010033")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:彼が語った惨劇…<br>それは現在誰の記憶にも残っていない
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010034")

	PlayAction(Actor006,"to  Std_Talk")

	--★★マーリン★★:「ユーサー様がブリテンの覇権を握るにあたり<br>島内のローマ人の存在が邪魔だった」
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A110_010036")


	--★★マーリン★★:「バルバロイにローマ人を喰らわせ<br>一掃するとともに彼らを忘却させるよう計った」
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A110_010037")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力

	--★★マーリン★★:「もとよりブリテンはログレスのものだった、と<br>歴史の改ざんを行った」…と仰せだったのですね
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A110_010038")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ルーシャスは自分が唯一の生き証人だと語った<br>彼だけしか知らない真実──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_010039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "照れ")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:だが、ブリテンにローマ人がいた痕跡はあった<br>それも事実だ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010040")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:ブリテンにある巨大な長城のことですよね<br>ローマほどの人的資源がないと完成は困難な…
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_010041")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:だから俺は知る必要があると考えた<br>ローマとログレスの因縁を
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★マーリン★★:ローマ本国内でブリテンの歴史が<br>どのように伝わっているのかを
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A110_010043")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:そんななか、ローマより皇太子の留学を依頼され<br>俺たちのほうから交換留学を提案したのだ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A110_010044")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:交換留学…！<br>ルーシャスは…そうだ、交換留学生で──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_010045")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "悩む")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ラヴェイン★★:隠すようなことではありませんが
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010046")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:ログレスからローマへの交換留学生は<br>私たち兄妹でした
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010047")

-- ▼直接出力
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
change_face(Actor003,"Surprise")
change_face(Actor004,"Surprise")
change_face(Actor005,"Surprise")
change_face(Actor006,"Surprise")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:ローマ大帝国の皇太子殿下と<br><ruby=わたし>一介の生徒会長</ruby>では不釣り合いでしたがね
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")

	--★★ラヴェイン★★:…継承者の発見、カレドニアの侵攻激化などで<br>留学を切り上げて帰国を余儀なくされました
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010051")


	--★★ラヴェイン★★:帰路のロンディニウムで妹ともども<br>騒ぎに巻き込まれ──
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010052")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:色々が落ち着いた今日この頃<br>諸々の報告のために密会を設けたという流れです
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ローマで、ユーサーの行いを知る者は…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_010054")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "否定")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ラヴェイン★★:結論から申し上げれば<br>大陸でもそれを知る者には出会いませんでした
	Talk(Actor008,"CHRNAME_LOVEIN","speech","L","MA_01A110_010055")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:………なに、それ…じゃあもう
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A110_010056")

-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:すべての真実を知るのは<br>ルーシャスただひとりなのか──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_010057")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:──すべてが妄言なのか、ね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_010058")

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
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
