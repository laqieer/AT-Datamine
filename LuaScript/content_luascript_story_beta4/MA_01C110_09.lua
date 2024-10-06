-- このluaスクリプトは、MA_01C110_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_002)
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_090002")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:夢…？<br>父さん……？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_090003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:同じ夢を見ていたのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_090004")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:わからない<br>今も、もしかしたら夢…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_090005")


	--★★ディナタン★★:でも私、忘れてたんだね…<br>父さんのこと……
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_090006")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…思い出したのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_090007")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:父さんは聖遺物化したってことだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_090008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…ああ、そうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_090009")


	--★★ディナタン★★:大事なことを伝えていないって<br>父さん言ってた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_090010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName114101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
