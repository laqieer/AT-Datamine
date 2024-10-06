-- このluaスクリプトは、EA_066_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_002)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:青春、か…<br>縁遠い言葉過ぎていまいちピンと来ないな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0130004")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0041")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:だが…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0130005")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
