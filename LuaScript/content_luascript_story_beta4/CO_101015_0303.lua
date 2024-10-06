-- このluaスクリプトは、CO_101015_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_003)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001, "J_Head")
keep_ik_lookat(Actor001,Actor002, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:ノワール様<br>ひとつお願いがあるのですが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_03030002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:マーリンさん？<br>なんですか、お願いって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:これを
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_03030004")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:これは…お金？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03030005")


	--★★マーリン★★:そのお金でホットドッグを<br>買ってきていただきたいのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_03030006")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは構いませんけど…いいんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03030007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:ええ。ああいったものばかり食べていては<br>栄養が偏るのでよくないとは思いますが…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_03030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:…多分、もう少ししたら<br>禁断症状が出ると思いますので
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_03030009")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…？<br>わかりました、行ってきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_03030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ3_4")
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
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
