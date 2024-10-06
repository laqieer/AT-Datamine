-- このluaスクリプトは、EA_010_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation07","DuelCommonFormation07_h")
Include("content_adv_advsmall_duelcommonformation07","TemplateDuelCommonFormation07_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation07_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation07,CameraPosDuelCommonFormation07_006)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPosDuelCommonFormation07_011,CameraAssetBundleNameDuelCommonFormation07,CameraPosDuelCommonFormation07_011)
	InitializeTemplateRandomCameraDuelCommonFormation07()
	InitializeTemplateDuelCommonFormation07()
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
CUT_11 =  cat_template_camera("P11_Cam", Actor002)
CUT_13 =  cat_template_camera("P13_Cam")
CUT_14 =  cat_template_camera("P14_Cam")
CUT_15 =  cat_template_camera("P15_Cam")
CUT_16 =  cat_template_camera("P16_Cam")
CUT_17 =  cat_template_camera("P17_Cam")
CUT_18 =  cat_template_camera("P18_Cam")
CUT_19 =  cat_template_camera("P19_Cam")
CUT_20 =  cat_template_camera("P20_Cam")
CUT_21 =  cat_template_camera("P21_Cam")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001=CUT_10
set_enable_auto_lookat_all(false)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010230", "content_still_20101023_image", "201010230_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_LTeinn")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101220011)
	Actor001 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(3.2)
setup_small_camera_start(CUT_11)
wait_time(1.6)
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310004")

	change_face(Actor001,"Shy")

	--★★レーヴァテイン★★:一緒に登校、するから
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_13)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0033")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310008")


	--★★レーヴァテイン★★:なんか…ずっと<br>私、めんどくさいね
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310009")

	open_select_window_tag(Actor002,"Normal","EA_010_0310011","EA_010_0310012","EA_010_0310013")
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
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:うん…
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310016")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:「あっち行って」って言ったり<br>一緒に登校したり
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310017")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:ほんと、あべこべで
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:お世辞はいいよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310021")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:自分が一番わかってる
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310022")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:どうしようもないぐらい<br>わかってる
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310023")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0015")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:…そういう話、してないんだけど
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310026")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:イヤ、ていうか…その
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:そう言ってくれるのは<br>私も、嬉しいし…いいんだけど
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310028")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_15)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:………私さ<br>前からそうなんだ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310030")

	PlayAction(Actor001,"to  Std_Talk")

	--★★レーヴァテイン★★:戦ってるとき<br>夢中で剣を振るの
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310031")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310032")


	--★★レーヴァテイン★★:戦ってないときも、そう
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310033")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★レーヴァテイン★★:言いたいことがあっても<br>うまく言葉にできなくて…
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310034")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_16)
wait_time(0.3)
-- ▲直接出力

	--★★レーヴァテイン★★:私のキラーズの──『<ruby=レーヴァテイン>破滅の剣</ruby>』の<br>伝承にもあるらしいんだよね
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310035")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0033")
-- ▲直接出力

	--★★レーヴァテイン★★:神々の時代に…<br><ruby=わたし>レーヴァテイン</ruby>が世界を破滅させた…って
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310037")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_17)
wait_time(0.3)
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310039")


	--★★レーヴァテイン★★:ううん、あなただけじゃない<br>きっと、これからも誰かを傷つけていく
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310040")

	PlayAction(Actor001,"to  Std_Talk")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310041")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★レーヴァテイン★★:…バルバロイは<br>ひとと、思い出を喰らう
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310043")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("201010230", 0.0, 0.0, 0.8,true,false)
wait_time(0.9)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★レーヴァテイン★★:喰らわれたひとはいなくなって<br>そのひとのことは思い出せなくなってく
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0310044")


	--★★レーヴァテイン★★:学園の空席が増えるたびに<br>思い出が消えたことだけを知る
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0310045")


	--★★レーヴァテイン★★:私も自分の剣で誰を傷つけたのかすら<br>忘れちゃって、薄情だよね
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0310046")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","N","EA_010_0310047")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
hide_image(0.0)
wait_time(0.1)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.9)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★レーヴァテイン★★:そうしたら──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310048")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_18)
hide_image(BLACK_WHITE_TIME)
wait_time(0.5)
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310049")


	--★★レーヴァテイン★★:笑ったら<br>その誰かに悪いと思ったから
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310050")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_11)
wait_time(0.3)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0310052","EA_010_0310053")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0048")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:…あのときは
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310056")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:………あなたに安心、してほしかったから
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310058")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:それだけ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310059")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:………
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310062")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:来ないよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310063")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:笑いたいとも思わないし
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310064")

	goto Block2end

::Block2end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:声あげてアハハなんて<br>できないよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310066")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_19)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:そうやって、皆のなかに<br>見えない傷痕だけが増え続ける
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310068")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:少しでも多く<br>できる限りたくさん
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310069")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_13)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0002")
-- ▲直接出力

	--★★レーヴァテイン★★:あなたも、さ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310071")


	--★★レーヴァテイン★★:戦いなんてしないで<br>サボってたほうが…いいよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310072")


	--★★レーヴァテイン★★:私たちだけ戦えばいいんだし
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310073")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310074")

	open_select_window_tag(Actor002,"Normal","EA_010_0310076")
	if is_select(1) then
		goto Block3_1
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0058")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:………！
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310079")

	goto Block3end

::Block3end::
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:な、に、言ってるの
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310080")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:変だよ、そんなの
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310081")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_11)
wait_time(0.6)
shake_camera(CUT_11, 0.42, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(3.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_LTeinn")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:…絶対、変
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310083")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★レーヴァテイン★★:変わってる、あなた
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310084")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_20)
shake_camera(CUT_20, 0.42, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(3.5)
-- ▲直接出力

	--★★レーヴァテイン★★:あなたには、過去の継承者の意志が宿ってる
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310086")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:記憶があっても、なくても<br>その意志はあなたに影響を与えてる
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310087")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:だからそんな変なこと<br>言えちゃうんだよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310088")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
shake_camera(CUT_20, 0.42, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(3.5)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★レーヴァテイン★★:………いいの？<br>カンタンに言っちゃって
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310090")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:「一緒に傷つこう」だなんて──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310091")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
shake_camera(CUT_20, 0.42, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(3.5)
wait_time(0.3)
setup_small_camera_start(CUT_21)
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力

	--★★レーヴァテイン★★:たぶん、もがくほど痛いよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0310094")

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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010230", "content_still_20101023_image", "201010230_StillImage")
preload_sound("BGM_Battle_LTeinn")
	InitializeLoad_Preload()
	load_duel_scene_preload(101220011)
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation07)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
