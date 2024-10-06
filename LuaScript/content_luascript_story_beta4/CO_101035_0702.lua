-- このluaスクリプトは、CO_101035_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-50,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
prop001=setup_prop_object(10112001)
set_pos(prop001,{-1.15,-0.08,0.48})
set_rot(prop001,{0,100,0})
prop002= set_object("content_weapon_101016001", "weapon_model_101016001", true)
set_pos(prop002,{-2.24,0.85,0.26})
set_rot(prop002,{70,-45,0})
prop003=setup_prop_object(10201019)
set_pos(prop003,{-1.8,0,1.1})
prop004=setup_prop_object(30101001)
set_pos(prop004,{-2,0,0})
set_enable_auto_lookat_all(false)
set_common_look_at(Actor001,Actor004)
set_common_look_at(Actor002,Actor004)
set_common_look_at(Actor003,Actor004)
-- ▲直接出力
-- ▼直接出力
CameraEx = set_camera({0.47, 1.282, 1.023,   5.53693, 249.2057, 0,   28.22622})
CameraEx2 = set_camera({2.766, 1.82, 0.293,  18.155, 122.952, 0,   28.22622})
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEx2 = 2.5
gaussian_end_CameraEx2 = 5
gaussian_max_radius_CameraEx2 =1.5
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:起き上がって食事ができるくらいにはなりましたね。よかった…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:もう少しすれば足のケガも治るでしょう頑張ったわね、リリアーナ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020003")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:足をケガしていたから剣と鞘を杖代わりに歩いていたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:そうそれが奇妙な形状の足跡の正体だったわけよ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020006")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:その体じゃ大したことはできないだろうけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:妙な気は起こすなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020010")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Surp")
turn_chara(Actor002,-100,0.3)
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:ノワールさん…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020011")

-- ▼直接出力
setup_small_camera_start(CameraEx)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,-80,0.5)
PlayPartVoice("市民_男2", "否定")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:元気な身体だったとしてもログレスの方たちと争おうなんてしませんよ
	Talk(Actor004,"NPCNAME_0258","speech","N","CO_101035_07020012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:あらためてお礼を言わせてくださいありがとう、リリアーナ嬢と学友のみなさん
	Talk(Actor004,"NPCNAME_0258","speech","N","CO_101035_07020013")

-- ▼直接出力
--東方諸国連合軍兵_下位,NPCNAME_0250 @名前変更
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:私はマルコと言います<br>見てのとおりカレドニアの兵士です
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020014")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "落胆")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:いえ、今となっては兵士だった、というのが正しいのかも
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020015")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:だった、というのはどういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020016")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "悲しみ")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:私など死んだほうがよかったんです…
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020017")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:訳ありのようだし、話を聞いてみましょう
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:マルコさん喋りたくないのなら無理に喋らなくても…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020019")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:ライエンス王がお亡くなりになられたあとカレドニア兵の大半はローマに取り込まれました
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020021")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★東方諸国連合軍兵_下位★★:私が所属していた部隊もその例に漏れずでした
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020022")


	--★★東方諸国連合軍兵_下位★★:あるとき、私の部隊は上からの命を受けこの森で作戦に従事していました
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020023")


	--★★東方諸国連合軍兵_下位★★:軍の秘密を知った人間が森に逃げ込んだので<br>それを捕まえて処分しろとのことでした
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020024")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★東方諸国連合軍兵_下位★★:ところがそこに突如としてバルバロイが現れて…私たちの部隊に襲い掛かってきたのです
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:バルバロイが…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020027")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:ふつうの武器で<br>バルバロイを倒せないことは知っています
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020028")


	--★★東方諸国連合軍兵_下位★★:でも仲間の兵士たちは死に物狂いで戦いましたなんとかバルバロイを退かせ、生き延びるために
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020029")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "悲しみ")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:でも私は…私は…
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020030")


	--★★東方諸国連合軍兵_下位★★:そんな仲間たちを見棄ててひとり逃げ出してしまったんです
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020031")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "納得")
-- ▲直接出力

	--★★クレア★★:そのあと、戦いで負ったキズが原因で動けなくなったところを私たちが見つけたのね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020032")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:私は臆病者です。兵士失格です生き延びたとて、もはや軍には戻れない
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020034")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "落胆")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:こうして恥じるくらいなら…後悔するくらいなら<br>死んでおけばよかったんだ
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020035")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:こうして私たちが出会えたのもきっと神様のお導きです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020037")


	--★★リリアーナ★★:神様はまだあなたに生きろと仰っているんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020038")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:だから、死んだほうが良かったなんて<br>言わないでください
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020039")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "否定")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:私が仲間を見棄てたのは事実ですいや…仲間だけじゃない
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020040")


	--★★東方諸国連合軍兵_下位★★:カレドニア軍人としての誇りを祖国を見棄てたようなものだ
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あのさひとつ気になっていたんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020042")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あんたはバルバロイに<br>やられたわけじゃないんだよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020043")

-- ▼直接出力
PlayPartVoice("市民_男2", "納得")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:私はバルバロイと一緒にいた<br>人間にやられました
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:バルバロイと一緒にいた人間だって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020045")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:腕に妙な紋章を刻んだ男でした３本の槍が交差したような紋章です
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020046")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Joy")
lookat_weight(Actor001,0.7,0.03,0.7,0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:…！！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020048")

	change_face(Actor003,"Surprise")

	--★★クレア★★:…！？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020049")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★リリアーナ★★:３本の槍の紋章…そんな…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020051")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力

	--★★ノワール★★:リリアーナ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020052")

-- ▼直接出力
set_enable_auto_lookat_all(true)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★リリアーナ★★:あ、ああ、あああ……っ！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_07020056","CO_101035_07020057")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,-10,0.3)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:突然どうしたんだリリアーナ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020059")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:落ち着け、落ち着くんだ大丈夫、みんながそばにいるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020060")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
reserve_eyesync(Actor002,"Close")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:うぅっ…ぐすっ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020061")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにがあっても俺が守ってやるだから安心していい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020062")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{0.8,0,-0.15},1)
turn_chara(Actor001,65,1)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
wait_time(0.6)
setup_small_camera_start(RndCamera006)
wait_time(0.2)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Angry")
wait_time(0.2)
se_play("SE_ADV_CO_101035_0702_Hug")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナ、落ち着いて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020064")

	change_face(Actor002,"Sad")

	--★★リリアーナ★★:わ、私…うぅっ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020065")

	change_face(Actor001,"Normal")

	--★★ノワール★★:大丈夫だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020066")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
reserve_eyesync(Actor002,"Close")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:うっ…ぐすっ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020067")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to  Std_Sad01")
set_pos(Actor003,{4.58,0,-0.82})
set_rot(Actor003,{0,-85,0})
PlayActionDirect(Actor003,"to Std_Loop")
change_face(Actor002,"Shy")
change_face(Actor003,"Normal")
set_common_look_at(Actor003,Actor002)
Camera001=setup_small_camera_resetting(Actor001,CharaPos003,CameraPos003)
set_rot(Actor001,{0,0,0})
set_common_look_at(Actor002,Actor001)
setup_small_camera_start(RndCamera003)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
reserve_eyesync(Actor002,"Auto")
lookat_delay_weight(Actor002, {0.7, 0.03, 0.6, 0.2} , 0.8)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:ありがとうございます、ノワールさんもう…大丈夫です
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020069")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("市民_男2", "照れ")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:すみませんなにか変なことを言ってしまったようで
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020070")

-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to  Std_No")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:いえ…大丈夫です…なんでも、ないですから…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_07020071")

-- ▼直接出力
setup_small_camera_start(CameraEx2)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEx2)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEx2)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEx2)
on_active(FX_DoF)
slidemove2(CameraEx2,2.785, 1.89, 0.281,12,2)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:３本の槍の紋章…バルバロイを信奉し
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020073")


	--★★クレア★★:伝承に遺る『聖槍』を手中に収めようとする邪教徒たちの紋章
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020074")


	--★★クレア★★:彼らは生贄を捧げバルバロイの力を得るとされる
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020075")

	change_face(Actor003,"Surprise")

	--★★クレア★★:リリアーナのあの怯えよう…まさか…？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020076")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
off_active(FX_DoF)
lookat_delay_weight_reset(Actor001 , 0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat( Actor001,Actor003, 0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020078")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★クレア★★:なんでもないわ少し考えごとをしていただけ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_07020079")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat( Actor001,Actor004, 0.5)
wait_time(0.5)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
PlayActionDirect(Actor001,"to  Std_Talk")
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:マルコさん、ふたりを落ち着かせたい<br>今日はこのへんで引き揚げさせてもらう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_07020080")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "納得")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:はい、私のことなら心配いりませんお気をつけて
	Talk(Actor004,"NPCNAME_0250","speech","N","CO_101035_07020081")

-- ▼直接出力
local trustParam = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")
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
setup_prop_object_preload(10112001)
set_object_preload("content_weapon_101016001", "weapon_model_101016001", true)
setup_prop_object_preload(10201019)
setup_prop_object_preload(30101001)
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
