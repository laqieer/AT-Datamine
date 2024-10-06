-- このluaスクリプトは、MA_01C900_38.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_03","111031_03_h")
Include("content_adv_advsmall_111031_03","Template111031_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_MA01C900_38v2_Controller","to Sit01_Loop",CameraAssetBundleName111031_03,CameraPos111031_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111031_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_MA01C900_38v2_Controller","to Sit01_Loop",CameraAssetBundleName111031_03,CameraPos111031_03_001)
	InitializeTemplateRandomCamera111031_03()
	InitializeTemplate111031_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
--set_pos(Actor001,{0.393,0.019,0.079})
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
CUT_10 = cat_template_camera("P10_Cam")
CUT_11 = cat_template_camera("P11_Cam")
CUT_12 = cat_template_camera("P12_Cam")
CUT_13 = cat_template_camera("P13_Cam")
CUT_14 = cat_template_camera("P14_Cam")
CUT_15 = cat_template_camera("P15_Cam")
CUT_16 = cat_template_camera("P16_Cam")
CUT_17 = cat_template_camera("P17_Cam")
CUT_18 = cat_template_camera("P18_Cam")
CUT_19 = cat_template_camera("P19_Cam")
CUT_20 = cat_template_camera("P20_Cam")
-- ▲直接出力
-- ▼直接出力
hideobj01 = get_object("geo_obj_basketA")
set_pos(hideobj01, {0,-20, 0})
hideobj02 = get_object("geo_obj_dish01")
set_pos(hideobj02, {0,-20, 0})
hideobj03 = get_object("geo_obj_dish02")
set_pos(hideobj03, {0,-20, 0})
hideobj04 = get_object("geo_obj_dish03")
set_pos(hideobj04, {0,-20, 0})
hideobj05 = get_object("geo_obj_plate")
set_pos(hideobj05, {0,-20, 0})
hideobj06 = get_object("geo_obj_cup01")
set_pos(hideobj06, {0,-20, 0})
hideobj07 = get_object("geo_obj_fork01")
set_pos(hideobj07, {0,-20, 0})
hideobj08 = get_object("geo_obj_fork02")
set_pos(hideobj08, {0,-20, 0})
hideobj09 = get_object("geo_obj_fork03")
set_pos(hideobj09, {0,-20, 0})
-- ▲直接出力
-- ▼直接出力
chair01 = get_object("geo_chair_01")
set_pos(chair01,{-1.23, 0.01, -1.55})
set_rot(chair01,{0.0, 31.85, 0.0})
set_scale(chair01,{0.8, 1.0, 0.8})
chair02 = get_object("geo_chair_02")
set_pos(chair02,{0.46, 0.01, 0.84})
set_rot(chair02,{0.0, -213.37, 0.0})
set_scale(chair02,{0.8, 1.0, 0.8})
chair03 = get_object("geo_chair_03")
set_pos(chair03,{0.82, -0.01, 0.25})
set_rot(chair03,{0.0, -103.16, 0.0})
set_scale(chair03,{0.8, 1.0, 0.8})
chair04 = get_object("geo_chair_04")
set_pos(chair04,{-0.64, 0.01, 0.94})
set_rot(chair04,{0.0, -204.16, 0.0})
set_scale(chair04,{0.8, 1.0, 0.8})
cup = get_object("geo_obj_cup02")
set_pos(cup,{0.23, 0.82, 0.23})
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10104011_anim", "10104011_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101012","001","101012001")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:ええっ、そんなの――
	Talk(Actor004,"telop","simple","N","MA_01C900_380002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
-- ▲直接出力

	--★★テロップ★★:寝ぼけてんのか？
	Talk(Actor004,"telop","simple","N","MA_01C900_380003")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start(CUT_10)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン2D★★:ふぁ…あれ？寝ちゃってた？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01C900_380004")

-- ▼直接出力
PlayActionDirect(Actor002,"startTalking010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★マルディサント★★:おはよう、ディーナ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380005")

-- ▼直接出力
Appear(Actor001)
PlayActionDirect(Actor001,"to Sit01_Loop")
wait_time(0.2)
setup_small_camera_start(CUT_11)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"startTalking010")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…どこからが夢？<br>あれ？よくわからない…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_12)
PlayActionDirect(Actor001,"to SitLookDown01_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:ここは夢のなかでもないし<br>あの世じゃないってことだけは確かだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380007")

-- ▼直接出力
CloseTalkWindow()
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"startTalking020")
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:…夢、終わらなかったんだね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380008")

	change_face(Actor002,"Smile")

	--★★マルディサント★★:夢じゃない、物語でもない<br>ここがアタシたちの未来だ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380009")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_13)
PlayActionDirect(Actor002,"startDivert")
wait_time(2.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"startNotice010")
wait_time(0.1)
setup_small_camera_start(CUT_14)
wait_time(0.1)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:ひとりで勝手に終わらせようとするな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380010")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_15)
PlayActionDirect(Actor001,"to SitLookUp03_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"startTalking030")
-- ▲直接出力

	--★★ディナタン★★:…そうだね、ごめんね<br>止めてくれてありがとう、マァル
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_16)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:…どんな夢を見てたんだ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380013")


	--★★ディナタン★★:いつもは夢の話嫌がるのに<br>今日は聞いてくれるの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380014")


	--★★マルディサント★★:眠っているディーナが<br>笑ってたからな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380015")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:えっ？私、笑ってた？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380016")


	--★★マルディサント★★:だから聞こうと思って
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380017")

	change_face(Actor001,"Smile")

	--★★ディナタン★★:フフッ…ひみつ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380018")

-- ▼直接出力
CloseTalkWindow()
set_pos(Actor002,{CharaPos111031_03_003[1],CharaPos111031_03_003[2],CharaPos111031_03_003[3]})
set_rot(Actor002,{0,CharaPos111031_03_003[4],0})
wait_time(0.3)
setup_small_camera_start(CUT_17)
PlayActionDirect(Actor001,"to SitLookUp05_Loop")
PlayActionDirect(Actor002,"to SitLookDown01_loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"startTalking0040")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:でも忘れないでおくね<br>私はずっと覚えておくから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380019")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:なんの話だ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380020")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_18)
PlayActionDirect(Actor001,"SitLookDown02")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 1.0,false,false)
set_scale_image(20,20)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:私はずっと覚えている
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380021")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
se_play("SE_ADV_MA_01C900_38_Baby")
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_19)
hide_image(0.5)
PlayActionDirect(Actor001,"to SitLookDown03_Loop")
PlayActionDirect(Actor002,"to SitLookDown02_loop")
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_20)
set_pos(chair02,{0, -20, 0})
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
 PlayActionDirect(Actor002,"startTalking020")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★マルディサント★★:おっと、こっちも起きちまったな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C900_380023")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"startTalking0050")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:あれ？おなかすいちゃった？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C900_380024")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor001,"SitLookDown03PickUp01")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0,1.0)
wait_time(1.0)
close_textbox_base()
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力

stillAnime.SetActive(true)
local signal = play_ui_timeline_controller_in(stillAnime)
fadein(0.5)
while signal.IsProccessing() do
    coroutine.yield()
end
open_textbox_base()
wait_time(0.2)
-- ▲直接出力

	--★★ディナタン★★:マァル、一緒にいてくれてありがとう
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","MA_01C900_380025")

	change_face(Actor001,"Smile")

	--★★ディナタン★★:これからもずっと一緒にいてね
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","MA_01C900_380026")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_ui_effect_preload("content_still_10104011_anim", "10104011_StillAnim", nil, nil, nil, "Root")
	InitializeLoad_Preload()
	load_area_scene_preload(111031)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	system.PreLoadRequest(CameraAssetBundleName111031_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
