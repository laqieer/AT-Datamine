-- このluaスクリプトは、EA_072_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:ひとりでダイジョブだろ。あいつなら
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_072_0210003")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:で、でも、心配じゃん<br>ノワールには、もう──
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_072_0210004")


	--★★ラグネル★★:<ruby=キラーズ>武器</ruby>が、ないんだよ？
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_072_0210006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0051")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:…あいつはさ、俺たちと出会う前から<br>傭兵団のヒーローだったンだろ？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_072_0210008")

	change_face(Actor002,"Normal")

	--★★ラグネル★★:………ダイジョブ、かな
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_072_0210010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:武器がなくても、あいつはさ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_072_0210011")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
