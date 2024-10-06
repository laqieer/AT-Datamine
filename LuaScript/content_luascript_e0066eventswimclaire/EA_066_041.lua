-- このluaスクリプトは、EA_066_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",-72,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",-83,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("201010830","content_still_20101083_image","201010830_StillImage")
load_image("201010831","content_still_20101083_image","201010831_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
B_Pos = {-0.4, 0, -0.75}
C_Pos = {0.7, 0, -0.7}
C2_Pos = {-0.88, 0, 0.79}
R_Pos = {-0.7, 0, 0}
set_pos(Actor002,C_Pos)
set_pos(Actor004,C2_Pos)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head", 0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head", 0)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head", 0)
-- ▲直接出力
-- ▼直接出力
load_image("201010840","content_still_20101084_image","201010840_StillImage")
load_image("201010870","content_still_20101087_image","201010870_StillImage")
load_image("201010880","content_still_20101088_image","201010880_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101025","003","101025003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera003)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0410003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0007")
-- ▲直接出力

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0410004")

-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力

	--★★ラロゥ★★:まずは辺りを調べてみよう遺跡の場所のヒントがあるかも
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0410005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Camera001 = setup_small_camera_resetting(Actor001,CharaPosDuelCommonFormation01_005,CameraPosDuelCommonFormation01_005)
Camera002 = setup_small_camera_resetting(Actor002,CharaPosDuelCommonFormation01_006,CameraPosDuelCommonFormation01_006)
Camera003 = setup_small_camera_resetting(Actor003,CharaPosDuelCommonFormation01_008,CameraPosDuelCommonFormation01_008)
turn_chara(Actor001,35,0)
turn_chara(Actor002,105,0)
turn_chara(Actor003,80,0)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Sit10")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor003,"to Sit10")
SkipDefaultMotion(Actor003)
wait_time(0.3)
setup_small_camera_start(RndCamera009)
fadein(FADE_TIME)
wait_time(FADE_TIME)
se_play("SE_ADV_MA_01B900_13_Wind_Blow")
wait_time(0.7)
-- ▲直接出力

	--★★ヴォールス★★:この辺りは…海水が入り込んでいるのか<br>ずいぶん深いな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0410008")

-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0028")
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラロゥ★★:…！見て、あそこ水の底になにかあるよ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0410009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
set_pos(Actor001,B_Pos)
set_pos(Actor002,C2_Pos)
set_pos(Actor003,R_Pos)
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor001,"to Sit10")
SkipDefaultMotion(Actor001)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力

	--★★ヴォールス★★:ん…？確かになにか影になっているようだが<br>いったいあれは――
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0410010")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
SkipDefaultMotion(Actor002)
PlayPartVoiceDirect("クレア_003","0055")
wait_time(0.3)
PlayActionDirect(Actor002,"to  Std_Yes")
wait_time(0.3)
-- ▲直接出力

	--★★クレア★★:引き上げてみればわかるわ<br>わたしの出番ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0410011")

-- ▼直接出力
CloseTalkWindow()--クレア水着になる
se_play("SE_ADV_MA_01B112_49_Cloth")
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head", 1)
lookat_delay_weight(Actor001,0.45,0.3,0.85,0.4, 1)
Hide(Actor002)
Appear(Actor004)
set_enable_auto_lookat(Actor001, false)
wait_time(0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0030")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:！？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0410013")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0010")
keep_delay_ik_lookat(Actor004,Actor001,"J_Head", 0.2)
lookat_delay_weight(Actor004,0.45,0.3,0.85,0.4, 0.2)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クレア水着★★:こんなこともあろうかと、用意しておいたの<br>じゃ、いってくるわね
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_066_0410014")

-- ▼直接出力
change_face(Actor004,"Normal")
wait_time(0.4)
PlayActionDirect(Actor004,"to Sit10")
SkipDefaultMotion(Actor004)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()--クレア潜る
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
se_play("SE_ADV_EA_066_041_Splsh")
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor001,"J_Foot_L", 0.8)
lookat_delay_weight(Actor001,0.2,0.3,0.85,0.2, 0.8)
turn_chara(Actor004,-90,0)
Hide(Actor004)
set_enable_auto_lookat(Actor002, false)
wait_time(1)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:…あの人、服の下に水着を着てたんだ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0410017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:そうみたいだな…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0410018")


	--★★ヴォールス★★:（結構気に入っていたんだな、あの水着…）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0410019")

-- ▼直接出力
CloseTalkWindow()--クレア戻る
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
se_play("SE_ADV_EA_066_041_WaterExit")
Appear(Actor004)
wait_time(0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
se_play("SE_ADV_EA_066_041_Dripping")
PlayActionDirect(Actor004,"to Std_Loop")
SkipDefaultMotion(Actor004)
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2)
show_image("201010830", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.9,0.9)
wait_time(1)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力

	--★★ヴォールス★★:これは…石板？<br>なにか刻んであるようだが…
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0410031")

-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0047")
-- ▲直接出力

	--★★ラロゥ★★:見せて！
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410032")

	open_select_window_tag(Actor001,"Normal","EA_066_0410034","EA_066_0410035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0045")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:読めるのか
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0410038")

-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:キャメロット騎士学術院の教育の賜物だよ<br>たまに授業を盗み聞きしてたからね
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410039")

	change_face(Actor001,"Normal")

	--★★ヴォールス★★:そ、そうだったのか
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0410040")

	change_face(Actor003,"Normal")

	--★★ラロゥ★★:生徒の邪魔はしてないし、大目に見てよ<br>ノワールはいいって言ってくれたよ
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0019")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:こういうのは<br>クレアに任せた方がいいんじゃないか
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0410044")

	change_face(Actor003,"Normal")

	--★★ラロゥ★★:ええ～？<br>おじさん、子供の好奇心を無下にするタイプ？
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410045")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:そ、そういうつもりでは…
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0410046")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0038")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア水着★★:わたしは順番気にしないから、お先にどうぞ
	Talk(Actor004,"CHRNAME_CLARE","simple","N","EA_066_0410047")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2)
show_image("201010831", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.9,0.9)
wait_time(0.3 + 0.2)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0009")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:んーと…なんかつらつら書いてある<br>えっと――
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410049")


	--★★ラロゥ★★:「力とは誰かから得るものに非ず<br>己の中から見つけ出し、磨くものと心得よ」
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410050")


	--★★ラロゥ★★:「覚悟を決めよ<br>その覚悟こそが可能性を広げる劒となる」
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410051")


	--★★ラロゥ★★:「力とは誰かから得るものに非ず己の中から見つけ出し、磨くものと心得よ」
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410052")


	--★★ラロゥ★★:「あらゆる覚悟は尊ばれ何人もこれを侵すことは許されない」
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410053")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2)
show_image("201010830", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.9,0.9)
wait_time(0.3 + 0.2)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0410054")


	--★★ラロゥ★★:
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410055")

-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0025")
-- ▲直接出力

	--★★ラロゥ★★:
	Talk(Actor003,"CHRNAME_LAROU","simple","N","EA_066_0410056")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0034")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クレア水着★★:その後は暗号になっているようね<br>えっと…
	Talk(Actor004,"CHRNAME_CLARE","simple","N","EA_066_0410057")


	--★★ヴォールス★★:………
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0410059")

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
load_image_preload("201010830","content_still_20101083_image","201010830_StillImage")
load_image_preload("201010831","content_still_20101083_image","201010831_StillImage")
B_Pos = {-0.4, 0, -0.75}
C_Pos = {0.7, 0, -0.7}
C2_Pos = {-0.88, 0, 0.79}
R_Pos = {-0.7, 0, 0}
load_image_preload("201010840","content_still_20101084_image","201010840_StillImage")
load_image_preload("201010870","content_still_20101087_image","201010870_StillImage")
load_image_preload("201010880","content_still_20101088_image","201010880_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101025","003","101025003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
