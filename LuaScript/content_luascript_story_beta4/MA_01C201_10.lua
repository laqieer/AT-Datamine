-- このluaスクリプトは、MA_01C201_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("103040020", "content_still_10304002_image", "103040020_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("VO_story01")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000012)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101011","001","101011001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そういえば、学園に来て初めて<br>遠出をしたのもキャメリアードだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_100002")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:祭壇での儀式のこと？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_100003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。右も左もわからない俺に<br>道中、ギネヴィアがいろいろ教えてくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力

	--★★ノワール★★:買い上げた傭兵があんまりにも<br>なにも知らないから驚いたのかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_100005")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103040020", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ギネヴィア★★:だからわたしは<br>あなたに期待してるわけ
	Talk(Actor006,"CHRNAME_GUINEVERE","simple","N","MA_01C201_100007")


	--★★ギネヴィア★★:旅路と帰路を拓く<br>派手な飾りになって欲しいなって
	Talk(Actor006,"CHRNAME_GUINEVERE","simple","N","MA_01C201_100008")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 --エフェクト終了
hide_image()
lookat_delay_weight_reset(Actor002 , 1)
turn_chara(Actor002, -6.743, 0)
set_enable_auto_lookat(Actor001, false)

 --スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さんのコート、繕っておいたの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_100010")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_100011")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:だから、きっとよく目立つよ<br>遠くからでも見つけられる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_100012")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ああ<br>見つけてくれるといいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_100013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103040020", "content_still_10304002_image", "103040020_StillImage")
preload_sound("VO_story01")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000012)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
