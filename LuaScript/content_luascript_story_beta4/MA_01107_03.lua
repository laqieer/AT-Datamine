-- このluaスクリプトは、MA_01107_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_01","113021_01_h")
Include("content_adv_advsmall_113021_01","Template113021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-20,CharaPos113021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_005)
	Camera002 = SetTemplate("Actor002",10,CharaPos113021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_008)
	Camera003 = SetTemplate("Actor003",-40,CharaPos113021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos113021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos113021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_006)
	InitializeTemplateRandomCamera113021_01()
	InitializeTemplate113021_01()
-- ▼直接出力
set_pos(Actor002,{-0.2,0,2.8})
set_pos(Actor005,{-0.9,0,3.8})
change_face(Actor001,"Sad")
change_face(Actor003,"Sad")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight(Actor001,0.8, 0.03, 0.7, 0)
lookat_weight(Actor003,0.8, 0.03, 0.7, 0)
lookat_weight(Actor005,0.8, 0.03, 0.7, 0)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
keep_ik_lookat(Actor005,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor004,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:キズの調子は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030002")


	--★★ブライアン将軍★★:どのキズのハナシだ？
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？<br>どのキズの、って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★ブライアン将軍★★:傭兵ひとりごときに勢ぞろいとは<br>随分丁重だ
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030007")

	PlayAction(Actor002,"to Bow")
-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力

	--★★ランスロット★★:お初にお目にかかる『不格好なコート』現団長、ブライアン
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_030009")

-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ブライアン将軍★★:…ノワールのオヤジの仇円卓の騎士ランスロット──…
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…ブライアン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030013")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ブライアン将軍★★:オレも殺すかい処刑の日取りが決まったとか？
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030014")


	--★★ランスロット★★:なぜそう死に急ぐ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_030015")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ブライアン将軍★★:袋小路だからさ
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030016")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
set_rot(Actor001,{0,-80,0})
set_rot(Actor003,{0,-80,0})
-- ▲直接出力

	--★★ランスロット★★:命を両替したんじゃなかったのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_030017")

-- ▼直接出力
setup_small_camera_start()
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Surp")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor004,"Surprise")

	--★★ブライアン将軍★★:…ッ！？おめえ、どうして…
	Talk(Actor004,"CHRNAME_BRIAN","speech","N","MA_01107_030019")

	close_cutin()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロット…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030020")

	change_face(Actor005,"Sad")

	--★★アーサー★★:…ランス、話が見えんぞ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030021")


	--★★ランスロット★★:あの人から預かった願いを果たさず…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_030022")

	PlayAction(Actor004,"to  Std_Angry")
	change_face(Actor004,"Anger")

	--★★ブライアン将軍★★:おめえ、なにをどこまで知ってやがる…！<br>ブルーノを殺した野郎が言えたクチかァッ…！？
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Surprise","MA_01107_030026","MA_01107_030027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,-20,0.3)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",0.8)
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ブライアンやめろ…！傷が開くから…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030029")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Anger")

	--★★ブライアン将軍★★:うるせぇ！少し黙ってろ
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030030")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
lookat_delay_weight_reset(Actor005,1)
set_rot(Actor003,{0,-40,0})
lookat_delay_weight_reset(Actor004,1)
-- ▲直接出力
	change_face(Actor004,"Pain")

	--★★ブライアン将軍★★:俺とブルーノしか<br>知らねえはずだ…！
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロット、どういうことだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030033")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_030034")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1)
lookat_delay_weight_reset(Actor005,1)
set_rot(Actor001,{0,-20,0})
set_rot(Actor003,{0,-40,0})
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ブライアン将軍★★:知ったような涼しい口ぶりで<br>ブルーノを語りやがって…！
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030035")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1)
PlayActionDirect(Actor004,"to  Std_Angry")
turn_chara(Actor004,-160,0.3)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ブライアン将軍★★:可愛い<ruby=おとうとでし>弟弟子</ruby>のキモチ裏切って<br>よく涼しいカオしてられるなあっ！？
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…お互い様だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_030039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to Bow")
-- ▼直接出力
change_face(Actor001,"Normal")
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:…失礼した、ブライアン腹を割って話そう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030041")


	--★★アーサー★★:カレドニア王ライエンス陛下は息災か？
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030042")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★ブライアン将軍★★:…イチ傭兵が知ってる話だと思うか？
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030043")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:傭兵の雇用が成立しているということはその雇い主…ライエンス王は今も健在、だな？
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030044")

-- ▼直接出力
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Worry")
-- ▲直接出力

	--★★アーサー★★:となればカレドニア軍はバルバロイに蹂躙された…というよりは共生関係を取っている状態か
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030045")


	--★★アーサー★★:もしくはバルバロイがなんらかの目的でカレドニア軍を生かし続けているだけか…
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ブライアン将軍★★:…食えねえヤツ
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030047")


	--★★アーサー★★:だがそうなるともはや本当の意味でライエンス王はご健在なのか
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030048")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:貴方なら知っているはずだ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
	change_face(Actor004,"Anger")

	--★★ブライアン将軍★★:いつから魔女どもが入り込んでいたのかは気づかなかったが
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030052")


	--★★ブライアン将軍★★:ほんの少し前からライエンスの横に張り付いて化け物どもを操り始め、相当数に膨れ上がってる
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030053")


	--★★ブライアン将軍★★:化け物どもはカレドニア兵やオレみてえなやつにある程度は従うようコントロールされてるらしい
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:増え続けるバルバロイを魔女が操っている…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_030056")


	--★★ブライアン将軍★★:…アーサー王、聞かせてくれや魔女ってのはなんなんだ…？
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030057")

-- ▼直接出力
change_face(Actor001,"Normal")
change_face(Actor003,"Normal")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★アーサー★★:…バルバロイを産み増やす根源円卓の騎士が叩くべき相手、許されざる敵だ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ブライアン将軍★★:…要はなんだかわかんねえ<br>ってことだな？
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030059")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Smile")

	--★★アーサー★★:気が合うじゃないかそう言おうと思っていたんだよお
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030060")

	change_face(Actor005,"Normal")

	--★★アーサー★★:こんな状況でもなければノワールの客人としてグルメツアーの案内でもしたいところだが
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030061")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ブライアン将軍★★:…敵だろ、オレとアンタらも
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030062")

	PlayAction(Actor005,"to  Std_Worry")

	--★★アーサー★★:ログレスが誇る大マーケットの屋台料理を…特にB級グルメを一度でも口にしたら──
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
lookat_weight(Actor002,0.8, 0.03, 0.7, 0)
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★アーサー★★:………ホラぁ、食べたくなってきたぁ<br>食べるしかないテンションになってきたぁ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030065")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1.5)
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",1)
change_face(Actor001,"Surprise")
change_face(Actor003,"Surprise")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:あ、アーサー？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01107_030066")

	PlayAction(Actor005,"to  Std_Angry")

	--★★アーサー★★:ということで今日すぐ食べに行くこととする！羨ましいか、ブライアン！
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030067")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ブライアン将軍★★:………うらやましいよ。王サマ
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030069")


	--★★アーサー★★:今度ご馳走するよ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01107_030071")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor005)
Hide(Actor002)
set_rot(Actor001,{0,-20,0})
set_rot(Actor003,{0,-40,0})
set_rot(Actor004,{0,170,0})
lookat_delay_weight_reset(Actor001,1)
lookat_delay_weight_reset(Actor003,1)
lookat_delay_weight_reset(Actor004,1)
set_enable_auto_lookat_all(false)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ブライアン将軍★★:バルバロイは今も人間を喰らい続けてる<br>オレはその片棒を担いだ。自らの意志でな
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030073")

	change_face(Actor004,"Sad")

	--★★ブライアン将軍★★:『戦い』だから仕様がねえ…<br>と言やあそうなのかもしれねえ、が
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030074")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力

	--★★ブライアン将軍★★:化け物に魂売ったオレを許せるほど<br>学生諸君は寛容じゃねえだろう
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030075")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ブライアンさんさえ良ければ…<br>私たちは………っ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01107_030076")

	PlayAction(Actor004,"to  Std_No")

	--★★ブライアン将軍★★:オレに肩入れすればするほど<br>学園でのおめえらの立場は悪くなる一方だ
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030077")

	change_face(Actor004,"Normal")

	--★★ブライアン将軍★★:…せっかく馴染み始めたところじゃねえのか？<br>オレなんかに構って台無しにすんな
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030079")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ブライアン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030081")


	--★★ブライアン将軍★★:なんだよ
	Talk(Actor004,"CHRNAME_BRIAN","speech","R","MA_01107_030083")

	change_face(Actor001,"Smile")

	--★★ノワール★★:生きててよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_030084")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
