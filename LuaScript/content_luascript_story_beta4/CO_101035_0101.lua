-- このluaスクリプトは、CO_101035_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_rot(Actor002,{0,130,0})
set_pos(Actor003,{10,0,-26.8})
set_rot(Actor003,{0,80,0})
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:リリアーナじゃないかどうした、なにか気になるものがあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01010002")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to  Std_Joy")
turn_chara(Actor002,-110,0.3)
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:…えっ！？ひゃっ、ノッ、ノワールさん！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんかビックリさせちゃったみたいだなごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01010005")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力

	--★★リリアーナ★★:わっ、私こそごめんなさい！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01010006")

	PlayAction(Actor002,"to Bow")

	--★★リリアーナ★★:それじゃあ、私はこれでっ！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_01010008")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor002,"to Run")
SkipDefaultMotion(Actor002)
turn_chara(Actor002,90,0.5)
slidemove(Actor002,{20,0,-25.5},2)
wait_time(1.0)
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:えっ？あ、おい！俺の質問の答え…は…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01010009")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{11.6,0,-26.3},1)
wait_time(1.0)
PlayActionDirect(Actor003,"to Std_Loop")
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.7)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:気になるわよね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01010011")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,200,0.3)
set_common_look_at(Actor001,Actor003)
Hide(Actor002)
-- ▲直接出力

	--★★ノワール★★:うわっ！…誰かと思ったらクレアか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01010012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:あとをつけましょう
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★クレア★★:見失うわ、急いで
	Talk(Actor003,"CHRNAME_CLARE","speech","L","CO_101035_01010015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:そこまでするつもりはなかったんだけど…まぁ、行ってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_01010016")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ1_2")
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
