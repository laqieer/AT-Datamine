-- このluaスクリプトは、CO_101030_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",120,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
turn_chara(Actor002,175,0)
turn_chara(Actor003,-55,0)
set_pos(Actor001, {-1.5,0.128,22.4})
set_pos(Actor002, {-0.48,0.12,24})
set_pos(Actor003, {1.1,0.128,20})
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
tegami = setup_prop_object(10106003)
off_active(tegami)
tegami_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
tegami_offset2 = {0,0,0,0,0,0}
off_active(tegami2)
off_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Sit10")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_default(Actor001, 1)
keep_ik_lookat(Actor001, Actor001, "J_Foot_R")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
on_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
on_active(tegami2)
-- ▲直接出力
	PlayAction(Actor001,"to ReadLetter")
-- ▼直接出力
lookat_weight_reset( Actor001)
setup_small_camera_start(Camera001)
se_play("SE_ADV_MA_01105_28_Paper")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:手紙か？<br>…「エレインお姉ちゃんへ」？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010002")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{-0.48,0.12,22},1.3)
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,-85,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,1)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩<br>このあたりに手紙が落ちていませんでしたか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:これのこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010005")

-- ▼直接出力
setup_small_camera_start(Camera002)
off_parent(tegami2)
off_active(tegami2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:あっ！それです！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010006")

-- ▼直接出力
Appear(Actor003)
-- ▲直接出力

	--★★エレイン★★:ロンディニウムの子供たちからもらったんですが学園に戻ってくる途中に落としてしまったようで
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010007")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:よかったぁ…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010009")

-- ▼直接出力
setup_small_camera_start(Camera001)
change_face(Actor002,"Normal")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あのさロンディニウムの子供たちって…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010010")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{-0.6,0.128,20.8},1.3)
wait_time(1.3)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.8,0.5,0.8,1)
set_enable_auto_lookat(Actor003, true)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.8,0.8,0.8,1)
set_enable_auto_lookat(Actor003, true)
wait_time(0.1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:先日の戦いで親とはぐれたり行き場を失った子供たちです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010012")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0017_1")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラヴェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010013")

-- ▼直接出力
setup_small_camera_start(Camera003)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0007")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:ローマの軍勢やバルバロイによってロンディニウムは建物の多くが破壊され
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010015")


	--★★ラヴェイン★★:数えきれないほどの死傷者や行方不明者が出ました
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010016")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ラヴェイン★★:なにを悼んでいいのかわからず泣くこともできぬ遺族も多数いるようです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010017")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラヴェイン", "落胆")
-- ▲直接出力

	--★★ラヴェイン★★:大勢の方があの事件はルーシャスが引き起こしたものと理解してくれていますが
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010019")


	--★★ラヴェイン★★:ロンディニウムが戦場となったことで
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010020")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラヴェイン★★:ログレスのやっていることを快く思わない市民も増えています
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010021")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そうなるよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:私とエレインは交換留学生としてローマに滞在していたことがありますから
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010023")


	--★★ラヴェイン★★:あの国の素晴らしさは知っています
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010024")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:ログレスとローマとの友好関係を途切れさせてはならない
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010025")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラヴェイン★★:そこで生徒会の仕事の一環として街の復興作業を手伝いながら
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010026")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:少しでも両国の関係修復につとめているんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010027")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そこで出会った子供たちから手紙をもらったわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010028")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
on_parent(tegami,Actor002, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(0.7)
-- ▲直接出力

	--★★エレイン★★:「エレインお姉ちゃんいつも遊んでくれてありがとう」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010030")


	--★★エレイン★★:「大人の人たちのなかにはログレスのことを悪く言う人もいるけど」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010031")


	--★★エレイン★★:「ぼくたちは円卓の騎士が悪いことするわけないって信じてます」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010033")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
SkipDefaultMotion(Actor002)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:子供たちのためにも、円卓の騎士が正義の味方だって証明してあげないと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010035")

	open_select_window_tag(Actor001,"Normal","CO_101030_01010037","CO_101030_01010038","CO_101030_01010039")
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
setup_small_camera_start(Camera001)
off_parent(tegami)
off_active(tegami)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0016_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの、さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010041")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ロンディニウムの復興作業俺にも協力させてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010042")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:先輩も？でも、お忙しいのではないですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺も円卓の騎士が正義の味方だって子供たちに証明したいんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010044")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:子供たち、喜ぶと思いますよ本物の円卓の騎士が来てくれたら
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010045")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
off_parent(tegami)
off_active(tegami)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その作業ってふたりだけでやってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:手が空いているときは生徒会のメンバーも手伝ってくれています
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そっか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010049")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:よかったら俺にも手伝わせてくれないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010051")

-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:先輩が！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010052")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:もちろん大歓迎ですよ、ノワール君
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010053")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
off_parent(tegami)
off_active(tegami)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
setup_small_camera_end(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか、頑張ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010055")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0001")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:せ、先輩っ！あ、あの、あのあの…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010056")

-- ▼直接出力
voice_play("VO_101031_sp_0001_1")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラヴェイン★★:ノワール君手の空いているときで構わないのですが
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010057")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラヴェイン★★:私やエレインと一緒にロンディニウム復興を手伝ってくれませんか？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010058")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010059")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:うん、それもいいかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010061")

	goto Block1end

::Block1end::
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0036")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:ありがとうございます<br>妹も喜びます
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010063")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,-170,0)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エレインが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010064")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
voice_play("VO_101030_sp_0002_2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:ちょ、ちょっとお兄ちゃん！余計なこと言わないで！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010065")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
SkipDefaultMotion(Actor002)
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-85,0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0001")
-- ▲直接出力

	--★★エレイン★★:先輩、お兄ちゃんの言ったこと真に受けないでくださいね！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010066")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんのことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_01010067")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力

	--★★ラヴェイン★★:ふふっ<br>なんのことでしょうね？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010068")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラヴェイン★★:さて
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010069")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101031_sp_0001_1")
-- ▲直接出力

	--★★ラヴェイン★★:今後、ロンディニウムに向かうさいは妹からノワールくんに連絡させるようにします
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","CO_101030_01010070")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0042")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:これからよろしくお願いしますね先輩！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_01010071")

-- ▼直接出力
local trustParam = set_communication_acquired("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
