-- このluaスクリプトは、EA_010_026.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100011_03","100011_03_h")
Include("content_adv_advsmall_100011_03","Template100011_03_h")
-- ▼直接出力
Include("content_luascript_common","PlayerControllerData")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_e0010_01_Controller","to Std_Loop",CameraAssetBundleName100011_03,CameraPos100011_03_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100011_03_004,CameraAssetBundleName100011_03,CameraPos100011_03_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos100011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName100011_03,CameraPos100011_03_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos100011_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName100011_03,CameraPos100011_03_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos100011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName100011_03,CameraPos100011_03_002)
	InitializeTemplateRandomCamera100011_03()
	InitializeTemplate100011_03()
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
chair01 = get_object("geo_chair_14")
chair02 = get_object("geo_chair_20")
set_pos(chair01,{2.65 , 0 , 0.516 , 0})
set_pos(chair02, {2.542 , 0 , -0.516 , 0})
door01 = get_object("geo_door_R_01")
set_pos(door01, {7.458 , 1.228 , -5.461})
kaban01 = get_object("geo_stationary_21")
set_pos(kaban01, {0.98278, -8.75, -0.51632})
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Sit01Sleep_Loop")
-- ▲直接出力
-- ▼直接出力
heroId = GetPlayerStyleId()
local controllerName = GetE0010CommonPlayerController(heroId)
set_animationcontroller(Actor002,controllerName, "to Std_Loop")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001=CUT_10
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
CUT_10 =  cat_template_camera("P10_Cam")
CUT_11 =  cat_template_camera("P11_Cam")
CUT_12 =  cat_template_camera("P12_Cam")
CUT_13 =  cat_template_camera("P13_Cam")
CUT_14 =  cat_template_camera("P14_Cam")
CUT_15 =  cat_template_camera("P15_Cam")
CUT_16 =  cat_template_camera("P16_Cam")
CUT_17 =  cat_template_camera("P17_Cam")
CUT_18 =  cat_template_camera("P18_Cam")
CUT_19 =  cat_template_camera("P19_Cam")
CUT_20 =  cat_template_camera("P20_Cam",Actor002)
CUT_22 =  cat_template_camera("P22_Cam")
CUT_25 =  cat_template_camera("P25_Cam")
CUT_26 =  cat_template_camera("P26_Cam",Actor002)
CUT_28 =  cat_template_camera("P28_Cam")
CUT_29 =  cat_template_camera("P29_Cam")
-- ▲直接出力
-- ▼直接出力
load_image("201010151", "content_still_20101015_image", "201010151_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004, {1.663,0,-3.982})
turn_chara(Actor004,3.79593,0)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100011)
	Actor001 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101002","002","101002002")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.0)
setup_small_camera_start(CUT_11)
wait_time(2.4)
Appear(Actor004)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0027")
-- ▲直接出力

	--★★レーヴァテイン★★:…ふあぁ～
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260005")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{1.663, 0, -0.306}, 2.5)
wait_time(2.5)
turn_chara(Actor004,254,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ロンギヌス2★★:
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260008")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:ううん<br>そうじゃないよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260009")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_12)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ロンギヌス2★★:ふふ。確かにレーヴァテインは<br>いつも眠そうにしてますもんね
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260010")


	--★★レーヴァテイン★★:そうそう<br>…ねえ、ロンギヌス
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260011")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ロンギヌス2★★:はい
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
show_image("201010151", 0.0, 0.0, 0.8,true,true)
set_scale_image(0.75,0.75)
wait_time(0.3)
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0260013")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0033")
-- ▲直接出力

	--★★レーヴァテイン★★:ぜんぶ<br>変な感じになる
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0260014")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0260015")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0009")
-- ▲直接出力

	--★★ロンギヌス2★★:そうですね
	Talk(Actor004,"CHRNAME_LONGINUS","simple","N","EA_010_0260016")


	--★★レーヴァテイン★★:ヒド
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0260017")


	--★★ロンギヌス2★★:ふふふふ…
	Talk(Actor004,"CHRNAME_LONGINUS","simple","N","EA_010_0260018")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
hide_image(0.0)
setup_small_camera_start(CUT_13)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力

	--★★ロンギヌス2★★:どうしてそこまで<br><%player>さんを？
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260020")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260021")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:正直私、ズタボロだった<br><%player>が来てくれなかったら
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260022")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260023")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:恩人すら救えないような自分には<br>なりたくない
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260024")

	change_face(Actor004,"Sad")

	--★★ロンギヌス2★★:………
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260025")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:私は──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260026")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_15)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:──誰ひとり<br>傷つけたくない
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_11)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260028")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:絶対に叶わないキレイゴト
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260029")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260030")

	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:二度と顔を上げられない気がするから
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260031")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_12)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0051")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:………とか、世界を救わなきゃなんないのに<br>人ひとりのためにウダウダ言ってる私、バカかな
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260034")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Laugh")

	--★★ロンギヌス2★★:あなたは<br>優しいから
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260035")

	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:ロンギヌス…
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260036")

	change_face(Actor004,"Normal")

	--★★ロンギヌス2★★:
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0009")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ロンギヌス2★★:レーヴァテインが迎えに行かなくても<br>誰かが行きました。私とか
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260038")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260039")

	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:私がする
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260040")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0007")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ロンギヌス2★★:………じゃあ<br>そういうことですよ。きっと
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260041")

	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:なにが？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260042")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ロンギヌス2★★:<%player>さんが<br>あなたと戦ってくれる理由
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260043")

-- ▼直接出力
CloseTalkWindow()
heroId = GetPlayerStyleId()
local controllerName = GetE0010PlayerController(heroId)
set_animationcontroller(Actor002,controllerName, "to WalkEnd_pose")
set_pos(Actor002,{1.649,0,-1.084})
turn_chara(Actor002, 289,0)
wait_time(0.6)
PlayActionDirect(Actor002,"to WalkEnd")
wait_time(0.2)
setup_small_camera_start(CUT_16)
wait_time(1.0)
-- ▲直接出力

	--★★ロンギヌス2★★:
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260044")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:するでしょ<br>それくらいは人として
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260045")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_17)
heroId = GetPlayerStyleId()
local controllerName = GetE0010CommonPlayerController(heroId)
set_animationcontroller(Actor002,controllerName, "to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ロンギヌス2★★:
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260046")

	open_select_window_tag(Actor002,"Smile","EA_010_0260049")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_18)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:………かばってるつもり、ない
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260052")

	goto Block1end

::Block1end::
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:あなたのために、やってな──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260053")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor001,"to Sit01Sleep_End")
wait_time(1.6)
setup_small_camera_start(CUT_15)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0015")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:なんでいるの
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260055")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0010")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ロンギヌス2★★:迎えに行ってみました
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260056")

	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:ロンギヌス、余計なことを…
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260057")

	change_face(Actor004,"Smile")

	--★★ロンギヌス2★★:ふふっ
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260058")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_19)
wait_time(0.3)
PlayActionDirect(Actor001,"to Sit01_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:<%player><br>どこから聞いてたの
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260059")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_20)
wait_time(0.3)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0260061")
	if is_select(1) then
		goto Block2_1
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:うわ、全部じゃん
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260063")

	goto Block2end

::Block2end::
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Laugh")

	--★★ロンギヌス2★★:全部ですね
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260064")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_22)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:………わかった
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260065")

	change_face(Actor001,"Smile")

	--★★レーヴァテイン★★:じゃあ<%player><br>順番、決めとく？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260066")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0034")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ロンギヌス2★★:順番？
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260067")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:バルバロイ倒すのを<br>次からは当番制にするの。公平に
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260068")

	change_face(Actor001,"Smile")

	--★★レーヴァテイン★★:ほら<br>じゃんけんで決めよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260069")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor001,"to Sit01RPS_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:いくよ。じゃーんけーん──… 
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260070")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_20)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_RPS")
wait_time(2.5)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0260072","EA_010_0260073","EA_010_0260074")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	elseif is_select(3) then
		goto Block3_3
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_25)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_RPSrock")
PlayActionDirect(Actor001,"to Sit01RPSrock_Loop")
wait_time(2.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★Player★★:（グー）
	Talk(Actor002,"PLAYERNAME_GENDAI","mind","L","EA_010_0260077")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:あいこだ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260078")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor001,"to Sit01RPS_end")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:じゃあ無効試合。当番制の話もナシ<br>あなたは戦わない。私だけで戦う
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260079")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_25)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_RPSscissors")
PlayActionDirect(Actor001,"to Sit01RPSrock_Loop")
wait_time(2.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★Player★★:（チョキ）
	Talk(Actor002,"PLAYERNAME_GENDAI","mind","L","EA_010_0260082")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★レーヴァテイン★★:やった、私の勝ち
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260083")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor001,"to Sit01RPS_end")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:じゃ、私が戦う<br>あなたは戦わない
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260084")

	goto Block3end

::Block3_3::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_25)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_RPSpaper")
PlayActionDirect(Actor001,"to Sit01RPSrock_Loop")
wait_time(2.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★Player★★:（パー）
	Talk(Actor002,"PLAYERNAME_GENDAI","mind","L","EA_010_0260087")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:うわ、負けた…
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260088")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor001,"to Sit01RPS_end")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:じゃ、あなたは戦わなくていいよ<br>私だけで戦うから
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260089")

	goto Block3end

::Block3end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_15)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:そういうことで、勝負はついたね
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260091")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.6)
PlayActionDirect(Actor001,"to Sit01_End")
wait_time(5.0)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-131,0.4)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-126,0.4)
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力

	--★★レーヴァテイン★★:帰る
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260093")

	change_face(Actor004,"Sad")

	--★★ロンギヌス2★★:
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","EA_010_0260094")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_26)
wait_time(0.3)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0260096","EA_010_0260097")
	if is_select(1) then
		goto Block4_1
	elseif is_select(2) then
		goto Block4_2
	end

::Block4_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
Appear(Actor005)
Hide(Actor001)
wait_time(0.3)
setup_small_camera_start(CUT_28)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★レーヴァテイン2★★:ムリ
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260100")

	change_face(Actor005,"Normal")

	--★★レーヴァテイン2★★:あなたのためじゃない
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260101")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★レーヴァテイン2★★:私が躊躇なく<br>傷を負うためだから
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260102")

	goto Block4end

::Block4_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
Appear(Actor005)
Hide(Actor001)
wait_time(0.3)
setup_small_camera_start(CUT_28)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★レーヴァテイン2★★:普通の学園生活なんて
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260105")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★レーヴァテイン2★★:そんなの、私は要らない
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260106")

	change_face(Actor005,"Sad")

	--★★レーヴァテイン2★★:こんな世界じゃなかったら<br>わからない、けど…今は──
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260107")

	goto Block4end

::Block4end::
	change_face(Actor005,"Normal")

	--★★レーヴァテイン2★★:ひとりで、できる
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260109")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{4.114, 0, -1.803,}, 2.5)
wait_time(2.8)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-226,0.4)
wait_time(0.3)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-266,0.3)
wait_time(0.1)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor005)
wait_time(2.5)
setup_small_camera_start(CUT_29)
wait_time(0.6)
-- ▲直接出力

	--★★レーヴァテイン3★★:私といても──
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260111")


	--★★レーヴァテイン3★★:
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260112")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0060")
-- ▲直接出力

	--★★レーヴァテイン3★★:もう、そばに来ないで
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0260113")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
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
heroId = GetPlayerStyleId()
RndCamera001=CUT_10
load_image_preload("201010151", "content_still_20101015_image", "201010151_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(100011)
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101002","002","101002002")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName100011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
