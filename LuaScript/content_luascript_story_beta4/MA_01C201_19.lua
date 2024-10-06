-- このluaスクリプトは、MA_01C201_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
force_eyesync(Actor002,"Close")
reserve_eyesync(Actor002,"Close")
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.055
--setup_small_camera_resetting(Actor002,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
--set_rot(Actor002,{2,CharaPos110141_02_001[4],0})
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
 --keep_ik_lookat(Actor001, Actor002, "J_Head")
 --lookat_delay_weight(Actor001, 0.9, 0, 0.5, 0.2,1.0)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002,1)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115150)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:う…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C201_190002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
reserve_eyesync(Actor002,"Auto")
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:ギネヴィアさん！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_190004")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:よかった、目を覚ましてくれた…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_190005")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ディナタン…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C201_190006")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…そっか。わたし、倒れちゃったのね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C201_190007")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:無理しないでください！<br>すごく体が冷えてて――
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_190009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:そうだ！私、ガレスさんに頼んで、<br>なにかお腹に優しいものもらってきますね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_190010")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
set_animationcontroller(Actor001, "Chr_501_01_StdController", "to Std_Loop")
wait_time(0.8)
setup_small_camera_start(RndCamera005)
lookat_delay_weight_reset(Actor001 , 1)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,270,0.5)
wait_time(0.5)
slidemove(Actor001,{-1.86,0, 2.84}, 5)
wait_time(5.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end(Camera002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
SkipOffsetCamera(Camera002)
-- ▲直接出力

	--★★ギネヴィア★★:………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C201_190012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115150)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
