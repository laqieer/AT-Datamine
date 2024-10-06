-- このluaスクリプトは、MA_01A900_57.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:問題は喪ったことではありませんよね
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A900_570002")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:多くを喪ったとしても<br>託されたものをこぼさずにやってきた
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A900_570004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラヴェイン★★:思い出はまだ<br>生き続けています
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A900_570005")

-- ▼直接出力
CloseTalkWindow()	
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_animationcontroller(Actor002,"Chr_009_01_StdController","to Std_Loop")
Camera002 = setup_small_camera_resetting(Actor002,CharaPos110061_02_003,CameraPos003)
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
wait_time(1.0)
setup_small_camera_start(RndCamera003)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラヴェイン★★:責任に囚われ続けることはありません<br>悲しみばかりに目を向け続けることもない
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A900_570007")


	--★★ラヴェイン★★:不躾なお願いではありますが<br>…ノワール君
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A900_570008")

-- ▼直接出力
setup_small_camera_end(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:愛されて生きることを避けないでください
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A900_570009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
