-- このluaスクリプトは、EA_003_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",335,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera008 = SetTemplate("Actor008",275,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera009 = SetTemplate("Actor009",150,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera010 = SetTemplate("Actor010",0.554,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera011 = SetTemplate("Actor011",9.11,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{0.085,0,-2.16})
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor009, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor010,{0.755,0,-12.545})
set_pos(Actor011,{-1.026,0,-10.836})
Hide(Actor010)
Hide(Actor011)
local barubaroi_EfPos = get_pos(Actor010)
local barubaroi2_EfPos = get_pos(Actor011)
Ef_Portal_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
Ef_Portal_Enemy_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
set_pos(Ef_Portal_Enemy,{0.76,0,-12.02})
set_pos(Ef_Portal_Enemy_2,{-0.94,0,-10.3})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-0.97, 2.08, -5.32,   10.93172, 172.508, 0.00331,   25})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({0.977, 1.784, -0.313,   13.33801, 313.2, 0,   28})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invation3")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor011")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ルーシャス★★:まだ着かないのかもうずっと歩きどおしだぞ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0510002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:もう少しがんばってくれよまだ先だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510003")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス","怒り")
-- ▲直接出力

	--★★ルーシャス★★:そなたの故郷はずいぶんと僻地にあるのだなこのローマ皇太子をここまで歩かせるとは
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0510004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:す、すみませんルーシャス様
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510005")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント","否定")
-- ▲直接出力

	--★★マルディサント★★:ディーナが謝る必要ねーっての
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_003_0510006")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","肯定3")
-- ▲直接出力

	--★★トリスタン★★:そうだよ。そもそも行きたいと言い出したのは皇太子さまだからね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","EA_003_0510007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:そう。そしてローマの力を借りたいと言い出したのはそなたらだ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0510008")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス","肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:その交換条件としてルーシャス様はノワールの故郷を見ることを望まれ…
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","EA_003_0510009")


	--★★ヴェルナルス★★:そしてお前たちは条件を飲んだ
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","EA_003_0510010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor007,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力

	--★★ルーシャス★★:その条件自体、だいぶ譲歩してやったぞそうだろう最強騎士殿
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0510011")

-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力

	--★★ランスロット★★:………
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_003_0510012")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","落胆")
-- ▲直接出力

	--★★トリスタン★★:権力者の遊戯に付き合わされるほうはたまったものじゃないね
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","EA_003_0510013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力

	--★★イゾルデ★★:同感だわ
	Talk(Actor008,"CHRNAME_ISOLDE","speech","L","EA_003_0510014")

-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ま、まぁ皆、がんばろう。もう少しだから！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510015")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:そ、そうだね、兄さん！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510016")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（い、いたたまれない…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_003_0510018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_003_0510020","EA_003_0510021","EA_003_0510022")
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
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",0.9)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…なんか、悪いな。付き合わせて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510024")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★トリスタン★★:本当だよ。このタイミングで里帰りとかそのうえ、行先がカレドニアとか
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","EA_003_0510025")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ","落胆")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★イゾルデ★★:監視対象がアクティブだと苦労するわね
	Talk(Actor008,"CHRNAME_ISOLDE","speech","L","EA_003_0510026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、俺が望んだわけじゃないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor007,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor007,"J_Head",0.9)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なぁ、ランスロットあんたはロジーの里を知っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510029")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ランスロット★★:あぁ、何度か様子を見に来ていたからな
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_003_0510030")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:様子を見に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510031")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510033")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ランスロット★★:話はあとでゆっくりするとしよう…今は、先を急ごう
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","EA_003_0510034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、あぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510035")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-22,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン、平気か？疲れたら言えよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:大丈夫。これでも私、傭兵団にいたんだから体力はあるんだよ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510038")

-- ▼直接出力
PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、それは知ってるけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510039")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン","肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:私のことを気にするより他の人たちを気にかけてあげて
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510040")

	change_face(Actor003,"Smile")

	--★★ディナタン★★:ね、兄さん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510041")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント","悩む")
-- ▲直接出力

	--★★マルディサント★★:ったく、マジで空気最悪だな～大丈夫かよ、オニーサン
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_003_0510043")

-- ▼直接出力
set_enable_auto_lookat(Actor009, true)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっとくじけそうかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510044")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（とりあえず今は、先を急ぐしかない…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_003_0510045")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor005, false)
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング","肯定3")
-- ▲直接出力
	change_face(Actor009,"Laugh")

	--★★ティルフィング★★:…この辺りは空気が綺麗ですねなんだか、心が洗われる気がします
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510047")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:田舎だからね～里の近くまで行けばまた少し雰囲気も変わるけど
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510048")

-- ▼直接出力
keep_delay_ik_lookat(Actor009,Actor001,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング","挨拶")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ティルフィング★★:マスターロジーの里はどんなところなんですか？
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510049")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,10,0.25)
wait_time(0.25)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:穏やかな場所だよ人もそんなに多くないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510050")

-- ▼直接出力
PlayPartVoice("ディナタン","肯定2")
-- ▲直接出力

	--★★ディナタン★★:でも皆、優しかったよね私たちのこと、詮索しないでいてくれて
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510051")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:…そうだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor009,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力

	--★★ディナタン★★:あと里の近くには綺麗な湖があってね私たち、よくそこで水遊びをしてたの
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510053")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:兄さんなんかパンツ一丁で湖に飛び込んだりしてたんですよ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510054")

-- ▼直接出力
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,1.035,1.803,-0.367,6)
-- ▲直接出力
	PlayAction(Actor009,"to  Std_Surp")
	change_face(Actor009,"Surprise")

	--★★ティルフィング★★:あら
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そりゃ、子供だったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510056")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor009,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ディナタン★★:そしたらあるときお母さんが水の底の悪魔の話を聞かせてくれて
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510057")

	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング","驚き")
-- ▲直接出力

	--★★ティルフィング★★:水の底の悪魔？
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510058")

-- ▼直接出力
PlayPartVoice("ディナタン","肯定")
-- ▲直接出力

	--★★ディナタン★★:はい。水のあるところには悪魔がいる…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510059")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:悪魔は深い深い水の底に棲み、人の足を掴んで引きずり込む機会を待っているのよ…って
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510060")


	--★★ティルフィング★★:まぁ…
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510061")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:いま思えば、子供だけで水遊びをしないように脅かしていたんでしょうね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510062")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ディナタン★★:その話を聞いてから兄さん、しばらく湖によりつかなくなっちゃって。ねー、兄さん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510063")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力

	--★★ノワール★★:今は平気だから！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510064")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それに今だったら悪魔がきたらこっちから迎え撃ってやるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510065")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力

	--★★ディナタン★★:兄さん、あんまり調子乗らないの水は怖いんだからね～
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510066")

-- ▼直接出力
PlayPartVoice("ティルフィング","笑い")
-- ▲直接出力
	change_face(Actor009,"Laugh")

	--★★ティルフィング★★:ふふ、微笑ましいですね
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510067")

	PlayAction(Actor009,"to  Std_Talk")
	change_face(Actor009,"Normal")

	--★★ティルフィング★★:…でも、お母様のお話はあながち間違いではないのかもしれません
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510068")

-- ▼直接出力
PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:えっ？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510070")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング","肯定")
-- ▲直接出力

	--★★ティルフィング★★:お母様の仰るように水辺は危険が伴いますから
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510071")

-- ▼直接出力
CameraEx_02 = set_camera({0.977, 1.784, -0.313,   13.33801, 313.2, 0,   28})
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,1.035,1.803,-0.367,6)
-- ▲直接出力
	change_face(Actor009,"Laugh")

	--★★ティルフィング★★:お母様はあなたがたのことをとても大切に想っていたのですね
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510072")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:…うん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_003_0510073")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定２")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえば、ティルフィングは水遊びとかしたことあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0510074")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor009,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ティルフィング","悩む")
-- ▲直接出力
	change_face(Actor009,"Surprise")

	--★★ティルフィング★★:水遊び、ですかそうですね…水浴びくらいなら――…
	Talk(Actor009,"CHRNAME_TYRFING","speech","L","EA_003_0510075")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
 --バルバロイ登場
CloseTalkWindow()
on_active(Ef_Portal_Enemy) 
play_particle(Ef_Portal_Enemy)
on_active(Ef_Portal_Enemy_2) 
play_particle(Ef_Portal_Enemy_2)
wait_time(0.6)
setup_small_camera_start(CameraEx_01)
wait_time(0.5)
Appear(Actor010)
Appear(Actor011)
PlayActionDirect(Actor010,"to Wlk")
PlayActionDirect(Actor011,"to Wlk")
slidemove(Actor010,0.76,0,-12.02,1.0)
slidemove(Actor011,-0.94,0,-10.3,1.0)
wait_time(1.0)
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor010,"to Std_Loop")
PlayActionDirect(Actor011,"to Std_Loop")
turn_lookat(Actor001,Actor010,0)
turn_lookat(Actor006,Actor010,0)
turn_lookat(Actor007,Actor010,0)
turn_lookat(Actor009,Actor010,0)
turn_lookat(Actor003,Actor010,0)
turn_lookat(Actor004,Actor010,0)
turn_lookat(Actor005,Actor010,0)
turn_lookat(Actor008,Actor010,0)
turn_lookat(Actor002,Actor010,0)
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor001,1,false)
PlayActionDirect(Actor001,"ToIdle")
set_animationbattlecontroller(Actor007,1,false)
PlayActionDirect(Actor007,"ToIdle")
wait_time(0.2)
set_animationbattlecontroller(Actor003,8,true)
PlayActionDirect(Actor003,"ToIdle")
wait_time(0.1)
set_animationbattlecontroller(Actor004,1,true)
PlayActionDirect(Actor004,"ToIdle")
wait_time(0.2)
set_animationbattlecontroller(Actor005,8,false)
PlayActionDirect(Actor005,"ToIdle")
set_animationbattlecontroller(Actor006,1,false)
PlayActionDirect(Actor006,"ToIdle")
wait_time(0.1)
set_animationbattlecontroller(Actor008,8,true)
PlayActionDirect(Actor008,"ToIdle")
set_animationbattlecontroller(Actor009,1,true)
PlayActionDirect(Actor009,"ToIdle")
wait_time(1.0)
setup_small_camera_start()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Invation3")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス","激怒")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ルーシャス★★:やれやれ美しい思い出話に水を差す無粋な輩たちの登場だ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0510077")

-- ▼直接出力
PlayPartVoice("ルーシャス","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ルーシャス★★:いや、もはやカレドニアはこやつらの巣窟ならば土足であがりこむ無粋な輩は余のほうか？
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0510078")

-- ▼直接出力
PlayPartVoice("マルディサント","苦しみ")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:んなこと言ってる場合かよ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_003_0510079")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:ルーシャス様、私の後ろに
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","EA_003_0510080")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:継承者の思い出の故郷が美しいままであればよいな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","EA_003_0510081")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
preload_sound("BGM_ADV_Invation3")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
