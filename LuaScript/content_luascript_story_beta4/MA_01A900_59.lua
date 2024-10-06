-- このluaスクリプトは、MA_01A900_59.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",98.28,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",-202,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:紅蓮の炎の影だけが
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590003")

	PlayAction(Actor002,"to  Std_No")

	--★★ギネマウア★★:瞼に焼き付いて、離れません
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:それはもはや名も知らぬ誰かが<br>私に遺してくれた火傷──
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590006")

	change_face(Actor002,"Smile")

	--★★ギネマウア★★:それは熱烈な愛でしたよね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:…はい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_590009")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_end(Camera002)
wait_time(1.0)
SkipOffsetCamera(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:少しお暇をいただきます
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590010")

	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:子供のころからどんな日々を過ごしてきたか<br>誰と一緒にいたのか、思い返しながら
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590012")

	change_face(Actor002,"Smile")

	--★★ギネマウア★★:コルベニックへ向かいます<br>あの子がつけてしまったキズを塞ぎに
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:…そのあとは、少し遠くへ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590014")


	--★★ギネマウア★★:やりのこしたことが<br>あるような気がしてなりませんので
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:なぜでしょうね<br>昔は外出に興味などなかったのですが
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590017")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:いまはただ、恋しくて
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_590019")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to Bow")
wait_time(2.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-202.6,0.6)
wait_time(0.6)
setup_small_camera_start()
turn_lookat_position(Actor001,-0.478, 0.128, 17.31,0)
slidemove(Actor002,{-0.478, 0.128, 17.31},2.0)
wait_time(2.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
