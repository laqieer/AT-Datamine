-- このluaスクリプトは、MA_01A112_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
load_image("10103035", "content_still_10103035_image", "101030350_StillImage")
RndCamera001 = RndCamera005
-- ▲直接出力
-- ▼直接出力
ExCamera = set_camera({2.348, 2.143, 0.96809,   47.71964, 71.80952, 358.5668,   18.79701})
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor001,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
CameraEx02 = RndCamera001
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera007
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
DontChangeRandomCamera(true)
 --PlayPartVoice("エレイン", "苦しみ")
-- ▲直接出力

	--★★エレイン★★:…痛いな
	Talk(Actor001,"CHRNAME_ELAINE","speech","N","MA_01A112_010002")


	--★★エレイン★★:徒花だ、私
	Talk(Actor001,"CHRNAME_ELAINE","speech","N","MA_01A112_010003")

-- ▼直接出力
on_camera(CameraEx02)
-- ▲直接出力

	--★★エレイン★★:徒花のくせに、枯れるんだ
	Talk(Actor001,"CHRNAME_ELAINE","speech","N","MA_01A112_010005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力

	--★★ラヴェイン★★:…エレイン、水を変えましょうか<br>傷口に熱がこもってはいけませんからね
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_010007")

-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:…ごめんなさい、お兄ちゃん
	Talk(Actor001,"CHRNAME_ELAINE","speech","N","MA_01A112_010009")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
on_camera(Camera002)
-- ▲直接出力

	--★★ラヴェイン★★:エレイン、は誇らしい働きをしました<br>卑下することなんてなにひとつないんですよ
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_010010")


	--★★エレイン★★:………笑ってなくても、ごめんね
	Talk(Actor001,"CHRNAME_ELAINE","speech","N","MA_01A112_010011")

-- ▼直接出力
on_camera(RndCamera004)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラヴェイン★★:…エレイン？
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_010013")

-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力

	--★★エレイン★★:キズがひきつれて痛いの<br>しゃべるたびにすごく痛いの
	Talk(Actor001,"CHRNAME_ELAINE","speech","N","MA_01A112_010014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10103035", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
voiceSignalS = voice_play("VO_MA_01A112_010015")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)

fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10103035", "content_still_10103035_image", "101030350_StillImage")
RndCamera001 = RndCamera005
CameraEx02 = RndCamera001
RndCamera001 = RndCamera007
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
