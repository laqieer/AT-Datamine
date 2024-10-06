-- このluaスクリプトは、MA_01C201_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_01","111012_01_h")
Include("content_adv_advsmall_111012_01","Template111012_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_006)
	Camera003 = SetTemplate("Actor003",-6,CharaPos111012_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_005)
	InitializeTemplateRandomCamera111012_01()
	InitializeTemplate111012_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:お前は本当にそれでいいのか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","R","MA_01C201_240002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:…これでいいと思ってます<br>私は兄さんの剣だから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_240003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:間違っているとは思わないのか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","R","MA_01C201_240004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力

	--★★ディナタン★★:思いません
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C201_240005")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★アーサー★★:そうか、だとしたら聖遺物となる前に<br>今ここで殺したほうが幸せかもしれん
	Talk(Actor002,"CHRNAME_ARTHUR","speech","R","MA_01C201_240006")

	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:約束が違うわ、アーサー
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","R","MA_01C201_240008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:私にノワールとディナタンを<br>一緒に殺させてくれる約束よ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","R","MA_01C201_240009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:私がちゃんと戦って始末をつける<br>あなたがちゃんと始末をつけたいように
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","R","MA_01C201_240011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:そうだったな、約束だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","R","MA_01C201_240012")

-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,74,0.8)
wait_time(0.8)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:そう。私たちの約束よ<br>行きましょう、ディナタン
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","R","MA_01C201_240013")

-- ▼直接出力
wait_time(0.2)
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
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
