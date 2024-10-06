-- このluaスクリプトは、CO_101026_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力

	--★★ディンドラン★★:パー坊…パーシヴァル様<br>これからどこかへおでかけ？
	Talk(Actor005,"CHRNAME_DINDRANE","speech","L","CO_101026_03020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:ああ<br>ちょっとログレス市街まで行ってくる
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_03020003")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ディンドラン★★:ハンカチは持った？<br>雨が降るといけないから傘もね。それから…
	Talk(Actor005,"CHRNAME_DINDRANE","speech","L","CO_101026_03020004")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ああもう、うるさいな！<br>いつまでもボクを子供扱いするな！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_03020005")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,270,0.5)
wait_time(0.5)
slidemove(Actor002,{8.37,0, -24.965}, 3)
wait_time(3.0)
PlayActionDirect(Actor003,"to Run")
turn_chara(Actor003,270,0.3)
PlayActionDirect(Actor004,"to Run")
turn_chara(Actor004,270,0.3)
wait_time(0.3)
slidemove(Actor003,{7.19,0, -25.465}, 2)
slidemove(Actor004,{7.16,0, -26.24}, 2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2.5)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor001,"J_Head")
lookat_weight(Actor005,0.8,0.5,0.5,0)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.5)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ディンドラン★★:ノワールさん、あの…<br>パー坊、いえパーシヴァル様と…
	Talk(Actor005,"CHRNAME_DINDRANE","speech","L","CO_101026_03020007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:わかってますよ、仲良くですよね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_03020009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ3_3")
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
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
