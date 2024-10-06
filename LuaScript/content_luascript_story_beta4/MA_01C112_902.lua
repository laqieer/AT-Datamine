-- このluaスクリプトは、MA_01C112_902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
Include("content_adv_advsmall_114011_02","114011_02_h")
Include("content_adv_advsmall_114011_02","Template114011_02_h")
-- ▼直接出力
Include("content_adv_advsmall_114011_02","114011_02_h")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_007)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
Hide(Actor002)
Hide(Actor004)
Hide(Actor006)
Hide(Actor007)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
set_pos(Ef_0001,CharaPos114011_02_015)
set_pos(Actor007,CharaPos114011_02_015)
set_rot(Actor007,{0,CharaPos114011_02_015[4],0}) 
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114011_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114011_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_015)
	InitializeTemplateRandomCamera114011_02()
	InitializeTemplate114011_02()
-- ▼直接出力
Hide(Actor003)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
set_pos(Ef_0001,CharaPos114011_02_015)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
DontCameraOffset(Actor003)
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:街の中心部にさしたる影響はないようだが…
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_9020002")


	--★★ルーシャス★★:余はここで別れる<br>城に行って被害状況を確認したいのでな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_9020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_chara( Actor003, 148, 0.6)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、おい、ちょっと！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_9020004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
se_play("SE_ADV_MA_01B112_12_Foot")
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor004)
Appear(Actor002)
setup_small_camera_start()

fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まったく、どいつもこいつも自分勝手すぎる…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_9020005")

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
DontCameraOffset(Actor002)
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:オイ。「どいつ」と「こいつ」ってのは<br>誰と誰のことを言ってんだ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_9020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:えっ？あ、いや…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_9020007")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クラリス", "肯定")
-- ▲直接出力

	--★★クラリス★★:「どいつ」がモルくんで<br>「こいつ」が皇太子殿下だと、わたしは思います
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_9020008")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:わかってても答えなくていいんだよ<br>こういうときは！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_9020009")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:は、はは…<br>（当然自覚はあるわけだな）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_9020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.3)
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:魔女たちの気配はない、な
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_060002")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★モルドレッド★★:だが、あちこちに襲撃の跡が残ってる<br>ひと暴れしたのは間違いねえな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_060003")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("クラリス", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:魔女って、ハロウィンで<br>かなりパワーアップしてましたよねえ…
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_060004")

	change_face(Actor004,"Normal")

	--★★クラリス★★:いくらランスロットさんが強いとはいえ<br>３人だけで大丈夫だったんでしょうか…
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_060005")

-- ▼直接出力
CloseTalkWindow()
lookat_weight(Actor006, 1.0, 0.3, 0.6, 0.5)
set_common_look_at(Actor006,Actor001)
EntryWalk(Actor006,Camera006,EntryData114011_01_06,CameraAssetBundleName114011_01,CameraPos114011_01_106)
-- ▲直接出力
-- ▼直接出力
lookat_weight_default(Actor005)
keep_ik_lookat(Actor005,Actor006,"J_Head")
lookat_weight_default(Actor004)
keep_ik_lookat(Actor004,Actor006,"J_Head")
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★マルイル★★:あ、ノワールさん！
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:マルイル！どうしてここに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_060008")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★マルイル★★:たまたま仕入れでこっちに来てまして<br>これからログレスに戻るつもりだったんです
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060009")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ディナタン★★:もしかして、襲撃のときにも…？
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01C112_060010")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★マルイル★★:はい…４人の魔女が突然現れて<br>いきなり、街を襲ったんです
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マルイル", "悲しみ")
-- ▲直接出力

	--★★マルイル★★:ぼくはなんとか隠れることができたんですが<br>あいつら、ロンディニウムの人たちを次々に…
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060012")

-- ▼直接出力
 --PlayPartVoice("クラリス", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:そう…だったんですか
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_060013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★マルイル★★:それから円卓の騎士が救援にきてくれたんですが<br>魔女の勢いに押されている様子で
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060014")

	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ディナタン★★:ハロウィンで魔女の力が増大してたから…
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01C112_060015")

-- ▼直接出力
 --PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★マルイル★★:けど、そこにアーサー王が現れて…<br>魔女たちをみんなまとめて退けたんです！
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060016")

-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:魔女たちを退けた？<br>アーサーが？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C112_060017")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(true)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:はい！<br>あ、あとガウェインさんもいたような…
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060018")

	open_select_window_tag(Actor001,"Normal","MA_01C112_060019","MA_01C112_060020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("クラリス", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:それって…アーサー様が助けてくれた…<br>ってことでしょうか？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_060022")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:やっぱり…<br>アーサーは俺たちの味方ってことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_060023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:てめえら、本気で言ってんのか？<br>だとしたら、相当なお花畑だぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_060024")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:うう…ごめんなさい、モルくん…
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_060025")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:別に、てめえにキレてるわけじゃねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_060026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どっちにしろ、わからないことが多すぎる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_060027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…アーサーと円卓の騎士たちは<br>ともに魔女と戦っていたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_060029")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★マルイル★★:いえ…アーサー様はみんなのほうを見向きもせず<br>騎士様たちも警戒しているような様子でした
	Talk(Actor006,"CHRNAME_MARIL","speech","L","MA_01C112_060030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ディナタン★★:兄さん、どういうことなんだろう…？
	Talk(Actor005,"CHRNAME_DINATAN","speech","L","MA_01C112_060031")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーがランスロットたちを助けた…<br>というわけではないのかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_060032")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
setup_small_camera_start(RndCamera003)
on_active(Ef_0001)
Appear(Actor007)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor005)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor004)
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat( Actor001,Actor007, 0.3)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat( Actor002,Actor007, 0.3)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat( Actor004,Actor007, 0.3)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat( Actor005,Actor007, 0.3)
PlayActionDirect(Actor006,"to Wlk")
turn_lookat( Actor006,Actor007, 0.3)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Serious2")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("クラリス", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor004,"Surprise")

	--★★クラリス★★:ま、魔女…！
	Talk(Actor004,"CHRNAME_CLARICE","speech","N","MA_01C112_060034")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
setup_small_camera_start(RndCamera001)
se_play("SE_ADV_MA_01C112_902_Scream")
wait_time(3.5)
SwitchMob(false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	open_cutin(1,1)
	on_cutin(1,Actor001,"Anger")
	on_cutin(2,Actor001,"Anger")

	--★★ノワール★★:なんだ…なんだか、様子がおかしい
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C112_060036")

	close_cutin()
-- ▼直接出力
off_active(Ef_0001)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力

	--★★グリートーネア★★:継承者…ああ…
	Talk(Actor007,"CHRNAME_SISTERS_4","speech","R","MA_01C112_060037")


	--★★グリートーネア★★:全部、ぜんぶ、ゼンブ、あなたのせい<br>あなたのせいで、もうめちゃくちゃ
	Talk(Actor007,"CHRNAME_SISTERS_4","speech","R","MA_01C112_060038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:…来るぞ！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_060039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
preload_sound("BGM_ADV_Reconnaissance")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
preload_sound("BGM_ADV_Serious2")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest(CameraAssetBundleName114011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
