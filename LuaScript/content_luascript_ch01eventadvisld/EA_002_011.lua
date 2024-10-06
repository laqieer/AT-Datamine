-- このluaスクリプトは、EA_002_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_02","110091_02_h")
Include("content_adv_advsmall_110091_02","Template110091_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-126.6,CharaPos110091_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_02,CameraPos110091_02_004)
	Camera002 = SetTemplate("Actor002",218.2,CharaPos110091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110091_02,CameraPos110091_02_001)
	Camera003 = SetTemplate("Actor003",-140.3,CharaPos110091_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110091_02,CameraPos110091_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110091_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110091_02,CameraPos110091_02_005)
	Camera005 = SetTemplate("Actor005",-149.6,CharaPos110091_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110091_02,CameraPos110091_02_002)
	InitializeTemplateRandomCamera110091_02()
	InitializeTemplate110091_02()
-- ▼直接出力
Hide(Actor001)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{5.75,0,5.07})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Comical")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★イゾルデ★★:神は賭けに乗る御人かしら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011002")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★リアム★★:………お大事になさってください
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011003")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
CloseTalkWindow()
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-323.6,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0015")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:信じられない。気休めしか言えないのね<br><ruby=しせい>市井</ruby>の人間に救いを与えようとは思わないの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011006")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★リアム★★:…コルベニックからの使者とともに<br>先日、コーンウォールへ向かわれたそうですが
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:見当たらなかったわ。調合も簡単ではないの<br>そう容易に手に入るシロモノじゃない…
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011008")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リアム", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★リアム★★:気を休めるハーブのご紹介であれば<br>いくらでも
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011009")

-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:<dot>ハッパ</dot>に詳しいという噂はウソ？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リアム", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★リアム★★:気を休めるハーブのご紹介であれば<br>いくらでも
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011014")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:ほら。また気休め
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011015")

-- ▼直接出力
se_play("SE_ADV_MA_01B109_11_Door")
Appear(Actor001)
Appear(Actor003)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101014_sp_0002_1")
-- ▲直接出力

	--★★トリスタン★★:見てられないよ、イゾルデ<br>気が立つのはわかるけど
	Talk(Actor003,"CHRNAME_TRISTAN","speech","N","EA_002_011017")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,70.7,0.3)
wait_time(0.2)
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,-244.1,0.3)
wait_time(0.1)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★トリスタン★★:偶然居合わせた敬虔なノワール卿まで困り顔だ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011018")

	open_select_window_tag(Actor001,"Normal","EA_002_011021","EA_002_011022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0004")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:イゾルデ、なにを探しているんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_011024")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0013")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:お前には関係ないわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011025")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:ノワール、誤解しないでほしいんだけど
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011026")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★トリスタン★★:あれは「自分のコトだから<br>ノワールに迷惑かけたくない」って意味だから
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011027")

-- ▼直接出力
PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:「黙りなさい」って意味よ<br>誤解しないでもらいたいわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ハッパ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_011031")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リアム", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リアム★★:ええ。ハーブのことです<br>ハーブに詳しいんです、私
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011032")

	change_face(Actor003,"Surprise")

	--★★トリスタン★★:へぇ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011033")

-- ▼直接出力
PlayPartVoice("リアム", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リアム★★:他意はないですよ<br>本当ですよ。信じてくださいね
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011034")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:司祭様の「信じてくださいね」は怖いなあ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011035")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:お祈りを捧げに来たわけじゃないの、私
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011037")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0046")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:祈ってあげるだけじゃ足りないかい？<br>あの人を救うのに
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011038")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:…見てられないのよ。それこそね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011040")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor004)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,CharaPos110091_02_005[1],CharaPos110091_02_005[2],CharaPos110091_02_005[3],1.0)
wait_time(0.1)
setup_small_camera_start(Camera004)
wait_time(0.9)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア","0002")
-- ▲直接出力

	--★★クレア★★:議論が円環を踊っているわね
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011042")

-- ▼直接出力
setup_small_camera_start(RndCamera010)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,103.7,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:平行線よ<br>ご覧の通り
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011044")

-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クレア★★:かぐわしい事件の香りがしたものだから
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力

	--★★イゾルデ★★:かぎつけて来たわけ？<br>大した名探偵ね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011046")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:惨事は未然に防ぎたいの<br>大した名探偵だから
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011047")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力

	--★★トリスタン★★:…イゾルデ、今回ボクはパスだよ<br>キミに任せる。探し物なら<ruby=クレア>探偵</ruby>にどうぞ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011048")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:トリスタン………わかってよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011050")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:キミとあの人にとって<br>良い出目になることを祈ってるよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","EA_002_011052")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…あの人？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_011054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★クレア★★:なら、良い出目となるかどうかは<br>賭けで決めましょうか
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011056")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:お前と賭け合うモノなんて
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011057")

-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力

	--★★クレア★★:報酬はあなたが望む、情報
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011058")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★クレア★★:イゾルデ、あなたが賭けに勝てば<br>リアムが情報を明かす。どう？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011060")

-- ▼直接出力
PlayPartVoiceDirect("リアム","0019")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★リアム★★:<ruby=わたし>司祭</ruby>をギャンブルに巻き込む気ですか？
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011061")


	--★★クレア★★:『神は賭けに乗る御人』？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011062")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:我らが信じる神は絶対に誤った結果を出さない<br>つまり彼女が情報を手にする資格がないとすれば
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011063")

	change_face(Actor005,"Normal")

	--★★リアム★★:…全能なる神はこの賭けを<br>『彼女の負け』として運命づけるはず…と？
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:あなたの信仰が誤っていなければね
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011066")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リアム", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★リアム★★:詭弁です
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011067")

-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クレア★★:賭け事、お嫌い？
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011068")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リアム","0033")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★リアム★★:………わかりました
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011070")

-- ▼直接出力
setup_small_camera_start(RndCamera010)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:まだ私が乗るとは言ってないわ<br>賭けの内容を明かさないのはフェアじゃない
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011071")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Appl")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア★★:ぱんぱかぱん
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011072")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.1)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	open_cutin(1,3)
	on_cutin(1,Actor004,"Normal")
-- ▼直接出力
bgm_play("BGM_ADV_Comical")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:『うきうきプレミアム感謝デーランチ』争奪<br>がんばれノワールバトル～
	Talk(Actor004,"CHRNAME_CLARE","speech","N","EA_002_011074")

	close_cutin()
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("イゾルデ", "驚き")
-- ▲直接出力
	open_cutin(2,3)
	on_cutin(1,Actor002,"Surprise")

	--★★イゾルデ★★:…『うきうきプレミアム感謝デーランチ』争奪<br>がんばれノワールバトル？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_011076")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リアム", "驚き")
-- ▲直接出力
	on_cutin(2,Actor005,"Surprise")

	--★★リアム★★:う、『うきうきプレミアム感謝デーランチ』争奪<br>がんばれノワールバトル…？
	Talk(Actor005,"CHRNAME_LIAM","speech","N","EA_002_011077")

	close_cutin()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	open_cutin(1,3)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:………え、俺？が？がんばる？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","EA_002_011079")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クレア★★:いわば神的運命に選ばれた者──ノワール<br>彼を対象とした賭け。今回に相応しいでしょう
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011080")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:…お遊びのつもり？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011081")

	PlayAction(Actor004,"to  Std_Joy")

	--★★クレア★★:詳細は後日発表。お楽しみに
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011082")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リアム", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★リアム★★:神よ
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_011083")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:伸るか反るか
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_002_011084")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0025")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:天を仰ぐよりは、マシね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_011087")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Area_Acoustic")
preload_sound("BGM_ADV_Comical")
	InitializeLoad_Preload()
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
