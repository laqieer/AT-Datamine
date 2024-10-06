-- このluaスクリプトは、EA_004_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor001,{-3.115,0,0.657})
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-4.4,0,-0.462})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
turn_lookat(Actor005,Actor003,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
turn_lookat(Actor006,Actor003,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
turn_lookat(Actor007,Actor003,0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{3.35,0,-0.6})
Hide(Actor008)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101054","005","101054005","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("パーシヴァル","激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:もう我慢ならないね！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220004")

-- ▼直接出力
IN_WALK_2P(Actor001,CharaPosDuelCommonFormation01_006,Actor004,CharaPosDuelCommonFormation01_008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:どうしたんだよ。いきなり大声を出して
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0019")
-- ▲直接出力

	--★★パーシヴァル★★:どうしたもこうしたもないよ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","怒り")
-- ▲直接出力

	--★★パーシヴァル★★:エクセリア。キミの指揮に従ったばかりに<br>ぼくらのチームは負けっぱなしじゃないか！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220010")

-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ、そういう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220011")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:指揮には自信があるっていうから、このぼくが<br>リーダーの座を譲ってあげたというのに！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220012")

	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:実技演習を行うには人数が足りないっていうから<br>クラスの垣根を越えて協力に来たこのぼくが！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoice("パーシヴァル","激怒")
-- ▲直接出力

	--★★パーシヴァル★★:なのに、この授業中ずっと負け続けて！<br>とうとうノワールのチームにまで負けた！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:これはもう、キミの指揮に<br>問題があるとしか言いようがない！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220015")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_004_0220017","EA_004_0220018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:乱暴な言いかたは止めろよ<br>エクセリアは悪くない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それにエクセリアはアダンの授業を<br>手伝ってくれてるんだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:それはわかってるさ<br>だからぼくだって今の今まで我慢してたんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220024")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:けど、言わなきゃ彼女はわからないだろ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そもそも、なんでリーダーを譲ったりしたんだ？<br>パーシヴァルらしくもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220028")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:キミはぼくをどういう人間だと思ってるのさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:あのね。ぼくだって臨時教師とその手伝いに<br>敬意を払おうっていう気持ちくらいあるんだよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ貫け、その気持ちを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220032")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ムリムリ！もうムリだね！！<br>海より広いぼくの心がもう無理だと叫んでる！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220033")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:言いたいことはそれだけ？
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220035")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:なら言わせてもらうけど<br>文句を言いたいのはこっちのほうよ
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220036")

-- ▼直接出力
PlayPartVoice("パーシヴァル","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:なんだって？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★エクセリア★★:私の指揮の通りに動いていれば勝てたはず<br>だから問題は作戦を実行できないチームにあるの
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220039")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:最適解の戦術を実行するには、<br>チームメンバー全員の練度が低すぎるのよ
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220040")

	PlayAction(Actor002,"to  Std_Surp")

	--★★パーシヴァル★★:なっ…！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220042")

-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エクセリア…キミも少し言いすぎじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220043")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エクセリア★★:彼が私の指揮に問題があるなんて言うからよ<br>私の作戦はいつだって最適解だもの
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220044")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ","悩む")
-- ▲直接出力

	--★★リリアーナ★★:うーん…確かに、エクセリアの戦術に<br>間違いはないと思います
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","EA_004_0220045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★リリアーナ★★:エクセリアは騎士団のなかでも特に知略に長け<br>軍師として実戦でも成果を出していますから
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","EA_004_0220046")

-- ▼直接出力
PlayPartVoice("パーシヴァル","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:それはそうかもしれないけどね――
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220047")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1","怒り")
-- ▲直接出力

	--★★男子生徒A★★:君の作戦はちょっと複雑すぎるんだよ！<br>こっちは戦うので精いっぱいだってのにさ
	Talk(Actor005,"NPCNAME_0151","speech","L","EA_004_0220049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1","怒り")
-- ▲直接出力

	--★★女子生徒A★★:私たちは円卓の騎士じゃないのよ<br>あんまり多くを求められても困るわ
	Talk(Actor006,"NPCNAME_0146","speech","L","EA_004_0220050")

	change_face(Actor003,"Anger")

	--★★エクセリア★★:…！
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:キミの作戦が最適解だってことは<br>ぼくだって否定はしないよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220052")

	PlayAction(Actor002,"to  Std_Talk")

	--★★パーシヴァル★★:だけどチームの実態に即していない<br>そんなものは机上の空論でしかないよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220053")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0013")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エクセリア★★:…最適解だということが分かっているのに<br>それを目指さないというのね
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220054")

-- ▼直接出力
PlayPartVoice("リリアーナ","悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★リリアーナ★★:エクセリア、そのくらいに――
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","EA_004_0220056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:あなたたち、そんな甘い考えで<br>これからを戦い抜いていけると思うの？
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220057")

	PlayAction(Actor003,"to  Std_Talk")

	--★★エクセリア★★:敵がどれだけ強大な相手か<br>忘れたわけではないでしょう
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220058")

	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:それは――…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:落ち着けって<br>ふたりとも少し熱くなり過ぎだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:…ぼくは充分落ち着いているとも<br>その上で、もう付き合えないって言ってるんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220062")


	--★★パーシヴァル★★:これ以上、無理な作戦を強いることは<br>チームのメンバーの士気にもかかわるからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220063")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうは言っても…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220064")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:じゃあノワール、キミが彼女を引き取ればいい<br>そっちのチームの誰かとトレードしようよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220065")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:はぁ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:元々、ぼくはこのクラスの人間じゃないし？<br>あんまり出しゃばるのもよくないよね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220068")

	PlayAction(Actor002,"to  Std_Talk")

	--★★パーシヴァル★★:クラスの代表としてキミが、<ruby=シルバタブラナイツ>銀卓騎士団</ruby>が誇る<br>最適解の戦術を教えてもらうといいさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220069")

-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:また、そういう言いかたをして…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ俺は構わないけど<br>エクセリアはどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220071")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:別に私は構わないわ<br>やるべきことは変わらないから
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220072")

-- ▼直接出力
se_play("SE_ADV_MA_01C111_20_Bell")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:決まりだね、決まり！<br>じゃあこの話は終了！皆、教室に戻ろう！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","EA_004_0220075")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","肯定")
-- ▲直接出力

	--★★男子生徒A★★:あー、授業終了～！やっと休める
	Talk(Actor005,"NPCNAME_0151","speech","L","EA_004_0220076")

-- ▼直接出力
PlayPartVoice("女子1","落胆")
-- ▲直接出力

	--★★女子生徒A★★:もうクタクタだよ～
	Talk(Actor006,"NPCNAME_0146","speech","L","EA_004_0220077")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.3)
PlayActionDirect(Actor005,"to Wlk")
wait_time(0.3)
PlayActionDirect(Actor006,"to Wlk")
wait_time(1.9)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
Hide(Actor002)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
turn_chara(Actor001,13,0)
turn_chara(Actor003,225,0)
turn_chara(Actor004,37,0)
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor003,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ったくもう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220079")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ","挨拶")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★リリアーナ★★:ノワール、いいんですか？<br>学園祭の出し物の話をするんじゃ…
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","EA_004_0220081")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…あ！しまった、そうだった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220083")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ、次でいいか。そうやって後回しにしてって<br>またランスロットに言われそうだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220085")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayPartVoice("エクセリア","落胆")
-- ▲直接出力

	--★★エクセリア★★:…本当に、なんの準備も進んでないのね
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220086")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:エクセリア、どうかしたか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220088")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:さっきの話だけど、たしかにノワールと<br>一緒のチームのほうがいいかもしれない
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220089")

-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220090")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力

	--★★エクセリア★★:次からよろしくね、ノワール
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0220091")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor003,"to Wlk")
wait_time(0.3)
PlayActionDirect(Actor004,"to Wlk")
wait_time(2.2)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
Hide(Actor003)
Hide(Actor004)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…また、なんか面倒なことになったかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220093")

-- ▼直接出力
IN_WALK(Actor008,CharaPosDuelCommonFormation01_002)
turn_lookat(Actor001,Actor008,0)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アダン","肯定2")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★アダン★★:エクセリアがお騒がせしてしまったようですね<br>申し訳ありません
	Talk(Actor008,"CHRNAME_ADAM","speech","L","EA_004_0220095")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あぁ、気にしないでください<br>そんな大したことじゃありませんから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0220096")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","肯定")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★アダン★★:彼女は騎士としても軍師としても<br>確かに優れていた資質を持っています
	Talk(Actor008,"CHRNAME_ADAM","speech","L","EA_004_0220097")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★アダン★★:ですが…どうしてもこういった<br>集団生活にあまり馴染みがないようで…
	Talk(Actor008,"CHRNAME_ADAM","speech","L","EA_004_0220098")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","悩む")
-- ▲直接出力

	--★★アダン★★:…さて、どうしたものか
	Talk(Actor008,"CHRNAME_ADAM","speech","L","EA_004_0220099")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101054","005","101054005","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
