-- このluaスクリプトは、MA_01A111_43.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_01","111013_01_h")
Include("content_adv_advsmall_111013_01","Template111013_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SleepController","to Std_Loop",CameraAssetBundleName111013_01,CameraPos111013_01_002)
	InitializeTemplateRandomCamera111013_01()
	InitializeTemplate111013_01()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Kneeling")
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
local EfPos = get_pos(Actor002)
set_pos(Ef_Aura_Enemy , EfPos)
on_active(Ef_Aura_Enemy) 
play_particle(Ef_Aura_Enemy)
DontCameraOffset(Actor002)
DontChangeRandomCamera(true)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
lookat_delay_weight(Actor002, 0.7, 0.04, 0.5, 0.2,0.5)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フレン★★:ねむれ、ねむれ、もういたくないよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_430002")

-- ▼直接出力
 --PlayPartVoice("ローラ", "落胆")
-- ▲直接出力

	--★★ローラ★★:おねえちゃん
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_430003")


	--★★フレン★★:ねむれ、ねむれ、あなたは夢をみる
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_430004")


	--★★ローラ★★:おねえちゃん
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_430005")


	--★★フレン★★:ねむれ、ねむれ、目を閉じればすぐ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_430006")

-- ▼直接出力
 --PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ローラ★★:おねえちゃん、だいすき
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_430007")


	--★★フレン★★:ねむれ、ねむれ、もういたくないよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_430008")

	change_face(Actor001,"Sad")

	--★★フレン★★:ねむれ、ねむれ、起きたときにはもう
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_430009")


	--★★フレン★★:すべて、わすれて
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_430010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Start_and_Finish", false, true)
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName111013_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
