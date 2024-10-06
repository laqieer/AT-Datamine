-- このluaスクリプトは、CO_101015_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…といったものの<br>アーサーのやつ、どこに行ったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04030002")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:いつものホットドッグ屋にもいないし<br>町の人たちも知らないって言うし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04030003")

-- ▼直接出力

setup_small_camera_end(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:アーサー様をお探しですか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_04030005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなんです。どこにもいなくて<br>ケイが探してるってのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04030006")

-- ▼直接出力
PlayPartVoice("マーリン", "納得")
-- ▲直接出力

	--★★マーリン★★:そうですか…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_04030007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:…恐らく、屋上にいるかと
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_04030009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ4_4")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
