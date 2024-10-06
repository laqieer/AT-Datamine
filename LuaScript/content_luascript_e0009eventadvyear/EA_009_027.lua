-- このluaスクリプトは、EA_009_027.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114071_01","114071_01_h")
Include("content_adv_advsmall_114071_01","Template114071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",130,CharaPos114071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_004)
	InitializeTemplateRandomCamera114071_01()
	InitializeTemplate114071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:ふ～、いいお湯でしたね～
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0270002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ。広い風呂にゆっくり浸かると<br>気分がいいよなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0270003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Smile")

	--★★ディナタン★★:～♪
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0270004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もしかしたらリラックスすることで<br>声が出るようになるかもと思って来てみたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0270005")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★ディナタン★★:………
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0270006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:さすがにそう上手くはいかないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0270008")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0047")
-- ▲直接出力

	--★★エレイン★★:でもリフレッシュはできましたよ！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0270009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:他の場所にもいってみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0270010")

-- ▼直接出力
reserve_next_script("シナリオイベクエ/新年24/2話_ADV_4_5")
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
	load_area_scene_preload(114071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
