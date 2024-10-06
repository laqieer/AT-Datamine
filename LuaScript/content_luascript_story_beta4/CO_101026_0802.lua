-- このluaスクリプトは、CO_101026_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",112,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110141_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_007)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor003,"Close")
reserve_eyesync(Actor003,"Close")
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor003,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor004,153.031,0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006, {-2.24,0,2.95})
set_rot(Actor006, {0,84.6,0})
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
lookWeight = {0.53, 0.04, 0.7, 0.35}
lookat_delay_weight(Actor004, lookWeight,0.8)
keep_ik_lookat(Actor004, Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:あ、パーシヴァルくんにノワール<br>来てくれたのか
	Talk(Actor004,"NPCNAME_0246","speech","N","CO_101026_08020002")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:ジャンは？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020003")

-- ▼直接出力
lookat_delay_weight_reset(Actor004 , 2.0)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:変わらずさ<br>あれから目を覚まさない
	Talk(Actor004,"NPCNAME_0246","speech","N","CO_101026_08020005")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(1.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ボクのせいだ<br>あのときボクがふたりから目を離さなければ…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020007")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力

	--★★パーシヴァル★★:いや、ふたりを森に連れて行かなければ<br>こんな事態にはならなかった！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_08020010","CO_101026_08020011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:パーシヴァルのせいじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020013")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんたがバルバロイを倒していなかったら<br>もっと被害がでていたかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020014")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:気休めはやめてくれ<br>…だが、その…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020015")

-- ▼直接出力
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:…いや、なんでもない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだな、危険な場所に<br>ダニーとジャンを連れていくべきじゃなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020018")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺も反省してる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020019")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
wait_time(0.5)
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:…ボクは、なんて弱いんだ………！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020020")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookat_delay_weight(Actor001, 0.8,0,0.4,0.35,1)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっと前に聞いたんだ<br>ふたりは幼い頃からあんたと一緒にいるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020022")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ボクたちの故郷は<br>果てなき森…いや、妖精の里を守護していた
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:守護していたといっても<br>妖精にあったことのある人はいなかったけれどね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020025")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:妖精と人間の交流はよしとされていないし<br>そもそも妖精の存在を眉唾と思う人も大勢いた
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★パーシヴァル★★:妖精なんていない<br>森を守る必要なんてない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020027")

	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:そんな油断しきったボクたちの故郷を<br>突如としてバルバロイの軍勢が襲った
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020028")

-- ▼直接出力
force_eyesync(Actor002,"Close")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力

	--★★パーシヴァル★★:今でも克明に覚えているよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020030")


	--★★パーシヴァル★★:バルバロイを前に使用人たちが<br>次々とボクを庇って喰われていった
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020031")

-- ▼直接出力
wait_time(0.8)
force_eyesync(Actor002,"Auto")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力

	--★★パーシヴァル★★:ボクは<br>高貴であるがゆえに生かされたんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:そんな過去があったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020033")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ダニーとジャンは怯えるボクの手を引き<br>城から連れ出してくれた
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:自分たちの家族の命を犠牲にしてまでもね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020035")

	open_select_window_tag(Actor001,"Normal","CO_101026_08020037","CO_101026_08020038")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたの言う責務の意味<br>やっとわかった気がするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020040")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ダニーやジャンをはじめとした<br>恩人たちの想いに応えようとしてるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020041")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:…フン。そんな格好良いものじゃない<br>貴族として当然の行為をしているだけさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020042")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたは十分強くなれてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020044")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:根拠のない励ましはいらない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020045")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ジャンひとりを助けられずに<br>なにが円卓の騎士だ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020046")

	change_face(Actor001,"Sad")

	--★★ノワール★★:パーシヴァル…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020047")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "苦しみ")
-- ▲直接出力

	--★★キャメロット騎士学男★★:ううっ…
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_08020049")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★キャメロット騎士学術院（男）③★★:ジャン？ジャン！<br>意識が戻ったのか！？
	Talk(Actor004,"NPCNAME_0246","speech","N","CO_101026_08020050")

-- ▼直接出力
reserve_eyesync(Actor003,"Auto")
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学男★★:うーん、ここは…？
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_08020052")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ジャン、良かった<br>本当に良かった…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020053")

-- ▼直接出力
lookWeight = {0.7, 0, 0.5, 0.35}
lookat_delay_weight(Actor003, lookWeight,0.7)
keep_ik_lookat(Actor003, Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★キャメロット騎士学男★★:えーっと、キミたちは誰？<br>ここはどこなんだろう？
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_08020054")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:記憶の欠損が起きたのかもしれないわね
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","CO_101026_08020057")

-- ▼直接出力
lookat_delay_weight(Actor001,1.0,0,0.6,0.35,1.0)
keep_ik_lookat(Actor001, Actor005, "J_Head")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:イゾルデ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08020058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★イゾルデ★★:彼はバルバロイの攻撃を受けたのでしょう？<br>バルバロイは人間の記憶を喰らう
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","CO_101026_08020060")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:一命をとりとめたとしても<br>場合によっては記憶の一部が奪われることがある
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","CO_101026_08020061")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:しかも、その者が大事にしている記憶から
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","CO_101026_08020062")

-- ▼直接出力
lookWeight = {0.8, 0, 0.7, 0.35}
lookat_delay_weight(Actor004, lookWeight,1)
keep_ik_lookat(Actor004, Actor005, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★キャメロット騎士学術院（男）③★★:記憶を戻すには…？
	Talk(Actor004,"NPCNAME_0246","speech","N","CO_101026_08020063")

	change_face(Actor005,"Normal")

	--★★イゾルデ★★:あなたも<br>この学園に通う者なら知っているでしょう？
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","CO_101026_08020064")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★イゾルデ★★:バルバロイに奪われた記憶は戻らないわ
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","CO_101026_08020065")

-- ▼直接出力
setup_small_camera_end()
lookat_delay_weight_reset(Actor004 , 0.6)
lookat_delay_weight_reset(Actor001 , 0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:そん、な…<br>ボクとともに過ごした思い出がなくなった…？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020066")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力

	--★★パーシヴァル★★:ともに武術の訓練をした思い出は？<br>果てなき森に一緒に狩りにいった思い出は？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020067")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:パパの大事にしていたグラスを割ってしまい<br>大目玉をくらったあの思い出は？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020068")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:みんなでゲシュタルト・シフトを果たし<br>バルバロイを根絶しようと誓った思い出は！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020069")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
Appear(Actor006)
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力

	--★★パーシヴァル★★:ジャン！<br>嘘だろう、覚えていると言ってくれ！！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08020070")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera004)
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")
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
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
