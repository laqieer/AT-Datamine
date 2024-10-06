-- このluaスクリプトは、CO_101037_0101_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_06","110011_06_h")
Include("content_adv_advsmall_110011_06","Template110011_06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_06_018,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_018)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_06_019,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_019)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_06_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_017)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_06_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_06_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_06_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_016)
	InitializeTemplateRandomCamera110011_06()
	InitializeTemplate110011_06()
-- ▼直接出力
set_enable_auto_lookat_all(false)
turn_chara(Actor003,-40,0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head",0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor004,Actor002,"J_Head",0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor002,"J_Head",0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor002,"J_Head",0)
keep_ik_lookat(Actor006,Actor002,"J_Head",0)
-- ▲直接出力
-- ▼直接出力
lookAtWeight = {0.8, 0.08, 0.7, 0.6}

-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラシア！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01010102")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:えっ、ノワール！？<br>どうしてここにいるんですか！？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01010103")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしてって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01010104")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力

	--★★ヴェルナルス★★:…ラシア
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_01010106")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:ここはお前の教室ではない
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_01010108")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:間違えましたっ、すみませんっ！！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01010110")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor002)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01010112")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01010114")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ラシアが落とし物をしていったので<br>届けてきてもいいですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01010115")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:…許可する
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","CO_101037_01010117")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ありがとうございます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01010118")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ1_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
lookAtWeight = {0.8, 0.08, 0.7, 0.6}
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_06)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
