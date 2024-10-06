-- このluaスクリプトは、CO_101037_0904.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor003,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("104000130", "content_still_10400013_image", "104000130_StillImage")
-- ▲直接出力
-- ▼直接出力
huton = setup_prop_object(10107002)
set_pos(huton,{3.34,0.1,1.41})
set_rot(huton,{0,270,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:えっと、えーっと…<br>こ、こんにちは、ヴェルナルス様！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09040002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:ああ。元気そうだな
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_09040003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はいっ、元気です！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラシア★★:…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09040005")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力

	--★★ヴェルナルス★★:…
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_09040006")

-- ▼直接出力
wait_time(1.0)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ラシア<br>なにか渡すものがあるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09040008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力

	--★★ラシア★★:あっ、そう、そうでした！<br>ヴェルナルス様、これ…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09040009")

-- ▼直接出力
ShowImageItem(104000130)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "納得")
-- ▲直接出力

	--★★ヴェルナルス★★:ヨーグルトか…<br>ひとつもらおう
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_09040010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:はい、どうぞ！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09040011")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
se_play("SE_ADV_CO_101037_0904_Tableware_Move")
wait_time(2.1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
PlayPartVoice("ヴェルナルス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴェルナルス★★:うまいな
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_09040013")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力

	--★★ラシア★★:本当ですか？<br>よかった…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09040014")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
setup_small_camera_start(Camera001)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…あまり長居しちゃ悪いし、<br>俺はここで失礼するよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09040015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:頑張れ、ラシア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09040017")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:あ…はい！今日は一緒に来てくれてありがとう<br>また明日、学園で！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09040019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:先生もお大事に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09040020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴェルナルス★★:ああ。わざわざすまなかったな
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_09040021")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor001)
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
turn_lookat(Actor002,Actor003,0)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000130", "content_still_10400013_image", "104000130_StillImage")
setup_prop_object_preload(10107002)
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
