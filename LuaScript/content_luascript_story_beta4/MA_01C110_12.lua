-- このluaスクリプトは、MA_01C110_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
Include("content_adv_advsmall_114101_03","114101_03_h")
Include("content_adv_advsmall_114101_03","Template114101_03_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_003)
	Camera002 = SetTemplate("Actor002",115,CharaPos114101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114101_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114101_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_008)
	Camera008 = SetTemplate("Actor008",nil,CharaPos114101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_006)
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
disp_calendar(false)
disableTextBox = true
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
movie_load("MA_01C110_12")
-- ▲直接出力
-- ▼直接出力
movie_set_active(true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor001, 0.8, 0.5, 0.5, 0.2,1.0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,169.533,0)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114101_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114101_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114101_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114101_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114101_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114101_03_013,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_013)
	Camera008 = SetTemplate("Actor008",nil,CharaPos114101_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_03,CameraPos114101_03_015)
	InitializeTemplateRandomCamera114101_03()
	InitializeTemplate114101_03()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor001, 0.8, 0.5, 0.5, 0.2,1.0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
disp_calendar(false)
disableTextBox = true
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,169.533,0)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","002","101017002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
movie_play()
movie_wait_playing()
-- ▲直接出力
-- ▼直接出力
movie_stop()
-- ▲直接出力
-- ▼直接出力
hide_image(4.0)
-- ▲直接出力
-- ▼直接出力
wait_time(4.0 + MOVIE_AFTER)
disableTextBox = false
open_textbox_base()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ねえ、私たち…<br>もうどれだけこの森にいるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_120002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…１ヶ月…いや３ヶ月…1年…？<br>もっとかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_120004")


	--★★ディナタン★★:もしかしてもうここから出られないんじゃ…<br>だとしたら
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_120005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:ねえ私たち…間違ってる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_120006")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ディナタン★★:兄さん――…私たち、なんだっけ――<br>なにを、すればいいんだっけ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_120007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:しっかりするんだ、ディナタン<br>俺たちは間違ってなんかいない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_120009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:お前は俺の武器で――俺の家族だ<br>俺は必ずお前を守る
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_120010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:その為にも、この森を出なきゃならない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_120011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Serious")

	--★★ノワール★★:必ずふたりで――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_120012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.7)
se_play("SE_ADV_MA_01C110_12_Crash_Crystal")
wait_time(2.3)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
wait_time(1.9)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Invasion2")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:…光――！？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C110_120014")

	close_cutin()
	open_cutin(1,1)
	on_cutin(1,Actor002,"Surprise")

	--★★ディナタン★★:森が、開いたの…！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","N","MA_01C110_120015")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
close_cutin()
template2()
setup_small_camera_start(R_Cam90)
SkipDefaultMotion(Actor002)
SkipDefaultMotion(Actor001)
PlayAction(Actor002,"to  Std_Surp")
PlayAction(Actor001,"to  Std_Surp")
Appear(Actor006)
Appear(Actor007)
Appear(Actor008)
turn_lookat(Actor001,Actor006,0)
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",1.0)
wait_time(0.5)
-- ▲直接出力
	close_cutin()
	change_face(Actor002,"Sad")

	--★★ディナタン★★:今まで森のなかに<br>バルバロイはいなかったのに…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_120017")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Serious")

	--★★ノワール★★:森から抜けられるかもしれない！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_120018")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ディナタン★★:でもこんなにたくさんのバルバロイ…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_120019")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
wait_time(0.5)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★マルディサント★★:ディーナ！
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","N","MA_01C110_120021")

-- ▼直接出力
Appear(Actor003)
Appear(Actor004)
Appear(Actor005)
setup_small_camera_end(R_Cam90)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
turn_lookat(Actor001,Actor003,0)
turn_lookat(Actor002,Actor003,0)
turn_lookat(Actor003,Actor002,0)
turn_lookat(Actor001,Actor003,0)
turn_lookat(Actor001,Actor003,0)
turn_lookat(Actor004,Actor006,0)
turn_lookat(Actor005,Actor006,0)
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
close_cutin()
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:マァル！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_120022")

-- ▼直接出力
setup_small_camera_start(R_Cam01)
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★マルディサント★★:ようやく見つけた！
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_120023")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Anger")

	--★★ガレス★★:マルディサント、感動の再会はあとだ！<br>…こいつらをぶちのめすぞ！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_120025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_Invasion2")
disableTextBox = true
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
movie_load_preload("MA_01C110_12")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_Invasion2")
disableTextBox = true
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","002","101017002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114101_01)
	system.PreLoadRequest(CameraAssetBundleName114101_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
