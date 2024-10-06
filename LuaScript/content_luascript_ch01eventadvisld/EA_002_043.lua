-- このluaスクリプトは、EA_002_043.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("103050100", "content_still_10305010_image", "103050100_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
wait_time(1.0)
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103050100", 0.0, 0.0, 0.0,true,false)
PlayActionDirect(Actor001,"to Std_Loop")
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
wait_time(1.5)
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
--エフェクト終了
hide_image()
 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "納得")
-- ▲直接出力

	--★★トリスタン★★:狙い通りか
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","EA_002_043002")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★トリスタン★★:イカサマを見抜けず何度も負けるイゾルデを<br>良いカモだと信じ込ませ──
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","EA_002_043003")

-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:彼女を舐め切った状態で<br>バレバレのイカサマ込みの大勝負を仕掛けさせる
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","EA_002_043004")


	--★★トリスタン★★:そしてコインの出目がどうあれ<br>商人の不正をあばき、勝負から降ろす
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","EA_002_043005")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★トリスタン★★:…賭けとしてはどうかと思うけど──
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","EA_002_043006")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050100", "content_still_10305010_image", "103050100_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
