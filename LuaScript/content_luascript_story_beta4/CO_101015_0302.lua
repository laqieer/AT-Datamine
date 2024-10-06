-- このluaスクリプトは、CO_101015_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",215,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
Hide(Actor003)
keep_ik_lookat(Actor001,Actor002, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101040","001","101040001")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ああ、集中が途切れてしまった！<br>そろそろ息抜きのタイミングだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03020002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:よし、ノワール！<br>そうと決まればさっそくB級グルメを食べに…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03020003")

-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ2D★★:行かせると思うか？
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101015_03020004")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor003,Camera003,EntryData110051_01_02,CameraAssetBundleName110051_01,CameraPos110051_01_102)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.6, 0.2, 0.9, 0.6} , 1)
keep_ik_lookat(Actor001, ケイ, "J_Head")
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.2, 0.8, 0.6} , 1)
keep_ik_lookat(Actor002, ケイ, "J_Head")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:に、義兄さん！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03020005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:お前がそう言いだす頃だと思ってな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03020007")

	change_face(Actor002,"Anger")

	--★★アーサー★★:ぐ、ぐぬう…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03020008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:お前と何年の付き合いだと思っている？<br>あまり私を見くびるなよ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03020009")

	change_face(Actor003,"Anger")

	--★★ケイ★★:アーサー…今日という今日は<br>イスにくくり付けてでも仕事をさせるからな！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03020010")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:く…！ここまでか…！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_03020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ケイ★★:悪いが、貴公も出て行ってくれるか<br>仕事に専念させたいのでな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_03020013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03020014")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ3_3")
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101040","001","101040001")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
