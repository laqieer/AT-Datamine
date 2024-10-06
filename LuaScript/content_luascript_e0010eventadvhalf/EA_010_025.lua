-- このluaスクリプトは、EA_010_025.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation06","DuelCommonFormation06_h")
Include("content_adv_advsmall_duelcommonformation06","TemplateDuelCommonFormation06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",90,CharaPosDuelCommonFormation06_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPosDuelCommonFormation06_014,CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_014)
	Camera003 = SetTemplate("Actor003",120,CharaPosDuelCommonFormation06_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_003)
	InitializeTemplateRandomCameraDuelCommonFormation06()
	InitializeTemplateDuelCommonFormation06()
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
CUT_14 = cat_template_camera("P14_Cam", Actor002)
CUT_16 =  cat_template_camera("P16_Cam")
CUT_22 =  cat_template_camera("P22_Cam")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010170", "content_still_10101017_image", "101010170_StillImage")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001=CUT_14
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{0.836, 0.011, 14.873,   110})
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
-- ▼直接出力

on_screencolor(IMAGE_COLOR, -100, -100)
show_image("101010170", 0.0, 0.0, 0.0) --回想スチルを表示
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Prison")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101220011)
	Actor001 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 --スチル終了
 hide_image() 
 --エフェクト終了
off_cameraframe()
off_screencolor()
 wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
--暗転明け
-- ▲直接出力

	--★★レーヴァテイン★★:………<%player>？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250007")

-- ▼直接出力

play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0250009")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT_16)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Prison")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:…ログレスで起きたことや、そこにいたひと…<br><dot>それに似たなにか</dot>を見られれば──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250011")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:<ruby=ノワール>過去の継承者</ruby>のことは<br>思い出せるのかもしれないわね
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250013")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:けど…つらかった思い出や<br>痛んだ傷痕を無理して辿る必要なんてない
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250015")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:あなたには、ないよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250016")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
setup_small_camera_start(CUT_22)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0060")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:私たちは<br>バルバロイに人生を奪われた
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★レーヴァテイン★★:だからバルバロイは１匹残らず私が殺す
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250018")


	--★★レーヴァテイン★★:戦う理由なんて<br>それでいい
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250019")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:けど、あなたには今<br>守るべき思い出なんてない
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250021")

-- ▼直接出力
CloseTalkWindow()
--立ち去るレーヴァテイン
 PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,270,0.3)
wait_time(0.3)
slidemove(Actor001,-7.3, 0, 13.86,6)
wait_time(1.3)
 PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,230,0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ロンギヌス★★:…
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0250022")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:戦う意味とか、どこにもないよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0250024")

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
load_image_preload("101010170", "content_still_10101017_image", "101010170_StillImage")
preload_sound("BGM_ADV_Prison")
	InitializeLoad_Preload()
	load_duel_scene_preload(101220011)
	InitializeCharacter_3D_Preload("101002","001","101002001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation06)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
