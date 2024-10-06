-- このluaスクリプトは、EA_010_046.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_06","110071_06_h")
Include("content_adv_advsmall_110071_06","Template110071_06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110071_06_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_02_e0010_01_Controller","to Std_Loop",CameraAssetBundleName110071_06,CameraPos110071_06_002)
	Camera002 = SetPlayerTemplate("Actor003",nil,CharaPos110071_06_017,CameraAssetBundleName110071_06,CameraPos110071_06_017)
	Camera003 = SetTemplate("Actor004",nil,CharaPos110071_06_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110071_06,CameraPos110071_06_003)
	Camera004 = SetTemplate("Actor005",nil,CharaPos110071_06_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110071_06,CameraPos110071_06_003)
	Camera005 = SetTemplate("Actor006",nil,CharaPos110071_06_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName110071_06,CameraPos110071_06_002)
	Camera006 = SetTemplate("Actor007",nil,CharaPos110071_06_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName110071_06,CameraPos110071_06_004)
	Camera007 = SetTemplate("Actor008",nil,CharaPos110071_06_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName110071_06,CameraPos110071_06_005)
	Camera008 = SetTemplate("Actor009",nil,CharaPos110071_06_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName110071_06,CameraPos110071_06_005)
	InitializeTemplateRandomCamera110071_06()
	InitializeTemplate110071_06()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
initialize_MA0010023(heroIdshort)
-- ▲直接出力
-- ▼直接出力
CUT_10 =  cat_template_camera("P10_Cam")
CUT_11 =  cat_template_camera("P11_Cam")
CUT_12 =  cat_template_camera("P12_Cam")
CUT_13 =  cat_template_camera("P13_Cam")
CUT_14 =  cat_template_camera("P14_Cam")
CUT_15 =  cat_template_camera("P15_Cam")
CUT_16 =  cat_template_camera("P16_Cam")
CUT_17 =  cat_template_camera("P17_Cam",Actor003)
CUT_19 =  cat_template_camera("P19_Cam")
CUT_20 =  cat_template_camera("P20_Cam")
CUT_21 =  cat_template_camera("P21_Cam")
CUT_22 =  cat_template_camera("P22_Cam")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001=CUT_10
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Ef_Emblem01 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_pos(Ef_Emblem01,{-1.855, 1.337, 15.13})
Ef_Emblem02 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_pos(Ef_Emblem02,{-1.416, 1.112, 16.018})
-- ▲直接出力
-- ▼直接出力
Ef_Emblem03 =  set_object("content_effect3d_common_adv","Ef_C_Adv_Emblem22",false)
turn(Ef_Emblem03, 0,180, 0, 0)
Ef_Emblem04 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
set_pos(Ef_Emblem04,{-1.855,0.0, 15.13})
Ef_Emblem05 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Area",false,true)
set_pos(Ef_Emblem05,{-1.855, 0.0, 15.13})
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to WalkEnd_pose")
PlayActionDirect(Actor003,"to RunEnd_pose")
PlayActionDirect(Actor007,"to Std_RPS")
Hide(Actor003)
Hide(Actor004)
Hide(Actor007)
Hide(Actor008)
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Ef_Emblem06 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Area_Start",false,true)
set_pos(Ef_Emblem06,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110072)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializePlayerCharacter("Actor003")
	Actor004 = InitializeCharacter_3D("101035","002","101035002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(3.0)
setup_small_camera_start(CUT_11)
wait_time(0.4)
-- ▲直接出力

	--★★テロップ★★:「また、うたたねのフリをする」
	Talk(Actor001,"telop","simple","N","EA_010_0460003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
Appear(Actor004)
PlayActionDirect(Actor004,"to WalkEnd")
setup_small_camera_start(CUT_12)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力

	--★★ロンギヌス★★:レーヴァテイン、おケガは？
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0460005")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor002,"to Sit10_end")
wait_time(0.7)
-- ▲直接出力

	--★★レーヴァテイン★★:………
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
on_active(Ef_Emblem01)
play_particle(Ef_Emblem01)
wait_time(0.3)
fadeout(255,255,255,1.0,0.4)
wait_time(TIME_ELAPSED + FADE_TIME)
fadein(FADE_TIME)
Appear(Actor006)
Hide(Actor002)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(FADE_TIME)
wait_time(0.6)
setup_small_camera_start(CUT_13)
wait_time(0.3)
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,65,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.6)
stop_particle(Ef_Emblem01)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★レーヴァテイン2★★:
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460009")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.5)
on_active(Ef_Emblem02)
play_particle(Ef_Emblem02)
wait_time(0.3)
fadeout(255,255,255,1.0, 0.4)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor005)
Hide(Actor004)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0010")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ロンギヌス2★★:良かった<br>元気そうですね
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","EA_010_0460011")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.4)
Appear(Actor003)
PlayActionDirect(Actor003,"to RunEnd")
setup_small_camera_start(CUT_15)
wait_time(1.6)
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.5)
setup_small_camera_start(CUT_16)
wait_time(2.0)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★レーヴァテイン2★★:…言ったよね
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460014")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★レーヴァテイン2★★:そばに来ないでって
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460016")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_17)
wait_time(0.3)
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_010_0460018")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_13)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0011")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★レーヴァテイン2★★:………ふっ
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460021")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_19)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★レーヴァテイン2★★:あっはははは、あはは！！
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460022")

	change_face(Actor006,"Normal")

	--★★レーヴァテイン2★★:…ねえ
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460024")


	--★★レーヴァテイン2★★:あのさ、<%player>
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_20)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★レーヴァテイン2★★:…やっぱり順番<br>決め直そうよ
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460026")

	change_face(Actor006,"Smile")

	--★★レーヴァテイン2★★:バルバロイ倒す当番
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460027")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0009")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ロンギヌス2★★:…いいですね
	Talk(Actor005,"CHRNAME_LONGINUS","speech","L","EA_010_0460028")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力

	--★★レーヴァテイン2★★:私と<%player>で<br>もっかいじゃんけん
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460029")

-- ▼直接出力
PlayActionDirect(Actor006,"to Std_RPS")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★レーヴァテイン2★★:いくよ。じゃーんけーん──…
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460030")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_17)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_RPS")
wait_time(2.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
Appear(Actor007)
Hide(Actor006)
-- ▲直接出力
	open_select_window_tag(Actor003,"Smile","EA_010_0460032","EA_010_0460033","EA_010_0460034")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
hide_image(BLACK_WHITE_TIME)
wait_time(0.5)
setup_small_camera_start(CUT_21)
wait_time(0.6)
PlayActionDirect(Actor007,"to Std_RPSrock")
PlayActionDirect(Actor003,"to Std_RPSrock")
wait_time(0.6)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★Player★★:（グー）
	Talk(Actor003,"PLAYERNAME_GENDAI","mind","L","EA_010_0460037")

	change_face(Actor007,"Normal")

	--★★レーヴァテイン3★★:あいこだ
	Talk(Actor007,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460038")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★レーヴァテイン3★★:じゃあ、次も一緒にやるってことで
	Talk(Actor007,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460039")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
hide_image(BLACK_WHITE_TIME)
wait_time(0.5)
setup_small_camera_start(CUT_21)
wait_time(0.6)
PlayActionDirect(Actor007,"to Std_RPSrock")
PlayActionDirect(Actor003,"to Std_RPSscissors")
wait_time(0.6)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★Player★★:（チョキ）
	Talk(Actor003,"PLAYERNAME_GENDAI","mind","L","EA_010_0460042")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★レーヴァテイン3★★:やった、私の勝ち
	Talk(Actor007,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460043")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★レーヴァテイン3★★:じゃあ次も<br>手伝ってもらおうかな
	Talk(Actor007,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460044")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
hide_image(BLACK_WHITE_TIME)
wait_time(0.5)
setup_small_camera_start(CUT_21)
wait_time(0.6)
PlayActionDirect(Actor007,"to Std_RPSrock")
PlayActionDirect(Actor003,"to Std_RPSpaper")
wait_time(0.6)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★Player★★:（パー）
	Talk(Actor003,"PLAYERNAME_GENDAI","mind","L","EA_010_0460047")

	change_face(Actor007,"Normal")

	--★★レーヴァテイン3★★:うわ、負けた…
	Talk(Actor007,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460048")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★レーヴァテイン3★★:じゃあ気が進まないけど<br>次もあなたと一緒に戦うことにする
	Talk(Actor007,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460049")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor008)
Hide(Actor007)
setup_small_camera_start(CUT_13)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0002")
-- ▲直接出力

	--★★レーヴァテイン4★★:…<%player>
	Talk(Actor008,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460051")

	PlayAction(Actor008,"to  Std_Talk")

	--★★レーヴァテイン4★★:また明日…
	Talk(Actor008,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460052")

	change_face(Actor008,"Smile")

	--★★レーヴァテイン4★★:あなたを迎えに行くよ
	Talk(Actor008,"CHRNAME_LAEVATEIN","speech","L","EA_010_0460053")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_22)
wait_time(0.5)
shake_camera(CUT_22,1.0,8)
se_play("SE_ADV_MA_01A111_14_Earthquake")
wait_time(0.5)
PlayActionDirect(Actor005,"to  Std_Surp")
PlayActionDirect(Actor008,"to  Std_Joy")
PlayActionDirect(Actor003,"to  Std_Surp")
wait_time(8.0)
PlayActionDirect(Actor008,"to Std_Loop")
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	change_face(Actor008,"Anger")

	--★★レーヴァテイン4★★:
	Talk(Actor008,"CHRNAME_LAEVATEIN","speech","L","EA_010_0470045")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
effect_at_character(Actor008,"Chest",Ef_Emblem03, 0.0, 0.15, 0.0)
wait_time(1.0)
on_active(Ef_Emblem04)
play_particle(Ef_Emblem04)
wait_time(2.0)
on_active(Ef_Emblem05)
play_particle(Ef_Emblem05)
on_active(Ef_Emblem01)
play_particle(Ef_Emblem01)
wait_time(0.6)
fadeout(255,255,255,1.0,0.4)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor009)
Hide(Actor008)
PlayActionDirect(Actor009,"to Std_Loop")
fadein(FADE_TIME)
wait_time(FADE_TIME)
stop_particle( Ef_Emblem04)
stop_particle( Ef_Emblem05)
stop_particle( Ef_Emblem01)
wait_time(0.3)
-- ▲直接出力

	--★★テロップ★★:「救いようのない私は<br>顔を上げられないままだ」
	Talk(Actor001,"telop","simple","N","EA_010_0460056")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
on_active(Ef_Emblem06)
play_particle(Ef_Emblem06)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end

