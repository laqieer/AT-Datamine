-- このluaスクリプトは、MS_002_033.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation06","DuelCommonFormation06_h")
Include("content_adv_advsmall_duelcommonformation06","TemplateDuelCommonFormation06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",0,CharaPosDuelCommonFormation06_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPosDuelCommonFormation06_014,CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_014)
	InitializeTemplateRandomCameraDuelCommonFormation06()
	InitializeTemplateDuelCommonFormation06()
-- ▼直接出力
CUT_10 = cat_template_camera("P10_Cam")
CUT_11 = cat_template_camera("P11_Cam")
CUT_12 = cat_template_camera("P12_Cam")
CUT_13 = cat_template_camera("P13_Cam")
CUT_14 = cat_template_camera("P14_Cam",Actor002)
CUT_16 = cat_template_camera("P16_Cam")
CUT_17 = cat_template_camera("P17_Cam")
CUT_18 = cat_template_camera("P18_Cam")
CUT_19 = cat_template_camera("P19_Cam")
CUT_20 = cat_template_camera("P20_Cam")
CUT_21 = cat_template_camera("P21_Cam")
CUT_22 = cat_template_camera("P22_Cam")
CUT_23 = cat_template_camera("P23_Cam")
CUT_24 = cat_template_camera("P24_Cam")
CUT_25 = cat_template_camera("P25_Cam")
CUT_26 = cat_template_camera("P26_Cam")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
RndCamera001=CUT_10
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101220011)
	Actor001 = InitializeCharacter_3D("101070","002","101070002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.8)
setup_small_camera_start(CUT_11)
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:こうやって<br>きみの日常がなくなってく
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★フライクーゲル★★:戦い続きで、不自由で
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330005")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
setup_small_camera_start(CUT_13)
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:…だけど、きみが<ruby=ログレス>過去の歴史のなか</ruby>で<br>得て来たものも沢山ある、よね
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330006")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0034")
-- ▲直接出力

	--★★フライクーゲル★★:世界を救うのにやらなきゃならないことも沢山…<br>…それは、わかってる
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330008")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start(CUT_20)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.6)
wait_time(0.6)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.6)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:だけど、それが<br>『最後の継承者』の運命でも
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330010")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330011")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:だから、世界に縛られなくたっていいんだよ<br>自由に生きたっていいんじゃない？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_17)
wait_time(1.8)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:………あっ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330014")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0068")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:そんなの急に言われても、だよね
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330015")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★フライクーゲル★★:いっつも間が悪くて。わたし<br>…ごめんね
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330016")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
setup_small_camera_start(CUT_12)
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0066")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:この学園の裏にね<br>キレイな森があるんだ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:森の抜け道は見つけてあるんだ<br>抜けた先は──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330018")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.4)
setup_small_camera_start(CUT_18)
wait_time(1.8)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:ここじゃないどこか
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330019")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.8)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:………
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330020")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start(CUT_16)
wait_time(2.8)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:放課後、そこで待ってる 
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0330021")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end

