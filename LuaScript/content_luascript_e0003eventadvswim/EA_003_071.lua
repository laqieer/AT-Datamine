-- このluaスクリプトは、EA_003_071.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera004 = SetTemplate("Actor004",0,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110901_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_004)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{3.02, 0.011, 0.805})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{3.38, 0.011, -0.443})
-- ▲直接出力
-- ▼直接出力
load_image("201010030", "content_still_20101003_image", "201010030_StillImage")
stillAnime = load_ui_effect("content_still_20101003_anim", "20101003_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({5.165, 1.97, 1.011,   9.901, 256.069, 0,   26})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({0.246, 1.45, -0.719,   0, 76.89999, 0,   28.22622})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor008 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor009 = InitializeCharacter_2DOnly("101001","001","101001001")
	Actor010 = InitializeCharacter_2DOnly("101012","001","101012001")
	Actor011 = InitializeCharacter_2DOnly("101017","001","101017001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
stillAnime.SetActive(true)
hide_image(0.5)
local signal = play_ui_timeline_controller_in(stillAnime)
while signal.IsProccessing() do
	coroutine.yield()
end
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_Volume_LT")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101011_Swim1_sp_0001_1")
-- ▲直接出力
	change_face(Actor008,"Laugh")

	--★★ギネヴィア_顔★★:ティルフィング！
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710003")

-- ▼直接出力
PlayPartVoice("ティルフィング","驚き")
-- ▲直接出力

	--★★ティルフィング_顔★★:え？
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710004")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_EA_003_071_Water")
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力

	--★★ティルフィング_顔★★:きゃっ…！
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710006")

-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ギネヴィア_顔★★:わーい、引っ掛かった！こういうの一度やってみたかったのよね
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710007")

-- ▼直接出力
voice_play("VO_101001_swim1_sp_0001_2")
-- ▲直接出力

	--★★ティルフィング_顔★★:もう…お返しですっ！
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710008")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_EA_003_071_Water")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0035")
-- ▲直接出力

	--★★ギネヴィア_顔★★:きゃあ！やったわね～！<br>ならわたしは倍返し～！！
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710009")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0011")
-- ▲直接出力

	--★★ノワール_顔★★:楽しそうだなぁ
	Talk(Actor007,"CHRNAME_NOIR","simple","N","EA_003_0710010")

-- ▼直接出力
PlayPartVoice("ディナタン","笑い")
-- ▲直接出力

	--★★ディナタン★★:次の里帰りは私たちも水着持ってこよっか
	Talk(Actor010,"CHRNAME_DINATAN","simple","N","EA_003_0710011")

-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール_顔★★:それもいいかもな
	Talk(Actor007,"CHRNAME_NOIR","simple","N","EA_003_0710012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ギネヴィア_顔★★:あ、あのね、ティルフィング
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710014")

-- ▼直接出力
PlayPartVoice("ティルフィング","肯定")
-- ▲直接出力

	--★★ティルフィング_顔★★:はい
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710015")


	--★★ギネヴィア_顔★★:わたし、あなたに謝らなきゃいけないことがあって
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力

	--★★ギネヴィア_顔★★:わたし、あなたに酷いことを言ったわ本当はお礼を言うべきだったのに
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710017")

	change_face(Actor008,"Pain")

	--★★ギネヴィア_顔★★:だってあなたは――
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710018")

-- ▼直接出力
PlayPartVoice("ティルフィング","否定")
-- ▲直接出力
	change_face(Actor009,"Laugh")

	--★★ティルフィング_顔★★:いいえ。ギネヴィア様が言っていたことは間違いではありません
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710019")


	--★★ティルフィング_顔★★:それは私の受け止めるべき咎ですから
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710020")

	change_face(Actor008,"Sad")

	--★★ギネヴィア_顔★★:でも――！
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710021")

-- ▼直接出力
voice_play("VO_101001_swim1_sp_0001_3")
-- ▲直接出力

	--★★ティルフィング_顔★★:…でもアナタはそんな私に歩み寄ろうとしてくれた
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング_顔★★:過ぎ去った過去よりも未来を見ようとしている
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710023")

-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0011")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ティルフィング_顔★★:ですから…水に流しましょうお互いに
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710024")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0011")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア_顔★★:…！うんっ！
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor008,"Shy")

	--★★ギネヴィア_顔★★:…あ、それとね<br>もうひとつ、言いたいことがあって
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710026")

	change_face(Actor009,"Surprise")

	--★★ティルフィング_顔★★:？
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710027")


	--★★ギネヴィア_顔★★:あの、その…
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710028")


	--★★ギネヴィア_顔★★:わ、わたしと…<br>お友達になってください！！！
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710029")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ノワール_顔★★:…もうお友達になっているんじゃないか？
	Talk(Actor007,"CHRNAME_NOIR","simple","N","EA_003_0710031")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0034")
-- ▲直接出力
	change_face(Actor010,"Surprise")

	--★★ディナタン★★:あれだけ仲良さそうに遊んでいて友達じゃないってことはないよね…？
	Talk(Actor010,"CHRNAME_DINATAN","simple","N","EA_003_0710032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネマウア★★:確証がほしいんですよ<br>かわいいでしょう？
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","simple","N","EA_003_0710033")

-- ▼直接出力
PlayPartVoice("マルディサント","落胆")
-- ▲直接出力
	change_face(Actor011,"Surprise")

	--★★マルディサント★★:むしろめんどくせ～～～
	Talk(Actor011,"CHRNAME_MALADISANT","simple","N","EA_003_0710034")

-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★ギネヴィア_顔★★:だ、だって！<br>ちゃんと言葉にしないと不安じゃない！
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ギネヴィア_顔★★:…で、どう？ティルフィング！？
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710036")

-- ▼直接出力
PlayPartVoice("ティルフィング","驚き")
-- ▲直接出力

	--★★ティルフィング_顔★★:どうって…
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710037")

	change_face(Actor008,"Shy")

	--★★ギネヴィア_顔★★:（ドキドキ！）
	Talk(Actor008,"CHRNAME_GUINEVERE","simple","N","EA_003_0710038")

-- ▼直接出力
PlayPartVoice("ティルフィング","喜び")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ティルフィング_顔★★:こちらこそ、よろしくお願いいたします
	Talk(Actor009,"CHRNAME_TYRFING","simple","N","EA_003_0710040")

-- ▼直接出力
CloseTalkWindow()
signal = play_ui_timeline_controller_out(stillAnime, true)
while signal.IsProccessing() do
	coroutine.yield()
end
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
stillAnime.SetActive(false)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor005,0.5, 0.1, 0.8, 0.2)
keep_ik_lookat(Actor005,Actor001,"J_Head")
lookat_weight(Actor006,0.5, 0.1, 0.8, 0.2)
keep_ik_lookat(Actor006,Actor001,"J_Head")
lookat_weight(Actor004,0.8, 0.1, 0.4, 0.2)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor001,0.5, 0.1, 0.8, 0.2)
keep_ik_lookat(Actor001,Actor005,"J_Head")
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:…ってわけで、無事お友達になれたってワケ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710043")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ラグネル★★:よかったですねぇ、ギネヴィア様
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_003_0710044")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力

	--★★ギネヴィア★★:うん！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710045")

-- ▼直接出力
on_active(Actor003)
on_active(Actor002)
PlayActionDirect(Actor003,"to Wlk")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat_position(Actor003,CharaPos110901_01_005[1],CharaPos110901_01_005[2],CharaPos110901_01_005[3],0)
turn_lookat_position(Actor002,CharaPos110901_01_006[1],CharaPos110901_01_006[2],CharaPos110901_01_006[3],0)
slidemove(Actor003,CharaPos110901_01_005[1],CharaPos110901_01_005[2],CharaPos110901_01_005[3],1.0)
wait_time(0.2)
slidemove(Actor002,CharaPos110901_01_006[1],CharaPos110901_01_006[2],CharaPos110901_01_006[3],1.0)
wait_time(0.2)
setup_small_camera_start()
wait_time(0.6)
turn_chara(Actor003,CharaPos110901_01_005[4],0.2)
wait_time(0.2)
turn_chara(Actor002,CharaPos110901_01_006[4],0.2)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ノワール★★:なにしてるんだ？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710047")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor004, false)
set_enable_auto_lookat(Actor006, false)
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
PlayPartVoice("ガウェイン","挨拶")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ガウェイン★★:お、ノワール。今ちょうど殿下から夏の思い出を聞いてたとこなんだ
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","EA_003_0710048")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラグネル★★:本気でぶつかって、水遊びしてティルちゃんと仲良くなれたーって
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_003_0710049")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ガウェイン★★:でも本当か～？
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","EA_003_0710050")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",0.5)
PlayPartVoice("ギネヴィア","怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:うたがうなぁ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_003_0710053","EA_003_0710054")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:まぁ、本当かな。確かに水遊びはしてたし<br>本気でぶつかってもいたし…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710056")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",0.6)
wait_time(0.2)
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:ほらぁ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710057")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:…いや、ぶつかったっていうか一方的に癇癪起こしてただけな気もするけど
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710058")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:まぁ、でも仲良くなったのは本当だよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710059")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:どうだったかなぁ…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710061")

-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:え、ウソ！？なんでよ！<br>ノワール、見てたでしょ！近くで！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710062")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:いや、だって、水遊びはしてたけど本気でぶつかった相手はバルバロイだし
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710063")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:そこはどーでもいいでしょうが！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710064")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ノワール★★:まぁ、でも…ティルフィングと仲良くなったのは本当だよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710065")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.2)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:な、ティルフィング
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0710067")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング","肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:ええ、お友達です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0710068")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン","納得")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ガウェイン★★:ティルフィングがそう言うならそうなのかな～
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","EA_003_0710069")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.0)
set_enable_auto_lookat(Actor006, true)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力

	--★★ラグネル★★:よかったですね、ギネヴィア様！
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_003_0710070")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:にっしっし…♪<br>もうわたしとティルフィングはお友達だから！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710071")


	--★★ギネヴィア★★:これからは一緒に買い物だって<br>行っちゃうんだから！にっしっしっしっし！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710072")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ガウェイン★★:おお、たいそう浮かれていらっしゃる
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","EA_003_0710073")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0014")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ラグネル★★:引かれないよう、ほどほどにね…
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_003_0710074")

-- ▼直接出力
setup_small_camera_start(Camera001)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.6)
wait_time(0.3)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力

	--★★ギネヴィア★★:ね、ティルフィング！<br>水着、今度は一緒に買いに行こうね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710075")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:今度…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0710076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:ティルフィングの好みを教えてよ！<br>ね、約束よ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0710077")


	--★★ティルフィング★★:………
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0710078")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,0.32,1.45,-0.702,8)
-- ▲直接出力
-- ▼直接出力
wait_time(1.9)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング","肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:…そうですね。いつか――…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0710080")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010030", "content_still_20101003_image", "201010030_StillImage")
load_ui_effect_preload("content_still_20101003_anim", "20101003_StillAnim", nil, nil, nil, "Root")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("101001","001","101001001")
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	InitializeCharacter_2DOnly_Preload("101017","001","101017001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
