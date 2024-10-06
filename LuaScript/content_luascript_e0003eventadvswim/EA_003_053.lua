-- このluaスクリプトは、EA_003_053.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_01","111012_01_h")
Include("content_adv_advsmall_111012_01","Template111012_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-358.4,CharaPos111012_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_005)
	Camera002 = SetTemplate("Actor002",-24.7,CharaPos111012_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_003)
	InitializeTemplateRandomCamera111012_01()
	InitializeTemplate111012_01()
-- ▼直接出力
load_image("still001", "content_still_10305006_image", "103050060_StillImage")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.8, 0.1, 0.4, 0.2,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101001","001","101001001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力

	--★★ギネヴィア★★:何度里帰りしても同じね<br>もうなんにも残ってない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530002")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("still001", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ギネヴィア★★:キャメリアードの土地も<br>あなたがこうやって力を吸い取ったの…？
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_003_0530004")


	--★★ティルフィング★★:………
	Talk(Actor003,"CHRNAME_TYRFING","simple","N","EA_003_0530005")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)

setup_small_camera_start(Camera001)
hide_image()
 
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

 wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…わたしが赤ちゃんだった頃…ううん<br>それよりもっと前
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530008")


	--★★ギネヴィア★★:この国はもっと豊かな国だったって<br>パパが言ってた
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530009")


	--★★ギネヴィア★★:でもだんだん鉱石が採れなくなって<br>どんどんじり貧になっちゃって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:結局、全部無くなっちゃった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:…全部じゃないでしょう
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0530012")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:思い出は守れたわ<br>あなたががんばったから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0530013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,60.5,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
wait_time(0.2)
lookat_delay_weight(Actor001, 0.8, 0.1, 0.4, 0.2,0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…うん<br>わたしだけがんばったんじゃないけど
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:…「限られた資源は有効に使おう」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530015")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","悩む")
-- ▲直接出力

	--★★ギネヴィア★★:ティルフィングはずっとそうしてきたのよね<br>自分にできるやりかたで
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530016")


	--★★ギネヴィア★★:だったら、わたしもそうすべきかなって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:あなたのできるやりかたって、例えば？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0530018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:――飾り立てることなら、得意よ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_003_0530020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("still001", "content_still_10305006_image", "103050060_StillImage")
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101001","001","101001001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
